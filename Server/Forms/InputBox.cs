using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.Forms
{
    public partial class InputBox : Form
    {
        public string Value { get; set; }
        public InputBox(string label)
        {
            InitializeComponent();
            msglabel.Text = label;
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string t = txtbody.Text;
            if (t == "") return;
            Value = t;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
