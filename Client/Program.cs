using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
namespace Client
{
    static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            bool createdNew = true;

            using (Mutex mutex = new Mutex(true, "MyApplicationName", out createdNew))
            {
                if (createdNew)
                {
                    var __f = new MainForm();
                    __f.WindowState = FormWindowState.Minimized;
                    __f.Visible = false;
                    __f.ShowInTaskbar = false;

                    Application.EnableVisualStyles();
                    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
                    Application.Run(__f);
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
