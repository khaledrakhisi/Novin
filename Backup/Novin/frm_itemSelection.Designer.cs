namespace Novin
{
    partial class frm_itemSelection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dgw_invoiceBuy = new System.Windows.Forms.DataGridView();
            this.itemBuyunitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBuyretailCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBuyretailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBuy_discountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBuytaxPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBuycommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_itemsBuy = new System.Windows.Forms.BindingSource(this.components);
            this.ds_buyInvoices = new Novin.ds_buyInvoices();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgw_invoiceSell = new System.Windows.Forms.DataGridView();
            this.itemSellunitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSellretailCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSellretailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSelldiscountPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSellvisitorPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSelltransportPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSelltaxPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSellcommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_itemsSell = new System.Windows.Forms.BindingSource(this.components);
            this.ds_sellInvoices = new Novin.ds_sellInvoices();
            this.dgw_itemsWasted = new System.Windows.Forms.DataGridView();
            this.itemWastedunitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWastedretailCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWastedretailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWastedcommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_itemsWasted = new System.Windows.Forms.BindingSource(this.components);
            this.ds_wastedInvoices = new Novin.ds_wastedInvoices();
            this.tbx_objectTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_objects = new System.Windows.Forms.DataGridView();
            this.objecttitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectretailInUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectentityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectretailBuyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectretailSellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object_sellPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object_sellPrice3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_objects = new System.Windows.Forms.BindingSource(this.components);
            this.ds_objectGrouping = new Novin.ds_objectGrouping();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_unitTitle = new System.Windows.Forms.TextBox();
            this.tbx_retailInUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_objectsForm = new System.Windows.Forms.Button();
            this.cbx_allPrice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_showObjectGrouping = new System.Windows.Forms.Button();
            this.pnl_groupingSet = new System.Windows.Forms.Panel();
            this.tbx_searchObjects = new System.Windows.Forms.TextBox();
            this.pnl_objectSet = new System.Windows.Forms.Panel();
            this.chk_searchWithin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bs_masterGroups = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_masterGroupsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_masterGroupsTableAdapter();
            this.tbl_slaveGroupsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_slaveGroupsTableAdapter();
            this.bs_slaveGroups = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_objectsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter();
            this.tbl_itemsBuyTableAdapter = new Novin.ds_buyInvoicesTableAdapters.tbl_itemsBuyTableAdapter();
            this.tbl_itemsSellTableAdapter = new Novin.ds_sellInvoicesTableAdapters.tbl_itemsSellTableAdapter();
            this.tbl_itemsWastedTableAdapter = new Novin.ds_wastedInvoicesTableAdapters.tbl_itemsWastedTableAdapter();
            this.bs_objectUnits = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_objectUnitsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_objectUnitsTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_invoiceBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_buyInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_invoiceSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sellInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_itemsWasted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsWasted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_wastedInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_objects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).BeginInit();
            this.pnl_groupingSet.SuspendLayout();
            this.pnl_objectSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_masterGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_slaveGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objectUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView1.Location = new System.Drawing.Point(26, 34);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(233, 173);
            this.treeView1.TabIndex = 1;
            this.treeView1.Enter += new System.EventHandler(this.treeView1_Enter);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Leave += new System.EventHandler(this.treeView1_Leave);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // dgw_invoiceBuy
            // 
            this.dgw_invoiceBuy.AllowUserToAddRows = false;
            this.dgw_invoiceBuy.AllowUserToDeleteRows = false;
            this.dgw_invoiceBuy.AllowUserToResizeRows = false;
            this.dgw_invoiceBuy.AutoGenerateColumns = false;
            this.dgw_invoiceBuy.BackgroundColor = System.Drawing.Color.Silver;
            this.dgw_invoiceBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_invoiceBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemBuyunitCountDataGridViewTextBoxColumn,
            this.itemBuyretailCountDataGridViewTextBoxColumn,
            this.itemBuyretailPriceDataGridViewTextBoxColumn,
            this.itemBuy_discountPercent,
            this.itemBuytaxPercentDataGridViewTextBoxColumn,
            this.itemBuycommentDataGridViewTextBoxColumn});
            this.dgw_invoiceBuy.DataSource = this.bs_itemsBuy;
            this.dgw_invoiceBuy.Location = new System.Drawing.Point(12, 271);
            this.dgw_invoiceBuy.Name = "dgw_invoiceBuy";
            this.dgw_invoiceBuy.Size = new System.Drawing.Size(643, 175);
            this.dgw_invoiceBuy.TabIndex = 29;
            this.dgw_invoiceBuy.Visible = false;
            this.dgw_invoiceBuy.Enter += new System.EventHandler(this.dgw_invoiceBuy_Enter);
            this.dgw_invoiceBuy.Leave += new System.EventHandler(this.dgw_invoiceBuy_Leave);
            // 
            // itemBuyunitCountDataGridViewTextBoxColumn
            // 
            this.itemBuyunitCountDataGridViewTextBoxColumn.DataPropertyName = "itemBuy_unitCount";
            this.itemBuyunitCountDataGridViewTextBoxColumn.HeaderText = "تعداد واحد";
            this.itemBuyunitCountDataGridViewTextBoxColumn.Name = "itemBuyunitCountDataGridViewTextBoxColumn";
            this.itemBuyunitCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemBuyretailCountDataGridViewTextBoxColumn
            // 
            this.itemBuyretailCountDataGridViewTextBoxColumn.DataPropertyName = "itemBuy_retailCount";
            this.itemBuyretailCountDataGridViewTextBoxColumn.HeaderText = "تعداد جزء";
            this.itemBuyretailCountDataGridViewTextBoxColumn.Name = "itemBuyretailCountDataGridViewTextBoxColumn";
            this.itemBuyretailCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemBuyretailPriceDataGridViewTextBoxColumn
            // 
            this.itemBuyretailPriceDataGridViewTextBoxColumn.DataPropertyName = "itemBuy_retailPrice";
            this.itemBuyretailPriceDataGridViewTextBoxColumn.HeaderText = "قیمت جزء";
            this.itemBuyretailPriceDataGridViewTextBoxColumn.Name = "itemBuyretailPriceDataGridViewTextBoxColumn";
            // 
            // itemBuy_discountPercent
            // 
            this.itemBuy_discountPercent.DataPropertyName = "itemBuy_discountPercent";
            this.itemBuy_discountPercent.HeaderText = "درصد تخفیف";
            this.itemBuy_discountPercent.Name = "itemBuy_discountPercent";
            this.itemBuy_discountPercent.Width = 50;
            // 
            // itemBuytaxPercentDataGridViewTextBoxColumn
            // 
            this.itemBuytaxPercentDataGridViewTextBoxColumn.DataPropertyName = "itemBuy_taxPercent";
            this.itemBuytaxPercentDataGridViewTextBoxColumn.HeaderText = "درصد مالیات";
            this.itemBuytaxPercentDataGridViewTextBoxColumn.Name = "itemBuytaxPercentDataGridViewTextBoxColumn";
            this.itemBuytaxPercentDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemBuycommentDataGridViewTextBoxColumn
            // 
            this.itemBuycommentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemBuycommentDataGridViewTextBoxColumn.DataPropertyName = "itemBuy_comment";
            this.itemBuycommentDataGridViewTextBoxColumn.HeaderText = "توضیحات کالا";
            this.itemBuycommentDataGridViewTextBoxColumn.Name = "itemBuycommentDataGridViewTextBoxColumn";
            // 
            // bs_itemsBuy
            // 
            this.bs_itemsBuy.DataMember = "tbl_itemsBuy";
            this.bs_itemsBuy.DataSource = this.ds_buyInvoices;
            this.bs_itemsBuy.CurrentChanged += new System.EventHandler(this.bs_itemsBuy_CurrentChanged);
            this.bs_itemsBuy.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bs_itemsBuy_ListChanged);
            // 
            // ds_buyInvoices
            // 
            this.ds_buyInvoices.DataSetName = "ds_buyInvoices";
            this.ds_buyInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(479, 452);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "تــــائید (Ctrl+Enter)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(398, 452);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "لغـــــو (Esc)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(21, 452);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(126, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "حـــذف سطر (Ctrl+Del)";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgw_invoiceSell
            // 
            this.dgw_invoiceSell.AllowUserToAddRows = false;
            this.dgw_invoiceSell.AllowUserToDeleteRows = false;
            this.dgw_invoiceSell.AllowUserToResizeRows = false;
            this.dgw_invoiceSell.AutoGenerateColumns = false;
            this.dgw_invoiceSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_invoiceSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemSellunitCountDataGridViewTextBoxColumn,
            this.itemSellretailCountDataGridViewTextBoxColumn,
            this.itemSellretailPriceDataGridViewTextBoxColumn,
            this.itemSelldiscountPercentDataGridViewTextBoxColumn,
            this.itemSellvisitorPercentDataGridViewTextBoxColumn,
            this.itemSelltransportPriceDataGridViewTextBoxColumn,
            this.itemSelltaxPercentDataGridViewTextBoxColumn,
            this.itemSellcommentDataGridViewTextBoxColumn});
            this.dgw_invoiceSell.DataSource = this.bs_itemsSell;
            this.dgw_invoiceSell.Location = new System.Drawing.Point(12, 271);
            this.dgw_invoiceSell.Name = "dgw_invoiceSell";
            this.dgw_invoiceSell.Size = new System.Drawing.Size(643, 175);
            this.dgw_invoiceSell.TabIndex = 52;
            this.dgw_invoiceSell.Visible = false;
            this.dgw_invoiceSell.Enter += new System.EventHandler(this.dgw_invoiceSell_Enter);
            this.dgw_invoiceSell.Leave += new System.EventHandler(this.dgw_invoiceSell_Leave);
            this.dgw_invoiceSell.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_invoiceSell_CellEndEdit);
            // 
            // itemSellunitCountDataGridViewTextBoxColumn
            // 
            this.itemSellunitCountDataGridViewTextBoxColumn.DataPropertyName = "itemSell_unitCount";
            this.itemSellunitCountDataGridViewTextBoxColumn.HeaderText = "تعداد واحد";
            this.itemSellunitCountDataGridViewTextBoxColumn.Name = "itemSellunitCountDataGridViewTextBoxColumn";
            this.itemSellunitCountDataGridViewTextBoxColumn.Width = 40;
            // 
            // itemSellretailCountDataGridViewTextBoxColumn
            // 
            this.itemSellretailCountDataGridViewTextBoxColumn.DataPropertyName = "itemSell_retailCount";
            this.itemSellretailCountDataGridViewTextBoxColumn.HeaderText = "تعداد جزء";
            this.itemSellretailCountDataGridViewTextBoxColumn.Name = "itemSellretailCountDataGridViewTextBoxColumn";
            this.itemSellretailCountDataGridViewTextBoxColumn.Width = 40;
            // 
            // itemSellretailPriceDataGridViewTextBoxColumn
            // 
            this.itemSellretailPriceDataGridViewTextBoxColumn.DataPropertyName = "itemSell_retailPrice";
            this.itemSellretailPriceDataGridViewTextBoxColumn.HeaderText = "قيمت جزء";
            this.itemSellretailPriceDataGridViewTextBoxColumn.Name = "itemSellretailPriceDataGridViewTextBoxColumn";
            this.itemSellretailPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // itemSelldiscountPercentDataGridViewTextBoxColumn
            // 
            this.itemSelldiscountPercentDataGridViewTextBoxColumn.DataPropertyName = "itemSell_discountPercent";
            this.itemSelldiscountPercentDataGridViewTextBoxColumn.HeaderText = "درصد تخفيف";
            this.itemSelldiscountPercentDataGridViewTextBoxColumn.Name = "itemSelldiscountPercentDataGridViewTextBoxColumn";
            this.itemSelldiscountPercentDataGridViewTextBoxColumn.Width = 40;
            // 
            // itemSellvisitorPercentDataGridViewTextBoxColumn
            // 
            this.itemSellvisitorPercentDataGridViewTextBoxColumn.DataPropertyName = "itemSell_visitorPercent";
            this.itemSellvisitorPercentDataGridViewTextBoxColumn.HeaderText = "درصد بازارياب";
            this.itemSellvisitorPercentDataGridViewTextBoxColumn.Name = "itemSellvisitorPercentDataGridViewTextBoxColumn";
            this.itemSellvisitorPercentDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemSelltransportPriceDataGridViewTextBoxColumn
            // 
            this.itemSelltransportPriceDataGridViewTextBoxColumn.DataPropertyName = "itemSell_transportPrice";
            this.itemSelltransportPriceDataGridViewTextBoxColumn.HeaderText = "هزينه باربري";
            this.itemSelltransportPriceDataGridViewTextBoxColumn.Name = "itemSelltransportPriceDataGridViewTextBoxColumn";
            this.itemSelltransportPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // itemSelltaxPercentDataGridViewTextBoxColumn
            // 
            this.itemSelltaxPercentDataGridViewTextBoxColumn.DataPropertyName = "itemSell_taxPercent";
            this.itemSelltaxPercentDataGridViewTextBoxColumn.HeaderText = "درصد ماليات";
            this.itemSelltaxPercentDataGridViewTextBoxColumn.Name = "itemSelltaxPercentDataGridViewTextBoxColumn";
            this.itemSelltaxPercentDataGridViewTextBoxColumn.Width = 40;
            // 
            // itemSellcommentDataGridViewTextBoxColumn
            // 
            this.itemSellcommentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemSellcommentDataGridViewTextBoxColumn.DataPropertyName = "itemSell_comment";
            this.itemSellcommentDataGridViewTextBoxColumn.HeaderText = "توضيحات";
            this.itemSellcommentDataGridViewTextBoxColumn.Name = "itemSellcommentDataGridViewTextBoxColumn";
            // 
            // bs_itemsSell
            // 
            this.bs_itemsSell.DataMember = "tbl_itemsSell";
            this.bs_itemsSell.DataSource = this.ds_sellInvoices;
            this.bs_itemsSell.CurrentChanged += new System.EventHandler(this.bs_itemsSell_CurrentChanged);
            this.bs_itemsSell.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bs_itemsSell_ListChanged);
            // 
            // ds_sellInvoices
            // 
            this.ds_sellInvoices.DataSetName = "ds_sellInvoices";
            this.ds_sellInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgw_itemsWasted
            // 
            this.dgw_itemsWasted.AllowUserToAddRows = false;
            this.dgw_itemsWasted.AllowUserToDeleteRows = false;
            this.dgw_itemsWasted.AllowUserToResizeRows = false;
            this.dgw_itemsWasted.AutoGenerateColumns = false;
            this.dgw_itemsWasted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_itemsWasted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemWastedunitCountDataGridViewTextBoxColumn,
            this.itemWastedretailCountDataGridViewTextBoxColumn,
            this.itemWastedretailPriceDataGridViewTextBoxColumn,
            this.itemWastedcommentDataGridViewTextBoxColumn});
            this.dgw_itemsWasted.DataSource = this.bs_itemsWasted;
            this.dgw_itemsWasted.Location = new System.Drawing.Point(12, 271);
            this.dgw_itemsWasted.Name = "dgw_itemsWasted";
            this.dgw_itemsWasted.Size = new System.Drawing.Size(643, 175);
            this.dgw_itemsWasted.TabIndex = 5;
            this.dgw_itemsWasted.Visible = false;
            this.dgw_itemsWasted.Enter += new System.EventHandler(this.dgw_itemsWasted_Enter);
            this.dgw_itemsWasted.Leave += new System.EventHandler(this.dgw_itemsWasted_Leave);
            this.dgw_itemsWasted.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgw_itemsWasted_KeyDown);
            // 
            // itemWastedunitCountDataGridViewTextBoxColumn
            // 
            this.itemWastedunitCountDataGridViewTextBoxColumn.DataPropertyName = "itemWasted_unitCount";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.itemWastedunitCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.itemWastedunitCountDataGridViewTextBoxColumn.HeaderText = "تعداد کل";
            this.itemWastedunitCountDataGridViewTextBoxColumn.Name = "itemWastedunitCountDataGridViewTextBoxColumn";
            this.itemWastedunitCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemWastedretailCountDataGridViewTextBoxColumn
            // 
            this.itemWastedretailCountDataGridViewTextBoxColumn.DataPropertyName = "itemWasted_retailCount";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.itemWastedretailCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.itemWastedretailCountDataGridViewTextBoxColumn.HeaderText = "تعداد جزء";
            this.itemWastedretailCountDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.itemWastedretailCountDataGridViewTextBoxColumn.Name = "itemWastedretailCountDataGridViewTextBoxColumn";
            this.itemWastedretailCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemWastedretailPriceDataGridViewTextBoxColumn
            // 
            this.itemWastedretailPriceDataGridViewTextBoxColumn.DataPropertyName = "itemWasted_retailPrice";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.itemWastedretailPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.itemWastedretailPriceDataGridViewTextBoxColumn.HeaderText = "قیمت جزء";
            this.itemWastedretailPriceDataGridViewTextBoxColumn.Name = "itemWastedretailPriceDataGridViewTextBoxColumn";
            // 
            // itemWastedcommentDataGridViewTextBoxColumn
            // 
            this.itemWastedcommentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemWastedcommentDataGridViewTextBoxColumn.DataPropertyName = "itemWasted_comment";
            this.itemWastedcommentDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.itemWastedcommentDataGridViewTextBoxColumn.Name = "itemWastedcommentDataGridViewTextBoxColumn";
            // 
            // bs_itemsWasted
            // 
            this.bs_itemsWasted.DataMember = "tbl_itemsWasted";
            this.bs_itemsWasted.DataSource = this.ds_wastedInvoices;
            this.bs_itemsWasted.CurrentChanged += new System.EventHandler(this.bs_itemsWasted_CurrentChanged);
            this.bs_itemsWasted.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bs_itemsWasted_ListChanged);
            // 
            // ds_wastedInvoices
            // 
            this.ds_wastedInvoices.DataSetName = "ds_wastedInvoices";
            this.ds_wastedInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbx_objectTitle
            // 
            this.tbx_objectTitle.Location = new System.Drawing.Point(462, 244);
            this.tbx_objectTitle.Name = "tbx_objectTitle";
            this.tbx_objectTitle.ReadOnly = true;
            this.tbx_objectTitle.Size = new System.Drawing.Size(117, 21);
            this.tbx_objectTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "نـــام کـــالا :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ثبت تغییرات کالا";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_objects
            // 
            this.dgv_objects.AllowUserToAddRows = false;
            this.dgv_objects.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_objects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_objects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_objects.AutoGenerateColumns = false;
            this.dgv_objects.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_objects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_objects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objecttitleDataGridViewTextBoxColumn,
            this.objectretailInUnitDataGridViewTextBoxColumn,
            this.objectentityDataGridViewTextBoxColumn,
            this.objectretailBuyPriceDataGridViewTextBoxColumn,
            this.objectretailSellPriceDataGridViewTextBoxColumn,
            this.object_sellPrice2,
            this.object_sellPrice3});
            this.dgv_objects.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bs_objects, "object_id", true));
            this.dgv_objects.DataSource = this.bs_objects;
            this.dgv_objects.Location = new System.Drawing.Point(10, 36);
            this.dgv_objects.MultiSelect = false;
            this.dgv_objects.Name = "dgv_objects";
            this.dgv_objects.ReadOnly = true;
            this.dgv_objects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_objects.Size = new System.Drawing.Size(614, 171);
            this.dgv_objects.TabIndex = 4;
            this.dgv_objects.Enter += new System.EventHandler(this.dgv_objects_Enter);
            this.dgv_objects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objects_CellDoubleClick);
            this.dgv_objects.Leave += new System.EventHandler(this.dgv_objects_Leave);
            this.dgv_objects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_objects_KeyPress);
            // 
            // objecttitleDataGridViewTextBoxColumn
            // 
            this.objecttitleDataGridViewTextBoxColumn.DataPropertyName = "object_title";
            this.objecttitleDataGridViewTextBoxColumn.HeaderText = "نام کالا";
            this.objecttitleDataGridViewTextBoxColumn.Name = "objecttitleDataGridViewTextBoxColumn";
            this.objecttitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectretailInUnitDataGridViewTextBoxColumn
            // 
            this.objectretailInUnitDataGridViewTextBoxColumn.DataPropertyName = "object_retailInUnit";
            this.objectretailInUnitDataGridViewTextBoxColumn.HeaderText = "جزء در واحد";
            this.objectretailInUnitDataGridViewTextBoxColumn.Name = "objectretailInUnitDataGridViewTextBoxColumn";
            this.objectretailInUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectretailInUnitDataGridViewTextBoxColumn.Width = 50;
            // 
            // objectentityDataGridViewTextBoxColumn
            // 
            this.objectentityDataGridViewTextBoxColumn.DataPropertyName = "object_entity";
            this.objectentityDataGridViewTextBoxColumn.HeaderText = "موجودی";
            this.objectentityDataGridViewTextBoxColumn.Name = "objectentityDataGridViewTextBoxColumn";
            this.objectentityDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectentityDataGridViewTextBoxColumn.Width = 50;
            // 
            // objectretailBuyPriceDataGridViewTextBoxColumn
            // 
            this.objectretailBuyPriceDataGridViewTextBoxColumn.DataPropertyName = "object_retailBuyPrice";
            this.objectretailBuyPriceDataGridViewTextBoxColumn.HeaderText = "قیمت خرید";
            this.objectretailBuyPriceDataGridViewTextBoxColumn.Name = "objectretailBuyPriceDataGridViewTextBoxColumn";
            this.objectretailBuyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectretailBuyPriceDataGridViewTextBoxColumn.Width = 50;
            // 
            // objectretailSellPriceDataGridViewTextBoxColumn
            // 
            this.objectretailSellPriceDataGridViewTextBoxColumn.DataPropertyName = "object_retailSellPrice";
            this.objectretailSellPriceDataGridViewTextBoxColumn.HeaderText = "قیمت فروش";
            this.objectretailSellPriceDataGridViewTextBoxColumn.Name = "objectretailSellPriceDataGridViewTextBoxColumn";
            this.objectretailSellPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectretailSellPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // object_sellPrice2
            // 
            this.object_sellPrice2.DataPropertyName = "object_sellPrice2";
            this.object_sellPrice2.HeaderText = "قیمت فروش 2";
            this.object_sellPrice2.Name = "object_sellPrice2";
            this.object_sellPrice2.ReadOnly = true;
            this.object_sellPrice2.Width = 80;
            // 
            // object_sellPrice3
            // 
            this.object_sellPrice3.DataPropertyName = "object_sellPrice3";
            this.object_sellPrice3.HeaderText = "قیمت فروش 3";
            this.object_sellPrice3.Name = "object_sellPrice3";
            this.object_sellPrice3.ReadOnly = true;
            this.object_sellPrice3.Width = 80;
            // 
            // bs_objects
            // 
            this.bs_objects.DataMember = "tbl_objects";
            this.bs_objects.DataSource = this.ds_objectGrouping;
            this.bs_objects.CurrentChanged += new System.EventHandler(this.bs_objects_CurrentChanged);
            // 
            // ds_objectGrouping
            // 
            this.ds_objectGrouping.DataSetName = "ds_objectGrouping";
            this.ds_objectGrouping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "نام واحد :";
            // 
            // tbx_unitTitle
            // 
            this.tbx_unitTitle.Location = new System.Drawing.Point(265, 244);
            this.tbx_unitTitle.Name = "tbx_unitTitle";
            this.tbx_unitTitle.ReadOnly = true;
            this.tbx_unitTitle.Size = new System.Drawing.Size(117, 21);
            this.tbx_unitTitle.TabIndex = 3;
            // 
            // tbx_retailInUnit
            // 
            this.tbx_retailInUnit.Location = new System.Drawing.Point(49, 244);
            this.tbx_retailInUnit.Name = "tbx_retailInUnit";
            this.tbx_retailInUnit.ReadOnly = true;
            this.tbx_retailInUnit.Size = new System.Drawing.Size(80, 21);
            this.tbx_retailInUnit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "تعداد جزء در واحد :";
            // 
            // btn_objectsForm
            // 
            this.btn_objectsForm.Location = new System.Drawing.Point(10, 9);
            this.btn_objectsForm.Name = "btn_objectsForm";
            this.btn_objectsForm.Size = new System.Drawing.Size(31, 23);
            this.btn_objectsForm.TabIndex = 3;
            this.btn_objectsForm.Text = "...";
            this.btn_objectsForm.UseVisualStyleBackColor = true;
            this.btn_objectsForm.Click += new System.EventHandler(this.btn_objectsForm_Click);
            // 
            // cbx_allPrice
            // 
            this.cbx_allPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_allPrice.FormattingEnabled = true;
            this.cbx_allPrice.Location = new System.Drawing.Point(462, 217);
            this.cbx_allPrice.Name = "cbx_allPrice";
            this.cbx_allPrice.Size = new System.Drawing.Size(119, 21);
            this.cbx_allPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "رنج قیمت :";
            // 
            // btn_showObjectGrouping
            // 
            this.btn_showObjectGrouping.Location = new System.Drawing.Point(2, 34);
            this.btn_showObjectGrouping.Name = "btn_showObjectGrouping";
            this.btn_showObjectGrouping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_showObjectGrouping.Size = new System.Drawing.Size(18, 173);
            this.btn_showObjectGrouping.TabIndex = 0;
            this.btn_showObjectGrouping.Text = "<";
            this.toolTip1.SetToolTip(this.btn_showObjectGrouping, " ctrl+space گروه بندی کالا");
            this.btn_showObjectGrouping.UseVisualStyleBackColor = true;
            this.btn_showObjectGrouping.Click += new System.EventHandler(this.btn_showObjectGrouping_Click);
            // 
            // pnl_groupingSet
            // 
            this.pnl_groupingSet.Controls.Add(this.btn_showObjectGrouping);
            this.pnl_groupingSet.Controls.Add(this.treeView1);
            this.pnl_groupingSet.Location = new System.Drawing.Point(640, 1);
            this.pnl_groupingSet.Name = "pnl_groupingSet";
            this.pnl_groupingSet.Size = new System.Drawing.Size(265, 210);
            this.pnl_groupingSet.TabIndex = 1;
            // 
            // tbx_searchObjects
            // 
            this.tbx_searchObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_searchObjects.Location = new System.Drawing.Point(329, 7);
            this.tbx_searchObjects.Name = "tbx_searchObjects";
            this.tbx_searchObjects.Size = new System.Drawing.Size(240, 21);
            this.tbx_searchObjects.TabIndex = 0;
            this.tbx_searchObjects.TextChanged += new System.EventHandler(this.tbx_searchObjects_TextChanged);
            this.tbx_searchObjects.Leave += new System.EventHandler(this.tbx_searchObjects_Leave);
            this.tbx_searchObjects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_searchObjects_KeyPress);
            this.tbx_searchObjects.Enter += new System.EventHandler(this.tbx_searchObjects_Enter);
            // 
            // pnl_objectSet
            // 
            this.pnl_objectSet.Controls.Add(this.chk_searchWithin);
            this.pnl_objectSet.Controls.Add(this.label5);
            this.pnl_objectSet.Controls.Add(this.tbx_searchObjects);
            this.pnl_objectSet.Controls.Add(this.dgv_objects);
            this.pnl_objectSet.Controls.Add(this.btn_objectsForm);
            this.pnl_objectSet.Controls.Add(this.button1);
            this.pnl_objectSet.Location = new System.Drawing.Point(12, 1);
            this.pnl_objectSet.Name = "pnl_objectSet";
            this.pnl_objectSet.Size = new System.Drawing.Size(627, 210);
            this.pnl_objectSet.TabIndex = 0;
            // 
            // chk_searchWithin
            // 
            this.chk_searchWithin.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_searchWithin.AutoSize = true;
            this.chk_searchWithin.Location = new System.Drawing.Point(296, 7);
            this.chk_searchWithin.Name = "chk_searchWithin";
            this.chk_searchWithin.Size = new System.Drawing.Size(27, 23);
            this.chk_searchWithin.TabIndex = 1;
            this.chk_searchWithin.Text = "@";
            this.chk_searchWithin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "نام کالا :";
            // 
            // bs_masterGroups
            // 
            this.bs_masterGroups.DataMember = "tbl_masterGroups";
            this.bs_masterGroups.DataSource = this.ds_objectGrouping;
            // 
            // tbl_masterGroupsTableAdapter
            // 
            this.tbl_masterGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_slaveGroupsTableAdapter
            // 
            this.tbl_slaveGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // bs_slaveGroups
            // 
            this.bs_slaveGroups.DataMember = "tbl_slaveGroups";
            this.bs_slaveGroups.DataSource = this.ds_objectGrouping;
            // 
            // tbl_objectsTableAdapter
            // 
            this.tbl_objectsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_itemsBuyTableAdapter
            // 
            this.tbl_itemsBuyTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_itemsSellTableAdapter
            // 
            this.tbl_itemsSellTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_itemsWastedTableAdapter
            // 
            this.tbl_itemsWastedTableAdapter.ClearBeforeFill = true;
            // 
            // bs_objectUnits
            // 
            this.bs_objectUnits.DataMember = "tbl_objectUnits";
            this.bs_objectUnits.DataSource = this.ds_objectGrouping;
            // 
            // tbl_objectUnitsTableAdapter
            // 
            this.tbl_objectUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_itemSelection
            // 
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(663, 481);
            this.Controls.Add(this.dgw_invoiceBuy);
            this.Controls.Add(this.pnl_objectSet);
            this.Controls.Add(this.pnl_groupingSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_allPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_retailInUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_unitTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_objectTitle);
            this.Controls.Add(this.dgw_itemsWasted);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dgw_invoiceSell);
            this.KeyPreview = true;
            this.Name = "frm_itemSelection";
            this.Text = "  انتخاب کالا";
            this.Load += new System.EventHandler(this.frm_itemSelection_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_itemSelection_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_itemSelection_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_invoiceBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_buyInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_invoiceSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sellInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_itemsWasted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsWasted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_wastedInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_objects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).EndInit();
            this.pnl_groupingSet.ResumeLayout(false);
            this.pnl_objectSet.ResumeLayout(false);
            this.pnl_objectSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_masterGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_slaveGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objectUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private ds_objectGrouping ds_objectGrouping;
        private System.Windows.Forms.BindingSource bs_masterGroups;
        private Novin.ds_objectGroupingTableAdapters.tbl_masterGroupsTableAdapter tbl_masterGroupsTableAdapter;
        private Novin.ds_objectGroupingTableAdapters.tbl_slaveGroupsTableAdapter tbl_slaveGroupsTableAdapter;
        private System.Windows.Forms.BindingSource bs_slaveGroups;
        private System.Windows.Forms.BindingSource bs_objects;
        private Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter tbl_objectsTableAdapter;
        private System.Windows.Forms.DataGridView dgw_invoiceBuy;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        public ds_buyInvoices ds_buyInvoices;
        public Novin.ds_buyInvoicesTableAdapters.tbl_itemsBuyTableAdapter tbl_itemsBuyTableAdapter;
        public System.Windows.Forms.BindingSource bs_itemsBuy;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuyunitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuyretailCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuyretailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuy_discountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuytaxPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuycommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgw_invoiceSell;
        public System.Windows.Forms.BindingSource bs_itemsSell;
        public ds_sellInvoices ds_sellInvoices;
        public Novin.ds_sellInvoicesTableAdapters.tbl_itemsSellTableAdapter tbl_itemsSellTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellunitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellretailCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellretailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSelldiscountPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellvisitorPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSelltransportPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSelltaxPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSellcommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgw_itemsWasted;
        public System.Windows.Forms.BindingSource bs_itemsWasted;
        public Novin.ds_wastedInvoicesTableAdapters.tbl_itemsWastedTableAdapter tbl_itemsWastedTableAdapter;
        public ds_wastedInvoices ds_wastedInvoices;
        private System.Windows.Forms.TextBox tbx_objectTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bs_objectUnits;
        private Novin.ds_objectGroupingTableAdapters.tbl_objectUnitsTableAdapter tbl_objectUnitsTableAdapter;
        private System.Windows.Forms.DataGridView dgv_objects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_unitTitle;
        private System.Windows.Forms.TextBox tbx_retailInUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_objectsForm;
        private System.Windows.Forms.ComboBox cbx_allPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_showObjectGrouping;
        private System.Windows.Forms.Panel pnl_groupingSet;
        private System.Windows.Forms.TextBox tbx_searchObjects;
        private System.Windows.Forms.Panel pnl_objectSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWastedunitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWastedretailCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWastedretailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWastedcommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objecttitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectretailInUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectentityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectretailBuyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectretailSellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn object_sellPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn object_sellPrice3;
        private System.Windows.Forms.CheckBox chk_searchWithin;
    }
}
