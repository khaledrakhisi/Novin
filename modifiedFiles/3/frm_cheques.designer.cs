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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_to = new System.Windows.Forms.ComboBox();
            this.bs_cheques = new System.Windows.Forms.BindingSource(this.components);
            this.ds_cheques = new Novin.ds_cheques();
            this.bs_persons_to = new System.Windows.Forms.BindingSource(this.components);
            this.ds_persons = new Novin.ds_persons();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.cbx_from = new System.Windows.Forms.ComboBox();
            this.bs_persons_from = new System.Windows.Forms.BindingSource(this.components);
            this.dspersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_accountNumber = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_usanceDate = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_state = new System.Windows.Forms.ComboBox();
            this.bs_chqStates = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_totalprice = new System.Windows.Forms.TextBox();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.tbx_number = new System.Windows.Forms.TextBox();
            this.cmb_bankname = new System.Windows.Forms.ComboBox();
            this.bs_banks = new System.Windows.Forms.BindingSource(this.components);
            this.ds_accounts = new Novin.ds_accounts();
            this.cmb_accounts = new System.Windows.Forms.ComboBox();
            this.bs_accounts = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_chequesTableAdapter = new Novin.ds_chequesTableAdapters.tbl_chequesTableAdapter();
            this.tbl_banksTableAdapter = new Novin.ds_accountsTableAdapters.tbl_banksTableAdapter();
            this.tbl_accountsTableAdapter = new Novin.ds_accountsTableAdapters.tbl_accountsTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_chequesTotal = new System.Windows.Forms.TextBox();
            this.pnl_navigation = new System.Windows.Forms.Panel();
            this.lbl_currentChequePosition = new System.Windows.Forms.Label();
            this.btn_priorCheque = new System.Windows.Forms.Button();
            this.btn_nextCheque = new System.Windows.Forms.Button();
            this.tbl_chqStatesTableAdapter = new Novin.ds_chequesTableAdapters.tbl_chqStatesTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tbl_personsTableAdapter = new Novin.ds_personsTableAdapters.tbl_personsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_cheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dspersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_chqStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_banks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accounts)).BeginInit();
            this.pnl_navigation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_to);
            this.groupBox1.Controls.Add(this.lbl_to);
            this.groupBox1.Controls.Add(this.lbl_from);
            this.groupBox1.Controls.Add(this.cbx_from);
            this.groupBox1.Controls.Add(this.tbx_accountNumber);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.mTbx_usanceDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_state);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_totalprice);
            this.groupBox1.Controls.Add(this.tbx_comment);
            this.groupBox1.Controls.Add(this.tbx_number);
            this.groupBox1.Controls.Add(this.cmb_bankname);
            this.groupBox1.Controls.Add(this.cmb_accounts);
            this.groupBox1.Location = new System.Drawing.Point(10, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbx_to
            // 
            this.cbx_to.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_cheques, "person_id", true));
            this.cbx_to.DataSource = this.bs_persons_to;
            this.cbx_to.DisplayMember = "person_familyAndName";
            this.cbx_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_to.Enabled = false;
            this.cbx_to.FormattingEnabled = true;
            this.cbx_to.Location = new System.Drawing.Point(474, 60);
            this.cbx_to.Name = "cbx_to";
            this.cbx_to.Size = new System.Drawing.Size(121, 21);
            this.cbx_to.TabIndex = 31;
            this.cbx_to.ValueMember = "person_id";
            // 
            // bs_cheques
            // 
            this.bs_cheques.DataMember = "tbl_cheques";
            this.bs_cheques.DataSource = this.ds_cheques;
            this.bs_cheques.CurrentChanged += new System.EventHandler(this.bs_cheques_CurrentChanged);
            // 
            // ds_cheques
            // 
            this.ds_cheques.DataSetName = "ds_cheques";
            this.ds_cheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(608, 63);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(44, 13);
            this.lbl_to.TabIndex = 30;
            this.lbl_to.Text = "در وجه :";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(601, 25);
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
            this.cbx_from.Location = new System.Drawing.Point(474, 22);
            this.cbx_from.Name = "cbx_from";
            this.cbx_from.Size = new System.Drawing.Size(121, 21);
            this.cbx_from.TabIndex = 28;
            this.cbx_from.ValueMember = "person_id";
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
            // tbx_accountNumber
            // 
            this.tbx_accountNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_hisAccount", true));
            this.tbx_accountNumber.Location = new System.Drawing.Point(6, 57);
            this.tbx_accountNumber.Name = "tbx_accountNumber";
            this.tbx_accountNumber.Size = new System.Drawing.Size(105, 21);
            this.tbx_accountNumber.TabIndex = 25;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AllowPromptAsInput = false;
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_usaDate", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.maskedTextBox1.Location = new System.Drawing.Point(21, 94);
            this.maskedTextBox1.Mask = "0000/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(101, 21);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // mTbx_usanceDate
            // 
            this.mTbx_usanceDate.AllowPromptAsInput = false;
            this.mTbx_usanceDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_issDate", true));
            this.mTbx_usanceDate.Location = new System.Drawing.Point(22, 24);
            this.mTbx_usanceDate.Mask = "0000/00/00";
            this.mTbx_usanceDate.Name = "mTbx_usanceDate";
            this.mTbx_usanceDate.PromptChar = ' ';
            this.mTbx_usanceDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_usanceDate.Size = new System.Drawing.Size(101, 21);
            this.mTbx_usanceDate.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(601, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = ":شماره چک";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = ":وضعییت چک";
            // 
            // cmb_state
            // 
            this.cmb_state.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_cheques, "chqState_id", true));
            this.cmb_state.DataSource = this.bs_chqStates;
            this.cmb_state.DisplayMember = "chqState_title";
            this.cmb_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.Location = new System.Drawing.Point(229, 97);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.Size = new System.Drawing.Size(152, 21);
            this.cmb_state.TabIndex = 19;
            this.cmb_state.ValueMember = "chqState_id";
            // 
            // bs_chqStates
            // 
            this.bs_chqStates.DataMember = "tbl_chqStates";
            this.bs_chqStates.DataSource = this.ds_cheques;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = ":توضیحات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = ":شماره حساب";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "*";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "*";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = ":تاریخ وصول";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = ":تاریخ صدور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = ":بانک";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "مبلغ چک :";
            // 
            // tbx_totalprice
            // 
            this.tbx_totalprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_price", true));
            this.tbx_totalprice.Location = new System.Drawing.Point(229, 20);
            this.tbx_totalprice.Name = "tbx_totalprice";
            this.tbx_totalprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_totalprice.Size = new System.Drawing.Size(152, 21);
            this.tbx_totalprice.TabIndex = 5;
            this.tbx_totalprice.TextChanged += new System.EventHandler(this.tbx_totalprice_TextChanged);
            // 
            // tbx_comment
            // 
            this.tbx_comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_comment", true));
            this.tbx_comment.Location = new System.Drawing.Point(6, 135);
            this.tbx_comment.Multiline = true;
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(600, 26);
            this.tbx_comment.TabIndex = 4;
            // 
            // tbx_number
            // 
            this.tbx_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_cheques, "chq_number", true));
            this.tbx_number.Location = new System.Drawing.Point(474, 97);
            this.tbx_number.Name = "tbx_number";
            this.tbx_number.Size = new System.Drawing.Size(121, 21);
            this.tbx_number.TabIndex = 3;
            // 
            // cmb_bankname
            // 
            this.cmb_bankname.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_cheques, "bank_id", true));
            this.cmb_bankname.DataSource = this.bs_banks;
            this.cmb_bankname.DisplayMember = "bank_name";
            this.cmb_bankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bankname.FormattingEnabled = true;
            this.cmb_bankname.Location = new System.Drawing.Point(229, 57);
            this.cmb_bankname.Name = "cmb_bankname";
            this.cmb_bankname.Size = new System.Drawing.Size(152, 21);
            this.cmb_bankname.TabIndex = 1;
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
            this.cmb_accounts.Location = new System.Drawing.Point(6, 57);
            this.cmb_accounts.Name = "cmb_accounts";
            this.cmb_accounts.Size = new System.Drawing.Size(116, 21);
            this.cmb_accounts.TabIndex = 0;
            this.cmb_accounts.ValueMember = "account_id";
            // 
            // bs_accounts
            // 
            this.bs_accounts.DataMember = "tbl_accounts";
            this.bs_accounts.DataSource = this.ds_accounts;
            // 
            // tbl_chequesTableAdapter
            // 
            this.tbl_chequesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_banksTableAdapter
            // 
            this.tbl_banksTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_accountsTableAdapter
            // 
            this.tbl_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(169, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 26);
            this.label13.TabIndex = 31;
            this.label13.Text = "ريال";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(415, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 26);
            this.label12.TabIndex = 30;
            this.label12.Text = "جمع مبالغ چک ها :";
            // 
            // tbx_chequesTotal
            // 
            this.tbx_chequesTotal.Location = new System.Drawing.Point(211, 255);
            this.tbx_chequesTotal.Name = "tbx_chequesTotal";
            this.tbx_chequesTotal.ReadOnly = true;
            this.tbx_chequesTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_chequesTotal.Size = new System.Drawing.Size(198, 21);
            this.tbx_chequesTotal.TabIndex = 29;
            // 
            // pnl_navigation
            // 
            this.pnl_navigation.BackColor = System.Drawing.Color.Transparent;
            this.pnl_navigation.Controls.Add(this.lbl_currentChequePosition);
            this.pnl_navigation.Controls.Add(this.btn_priorCheque);
            this.pnl_navigation.Controls.Add(this.btn_nextCheque);
            this.pnl_navigation.Location = new System.Drawing.Point(143, 7);
            this.pnl_navigation.Name = "pnl_navigation";
            this.pnl_navigation.Size = new System.Drawing.Size(412, 57);
            this.pnl_navigation.TabIndex = 32;
            // 
            // lbl_currentChequePosition
            // 
            this.lbl_currentChequePosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_currentChequePosition.Font = new System.Drawing.Font("B Zar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_currentChequePosition.ForeColor = System.Drawing.Color.Black;
            this.lbl_currentChequePosition.Location = new System.Drawing.Point(12, 9);
            this.lbl_currentChequePosition.Name = "lbl_currentChequePosition";
            this.lbl_currentChequePosition.Size = new System.Drawing.Size(164, 34);
            this.lbl_currentChequePosition.TabIndex = 11;
            this.lbl_currentChequePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_priorCheque
            // 
            this.btn_priorCheque.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_priorCheque.Location = new System.Drawing.Point(182, 11);
            this.btn_priorCheque.Name = "btn_priorCheque";
            this.btn_priorCheque.Size = new System.Drawing.Size(105, 32);
            this.btn_priorCheque.TabIndex = 1;
            this.btn_priorCheque.Text = "چک قـــبلی    >";
            this.btn_priorCheque.UseVisualStyleBackColor = true;
            this.btn_priorCheque.Click += new System.EventHandler(this.btn_priorCheque_Click);
            // 
            // btn_nextCheque
            // 
            this.btn_nextCheque.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_nextCheque.Location = new System.Drawing.Point(293, 12);
            this.btn_nextCheque.Name = "btn_nextCheque";
            this.btn_nextCheque.Size = new System.Drawing.Size(100, 31);
            this.btn_nextCheque.TabIndex = 0;
            this.btn_nextCheque.Text = "<    چک بــعدی  ";
            this.btn_nextCheque.UseVisualStyleBackColor = true;
            this.btn_nextCheque.Click += new System.EventHandler(this.btn_nextCheque_Click);
            // 
            // tbl_chqStatesTableAdapter
            // 
            this.tbl_chqStatesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(159, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 44);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_close.Location = new System.Drawing.Point(16, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "ثبت و خروج";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.Location = new System.Drawing.Point(196, 11);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.Location = new System.Drawing.Point(106, 11);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 23);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "ثبت تغییرات";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.Location = new System.Drawing.Point(286, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "درج";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tbl_personsTableAdapter
            // 
            this.tbl_personsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_cheques
            // 
            this.ClientSize = new System.Drawing.Size(699, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnl_navigation);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbx_chequesTotal);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_cheques";
            this.Text = "ثبت چک";
            this.Load += new System.EventHandler(this.frm_cheques_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_cheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dspersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_chqStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_banks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accounts)).EndInit();
            this.pnl_navigation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_bankname;
        private System.Windows.Forms.ComboBox cmb_accounts;
        private System.Windows.Forms.TextBox tbx_totalprice;
        private System.Windows.Forms.TextBox tbx_comment;
        private System.Windows.Forms.TextBox tbx_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_state;
        private System.Windows.Forms.Label label10;
        private Novin.ds_chequesTableAdapters.tbl_chequesTableAdapter tbl_chequesTableAdapter;
        private ds_accounts ds_accounts;
        private System.Windows.Forms.BindingSource bs_banks;
        private Novin.ds_accountsTableAdapters.tbl_banksTableAdapter tbl_banksTableAdapter;        
        private System.Windows.Forms.BindingSource bs_accounts;
        private Novin.ds_accountsTableAdapters.tbl_accountsTableAdapter tbl_accountsTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mTbx_usanceDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tbx_chequesTotal;
        private System.Windows.Forms.Panel pnl_navigation;
        private System.Windows.Forms.Label lbl_currentChequePosition;
        private System.Windows.Forms.Button btn_priorCheque;
        private System.Windows.Forms.Button btn_nextCheque;
        private System.Windows.Forms.TextBox tbx_accountNumber;
        private System.Windows.Forms.BindingSource bs_cheques;
        private ds_cheques ds_cheques;
        private System.Windows.Forms.BindingSource bs_chqStates;
        private Novin.ds_chequesTableAdapters.tbl_chqStatesTableAdapter tbl_chqStatesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_close;
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

    }
}
