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
    public partial class AttributeForm : Form
    {
        public AttributeForm()
        {
            InitializeComponent();
        }
        public string Value { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (box_readonly.Checked)
            {
                Value += "1";
            }
            else
            {
                Value += "0";
            }
            if (box_hidden.Checked)
            {
                Value += "1";
            }
            else
            {
                Value += "0";
            }
            if (box_system.Checked)
            {
                Value += "1";
            }
            else
            {
                Value += "0";
            }
            this.Close();
        }
    }
}
