using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
namespace Server.Forms
{
    public partial class RemoteDesktop : Form
    {
        public RemoteDesktop()
        {
            InitializeComponent();
        }
        public Socket Client { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int type { get; set; }
        public bool IsStart { get; set; }
        public string FixBase64ForImage(string Image)
        {
            System.Text.StringBuilder sbText = new System.Text.StringBuilder(Image, Image.Length);
            sbText.Replace("\r\n", String.Empty); sbText.Replace(" ", String.Empty);
            return sbText.ToString();
        }
        public void SetTitle(string ip)
        {
            this.Text = "Client: " + ip;
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

        }
        public void SetScreen(byte[] img)
        {
            desktopscreen.Invoke(new MethodInvoker(
            delegate
            {
                desktopscreen.Image = ByteToImage(img);
            }
          ));
        }

        private void RemoteDesktop_Load(object sender, EventArgs e)
        {
            txttype.SelectedIndex = 0;
            comboBox1.SelectedIndex = 4;
            IsStart = false;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            txth.Enabled = false;
            txtw.Enabled = false;
            txttype.Enabled = false;
            btnstart.Enabled = false;
            btnstop.Enabled = true;
            IsStart = true;
            string _width = txtw.Text;
            string _height = txth.Text;
            type = txttype.SelectedIndex;
            int w = 0;
            int h = 0;
            bool v1 = int.TryParse(_width, out w);
            bool v2 = int.TryParse(_height, out h);
            width = w;
            height = h;
            if (!v1 && !v2)
            {
                MessageBox.Show("Width or Height value is currect.");
                return;
            }
            Thread TR_server = new Thread(delegate(object unused) { Classes.Commands.GetDesktopScreen(Client, width, height, type); });
            TR_server.IsBackground = true;
            TR_server.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            txth.Enabled = true;
            txtw.Enabled = true;
            txttype.Enabled = true;
            btnstart.Enabled = true;
            btnstop.Enabled = false;
            IsStart = false;
        }

        private void RemoteDesktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            btnstop_Click(null, null);
            this.Hide();
        }

        private void saveScreenshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (desktopscreen.Image != null)
            {

                Image img = desktopscreen.Image;
                img.Save(Application.StartupPath + "\\" + DateTime.Now.Ticks.ToString() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Dispose();


                //}
                //catch
                //{
                //    MessageBox.Show("Error saving screenshot");
                //}
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    txtw.Text = "1920";
                    txth.Text= "1080";
                    break;
                case 1:
                    txtw.Text = "1600";
                    txth.Text = "900";
                    break;
                case 2:
                    txtw.Text = "1280";
                    txth.Text = "720";
                    break;
                case 3:
                    txtw.Text = "1024";
                    txth.Text = "768";
                    break;
                case 4:
                    txtw.Text = "800";
                    txth.Text = "600";
                    break;
            }
        }
    }
}
