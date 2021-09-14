namespace Novin
{
    partial class frm_chequesExplorer
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
            this.gbx_allChegues = new System.Windows.Forms.GroupBox();
            this.chk_filterWithPerson = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdu_returnedCheques = new System.Windows.Forms.RadioButton();
            this.rdu_usedCheques = new System.Windows.Forms.RadioButton();
            this.rdu_unUsedCheques = new System.Windows.Forms.RadioButton();
            this.rdu_allChequesStates = new System.Windows.Forms.RadioButton();
            this.grp_personSet = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bs_persons = new System.Windows.Forms.BindingSource(this.components);
            this.ds_chqs = new Novin.ds_chqs();
            this.chk_notMineCheques = new System.Windows.Forms.CheckBox();
            this.chk_mineCheques = new System.Windows.Forms.CheckBox();
            this.chbx_allCheques = new System.Windows.Forms.CheckBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_modifyInvoice = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.bs_cheques = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_chequesTableAdapter = new Novin.ds_chqsTableAdapters.tbl_chequesTableAdapter();
            this.tbl_personsTableAdapter = new Novin.ds_chqsTableAdapters.tbl_personsTableAdapter();
            this.gbx_allChegues.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_personSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_chqs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cheques)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_allChegues
            // 
            this.gbx_allChegues.Controls.Add(this.chk_filterWithPerson);
            this.gbx_allChegues.Controls.Add(this.groupBox2);
            this.gbx_allChegues.Controls.Add(this.grp_personSet);
            this.gbx_allChegues.Controls.Add(this.chk_notMineCheques);
            this.gbx_allChegues.Controls.Add(this.chk_mineCheques);
            this.gbx_allChegues.Location = new System.Drawing.Point(12, 12);
            this.gbx_allChegues.Name = "gbx_allChegues";
            this.gbx_allChegues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbx_allChegues.Size = new System.Drawing.Size(808, 124);
            this.gbx_allChegues.TabIndex = 0;
            this.gbx_allChegues.TabStop = false;
            // 
            // chk_filterWithPerson
            // 
            this.chk_filterWithPerson.AutoSize = true;
            this.chk_filterWithPerson.Checked = true;
            this.chk_filterWithPerson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_filterWithPerson.Location = new System.Drawing.Point(605, 43);
            this.chk_filterWithPerson.Name = "chk_filterWithPerson";
            this.chk_filterWithPerson.Size = new System.Drawing.Size(186, 17);
            this.chk_filterWithPerson.TabIndex = 4;
            this.chk_filterWithPerson.Text = "چک های دریافتی یک شخص  خاص";
            this.chk_filterWithPerson.UseVisualStyleBackColor = true;
            this.chk_filterWithPerson.CheckedChanged += new System.EventHandler(this.chk_filterWithPerson_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdu_returnedCheques);
            this.groupBox2.Controls.Add(this.rdu_usedCheques);
            this.groupBox2.Controls.Add(this.rdu_unUsedCheques);
            this.groupBox2.Controls.Add(this.rdu_allChequesStates);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 98);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "وضعیت چک";
            // 
            // rdu_returnedCheques
            // 
            this.rdu_returnedCheques.AutoSize = true;
            this.rdu_returnedCheques.Location = new System.Drawing.Point(25, 41);
            this.rdu_returnedCheques.Name = "rdu_returnedCheques";
            this.rdu_returnedCheques.Size = new System.Drawing.Size(65, 17);
            this.rdu_returnedCheques.TabIndex = 3;
            this.rdu_returnedCheques.Text = "برگشتی";
            this.rdu_returnedCheques.UseVisualStyleBackColor = true;
            // 
            // rdu_usedCheques
            // 
            this.rdu_usedCheques.AutoSize = true;
            this.rdu_usedCheques.Location = new System.Drawing.Point(141, 41);
            this.rdu_usedCheques.Name = "rdu_usedCheques";
            this.rdu_usedCheques.Size = new System.Drawing.Size(76, 17);
            this.rdu_usedCheques.TabIndex = 2;
            this.rdu_usedCheques.Text = "وصول شده";
            this.rdu_usedCheques.UseVisualStyleBackColor = true;
            // 
            // rdu_unUsedCheques
            // 
            this.rdu_unUsedCheques.AutoSize = true;
            this.rdu_unUsedCheques.Location = new System.Drawing.Point(268, 41);
            this.rdu_unUsedCheques.Name = "rdu_unUsedCheques";
            this.rdu_unUsedCheques.Size = new System.Drawing.Size(80, 17);
            this.rdu_unUsedCheques.TabIndex = 1;
            this.rdu_unUsedCheques.Text = "وصول نشده";
            this.rdu_unUsedCheques.UseVisualStyleBackColor = true;
            // 
            // rdu_allChequesStates
            // 
            this.rdu_allChequesStates.AutoSize = true;
            this.rdu_allChequesStates.Checked = true;
            this.rdu_allChequesStates.Location = new System.Drawing.Point(399, 41);
            this.rdu_allChequesStates.Name = "rdu_allChequesStates";
            this.rdu_allChequesStates.Size = new System.Drawing.Size(97, 17);
            this.rdu_allChequesStates.TabIndex = 0;
            this.rdu_allChequesStates.TabStop = true;
            this.rdu_allChequesStates.Text = "همه وضعیت ها";
            this.rdu_allChequesStates.UseVisualStyleBackColor = true;
            // 
            // grp_personSet
            // 
            this.grp_personSet.Controls.Add(this.comboBox1);
            this.grp_personSet.Location = new System.Drawing.Point(532, 43);
            this.grp_personSet.Name = "grp_personSet";
            this.grp_personSet.Size = new System.Drawing.Size(264, 70);
            this.grp_personSet.TabIndex = 9;
            this.grp_personSet.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DataSource = this.bs_persons;
            this.comboBox1.DisplayMember = "person_familyAndName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "person_id";
            // 
            // bs_persons
            // 
            this.bs_persons.DataMember = "tbl_persons";
            this.bs_persons.DataSource = this.ds_chqs;
            // 
            // ds_chqs
            // 
            this.ds_chqs.DataSetName = "ds_chqs";
            this.ds_chqs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chk_notMineCheques
            // 
            this.chk_notMineCheques.AutoSize = true;
            this.chk_notMineCheques.Checked = true;
            this.chk_notMineCheques.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_notMineCheques.Location = new System.Drawing.Point(575, 20);
            this.chk_notMineCheques.Name = "chk_notMineCheques";
            this.chk_notMineCheques.Size = new System.Drawing.Size(106, 17);
            this.chk_notMineCheques.TabIndex = 7;
            this.chk_notMineCheques.Text = "چک های دریافتی";
            this.chk_notMineCheques.UseVisualStyleBackColor = true;
            // 
            // chk_mineCheques
            // 
            this.chk_mineCheques.AutoSize = true;
            this.chk_mineCheques.Location = new System.Drawing.Point(687, 20);
            this.chk_mineCheques.Name = "chk_mineCheques";
            this.chk_mineCheques.Size = new System.Drawing.Size(109, 17);
            this.chk_mineCheques.TabIndex = 8;
            this.chk_mineCheques.Text = "چک های پرداختی";
            this.chk_mineCheques.UseVisualStyleBackColor = true;
            // 
            // chbx_allCheques
            // 
            this.chbx_allCheques.AutoSize = true;
            this.chbx_allCheques.Checked = true;
            this.chbx_allCheques.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_allCheques.Location = new System.Drawing.Point(732, 9);
            this.chbx_allCheques.Name = "chbx_allCheques";
            this.chbx_allCheques.Size = new System.Drawing.Size(82, 17);
            this.chbx_allCheques.TabIndex = 10;
            this.chbx_allCheques.Text = "تعیین شروط";
            this.chbx_allCheques.UseVisualStyleBackColor = true;
            this.chbx_allCheques.CheckedChanged += new System.EventHandler(this.chbx_allCheques_CheckedChanged);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(651, 142);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(163, 23);
            this.btn_view.TabIndex = 51;
            this.btn_view.Text = "نمایش";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(463, 418);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 52;
            this.btn_cancel.Text = "بستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(808, 241);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_modifyInvoice
            // 
            this.btn_modifyInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modifyInvoice.Location = new System.Drawing.Point(544, 418);
            this.btn_modifyInvoice.Name = "btn_modifyInvoice";
            this.btn_modifyInvoice.Size = new System.Drawing.Size(149, 23);
            this.btn_modifyInvoice.TabIndex = 59;
            this.btn_modifyInvoice.Text = "ویـــــرایش سند";
            this.btn_modifyInvoice.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Location = new System.Drawing.Point(699, 418);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(114, 23);
            this.btn_print.TabIndex = 58;
            this.btn_print.Text = "چــاپ";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // bs_cheques
            // 
            this.bs_cheques.DataMember = "tbl_cheques";
            this.bs_cheques.DataSource = this.ds_chqs;
            // 
            // tbl_chequesTableAdapter
            // 
            this.tbl_chequesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_personsTableAdapter
            // 
            this.tbl_personsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_chequesExplorer
            // 
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btn_modifyInvoice);
            this.Controls.Add(this.chbx_allCheques);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.gbx_allChegues);
            this.Name = "frm_chequesExplorer";
            this.Text = "   مرور چک ها  ";
            this.Load += new System.EventHandler(this.frm_chequesExplorer_Load);
            this.gbx_allChegues.ResumeLayout(false);
            this.gbx_allChegues.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_personSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_chqs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cheques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_allChegues;
        //private ds_cheques ds_cheques;
        //private Novin.ds_chequesTableAdapters.tbl_personsTableAdapter tbl_personsTableAdapter;
        private System.Windows.Forms.CheckBox chbx_allCheques;
        private System.Windows.Forms.GroupBox grp_personSet;
        private System.Windows.Forms.CheckBox chk_filterWithPerson;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chk_notMineCheques;
        private System.Windows.Forms.CheckBox chk_mineCheques;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdu_usedCheques;
        private System.Windows.Forms.RadioButton rdu_unUsedCheques;
        private System.Windows.Forms.RadioButton rdu_allChequesStates;
        private System.Windows.Forms.RadioButton rdu_returnedCheques;
        private System.Windows.Forms.Button btn_modifyInvoice;
        private System.Windows.Forms.Button btn_print;
        private ds_chqs ds_chqs;
        private System.Windows.Forms.BindingSource bs_cheques;
        private Novin.ds_chqsTableAdapters.tbl_chequesTableAdapter tbl_chequesTableAdapter;
        private System.Windows.Forms.BindingSource bs_persons;
        private Novin.ds_chqsTableAdapters.tbl_personsTableAdapter tbl_personsTableAdapter;
    }
}
