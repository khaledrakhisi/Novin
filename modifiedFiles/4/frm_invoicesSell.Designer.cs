namespace Novin
{
    partial class frm_invoicesSell
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
            this.grp_header = new System.Windows.Forms.GroupBox();
            this.cbx_persons = new System.Windows.Forms.ComboBox();
            this.bs_persons = new System.Windows.Forms.BindingSource(this.components);
            this.ds_persons = new Novin.ds_persons();
            this.tbx_personID = new System.Windows.Forms.TextBox();
            this.mTbx_date = new System.Windows.Forms.MaskedTextBox();
            this.bs_invoicesSell = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sellInvoices = new Novin.ds_sellInvoices();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_invoiceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_details = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.bs_viewItemsSell = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_invoiceTotalCount = new System.Windows.Forms.TextBox();
            this.tbx_invoiceTotalPrice = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_addOrRemoveRows = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemBuy_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSellcommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSellunitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSellretailCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSellretailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_footer = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbl_personsTableAdapter = new Novin.ds_personsTableAdapters.tbl_personsTableAdapter();
            this.tbl_invoicesSellTableAdapter = new Novin.ds_sellInvoicesTableAdapters.tbl_invoicesSellTableAdapter();
            this.viw_itemsSellTableAdapter = new Novin.ds_sellInvoicesTableAdapters.viw_itemsSellTableAdapter();
            this.bs_itemsSell = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_itemsSellTableAdapter = new Novin.ds_sellInvoicesTableAdapters.tbl_itemsSellTableAdapter();
            this.grp_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_invoicesSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sellInvoices)).BeginInit();
            this.grp_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viewItemsSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsSell)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_header
            // 
            this.grp_header.Controls.Add(this.cbx_persons);
            this.grp_header.Controls.Add(this.tbx_personID);
            this.grp_header.Controls.Add(this.mTbx_date);
            this.grp_header.Controls.Add(this.tbx_phone);
            this.grp_header.Controls.Add(this.label6);
            this.grp_header.Controls.Add(this.tbx_address);
            this.grp_header.Controls.Add(this.label5);
            this.grp_header.Controls.Add(this.tbx_invoiceID);
            this.grp_header.Controls.Add(this.label4);
            this.grp_header.Controls.Add(this.label3);
            this.grp_header.Controls.Add(this.label2);
            this.grp_header.Controls.Add(this.label1);
            this.grp_header.Location = new System.Drawing.Point(5, 6);
            this.grp_header.Name = "grp_header";
            this.grp_header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_header.Size = new System.Drawing.Size(804, 84);
            this.grp_header.TabIndex = 0;
            this.grp_header.TabStop = false;
            this.grp_header.Text = "مشخصات خريدار :";
            // 
            // cbx_persons
            // 
            this.cbx_persons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_persons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_persons.DataSource = this.bs_persons;
            this.cbx_persons.DisplayMember = "person_familyAndName";
            this.cbx_persons.FormattingEnabled = true;
            this.cbx_persons.Location = new System.Drawing.Point(483, 20);
            this.cbx_persons.Name = "cbx_persons";
            this.cbx_persons.Size = new System.Drawing.Size(196, 21);
            this.cbx_persons.TabIndex = 0;
            this.cbx_persons.ValueMember = "person_id";
            // 
            // bs_persons
            // 
            this.bs_persons.DataMember = "tbl_persons";
            this.bs_persons.DataSource = this.ds_persons;
            // 
            // ds_persons
            // 
            this.ds_persons.DataSetName = "ds_persons";
            this.ds_persons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbx_personID
            // 
            this.tbx_personID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_id", true));
            this.tbx_personID.Location = new System.Drawing.Point(319, 20);
            this.tbx_personID.Name = "tbx_personID";
            this.tbx_personID.ReadOnly = true;
            this.tbx_personID.Size = new System.Drawing.Size(78, 21);
            this.tbx_personID.TabIndex = 1;
            // 
            // mTbx_date
            // 
            this.mTbx_date.AllowDrop = true;
            this.mTbx_date.AllowPromptAsInput = false;
            this.mTbx_date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_invoicesSell, "invoiceSell_date", true));
            this.mTbx_date.Location = new System.Drawing.Point(7, 52);
            this.mTbx_date.Mask = "0000/00/00";
            this.mTbx_date.Name = "mTbx_date";
            this.mTbx_date.PromptChar = ' ';
            this.mTbx_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_date.Size = new System.Drawing.Size(69, 21);
            this.mTbx_date.TabIndex = 5;
            // 
            // bs_invoicesSell
            // 
            this.bs_invoicesSell.DataMember = "tbl_invoicesSell";
            this.bs_invoicesSell.DataSource = this.ds_sellInvoices;
            // 
            // ds_sellInvoices
            // 
            this.ds_sellInvoices.DataSetName = "ds_sellInvoices";
            this.ds_sellInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbx_phone
            // 
            this.tbx_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_phone", true));
            this.tbx_phone.Location = new System.Drawing.Point(163, 20);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.Size = new System.Drawing.Size(100, 21);
            this.tbx_phone.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 55);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "تاريخ :";
            // 
            // tbx_address
            // 
            this.tbx_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_address1", true));
            this.tbx_address.Location = new System.Drawing.Point(163, 52);
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(516, 21);
            this.tbx_address.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 55);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "آدرس :";
            // 
            // tbx_invoiceID
            // 
            this.tbx_invoiceID.Location = new System.Drawing.Point(6, 20);
            this.tbx_invoiceID.Name = "tbx_invoiceID";
            this.tbx_invoiceID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_invoiceID.Size = new System.Drawing.Size(72, 21);
            this.tbx_invoiceID.TabIndex = 3;
            this.tbx_invoiceID.TextChanged += new System.EventHandler(this.tbx_invoiceID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 23);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "شماره فاكتور :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "تلفن :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "كد شخص :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام و نام خانوادگي :";
            // 
            // grp_details
            // 
            this.grp_details.Controls.Add(this.numericUpDown3);
            this.grp_details.Controls.Add(this.label10);
            this.grp_details.Controls.Add(this.tbx_invoiceTotalCount);
            this.grp_details.Controls.Add(this.tbx_invoiceTotalPrice);
            this.grp_details.Controls.Add(this.numericUpDown2);
            this.grp_details.Controls.Add(this.label9);
            this.grp_details.Controls.Add(this.numericUpDown1);
            this.grp_details.Controls.Add(this.label8);
            this.grp_details.Controls.Add(this.btn_addOrRemoveRows);
            this.grp_details.Controls.Add(this.btn_Sum);
            this.grp_details.Controls.Add(this.label7);
            this.grp_details.Controls.Add(this.dataGridView1);
            this.grp_details.Location = new System.Drawing.Point(5, 99);
            this.grp_details.Name = "grp_details";
            this.grp_details.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_details.Size = new System.Drawing.Size(804, 294);
            this.grp_details.TabIndex = 1;
            this.grp_details.TabStop = false;
            this.grp_details.Text = "اقلام فاكتور :";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_viewItemsSell, "itemSell_visitorPercent", true));
            this.numericUpDown3.Location = new System.Drawing.Point(35, 16);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown3.TabIndex = 27;
            // 
            // bs_viewItemsSell
            // 
            this.bs_viewItemsSell.DataMember = "viw_itemsSell";
            this.bs_viewItemsSell.DataSource = this.ds_sellInvoices;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 22);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "پورسانت ويزيتور";
            // 
            // tbx_invoiceTotalCount
            // 
            this.tbx_invoiceTotalCount.Location = new System.Drawing.Point(316, 261);
            this.tbx_invoiceTotalCount.Name = "tbx_invoiceTotalCount";
            this.tbx_invoiceTotalCount.ReadOnly = true;
            this.tbx_invoiceTotalCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_invoiceTotalCount.Size = new System.Drawing.Size(46, 21);
            this.tbx_invoiceTotalCount.TabIndex = 5;
            // 
            // tbx_invoiceTotalPrice
            // 
            this.tbx_invoiceTotalPrice.Location = new System.Drawing.Point(37, 261);
            this.tbx_invoiceTotalPrice.Name = "tbx_invoiceTotalPrice";
            this.tbx_invoiceTotalPrice.ReadOnly = true;
            this.tbx_invoiceTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_invoiceTotalPrice.Size = new System.Drawing.Size(90, 21);
            this.tbx_invoiceTotalPrice.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_viewItemsSell, "itemSell_taxPercent", true));
            this.numericUpDown2.Location = new System.Drawing.Point(177, 17);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 23);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "درصد مالیات کالا :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_viewItemsSell, "itemSell_discountPercent", true));
            this.numericUpDown1.Location = new System.Drawing.Point(321, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 22);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "درصد تخفیف کالا :";
            // 
            // btn_addOrRemoveRows
            // 
            this.btn_addOrRemoveRows.Location = new System.Drawing.Point(615, 14);
            this.btn_addOrRemoveRows.Name = "btn_addOrRemoveRows";
            this.btn_addOrRemoveRows.Size = new System.Drawing.Size(165, 23);
            this.btn_addOrRemoveRows.TabIndex = 0;
            this.btn_addOrRemoveRows.Text = "حذف/اضـــافه کــالا";
            this.btn_addOrRemoveRows.UseVisualStyleBackColor = true;
            this.btn_addOrRemoveRows.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Sum
            // 
            this.btn_Sum.Location = new System.Drawing.Point(703, 263);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(77, 25);
            this.btn_Sum.TabIndex = 4;
            this.btn_Sum.Text = "جمع";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ريال";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemBuy_row,
            this.dataGridViewTextBoxColumn1,
            this.itemSellcommentDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.itemSellunitCountDataGridViewTextBoxColumn,
            this.itemSellretailCountDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.itemSellretailPriceDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.bs_viewItemsSell;
            this.dataGridView1.Location = new System.Drawing.Point(11, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(787, 214);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // itemBuy_row
            // 
            this.itemBuy_row.DataPropertyName = "itemBuy_row";
            this.itemBuy_row.HeaderText = "ردیف";
            this.itemBuy_row.Name = "itemBuy_row";
            this.itemBuy_row.ReadOnly = true;
            this.itemBuy_row.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "object_title";
            this.dataGridViewTextBoxColumn1.HeaderText = "شــــرح كالا";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemSellcommentDataGridViewTextBoxColumn
            // 
            this.itemSellcommentDataGridViewTextBoxColumn.DataPropertyName = "itemSell_comment";
            this.itemSellcommentDataGridViewTextBoxColumn.HeaderText = "تــــوضیحات";
            this.itemSellcommentDataGridViewTextBoxColumn.Name = "itemSellcommentDataGridViewTextBoxColumn";
            this.itemSellcommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "objectUnit_title";
            this.dataGridViewTextBoxColumn2.HeaderText = "واحد كالا";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // itemSellunitCountDataGridViewTextBoxColumn
            // 
            this.itemSellunitCountDataGridViewTextBoxColumn.DataPropertyName = "itemSell_unitCount";
            this.itemSellunitCountDataGridViewTextBoxColumn.HeaderText = "تعداد واحد";
            this.itemSellunitCountDataGridViewTextBoxColumn.Name = "itemSellunitCountDataGridViewTextBoxColumn";
            this.itemSellunitCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemSellunitCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemSellretailCountDataGridViewTextBoxColumn
            // 
            this.itemSellretailCountDataGridViewTextBoxColumn.DataPropertyName = "itemSell_retailCount";
            this.itemSellretailCountDataGridViewTextBoxColumn.HeaderText = "تعداد جزء";
            this.itemSellretailCountDataGridViewTextBoxColumn.Name = "itemSellretailCountDataGridViewTextBoxColumn";
            this.itemSellretailCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemSellretailCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "object_retailInUnit";
            this.dataGridViewTextBoxColumn3.HeaderText = "جزء در واحد";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // itemSellretailPriceDataGridViewTextBoxColumn
            // 
            this.itemSellretailPriceDataGridViewTextBoxColumn.DataPropertyName = "itemSell_retailPrice";
            this.itemSellretailPriceDataGridViewTextBoxColumn.HeaderText = "قيمت جزء";
            this.itemSellretailPriceDataGridViewTextBoxColumn.Name = "itemSellretailPriceDataGridViewTextBoxColumn";
            this.itemSellretailPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "objectTotalCount";
            this.dataGridViewTextBoxColumn4.HeaderText = "تعداد كل";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "objectTotalPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "قيمت كل";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // grp_footer
            // 
            this.grp_footer.Controls.Add(this.btn_close);
            this.grp_footer.Controls.Add(this.btn_delete);
            this.grp_footer.Controls.Add(this.btn_new);
            this.grp_footer.Controls.Add(this.btn_save);
            this.grp_footer.Location = new System.Drawing.Point(5, 399);
            this.grp_footer.Name = "grp_footer";
            this.grp_footer.Size = new System.Drawing.Size(804, 45);
            this.grp_footer.TabIndex = 2;
            this.grp_footer.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(484, 14);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "خروج";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(563, 14);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف فاكتور";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.Location = new System.Drawing.Point(721, 14);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "فاكتور جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(642, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "ثبت فاكتور";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbl_personsTableAdapter
            // 
            this.tbl_personsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_invoicesSellTableAdapter
            // 
            this.tbl_invoicesSellTableAdapter.ClearBeforeFill = true;
            // 
            // viw_itemsSellTableAdapter
            // 
            this.viw_itemsSellTableAdapter.ClearBeforeFill = true;
            // 
            // bs_itemsSell
            // 
            this.bs_itemsSell.DataMember = "tbl_itemsSell";
            this.bs_itemsSell.DataSource = this.ds_sellInvoices;
            // 
            // tbl_itemsSellTableAdapter
            // 
            this.tbl_itemsSellTableAdapter.ClearBeforeFill = true;
            // 
            // frm_invoicesSell
            // 
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(812, 448);
            this.Controls.Add(this.grp_header);
            this.Controls.Add(this.grp_footer);
            this.Controls.Add(this.grp_details);
            this.Name = "frm_invoicesSell";
            this.Text = "فاكتور فـــــروش";
            this.Load += new System.EventHandler(this.frm_invoicesSell_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_invoicesSell_FormClosing);
            this.grp_header.ResumeLayout(false);
            this.grp_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_invoicesSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sellInvoices)).EndInit();
            this.grp_details.ResumeLayout(false);
            this.grp_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viewItemsSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsSell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_header;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_invoiceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_details;
        private System.Windows.Forms.DataGridView dataGridView1;        
        private System.Windows.Forms.ComboBox cbx_persons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuycountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuyonePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itembuytotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuycommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.GroupBox grp_footer;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectUnittitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuyunitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuyretailCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectTotalCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectretailInUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectretailSellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectdiscountPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuytaxPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.Button btn_addOrRemoveRows;
        private System.Windows.Forms.MaskedTextBox mTbx_date;
        private System.Windows.Forms.TextBox tbx_personID;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_invoiceTotalPrice;
        private System.Windows.Forms.TextBox tbx_invoiceTotalCount;
        private ds_persons ds_persons;
        private System.Windows.Forms.BindingSource bs_persons;
        private Novin.ds_personsTableAdapters.tbl_personsTableAdapter tbl_personsTableAdapter;
        private ds_sellInvoices ds_sellInvoices;
        private System.Windows.Forms.BindingSource bs_invoicesSell;
        private Novin.ds_sellInvoicesTableAdapters.tbl_invoicesSellTableAdapter tbl_invoicesSellTableAdapter;
        private System.Windows.Forms.BindingSource bs_viewItemsSell;
        private Novin.ds_sellInvoicesTableAdapters.viw_itemsSellTableAdapter viw_itemsSellTableAdapter;
        private System.Windows.Forms.BindingSource bs_itemsSell;
        private Novin.ds_sellInvoicesTableAdapters.tbl_itemsSellTableAdapter tbl_itemsSellTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuy_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellcommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellunitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellretailCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellretailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label10;

    }
}
