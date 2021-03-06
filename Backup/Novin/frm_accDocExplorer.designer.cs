namespace Novin
{
    partial class frm_accDocExplorer
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
            this.btn_printAll = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pag_viaDocNumber = new System.Windows.Forms.TabPage();
            this.rdu_allAccDocs = new System.Windows.Forms.RadioButton();
            this.rdu_betweensNumber = new System.Windows.Forms.RadioButton();
            this.rdu_equalsToNumber = new System.Windows.Forms.RadioButton();
            this.rdu_moreThanNumber = new System.Windows.Forms.RadioButton();
            this.rdu_lessThanNumber = new System.Windows.Forms.RadioButton();
            this.num_toNumber = new System.Windows.Forms.NumericUpDown();
            this.pnl_rangeNumber = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.num_fromNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pag_viaDocDate = new System.Windows.Forms.TabPage();
            this.pnl_rangeDate = new System.Windows.Forms.Panel();
            this.mTbx_fromDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mTbx_toDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdu_betweensDate = new System.Windows.Forms.RadioButton();
            this.rdu_equalsToDate = new System.Windows.Forms.RadioButton();
            this.rdu_moreThanDate = new System.Windows.Forms.RadioButton();
            this.rdu_lessThanDate = new System.Windows.Forms.RadioButton();
            this.pag_viaDocPrice = new System.Windows.Forms.TabPage();
            this.tbx_toPrice = new System.Windows.Forms.TextBox();
            this.pnl_rangePrice = new System.Windows.Forms.Panel();
            this.tbx_fromPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdu_betweensPrice = new System.Windows.Forms.RadioButton();
            this.rdu_equalsToPrice = new System.Windows.Forms.RadioButton();
            this.rdu_moreThanPrice = new System.Windows.Forms.RadioButton();
            this.rdu_lessThanPrice = new System.Windows.Forms.RadioButton();
            this.lbl_priceInChars = new System.Windows.Forms.Label();
            this.pag_viaDocComment = new System.Windows.Forms.TabPage();
            this.tbx_commend = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pag_viaDocNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_toNumber)).BeginInit();
            this.pnl_rangeNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fromNumber)).BeginInit();
            this.pag_viaDocDate.SuspendLayout();
            this.pnl_rangeDate.SuspendLayout();
            this.pag_viaDocPrice.SuspendLayout();
            this.pnl_rangePrice.SuspendLayout();
            this.pag_viaDocComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_printAll
            // 
            this.btn_printAll.Location = new System.Drawing.Point(290, 381);
            this.btn_printAll.Name = "btn_printAll";
            this.btn_printAll.Size = new System.Drawing.Size(92, 23);
            this.btn_printAll.TabIndex = 65;
            this.btn_printAll.Text = "چـــاپ همه";
            this.btn_printAll.UseVisualStyleBackColor = true;
            this.btn_printAll.Click += new System.EventHandler(this.btn_printAll_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Enabled = false;
            this.btn_modify.Location = new System.Drawing.Point(388, 381);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(92, 23);
            this.btn_modify.TabIndex = 64;
            this.btn_modify.Text = "اصـــــلاح";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(486, 381);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(92, 23);
            this.btn_print.TabIndex = 63;
            this.btn_print.Text = "نمایــــش";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(577, 160);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(415, 186);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 60;
            this.btn_ok.Text = "جستجو";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(24, 381);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 61;
            this.btn_cancel.Text = "بــــستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pag_viaDocNumber);
            this.tabControl1.Controls.Add(this.pag_viaDocDate);
            this.tabControl1.Controls.Add(this.pag_viaDocPrice);
            this.tabControl1.Controls.Add(this.pag_viaDocComment);
            this.tabControl1.Location = new System.Drawing.Point(8, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 160);
            this.tabControl1.TabIndex = 59;
            // 
            // pag_viaDocNumber
            // 
            this.pag_viaDocNumber.Controls.Add(this.rdu_allAccDocs);
            this.pag_viaDocNumber.Controls.Add(this.rdu_betweensNumber);
            this.pag_viaDocNumber.Controls.Add(this.rdu_equalsToNumber);
            this.pag_viaDocNumber.Controls.Add(this.rdu_moreThanNumber);
            this.pag_viaDocNumber.Controls.Add(this.rdu_lessThanNumber);
            this.pag_viaDocNumber.Controls.Add(this.num_toNumber);
            this.pag_viaDocNumber.Controls.Add(this.pnl_rangeNumber);
            this.pag_viaDocNumber.Controls.Add(this.label5);
            this.pag_viaDocNumber.Location = new System.Drawing.Point(4, 22);
            this.pag_viaDocNumber.Name = "pag_viaDocNumber";
            this.pag_viaDocNumber.Padding = new System.Windows.Forms.Padding(3);
            this.pag_viaDocNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pag_viaDocNumber.Size = new System.Drawing.Size(577, 134);
            this.pag_viaDocNumber.TabIndex = 0;
            this.pag_viaDocNumber.Text = "شماره ســند";
            this.pag_viaDocNumber.UseVisualStyleBackColor = true;
            // 
            // rdu_allAccDocs
            // 
            this.rdu_allAccDocs.AutoSize = true;
            this.rdu_allAccDocs.Location = new System.Drawing.Point(73, 6);
            this.rdu_allAccDocs.Name = "rdu_allAccDocs";
            this.rdu_allAccDocs.Size = new System.Drawing.Size(84, 17);
            this.rdu_allAccDocs.TabIndex = 5;
            this.rdu_allAccDocs.Text = "همه اسنـــاد";
            this.rdu_allAccDocs.UseVisualStyleBackColor = true;
            // 
            // rdu_betweensNumber
            // 
            this.rdu_betweensNumber.AutoSize = true;
            this.rdu_betweensNumber.Location = new System.Drawing.Point(176, 6);
            this.rdu_betweensNumber.Name = "rdu_betweensNumber";
            this.rdu_betweensNumber.Size = new System.Drawing.Size(52, 17);
            this.rdu_betweensNumber.TabIndex = 4;
            this.rdu_betweensNumber.Text = "ما بین";
            this.rdu_betweensNumber.UseVisualStyleBackColor = true;
            this.rdu_betweensNumber.CheckedChanged += new System.EventHandler(this.rdu_betweensNumber_CheckedChanged);
            // 
            // rdu_equalsToNumber
            // 
            this.rdu_equalsToNumber.AutoSize = true;
            this.rdu_equalsToNumber.Checked = true;
            this.rdu_equalsToNumber.Location = new System.Drawing.Point(257, 6);
            this.rdu_equalsToNumber.Name = "rdu_equalsToNumber";
            this.rdu_equalsToNumber.Size = new System.Drawing.Size(61, 17);
            this.rdu_equalsToNumber.TabIndex = 3;
            this.rdu_equalsToNumber.TabStop = true;
            this.rdu_equalsToNumber.Text = "مساوی";
            this.rdu_equalsToNumber.UseVisualStyleBackColor = true;
            // 
            // rdu_moreThanNumber
            // 
            this.rdu_moreThanNumber.AutoSize = true;
            this.rdu_moreThanNumber.Location = new System.Drawing.Point(344, 6);
            this.rdu_moreThanNumber.Name = "rdu_moreThanNumber";
            this.rdu_moreThanNumber.Size = new System.Drawing.Size(61, 17);
            this.rdu_moreThanNumber.TabIndex = 2;
            this.rdu_moreThanNumber.Text = "بزرگتر از";
            this.rdu_moreThanNumber.UseVisualStyleBackColor = true;
            // 
            // rdu_lessThanNumber
            // 
            this.rdu_lessThanNumber.AutoSize = true;
            this.rdu_lessThanNumber.Location = new System.Drawing.Point(437, 6);
            this.rdu_lessThanNumber.Name = "rdu_lessThanNumber";
            this.rdu_lessThanNumber.Size = new System.Drawing.Size(67, 17);
            this.rdu_lessThanNumber.TabIndex = 1;
            this.rdu_lessThanNumber.Text = "کوچکتر از";
            this.rdu_lessThanNumber.UseVisualStyleBackColor = true;
            // 
            // num_toNumber
            // 
            this.num_toNumber.Location = new System.Drawing.Point(121, 46);
            this.num_toNumber.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.num_toNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_toNumber.Name = "num_toNumber";
            this.num_toNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_toNumber.Size = new System.Drawing.Size(121, 21);
            this.num_toNumber.TabIndex = 0;
            this.num_toNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnl_rangeNumber
            // 
            this.pnl_rangeNumber.Controls.Add(this.label2);
            this.pnl_rangeNumber.Controls.Add(this.num_fromNumber);
            this.pnl_rangeNumber.Controls.Add(this.label1);
            this.pnl_rangeNumber.Location = new System.Drawing.Point(248, 46);
            this.pnl_rangeNumber.Name = "pnl_rangeNumber";
            this.pnl_rangeNumber.Size = new System.Drawing.Size(318, 51);
            this.pnl_rangeNumber.TabIndex = 4;
            this.pnl_rangeNumber.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا شماره ی";
            // 
            // num_fromNumber
            // 
            this.num_fromNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_fromNumber.Location = new System.Drawing.Point(87, 2);
            this.num_fromNumber.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.num_fromNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_fromNumber.Name = "num_fromNumber";
            this.num_fromNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_fromNumber.Size = new System.Drawing.Size(127, 21);
            this.num_fromNumber.TabIndex = 1;
            this.num_fromNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "از شماره ی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "شماره ســند :";
            // 
            // pag_viaDocDate
            // 
            this.pag_viaDocDate.Controls.Add(this.pnl_rangeDate);
            this.pag_viaDocDate.Controls.Add(this.mTbx_toDate);
            this.pag_viaDocDate.Controls.Add(this.label6);
            this.pag_viaDocDate.Controls.Add(this.rdu_betweensDate);
            this.pag_viaDocDate.Controls.Add(this.rdu_equalsToDate);
            this.pag_viaDocDate.Controls.Add(this.rdu_moreThanDate);
            this.pag_viaDocDate.Controls.Add(this.rdu_lessThanDate);
            this.pag_viaDocDate.Location = new System.Drawing.Point(4, 22);
            this.pag_viaDocDate.Name = "pag_viaDocDate";
            this.pag_viaDocDate.Padding = new System.Windows.Forms.Padding(3);
            this.pag_viaDocDate.Size = new System.Drawing.Size(577, 134);
            this.pag_viaDocDate.TabIndex = 1;
            this.pag_viaDocDate.Text = "تاریخ ســند";
            this.pag_viaDocDate.UseVisualStyleBackColor = true;
            // 
            // pnl_rangeDate
            // 
            this.pnl_rangeDate.Controls.Add(this.mTbx_fromDate);
            this.pnl_rangeDate.Controls.Add(this.label3);
            this.pnl_rangeDate.Controls.Add(this.label4);
            this.pnl_rangeDate.Location = new System.Drawing.Point(324, 49);
            this.pnl_rangeDate.Name = "pnl_rangeDate";
            this.pnl_rangeDate.Size = new System.Drawing.Size(228, 51);
            this.pnl_rangeDate.TabIndex = 12;
            this.pnl_rangeDate.Visible = false;
            // 
            // mTbx_fromDate
            // 
            this.mTbx_fromDate.AllowPromptAsInput = false;
            this.mTbx_fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbx_fromDate.Culture = new System.Globalization.CultureInfo("");
            this.mTbx_fromDate.Location = new System.Drawing.Point(68, 2);
            this.mTbx_fromDate.Mask = "0000/00/00";
            this.mTbx_fromDate.Name = "mTbx_fromDate";
            this.mTbx_fromDate.PromptChar = ' ';
            this.mTbx_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_fromDate.Size = new System.Drawing.Size(95, 21);
            this.mTbx_fromDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تا تاریخ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "از تاریخ";
            // 
            // mTbx_toDate
            // 
            this.mTbx_toDate.Location = new System.Drawing.Point(205, 49);
            this.mTbx_toDate.Mask = "0000/00/00";
            this.mTbx_toDate.Name = "mTbx_toDate";
            this.mTbx_toDate.PromptChar = ' ';
            this.mTbx_toDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_toDate.Size = new System.Drawing.Size(105, 21);
            this.mTbx_toDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "تاریخ ســند :";
            // 
            // rdu_betweensDate
            // 
            this.rdu_betweensDate.AutoSize = true;
            this.rdu_betweensDate.Location = new System.Drawing.Point(120, 6);
            this.rdu_betweensDate.Name = "rdu_betweensDate";
            this.rdu_betweensDate.Size = new System.Drawing.Size(52, 17);
            this.rdu_betweensDate.TabIndex = 11;
            this.rdu_betweensDate.Text = "ما بین";
            this.rdu_betweensDate.UseVisualStyleBackColor = true;
            this.rdu_betweensDate.CheckedChanged += new System.EventHandler(this.rdu_betweensDate_CheckedChanged);
            // 
            // rdu_equalsToDate
            // 
            this.rdu_equalsToDate.AutoSize = true;
            this.rdu_equalsToDate.Checked = true;
            this.rdu_equalsToDate.Location = new System.Drawing.Point(204, 6);
            this.rdu_equalsToDate.Name = "rdu_equalsToDate";
            this.rdu_equalsToDate.Size = new System.Drawing.Size(61, 17);
            this.rdu_equalsToDate.TabIndex = 10;
            this.rdu_equalsToDate.TabStop = true;
            this.rdu_equalsToDate.Text = "مساوی";
            this.rdu_equalsToDate.UseVisualStyleBackColor = true;
            // 
            // rdu_moreThanDate
            // 
            this.rdu_moreThanDate.AutoSize = true;
            this.rdu_moreThanDate.Location = new System.Drawing.Point(293, 6);
            this.rdu_moreThanDate.Name = "rdu_moreThanDate";
            this.rdu_moreThanDate.Size = new System.Drawing.Size(61, 17);
            this.rdu_moreThanDate.TabIndex = 9;
            this.rdu_moreThanDate.Text = "بزرگتر از";
            this.rdu_moreThanDate.UseVisualStyleBackColor = true;
            // 
            // rdu_lessThanDate
            // 
            this.rdu_lessThanDate.AutoSize = true;
            this.rdu_lessThanDate.Location = new System.Drawing.Point(390, 6);
            this.rdu_lessThanDate.Name = "rdu_lessThanDate";
            this.rdu_lessThanDate.Size = new System.Drawing.Size(67, 17);
            this.rdu_lessThanDate.TabIndex = 8;
            this.rdu_lessThanDate.Text = "کوچکتر از";
            this.rdu_lessThanDate.UseVisualStyleBackColor = true;
            // 
            // pag_viaDocPrice
            // 
            this.pag_viaDocPrice.Controls.Add(this.tbx_toPrice);
            this.pag_viaDocPrice.Controls.Add(this.pnl_rangePrice);
            this.pag_viaDocPrice.Controls.Add(this.label10);
            this.pag_viaDocPrice.Controls.Add(this.rdu_betweensPrice);
            this.pag_viaDocPrice.Controls.Add(this.rdu_equalsToPrice);
            this.pag_viaDocPrice.Controls.Add(this.rdu_moreThanPrice);
            this.pag_viaDocPrice.Controls.Add(this.rdu_lessThanPrice);
            this.pag_viaDocPrice.Controls.Add(this.lbl_priceInChars);
            this.pag_viaDocPrice.Location = new System.Drawing.Point(4, 22);
            this.pag_viaDocPrice.Name = "pag_viaDocPrice";
            this.pag_viaDocPrice.Padding = new System.Windows.Forms.Padding(3);
            this.pag_viaDocPrice.Size = new System.Drawing.Size(577, 134);
            this.pag_viaDocPrice.TabIndex = 2;
            this.pag_viaDocPrice.Text = "مبلغ ســند";
            this.pag_viaDocPrice.UseVisualStyleBackColor = true;
            // 
            // tbx_toPrice
            // 
            this.tbx_toPrice.Location = new System.Drawing.Point(72, 41);
            this.tbx_toPrice.Name = "tbx_toPrice";
            this.tbx_toPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_toPrice.Size = new System.Drawing.Size(115, 21);
            this.tbx_toPrice.TabIndex = 3;
            this.tbx_toPrice.Text = "0";
            // 
            // pnl_rangePrice
            // 
            this.pnl_rangePrice.Controls.Add(this.tbx_fromPrice);
            this.pnl_rangePrice.Controls.Add(this.label8);
            this.pnl_rangePrice.Controls.Add(this.label9);
            this.pnl_rangePrice.Location = new System.Drawing.Point(193, 41);
            this.pnl_rangePrice.Name = "pnl_rangePrice";
            this.pnl_rangePrice.Size = new System.Drawing.Size(318, 51);
            this.pnl_rangePrice.TabIndex = 17;
            this.pnl_rangePrice.Visible = false;
            // 
            // tbx_fromPrice
            // 
            this.tbx_fromPrice.Location = new System.Drawing.Point(100, 3);
            this.tbx_fromPrice.Name = "tbx_fromPrice";
            this.tbx_fromPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_fromPrice.Size = new System.Drawing.Size(115, 21);
            this.tbx_fromPrice.TabIndex = 4;
            this.tbx_fromPrice.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "تا مبلغ :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "از مبلغ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "مبلغ ســند :";
            // 
            // rdu_betweensPrice
            // 
            this.rdu_betweensPrice.AutoSize = true;
            this.rdu_betweensPrice.Location = new System.Drawing.Point(120, 6);
            this.rdu_betweensPrice.Name = "rdu_betweensPrice";
            this.rdu_betweensPrice.Size = new System.Drawing.Size(52, 17);
            this.rdu_betweensPrice.TabIndex = 15;
            this.rdu_betweensPrice.Text = "ما بین";
            this.rdu_betweensPrice.UseVisualStyleBackColor = true;
            this.rdu_betweensPrice.CheckedChanged += new System.EventHandler(this.rdu_betweensPrice_CheckedChanged);
            // 
            // rdu_equalsToPrice
            // 
            this.rdu_equalsToPrice.AutoSize = true;
            this.rdu_equalsToPrice.Checked = true;
            this.rdu_equalsToPrice.Location = new System.Drawing.Point(204, 6);
            this.rdu_equalsToPrice.Name = "rdu_equalsToPrice";
            this.rdu_equalsToPrice.Size = new System.Drawing.Size(61, 17);
            this.rdu_equalsToPrice.TabIndex = 14;
            this.rdu_equalsToPrice.TabStop = true;
            this.rdu_equalsToPrice.Text = "مساوی";
            this.rdu_equalsToPrice.UseVisualStyleBackColor = true;
            // 
            // rdu_moreThanPrice
            // 
            this.rdu_moreThanPrice.AutoSize = true;
            this.rdu_moreThanPrice.Location = new System.Drawing.Point(293, 6);
            this.rdu_moreThanPrice.Name = "rdu_moreThanPrice";
            this.rdu_moreThanPrice.Size = new System.Drawing.Size(61, 17);
            this.rdu_moreThanPrice.TabIndex = 13;
            this.rdu_moreThanPrice.Text = "بزرگتر از";
            this.rdu_moreThanPrice.UseVisualStyleBackColor = true;
            // 
            // rdu_lessThanPrice
            // 
            this.rdu_lessThanPrice.AutoSize = true;
            this.rdu_lessThanPrice.Location = new System.Drawing.Point(390, 6);
            this.rdu_lessThanPrice.Name = "rdu_lessThanPrice";
            this.rdu_lessThanPrice.Size = new System.Drawing.Size(67, 17);
            this.rdu_lessThanPrice.TabIndex = 12;
            this.rdu_lessThanPrice.Text = "کوچکتر از";
            this.rdu_lessThanPrice.UseVisualStyleBackColor = true;
            // 
            // lbl_priceInChars
            // 
            this.lbl_priceInChars.AllowDrop = true;
            this.lbl_priceInChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_priceInChars.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_priceInChars.Location = new System.Drawing.Point(12, 100);
            this.lbl_priceInChars.Name = "lbl_priceInChars";
            this.lbl_priceInChars.Size = new System.Drawing.Size(559, 23);
            this.lbl_priceInChars.TabIndex = 2;
            this.lbl_priceInChars.Text = "صفر ریال";
            // 
            // pag_viaDocComment
            // 
            this.pag_viaDocComment.Controls.Add(this.tbx_commend);
            this.pag_viaDocComment.Controls.Add(this.label7);
            this.pag_viaDocComment.Location = new System.Drawing.Point(4, 22);
            this.pag_viaDocComment.Name = "pag_viaDocComment";
            this.pag_viaDocComment.Padding = new System.Windows.Forms.Padding(3);
            this.pag_viaDocComment.Size = new System.Drawing.Size(577, 134);
            this.pag_viaDocComment.TabIndex = 3;
            this.pag_viaDocComment.Text = "تــوضیحــــات";
            this.pag_viaDocComment.UseVisualStyleBackColor = true;
            // 
            // tbx_commend
            // 
            this.tbx_commend.Location = new System.Drawing.Point(175, 60);
            this.tbx_commend.Name = "tbx_commend";
            this.tbx_commend.Size = new System.Drawing.Size(231, 21);
            this.tbx_commend.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "تــوضیــحــــات:";
            // 
            // frm_accDocExplorer
            // 
            this.ClientSize = new System.Drawing.Size(599, 412);
            this.Controls.Add(this.btn_printAll);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_accDocExplorer";
            this.Text = "  مرور ســـندها";
            this.Load += new System.EventHandler(this.frm_accDocExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pag_viaDocNumber.ResumeLayout(false);
            this.pag_viaDocNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_toNumber)).EndInit();
            this.pnl_rangeNumber.ResumeLayout(false);
            this.pnl_rangeNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fromNumber)).EndInit();
            this.pag_viaDocDate.ResumeLayout(false);
            this.pag_viaDocDate.PerformLayout();
            this.pnl_rangeDate.ResumeLayout(false);
            this.pnl_rangeDate.PerformLayout();
            this.pag_viaDocPrice.ResumeLayout(false);
            this.pag_viaDocPrice.PerformLayout();
            this.pnl_rangePrice.ResumeLayout(false);
            this.pnl_rangePrice.PerformLayout();
            this.pag_viaDocComment.ResumeLayout(false);
            this.pag_viaDocComment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_printAll;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pag_viaDocNumber;
        private System.Windows.Forms.RadioButton rdu_allAccDocs;
        private System.Windows.Forms.RadioButton rdu_betweensNumber;
        private System.Windows.Forms.RadioButton rdu_equalsToNumber;
        private System.Windows.Forms.RadioButton rdu_moreThanNumber;
        private System.Windows.Forms.RadioButton rdu_lessThanNumber;
        private System.Windows.Forms.NumericUpDown num_toNumber;
        private System.Windows.Forms.Panel pnl_rangeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_fromNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage pag_viaDocDate;
        private System.Windows.Forms.Panel pnl_rangeDate;
        public System.Windows.Forms.MaskedTextBox mTbx_fromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mTbx_toDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdu_betweensDate;
        private System.Windows.Forms.RadioButton rdu_equalsToDate;
        private System.Windows.Forms.RadioButton rdu_moreThanDate;
        private System.Windows.Forms.RadioButton rdu_lessThanDate;
        private System.Windows.Forms.TabPage pag_viaDocPrice;
        private System.Windows.Forms.TextBox tbx_toPrice;
        private System.Windows.Forms.Panel pnl_rangePrice;
        private System.Windows.Forms.TextBox tbx_fromPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdu_betweensPrice;
        private System.Windows.Forms.RadioButton rdu_equalsToPrice;
        private System.Windows.Forms.RadioButton rdu_moreThanPrice;
        private System.Windows.Forms.RadioButton rdu_lessThanPrice;
        private System.Windows.Forms.Label lbl_priceInChars;
        private System.Windows.Forms.TabPage pag_viaDocComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_commend;
    }
}
