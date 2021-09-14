namespace Novin
{
    partial class frm_setPassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_confirmNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_newPass = new System.Windows.Forms.TextBox();
            this.tbx_oldPass = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(292, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "تائید گذرواژه جدید :";
            // 
            // tbx_confirmNewPass
            // 
            this.tbx_confirmNewPass.Location = new System.Drawing.Point(19, 82);
            this.tbx_confirmNewPass.Name = "tbx_confirmNewPass";
            this.tbx_confirmNewPass.PasswordChar = '*';
            this.tbx_confirmNewPass.Size = new System.Drawing.Size(267, 21);
            this.tbx_confirmNewPass.TabIndex = 9;
            this.tbx_confirmNewPass.TextChanged += new System.EventHandler(this.tbx_confirmNewPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(294, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "گذرواژه جدید :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(292, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "گذرواژه قبلی :";
            // 
            // tbx_newPass
            // 
            this.tbx_newPass.Location = new System.Drawing.Point(19, 55);
            this.tbx_newPass.Name = "tbx_newPass";
            this.tbx_newPass.PasswordChar = '*';
            this.tbx_newPass.Size = new System.Drawing.Size(267, 21);
            this.tbx_newPass.TabIndex = 8;
            this.tbx_newPass.TextChanged += new System.EventHandler(this.tbx_newPass_TextChanged);
            // 
            // tbx_oldPass
            // 
            this.tbx_oldPass.Location = new System.Drawing.Point(19, 28);
            this.tbx_oldPass.Name = "tbx_oldPass";
            this.tbx_oldPass.PasswordChar = '*';
            this.tbx_oldPass.Size = new System.Drawing.Size(267, 21);
            this.tbx_oldPass.TabIndex = 7;
            this.tbx_oldPass.TextChanged += new System.EventHandler(this.tbx_oldPass_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(218, 122);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 57;
            this.btn_ok.Text = "تــــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(137, 122);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 58;
            this.btn_cancel.Text = "انــــصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_setPassword
            // 
            this.AcceptButton = this.btn_ok;
            this.ClientSize = new System.Drawing.Size(405, 157);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_confirmNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_newPass);
            this.Controls.Add(this.tbx_oldPass);
            this.Name = "frm_setPassword";
            this.Text = "تنظیم گذرواژه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbx_confirmNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_newPass;
        private System.Windows.Forms.TextBox tbx_oldPass;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}
