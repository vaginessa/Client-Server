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
    public partial class RunProgram : Form
    {
        public RunProgram()
        {
            InitializeComponent();
        }

        private void txtcancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public string Value { get; set; }
        private void btnrun_Click(object sender, EventArgs e)
        {
            string pro = txtprogram.Text;
            if (pro == "") return;
            string arg = txtarg.Text;
            if (arg == "") arg = "none";
            string mode = programbox.Text.ToLower();
            string cmd = "run|" + pro + "<" + arg + "<" + mode;
            Value = cmd;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RunProgram_Load(object sender, EventArgs e)
        {
            programbox.SelectedIndex = 0;
        }
    }
}
