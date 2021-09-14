namespace Novin
{
    partial class frm_soldObjectExplorer
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
            this.cbx_object = new System.Windows.Forms.ComboBox();
            this.bs_object = new System.Windows.Forms.BindingSource(this.components);
            this.ds_objectGrouping = new Novin.ds_objectGrouping();
            this.cbx_persons = new System.Windows.Forms.ComboBox();
            this.bs_person = new System.Windows.Forms.BindingSource(this.components);
            this.ds_persons = new Novin.ds_persons();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbx_person = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbx_object = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mTbx_toDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_fromDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbx_date = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_showInvoice = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.da_object = new Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter();
            this.da_person = new Novin.ds_personsTableAdapters.tbl_personsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bs_object)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_object
            // 
            this.cbx_object.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_object.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_object.DataSource = this.bs_object;
            this.cbx_object.DisplayMember = "object_title";
            this.cbx_object.FormattingEnabled = true;
            this.cbx_object.Location = new System.Drawing.Point(35, 17);
            this.cbx_object.Name = "cbx_object";
            this.cbx_object.Size = new System.Drawing.Size(150, 21);
            this.cbx_object.TabIndex = 6;
            this.cbx_object.ValueMember = "object_id";
            // 
            // bs_object
            // 
            this.bs_object.DataMember = "tbl_objects";
            this.bs_object.DataSource = this.ds_objectGrouping;
            // 
            // ds_objectGrouping
            // 
            this.ds_objectGrouping.DataSetName = "ds_objectGrouping";
            this.ds_objectGrouping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbx_persons
            // 
            this.cbx_persons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_persons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_persons.DataSource = this.bs_person;
            this.cbx_persons.DisplayMember = "person_familyAndName";
            this.cbx_persons.Enabled = false;
            this.cbx_persons.FormattingEnabled = true;
            this.cbx_persons.Location = new System.Drawing.Point(13, 17);
            this.cbx_persons.Name = "cbx_persons";
            this.cbx_persons.Size = new System.Drawing.Size(179, 21);
            this.cbx_persons.TabIndex = 9;
            this.cbx_persons.ValueMember = "person_id";
            // 
            // bs_person
            // 
            this.bs_person.DataMember = "tbl_persons";
            this.bs_person.DataSource = this.ds_persons;
            // 
            // ds_persons
            // 
            this.ds_persons.DataSetName = "ds_persons";
            this.ds_persons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbx_person);
            this.panel1.Controls.Add(this.cbx_persons);
            this.panel1.Location = new System.Drawing.Point(9, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 55);
            this.panel1.TabIndex = 10;
            // 
            // chbx_person
            // 
            this.chbx_person.AutoSize = true;
            this.chbx_person.Location = new System.Drawing.Point(198, 19);
            this.chbx_person.Name = "chbx_person";
            this.chbx_person.Size = new System.Drawing.Size(108, 17);
            this.chbx_person.TabIndex = 0;
            this.chbx_person.Text = "نام طرف حساب  :";
            this.chbx_person.UseVisualStyleBackColor = true;
            this.chbx_person.CheckedChanged += new System.EventHandler(this.chbx_person_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbx_object);
            this.panel2.Controls.Add(this.cbx_object);
            this.panel2.Location = new System.Drawing.Point(335, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 55);
            this.panel2.TabIndex = 11;
            // 
            // chbx_object
            // 
            this.chbx_object.AutoSize = true;
            this.chbx_object.Checked = true;
            this.chbx_object.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_object.Location = new System.Drawing.Point(191, 19);
            this.chbx_object.Name = "chbx_object";
            this.chbx_object.Size = new System.Drawing.Size(67, 17);
            this.chbx_object.TabIndex = 7;
            this.chbx_object.Text = "نام کالا  :";
            this.chbx_object.UseVisualStyleBackColor = true;
            this.chbx_object.CheckedChanged += new System.EventHandler(this.chbx_object_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mTbx_toDate);
            this.panel3.Controls.Add(this.mTbx_fromDate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chbx_date);
            this.panel3.Location = new System.Drawing.Point(9, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 50);
            this.panel3.TabIndex = 12;
            // 
            // mTbx_toDate
            // 
            this.mTbx_toDate.Enabled = false;
            this.mTbx_toDate.Location = new System.Drawing.Point(406, 14);
            this.mTbx_toDate.Mask = "0000/00/00";
            this.mTbx_toDate.Name = "mTbx_toDate";
            this.mTbx_toDate.PromptChar = ' ';
            this.mTbx_toDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_toDate.Size = new System.Drawing.Size(105, 21);
            this.mTbx_toDate.TabIndex = 17;
            // 
            // mTbx_fromDate
            // 
            this.mTbx_fromDate.AllowPromptAsInput = false;
            this.mTbx_fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbx_fromDate.Culture = new System.Globalization.CultureInfo("");
            this.mTbx_fromDate.Enabled = false;
            this.mTbx_fromDate.Location = new System.Drawing.Point(230, 16);
            this.mTbx_fromDate.Mask = "0000/00/00";
            this.mTbx_fromDate.Name = "mTbx_fromDate";
            this.mTbx_fromDate.PromptChar = ' ';
            this.mTbx_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_fromDate.Size = new System.Drawing.Size(95, 21);
            this.mTbx_fromDate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "تا تاریخ :";
            // 
            // chbx_date
            // 
            this.chbx_date.AutoSize = true;
            this.chbx_date.Location = new System.Drawing.Point(517, 18);
            this.chbx_date.Name = "chbx_date";
            this.chbx_date.Size = new System.Drawing.Size(64, 17);
            this.chbx_date.TabIndex = 1;
            this.chbx_date.Text = "از تاریخ :";
            this.chbx_date.UseVisualStyleBackColor = true;
            this.chbx_date.CheckedChanged += new System.EventHandler(this.chbx_date_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(590, 172);
            this.dataGridView1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "موارد یافت شده :";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(326, 344);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 23);
            this.btn_close.TabIndex = 28;
            this.btn_close.Text = "بستن";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_showInvoice
            // 
            this.btn_showInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_showInvoice.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_showInvoice.Enabled = false;
            this.btn_showInvoice.Location = new System.Drawing.Point(22, 344);
            this.btn_showInvoice.Name = "btn_showInvoice";
            this.btn_showInvoice.Size = new System.Drawing.Size(140, 23);
            this.btn_showInvoice.TabIndex = 29;
            this.btn_showInvoice.Text = "نمایش فاکتور";
            this.btn_showInvoice.UseVisualStyleBackColor = true;
            this.btn_showInvoice.Click += new System.EventHandler(this.btn_showInvoice_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(453, 344);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(140, 23);
            this.btn_search.TabIndex = 30;
            this.btn_search.Text = "جستجو";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // da_object
            // 
            this.da_object.ClearBeforeFill = true;
            // 
            // da_person
            // 
            this.da_person.ClearBeforeFill = true;
            // 
            // frm_soldObjectExplorer
            // 
            this.AcceptButton = this.btn_search;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(616, 379);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_showInvoice);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_soldObjectExplorer";
            this.Text = " جستجوی کـــــالا";
            this.Load += new System.EventHandler(this.frm_soldObjectExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_object)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_object;
        private System.Windows.Forms.ComboBox cbx_persons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbx_person;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbx_object;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbx_date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_showInvoice;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.MaskedTextBox mTbx_toDate;
        public System.Windows.Forms.MaskedTextBox mTbx_fromDate;
        private ds_objectGrouping ds_objectGrouping;
        private System.Windows.Forms.BindingSource bs_object;
        private Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter da_object;
        private ds_persons ds_persons;
        private System.Windows.Forms.BindingSource bs_person;
        private Novin.ds_personsTableAdapters.tbl_personsTableAdapter da_person;
    }
}
