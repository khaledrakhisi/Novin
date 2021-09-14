namespace Novin
{
    partial class frm_preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_preferences));
            this.tabs = new System.Windows.Forms.TabControl();
            this.pag_desktop = new System.Windows.Forms.TabPage();
            this.pnl_delayGroup = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.num_seconds = new System.Windows.Forms.NumericUpDown();
            this.chk_showSamePathPic = new System.Windows.Forms.CheckBox();
            this.chk_showMainMenu = new System.Windows.Forms.CheckBox();
            this.tbx_path = new System.Windows.Forms.TextBox();
            this.pnl_tile = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_selectPic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_picPosition = new System.Windows.Forms.ComboBox();
            this.pic_sampleScreen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pag_password = new System.Windows.Forms.TabPage();
            this.listView_users = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_userManagment = new System.Windows.Forms.Panel();
            this.lnk_managePassword = new System.Windows.Forms.LinkLabel();
            this.lnk_deleteUserAccount = new System.Windows.Forms.LinkLabel();
            this.lnk_renameUserAccount = new System.Windows.Forms.LinkLabel();
            this.pnl_userProp = new System.Windows.Forms.Panel();
            this.chkLst_Allocations = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_accountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_imagesNames = new System.Windows.Forms.ComboBox();
            this.lnk_browseForPic = new System.Windows.Forms.LinkLabel();
            this.lnk_createUserAccount = new System.Windows.Forms.LinkLabel();
            this.pag_general = new System.Windows.Forms.TabPage();
            this.btn_brosweTheBank = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_bankPath = new System.Windows.Forms.TextBox();
            this.btn_browseBackupPath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_backupPath = new System.Windows.Forms.TextBox();
            this.pag_reminder = new System.Windows.Forms.TabPage();
            this.pnl_playSound = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_selectSound = new System.Windows.Forms.Button();
            this.tbx_reminderSoundPath = new System.Windows.Forms.TextBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.chk_playSoundOnTime = new System.Windows.Forms.CheckBox();
            this.btn_runReminder = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.ds_users = new Novin.ds_users();
            this.bs_users = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_usersTableAdapter = new Novin.ds_usersTableAdapters.tbl_usersTableAdapter();
            this.ofd_pic = new System.Windows.Forms.OpenFileDialog();
            this.fbd_ = new System.Windows.Forms.FolderBrowserDialog();
            this.tabs.SuspendLayout();
            this.pag_desktop.SuspendLayout();
            this.pnl_delayGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_seconds)).BeginInit();
            this.pnl_tile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sampleScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pag_password.SuspendLayout();
            this.pnl_userManagment.SuspendLayout();
            this.pnl_userProp.SuspendLayout();
            this.pag_general.SuspendLayout();
            this.pag_reminder.SuspendLayout();
            this.pnl_playSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_users)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.pag_desktop);
            this.tabs.Controls.Add(this.pag_password);
            this.tabs.Controls.Add(this.pag_general);
            this.tabs.Controls.Add(this.pag_reminder);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.RightToLeftLayout = true;
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(667, 341);
            this.tabs.TabIndex = 1;
            // 
            // pag_desktop
            // 
            this.pag_desktop.Controls.Add(this.pnl_delayGroup);
            this.pag_desktop.Controls.Add(this.chk_showSamePathPic);
            this.pag_desktop.Controls.Add(this.chk_showMainMenu);
            this.pag_desktop.Controls.Add(this.tbx_path);
            this.pag_desktop.Controls.Add(this.pnl_tile);
            this.pag_desktop.Controls.Add(this.btn_selectPic);
            this.pag_desktop.Controls.Add(this.label1);
            this.pag_desktop.Controls.Add(this.cmb_picPosition);
            this.pag_desktop.Controls.Add(this.pic_sampleScreen);
            this.pag_desktop.Controls.Add(this.pictureBox1);
            this.pag_desktop.Location = new System.Drawing.Point(4, 22);
            this.pag_desktop.Name = "pag_desktop";
            this.pag_desktop.Padding = new System.Windows.Forms.Padding(3);
            this.pag_desktop.Size = new System.Drawing.Size(659, 315);
            this.pag_desktop.TabIndex = 0;
            this.pag_desktop.Text = "پس زمینه";
            this.pag_desktop.UseVisualStyleBackColor = true;
            // 
            // pnl_delayGroup
            // 
            this.pnl_delayGroup.Controls.Add(this.label2);
            this.pnl_delayGroup.Controls.Add(this.num_seconds);
            this.pnl_delayGroup.Enabled = false;
            this.pnl_delayGroup.Location = new System.Drawing.Point(90, 235);
            this.pnl_delayGroup.Name = "pnl_delayGroup";
            this.pnl_delayGroup.Size = new System.Drawing.Size(119, 46);
            this.pnl_delayGroup.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ثانیه.";
            // 
            // num_seconds
            // 
            this.num_seconds.Location = new System.Drawing.Point(64, 3);
            this.num_seconds.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_seconds.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_seconds.Name = "num_seconds";
            this.num_seconds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_seconds.Size = new System.Drawing.Size(47, 21);
            this.num_seconds.TabIndex = 8;
            this.num_seconds.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // chk_showSamePathPic
            // 
            this.chk_showSamePathPic.AutoSize = true;
            this.chk_showSamePathPic.Location = new System.Drawing.Point(205, 243);
            this.chk_showSamePathPic.Name = "chk_showSamePathPic";
            this.chk_showSamePathPic.Size = new System.Drawing.Size(201, 17);
            this.chk_showSamePathPic.TabIndex = 7;
            this.chk_showSamePathPic.Text = "نمایش عکس های هم مسیر در زمان :";
            this.chk_showSamePathPic.UseVisualStyleBackColor = true;
            this.chk_showSamePathPic.CheckedChanged += new System.EventHandler(this.chk_showSamePathPic_CheckedChanged);
            // 
            // chk_showMainMenu
            // 
            this.chk_showMainMenu.AutoSize = true;
            this.chk_showMainMenu.Checked = true;
            this.chk_showMainMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_showMainMenu.Location = new System.Drawing.Point(493, 241);
            this.chk_showMainMenu.Name = "chk_showMainMenu";
            this.chk_showMainMenu.Size = new System.Drawing.Size(114, 17);
            this.chk_showMainMenu.TabIndex = 6;
            this.chk_showMainMenu.Text = "نمایش منوی اصلی";
            this.chk_showMainMenu.UseVisualStyleBackColor = true;
            // 
            // tbx_path
            // 
            this.tbx_path.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_path.Location = new System.Drawing.Point(481, 82);
            this.tbx_path.Name = "tbx_path";
            this.tbx_path.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_path.Size = new System.Drawing.Size(163, 25);
            this.tbx_path.TabIndex = 5;
            // 
            // pnl_tile
            // 
            this.pnl_tile.Controls.Add(this.pictureBox5);
            this.pnl_tile.Controls.Add(this.pictureBox4);
            this.pnl_tile.Controls.Add(this.pictureBox3);
            this.pnl_tile.Controls.Add(this.pictureBox2);
            this.pnl_tile.Location = new System.Drawing.Point(206, 39);
            this.pnl_tile.Name = "pnl_tile";
            this.pnl_tile.Size = new System.Drawing.Size(232, 165);
            this.pnl_tile.TabIndex = 4;
            this.pnl_tile.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(116, 82);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 83);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(1, 82);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(115, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_selectPic
            // 
            this.btn_selectPic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_selectPic.Location = new System.Drawing.Point(506, 51);
            this.btn_selectPic.Name = "btn_selectPic";
            this.btn_selectPic.Size = new System.Drawing.Size(103, 25);
            this.btn_selectPic.TabIndex = 3;
            this.btn_selectPic.Text = "انتخاب عکس";
            this.btn_selectPic.UseVisualStyleBackColor = true;
            this.btn_selectPic.Click += new System.EventHandler(this.btn_selectPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "موقعیت :";
            // 
            // cmb_picPosition
            // 
            this.cmb_picPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_picPosition.FormattingEnabled = true;
            this.cmb_picPosition.Items.AddRange(new object[] {
            "کاشی وار",
            "کشیده شده",
            "وسط"});
            this.cmb_picPosition.Location = new System.Drawing.Point(481, 146);
            this.cmb_picPosition.Name = "cmb_picPosition";
            this.cmb_picPosition.Size = new System.Drawing.Size(163, 21);
            this.cmb_picPosition.TabIndex = 1;
            this.cmb_picPosition.SelectedIndexChanged += new System.EventHandler(this.cmb_picPosition_SelectedIndexChanged);
            // 
            // pic_sampleScreen
            // 
            this.pic_sampleScreen.Location = new System.Drawing.Point(205, 39);
            this.pic_sampleScreen.Name = "pic_sampleScreen";
            this.pic_sampleScreen.Size = new System.Drawing.Size(232, 165);
            this.pic_sampleScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_sampleScreen.TabIndex = 1;
            this.pic_sampleScreen.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Novin.Properties.Resources.monitor2;
            this.pictureBox1.Location = new System.Drawing.Point(187, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pag_password
            // 
            this.pag_password.Controls.Add(this.listView_users);
            this.pag_password.Controls.Add(this.pnl_userManagment);
            this.pag_password.Controls.Add(this.pnl_userProp);
            this.pag_password.Controls.Add(this.lnk_createUserAccount);
            this.pag_password.Location = new System.Drawing.Point(4, 22);
            this.pag_password.Name = "pag_password";
            this.pag_password.Padding = new System.Windows.Forms.Padding(3);
            this.pag_password.Size = new System.Drawing.Size(659, 315);
            this.pag_password.TabIndex = 1;
            this.pag_password.Text = "کاربران";
            this.pag_password.UseVisualStyleBackColor = true;
            // 
            // listView_users
            // 
            this.listView_users.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView_users.LargeImageList = this.imageList1;
            this.listView_users.Location = new System.Drawing.Point(12, 34);
            this.listView_users.MultiSelect = false;
            this.listView_users.Name = "listView_users";
            this.listView_users.Size = new System.Drawing.Size(641, 129);
            this.listView_users.TabIndex = 14;
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
            // pnl_userManagment
            // 
            this.pnl_userManagment.Controls.Add(this.lnk_managePassword);
            this.pnl_userManagment.Controls.Add(this.lnk_deleteUserAccount);
            this.pnl_userManagment.Controls.Add(this.lnk_renameUserAccount);
            this.pnl_userManagment.Enabled = false;
            this.pnl_userManagment.Location = new System.Drawing.Point(12, 1);
            this.pnl_userManagment.Name = "pnl_userManagment";
            this.pnl_userManagment.Size = new System.Drawing.Size(458, 29);
            this.pnl_userManagment.TabIndex = 13;
            // 
            // lnk_managePassword
            // 
            this.lnk_managePassword.AutoSize = true;
            this.lnk_managePassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnk_managePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_managePassword.Location = new System.Drawing.Point(157, 2);
            this.lnk_managePassword.Name = "lnk_managePassword";
            this.lnk_managePassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnk_managePassword.Size = new System.Drawing.Size(75, 16);
            this.lnk_managePassword.TabIndex = 12;
            this.lnk_managePassword.TabStop = true;
            this.lnk_managePassword.Text = "ایجاد گذرواژه";
            this.lnk_managePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnk_managePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_managePassword_LinkClicked);
            // 
            // lnk_deleteUserAccount
            // 
            this.lnk_deleteUserAccount.AutoSize = true;
            this.lnk_deleteUserAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnk_deleteUserAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_deleteUserAccount.Location = new System.Drawing.Point(8, 2);
            this.lnk_deleteUserAccount.Name = "lnk_deleteUserAccount";
            this.lnk_deleteUserAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnk_deleteUserAccount.Size = new System.Drawing.Size(116, 16);
            this.lnk_deleteUserAccount.TabIndex = 3;
            this.lnk_deleteUserAccount.TabStop = true;
            this.lnk_deleteUserAccount.Text = "حذف حساب کاربری";
            this.lnk_deleteUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnk_deleteUserAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_deleteUserAccount_LinkClicked);
            // 
            // lnk_renameUserAccount
            // 
            this.lnk_renameUserAccount.AutoSize = true;
            this.lnk_renameUserAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnk_renameUserAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_renameUserAccount.Location = new System.Drawing.Point(303, 2);
            this.lnk_renameUserAccount.Name = "lnk_renameUserAccount";
            this.lnk_renameUserAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnk_renameUserAccount.Size = new System.Drawing.Size(134, 16);
            this.lnk_renameUserAccount.TabIndex = 2;
            this.lnk_renameUserAccount.TabStop = true;
            this.lnk_renameUserAccount.Text = "تغییر نام حساب کاربری";
            this.lnk_renameUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnk_renameUserAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_renameUserAccount_LinkClicked);
            // 
            // pnl_userProp
            // 
            this.pnl_userProp.Controls.Add(this.chkLst_Allocations);
            this.pnl_userProp.Controls.Add(this.label4);
            this.pnl_userProp.Controls.Add(this.cmb_accountType);
            this.pnl_userProp.Controls.Add(this.label3);
            this.pnl_userProp.Controls.Add(this.cmb_imagesNames);
            this.pnl_userProp.Controls.Add(this.lnk_browseForPic);
            this.pnl_userProp.Enabled = false;
            this.pnl_userProp.Location = new System.Drawing.Point(6, 169);
            this.pnl_userProp.Name = "pnl_userProp";
            this.pnl_userProp.Size = new System.Drawing.Size(650, 140);
            this.pnl_userProp.TabIndex = 11;
            // 
            // chkLst_Allocations
            // 
            this.chkLst_Allocations.CheckOnClick = true;
            this.chkLst_Allocations.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkLst_Allocations.FormattingEnabled = true;
            this.chkLst_Allocations.Items.AddRange(new object[] {
            "اجازه ورود داده",
            "اجازه تغییر داده ها",
            "اجازه حذف داده ها",
            "اجازه مشاهده دفتر روزنامه",
            "اجازه مشاهده دفتر کل",
            "اجازه مشاهده دفتر معین",
            "اجازه مشاهده معین پروژه ها",
            "اجازه مشاهده تراز آزمایشی",
            "اجازه مشاهده مانده حساب ها",
            "اجازه مشاهده ترازنامه",
            "اجازه مشاهده اسناد حسابداری",
            "اجازه تغییر در بانک اطلاعاتی",
            "اجازه تغییر ظاهر برنامه",
            "اجازه تغییر سرفصلهای حسابداری"});
            this.chkLst_Allocations.Location = new System.Drawing.Point(7, 3);
            this.chkLst_Allocations.Name = "chkLst_Allocations";
            this.chkLst_Allocations.Size = new System.Drawing.Size(240, 132);
            this.chkLst_Allocations.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(498, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "نوع حساب کاربری";
            // 
            // cmb_accountType
            // 
            this.cmb_accountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_accountType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_accountType.FormattingEnabled = true;
            this.cmb_accountType.Items.AddRange(new object[] {
            "برنامه نویس",
            "مدیر",
            "عادی",
            "سفارشی"});
            this.cmb_accountType.Location = new System.Drawing.Point(365, 53);
            this.cmb_accountType.Name = "cmb_accountType";
            this.cmb_accountType.Size = new System.Drawing.Size(127, 22);
            this.cmb_accountType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(529, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "تصویر";
            // 
            // cmb_imagesNames
            // 
            this.cmb_imagesNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_imagesNames.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_imagesNames.FormattingEnabled = true;
            this.cmb_imagesNames.Items.AddRange(new object[] {
            "جمکران",
            "پرنده",
            "ماشین",
            "عقاب",
            "ماهی",
            "اسب",
            "نهنگ",
            "پنگوئن",
            "طبیعت 1",
            "سفارشی..."});
            this.cmb_imagesNames.Location = new System.Drawing.Point(365, 25);
            this.cmb_imagesNames.Name = "cmb_imagesNames";
            this.cmb_imagesNames.Size = new System.Drawing.Size(127, 22);
            this.cmb_imagesNames.TabIndex = 6;
            this.cmb_imagesNames.SelectionChangeCommitted += new System.EventHandler(this.cmb_imagesNames_SelectionChangeCommitted);
            this.cmb_imagesNames.SelectedIndexChanged += new System.EventHandler(this.cmb_imagesNames_SelectedIndexChanged);
            // 
            // lnk_browseForPic
            // 
            this.lnk_browseForPic.AutoSize = true;
            this.lnk_browseForPic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnk_browseForPic.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_browseForPic.Location = new System.Drawing.Point(264, 31);
            this.lnk_browseForPic.Name = "lnk_browseForPic";
            this.lnk_browseForPic.Size = new System.Drawing.Size(95, 16);
            this.lnk_browseForPic.TabIndex = 5;
            this.lnk_browseForPic.TabStop = true;
            this.lnk_browseForPic.Text = "جستجوی تصویر";
            this.lnk_browseForPic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_browseForPic_LinkClicked);
            // 
            // lnk_createUserAccount
            // 
            this.lnk_createUserAccount.AutoSize = true;
            this.lnk_createUserAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnk_createUserAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_createUserAccount.Location = new System.Drawing.Point(487, 3);
            this.lnk_createUserAccount.Name = "lnk_createUserAccount";
            this.lnk_createUserAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lnk_createUserAccount.Size = new System.Drawing.Size(146, 16);
            this.lnk_createUserAccount.TabIndex = 1;
            this.lnk_createUserAccount.TabStop = true;
            this.lnk_createUserAccount.Text = "ایجاد حساب کاربری جدید";
            this.lnk_createUserAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_createUserAccount_LinkClicked);
            // 
            // pag_general
            // 
            this.pag_general.Controls.Add(this.btn_brosweTheBank);
            this.pag_general.Controls.Add(this.label9);
            this.pag_general.Controls.Add(this.tbx_bankPath);
            this.pag_general.Controls.Add(this.btn_browseBackupPath);
            this.pag_general.Controls.Add(this.label8);
            this.pag_general.Controls.Add(this.tbx_backupPath);
            this.pag_general.Location = new System.Drawing.Point(4, 22);
            this.pag_general.Name = "pag_general";
            this.pag_general.Padding = new System.Windows.Forms.Padding(3);
            this.pag_general.Size = new System.Drawing.Size(659, 315);
            this.pag_general.TabIndex = 2;
            this.pag_general.Text = "عمومی";
            this.pag_general.UseVisualStyleBackColor = true;
            // 
            // btn_brosweTheBank
            // 
            this.btn_brosweTheBank.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_brosweTheBank.Location = new System.Drawing.Point(441, 134);
            this.btn_brosweTheBank.Name = "btn_brosweTheBank";
            this.btn_brosweTheBank.Size = new System.Drawing.Size(103, 30);
            this.btn_brosweTheBank.TabIndex = 15;
            this.btn_brosweTheBank.Text = "انتخاب مسیر";
            this.btn_brosweTheBank.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(231, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "مسیر بانک برنامه";
            // 
            // tbx_bankPath
            // 
            this.tbx_bankPath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_bankPath.Location = new System.Drawing.Point(114, 137);
            this.tbx_bankPath.Name = "tbx_bankPath";
            this.tbx_bankPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_bankPath.Size = new System.Drawing.Size(321, 25);
            this.tbx_bankPath.TabIndex = 13;
            // 
            // btn_browseBackupPath
            // 
            this.btn_browseBackupPath.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_browseBackupPath.Location = new System.Drawing.Point(441, 82);
            this.btn_browseBackupPath.Name = "btn_browseBackupPath";
            this.btn_browseBackupPath.Size = new System.Drawing.Size(103, 30);
            this.btn_browseBackupPath.TabIndex = 12;
            this.btn_browseBackupPath.Text = "انتخاب مسیر";
            this.btn_browseBackupPath.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "مسیر پیش فرض نسخه پشتیبان";
            // 
            // tbx_backupPath
            // 
            this.tbx_backupPath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_backupPath.Location = new System.Drawing.Point(114, 85);
            this.tbx_backupPath.Name = "tbx_backupPath";
            this.tbx_backupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_backupPath.Size = new System.Drawing.Size(321, 25);
            this.tbx_backupPath.TabIndex = 10;
            // 
            // pag_reminder
            // 
            this.pag_reminder.Controls.Add(this.pnl_playSound);
            this.pag_reminder.Controls.Add(this.chk_playSoundOnTime);
            this.pag_reminder.Controls.Add(this.btn_runReminder);
            this.pag_reminder.Location = new System.Drawing.Point(4, 22);
            this.pag_reminder.Name = "pag_reminder";
            this.pag_reminder.Padding = new System.Windows.Forms.Padding(3);
            this.pag_reminder.Size = new System.Drawing.Size(659, 315);
            this.pag_reminder.TabIndex = 3;
            this.pag_reminder.Text = "یادآورنده";
            this.pag_reminder.UseVisualStyleBackColor = true;
            // 
            // pnl_playSound
            // 
            this.pnl_playSound.Controls.Add(this.button1);
            this.pnl_playSound.Controls.Add(this.btn_selectSound);
            this.pnl_playSound.Controls.Add(this.tbx_reminderSoundPath);
            this.pnl_playSound.Controls.Add(this.btn_play);
            this.pnl_playSound.Location = new System.Drawing.Point(39, 178);
            this.pnl_playSound.Name = "pnl_playSound";
            this.pnl_playSound.Size = new System.Drawing.Size(580, 65);
            this.pnl_playSound.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(517, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 35);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_selectSound
            // 
            this.btn_selectSound.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_selectSound.Location = new System.Drawing.Point(23, 15);
            this.btn_selectSound.Name = "btn_selectSound";
            this.btn_selectSound.Size = new System.Drawing.Size(103, 32);
            this.btn_selectSound.TabIndex = 11;
            this.btn_selectSound.Text = "انتخاب صدا";
            this.btn_selectSound.UseVisualStyleBackColor = true;
            // 
            // tbx_reminderSoundPath
            // 
            this.tbx_reminderSoundPath.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_reminderSoundPath.Location = new System.Drawing.Point(132, 20);
            this.tbx_reminderSoundPath.Name = "tbx_reminderSoundPath";
            this.tbx_reminderSoundPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_reminderSoundPath.Size = new System.Drawing.Size(334, 25);
            this.tbx_reminderSoundPath.TabIndex = 10;
            // 
            // btn_play
            // 
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_play.Location = new System.Drawing.Point(472, 15);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(42, 35);
            this.btn_play.TabIndex = 12;
            this.btn_play.UseVisualStyleBackColor = true;
            // 
            // chk_playSoundOnTime
            // 
            this.chk_playSoundOnTime.AutoSize = true;
            this.chk_playSoundOnTime.Checked = true;
            this.chk_playSoundOnTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_playSoundOnTime.Location = new System.Drawing.Point(334, 138);
            this.chk_playSoundOnTime.Name = "chk_playSoundOnTime";
            this.chk_playSoundOnTime.Size = new System.Drawing.Size(218, 17);
            this.chk_playSoundOnTime.TabIndex = 9;
            this.chk_playSoundOnTime.Text = "پخش صدای زیر هنگام رسیدن زمان نمایش";
            this.chk_playSoundOnTime.UseVisualStyleBackColor = true;
            // 
            // btn_runReminder
            // 
            this.btn_runReminder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_runReminder.Location = new System.Drawing.Point(242, 27);
            this.btn_runReminder.Name = "btn_runReminder";
            this.btn_runReminder.Size = new System.Drawing.Size(178, 28);
            this.btn_runReminder.TabIndex = 7;
            this.btn_runReminder.Text = "اجرای برنامه یادآورنده";
            this.btn_runReminder.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(509, 364);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 55;
            this.btn_ok.Text = "تــــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(428, 364);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 56;
            this.btn_cancel.Text = "انــــصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
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
            // tbl_usersTableAdapter
            // 
            this.tbl_usersTableAdapter.ClearBeforeFill = true;
            // 
            // ofd_pic
            // 
            this.ofd_pic.FileName = "openFileDialog1";
            // 
            // frm_preferences
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(687, 399);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tabs);
            this.Name = "frm_preferences";
            this.Text = "    تنظیمات نرم افزار";
            this.Load += new System.EventHandler(this.frm_preferences_Load);
            this.tabs.ResumeLayout(false);
            this.pag_desktop.ResumeLayout(false);
            this.pag_desktop.PerformLayout();
            this.pnl_delayGroup.ResumeLayout(false);
            this.pnl_delayGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_seconds)).EndInit();
            this.pnl_tile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sampleScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pag_password.ResumeLayout(false);
            this.pag_password.PerformLayout();
            this.pnl_userManagment.ResumeLayout(false);
            this.pnl_userManagment.PerformLayout();
            this.pnl_userProp.ResumeLayout(false);
            this.pnl_userProp.PerformLayout();
            this.pag_general.ResumeLayout(false);
            this.pag_general.PerformLayout();
            this.pag_reminder.ResumeLayout(false);
            this.pag_reminder.PerformLayout();
            this.pnl_playSound.ResumeLayout(false);
            this.pnl_playSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage pag_desktop;
        private System.Windows.Forms.Panel pnl_delayGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_seconds;
        private System.Windows.Forms.CheckBox chk_showSamePathPic;
        private System.Windows.Forms.CheckBox chk_showMainMenu;
        private System.Windows.Forms.TextBox tbx_path;
        private System.Windows.Forms.Panel pnl_tile;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_selectPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_picPosition;
        private System.Windows.Forms.PictureBox pic_sampleScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage pag_password;
        private System.Windows.Forms.ListView listView_users;
        private System.Windows.Forms.Panel pnl_userManagment;
        private System.Windows.Forms.LinkLabel lnk_managePassword;
        private System.Windows.Forms.LinkLabel lnk_deleteUserAccount;
        private System.Windows.Forms.LinkLabel lnk_renameUserAccount;
        private System.Windows.Forms.Panel pnl_userProp;
        private System.Windows.Forms.CheckedListBox chkLst_Allocations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_accountType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_imagesNames;
        private System.Windows.Forms.LinkLabel lnk_browseForPic;
        private System.Windows.Forms.LinkLabel lnk_createUserAccount;
        private System.Windows.Forms.TabPage pag_general;
        private System.Windows.Forms.Button btn_brosweTheBank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_bankPath;
        private System.Windows.Forms.Button btn_browseBackupPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_backupPath;
        private System.Windows.Forms.TabPage pag_reminder;
        private System.Windows.Forms.Panel pnl_playSound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_selectSound;
        private System.Windows.Forms.TextBox tbx_reminderSoundPath;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.CheckBox chk_playSoundOnTime;
        private System.Windows.Forms.Button btn_runReminder;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private ds_users ds_users;
        private System.Windows.Forms.BindingSource bs_users;
        private Novin.ds_usersTableAdapters.tbl_usersTableAdapter tbl_usersTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog ofd_pic;
        private System.Windows.Forms.FolderBrowserDialog fbd_;
    }
}
