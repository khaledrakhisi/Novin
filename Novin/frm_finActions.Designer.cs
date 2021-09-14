namespace Novin
{
    partial class frm_finActions
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
            this.cbx_typeFinAction = new System.Windows.Forms.ComboBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.cbx_from = new System.Windows.Forms.ComboBox();
            this.bs_viwAccounts_from = new System.Windows.Forms.BindingSource(this.components);
            this.ds_viewAccounts = new Novin.ds_viewAccounts();
            this.cbx_to = new System.Windows.Forms.ComboBox();
            this.bs_viwAccounts_to = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_to = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viw_accountsTableAdapter = new Novin.ds_viewAccountsTableAdapters.viw_accountsTableAdapter();
            this.pnl_toSet = new System.Windows.Forms.Panel();
            this.pnl_fromSet = new System.Windows.Forms.Panel();
            this.ds_persons = new Novin.ds_persons();
            this.bs_persons = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_personsTableAdapter = new Novin.ds_personsTableAdapters.tbl_personsTableAdapter();
            this.tbx_totalMoney = new System.Windows.Forms.TextBox();
            this.bs_finActs = new System.Windows.Forms.BindingSource(this.components);
            this.ds_finActs = new Novin.ds_finActs();
            this.lbl_actionPrompt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTbx_accDocDate = new System.Windows.Forms.MaskedTextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_priceInChars = new System.Windows.Forms.Label();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx_remainMoney = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbx_totalPaidMoney = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grp_paySet = new System.Windows.Forms.GroupBox();
            this.tbx_indebtedMoney = new System.Windows.Forms.TextBox();
            this.tbx_discountMoney = new System.Windows.Forms.TextBox();
            this.tbx_cashMoney = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_useCheque = new System.Windows.Forms.Button();
            this.btn_newCheque = new System.Windows.Forms.Button();
            this.tbx_uesedChequesMoney = new System.Windows.Forms.TextBox();
            this.tbx_chequesMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbl_finActsTableAdapter = new Novin.ds_finActsTableAdapters.tbl_finActsTableAdapter();
            this.bs_MOEENS = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MOEENsTableAdapter = new Novin.ds_finActsTableAdapters.tbl_MOEENsTableAdapter();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viwAccounts_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_viewAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viwAccounts_to)).BeginInit();
            this.pnl_toSet.SuspendLayout();
            this.pnl_fromSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_finActs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_finActs)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grp_paySet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MOEENS)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_typeFinAction
            // 
            this.cbx_typeFinAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_typeFinAction.FormattingEnabled = true;
            this.cbx_typeFinAction.Items.AddRange(new object[] {
            "بانک به بانک",
            "صندوق به بانک",
            "حواله طرف حساب",
            "دریافت از طرف حساب",
            "پرداخت به طرف حساب",
            "سرمایه گذاری",
            "هزینــه",
            "درآمـــد",
            "برداشت",
            "بانک به صندوق",
            "کارمزد بانک",
            "ارساله حواله"});
            this.cbx_typeFinAction.Location = new System.Drawing.Point(97, 49);
            this.cbx_typeFinAction.Name = "cbx_typeFinAction";
            this.cbx_typeFinAction.Size = new System.Drawing.Size(211, 21);
            this.cbx_typeFinAction.TabIndex = 0;
            this.cbx_typeFinAction.SelectedIndexChanged += new System.EventHandler(this.cbx_typeFinAction_SelectedIndexChanged);
            // 
            // lbl_from
            // 
            this.lbl_from.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_from.Location = new System.Drawing.Point(13, 11);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(202, 19);
            this.lbl_from.TabIndex = 1;
            this.lbl_from.Text = "از بانک";
            this.lbl_from.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_from
            // 
            this.cbx_from.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbx_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_from.FormattingEnabled = true;
            this.cbx_from.Location = new System.Drawing.Point(14, 33);
            this.cbx_from.Name = "cbx_from";
            this.cbx_from.Size = new System.Drawing.Size(200, 21);
            this.cbx_from.TabIndex = 2;
            // 
            // bs_viwAccounts_from
            // 
            this.bs_viwAccounts_from.DataMember = "viw_accounts";
            this.bs_viwAccounts_from.DataSource = this.ds_viewAccounts;
            // 
            // ds_viewAccounts
            // 
            this.ds_viewAccounts.DataSetName = "ds_viewAccounts";
            this.ds_viewAccounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbx_to
            // 
            this.cbx_to.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbx_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_to.FormattingEnabled = true;
            this.cbx_to.Location = new System.Drawing.Point(28, 33);
            this.cbx_to.Name = "cbx_to";
            this.cbx_to.Size = new System.Drawing.Size(190, 21);
            this.cbx_to.TabIndex = 4;
            // 
            // bs_viwAccounts_to
            // 
            this.bs_viwAccounts_to.DataMember = "viw_accounts";
            this.bs_viwAccounts_to.DataSource = this.ds_viewAccounts;
            // 
            // lbl_to
            // 
            this.lbl_to.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_to.Location = new System.Drawing.Point(35, 11);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(177, 19);
            this.lbl_to.TabIndex = 3;
            this.lbl_to.Text = "به بانک";
            this.lbl_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "نوع عملیات مالی:";
            // 
            // viw_accountsTableAdapter
            // 
            this.viw_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_toSet
            // 
            this.pnl_toSet.Controls.Add(this.cbx_to);
            this.pnl_toSet.Controls.Add(this.lbl_to);
            this.pnl_toSet.Location = new System.Drawing.Point(10, 77);
            this.pnl_toSet.Name = "pnl_toSet";
            this.pnl_toSet.Size = new System.Drawing.Size(247, 69);
            this.pnl_toSet.TabIndex = 6;
            // 
            // pnl_fromSet
            // 
            this.pnl_fromSet.Controls.Add(this.cbx_from);
            this.pnl_fromSet.Controls.Add(this.lbl_from);
            this.pnl_fromSet.Location = new System.Drawing.Point(263, 77);
            this.pnl_fromSet.Name = "pnl_fromSet";
            this.pnl_fromSet.Size = new System.Drawing.Size(229, 69);
            this.pnl_fromSet.TabIndex = 7;
            // 
            // ds_persons
            // 
            this.ds_persons.DataSetName = "ds_persons";
            this.ds_persons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_persons
            // 
            this.bs_persons.DataMember = "tbl_persons";
            this.bs_persons.DataSource = this.ds_persons;
            // 
            // tbl_personsTableAdapter
            // 
            this.tbl_personsTableAdapter.ClearBeforeFill = true;
            // 
            // tbx_totalMoney
            // 
            this.tbx_totalMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_finActs, "finAct_money", true));
            this.tbx_totalMoney.Location = new System.Drawing.Point(131, 165);
            this.tbx_totalMoney.Name = "tbx_totalMoney";
            this.tbx_totalMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_totalMoney.Size = new System.Drawing.Size(168, 21);
            this.tbx_totalMoney.TabIndex = 8;
            this.tbx_totalMoney.Text = "0";
            this.tbx_totalMoney.TextChanged += new System.EventHandler(this.tbx_money_TextChanged);
            this.tbx_totalMoney.Leave += new System.EventHandler(this.tbx_totalMoney_Leave);
            this.tbx_totalMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_totalMoney_KeyPress);
            // 
            // bs_finActs
            // 
            this.bs_finActs.DataMember = "tbl_finActs";
            this.bs_finActs.DataSource = this.ds_finActs;
            // 
            // ds_finActs
            // 
            this.ds_finActs.DataSetName = "ds_finActs";
            this.ds_finActs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_actionPrompt
            // 
            this.lbl_actionPrompt.AutoSize = true;
            this.lbl_actionPrompt.Location = new System.Drawing.Point(305, 168);
            this.lbl_actionPrompt.Name = "lbl_actionPrompt";
            this.lbl_actionPrompt.Size = new System.Drawing.Size(67, 13);
            this.lbl_actionPrompt.TabIndex = 9;
            this.lbl_actionPrompt.Text = "مبلغ واریزی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "تاریخ سند :";
            // 
            // mTbx_accDocDate
            // 
            this.mTbx_accDocDate.AllowDrop = true;
            this.mTbx_accDocDate.AllowPromptAsInput = false;
            this.mTbx_accDocDate.Location = new System.Drawing.Point(9, 12);
            this.mTbx_accDocDate.Mask = "0000/00/00";
            this.mTbx_accDocDate.Name = "mTbx_accDocDate";
            this.mTbx_accDocDate.PromptChar = ' ';
            this.mTbx_accDocDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_accDocDate.Size = new System.Drawing.Size(69, 21);
            this.mTbx_accDocDate.TabIndex = 10;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(342, 479);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(136, 23);
            this.btn_ok.TabIndex = 53;
            this.btn_ok.Text = "تــــائید (Ctrl+Enter)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 479);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 23);
            this.btn_cancel.TabIndex = 54;
            this.btn_cancel.Text = "لغو (Esc)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_priceInChars
            // 
            this.lbl_priceInChars.ForeColor = System.Drawing.Color.Red;
            this.lbl_priceInChars.Location = new System.Drawing.Point(12, 194);
            this.lbl_priceInChars.Name = "lbl_priceInChars";
            this.lbl_priceInChars.Size = new System.Drawing.Size(466, 23);
            this.lbl_priceInChars.TabIndex = 55;
            this.lbl_priceInChars.Text = "صفر ریال";
            // 
            // tbx_comment
            // 
            this.tbx_comment.Location = new System.Drawing.Point(52, 440);
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(316, 21);
            this.tbx_comment.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "تــــوضیحات :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.tbx_remainMoney);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbx_totalPaidMoney);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(38, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 69);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(89, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "ریال";
            // 
            // tbx_remainMoney
            // 
            this.tbx_remainMoney.Location = new System.Drawing.Point(119, 37);
            this.tbx_remainMoney.Name = "tbx_remainMoney";
            this.tbx_remainMoney.ReadOnly = true;
            this.tbx_remainMoney.Size = new System.Drawing.Size(187, 21);
            this.tbx_remainMoney.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "ریال";
            // 
            // tbx_totalPaidMoney
            // 
            this.tbx_totalPaidMoney.Location = new System.Drawing.Point(119, 14);
            this.tbx_totalPaidMoney.Name = "tbx_totalPaidMoney";
            this.tbx_totalPaidMoney.ReadOnly = true;
            this.tbx_totalPaidMoney.Size = new System.Drawing.Size(187, 21);
            this.tbx_totalPaidMoney.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "بــــاقیمانده :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "جمع :";
            // 
            // grp_paySet
            // 
            this.grp_paySet.Controls.Add(this.tbx_indebtedMoney);
            this.grp_paySet.Controls.Add(this.tbx_discountMoney);
            this.grp_paySet.Controls.Add(this.tbx_cashMoney);
            this.grp_paySet.Controls.Add(this.label18);
            this.grp_paySet.Controls.Add(this.label17);
            this.grp_paySet.Controls.Add(this.label16);
            this.grp_paySet.Controls.Add(this.btn_useCheque);
            this.grp_paySet.Controls.Add(this.btn_newCheque);
            this.grp_paySet.Controls.Add(this.tbx_uesedChequesMoney);
            this.grp_paySet.Controls.Add(this.tbx_chequesMoney);
            this.grp_paySet.Controls.Add(this.label9);
            this.grp_paySet.Controls.Add(this.label8);
            this.grp_paySet.Controls.Add(this.label7);
            this.grp_paySet.Controls.Add(this.label6);
            this.grp_paySet.Controls.Add(this.label5);
            this.grp_paySet.Enabled = false;
            this.grp_paySet.Location = new System.Drawing.Point(38, 220);
            this.grp_paySet.Name = "grp_paySet";
            this.grp_paySet.Size = new System.Drawing.Size(406, 139);
            this.grp_paySet.TabIndex = 58;
            this.grp_paySet.TabStop = false;
            // 
            // tbx_indebtedMoney
            // 
            this.tbx_indebtedMoney.Location = new System.Drawing.Point(134, 108);
            this.tbx_indebtedMoney.Name = "tbx_indebtedMoney";
            this.tbx_indebtedMoney.ReadOnly = true;
            this.tbx_indebtedMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_indebtedMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_indebtedMoney.TabIndex = 26;
            this.tbx_indebtedMoney.Text = "0";
            this.tbx_indebtedMoney.TextChanged += new System.EventHandler(this.tbx_indebtedMoney_TextChanged);
            this.tbx_indebtedMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_indebtedMoney_KeyUp);
            this.tbx_indebtedMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_indebtedMoney_KeyPress);
            // 
            // tbx_discountMoney
            // 
            this.tbx_discountMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_finActs, "finAct_indebtedMoney", true));
            this.tbx_discountMoney.Location = new System.Drawing.Point(134, 84);
            this.tbx_discountMoney.Name = "tbx_discountMoney";
            this.tbx_discountMoney.ReadOnly = true;
            this.tbx_discountMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_discountMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_discountMoney.TabIndex = 25;
            this.tbx_discountMoney.Text = "0";
            this.tbx_discountMoney.TextChanged += new System.EventHandler(this.tbx_discountMoney_TextChanged);
            this.tbx_discountMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_discountMoney_KeyUp);
            this.tbx_discountMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_discountMoney_KeyPress);
            // 
            // tbx_cashMoney
            // 
            this.tbx_cashMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_finActs, "finAct_cashMoney", true));
            this.tbx_cashMoney.Location = new System.Drawing.Point(134, 12);
            this.tbx_cashMoney.Name = "tbx_cashMoney";
            this.tbx_cashMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_cashMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_cashMoney.TabIndex = 24;
            this.tbx_cashMoney.Text = "0";
            this.tbx_cashMoney.TextChanged += new System.EventHandler(this.tbx_cashMoney_TextChanged);
            this.tbx_cashMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_cashMoney_KeyUp);
            this.tbx_cashMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_cashMoney_KeyPress_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(104, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "ریال";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "ریال";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(104, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "ریال";
            // 
            // btn_useCheque
            // 
            this.btn_useCheque.Location = new System.Drawing.Point(50, 60);
            this.btn_useCheque.Name = "btn_useCheque";
            this.btn_useCheque.Size = new System.Drawing.Size(75, 23);
            this.btn_useCheque.TabIndex = 16;
            this.btn_useCheque.Text = "خـــرج چک";
            this.btn_useCheque.UseVisualStyleBackColor = true;
            // 
            // btn_newCheque
            // 
            this.btn_newCheque.Location = new System.Drawing.Point(50, 34);
            this.btn_newCheque.Name = "btn_newCheque";
            this.btn_newCheque.Size = new System.Drawing.Size(75, 23);
            this.btn_newCheque.TabIndex = 15;
            this.btn_newCheque.Text = "چـــــک";
            this.btn_newCheque.UseVisualStyleBackColor = true;
            this.btn_newCheque.Click += new System.EventHandler(this.btn_newCheque_Click);
            // 
            // tbx_uesedChequesMoney
            // 
            this.tbx_uesedChequesMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_finActs, "finAct_useChequesMoney", true));
            this.tbx_uesedChequesMoney.Location = new System.Drawing.Point(134, 60);
            this.tbx_uesedChequesMoney.Name = "tbx_uesedChequesMoney";
            this.tbx_uesedChequesMoney.ReadOnly = true;
            this.tbx_uesedChequesMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_uesedChequesMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_uesedChequesMoney.TabIndex = 10;
            this.tbx_uesedChequesMoney.Text = "0";
            this.tbx_uesedChequesMoney.TextChanged += new System.EventHandler(this.tbx_uesedChequesMoney_TextChanged);
            // 
            // tbx_chequesMoney
            // 
            this.tbx_chequesMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_finActs, "finAct_chequesMoney", true));
            this.tbx_chequesMoney.Location = new System.Drawing.Point(134, 36);
            this.tbx_chequesMoney.Name = "tbx_chequesMoney";
            this.tbx_chequesMoney.ReadOnly = true;
            this.tbx_chequesMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_chequesMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_chequesMoney.TabIndex = 9;
            this.tbx_chequesMoney.Text = "0";
            this.tbx_chequesMoney.TextChanged += new System.EventHandler(this.tbx_chequesMoney_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "نسیه :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "تخفیف :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "خرج چک :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "چک :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "نقد :";
            // 
            // tbl_finActsTableAdapter
            // 
            this.tbl_finActsTableAdapter.ClearBeforeFill = true;
            // 
            // bs_MOEENS
            // 
            this.bs_MOEENS.DataMember = "tbl_MOEENs";
            this.bs_MOEENS.DataSource = this.ds_finActs;
            // 
            // tbl_MOEENsTableAdapter
            // 
            this.tbl_MOEENsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(208, 479);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 23);
            this.btn_delete.TabIndex = 60;
            this.btn_delete.Text = "حذف سند (Ctrl+Del)";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_finActions
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(500, 509);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tbx_comment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_paySet);
            this.Controls.Add(this.lbl_priceInChars);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mTbx_accDocDate);
            this.Controls.Add(this.lbl_actionPrompt);
            this.Controls.Add(this.tbx_totalMoney);
            this.Controls.Add(this.pnl_fromSet);
            this.Controls.Add(this.pnl_toSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_typeFinAction);
            this.Name = "frm_finActions";
            this.Text = "  عـمـلیـــات مــالــی";
            this.Load += new System.EventHandler(this.frm_finActions_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_finActions_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bs_viwAccounts_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_viewAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viwAccounts_to)).EndInit();
            this.pnl_toSet.ResumeLayout(false);
            this.pnl_fromSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_finActs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_finActs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grp_paySet.ResumeLayout(false);
            this.grp_paySet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MOEENS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_typeFinAction;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.ComboBox cbx_from;
        private System.Windows.Forms.ComboBox cbx_to;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label label3;
        private ds_viewAccounts ds_viewAccounts;
        private System.Windows.Forms.BindingSource bs_viwAccounts_from;
        private Novin.ds_viewAccountsTableAdapters.viw_accountsTableAdapter viw_accountsTableAdapter;
        private System.Windows.Forms.BindingSource bs_viwAccounts_to;
        private System.Windows.Forms.Panel pnl_toSet;
        private System.Windows.Forms.Panel pnl_fromSet;
        private ds_persons ds_persons;
        private System.Windows.Forms.BindingSource bs_persons;
        private Novin.ds_personsTableAdapters.tbl_personsTableAdapter tbl_personsTableAdapter;
        private System.Windows.Forms.TextBox tbx_totalMoney;
        private System.Windows.Forms.Label lbl_actionPrompt;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox mTbx_accDocDate;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private ds_finActs ds_finActs;
        private System.Windows.Forms.BindingSource bs_finActs;
        private Novin.ds_finActsTableAdapters.tbl_finActsTableAdapter tbl_finActsTableAdapter;
        private System.Windows.Forms.Label lbl_priceInChars;
        private System.Windows.Forms.TextBox tbx_comment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbx_remainMoney;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbx_totalPaidMoney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grp_paySet;
        private System.Windows.Forms.TextBox tbx_indebtedMoney;
        private System.Windows.Forms.TextBox tbx_discountMoney;
        private System.Windows.Forms.TextBox tbx_cashMoney;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_useCheque;
        private System.Windows.Forms.Button btn_newCheque;
        private System.Windows.Forms.TextBox tbx_uesedChequesMoney;
        private System.Windows.Forms.TextBox tbx_chequesMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bs_MOEENS;
        private Novin.ds_finActsTableAdapters.tbl_MOEENsTableAdapter tbl_MOEENsTableAdapter;
        private System.Windows.Forms.Button btn_delete;
    }
}
