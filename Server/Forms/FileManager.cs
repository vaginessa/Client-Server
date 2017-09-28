using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace Server.Forms
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
        }
        public void SetTitle(string ip)
        {
            this.Text = "Client: " + ip;
        }
        public Socket Client { get; set; }
        Thread FileManagerTR;
        private void loadLocalDrives()
        {
            string[] drives = Classes.LocalFileManager.GetDrives();
            txtdrive_local.Items.Clear();
            txtdrive_local.BeginUpdate();
            foreach (string t in drives)
            {
                txtdrive_local.Items.Add(t);
            }
            txtdrive_local.EndUpdate();
        }
        private void loadEntries(string path)
        {
            string entries = Classes.LocalFileManager.io_getEntries(path);
            try
            {
                flist_local.Items.Clear();
                flist_local.BeginUpdate();
                string[] b = entries.Split('\n');
                //=================================
                ListViewItem li = new ListViewItem();

                int i = 0;
                //================================
                foreach (string t in b)
                {
                    if (t.Length < 5) continue;
                    string[] item = t.Split('|');
                    if (i == 0)
                    {
                        string root = Directory.GetParent(item[5]).ToString();
                        try
                        {
                            root = Directory.GetParent(root).ToString();
                        }
                        catch
                        {

                        }
                        li.Text = "...";
                        li.SubItems.Add("-");
                        li.SubItems.Add("Directory");
                        li.SubItems.Add("");
                        li.SubItems.Add("");
                        li.SubItems.Add(root);
                        li.ImageIndex = 1;
                        flist_local.Items.Add(li);
                    }
                    i = 1;
                    li = new ListViewItem();
                    li.Text = item[0];
                    li.SubItems.Add(item[1]);
                    li.SubItems.Add(item[2]);
                    li.SubItems.Add(item[3]);
                    li.SubItems.Add(item[4]);
                    li.SubItems.Add(item[5]);
                    if (item[2] == "File")
                    {
                        li.ImageIndex = 0;
                    }
                    else
                    {
                        li.ImageIndex = 1;
                    }
                    flist_local.Items.Add(li);
                }
                flist_local.EndUpdate();

            }
            catch
            {
                flist_local.EndUpdate();

            }
        }
        //========================================================================================================= Remote File Manager Functions
        private void loadRemoteDrives()
        {
            if (FileManagerTR != null)
            {
                if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
            }
            FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.GetRemoteDrives(Client); });
            FileManagerTR.IsBackground = true;
            FileManagerTR.Start();
        }
        public void loadRemoteEntries(string entries)
        {
            flist_remote.Invoke(new MethodInvoker(
     delegate
     {
         try
         {
             flist_remote.Items.Clear();
             flist_remote.BeginUpdate();
             string[] b = entries.Split('\n');
             //MessageBox.Show(b.Count().ToString());
             //=================================
             ListViewItem li = new ListViewItem();
             int i = 0;
             //================================
             foreach (string t in b)
             {
                 if (t.Length < 5) continue;
                 string[] item = t.Split('<');
                 if (i == 0)
                 {
                     string root = Directory.GetParent(item[5]).ToString();
                     try
                     {
                         root = Directory.GetParent(root).ToString();
                     }
                     catch
                     {

                     }
                     li.Text = "...";
                     li.SubItems.Add("-");
                     li.SubItems.Add("Directory");
                     li.SubItems.Add("");
                     li.SubItems.Add("");
                     li.SubItems.Add(root);
                     li.ImageIndex = 1;
                     flist_remote.Items.Add(li);
                 }
                 i = 1;
                 li = new ListViewItem();
                 li.Text = item[0];
                 li.SubItems.Add(item[1]);
                 li.SubItems.Add(item[2]);
                 li.SubItems.Add(item[3]);
                 li.SubItems.Add(item[4]);
                 li.SubItems.Add(item[5]);
                 if (item[2] == "File")
                 {
                     li.ImageIndex = 0;
                 }
                 else
                 {
                     li.ImageIndex = 1;
                 }
                 flist_remote.Items.Add(li);
             }
             flist_remote.EndUpdate();

         }
         catch
         {
             flist_remote.EndUpdate();
         }
     }
     ));


        }
        //========================================================================================================= Remote File Manager EXE
        public void loadRemoteDrives_EXE(string parameters)
        {
            string[] d = parameters.Split('\n');
            txtdrives_remote.Invoke(new MethodInvoker(
                   delegate
                   {
                       try
                       {
                           txtdrives_remote.Items.Clear();
                           foreach (string t in d)
                           {
                               if (t.Length < 2) continue;
                               txtdrives_remote.Items.Add(t);
                           }
                       }
                       catch
                       {
                       }
                   }
                   ));
        }
        //=========================================================================================================
        private void FileManager_Load(object sender, EventArgs e)
        {
            loadLocalDrives();
            loadRemoteDrives();
        }

        private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void txtdrive_local_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtpath_local.Text = txtdrive_local.Text;
            loadEntries(txtdrive_local.Text);
        }

        private void flist_local_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (flist_local.SelectedItems.Count != 0)
            {
                ListViewItem i = flist_local.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    txtpath_local.Text = fname;
                    loadEntries(fname);
                }
            }
        }

        private void btnreloaddrive_remote_Click(object sender, EventArgs e)
        {
            loadRemoteDrives();
        }

        private void btnreloadpath_remote_Click(object sender, EventArgs e)
        {
            string path = txtpath_remote.Text;
            if (path == "") return;
            if (FileManagerTR != null)
            {
                if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
            }
            FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.GetRemoteEntries(Client, path); });
            FileManagerTR.IsBackground = true;
            FileManagerTR.Start();
        }

        private void txtdrives_remote_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtpath_remote.Text = txtdrives_remote.Text;
            btnreloadpath_remote_Click(null, null);
        }

        private void flist_remote_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    txtpath_remote.Text = fname;
                    btnreloadpath_remote_Click(null, null);
                }
            }
        }

        private void btn_newfolder_Click(object sender, EventArgs e)
        {
            Forms.InputBox i = new InputBox("Enter name:");
            if (i.ShowDialog() == DialogResult.OK)
            {
                string cmd = "io.createdirectory";
                string parameters = txtpath_remote.Text + "\\" + i.Value;
                if (FileManagerTR != null)
                {
                    if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                }
                FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                FileManagerTR.IsBackground = true;
                FileManagerTR.Start();
            }
        }

        private void btn_newfile_Click(object sender, EventArgs e)
        {
            Forms.InputBox i = new InputBox("Enter name:");
            if (i.ShowDialog() == DialogResult.OK)
            {
                string cmd = "io.createfile";
                string parameters = txtpath_remote.Text + "\\" + i.Value;
                //MessageBox.Show(parameters);
                if (FileManagerTR != null)
                {
                    if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                }
                FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                FileManagerTR.IsBackground = true;
                FileManagerTR.Start();
            }
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                string cmd = "";
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    cmd = "io.renamedirectory";
                }
                else
                {
                    cmd = "io.renamefile";
                }
                Forms.InputBox ii = new InputBox("Enter new name:");
                if (ii.ShowDialog() == DialogResult.OK)
                {
                    string parameters = fname + "<" + ii.Value;
                    if (FileManagerTR != null)
                    {
                        if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                    }
                    FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                    FileManagerTR.IsBackground = true;
                    FileManagerTR.Start();
                }
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                string cmd = "";
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    //cmd = "io.copydirectory";
                    MessageBox.Show("Copy directory not supported.");
                    return;
                }
                else
                {
                    cmd = "io.copyfile";
                }
                Forms.InputBox ii = new InputBox("Enter target path:");
                if (ii.ShowDialog() == DialogResult.OK)
                {
                    string parameters = fname + "<" + ii.Value;
                    if (FileManagerTR != null)
                    {
                        if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                    }
                    FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                    FileManagerTR.IsBackground = true;
                    FileManagerTR.Start();
                }
            }
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                string cmd = "";
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    cmd = "io.movedirectory";
                }
                else
                {
                    cmd = "io.movefile";
                }
                Forms.InputBox ii = new InputBox("Enter target path:");
                if (ii.ShowDialog() == DialogResult.OK)
                {
                    string parameters = fname + "|" + ii.Value;
                    if (FileManagerTR != null)
                    {
                        if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                    }
                    FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                    FileManagerTR.IsBackground = true;
                    FileManagerTR.Start();
                }
            }
        }

        private void btn_attr_Click(object sender, EventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                string cmd = "";
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    cmd = "io.directoryattribute";
                }
                else
                {
                    cmd = "io.fileattribute";
                }
                Forms.AttributeForm ii = new AttributeForm();
                if (ii.ShowDialog() == DialogResult.OK)
                {
                    string parameters = fname + "<" + ii.Value;
                    if (FileManagerTR != null)
                    {
                        if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                    }
                    FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                    FileManagerTR.IsBackground = true;
                    FileManagerTR.Start();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                string cmd = "";
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    cmd = "io.deletedirectory";
                }
                else
                {
                    cmd = "io.deletefile";
                }
                string parameters = fname;
                if (FileManagerTR != null)
                {
                    if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                }
                FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                FileManagerTR.IsBackground = true;
                FileManagerTR.Start();
                try
                {
                    flist_remote.SelectedItems[0].Remove();
                }
                catch { }
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                string cmd = "";
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    MessageBox.Show("You can not run directory.");
                    return;
                }
                else
                {
                    cmd = "run";
                }
                string parameters = fname + "<none<" + "<normal";
                if (FileManagerTR != null)
                {
                    if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                }
                FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                FileManagerTR.IsBackground = true;
                FileManagerTR.Start();

            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                string cmd = "";
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    MessageBox.Show("You can not run directory.");
                    return;
                }
                else
                {
                    cmd = "run";
                }
                string parameters = fname + "<" + "<hidden";
                if (FileManagerTR != null)
                {
                    if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                }
                FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                FileManagerTR.IsBackground = true;
                FileManagerTR.Start();
            }
        }

        private void flist_local_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (this.flist_local.SelectedIndices.Count > 0)
            {
                ListViewItem s = (ListViewItem)e.Item;
                DoDragDrop(s, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }
        private void flist_remote_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void flist_local_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private void flist_remote_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem a = new ListViewItem();
            ListViewItem i = (ListViewItem)e.Data.GetData(a.GetType());
            string fpath = i.SubItems[5].Text;
            string ftype = i.SubItems[2].Text;
            if (i.ListView.Name.ToString() == "flist_remote") return;
            if (ftype == "Directory")
            {
                MessageBox.Show("Directory not supported.");
                return;
            }
            //upload
            if (FileManagerTR != null)
            {
                if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
            }
            string target = txtpath_remote.Text + "\\" + Path.GetFileName(fpath);
            FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.UploadFile(Client, fpath, target); });
            FileManagerTR.IsBackground = true;
            FileManagerTR.Start();

        }


        private void flist_remote_ItemDrag_1(object sender, ItemDragEventArgs e)
        {
            if (this.flist_remote.SelectedIndices.Count > 0)
            {
                ListViewItem s = (ListViewItem)e.Item;
                DoDragDrop(s, DragDropEffects.Copy | DragDropEffects.Move);
            }

        }

        private void flist_local_DragDrop_1(object sender, DragEventArgs e)
        {
            ListViewItem a = new ListViewItem();
            ListViewItem i = (ListViewItem)e.Data.GetData(a.GetType());
            string fpath = i.SubItems[5].Text;
            string ftype = i.SubItems[2].Text;
            if (i.ListView.Name.ToString() == "flist_local") return;
            if (ftype == "Directory")
            {
                MessageBox.Show("Directory not supported.");
                return;
            }
            //download
            string cmd = "downloadfile";
            string target = txtpath_local.Text + "\\" + Path.GetFileName(fpath);
            string parameters = fpath + "<" + target;
            //MessageBox.Show(parameters);
            if (FileManagerTR != null)
            {
                if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
            }
            FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
            FileManagerTR.IsBackground = true;
            FileManagerTR.Start();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (flist_remote.SelectedItems.Count != 0)
            {
                string cmd = "";
                ListViewItem i = flist_remote.SelectedItems[0];
                string fname = i.SubItems[5].Text;
                string ftype = i.SubItems[2].Text;
                if (ftype.Trim() == "Directory")
                {
                    return;
                }
                else
                {
                    cmd = "editfile";
                }
                string parameters = fname;
                if (FileManagerTR != null)
                {
                    if (FileManagerTR.ThreadState == ThreadState.Running) FileManagerTR.Abort();
                }
                FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.IO_Oprator(Client, cmd, parameters); });
                FileManagerTR.IsBackground = true;
                FileManagerTR.Start();
            }
        }
    }
}
