namespace Server.Forms
{
    partial class FileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.localPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flist_local = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtdrive_local = new System.Windows.Forms.ComboBox();
            this.txtpath_local = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.remotePanel = new System.Windows.Forms.Panel();
            this.btnreloadpath_remote = new System.Windows.Forms.Button();
            this.btnreloaddrive_remote = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_attr = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_rename = new System.Windows.Forms.Button();
            this.btn_newfile = new System.Windows.Forms.Button();
            this.btn_newfolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flist_remote = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txtdrives_remote = new System.Windows.Forms.ComboBox();
            this.txtpath_remote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.localPanel.SuspendLayout();
            this.remotePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // localPanel
            // 
            this.localPanel.Controls.Add(this.label3);
            this.localPanel.Controls.Add(this.flist_local);
            this.localPanel.Controls.Add(this.label11);
            this.localPanel.Controls.Add(this.txtdrive_local);
            this.localPanel.Controls.Add(this.txtpath_local);
            this.localPanel.Controls.Add(this.label1);
            this.localPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.localPanel.Location = new System.Drawing.Point(0, 0);
            this.localPanel.Name = "localPanel";
            this.localPanel.Size = new System.Drawing.Size(420, 487);
            this.localPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Path:";
            // 
            // flist_local
            // 
            this.flist_local.AllowDrop = true;
            this.flist_local.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flist_local.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.flist_local.FullRowSelect = true;
            this.flist_local.LargeImageList = this.imageList1;
            this.flist_local.Location = new System.Drawing.Point(12, 86);
            this.flist_local.MultiSelect = false;
            this.flist_local.Name = "flist_local";
            this.flist_local.Size = new System.Drawing.Size(402, 336);
            this.flist_local.SmallImageList = this.imageList1;
            this.flist_local.TabIndex = 26;
            this.flist_local.UseCompatibleStateImageBehavior = false;
            this.flist_local.View = System.Windows.Forms.View.Details;
            this.flist_local.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.flist_local_ItemDrag);
            this.flist_local.DragDrop += new System.Windows.Forms.DragEventHandler(this.flist_local_DragDrop_1);
            this.flist_local.DragEnter += new System.Windows.Forms.DragEventHandler(this.flist_local_DragEnter);
            this.flist_local.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flist_local_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FileSize";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FileType";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CreationTime";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Attribute";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Path";
            this.columnHeader6.Width = 100;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file.png");
            this.imageList1.Images.SetKeyName(1, "Folder.png");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Select Drive:";
            // 
            // txtdrive_local
            // 
            this.txtdrive_local.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdrive_local.FormattingEnabled = true;
            this.txtdrive_local.Location = new System.Drawing.Point(86, 33);
            this.txtdrive_local.Name = "txtdrive_local";
            this.txtdrive_local.Size = new System.Drawing.Size(180, 21);
            this.txtdrive_local.TabIndex = 24;
            this.txtdrive_local.SelectedIndexChanged += new System.EventHandler(this.txtdrive_local_SelectedIndexChanged);
            // 
            // txtpath_local
            // 
            this.txtpath_local.Location = new System.Drawing.Point(86, 60);
            this.txtpath_local.Name = "txtpath_local";
            this.txtpath_local.Size = new System.Drawing.Size(328, 20);
            this.txtpath_local.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(420, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 487);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // remotePanel
            // 
            this.remotePanel.Controls.Add(this.btnreloadpath_remote);
            this.remotePanel.Controls.Add(this.btnreloaddrive_remote);
            this.remotePanel.Controls.Add(this.btn_open);
            this.remotePanel.Controls.Add(this.btn_run);
            this.remotePanel.Controls.Add(this.btn_edit);
            this.remotePanel.Controls.Add(this.btn_attr);
            this.remotePanel.Controls.Add(this.btn_delete);
            this.remotePanel.Controls.Add(this.btn_move);
            this.remotePanel.Controls.Add(this.btn_copy);
            this.remotePanel.Controls.Add(this.btn_rename);
            this.remotePanel.Controls.Add(this.btn_newfile);
            this.remotePanel.Controls.Add(this.btn_newfolder);
            this.remotePanel.Controls.Add(this.label4);
            this.remotePanel.Controls.Add(this.flist_remote);
            this.remotePanel.Controls.Add(this.label5);
            this.remotePanel.Controls.Add(this.txtdrives_remote);
            this.remotePanel.Controls.Add(this.txtpath_remote);
            this.remotePanel.Controls.Add(this.label2);
            this.remotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remotePanel.Location = new System.Drawing.Point(426, 0);
            this.remotePanel.Name = "remotePanel";
            this.remotePanel.Size = new System.Drawing.Size(416, 487);
            this.remotePanel.TabIndex = 2;
            // 
            // btnreloadpath_remote
            // 
            this.btnreloadpath_remote.Location = new System.Drawing.Point(348, 62);
            this.btnreloadpath_remote.Name = "btnreloadpath_remote";
            this.btnreloadpath_remote.Size = new System.Drawing.Size(61, 23);
            this.btnreloadpath_remote.TabIndex = 44;
            this.btnreloadpath_remote.Text = "Reload";
            this.btnreloadpath_remote.UseVisualStyleBackColor = true;
            this.btnreloadpath_remote.Click += new System.EventHandler(this.btnreloadpath_remote_Click);
            // 
            // btnreloaddrive_remote
            // 
            this.btnreloaddrive_remote.Location = new System.Drawing.Point(267, 35);
            this.btnreloaddrive_remote.Name = "btnreloaddrive_remote";
            this.btnreloaddrive_remote.Size = new System.Drawing.Size(75, 23);
            this.btnreloaddrive_remote.TabIndex = 43;
            this.btnreloaddrive_remote.Text = "Reload";
            this.btnreloaddrive_remote.UseVisualStyleBackColor = true;
            this.btnreloaddrive_remote.Click += new System.EventHandler(this.btnreloaddrive_remote_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(329, 460);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 42;
            this.btn_open.Text = "Run Hidden";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(329, 431);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 41;
            this.btn_run.Text = "Run Normal";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(250, 460);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 40;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_attr
            // 
            this.btn_attr.Location = new System.Drawing.Point(248, 431);
            this.btn_attr.Name = "btn_attr";
            this.btn_attr.Size = new System.Drawing.Size(75, 23);
            this.btn_attr.TabIndex = 39;
            this.btn_attr.Text = "Attribute";
            this.btn_attr.UseVisualStyleBackColor = true;
            this.btn_attr.Click += new System.EventHandler(this.btn_attr_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(88, 460);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 38;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(169, 461);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(75, 23);
            this.btn_move.TabIndex = 37;
            this.btn_move.Text = "Move";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(169, 431);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 36;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_rename
            // 
            this.btn_rename.Location = new System.Drawing.Point(88, 431);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(75, 23);
            this.btn_rename.TabIndex = 35;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // btn_newfile
            // 
            this.btn_newfile.Location = new System.Drawing.Point(7, 460);
            this.btn_newfile.Name = "btn_newfile";
            this.btn_newfile.Size = new System.Drawing.Size(75, 23);
            this.btn_newfile.TabIndex = 34;
            this.btn_newfile.Text = "New File";
            this.btn_newfile.UseVisualStyleBackColor = true;
            this.btn_newfile.Click += new System.EventHandler(this.btn_newfile_Click);
            // 
            // btn_newfolder
            // 
            this.btn_newfolder.Location = new System.Drawing.Point(7, 431);
            this.btn_newfolder.Name = "btn_newfolder";
            this.btn_newfolder.Size = new System.Drawing.Size(75, 23);
            this.btn_newfolder.TabIndex = 33;
            this.btn_newfolder.Text = "New Folder";
            this.btn_newfolder.UseVisualStyleBackColor = true;
            this.btn_newfolder.Click += new System.EventHandler(this.btn_newfolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Path:";
            // 
            // flist_remote
            // 
            this.flist_remote.AllowDrop = true;
            this.flist_remote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flist_remote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.flist_remote.FullRowSelect = true;
            this.flist_remote.LargeImageList = this.imageList1;
            this.flist_remote.Location = new System.Drawing.Point(7, 89);
            this.flist_remote.MultiSelect = false;
            this.flist_remote.Name = "flist_remote";
            this.flist_remote.Size = new System.Drawing.Size(402, 336);
            this.flist_remote.SmallImageList = this.imageList1;
            this.flist_remote.TabIndex = 31;
            this.flist_remote.UseCompatibleStateImageBehavior = false;
            this.flist_remote.View = System.Windows.Forms.View.Details;
            this.flist_remote.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.flist_remote_ItemDrag_1);
            this.flist_remote.DragDrop += new System.Windows.Forms.DragEventHandler(this.flist_remote_DragDrop);
            this.flist_remote.DragEnter += new System.Windows.Forms.DragEventHandler(this.flist_remote_DragEnter);
            this.flist_remote.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flist_remote_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Filename";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "FileSize";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "FileType";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "CreationTime";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Attribute";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Path";
            this.columnHeader12.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Select Drive:";
            // 
            // txtdrives_remote
            // 
            this.txtdrives_remote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdrives_remote.FormattingEnabled = true;
            this.txtdrives_remote.Location = new System.Drawing.Point(81, 36);
            this.txtdrives_remote.Name = "txtdrives_remote";
            this.txtdrives_remote.Size = new System.Drawing.Size(180, 21);
            this.txtdrives_remote.TabIndex = 29;
            this.txtdrives_remote.SelectedIndexChanged += new System.EventHandler(this.txtdrives_remote_SelectedIndexChanged);
            // 
            // txtpath_remote
            // 
            this.txtpath_remote.Location = new System.Drawing.Point(81, 63);
            this.txtpath_remote.Name = "txtpath_remote";
            this.txtpath_remote.Size = new System.Drawing.Size(261, 20);
            this.txtpath_remote.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote Computer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 487);
            this.Controls.Add(this.remotePanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.localPanel);
            this.Name = "FileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileManager_FormClosing);
            this.Load += new System.EventHandler(this.FileManager_Load);
            this.localPanel.ResumeLayout(false);
            this.localPanel.PerformLayout();
            this.remotePanel.ResumeLayout(false);
            this.remotePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel localPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel remotePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView flist_local;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtdrive_local;
        private System.Windows.Forms.TextBox txtpath_local;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView flist_remote;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtdrives_remote;
        private System.Windows.Forms.TextBox txtpath_remote;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_attr;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Button btn_newfile;
        private System.Windows.Forms.Button btn_newfolder;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnreloaddrive_remote;
        private System.Windows.Forms.Button btnreloadpath_remote;
    }
}