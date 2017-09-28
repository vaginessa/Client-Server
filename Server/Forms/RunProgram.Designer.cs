namespace Server.Forms
{
    partial class RunProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtarg = new System.Windows.Forms.TextBox();
            this.programbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprogram = new System.Windows.Forms.TextBox();
            this.btnrun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtarg
            // 
            this.txtarg.Location = new System.Drawing.Point(92, 41);
            this.txtarg.Name = "txtarg";
            this.txtarg.Size = new System.Drawing.Size(270, 20);
            this.txtarg.TabIndex = 21;
            // 
            // programbox
            // 
            this.programbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programbox.FormattingEnabled = true;
            this.programbox.Items.AddRange(new object[] {
            "Normal",
            "Hidden",
            "Maximized",
            "Minimized"});
            this.programbox.Location = new System.Drawing.Point(92, 68);
            this.programbox.Name = "programbox";
            this.programbox.Size = new System.Drawing.Size(97, 21);
            this.programbox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Program/Cmd:";
            // 
            // txtprogram
            // 
            this.txtprogram.Location = new System.Drawing.Point(92, 12);
            this.txtprogram.Name = "txtprogram";
            this.txtprogram.Size = new System.Drawing.Size(270, 20);
            this.txtprogram.TabIndex = 17;
            // 
            // btnrun
            // 
            this.btnrun.Location = new System.Drawing.Point(245, 111);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(117, 23);
            this.btnrun.TabIndex = 19;
            this.btnrun.Text = "Run";
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Parameters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Start Mode:";
            // 
            // txtcancel
            // 
            this.txtcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.txtcancel.Location = new System.Drawing.Point(122, 111);
            this.txtcancel.Name = "txtcancel";
            this.txtcancel.Size = new System.Drawing.Size(117, 23);
            this.txtcancel.TabIndex = 24;
            this.txtcancel.Text = "Cancel";
            this.txtcancel.UseVisualStyleBackColor = true;
            this.txtcancel.Click += new System.EventHandler(this.txtcancel_Click);
            // 
            // RunProgram
            // 
            this.AcceptButton = this.btnrun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.txtcancel;
            this.ClientSize = new System.Drawing.Size(374, 149);
            this.ControlBox = false;
            this.Controls.Add(this.txtcancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtarg);
            this.Controls.Add(this.programbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprogram);
            this.Controls.Add(this.btnrun);
            this.Name = "RunProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunProgram";
            this.Load += new System.EventHandler(this.RunProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtarg;
        private System.Windows.Forms.ComboBox programbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprogram;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtcancel;
    }
}