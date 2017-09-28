using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Server.Classes
{
    class LocalFileManager
    {
        public static string[] GetDrives()
        {
            String[] drives = Environment.GetLogicalDrives();
            return drives;
        }
        public static string io_getEntries(string path)
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
                    res += string.Format("{0}|{1}|{2}|{3}|{4}|{5}\n", Path.GetFileName(t), "-", "Directory", f.CreationTime, at, t);
                }
                foreach (string t in files)
                {
                    FileInfo f = new FileInfo(t);
                    FileAttributes at = f.Attributes;
                    res += string.Format("{0}|{1}|{2}|{3}|{4}|{5}\n", Path.GetFileName(t), f.Length, "File", f.CreationTime, at, t);
                }
                return res;
            }
            catch
            {
                return "error";
            }
        }
    }
}
