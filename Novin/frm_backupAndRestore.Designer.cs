namespace Novin
{
    partial class frm_backupAndRestore
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
            this.grp_restore = new System.Windows.Forms.GroupBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_browseBackup = new System.Windows.Forms.Button();
            this.tbx_restore = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_provideBackup = new System.Windows.Forms.Button();
            this.btn_saveBackup = new System.Windows.Forms.Button();
            this.tbx_backupPath = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grp_restore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_restore
            // 
            this.grp_restore.BackColor = System.Drawing.Color.Transparent;
            this.grp_restore.Controls.Add(this.btn_restore);
            this.grp_restore.Controls.Add(this.btn_browseBackup);
            this.grp_restore.Controls.Add(this.tbx_restore);
            this.grp_restore.Location = new System.Drawing.Point(18, 104);
            this.grp_restore.Name = "grp_restore";
            this.grp_restore.Size = new System.Drawing.Size(567, 90);
            this.grp_restore.TabIndex = 4;
            this.grp_restore.TabStop = false;
            this.grp_restore.Text = "بازیابی نسخه پشتیبان";
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_restore.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_restore.Location = new System.Drawing.Point(6, 52);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(195, 27);
            this.btn_restore.TabIndex = 2;
            this.btn_restore.Text = "بازیابی نسخه پشتیبان";
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_browseBackup
            // 
            this.btn_browseBackup.Location = new System.Drawing.Point(506, 20);
            this.btn_browseBackup.Name = "btn_browseBackup";
            this.btn_browseBackup.Size = new System.Drawing.Size(34, 26);
            this.btn_browseBackup.TabIndex = 1;
            this.btn_browseBackup.Text = "...";
            this.btn_browseBackup.UseVisualStyleBackColor = true;
            // 
            // tbx_restore
            // 
            this.tbx_restore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_restore.Location = new System.Drawing.Point(6, 20);
            this.tbx_restore.Name = "tbx_restore";
            this.tbx_restore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_restore.Size = new System.Drawing.Size(494, 26);
            this.tbx_restore.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_provideBackup);
            this.groupBox1.Controls.Add(this.btn_saveBackup);
            this.groupBox1.Controls.Add(this.tbx_backupPath);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تهیه نسخه پشتیبان";
            // 
            // btn_provideBackup
            // 
            this.btn_provideBackup.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_provideBackup.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_provideBackup.Location = new System.Drawing.Point(6, 52);
            this.btn_provideBackup.Name = "btn_provideBackup";
            this.btn_provideBackup.Size = new System.Drawing.Size(195, 25);
            this.btn_provideBackup.TabIndex = 2;
            this.btn_provideBackup.Text = "تهیه نسخه پشتیبان";
            this.btn_provideBackup.UseVisualStyleBackColor = false;
            this.btn_provideBackup.Click += new System.EventHandler(this.btn_provideBackup_Click);
            // 
            // btn_saveBackup
            // 
            this.btn_saveBackup.Location = new System.Drawing.Point(506, 20);
            this.btn_saveBackup.Name = "btn_saveBackup";
            this.btn_saveBackup.Size = new System.Drawing.Size(34, 26);
            this.btn_saveBackup.TabIndex = 1;
            this.btn_saveBackup.Text = "...";
            this.btn_saveBackup.UseVisualStyleBackColor = true;
            // 
            // tbx_backupPath
            // 
            this.tbx_backupPath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_backupPath.Location = new System.Drawing.Point(6, 20);
            this.tbx_backupPath.Name = "tbx_backupPath";
            this.tbx_backupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_backupPath.Size = new System.Drawing.Size(494, 26);
            this.tbx_backupPath.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(403, 215);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 59;
            this.btn_ok.Text = "تــــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(322, 215);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "انــــصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_backupAndRestore
            // 
            this.ClientSize = new System.Drawing.Size(603, 250);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.grp_restore);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_backupAndRestore";
            this.Text = "تهیه و بازیابی نسخه پشتیبان";
            this.grp_restore.ResumeLayout(false);
            this.grp_restore.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grp_restore;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_browseBackup;
        private System.Windows.Forms.TextBox tbx_restore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_provideBackup;
        private System.Windows.Forms.Button btn_saveBackup;
        private System.Windows.Forms.TextBox tbx_backupPath;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}
