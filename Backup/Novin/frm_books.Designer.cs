namespace Novin
{
    partial class frm_books
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
            this.grp_bookKind = new System.Windows.Forms.GroupBox();
            this.pnl_detail = new System.Windows.Forms.Panel();
            this.chk_personsMoeenOnly = new System.Windows.Forms.CheckBox();
            this.tbx_detailCode = new System.Windows.Forms.TextBox();
            this.bs_MOEENs = new System.Windows.Forms.BindingSource(this.components);
            this.ds_accounting = new Novin.ds_accounting();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_detail = new System.Windows.Forms.ComboBox();
            this.pnl_masterSpent = new System.Windows.Forms.Panel();
            this.tbx_ledgerCode = new System.Windows.Forms.TextBox();
            this.bs_KOLs = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_masterSpentName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdu_smallLedger = new System.Windows.Forms.RadioButton();
            this.rdu_bigLedger = new System.Windows.Forms.RadioButton();
            this.rdu_journal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_searchInDeletedInvoices = new System.Windows.Forms.CheckBox();
            this.pnl_betweenIDs = new System.Windows.Forms.Panel();
            this.tbx_toID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_fromID = new System.Windows.Forms.TextBox();
            this.pnl_betweenDates = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mTbx_fromDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_toDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_inDate = new System.Windows.Forms.MaskedTextBox();
            this.rdu_showBetweenAccDoc_ids = new System.Windows.Forms.RadioButton();
            this.rdu_showBetweenDates = new System.Windows.Forms.RadioButton();
            this.rdu_showAll = new System.Windows.Forms.RadioButton();
            this.rdu_showInDate = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tbl_KOLsTableAdapter = new Novin.ds_accountingTableAdapters.tbl_KOLsTableAdapter();
            this.tbl_MOEENsTableAdapter = new Novin.ds_accountingTableAdapters.tbl_MOEENsTableAdapter();
            this.grp_bookKind.SuspendLayout();
            this.pnl_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MOEENs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounting)).BeginInit();
            this.pnl_masterSpent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_KOLs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnl_betweenIDs.SuspendLayout();
            this.pnl_betweenDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_bookKind
            // 
            this.grp_bookKind.BackColor = System.Drawing.Color.Transparent;
            this.grp_bookKind.Controls.Add(this.pnl_detail);
            this.grp_bookKind.Controls.Add(this.pnl_masterSpent);
            this.grp_bookKind.Controls.Add(this.rdu_smallLedger);
            this.grp_bookKind.Controls.Add(this.rdu_bigLedger);
            this.grp_bookKind.Controls.Add(this.rdu_journal);
            this.grp_bookKind.Location = new System.Drawing.Point(12, 12);
            this.grp_bookKind.Name = "grp_bookKind";
            this.grp_bookKind.Size = new System.Drawing.Size(546, 175);
            this.grp_bookKind.TabIndex = 2;
            this.grp_bookKind.TabStop = false;
            this.grp_bookKind.Text = "نوع دفتر حسابداری";
            // 
            // pnl_detail
            // 
            this.pnl_detail.Controls.Add(this.chk_personsMoeenOnly);
            this.pnl_detail.Controls.Add(this.tbx_detailCode);
            this.pnl_detail.Controls.Add(this.label4);
            this.pnl_detail.Controls.Add(this.cmb_detail);
            this.pnl_detail.Enabled = false;
            this.pnl_detail.Location = new System.Drawing.Point(6, 52);
            this.pnl_detail.Name = "pnl_detail";
            this.pnl_detail.Size = new System.Drawing.Size(295, 117);
            this.pnl_detail.TabIndex = 4;
            // 
            // chk_personsMoeenOnly
            // 
            this.chk_personsMoeenOnly.AutoSize = true;
            this.chk_personsMoeenOnly.Location = new System.Drawing.Point(97, 13);
            this.chk_personsMoeenOnly.Name = "chk_personsMoeenOnly";
            this.chk_personsMoeenOnly.Size = new System.Drawing.Size(102, 17);
            this.chk_personsMoeenOnly.TabIndex = 5;
            this.chk_personsMoeenOnly.Text = "معیــــن اشخاص";
            this.chk_personsMoeenOnly.UseVisualStyleBackColor = true;
            this.chk_personsMoeenOnly.CheckedChanged += new System.EventHandler(this.chk_personsMoeenOnly_CheckedChanged);
            // 
            // tbx_detailCode
            // 
            this.tbx_detailCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_MOEENs, "moeen_id", true));
            this.tbx_detailCode.Location = new System.Drawing.Point(220, 76);
            this.tbx_detailCode.Name = "tbx_detailCode";
            this.tbx_detailCode.ReadOnly = true;
            this.tbx_detailCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_detailCode.Size = new System.Drawing.Size(69, 21);
            this.tbx_detailCode.TabIndex = 0;
            // 
            // bs_MOEENs
            // 
            this.bs_MOEENs.DataMember = "tbl_MOEENs";
            this.bs_MOEENs.DataSource = this.ds_accounting;
            // 
            // ds_accounting
            // 
            this.ds_accounting.DataSetName = "ds_accounting";
            this.ds_accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "سرفصل معین :";
            // 
            // cmb_detail
            // 
            this.cmb_detail.DataSource = this.bs_MOEENs;
            this.cmb_detail.DisplayMember = "moeen_title";
            this.cmb_detail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_detail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_detail.FormattingEnabled = true;
            this.cmb_detail.Location = new System.Drawing.Point(2, 75);
            this.cmb_detail.Name = "cmb_detail";
            this.cmb_detail.Size = new System.Drawing.Size(212, 22);
            this.cmb_detail.TabIndex = 1;
            this.cmb_detail.ValueMember = "moeen_id";
            this.cmb_detail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_detail_KeyPress);
            // 
            // pnl_masterSpent
            // 
            this.pnl_masterSpent.Controls.Add(this.tbx_ledgerCode);
            this.pnl_masterSpent.Controls.Add(this.cmb_masterSpentName);
            this.pnl_masterSpent.Controls.Add(this.label3);
            this.pnl_masterSpent.Enabled = false;
            this.pnl_masterSpent.Location = new System.Drawing.Point(304, 52);
            this.pnl_masterSpent.Name = "pnl_masterSpent";
            this.pnl_masterSpent.Size = new System.Drawing.Size(233, 117);
            this.pnl_masterSpent.TabIndex = 3;
            // 
            // tbx_ledgerCode
            // 
            this.tbx_ledgerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_ledgerCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_KOLs, "kol_id", true));
            this.tbx_ledgerCode.Location = new System.Drawing.Point(184, 72);
            this.tbx_ledgerCode.Name = "tbx_ledgerCode";
            this.tbx_ledgerCode.ReadOnly = true;
            this.tbx_ledgerCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_ledgerCode.Size = new System.Drawing.Size(46, 21);
            this.tbx_ledgerCode.TabIndex = 0;
            // 
            // bs_KOLs
            // 
            this.bs_KOLs.DataMember = "tbl_KOLs";
            this.bs_KOLs.DataSource = this.ds_accounting;
            this.bs_KOLs.CurrentChanged += new System.EventHandler(this.bs_KOLs_CurrentChanged);
            // 
            // cmb_masterSpentName
            // 
            this.cmb_masterSpentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_masterSpentName.DataSource = this.bs_KOLs;
            this.cmb_masterSpentName.DisplayMember = "kol_title";
            this.cmb_masterSpentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_masterSpentName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_masterSpentName.FormattingEnabled = true;
            this.cmb_masterSpentName.Location = new System.Drawing.Point(13, 72);
            this.cmb_masterSpentName.Name = "cmb_masterSpentName";
            this.cmb_masterSpentName.Size = new System.Drawing.Size(165, 22);
            this.cmb_masterSpentName.TabIndex = 1;
            this.cmb_masterSpentName.ValueMember = "kol_id";
            this.cmb_masterSpentName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmb_masterSpentName_MouseUp);
            this.cmb_masterSpentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_masterSpentName_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "سرفصل کل :";
            // 
            // rdu_smallLedger
            // 
            this.rdu_smallLedger.AutoSize = true;
            this.rdu_smallLedger.BackColor = System.Drawing.Color.Transparent;
            this.rdu_smallLedger.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_smallLedger.ForeColor = System.Drawing.Color.Red;
            this.rdu_smallLedger.Location = new System.Drawing.Point(103, 9);
            this.rdu_smallLedger.Name = "rdu_smallLedger";
            this.rdu_smallLedger.Size = new System.Drawing.Size(99, 37);
            this.rdu_smallLedger.TabIndex = 2;
            this.rdu_smallLedger.Text = "دفتر معین";
            this.rdu_smallLedger.UseVisualStyleBackColor = false;
            this.rdu_smallLedger.CheckedChanged += new System.EventHandler(this.rdu_smallJournal_CheckedChanged);
            // 
            // rdu_bigLedger
            // 
            this.rdu_bigLedger.AutoSize = true;
            this.rdu_bigLedger.BackColor = System.Drawing.Color.Transparent;
            this.rdu_bigLedger.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_bigLedger.ForeColor = System.Drawing.Color.Red;
            this.rdu_bigLedger.Location = new System.Drawing.Point(225, 6);
            this.rdu_bigLedger.Name = "rdu_bigLedger";
            this.rdu_bigLedger.Size = new System.Drawing.Size(87, 37);
            this.rdu_bigLedger.TabIndex = 1;
            this.rdu_bigLedger.Text = "دفتر کل";
            this.rdu_bigLedger.UseVisualStyleBackColor = false;
            this.rdu_bigLedger.CheckedChanged += new System.EventHandler(this.rdu_bigJournal_CheckedChanged);
            // 
            // rdu_journal
            // 
            this.rdu_journal.AutoSize = true;
            this.rdu_journal.BackColor = System.Drawing.Color.Transparent;
            this.rdu_journal.Checked = true;
            this.rdu_journal.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_journal.ForeColor = System.Drawing.Color.Red;
            this.rdu_journal.Location = new System.Drawing.Point(327, 9);
            this.rdu_journal.Name = "rdu_journal";
            this.rdu_journal.Size = new System.Drawing.Size(116, 37);
            this.rdu_journal.TabIndex = 0;
            this.rdu_journal.TabStop = true;
            this.rdu_journal.Text = "دفتر روزنامه";
            this.rdu_journal.UseVisualStyleBackColor = false;
            this.rdu_journal.CheckedChanged += new System.EventHandler(this.rdu_journal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chk_searchInDeletedInvoices);
            this.groupBox1.Controls.Add(this.pnl_betweenIDs);
            this.groupBox1.Controls.Add(this.pnl_betweenDates);
            this.groupBox1.Controls.Add(this.mTbx_inDate);
            this.groupBox1.Controls.Add(this.rdu_showBetweenAccDoc_ids);
            this.groupBox1.Controls.Add(this.rdu_showBetweenDates);
            this.groupBox1.Controls.Add(this.rdu_showAll);
            this.groupBox1.Controls.Add(this.rdu_showInDate);
            this.groupBox1.Location = new System.Drawing.Point(13, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "شروط";
            // 
            // chk_searchInDeletedInvoices
            // 
            this.chk_searchInDeletedInvoices.AutoSize = true;
            this.chk_searchInDeletedInvoices.Location = new System.Drawing.Point(346, 187);
            this.chk_searchInDeletedInvoices.Name = "chk_searchInDeletedInvoices";
            this.chk_searchInDeletedInvoices.Size = new System.Drawing.Size(158, 17);
            this.chk_searchInDeletedInvoices.TabIndex = 60;
            this.chk_searchInDeletedInvoices.Text = "نــمایش سندهای حذف شده";
            this.chk_searchInDeletedInvoices.UseVisualStyleBackColor = true;
            // 
            // pnl_betweenIDs
            // 
            this.pnl_betweenIDs.Controls.Add(this.tbx_toID);
            this.pnl_betweenIDs.Controls.Add(this.label2);
            this.pnl_betweenIDs.Controls.Add(this.tbx_fromID);
            this.pnl_betweenIDs.Enabled = false;
            this.pnl_betweenIDs.Location = new System.Drawing.Point(30, 149);
            this.pnl_betweenIDs.Name = "pnl_betweenIDs";
            this.pnl_betweenIDs.Size = new System.Drawing.Size(232, 44);
            this.pnl_betweenIDs.TabIndex = 6;
            // 
            // tbx_toID
            // 
            this.tbx_toID.Location = new System.Drawing.Point(8, 5);
            this.tbx_toID.Name = "tbx_toID";
            this.tbx_toID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_toID.Size = new System.Drawing.Size(91, 21);
            this.tbx_toID.TabIndex = 1;
            this.tbx_toID.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "تا";
            // 
            // tbx_fromID
            // 
            this.tbx_fromID.Location = new System.Drawing.Point(128, 6);
            this.tbx_fromID.Name = "tbx_fromID";
            this.tbx_fromID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_fromID.Size = new System.Drawing.Size(91, 21);
            this.tbx_fromID.TabIndex = 0;
            this.tbx_fromID.Text = "1";
            // 
            // pnl_betweenDates
            // 
            this.pnl_betweenDates.Controls.Add(this.label1);
            this.pnl_betweenDates.Controls.Add(this.mTbx_fromDate);
            this.pnl_betweenDates.Controls.Add(this.mTbx_toDate);
            this.pnl_betweenDates.Enabled = false;
            this.pnl_betweenDates.Location = new System.Drawing.Point(30, 99);
            this.pnl_betweenDates.Name = "pnl_betweenDates";
            this.pnl_betweenDates.Size = new System.Drawing.Size(232, 47);
            this.pnl_betweenDates.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "تا";
            // 
            // mTbx_fromDate
            // 
            this.mTbx_fromDate.AllowPromptAsInput = false;
            this.mTbx_fromDate.Location = new System.Drawing.Point(128, 6);
            this.mTbx_fromDate.Mask = "0000/00/00";
            this.mTbx_fromDate.Name = "mTbx_fromDate";
            this.mTbx_fromDate.PromptChar = ' ';
            this.mTbx_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_fromDate.Size = new System.Drawing.Size(91, 21);
            this.mTbx_fromDate.TabIndex = 0;
            this.mTbx_fromDate.Leave += new System.EventHandler(this.mTbx_fromDate_Leave);
            // 
            // mTbx_toDate
            // 
            this.mTbx_toDate.AllowPromptAsInput = false;
            this.mTbx_toDate.Location = new System.Drawing.Point(8, 6);
            this.mTbx_toDate.Mask = "0000/00/00";
            this.mTbx_toDate.Name = "mTbx_toDate";
            this.mTbx_toDate.PromptChar = ' ';
            this.mTbx_toDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_toDate.Size = new System.Drawing.Size(91, 21);
            this.mTbx_toDate.TabIndex = 1;
            this.mTbx_toDate.Leave += new System.EventHandler(this.mTbx_toDate_Leave);
            // 
            // mTbx_inDate
            // 
            this.mTbx_inDate.AllowPromptAsInput = false;
            this.mTbx_inDate.Location = new System.Drawing.Point(158, 67);
            this.mTbx_inDate.Mask = "0000/00/00";
            this.mTbx_inDate.Name = "mTbx_inDate";
            this.mTbx_inDate.PromptChar = ' ';
            this.mTbx_inDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_inDate.Size = new System.Drawing.Size(91, 21);
            this.mTbx_inDate.TabIndex = 2;
            this.mTbx_inDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTbx_inDate_MaskInputRejected);
            this.mTbx_inDate.Leave += new System.EventHandler(this.mTbx_inDate_Leave);
            // 
            // rdu_showBetweenAccDoc_ids
            // 
            this.rdu_showBetweenAccDoc_ids.AutoSize = true;
            this.rdu_showBetweenAccDoc_ids.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenAccDoc_ids.Location = new System.Drawing.Point(313, 146);
            this.rdu_showBetweenAccDoc_ids.Name = "rdu_showBetweenAccDoc_ids";
            this.rdu_showBetweenAccDoc_ids.Size = new System.Drawing.Size(191, 17);
            this.rdu_showBetweenAccDoc_ids.TabIndex = 5;
            this.rdu_showBetweenAccDoc_ids.Text = "نمایش دفتر ما بین شماره سند های ";
            this.rdu_showBetweenAccDoc_ids.UseVisualStyleBackColor = false;
            this.rdu_showBetweenAccDoc_ids.CheckedChanged += new System.EventHandler(this.rdu_showBetweenAccDoc_ids_CheckedChanged);
            // 
            // rdu_showBetweenDates
            // 
            this.rdu_showBetweenDates.AutoSize = true;
            this.rdu_showBetweenDates.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenDates.Location = new System.Drawing.Point(346, 105);
            this.rdu_showBetweenDates.Name = "rdu_showBetweenDates";
            this.rdu_showBetweenDates.Size = new System.Drawing.Size(158, 17);
            this.rdu_showBetweenDates.TabIndex = 3;
            this.rdu_showBetweenDates.Text = "نمایش دفتر ما بین تاریخ های ";
            this.rdu_showBetweenDates.UseVisualStyleBackColor = false;
            this.rdu_showBetweenDates.CheckedChanged += new System.EventHandler(this.rdu_showBetweenDates_CheckedChanged);
            // 
            // rdu_showAll
            // 
            this.rdu_showAll.AutoSize = true;
            this.rdu_showAll.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showAll.Location = new System.Drawing.Point(404, 23);
            this.rdu_showAll.Name = "rdu_showAll";
            this.rdu_showAll.Size = new System.Drawing.Size(100, 17);
            this.rdu_showAll.TabIndex = 0;
            this.rdu_showAll.Text = "نمایش کل دفتر .";
            this.rdu_showAll.UseVisualStyleBackColor = false;
            // 
            // rdu_showInDate
            // 
            this.rdu_showInDate.AutoSize = true;
            this.rdu_showInDate.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showInDate.Checked = true;
            this.rdu_showInDate.Location = new System.Drawing.Point(391, 64);
            this.rdu_showInDate.Name = "rdu_showInDate";
            this.rdu_showInDate.Size = new System.Drawing.Size(113, 17);
            this.rdu_showInDate.TabIndex = 1;
            this.rdu_showInDate.TabStop = true;
            this.rdu_showInDate.Text = "نمایش دفتر در تاریخ";
            this.rdu_showInDate.UseVisualStyleBackColor = false;
            this.rdu_showInDate.CheckedChanged += new System.EventHandler(this.rdu_showInDate_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(339, 421);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(199, 23);
            this.btn_ok.TabIndex = 55;
            this.btn_ok.Text = "نـــمایــش گزارش";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(18, 421);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 23);
            this.btn_cancel.TabIndex = 56;
            this.btn_cancel.Text = "بــــستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tbl_KOLsTableAdapter
            // 
            this.tbl_KOLsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_MOEENsTableAdapter
            // 
            this.tbl_MOEENsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_books
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(571, 456);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.grp_bookKind);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_books";
            this.Text = "   دفاتر حسابداری";
            this.Load += new System.EventHandler(this.frm_books_Load);
            this.grp_bookKind.ResumeLayout(false);
            this.grp_bookKind.PerformLayout();
            this.pnl_detail.ResumeLayout(false);
            this.pnl_detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MOEENs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounting)).EndInit();
            this.pnl_masterSpent.ResumeLayout(false);
            this.pnl_masterSpent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_KOLs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_betweenIDs.ResumeLayout(false);
            this.pnl_betweenIDs.PerformLayout();
            this.pnl_betweenDates.ResumeLayout(false);
            this.pnl_betweenDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_bookKind;
        private System.Windows.Forms.Panel pnl_detail;
        private System.Windows.Forms.TextBox tbx_detailCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_detail;
        private System.Windows.Forms.Panel pnl_masterSpent;
        private System.Windows.Forms.TextBox tbx_ledgerCode;
        private System.Windows.Forms.ComboBox cmb_masterSpentName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton rdu_smallLedger;
        public System.Windows.Forms.RadioButton rdu_bigLedger;
        public System.Windows.Forms.RadioButton rdu_journal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl_betweenIDs;
        private System.Windows.Forms.TextBox tbx_toID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_fromID;
        private System.Windows.Forms.Panel pnl_betweenDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTbx_fromDate;
        private System.Windows.Forms.MaskedTextBox mTbx_toDate;
        private System.Windows.Forms.MaskedTextBox mTbx_inDate;
        private System.Windows.Forms.RadioButton rdu_showBetweenAccDoc_ids;
        private System.Windows.Forms.RadioButton rdu_showBetweenDates;
        private System.Windows.Forms.RadioButton rdu_showAll;
        private System.Windows.Forms.RadioButton rdu_showInDate;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private ds_accounting ds_accounting;
        private System.Windows.Forms.BindingSource bs_KOLs;
        private Novin.ds_accountingTableAdapters.tbl_KOLsTableAdapter tbl_KOLsTableAdapter;
        private System.Windows.Forms.BindingSource bs_MOEENs;
        private Novin.ds_accountingTableAdapters.tbl_MOEENsTableAdapter tbl_MOEENsTableAdapter;
        public System.Windows.Forms.CheckBox chk_personsMoeenOnly;
        private System.Windows.Forms.CheckBox chk_searchInDeletedInvoices;
    }
}
