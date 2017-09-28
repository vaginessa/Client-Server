using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace Server.Forms
{
    public partial class EditFile : Form
    {
        public EditFile(string f)
        {
            InitializeComponent();
            richTextBox1.Text = f;
        }
        public Socket Client { get; set; }
        public string TargetFile { get; set; }
        private void EditFile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = richTextBox1.Text;
            Thread FileManagerTR = new Thread(delegate(object unused) { Classes.Commands.SendFileForEdit(Client, TargetFile, t); });
            FileManagerTR.IsBackground = true;
            FileManagerTR.Start();
           
        }
    }
}
