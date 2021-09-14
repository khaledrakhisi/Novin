namespace Novin
{
    partial class frm_persons
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
            this.bs_persons = new System.Windows.Forms.BindingSource(this.components);
            this.ds_persons = new Novin.ds_persons();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_modifyPersonProperties = new System.Windows.Forms.Button();
            this.btn_deletePerson = new System.Windows.Forms.Button();
            this.btn_renamePerosn = new System.Windows.Forms.Button();
            this.btn_newPerson = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.bs_zones = new System.Windows.Forms.BindingSource(this.components);
            this.bs_visitors = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_deletePic = new System.Windows.Forms.Button();
            this.btn_choosepicture = new System.Windows.Forms.Button();
            this.pic_personFace = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_familyAndName = new System.Windows.Forms.ComboBox();
            this.tbl_personsTableAdapter = new Novin.ds_personsTableAdapters.tbl_personsTableAdapter();
            this.tableAdapterManager = new Novin.ds_personsTableAdapters.TableAdapterManager();
            this.tbl_visitorsTableAdapter = new Novin.ds_personsTableAdapters.tbl_visitorsTableAdapter();
            this.tbl_zonesTableAdapter = new Novin.ds_personsTableAdapters.tbl_zonesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbx_discountPercent = new System.Windows.Forms.TextBox();
            this.tbx_creditCeil = new System.Windows.Forms.TextBox();
            this.tab_Person = new System.Windows.Forms.TabControl();
            this.pag_general = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_address2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_address1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_ccode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_aliasName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_nationalNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_personelNumber = new System.Windows.Forms.TextBox();
            this.pag_money = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_isPersonel = new System.Windows.Forms.CheckBox();
            this.chk_isInterface = new System.Windows.Forms.CheckBox();
            this.chk_isSeller = new System.Windows.Forms.CheckBox();
            this.chk_isCustomer = new System.Windows.Forms.CheckBox();
            this.lbl_creditCeilInChars = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.num_rangePrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grp_RadioButtons = new System.Windows.Forms.GroupBox();
            this.lbl_priceInChars = new System.Windows.Forms.Label();
            this.pnl_beforeMoney = new System.Windows.Forms.Panel();
            this.tbx_indebtedOrCreditorPrice = new System.Windows.Forms.TextBox();
            this.lbl_beforeRemainMoneyPrompt = new System.Windows.Forms.Label();
            this.rdu_creditorBefore = new System.Windows.Forms.RadioButton();
            this.rdu_indebtedBefore = new System.Windows.Forms.RadioButton();
            this.rdu_NoBeforeMoney = new System.Windows.Forms.RadioButton();
            this.btn_print = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_zones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_visitors)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tab_Person.SuspendLayout();
            this.pag_general.SuspendLayout();
            this.pag_money.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rangePrice)).BeginInit();
            this.grp_RadioButtons.SuspendLayout();
            this.pnl_beforeMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // bs_persons
            // 
            this.bs_persons.DataMember = "tbl_persons";
            this.bs_persons.DataSource = this.ds_persons;
            this.bs_persons.CurrentChanged += new System.EventHandler(this.bs_persons_CurrentChanged);
            // 
            // ds_persons
            // 
            this.ds_persons.DataSetName = "ds_persons";
            this.ds_persons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_modifyPersonProperties);
            this.groupBox1.Controls.Add(this.btn_deletePerson);
            this.groupBox1.Controls.Add(this.btn_renamePerosn);
            this.groupBox1.Controls.Add(this.btn_newPerson);
            this.groupBox1.Location = new System.Drawing.Point(45, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(453, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_modifyPersonProperties
            // 
            this.btn_modifyPersonProperties.BackColor = System.Drawing.Color.Azure;
            this.btn_modifyPersonProperties.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_modifyPersonProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_modifyPersonProperties.Location = new System.Drawing.Point(117, 19);
            this.btn_modifyPersonProperties.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modifyPersonProperties.Name = "btn_modifyPersonProperties";
            this.btn_modifyPersonProperties.Size = new System.Drawing.Size(103, 23);
            this.btn_modifyPersonProperties.TabIndex = 2;
            this.btn_modifyPersonProperties.Text = "ذخیره تغییرات";
            this.btn_modifyPersonProperties.UseVisualStyleBackColor = false;
            this.btn_modifyPersonProperties.Click += new System.EventHandler(this.btn_modifyPersonProperties_Click);
            // 
            // btn_deletePerson
            // 
            this.btn_deletePerson.BackColor = System.Drawing.Color.Azure;
            this.btn_deletePerson.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deletePerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deletePerson.Location = new System.Drawing.Point(6, 19);
            this.btn_deletePerson.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deletePerson.Name = "btn_deletePerson";
            this.btn_deletePerson.Size = new System.Drawing.Size(107, 23);
            this.btn_deletePerson.TabIndex = 3;
            this.btn_deletePerson.Text = "حذف طرف حساب";
            this.btn_deletePerson.UseVisualStyleBackColor = false;
            this.btn_deletePerson.Click += new System.EventHandler(this.btn_deletePerson_Click);
            // 
            // btn_renamePerosn
            // 
            this.btn_renamePerosn.BackColor = System.Drawing.Color.Azure;
            this.btn_renamePerosn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_renamePerosn.Location = new System.Drawing.Point(224, 19);
            this.btn_renamePerosn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_renamePerosn.Name = "btn_renamePerosn";
            this.btn_renamePerosn.Size = new System.Drawing.Size(91, 23);
            this.btn_renamePerosn.TabIndex = 1;
            this.btn_renamePerosn.Text = "تغییر نام";
            this.btn_renamePerosn.UseVisualStyleBackColor = false;
            this.btn_renamePerosn.Click += new System.EventHandler(this.btn_renamePerosn_Click);
            // 
            // btn_newPerson
            // 
            this.btn_newPerson.BackColor = System.Drawing.Color.Azure;
            this.btn_newPerson.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newPerson.ForeColor = System.Drawing.Color.Green;
            this.btn_newPerson.Location = new System.Drawing.Point(319, 19);
            this.btn_newPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newPerson.Name = "btn_newPerson";
            this.btn_newPerson.Size = new System.Drawing.Size(127, 23);
            this.btn_newPerson.TabIndex = 0;
            this.btn_newPerson.Text = "* طرف حساب جدید";
            this.btn_newPerson.UseVisualStyleBackColor = false;
            this.btn_newPerson.Click += new System.EventHandler(this.btn_newPerson_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(26, 454);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "بستن";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // bs_zones
            // 
            this.bs_zones.DataMember = "tbl_zones";
            this.bs_zones.DataSource = this.ds_persons;
            // 
            // bs_visitors
            // 
            this.bs_visitors.DataMember = "tbl_visitors";
            this.bs_visitors.DataSource = this.ds_persons;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btn_deletePic);
            this.groupBox4.Controls.Add(this.btn_choosepicture);
            this.groupBox4.Controls.Add(this.pic_personFace);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmb_familyAndName);
            this.groupBox4.Location = new System.Drawing.Point(16, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 86);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // btn_deletePic
            // 
            this.btn_deletePic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deletePic.Location = new System.Drawing.Point(82, 49);
            this.btn_deletePic.Name = "btn_deletePic";
            this.btn_deletePic.Size = new System.Drawing.Size(92, 23);
            this.btn_deletePic.TabIndex = 28;
            this.btn_deletePic.Text = "حذف عکس";
            this.btn_deletePic.UseVisualStyleBackColor = true;
            this.btn_deletePic.Click += new System.EventHandler(this.btn_deletePic_Click);
            // 
            // btn_choosepicture
            // 
            this.btn_choosepicture.Location = new System.Drawing.Point(82, 20);
            this.btn_choosepicture.Name = "btn_choosepicture";
            this.btn_choosepicture.Size = new System.Drawing.Size(92, 23);
            this.btn_choosepicture.TabIndex = 27;
            this.btn_choosepicture.Text = "تخصیص عکس";
            this.btn_choosepicture.UseVisualStyleBackColor = true;
            this.btn_choosepicture.Click += new System.EventHandler(this.btn_choosepicture_Click);
            // 
            // pic_personFace
            // 
            this.pic_personFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_personFace.Location = new System.Drawing.Point(10, 20);
            this.pic_personFace.Margin = new System.Windows.Forms.Padding(2);
            this.pic_personFace.Name = "pic_personFace";
            this.pic_personFace.Size = new System.Drawing.Size(67, 52);
            this.pic_personFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_personFace.TabIndex = 26;
            this.pic_personFace.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(305, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 14);
            this.label1.TabIndex = 25;
            this.label1.Text = "نام خانوادگی و نام طرف حساب :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb_familyAndName
            // 
            this.cmb_familyAndName.DataSource = this.bs_persons;
            this.cmb_familyAndName.DisplayMember = "person_familyAndName";
            this.cmb_familyAndName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_familyAndName.FormattingEnabled = true;
            this.cmb_familyAndName.Location = new System.Drawing.Point(211, 52);
            this.cmb_familyAndName.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_familyAndName.MaxDropDownItems = 10;
            this.cmb_familyAndName.Name = "cmb_familyAndName";
            this.cmb_familyAndName.Size = new System.Drawing.Size(271, 22);
            this.cmb_familyAndName.TabIndex = 24;
            this.cmb_familyAndName.ValueMember = "person_id";
            this.cmb_familyAndName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_familyAndName_KeyPress);
            // 
            // tbl_personsTableAdapter
            // 
            this.tbl_personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_personsTableAdapter = this.tbl_personsTableAdapter;
            this.tableAdapterManager.tbl_visitorsTableAdapter = this.tbl_visitorsTableAdapter;
            this.tableAdapterManager.tbl_zonesTableAdapter = this.tbl_zonesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Novin.ds_personsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_visitorsTableAdapter
            // 
            this.tbl_visitorsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_zonesTableAdapter
            // 
            this.tbl_zonesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataMember = "";
            this.errorProvider1.DataSource = this.bs_persons;
            this.errorProvider1.RightToLeft = true;
            // 
            // tbx_discountPercent
            // 
            this.tbx_discountPercent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_discountPercent", true));
            this.errorProvider1.SetError(this.tbx_discountPercent, "درصد تخفیف عددی بین 1 تا 100 می باشد");
            this.tbx_discountPercent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_discountPercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbx_discountPercent.Location = new System.Drawing.Point(336, 102);
            this.tbx_discountPercent.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_discountPercent.Name = "tbx_discountPercent";
            this.tbx_discountPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_discountPercent.Size = new System.Drawing.Size(40, 22);
            this.tbx_discountPercent.TabIndex = 20;
            this.tbx_discountPercent.Text = "0";
            this.tbx_discountPercent.TextChanged += new System.EventHandler(this.tbx_discountPercent_TextChanged);
            this.tbx_discountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_nationalNumber_KeyPress);
            // 
            // tbx_creditCeil
            // 
            this.tbx_creditCeil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_creditCeil", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbx_creditCeil.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_creditCeil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbx_creditCeil.Location = new System.Drawing.Point(20, 149);
            this.tbx_creditCeil.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_creditCeil.Name = "tbx_creditCeil";
            this.tbx_creditCeil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_creditCeil.Size = new System.Drawing.Size(172, 22);
            this.tbx_creditCeil.TabIndex = 34;
            this.tbx_creditCeil.Text = "0";
            this.tbx_creditCeil.TextChanged += new System.EventHandler(this.tbx_creditCeil_TextChanged);
            this.tbx_creditCeil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_creditCeil_KeyPress);
            // 
            // tab_Person
            // 
            this.tab_Person.Controls.Add(this.pag_general);
            this.tab_Person.Controls.Add(this.pag_money);
            this.tab_Person.Location = new System.Drawing.Point(21, 158);
            this.tab_Person.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Person.Name = "tab_Person";
            this.tab_Person.RightToLeftLayout = true;
            this.tab_Person.SelectedIndex = 0;
            this.tab_Person.Size = new System.Drawing.Size(497, 291);
            this.tab_Person.TabIndex = 26;
            // 
            // pag_general
            // 
            this.pag_general.Controls.Add(this.label14);
            this.pag_general.Controls.Add(this.textBox2);
            this.pag_general.Controls.Add(this.label13);
            this.pag_general.Controls.Add(this.textBox1);
            this.pag_general.Controls.Add(this.label12);
            this.pag_general.Controls.Add(this.tbx_comment);
            this.pag_general.Controls.Add(this.label11);
            this.pag_general.Controls.Add(this.tbx_address2);
            this.pag_general.Controls.Add(this.label10);
            this.pag_general.Controls.Add(this.tbx_address1);
            this.pag_general.Controls.Add(this.label7);
            this.pag_general.Controls.Add(this.tbx_ccode);
            this.pag_general.Controls.Add(this.label6);
            this.pag_general.Controls.Add(this.tbx_aliasName);
            this.pag_general.Controls.Add(this.label4);
            this.pag_general.Controls.Add(this.tbx_phone);
            this.pag_general.Controls.Add(this.label3);
            this.pag_general.Controls.Add(this.tbx_nationalNumber);
            this.pag_general.Controls.Add(this.label2);
            this.pag_general.Controls.Add(this.tbx_personelNumber);
            this.pag_general.Location = new System.Drawing.Point(4, 23);
            this.pag_general.Margin = new System.Windows.Forms.Padding(2);
            this.pag_general.Name = "pag_general";
            this.pag_general.Padding = new System.Windows.Forms.Padding(2);
            this.pag_general.Size = new System.Drawing.Size(489, 264);
            this.pag_general.TabIndex = 0;
            this.pag_general.Text = "اطلاعات شخصی";
            this.pag_general.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(385, 94);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 14);
            this.label14.TabIndex = 34;
            this.label14.Text = "تلفن دوم :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_phone2", true));
            this.textBox2.Location = new System.Drawing.Point(247, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 14);
            this.label13.TabIndex = 32;
            this.label13.Text = "همراه :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_mobile", true));
            this.textBox1.Location = new System.Drawing.Point(15, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(379, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 60);
            this.label12.TabIndex = 30;
            this.label12.Text = "توضیحات :";
            // 
            // tbx_comment
            // 
            this.tbx_comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_comment", true));
            this.tbx_comment.Location = new System.Drawing.Point(15, 179);
            this.tbx_comment.Multiline = true;
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(363, 63);
            this.tbx_comment.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "آدرس منزل";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_address2
            // 
            this.tbx_address2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_address2", true));
            this.tbx_address2.Location = new System.Drawing.Point(14, 150);
            this.tbx_address2.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_address2.Name = "tbx_address2";
            this.tbx_address2.Size = new System.Drawing.Size(364, 22);
            this.tbx_address2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "آدرس محل کار";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_address1
            // 
            this.tbx_address1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_address1", true));
            this.tbx_address1.Location = new System.Drawing.Point(14, 124);
            this.tbx_address1.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_address1.Name = "tbx_address1";
            this.tbx_address1.Size = new System.Drawing.Size(364, 22);
            this.tbx_address1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "شماره پرسنلی :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_ccode
            // 
            this.tbx_ccode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_ccode", true));
            this.tbx_ccode.Location = new System.Drawing.Point(15, 38);
            this.tbx_ccode.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_ccode.Name = "tbx_ccode";
            this.tbx_ccode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_ccode.Size = new System.Drawing.Size(120, 22);
            this.tbx_ccode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "عنوان تابلو :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_aliasName
            // 
            this.tbx_aliasName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_aliasName", true));
            this.tbx_aliasName.Location = new System.Drawing.Point(15, 10);
            this.tbx_aliasName.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_aliasName.Name = "tbx_aliasName";
            this.tbx_aliasName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_aliasName.Size = new System.Drawing.Size(120, 22);
            this.tbx_aliasName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "تلفن :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_phone
            // 
            this.tbx_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_phone", true));
            this.tbx_phone.Location = new System.Drawing.Point(247, 65);
            this.tbx_phone.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_phone.Size = new System.Drawing.Size(120, 22);
            this.tbx_phone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "کد ملی :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_nationalNumber
            // 
            this.tbx_nationalNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_nationalNum", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbx_nationalNumber.Location = new System.Drawing.Point(247, 39);
            this.tbx_nationalNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_nationalNumber.Name = "tbx_nationalNumber";
            this.tbx_nationalNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_nationalNumber.Size = new System.Drawing.Size(120, 22);
            this.tbx_nationalNumber.TabIndex = 1;
            this.tbx_nationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_nationalNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "کد :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_personelNumber
            // 
            this.tbx_personelNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_id", true));
            this.tbx_personelNumber.Location = new System.Drawing.Point(247, 13);
            this.tbx_personelNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_personelNumber.Name = "tbx_personelNumber";
            this.tbx_personelNumber.ReadOnly = true;
            this.tbx_personelNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_personelNumber.Size = new System.Drawing.Size(120, 22);
            this.tbx_personelNumber.TabIndex = 0;
            // 
            // pag_money
            // 
            this.pag_money.Controls.Add(this.groupBox2);
            this.pag_money.Controls.Add(this.lbl_creditCeilInChars);
            this.pag_money.Controls.Add(this.label15);
            this.pag_money.Controls.Add(this.tbx_creditCeil);
            this.pag_money.Controls.Add(this.num_rangePrice);
            this.pag_money.Controls.Add(this.label8);
            this.pag_money.Controls.Add(this.label9);
            this.pag_money.Controls.Add(this.comboBox2);
            this.pag_money.Controls.Add(this.label5);
            this.pag_money.Controls.Add(this.tbx_discountPercent);
            this.pag_money.Controls.Add(this.grp_RadioButtons);
            this.pag_money.Location = new System.Drawing.Point(4, 22);
            this.pag_money.Margin = new System.Windows.Forms.Padding(2);
            this.pag_money.Name = "pag_money";
            this.pag_money.Padding = new System.Windows.Forms.Padding(2);
            this.pag_money.Size = new System.Drawing.Size(489, 265);
            this.pag_money.TabIndex = 1;
            this.pag_money.Text = "اطلاعات مالی و کاری";
            this.pag_money.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_isPersonel);
            this.groupBox2.Controls.Add(this.chk_isInterface);
            this.groupBox2.Controls.Add(this.chk_isSeller);
            this.groupBox2.Controls.Add(this.chk_isCustomer);
            this.groupBox2.Location = new System.Drawing.Point(314, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 113);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوع طرف حساب";
            // 
            // chk_isPersonel
            // 
            this.chk_isPersonel.AutoSize = true;
            this.chk_isPersonel.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_persons, "person_isPersonel", true));
            this.chk_isPersonel.Location = new System.Drawing.Point(74, 88);
            this.chk_isPersonel.Name = "chk_isPersonel";
            this.chk_isPersonel.Size = new System.Drawing.Size(66, 18);
            this.chk_isPersonel.TabIndex = 33;
            this.chk_isPersonel.Text = "کـــارمند";
            this.chk_isPersonel.UseVisualStyleBackColor = true;
            // 
            // chk_isInterface
            // 
            this.chk_isInterface.AutoSize = true;
            this.chk_isInterface.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_persons, "person_isInter", true));
            this.chk_isInterface.Location = new System.Drawing.Point(74, 64);
            this.chk_isInterface.Name = "chk_isInterface";
            this.chk_isInterface.Size = new System.Drawing.Size(66, 18);
            this.chk_isInterface.TabIndex = 24;
            this.chk_isInterface.Text = "واســــط";
            this.chk_isInterface.UseVisualStyleBackColor = true;
            // 
            // chk_isSeller
            // 
            this.chk_isSeller.AutoSize = true;
            this.chk_isSeller.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_persons, "person_isSeller", true));
            this.chk_isSeller.Location = new System.Drawing.Point(55, 40);
            this.chk_isSeller.Name = "chk_isSeller";
            this.chk_isSeller.Size = new System.Drawing.Size(85, 18);
            this.chk_isSeller.TabIndex = 23;
            this.chk_isSeller.Text = "فـــــروشنده";
            this.chk_isSeller.UseVisualStyleBackColor = true;
            // 
            // chk_isCustomer
            // 
            this.chk_isCustomer.AutoSize = true;
            this.chk_isCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_persons, "person_isCustomer", true));
            this.chk_isCustomer.Location = new System.Drawing.Point(64, 16);
            this.chk_isCustomer.Name = "chk_isCustomer";
            this.chk_isCustomer.Size = new System.Drawing.Size(76, 18);
            this.chk_isCustomer.TabIndex = 22;
            this.chk_isCustomer.Text = "مــــشتری";
            this.chk_isCustomer.UseVisualStyleBackColor = true;
            // 
            // lbl_creditCeilInChars
            // 
            this.lbl_creditCeilInChars.AutoEllipsis = true;
            this.lbl_creditCeilInChars.ForeColor = System.Drawing.Color.Black;
            this.lbl_creditCeilInChars.Location = new System.Drawing.Point(17, 184);
            this.lbl_creditCeilInChars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_creditCeilInChars.Name = "lbl_creditCeilInChars";
            this.lbl_creditCeilInChars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_creditCeilInChars.Size = new System.Drawing.Size(248, 68);
            this.lbl_creditCeilInChars.TabIndex = 36;
            this.lbl_creditCeilInChars.Text = "صفر ریال";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(196, 152);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "حــد اعــتبار :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // num_rangePrice
            // 
            this.num_rangePrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_persons, "person_rangePrice", true));
            this.num_rangePrice.Location = new System.Drawing.Point(204, 103);
            this.num_rangePrice.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_rangePrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_rangePrice.Name = "num_rangePrice";
            this.num_rangePrice.Size = new System.Drawing.Size(43, 22);
            this.num_rangePrice.TabIndex = 32;
            this.num_rangePrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 14);
            this.label8.TabIndex = 30;
            this.label8.Text = "رنج قیمت :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 14);
            this.label9.TabIndex = 28;
            this.label9.Text = "منطقه :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_persons, "zone_id", true));
            this.comboBox2.DataSource = this.bs_zones;
            this.comboBox2.DisplayMember = "zone_title";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(20, 105);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.MaxDropDownItems = 10;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 22);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.ValueMember = "zone_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "درصد تخفیف :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grp_RadioButtons
            // 
            this.grp_RadioButtons.Controls.Add(this.lbl_priceInChars);
            this.grp_RadioButtons.Controls.Add(this.pnl_beforeMoney);
            this.grp_RadioButtons.Controls.Add(this.rdu_creditorBefore);
            this.grp_RadioButtons.Controls.Add(this.rdu_indebtedBefore);
            this.grp_RadioButtons.Controls.Add(this.rdu_NoBeforeMoney);
            this.grp_RadioButtons.Location = new System.Drawing.Point(17, 8);
            this.grp_RadioButtons.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RadioButtons.Name = "grp_RadioButtons";
            this.grp_RadioButtons.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RadioButtons.Size = new System.Drawing.Size(453, 90);
            this.grp_RadioButtons.TabIndex = 0;
            this.grp_RadioButtons.TabStop = false;
            this.grp_RadioButtons.Text = "مانده قبلی";
            // 
            // lbl_priceInChars
            // 
            this.lbl_priceInChars.AutoEllipsis = true;
            this.lbl_priceInChars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_priceInChars.Location = new System.Drawing.Point(8, 52);
            this.lbl_priceInChars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_priceInChars.Name = "lbl_priceInChars";
            this.lbl_priceInChars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_priceInChars.Size = new System.Drawing.Size(429, 26);
            this.lbl_priceInChars.TabIndex = 29;
            this.lbl_priceInChars.Text = "صفر ریال";
            // 
            // pnl_beforeMoney
            // 
            this.pnl_beforeMoney.Controls.Add(this.tbx_indebtedOrCreditorPrice);
            this.pnl_beforeMoney.Controls.Add(this.lbl_beforeRemainMoneyPrompt);
            this.pnl_beforeMoney.Location = new System.Drawing.Point(8, 16);
            this.pnl_beforeMoney.Name = "pnl_beforeMoney";
            this.pnl_beforeMoney.Size = new System.Drawing.Size(214, 36);
            this.pnl_beforeMoney.TabIndex = 22;
            this.pnl_beforeMoney.Visible = false;
            // 
            // tbx_indebtedOrCreditorPrice
            // 
            this.tbx_indebtedOrCreditorPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_remainMoney", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbx_indebtedOrCreditorPrice.Location = new System.Drawing.Point(6, 5);
            this.tbx_indebtedOrCreditorPrice.Name = "tbx_indebtedOrCreditorPrice";
            this.tbx_indebtedOrCreditorPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_indebtedOrCreditorPrice.Size = new System.Drawing.Size(125, 22);
            this.tbx_indebtedOrCreditorPrice.TabIndex = 30;
            this.tbx_indebtedOrCreditorPrice.TextChanged += new System.EventHandler(this.tbx_indebtedOrCreditorPrice_TextChanged);
            this.tbx_indebtedOrCreditorPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_nationalNumber_KeyPress);
            // 
            // lbl_beforeRemainMoneyPrompt
            // 
            this.lbl_beforeRemainMoneyPrompt.AutoSize = true;
            this.lbl_beforeRemainMoneyPrompt.Location = new System.Drawing.Point(136, 5);
            this.lbl_beforeRemainMoneyPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_beforeRemainMoneyPrompt.Name = "lbl_beforeRemainMoneyPrompt";
            this.lbl_beforeRemainMoneyPrompt.Size = new System.Drawing.Size(74, 14);
            this.lbl_beforeRemainMoneyPrompt.TabIndex = 19;
            this.lbl_beforeRemainMoneyPrompt.Text = "مبلغ بدهکاری";
            this.lbl_beforeRemainMoneyPrompt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdu_creditorBefore
            // 
            this.rdu_creditorBefore.AutoSize = true;
            this.rdu_creditorBefore.Location = new System.Drawing.Point(227, 16);
            this.rdu_creditorBefore.Margin = new System.Windows.Forms.Padding(2);
            this.rdu_creditorBefore.Name = "rdu_creditorBefore";
            this.rdu_creditorBefore.Size = new System.Drawing.Size(66, 18);
            this.rdu_creditorBefore.TabIndex = 2;
            this.rdu_creditorBefore.Text = "بستانکار";
            this.rdu_creditorBefore.UseVisualStyleBackColor = true;
            this.rdu_creditorBefore.CheckedChanged += new System.EventHandler(this.rdu_creditorBefore_CheckedChanged);
            // 
            // rdu_indebtedBefore
            // 
            this.rdu_indebtedBefore.AutoSize = true;
            this.rdu_indebtedBefore.Location = new System.Drawing.Point(297, 16);
            this.rdu_indebtedBefore.Margin = new System.Windows.Forms.Padding(2);
            this.rdu_indebtedBefore.Name = "rdu_indebtedBefore";
            this.rdu_indebtedBefore.Size = new System.Drawing.Size(57, 18);
            this.rdu_indebtedBefore.TabIndex = 1;
            this.rdu_indebtedBefore.Text = "بدهکار";
            this.rdu_indebtedBefore.UseVisualStyleBackColor = true;
            this.rdu_indebtedBefore.CheckedChanged += new System.EventHandler(this.rdu_indebtedBefore_CheckedChanged);
            // 
            // rdu_NoBeforeMoney
            // 
            this.rdu_NoBeforeMoney.AutoSize = true;
            this.rdu_NoBeforeMoney.Checked = true;
            this.rdu_NoBeforeMoney.Location = new System.Drawing.Point(358, 16);
            this.rdu_NoBeforeMoney.Margin = new System.Windows.Forms.Padding(2);
            this.rdu_NoBeforeMoney.Name = "rdu_NoBeforeMoney";
            this.rdu_NoBeforeMoney.Size = new System.Drawing.Size(79, 18);
            this.rdu_NoBeforeMoney.TabIndex = 0;
            this.rdu_NoBeforeMoney.TabStop = true;
            this.rdu_NoBeforeMoney.Text = "بی حساب";
            this.rdu_NoBeforeMoney.UseVisualStyleBackColor = true;
            this.rdu_NoBeforeMoney.CheckedChanged += new System.EventHandler(this.rdu_NoBeforeMoney_CheckedChanged);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_print.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_print.Location = new System.Drawing.Point(217, 454);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(172, 23);
            this.btn_print.TabIndex = 27;
            this.btn_print.Text = "چاپ لیست طرف های حساب";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(395, 454);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(119, 23);
            this.btn_ok.TabIndex = 28;
            this.btn_ok.Text = "تـــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click_1);
            // 
            // frm_persons
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(539, 489);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.tab_Person);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_persons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طرف های حساب";
            this.Load += new System.EventHandler(this.frm_persons_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_persons_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_persons_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_persons_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_zones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_visitors)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tab_Person.ResumeLayout(false);
            this.pag_general.ResumeLayout(false);
            this.pag_general.PerformLayout();
            this.pag_money.ResumeLayout(false);
            this.pag_money.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rangePrice)).EndInit();
            this.grp_RadioButtons.ResumeLayout(false);
            this.grp_RadioButtons.PerformLayout();
            this.pnl_beforeMoney.ResumeLayout(false);
            this.pnl_beforeMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deletePerson;
        private System.Windows.Forms.Button btn_renamePerosn;
        private System.Windows.Forms.Button btn_newPerson;
        private System.Windows.Forms.Button btn_modifyPersonProperties;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_deletePic;
        private System.Windows.Forms.Button btn_choosepicture;
        private System.Windows.Forms.PictureBox pic_personFace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_familyAndName;
        private ds_persons ds_persons;
        private Novin.ds_personsTableAdapters.tbl_personsTableAdapter tbl_personsTableAdapter;
        private System.Windows.Forms.BindingSource bs_persons;
        private Novin.ds_personsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Novin.ds_personsTableAdapters.tbl_visitorsTableAdapter tbl_visitorsTableAdapter;
        private System.Windows.Forms.BindingSource bs_visitors;
        private Novin.ds_personsTableAdapters.tbl_zonesTableAdapter tbl_zonesTableAdapter;
        private System.Windows.Forms.BindingSource bs_zones;
        private System.Windows.Forms.TabPage pag_general;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_comment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_address2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_address1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_ccode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_aliasName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_nationalNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_personelNumber;
        private System.Windows.Forms.TabPage pag_money;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox chk_isInterface;
        private System.Windows.Forms.CheckBox chk_isSeller;
        private System.Windows.Forms.CheckBox chk_isCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_discountPercent;
        private System.Windows.Forms.GroupBox grp_RadioButtons;
        private System.Windows.Forms.Label lbl_priceInChars;
        private System.Windows.Forms.Panel pnl_beforeMoney;
        private System.Windows.Forms.Label lbl_beforeRemainMoneyPrompt;
        private System.Windows.Forms.RadioButton rdu_creditorBefore;
        private System.Windows.Forms.RadioButton rdu_indebtedBefore;
        private System.Windows.Forms.RadioButton rdu_NoBeforeMoney;
        private System.Windows.Forms.TextBox tbx_indebtedOrCreditorPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_rangePrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chk_isPersonel;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbx_creditCeil;
        private System.Windows.Forms.Label lbl_creditCeilInChars;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.TabControl tab_Person;
    }
}