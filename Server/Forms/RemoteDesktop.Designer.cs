namespace Server.Forms
{
    partial class RemoteDesktop
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.desktopscreen = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desktopscreen)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnstop);
            this.panel1.Controls.Add(this.btnstart);
            this.panel1.Controls.Add(this.txttype);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(738, 10);
            this.btnstop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(100, 28);
            this.btnstop.TabIndex = 7;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(633, 10);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(100, 28);
            this.btnstart.TabIndex = 6;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txttype
            // 
            this.txttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "Colorful (High Speed Network)",
            "Black and white (Low Speed Network)"});
            this.txttype.Location = new System.Drawing.Point(340, 12);
            this.txttype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(287, 24);
            this.txttype.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type:";
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(159, 12);
            this.txth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(41, 22);
            this.txth.TabIndex = 3;
            this.txth.Text = "600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // txtw
            // 
            this.txtw.Location = new System.Drawing.Point(53, 12);
            this.txtw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtw.Name = "txtw";
            this.txtw.Size = new System.Drawing.Size(42, 22);
            this.txtw.TabIndex = 1;
            this.txtw.Text = "800";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // desktopscreen
            // 
            this.desktopscreen.ContextMenuStrip = this.contextMenuStrip1;
            this.desktopscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopscreen.Location = new System.Drawing.Point(0, 46);
            this.desktopscreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.desktopscreen.Name = "desktopscreen";
            this.desktopscreen.Size = new System.Drawing.Size(844, 524);
            this.desktopscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.desktopscreen.TabIndex = 1;
            this.desktopscreen.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveScreenshotToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 28);
            // 
            // saveScreenshotToolStripMenuItem
            // 
            this.saveScreenshotToolStripMenuItem.Name = "saveScreenshotToolStripMenuItem";
            this.saveScreenshotToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.saveScreenshotToolStripMenuItem.Text = "Save Screenshot";
            this.saveScreenshotToolStripMenuItem.Click += new System.EventHandler(this.saveScreenshotToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1920x1080",
            "1600x900",
            "1280x720",
            "1024x768",
            "800x600"});
            this.comboBox1.Location = new System.Drawing.Point(207, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RemoteDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 570);
            this.Controls.Add(this.desktopscreen);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RemoteDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoteDesktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoteDesktop_FormClosing);
            this.Load += new System.EventHandler(this.RemoteDesktop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desktopscreen)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.PictureBox desktopscreen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveScreenshotToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}