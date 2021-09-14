namespace Novin
{
    partial class frm_cheques
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
            this.grp_chqInformationSet = new System.Windows.Forms.GroupBox();
            this.btn_showPersonForm = new System.Windows.Forms.Button();
            this.btn_showAccountsForm = new System.Windows.Forms.Button();
            this.lbl_priceToChare = new System.Windows.Forms.Label();
            this.cbx_to = new System.Windows.Forms.ComboBox();
            this.bs_cheques = new System.Windows.Forms.BindingSource(this.components);
            this.ds_chqs = new Novin.ds_chqs();
            this.bs_persons_to = new System.Windows.Forms.BindingSource(this.components);
            this.ds_persons = new Novin.ds_persons();
            this.mTbx_usanceDate = new System.Windows.Forms.MaskedTextBox();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.cbx_from = new System.Windows.Forms.ComboBox();
            this.bs_persons_from = new System.Windows.Forms.BindingSource(this.components);
            this.dspersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.mTbx_issuseDate = new System.Windows.Forms.MaskedTextBox();
            this.tbx_accountNumber = new System.Windows.Forms.TextBox();
            this.tbx_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_state = new System.Windows.Forms.ComboBox();
            this.bs_chqStates = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_totalprice = new System.Windows.Forms.TextBox();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.cmb_bankname = new System.Windows.Forms.ComboBox();
            this.bs_banks = new System.Windows.Forms.BindingSource(this.components);
            this.ds_accounts = new Novin.ds_accounts();
            this.cmb_accounts = new System.Windows.Forms.ComboBox();
            this.bs_accounts = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_chequesTotal = new System.Windows.Forms.TextBox();
            this.gbx_help = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_banksTableAdapter = new Novin.ds_accountsTableAdapters.tbl_banksTableAdapter();
            this.tbl_accountsTableAdapter = new Novin.ds_accountsTableAdapters.tbl_accountsTableAdapter();
            this.pnl_navigation = new System.Windows.Forms.Panel();
            this.lbl_currentChequePosition = new System.Windows.Forms.Label();
            this.btn_priorCheque = new System.Windows.Forms.Button();
            this.btn_nextCheque = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tbl_personsTableAdapter = new Novin.ds_personsTableAdapters.tbl_personsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveexitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_help = new System.Windows.Forms.Button();
            this.tbl_chequesTableAdapter = new Novin.ds_chqsTableAdapters.tbl_chequesTableAdapter();
            this.tbl_chqStatesTableAdapter = new Novin.ds_chqsTableAdapters.tbl_chqStatesTableAdapter();
            this.btn_close = new System.Windows.Forms.Button();
            this.grp_chqInformationSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_chqs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dspersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_chqStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_banks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accounts)).BeginInit();
            this.gbx_help.SuspendLayout();
            this.pnl_navigation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_chqInformationSet
            // 
            this.grp_chqInformationSet.Controls.Add(this.btn_showPersonForm);
            this.grp_chqInformationSet.Controls.Add(this.btn_showAccountsForm);
            this.grp_chqInformationSet.Controls.Add(this.lbl_priceToChare);
            this.grp_chqInformationSet.Controls.Add(this.cbx_to);
            this.grp_chqInformationSet.Controls.Add(this.mTbx_usanceDate);
            this.grp_chqInformationSet.Controls.Add(this.lbl_to);
            this.grp_chqInformationSet.Controls.Add(this.lbl_from);
            this.grp_chqInformationSet.Controls.Add(this.cbx_from);
            this.grp_chqInformationSet.Controls.Add(this.label6);
            this.grp_chqInformationSet.Controls.Add(this.mTbx_issuseDate);
            this.grp_chqInformationSet.Controls.Add(this.tbx_accountNumber);
            this.grp_chqInformationSet.Controls.Add(this.tbx_number);
            this.grp_chqInformationSet.Controls.Add(this.label10);
            this.grp_chqInformationSet.Controls.Add(this.label5);
            this.grp_chqInformationSet.Controls.Add(this.label9);
            this.grp_chqInformationSet.Controls.Add(this.cmb_state);
            this.grp_chqInformationSet.Controls.Add(this.label8);
            this.grp_chqInformationSet.Controls.Add(this.label7);
            this.grp_chqInformationSet.Controls.Add(this.label4);
            this.grp_chqInformationSet.Controls.Add(this.label2);
            this.grp_chqInformationSet.Controls.Add(this.tbx_totalprice);
            this.grp_chqInformationSet.Controls.Add(this.tbx_comment);
            this.grp_chqInformationSet.Controls.Add(this.cmb_bankname);
            this.grp_chqInformationSet.Controls.Add(this.cmb_accounts);
            this.grp_chqInformationSet.Location = new System.Drawing.Point(19, 55);
            this.grp_chqInformationSet.Name = "grp_chqInformationSet";
            this.grp_chqInformationSet.Size = new System.Drawing.Size(721, 211);
            this.grp_chqInformationSet.TabIndex = 0;
            this.grp_chqInformationSet.TabStop = false;
            // 
            // btn_showPersonForm
            // 
            this.btn_showPersonForm.Location = new System.Drawing.Point(474, 93);
            this.btn_showPersonForm.Name = "btn_showPersonForm";
            this.btn_showPersonForm.Size = new System.Drawing.Size(31, 23);
            this.btn_showPersonForm.TabIndex = 36;
            this.btn_showPersonForm.Text = "...";
            this.btn_showPersonForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_showPersonForm.UseVisualStyleBackColor = true;
            this.btn_showPersonForm.Click += new System.EventHandler(this.btn_showPersonForm_Click);
            // 
            // btn_showAccountsForm
            // 
            this.btn_showAccountsForm.Location = new System.Drawing.Point(222, 99);
            this.btn_showAccountsForm.Name = "btn_showAccountsForm";
            this.btn_showAccountsForm.Size = new System.Drawing.Size(31, 23);
            this.btn_showAccountsForm.TabIndex = 35;
            this.btn_showAccountsForm.Text = "...";
            this.btn_showAccountsForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_showAccountsForm.UseVisualStyleBackColor = true;
            this.btn_showAccountsForm.Click += new System.EventHandler(this.btn_showAccountsForm_Click);
            // 
            // lbl_priceToChare
            // 
            this.lbl_priceToChare.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_priceToChare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_priceToChare.Location = new System.Drawing.Point(6, 22);
            this.lbl_priceToChare.Name = "lbl_priceToChare";
            this.lbl_priceToChare.Size = new System.Drawing.Size(247, 18);
            this.lbl_priceToChare.TabIndex = 34;
            this.lbl_priceToChare.Text = "صفر ريال";
            // 
            // cbx_to
            // 
            this.cbx_to.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_cheques, "person_id", true));
            this.cbx_to.DataSource = this.bs_persons_to;
            this.cbx_to.DisplayMember = "person_familyAndName";
            this.cbx_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_to.Enabled = false;
            this.cbx_to.FormattingEnabled = true;
            this.cbx_to.Location = new System.Drawing.Point(511, 94);
            this.cbx_to.Name = "cbx_to";
            this.cbx_to.Size = new System.Drawing.Size(121, 21);
            this.cbx_to.TabIndex = 1;
            this.cbx_to.ValueMember = "person_id";
            this.cbx_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_to_KeyPress);
            // 
            // bs_cheques
            // 
            this.bs_cheques.DataMember = "tbl_cheques";
            this.bs_cheques.DataSource = this.ds_chqs;
            this.bs_cheques.CurrentChanged += new System.EventHandler(this.bs_cheques_CurrentChanged);
            // 
            // ds_chqs
            // 
            this.ds_chqs.DataSetName = "ds_chqs";
            this.ds_chqs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_persons_to
            // 
            this.bs_persons_to.DataMember = "tbl_persons";
            this.bs_persons_to.DataSource = this.ds_persons;
            // 
            // ds_persons
            // 
            this.ds_persons.DataSetName = "ds_persons";
            this.ds_persons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mTbx_usanceDate
            // 
            this.mTbx_usanceDate.AllowPromptAsInput = false;
            this.mTbx_usanceDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_usaDate", true));
            this.mTbx_usanceDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mTbx_usanceDate.Location = new System.Drawing.Point(273, 57);
            this.mTbx_usanceDate.Mask = "0000/00/00";
            this.mTbx_usanceDate.Name = "mTbx_usanceDate";
            this.mTbx_usanceDate.PromptChar = ' ';
            this.mTbx_usanceDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_usanceDate.Size = new System.Drawing.Size(101, 21);
            this.mTbx_usanceDate.TabIndex = 1;
            this.mTbx_usanceDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(658, 101);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(44, 13);
            this.lbl_to.TabIndex = 30;
            this.lbl_to.Text = "در وجه :";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(638, 23);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(64, 13);
            this.lbl_from.TabIndex = 29;
            this.lbl_from.Text = "صاحب چک :";
            // 
            // cbx_from
            // 
            this.cbx_from.DataSource = this.bs_persons_from;
            this.cbx_from.DisplayMember = "person_familyAndName";
            this.cbx_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_from.Enabled = false;
            this.cbx_from.FormattingEnabled = true;
            this.cbx_from.Location = new System.Drawing.Point(511, 16);
            this.cbx_from.Name = "cbx_from";
            this.cbx_from.Size = new System.Drawing.Size(121, 21);
            this.cbx_from.TabIndex = 0;
            this.cbx_from.ValueMember = "person_id";
            this.cbx_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_from_KeyPress);
            // 
            // bs_persons_from
            // 
            this.bs_persons_from.DataMember = "tbl_persons";
            this.bs_persons_from.DataSource = this.dspersonsBindingSource;
            // 
            // dspersonsBindingSource
            // 
            this.dspersonsBindingSource.DataSource = this.ds_persons;
            this.dspersonsBindingSource.Position = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "تاریخ وصول :";
            // 
            // mTbx_issuseDate
            // 
            this.mTbx_issuseDate.AllowPromptAsInput = false;
            this.mTbx_issuseDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_issDate", true));
            this.mTbx_issuseDate.Location = new System.Drawing.Point(511, 55);
            this.mTbx_issuseDate.Mask = "0000/00/00";
            this.mTbx_issuseDate.Name = "mTbx_issuseDate";
            this.mTbx_issuseDate.PromptChar = ' ';
            this.mTbx_issuseDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_issuseDate.Size = new System.Drawing.Size(121, 21);
            this.mTbx_issuseDate.TabIndex = 0;
            this.mTbx_issuseDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTbx_usanceDate_KeyDown);
            // 
            // tbx_accountNumber
            // 
            this.tbx_accountNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_hisAccount", true));
            this.tbx_accountNumber.Location = new System.Drawing.Point(258, 99);
            this.tbx_accountNumber.Name = "tbx_accountNumber";
            this.tbx_accountNumber.Size = new System.Drawing.Size(104, 21);
            this.tbx_accountNumber.TabIndex = 5;
            // 
            // tbx_number
            // 
            this.tbx_number.Location = new System.Drawing.Point(511, 132);
            this.tbx_number.Name = "tbx_number";
            this.tbx_number.Size = new System.Drawing.Size(121, 21);
            this.tbx_number.TabIndex = 2;
            this.tbx_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_number_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(637, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "شماره چک :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "تاریخ صدور :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "وضعییت چک :";
            // 
            // cmb_state
            // 
            this.cmb_state.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_cheques, "chqState_id", true));
            this.cmb_state.DataSource = this.bs_chqStates;
            this.cmb_state.DisplayMember = "chqState_title";
            this.cmb_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.Location = new System.Drawing.Point(46, 60);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.Size = new System.Drawing.Size(135, 21);
            this.cmb_state.TabIndex = 7;
            this.cmb_state.ValueMember = "chqState_id";
            // 
            // bs_chqStates
            // 
            this.bs_chqStates.DataMember = "tbl_chqStates";
            this.bs_chqStates.DataSource = this.ds_chqs;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "توضیحات:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "شماره حساب:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "بانک :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "مبلغ چک :";
            // 
            // tbx_totalprice
            // 
            this.tbx_totalprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_price", true));
            this.tbx_totalprice.Location = new System.Drawing.Point(258, 18);
            this.tbx_totalprice.Name = "tbx_totalprice";
            this.tbx_totalprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_totalprice.Size = new System.Drawing.Size(123, 21);
            this.tbx_totalprice.TabIndex = 4;
            this.tbx_totalprice.Text = "0";
            this.tbx_totalprice.TextChanged += new System.EventHandler(this.tbx_totalprice_TextChanged);
            this.tbx_totalprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_totalprice_KeyPress);
            // 
            // tbx_comment
            // 
            this.tbx_comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_comment", true));
            this.tbx_comment.Location = new System.Drawing.Point(6, 170);
            this.tbx_comment.Multiline = true;
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(626, 26);
            this.tbx_comment.TabIndex = 8;
            // 
            // cmb_bankname
            // 
            this.cmb_bankname.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_cheques, "bank_id", true));
            this.cmb_bankname.DataSource = this.bs_banks;
            this.cmb_bankname.DisplayMember = "bank_name";
            this.cmb_bankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bankname.FormattingEnabled = true;
            this.cmb_bankname.Location = new System.Drawing.Point(46, 100);
            this.cmb_bankname.Name = "cmb_bankname";
            this.cmb_bankname.Size = new System.Drawing.Size(127, 21);
            this.cmb_bankname.TabIndex = 3;
            this.cmb_bankname.ValueMember = "bank_id";
            // 
            // bs_banks
            // 
            this.bs_banks.DataMember = "tbl_banks";
            this.bs_banks.DataSource = this.ds_accounts;
            this.bs_banks.CurrentChanged += new System.EventHandler(this.bs_banks_CurrentChanged);
            // 
            // ds_accounts
            // 
            this.ds_accounts.DataSetName = "ds_accounts";
            this.ds_accounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_accounts
            // 
            this.cmb_accounts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_cheques, "account_id", true));
            this.cmb_accounts.DataSource = this.bs_accounts;
            this.cmb_accounts.DisplayMember = "account_number";
            this.cmb_accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_accounts.FormattingEnabled = true;
            this.cmb_accounts.Location = new System.Drawing.Point(258, 99);
            this.cmb_accounts.Name = "cmb_accounts";
            this.cmb_accounts.Size = new System.Drawing.Size(116, 21);
            this.cmb_accounts.TabIndex = 6;
            this.cmb_accounts.ValueMember = "account_id";
            // 
            // bs_accounts
            // 
            this.bs_accounts.DataMember = "tbl_accounts";
            this.bs_accounts.DataSource = this.ds_accounts;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(212, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "ريال";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(444, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "جمع مبالغ چک ها :";
            // 
            // tbx_chequesTotal
            // 
            this.tbx_chequesTotal.Location = new System.Drawing.Point(240, 272);
            this.tbx_chequesTotal.Name = "tbx_chequesTotal";
            this.tbx_chequesTotal.ReadOnly = true;
            this.tbx_chequesTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_chequesTotal.Size = new System.Drawing.Size(198, 21);
            this.tbx_chequesTotal.TabIndex = 29;
            // 
            // gbx_help
            // 
            this.gbx_help.Controls.Add(this.label16);
            this.gbx_help.Controls.Add(this.label15);
            this.gbx_help.Controls.Add(this.label14);
            this.gbx_help.Controls.Add(this.label11);
            this.gbx_help.Controls.Add(this.label3);
            this.gbx_help.Controls.Add(this.label1);
            this.gbx_help.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbx_help.Location = new System.Drawing.Point(12, 157);
            this.gbx_help.Name = "gbx_help";
            this.gbx_help.Size = new System.Drawing.Size(156, 163);
            this.gbx_help.TabIndex = 35;
            this.gbx_help.TabStop = false;
            this.gbx_help.Text = "کلیدهای میانبر";
            this.gbx_help.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(44, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "چک قـــبلی  ctrl+left";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(37, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "چک بــعدی  ctrl+right";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(70, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "ثبت و خروج  F4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(72, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "ثبت تغیرات  F3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(74, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "حذف  ctrl+del";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(106, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "درج  F2";
            // 
            // tbl_banksTableAdapter
            // 
            this.tbl_banksTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_accountsTableAdapter
            // 
            this.tbl_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_navigation
            // 
            this.pnl_navigation.BackColor = System.Drawing.Color.Transparent;
            this.pnl_navigation.Controls.Add(this.lbl_currentChequePosition);
            this.pnl_navigation.Controls.Add(this.btn_priorCheque);
            this.pnl_navigation.Controls.Add(this.btn_nextCheque);
            this.pnl_navigation.Location = new System.Drawing.Point(7, 12);
            this.pnl_navigation.Name = "pnl_navigation";
            this.pnl_navigation.Size = new System.Drawing.Size(391, 37);
            this.pnl_navigation.TabIndex = 32;
            // 
            // lbl_currentChequePosition
            // 
            this.lbl_currentChequePosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_currentChequePosition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_currentChequePosition.ForeColor = System.Drawing.Color.Black;
            this.lbl_currentChequePosition.Location = new System.Drawing.Point(12, 9);
            this.lbl_currentChequePosition.Name = "lbl_currentChequePosition";
            this.lbl_currentChequePosition.Size = new System.Drawing.Size(164, 26);
            this.lbl_currentChequePosition.TabIndex = 11;
            this.lbl_currentChequePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_priorCheque
            // 
            this.btn_priorCheque.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_priorCheque.Location = new System.Drawing.Point(182, 11);
            this.btn_priorCheque.Name = "btn_priorCheque";
            this.btn_priorCheque.Size = new System.Drawing.Size(93, 24);
            this.btn_priorCheque.TabIndex = 1;
            this.btn_priorCheque.Text = "چک قـــبلی    >";
            this.btn_priorCheque.UseVisualStyleBackColor = true;
            this.btn_priorCheque.Click += new System.EventHandler(this.btn_priorCheque_Click);
            // 
            // btn_nextCheque
            // 
            this.btn_nextCheque.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_nextCheque.Location = new System.Drawing.Point(281, 12);
            this.btn_nextCheque.Name = "btn_nextCheque";
            this.btn_nextCheque.Size = new System.Drawing.Size(98, 23);
            this.btn_nextCheque.TabIndex = 0;
            this.btn_nextCheque.Text = "<    چک بــعدی  ";
            this.btn_nextCheque.UseVisualStyleBackColor = true;
            this.btn_nextCheque.Click += new System.EventHandler(this.btn_nextCheque_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 44);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(97, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف چک";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Azure;
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.ForeColor = System.Drawing.Color.Blue;
            this.btn_edit.Location = new System.Drawing.Point(7, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "ثبت تغییرات";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Azure;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.ForeColor = System.Drawing.Color.Green;
            this.btn_add.Location = new System.Drawing.Point(187, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "* چک جدید";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Location = new System.Drawing.Point(591, 321);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(140, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "تائــــید";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tbl_personsTableAdapter
            // 
            this.tbl_personsTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem1,
            this.preToolStripMenuItem,
            this.addToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveexitToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.nextToolStripMenuItem.Text = "menu";
            this.nextToolStripMenuItem.Visible = false;
            // 
            // nextToolStripMenuItem1
            // 
            this.nextToolStripMenuItem1.Name = "nextToolStripMenuItem1";
            this.nextToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.nextToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.nextToolStripMenuItem1.Text = "next";
            this.nextToolStripMenuItem1.Click += new System.EventHandler(this.nextToolStripMenuItem1_Click);
            // 
            // preToolStripMenuItem
            // 
            this.preToolStripMenuItem.Name = "preToolStripMenuItem";
            this.preToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.preToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.preToolStripMenuItem.Text = "pre";
            this.preToolStripMenuItem.Click += new System.EventHandler(this.preToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.addToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveexitToolStripMenuItem
            // 
            this.saveexitToolStripMenuItem.Name = "saveexitToolStripMenuItem";
            this.saveexitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.saveexitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveexitToolStripMenuItem.Text = "save&exit";
            this.saveexitToolStripMenuItem.Click += new System.EventHandler(this.saveexitToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(12, 326);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(45, 24);
            this.btn_help.TabIndex = 35;
            this.btn_help.Text = "راهنما";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbl_chequesTableAdapter
            // 
            this.tbl_chequesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_chqStatesTableAdapter
            // 
            this.tbl_chqStatesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_close.Location = new System.Drawing.Point(492, 321);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(93, 23);
            this.btn_close.TabIndex = 37;
            this.btn_close.Text = "بستن";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // frm_cheques
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(751, 356);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.pnl_navigation);
            this.Controls.Add(this.gbx_help);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grp_chqInformationSet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbx_chequesTotal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_cheques";
            this.Text = "   ثبت چک";
            this.Load += new System.EventHandler(this.frm_cheques_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_cheques_FormClosed);
            this.grp_chqInformationSet.ResumeLayout(false);
            this.grp_chqInformationSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_chqs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dspersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_chqStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_banks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accounts)).EndInit();
            this.gbx_help.ResumeLayout(false);
            this.gbx_help.PerformLayout();
            this.pnl_navigation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_chqInformationSet;
        private System.Windows.Forms.ComboBox cmb_bankname;
        private System.Windows.Forms.ComboBox cmb_accounts;
        private System.Windows.Forms.TextBox tbx_totalprice;
        private System.Windows.Forms.TextBox tbx_comment;
        private System.Windows.Forms.TextBox tbx_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_state;
        private System.Windows.Forms.Label label10;
        //private Novin.ds_chequesTableAdapters.tbl_chequesTableAdapter tbl_chequesTableAdapter;
        private ds_accounts ds_accounts;
        private System.Windows.Forms.BindingSource bs_banks;
        private Novin.ds_accountsTableAdapters.tbl_banksTableAdapter tbl_banksTableAdapter;        
        private System.Windows.Forms.BindingSource bs_accounts;
        private Novin.ds_accountsTableAdapters.tbl_accountsTableAdapter tbl_accountsTableAdapter;
        private System.Windows.Forms.MaskedTextBox mTbx_usanceDate;
        private System.Windows.Forms.MaskedTextBox mTbx_issuseDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tbx_chequesTotal;
        private System.Windows.Forms.Panel pnl_navigation;
        private System.Windows.Forms.Label lbl_currentChequePosition;
        private System.Windows.Forms.Button btn_priorCheque;
        private System.Windows.Forms.Button btn_nextCheque;
        private System.Windows.Forms.TextBox tbx_accountNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cbx_to;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.ComboBox cbx_from;
        private System.Windows.Forms.BindingSource dspersonsBindingSource;
        private ds_persons ds_persons;
        private System.Windows.Forms.BindingSource bs_persons_from;
        private Novin.ds_personsTableAdapters.tbl_personsTableAdapter tbl_personsTableAdapter;
        private System.Windows.Forms.BindingSource bs_persons_to;
        private System.Windows.Forms.Label lbl_priceToChare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveexitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.GroupBox gbx_help;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private ds_chqs ds_chqs;
        private System.Windows.Forms.BindingSource bs_cheques;
        private Novin.ds_chqsTableAdapters.tbl_chequesTableAdapter tbl_chequesTableAdapter;
        private System.Windows.Forms.BindingSource bs_chqStates;
        private Novin.ds_chqsTableAdapters.tbl_chqStatesTableAdapter tbl_chqStatesTableAdapter;
        private System.Windows.Forms.Button btn_showAccountsForm;
        private System.Windows.Forms.Button btn_showPersonForm;
        private System.Windows.Forms.Button btn_close;

    }
}
