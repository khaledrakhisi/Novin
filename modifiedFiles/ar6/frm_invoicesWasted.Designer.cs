namespace Novin
{
    partial class frm_invoicesWasted
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
            this.mTbx_date = new System.Windows.Forms.MaskedTextBox();
            this.bs_invoicesWasted = new System.Windows.Forms.BindingSource(this.components);
            this.ds_wastedInvoices = new Novin.ds_wastedInvoices();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_invoiceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_footer = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grp_details = new System.Windows.Forms.GroupBox();
            this.tbx_invoiceTotalCount = new System.Windows.Forms.TextBox();
            this.tbx_invoiceTotalPrice = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_addOrRemoveRows = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemBuy_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectUnittitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWastedunitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWastedretailCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectTotalCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectretailInUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWastedretailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWastedcommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_viewItemsWasted = new System.Windows.Forms.BindingSource(this.components);
            this.viw_itemsWastedTableAdapter = new Novin.ds_wastedInvoicesTableAdapters.viw_itemsWastedTableAdapter();
            this.tbl_invoicesWastedTableAdapter = new Novin.ds_wastedInvoicesTableAdapters.tbl_invoicesWastedTableAdapter();
            this.grp_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_invoicesWasted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_wastedInvoices)).BeginInit();
            this.grp_footer.SuspendLayout();
            this.grp_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viewItemsWasted)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_header
            // 
            this.grp_header.Controls.Add(this.mTbx_date);
            this.grp_header.Controls.Add(this.label6);
            this.grp_header.Controls.Add(this.tbx_invoiceID);
            this.grp_header.Controls.Add(this.label4);
            this.grp_header.Location = new System.Drawing.Point(11, 12);
            this.grp_header.Name = "grp_header";
            this.grp_header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_header.Size = new System.Drawing.Size(804, 84);
            this.grp_header.TabIndex = 3;
            this.grp_header.TabStop = false;
            // 
            // mTbx_date
            // 
            this.mTbx_date.AllowDrop = true;
            this.mTbx_date.AllowPromptAsInput = false;
            this.mTbx_date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_invoicesWasted, "invoiceWasted_date", true));
            this.mTbx_date.Location = new System.Drawing.Point(7, 52);
            this.mTbx_date.Mask = "0000/00/00";
            this.mTbx_date.Name = "mTbx_date";
            this.mTbx_date.PromptChar = ' ';
            this.mTbx_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_date.Size = new System.Drawing.Size(69, 21);
            this.mTbx_date.TabIndex = 5;
            // 
            // bs_invoicesWasted
            // 
            this.bs_invoicesWasted.DataMember = "tbl_invoicesWasted";
            this.bs_invoicesWasted.DataSource = this.ds_wastedInvoices;
            // 
            // ds_wastedInvoices
            // 
            this.ds_wastedInvoices.DataSetName = "ds_wastedInvoices";
            this.ds_wastedInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tbx_invoiceID
            // 
            this.tbx_invoiceID.Location = new System.Drawing.Point(6, 20);
            this.tbx_invoiceID.Name = "tbx_invoiceID";
            this.tbx_invoiceID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_invoiceID.Size = new System.Drawing.Size(72, 21);
            this.tbx_invoiceID.TabIndex = 3;
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
            // grp_footer
            // 
            this.grp_footer.Controls.Add(this.btn_close);
            this.grp_footer.Controls.Add(this.btn_delete);
            this.grp_footer.Controls.Add(this.btn_new);
            this.grp_footer.Controls.Add(this.btn_save);
            this.grp_footer.Location = new System.Drawing.Point(11, 405);
            this.grp_footer.Name = "grp_footer";
            this.grp_footer.Size = new System.Drawing.Size(804, 45);
            this.grp_footer.TabIndex = 5;
            this.grp_footer.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(541, 15);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "خروج";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(7, 14);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف فاكتور";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.Location = new System.Drawing.Point(703, 15);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "فاکتور جدید";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(622, 15);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "ثبت فاكتور";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grp_details
            // 
            this.grp_details.Controls.Add(this.tbx_invoiceTotalCount);
            this.grp_details.Controls.Add(this.tbx_invoiceTotalPrice);
            this.grp_details.Controls.Add(this.numericUpDown2);
            this.grp_details.Controls.Add(this.label9);
            this.grp_details.Controls.Add(this.btn_addOrRemoveRows);
            this.grp_details.Controls.Add(this.btn_Sum);
            this.grp_details.Controls.Add(this.label7);
            this.grp_details.Controls.Add(this.dataGridView1);
            this.grp_details.Location = new System.Drawing.Point(11, 105);
            this.grp_details.Name = "grp_details";
            this.grp_details.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_details.Size = new System.Drawing.Size(804, 294);
            this.grp_details.TabIndex = 4;
            this.grp_details.TabStop = false;
            this.grp_details.Text = "اقلام فاكتور :";
            // 
            // tbx_invoiceTotalCount
            // 
            this.tbx_invoiceTotalCount.Location = new System.Drawing.Point(249, 261);
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
            this.numericUpDown2.Location = new System.Drawing.Point(58, 17);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 23);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "درصد مالیات کالا :";
            // 
            // btn_addOrRemoveRows
            // 
            this.btn_addOrRemoveRows.Location = new System.Drawing.Point(615, 14);
            this.btn_addOrRemoveRows.Name = "btn_addOrRemoveRows";
            this.btn_addOrRemoveRows.Size = new System.Drawing.Size(165, 23);
            this.btn_addOrRemoveRows.TabIndex = 0;
            this.btn_addOrRemoveRows.Text = "حذف/اضـــافه کــالا";
            this.btn_addOrRemoveRows.UseVisualStyleBackColor = true;
            this.btn_addOrRemoveRows.Click += new System.EventHandler(this.btn_addOrRemoveRows_Click);
            // 
            // btn_Sum
            // 
            this.btn_Sum.Location = new System.Drawing.Point(703, 263);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(77, 25);
            this.btn_Sum.TabIndex = 4;
            this.btn_Sum.Text = "جمع";
            this.btn_Sum.UseVisualStyleBackColor = true;
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
            this.objectTitleDataGridViewTextBoxColumn,
            this.objectUnittitleDataGridViewTextBoxColumn,
            this.itemWastedunitCountDataGridViewTextBoxColumn,
            this.itemWastedretailCountDataGridViewTextBoxColumn,
            this.objectTotalCountDataGridViewTextBoxColumn,
            this.objectretailInUnitDataGridViewTextBoxColumn,
            this.itemWastedretailPriceDataGridViewTextBoxColumn,
            this.objectTotalPriceDataGridViewTextBoxColumn,
            this.itemWastedcommentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bs_viewItemsWasted;
            this.dataGridView1.Location = new System.Drawing.Point(9, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(787, 214);
            this.dataGridView1.TabIndex = 1;
            // 
            // itemBuy_row
            // 
            this.itemBuy_row.DataPropertyName = "itemBuy_row";
            this.itemBuy_row.HeaderText = "ردیف";
            this.itemBuy_row.Name = "itemBuy_row";
            this.itemBuy_row.ReadOnly = true;
            this.itemBuy_row.Width = 50;
            // 
            // objectTitleDataGridViewTextBoxColumn
            // 
            this.objectTitleDataGridViewTextBoxColumn.DataPropertyName = "objectTitle";
            this.objectTitleDataGridViewTextBoxColumn.HeaderText = "objectTitle";
            this.objectTitleDataGridViewTextBoxColumn.Name = "objectTitleDataGridViewTextBoxColumn";
            this.objectTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectUnittitleDataGridViewTextBoxColumn
            // 
            this.objectUnittitleDataGridViewTextBoxColumn.DataPropertyName = "objectUnit_title";
            this.objectUnittitleDataGridViewTextBoxColumn.HeaderText = "objectUnit_title";
            this.objectUnittitleDataGridViewTextBoxColumn.Name = "objectUnittitleDataGridViewTextBoxColumn";
            this.objectUnittitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemWastedunitCountDataGridViewTextBoxColumn
            // 
            this.itemWastedunitCountDataGridViewTextBoxColumn.DataPropertyName = "itemWasted_unitCount";
            this.itemWastedunitCountDataGridViewTextBoxColumn.HeaderText = "itemWasted_unitCount";
            this.itemWastedunitCountDataGridViewTextBoxColumn.Name = "itemWastedunitCountDataGridViewTextBoxColumn";
            this.itemWastedunitCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemWastedretailCountDataGridViewTextBoxColumn
            // 
            this.itemWastedretailCountDataGridViewTextBoxColumn.DataPropertyName = "itemWasted_retailCount";
            this.itemWastedretailCountDataGridViewTextBoxColumn.HeaderText = "itemWasted_retailCount";
            this.itemWastedretailCountDataGridViewTextBoxColumn.Name = "itemWastedretailCountDataGridViewTextBoxColumn";
            this.itemWastedretailCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectTotalCountDataGridViewTextBoxColumn
            // 
            this.objectTotalCountDataGridViewTextBoxColumn.DataPropertyName = "objectTotalCount";
            this.objectTotalCountDataGridViewTextBoxColumn.HeaderText = "objectTotalCount";
            this.objectTotalCountDataGridViewTextBoxColumn.Name = "objectTotalCountDataGridViewTextBoxColumn";
            this.objectTotalCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectretailInUnitDataGridViewTextBoxColumn
            // 
            this.objectretailInUnitDataGridViewTextBoxColumn.DataPropertyName = "object_retailInUnit";
            this.objectretailInUnitDataGridViewTextBoxColumn.HeaderText = "object_retailInUnit";
            this.objectretailInUnitDataGridViewTextBoxColumn.Name = "objectretailInUnitDataGridViewTextBoxColumn";
            this.objectretailInUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemWastedretailPriceDataGridViewTextBoxColumn
            // 
            this.itemWastedretailPriceDataGridViewTextBoxColumn.DataPropertyName = "itemWasted_retailPrice";
            this.itemWastedretailPriceDataGridViewTextBoxColumn.HeaderText = "itemWasted_retailPrice";
            this.itemWastedretailPriceDataGridViewTextBoxColumn.Name = "itemWastedretailPriceDataGridViewTextBoxColumn";
            this.itemWastedretailPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectTotalPriceDataGridViewTextBoxColumn
            // 
            this.objectTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "objectTotalPrice";
            this.objectTotalPriceDataGridViewTextBoxColumn.HeaderText = "objectTotalPrice";
            this.objectTotalPriceDataGridViewTextBoxColumn.Name = "objectTotalPriceDataGridViewTextBoxColumn";
            this.objectTotalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemWastedcommentDataGridViewTextBoxColumn
            // 
            this.itemWastedcommentDataGridViewTextBoxColumn.DataPropertyName = "itemWasted_comment";
            this.itemWastedcommentDataGridViewTextBoxColumn.HeaderText = "itemWasted_comment";
            this.itemWastedcommentDataGridViewTextBoxColumn.Name = "itemWastedcommentDataGridViewTextBoxColumn";
            this.itemWastedcommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bs_viewItemsWasted
            // 
            this.bs_viewItemsWasted.DataMember = "viw_itemsWasted";
            this.bs_viewItemsWasted.DataSource = this.ds_wastedInvoices;
            // 
            // viw_itemsWastedTableAdapter
            // 
            this.viw_itemsWastedTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_invoicesWastedTableAdapter
            // 
            this.tbl_invoicesWastedTableAdapter.ClearBeforeFill = true;
            // 
            // frm_invoicesWasted
            // 
            this.ClientSize = new System.Drawing.Size(822, 458);
            this.Controls.Add(this.grp_header);
            this.Controls.Add(this.grp_footer);
            this.Controls.Add(this.grp_details);
            this.Name = "frm_invoicesWasted";
            this.Text = "فــــاکتور ضایعات کــــالا";
            this.Load += new System.EventHandler(this.frm_invoicesWasted_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_invoicesWasted_FormClosing);
            this.grp_header.ResumeLayout(false);
            this.grp_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_invoicesWasted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_wastedInvoices)).EndInit();
            this.grp_footer.ResumeLayout(false);
            this.grp_details.ResumeLayout(false);
            this.grp_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viewItemsWasted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_header;
        private System.Windows.Forms.MaskedTextBox mTbx_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_invoiceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grp_footer;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox grp_details;
        private System.Windows.Forms.TextBox tbx_invoiceTotalCount;
        private System.Windows.Forms.TextBox tbx_invoiceTotalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_addOrRemoveRows;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ds_wastedInvoices ds_wastedInvoices;
        private System.Windows.Forms.BindingSource bs_viewItemsWasted;
        private Novin.ds_wastedInvoicesTableAdapters.viw_itemsWastedTableAdapter viw_itemsWastedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBuy_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectUnittitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWastedunitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWastedretailCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectTotalCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectretailInUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWastedretailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWastedcommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bs_invoicesWasted;
        private Novin.ds_wastedInvoicesTableAdapters.tbl_invoicesWastedTableAdapter tbl_invoicesWastedTableAdapter;
    }
}
