namespace Novin
{
    partial class frm_logOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_logOn));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_userName = new System.Windows.Forms.TextBox();
            this.pnl_Password = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.listView_users = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbx_users = new System.Windows.Forms.ListBox();
            this.tbl_usersTableAdapter = new Novin.ds_usersTableAdapters.tbl_usersTableAdapter();
            this.ds_users = new Novin.ds_users();
            this.bs_users = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_users)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("IranNastaliq", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(237, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 43);
            this.label3.TabIndex = 34;
            this.label3.Text = "بسم الله الرحمن الرحیم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(402, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "نام کاربری";
            // 
            // tbx_userName
            // 
            this.tbx_userName.Location = new System.Drawing.Point(141, 200);
            this.tbx_userName.Name = "tbx_userName";
            this.tbx_userName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_userName.Size = new System.Drawing.Size(255, 21);
            this.tbx_userName.TabIndex = 28;
            this.tbx_userName.TextChanged += new System.EventHandler(this.tbx_userName_TextChanged);
            // 
            // pnl_Password
            // 
            this.pnl_Password.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Password.Controls.Add(this.label2);
            this.pnl_Password.Controls.Add(this.tbx_password);
            this.pnl_Password.Location = new System.Drawing.Point(139, 227);
            this.pnl_Password.Name = "pnl_Password";
            this.pnl_Password.Size = new System.Drawing.Size(313, 29);
            this.pnl_Password.TabIndex = 29;
            this.pnl_Password.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(263, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "گذرواژه";
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(3, 3);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_password.Size = new System.Drawing.Size(254, 21);
            this.tbx_password.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(19, 265);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 26);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "بستن برنامه";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(344, 265);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(239, 26);
            this.btn_ok.TabIndex = 30;
            this.btn_ok.Text = "ورود به برنامه";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // listView_users
            // 
            this.listView_users.BackColor = System.Drawing.SystemColors.Window;
            this.listView_users.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_users.LargeImageList = this.imageList1;
            this.listView_users.Location = new System.Drawing.Point(19, 58);
            this.listView_users.MultiSelect = false;
            this.listView_users.Name = "listView_users";
            this.listView_users.Size = new System.Drawing.Size(557, 136);
            this.listView_users.TabIndex = 27;
            this.listView_users.UseCompatibleStateImageBehavior = false;
            this.listView_users.SelectedIndexChanged += new System.EventHandler(this.listView_users_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "monji");
            this.imageList1.Images.SetKeyName(1, "bird.jpg");
            this.imageList1.Images.SetKeyName(2, "car1.jpg");
            this.imageList1.Images.SetKeyName(3, "eagle.jpg");
            this.imageList1.Images.SetKeyName(4, "fish.jpg");
            this.imageList1.Images.SetKeyName(5, "hourse.jpg");
            this.imageList1.Images.SetKeyName(6, "killer.jpg");
            this.imageList1.Images.SetKeyName(7, "linux.png");
            this.imageList1.Images.SetKeyName(8, "nature1.jpg");
            // 
            // lbx_users
            // 
            this.lbx_users.DisplayMember = "user_name";
            this.lbx_users.FormattingEnabled = true;
            this.lbx_users.Location = new System.Drawing.Point(86, 109);
            this.lbx_users.Name = "lbx_users";
            this.lbx_users.Size = new System.Drawing.Size(120, 17);
            this.lbx_users.TabIndex = 32;
            this.lbx_users.TabStop = false;
            this.lbx_users.ValueMember = "user_id";
            // 
            // tbl_usersTableAdapter
            // 
            this.tbl_usersTableAdapter.ClearBeforeFill = true;
            // 
            // ds_users
            // 
            this.ds_users.DataSetName = "ds_users";
            this.ds_users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_users
            // 
            this.bs_users.DataMember = "tbl_users";
            this.bs_users.DataSource = this.ds_users;
            // 
            // frm_logOn
            // 
            this.AcceptButton = this.btn_ok;
            this.ClientSize = new System.Drawing.Size(595, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_userName);
            this.Controls.Add(this.pnl_Password);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.listView_users);
            this.Controls.Add(this.lbx_users);
            this.Name = "frm_logOn";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ورود به نرم افزار";
            this.Load += new System.EventHandler(this.frm_logOn_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_logOn_FormClosing);
            this.pnl_Password.ResumeLayout(false);
            this.pnl_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_userName;
        private System.Windows.Forms.Panel pnl_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ListView listView_users;
        private System.Windows.Forms.ListBox lbx_users;
        private System.Windows.Forms.ImageList imageList1;
        private Novin.ds_usersTableAdapters.tbl_usersTableAdapter tbl_usersTableAdapter;
        private ds_users ds_users;
        private System.Windows.Forms.BindingSource bs_users;
    }
}
