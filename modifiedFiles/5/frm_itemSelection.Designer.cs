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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.bs_objects = new System.Windows.Forms.BindingSource(this.components);
            this.ds_objectGrouping = new Novin.ds_objectGrouping();
            this.lst_objects = new System.Windows.Forms.ListBox();
            this.bs_masterGroups = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_masterGroupsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_masterGroupsTableAdapter();
            this.tbl_slaveGroupsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_slaveGroupsTableAdapter();
            this.bs_slaveGroups = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_objectsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter();
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
            this.tbl_itemsBuyTableAdapter = new Novin.ds_buyInvoicesTableAdapters.tbl_itemsBuyTableAdapter();
            this.tbl_itemsSellTableAdapter = new Novin.ds_sellInvoicesTableAdapters.tbl_itemsSellTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_masterGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_slaveGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_invoiceBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_buyInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_invoiceSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sellInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView1.Location = new System.Drawing.Point(339, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(317, 212);
            this.treeView1.TabIndex = 14;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.LocationChanged += new System.EventHandler(this.treeView1_LocationChanged);
            // 
            // bs_objects
            // 
            this.bs_objects.DataMember = "tbl_objects";
            this.bs_objects.DataSource = this.ds_objectGrouping;
            // 
            // ds_objectGrouping
            // 
            this.ds_objectGrouping.DataSetName = "ds_objectGrouping";
            this.ds_objectGrouping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lst_objects
            // 
            this.lst_objects.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bs_objects, "object_id", true));
            this.lst_objects.DataSource = this.bs_objects;
            this.lst_objects.DisplayMember = "object_title";
            this.lst_objects.FormattingEnabled = true;
            this.lst_objects.Location = new System.Drawing.Point(12, 12);
            this.lst_objects.Name = "lst_objects";
            this.lst_objects.Size = new System.Drawing.Size(318, 212);
            this.lst_objects.TabIndex = 28;
            this.lst_objects.ValueMember = "object_id";
            this.lst_objects.SelectedIndexChanged += new System.EventHandler(this.lst_objects_SelectedIndexChanged);
            this.lst_objects.DoubleClick += new System.EventHandler(this.lst_objects_DoubleClick);
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
            // dgw_invoiceBuy
            // 
            this.dgw_invoiceBuy.AllowUserToAddRows = false;
            this.dgw_invoiceBuy.AllowUserToDeleteRows = false;
            this.dgw_invoiceBuy.AllowUserToResizeRows = false;
            this.dgw_invoiceBuy.AutoGenerateColumns = false;
            this.dgw_invoiceBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_invoiceBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemBuyunitCountDataGridViewTextBoxColumn,
            this.itemBuyretailCountDataGridViewTextBoxColumn,
            this.itemBuyretailPriceDataGridViewTextBoxColumn,
            this.itemBuy_discountPercent,
            this.itemBuytaxPercentDataGridViewTextBoxColumn,
            this.itemBuycommentDataGridViewTextBoxColumn});
            this.dgw_invoiceBuy.DataSource = this.bs_itemsBuy;
            this.dgw_invoiceBuy.Location = new System.Drawing.Point(13, 243);
            this.dgw_invoiceBuy.Name = "dgw_invoiceBuy";
            this.dgw_invoiceBuy.Size = new System.Drawing.Size(643, 175);
            this.dgw_invoiceBuy.TabIndex = 29;
            this.dgw_invoiceBuy.Visible = false;
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
            this.btn_ok.Location = new System.Drawing.Point(482, 424);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 49;
            this.btn_ok.Text = "تــــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(401, 424);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 50;
            this.btn_cancel.Text = "انــــصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(24, 424);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 51;
            this.btn_delete.Text = "حـــذف سطر";
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
            this.dgw_invoiceSell.Location = new System.Drawing.Point(12, 243);
            this.dgw_invoiceSell.Name = "dgw_invoiceSell";
            this.dgw_invoiceSell.Size = new System.Drawing.Size(643, 175);
            this.dgw_invoiceSell.TabIndex = 52;
            this.dgw_invoiceSell.Visible = false;
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
            // 
            // ds_sellInvoices
            // 
            this.ds_sellInvoices.DataSetName = "ds_sellInvoices";
            this.ds_sellInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_itemsBuyTableAdapter
            // 
            this.tbl_itemsBuyTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_itemsSellTableAdapter
            // 
            this.tbl_itemsSellTableAdapter.ClearBeforeFill = true;
            // 
            // frm_itemSelection
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(668, 459);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lst_objects);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dgw_invoiceSell);
            this.Controls.Add(this.dgw_invoiceBuy);
            this.Name = "frm_itemSelection";
            this.Text = "";
            this.Load += new System.EventHandler(this.frm_itemSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_objects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_masterGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_slaveGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_invoiceBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_buyInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_invoiceSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_itemsSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sellInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lst_objects;
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
    }
}
