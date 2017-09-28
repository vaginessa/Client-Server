namespace Server
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnetop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dissconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runProgramCMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClientList_view = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtlog = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsendmessage = new System.Windows.Forms.Button();
            this.btnrunprogram = new System.Windows.Forms.Button();
            this.btnremotedesktop = new System.Windows.Forms.Button();
            this.btnfilemanager = new System.Windows.Forms.Button();
            this.timer_client = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.CMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtip);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnetop);
            this.panel2.Controls.Add(this.btnstart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 49);
            this.panel2.TabIndex = 5;
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(276, 17);
            this.txtport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(61, 22);
            this.txtport.TabIndex = 9;
            this.txtport.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(48, 17);
            this.txtip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(172, 22);
            this.txtip.TabIndex = 7;
            this.txtip.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP:";
            // 
            // btnetop
            // 
            this.btnetop.Enabled = false;
            this.btnetop.Location = new System.Drawing.Point(485, 16);
            this.btnetop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnetop.Name = "btnetop";
            this.btnetop.Size = new System.Drawing.Size(131, 28);
            this.btnetop.TabIndex = 5;
            this.btnetop.Text = "Stop Server";
            this.btnetop.UseVisualStyleBackColor = true;
            this.btnetop.Click += new System.EventHandler(this.btnetop_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(347, 16);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(131, 28);
            this.btnstart.TabIndex = 4;
            this.btnstart.Text = "Start Server";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // CMenu
            // 
            this.CMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.clientInformationToolStripMenuItem,
            this.fileManagerToolStripMenuItem1,
            this.remoteDesktopToolStripMenuItem1,
            this.runProgramCMDToolStripMenuItem,
            this.sendMessageToolStripMenuItem,
            this.powerControlToolStripMenuItem,
            this.clientControlToolStripMenuItem});
            this.CMenu.Name = "CMenu";
            this.CMenu.Size = new System.Drawing.Size(252, 196);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.reconnectToolStripMenuItem,
            this.dissconnectToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            // 
            // dissconnectToolStripMenuItem
            // 
            this.dissconnectToolStripMenuItem.Name = "dissconnectToolStripMenuItem";
            this.dissconnectToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.dissconnectToolStripMenuItem.Text = "Dissconnect";
            // 
            // clientInformationToolStripMenuItem
            // 
            this.clientInformationToolStripMenuItem.Name = "clientInformationToolStripMenuItem";
            this.clientInformationToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.clientInformationToolStripMenuItem.Text = "Update Client Information";
            this.clientInformationToolStripMenuItem.Click += new System.EventHandler(this.clientInformationToolStripMenuItem_Click);
            // 
            // fileManagerToolStripMenuItem1
            // 
            this.fileManagerToolStripMenuItem1.Name = "fileManagerToolStripMenuItem1";
            this.fileManagerToolStripMenuItem1.Size = new System.Drawing.Size(251, 24);
            this.fileManagerToolStripMenuItem1.Text = "FileManager";
            this.fileManagerToolStripMenuItem1.Click += new System.EventHandler(this.fileManagerToolStripMenuItem1_Click);
            // 
            // remoteDesktopToolStripMenuItem1
            // 
            this.remoteDesktopToolStripMenuItem1.Name = "remoteDesktopToolStripMenuItem1";
            this.remoteDesktopToolStripMenuItem1.Size = new System.Drawing.Size(251, 24);
            this.remoteDesktopToolStripMenuItem1.Text = "Remote Desktop";
            this.remoteDesktopToolStripMenuItem1.Click += new System.EventHandler(this.remoteDesktopToolStripMenuItem1_Click);
            // 
            // runProgramCMDToolStripMenuItem
            // 
            this.runProgramCMDToolStripMenuItem.Name = "runProgramCMDToolStripMenuItem";
            this.runProgramCMDToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.runProgramCMDToolStripMenuItem.Text = "Run Program/CMD";
            this.runProgramCMDToolStripMenuItem.Click += new System.EventHandler(this.runProgramCMDToolStripMenuItem_Click);
            // 
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.sendMessageToolStripMenuItem.Text = "Send Message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToolStripMenuItem_Click);
            // 
            // powerControlToolStripMenuItem
            // 
            this.powerControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.shutDownToolStripMenuItem});
            this.powerControlToolStripMenuItem.Name = "powerControlToolStripMenuItem";
            this.powerControlToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.powerControlToolStripMenuItem.Text = "Power Control";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.shutDownToolStripMenuItem.Text = "ShutDown";
            this.shutDownToolStripMenuItem.Click += new System.EventHandler(this.shutDownToolStripMenuItem_Click);
            // 
            // clientControlToolStripMenuItem
            // 
            this.clientControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutDownClientToolStripMenuItem,
            this.removeClientToolStripMenuItem});
            this.clientControlToolStripMenuItem.Name = "clientControlToolStripMenuItem";
            this.clientControlToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.clientControlToolStripMenuItem.Text = "Client Control";
            // 
            // shutDownClientToolStripMenuItem
            // 
            this.shutDownClientToolStripMenuItem.Name = "shutDownClientToolStripMenuItem";
            this.shutDownClientToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.shutDownClientToolStripMenuItem.Text = "ShutDown Client";
            this.shutDownClientToolStripMenuItem.Click += new System.EventHandler(this.shutDownClientToolStripMenuItem_Click);
            // 
            // removeClientToolStripMenuItem
            // 
            this.removeClientToolStripMenuItem.Name = "removeClientToolStripMenuItem";
            this.removeClientToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.removeClientToolStripMenuItem.Text = "Remove Client";
            this.removeClientToolStripMenuItem.Click += new System.EventHandler(this.removeClientToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(805, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(129, 20);
            this.statuslabel.Text = "Server not started.";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel1.Text = "ReCoded By Mahdi72";
            // 
            // ClientList_view
            // 
            this.ClientList_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientList_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.columnHeader1,
            this.columnHeader2});
            this.ClientList_view.ContextMenuStrip = this.CMenu;
            this.ClientList_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ClientList_view.FullRowSelect = true;
            this.ClientList_view.Location = new System.Drawing.Point(5, 7);
            this.ClientList_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientList_view.MultiSelect = false;
            this.ClientList_view.Name = "ClientList_view";
            this.ClientList_view.Size = new System.Drawing.Size(753, 272);
            this.ClientList_view.TabIndex = 8;
            this.ClientList_view.UseCompatibleStateImageBehavior = false;
            this.ClientList_view.View = System.Windows.Forms.View.Details;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Computer Name";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 120;
            // 
            // txtlog
            // 
            this.txtlog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlog.BackColor = System.Drawing.Color.White;
            this.txtlog.Location = new System.Drawing.Point(16, 437);
            this.txtlog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlog.Name = "txtlog";
            this.txtlog.ReadOnly = true;
            this.txtlog.Size = new System.Drawing.Size(772, 143);
            this.txtlog.TabIndex = 9;
            this.txtlog.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 57);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 373);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ClientList_view);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(765, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnsendmessage);
            this.panel1.Controls.Add(this.btnrunprogram);
            this.panel1.Controls.Add(this.btnremotedesktop);
            this.panel1.Controls.Add(this.btnfilemanager);
            this.panel1.Location = new System.Drawing.Point(4, 288);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 46);
            this.panel1.TabIndex = 9;
            // 
            // btnsendmessage
            // 
            this.btnsendmessage.Location = new System.Drawing.Point(427, 7);
            this.btnsendmessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsendmessage.Name = "btnsendmessage";
            this.btnsendmessage.Size = new System.Drawing.Size(131, 28);
            this.btnsendmessage.TabIndex = 8;
            this.btnsendmessage.Text = "Send Message";
            this.btnsendmessage.UseVisualStyleBackColor = true;
            this.btnsendmessage.Click += new System.EventHandler(this.btnsendmessage_Click);
            // 
            // btnrunprogram
            // 
            this.btnrunprogram.Location = new System.Drawing.Point(288, 7);
            this.btnrunprogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrunprogram.Name = "btnrunprogram";
            this.btnrunprogram.Size = new System.Drawing.Size(131, 28);
            this.btnrunprogram.TabIndex = 7;
            this.btnrunprogram.Text = "Run Program";
            this.btnrunprogram.UseVisualStyleBackColor = true;
            this.btnrunprogram.Click += new System.EventHandler(this.btnrunprogram_Click);
            // 
            // btnremotedesktop
            // 
            this.btnremotedesktop.Location = new System.Drawing.Point(149, 7);
            this.btnremotedesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnremotedesktop.Name = "btnremotedesktop";
            this.btnremotedesktop.Size = new System.Drawing.Size(131, 28);
            this.btnremotedesktop.TabIndex = 6;
            this.btnremotedesktop.Text = "Remote Desktop";
            this.btnremotedesktop.UseVisualStyleBackColor = true;
            this.btnremotedesktop.Click += new System.EventHandler(this.btnremotedesktop_Click);
            // 
            // btnfilemanager
            // 
            this.btnfilemanager.Location = new System.Drawing.Point(11, 7);
            this.btnfilemanager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfilemanager.Name = "btnfilemanager";
            this.btnfilemanager.Size = new System.Drawing.Size(131, 28);
            this.btnfilemanager.TabIndex = 5;
            this.btnfilemanager.Text = "File Manager";
            this.btnfilemanager.UseVisualStyleBackColor = true;
            this.btnfilemanager.Click += new System.EventHandler(this.btnfilemanager_Click);
            // 
            // timer_client
            // 
            this.timer_client.Enabled = true;
            this.timer_client.Interval = 10000;
            this.timer_client.Tick += new System.EventHandler(this.timer_client_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ContextMenuStrip CMenu;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dissconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runProgramCMDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.Button btnetop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView ClientList_view;
        private System.Windows.Forms.ColumnHeader IP;
        public System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RichTextBox txtlog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsendmessage;
        private System.Windows.Forms.Button btnrunprogram;
        private System.Windows.Forms.Button btnremotedesktop;
        private System.Windows.Forms.Button btnfilemanager;
        private System.Windows.Forms.Timer timer_client;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

