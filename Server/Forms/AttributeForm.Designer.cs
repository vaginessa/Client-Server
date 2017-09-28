namespace Server.Forms
{
    partial class AttributeForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.box_system = new System.Windows.Forms.CheckBox();
            this.box_hidden = new System.Windows.Forms.CheckBox();
            this.box_readonly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(126, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box_system
            // 
            this.box_system.AutoSize = true;
            this.box_system.Location = new System.Drawing.Point(12, 58);
            this.box_system.Name = "box_system";
            this.box_system.Size = new System.Drawing.Size(60, 17);
            this.box_system.TabIndex = 7;
            this.box_system.Text = "System";
            this.box_system.UseVisualStyleBackColor = true;
            // 
            // box_hidden
            // 
            this.box_hidden.AutoSize = true;
            this.box_hidden.Location = new System.Drawing.Point(12, 35);
            this.box_hidden.Name = "box_hidden";
            this.box_hidden.Size = new System.Drawing.Size(60, 17);
            this.box_hidden.TabIndex = 6;
            this.box_hidden.Text = "Hidden";
            this.box_hidden.UseVisualStyleBackColor = true;
            // 
            // box_readonly
            // 
            this.box_readonly.AutoSize = true;
            this.box_readonly.Location = new System.Drawing.Point(12, 12);
            this.box_readonly.Name = "box_readonly";
            this.box_readonly.Size = new System.Drawing.Size(73, 17);
            this.box_readonly.TabIndex = 5;
            this.box_readonly.Text = "ReadOnly";
            this.box_readonly.UseVisualStyleBackColor = true;
            // 
            // AttributeForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(212, 121);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_system);
            this.Controls.Add(this.box_hidden);
            this.Controls.Add(this.box_readonly);
            this.Name = "AttributeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttributeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox box_system;
        private System.Windows.Forms.CheckBox box_hidden;
        private System.Windows.Forms.CheckBox box_readonly;
    }
}