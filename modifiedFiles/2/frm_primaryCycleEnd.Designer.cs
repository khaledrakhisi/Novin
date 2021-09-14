namespace Novin
{
    partial class frm_primaryCycleEnd
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
            System.Windows.Forms.Label chq_numberLabel;
            System.Windows.Forms.Label chq_priceLabel;
            this.mTbx_accDocDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_owner = new System.Windows.Forms.Label();
            this.lbl_chequePriceInChars = new System.Windows.Forms.Label();
            this.lbl_chequeKind = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chq_numberTextBox = new System.Windows.Forms.TextBox();
            this.bs_Cheques = new System.Windows.Forms.BindingSource(this.components);
            this.ds_viewCheques = new Novin.ds_viewCheques();
            this.person_familyAndNameTextBox = new System.Windows.Forms.TextBox();
            this.tbx_price = new System.Windows.Forms.TextBox();
            this.pnl_navigation = new System.Windows.Forms.Panel();
            this.cbx_whichCheq = new System.Windows.Forms.ComboBox();
            this.lbl_currentMineChequePosition = new System.Windows.Forms.Label();
            this.btn_priorCheque = new System.Windows.Forms.Button();
            this.btn_nextCheque = new System.Windows.Forms.Button();
            this.viw_chequesTableAdapter = new Novin.ds_viewChequesTableAdapters.viw_chequesTableAdapter();
            this.tableAdapterManager = new Novin.ds_viewChequesTableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_sumOfNotMineCheques = new System.Windows.Forms.TextBox();
            this.tbx_sumOfMineCheques = new System.Windows.Forms.TextBox();
            this.tbl_personsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_viwIndebtedCreditor = new System.Windows.Forms.BindingSource(this.components);
            this.ds_viewIndebtedCreditor = new Novin.ds_viewIndebtedCreditor();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_sumOfCreditors = new System.Windows.Forms.TextBox();
            this.tbx_sumOfIndebteds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_entireObjectsCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ds_objectGrouping = new Novin.ds_objectGrouping();
            this.bs_objects = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_objectsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_sumOfAcountAndCashes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_sumOfAccounts = new System.Windows.Forms.TextBox();
            this.tbx_sumOfCashes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.viw_accountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_viewAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.ds_viewAccounts = new Novin.ds_viewAccounts();
            this.tableAdapterManager1 = new Novin.ds_personsTableAdapters.TableAdapterManager();
            this.viw_accountsTableAdapter = new Novin.ds_viewAccountsTableAdapters.viw_accountsTableAdapter();
            this.tableAdapterManager2 = new Novin.ds_viewAccountsTableAdapters.TableAdapterManager();
            this.viw_indebtedCreditorTableAdapter = new Novin.ds_viewIndebtedCreditorTableAdapters.viw_indebtedCreditorTableAdapter();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            chq_numberLabel = new System.Windows.Forms.Label();
            chq_priceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Cheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_viewCheques)).BeginInit();
            this.pnl_navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_personsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viwIndebtedCreditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_viewIndebtedCreditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objects)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viw_accountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viewAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_viewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // chq_numberLabel
            // 
            chq_numberLabel.AutoSize = true;
            chq_numberLabel.Location = new System.Drawing.Point(517, 17);
            chq_numberLabel.Name = "chq_numberLabel";
            chq_numberLabel.Size = new System.Drawing.Size(65, 13);
            chq_numberLabel.TabIndex = 6;
            chq_numberLabel.Text = "شماره چک :";
            // 
            // chq_priceLabel
            // 
            chq_priceLabel.AutoSize = true;
            chq_priceLabel.Location = new System.Drawing.Point(194, 20);
            chq_priceLabel.Name = "chq_priceLabel";
            chq_priceLabel.Size = new System.Drawing.Size(55, 13);
            chq_priceLabel.TabIndex = 10;
            chq_priceLabel.Text = "مبلغ چک :";
            // 
            // mTbx_accDocDate
            // 
            this.mTbx_accDocDate.AllowDrop = true;
            this.mTbx_accDocDate.AllowPromptAsInput = false;
            this.mTbx_accDocDate.Location = new System.Drawing.Point(12, 12);
            this.mTbx_accDocDate.Mask = "0000/00/00";
            this.mTbx_accDocDate.Name = "mTbx_accDocDate";
            this.mTbx_accDocDate.PromptChar = ' ';
            this.mTbx_accDocDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_accDocDate.Size = new System.Drawing.Size(83, 21);
            this.mTbx_accDocDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "تــــاریخ سند :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.lbl_owner);
            this.groupBox1.Controls.Add(this.lbl_chequePriceInChars);
            this.groupBox1.Controls.Add(this.lbl_chequeKind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(chq_numberLabel);
            this.groupBox1.Controls.Add(this.chq_numberTextBox);
            this.groupBox1.Controls.Add(this.person_familyAndNameTextBox);
            this.groupBox1.Controls.Add(chq_priceLabel);
            this.groupBox1.Controls.Add(this.tbx_price);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 66);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "چــــک ها";
            // 
            // lbl_owner
            // 
            this.lbl_owner.Location = new System.Drawing.Point(378, 17);
            this.lbl_owner.Name = "lbl_owner";
            this.lbl_owner.Size = new System.Drawing.Size(72, 23);
            this.lbl_owner.TabIndex = 34;
            this.lbl_owner.Text = "label3";
            // 
            // lbl_chequePriceInChars
            // 
            this.lbl_chequePriceInChars.ForeColor = System.Drawing.Color.Red;
            this.lbl_chequePriceInChars.Location = new System.Drawing.Point(12, 41);
            this.lbl_chequePriceInChars.Name = "lbl_chequePriceInChars";
            this.lbl_chequePriceInChars.Size = new System.Drawing.Size(568, 23);
            this.lbl_chequePriceInChars.TabIndex = 14;
            this.lbl_chequePriceInChars.Text = "label3";
            // 
            // lbl_chequeKind
            // 
            this.lbl_chequeKind.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_chequeKind.ForeColor = System.Drawing.Color.Red;
            this.lbl_chequeKind.Location = new System.Drawing.Point(6, 17);
            this.lbl_chequeKind.Name = "lbl_chequeKind";
            this.lbl_chequeKind.Size = new System.Drawing.Size(52, 18);
            this.lbl_chequeKind.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "نوع چک :";
            // 
            // chq_numberTextBox
            // 
            this.chq_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Cheques, "chq_number", true));
            this.chq_numberTextBox.Location = new System.Drawing.Point(456, 14);
            this.chq_numberTextBox.Name = "chq_numberTextBox";
            this.chq_numberTextBox.ReadOnly = true;
            this.chq_numberTextBox.Size = new System.Drawing.Size(55, 21);
            this.chq_numberTextBox.TabIndex = 7;
            // 
            // bs_Cheques
            // 
            this.bs_Cheques.DataMember = "viw_cheques";
            this.bs_Cheques.DataSource = this.ds_viewCheques;
            this.bs_Cheques.CurrentChanged += new System.EventHandler(this.bs_mineCheques_CurrentChanged);
            // 
            // ds_viewCheques
            // 
            this.ds_viewCheques.DataSetName = "ds_viewCheques";
            this.ds_viewCheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // person_familyAndNameTextBox
            // 
            this.person_familyAndNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Cheques, "person_familyAndName", true));
            this.person_familyAndNameTextBox.Location = new System.Drawing.Point(255, 14);
            this.person_familyAndNameTextBox.Name = "person_familyAndNameTextBox";
            this.person_familyAndNameTextBox.ReadOnly = true;
            this.person_familyAndNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.person_familyAndNameTextBox.Size = new System.Drawing.Size(117, 21);
            this.person_familyAndNameTextBox.TabIndex = 9;
            // 
            // tbx_price
            // 
            this.tbx_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Cheques, "chq_price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbx_price.Location = new System.Drawing.Point(113, 17);
            this.tbx_price.Name = "tbx_price";
            this.tbx_price.ReadOnly = true;
            this.tbx_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_price.Size = new System.Drawing.Size(75, 21);
            this.tbx_price.TabIndex = 11;
            this.tbx_price.TextChanged += new System.EventHandler(this.tbx_price_TextChanged);
            // 
            // pnl_navigation
            // 
            this.pnl_navigation.BackColor = System.Drawing.Color.Transparent;
            this.pnl_navigation.Controls.Add(this.cbx_whichCheq);
            this.pnl_navigation.Controls.Add(this.lbl_currentMineChequePosition);
            this.pnl_navigation.Controls.Add(this.btn_priorCheque);
            this.pnl_navigation.Controls.Add(this.btn_nextCheque);
            this.pnl_navigation.Location = new System.Drawing.Point(184, 9);
            this.pnl_navigation.Name = "pnl_navigation";
            this.pnl_navigation.Size = new System.Drawing.Size(407, 51);
            this.pnl_navigation.TabIndex = 33;
            // 
            // cbx_whichCheq
            // 
            this.cbx_whichCheq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_whichCheq.FormattingEnabled = true;
            this.cbx_whichCheq.Items.AddRange(new object[] {
            "--هردو چک--",
            "چکهای پرداختی",
            "چکهای دریافتی"});
            this.cbx_whichCheq.Location = new System.Drawing.Point(294, 14);
            this.cbx_whichCheq.Name = "cbx_whichCheq";
            this.cbx_whichCheq.Size = new System.Drawing.Size(110, 21);
            this.cbx_whichCheq.TabIndex = 12;
            this.cbx_whichCheq.SelectedIndexChanged += new System.EventHandler(this.cbx_whichCheq_SelectedIndexChanged);
            // 
            // lbl_currentMineChequePosition
            // 
            this.lbl_currentMineChequePosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_currentMineChequePosition.Font = new System.Drawing.Font("B Zar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_currentMineChequePosition.ForeColor = System.Drawing.Color.Black;
            this.lbl_currentMineChequePosition.Location = new System.Drawing.Point(12, 9);
            this.lbl_currentMineChequePosition.Name = "lbl_currentMineChequePosition";
            this.lbl_currentMineChequePosition.Size = new System.Drawing.Size(164, 34);
            this.lbl_currentMineChequePosition.TabIndex = 11;
            this.lbl_currentMineChequePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_priorCheque
            // 
            this.btn_priorCheque.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_priorCheque.Location = new System.Drawing.Point(182, 11);
            this.btn_priorCheque.Name = "btn_priorCheque";
            this.btn_priorCheque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_priorCheque.Size = new System.Drawing.Size(50, 24);
            this.btn_priorCheque.TabIndex = 1;
            this.btn_priorCheque.Text = "<";
            this.btn_priorCheque.UseVisualStyleBackColor = true;
            this.btn_priorCheque.Click += new System.EventHandler(this.btn_priorCheque_Click);
            // 
            // btn_nextCheque
            // 
            this.btn_nextCheque.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_nextCheque.Location = new System.Drawing.Point(238, 12);
            this.btn_nextCheque.Name = "btn_nextCheque";
            this.btn_nextCheque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_nextCheque.Size = new System.Drawing.Size(50, 24);
            this.btn_nextCheque.TabIndex = 0;
            this.btn_nextCheque.Text = ">";
            this.btn_nextCheque.UseVisualStyleBackColor = true;
            this.btn_nextCheque.Click += new System.EventHandler(this.btn_nextCheque_Click);
            // 
            // viw_chequesTableAdapter
            // 
            this.viw_chequesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Novin.ds_viewChequesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "جمع چـــک های دریافتی :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "جمع چـــک های پرداختی :";
            // 
            // tbx_sumOfNotMineCheques
            // 
            this.tbx_sumOfNotMineCheques.Location = new System.Drawing.Point(269, 138);
            this.tbx_sumOfNotMineCheques.Name = "tbx_sumOfNotMineCheques";
            this.tbx_sumOfNotMineCheques.ReadOnly = true;
            this.tbx_sumOfNotMineCheques.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_sumOfNotMineCheques.Size = new System.Drawing.Size(104, 21);
            this.tbx_sumOfNotMineCheques.TabIndex = 36;
            // 
            // tbx_sumOfMineCheques
            // 
            this.tbx_sumOfMineCheques.Location = new System.Drawing.Point(27, 138);
            this.tbx_sumOfMineCheques.Name = "tbx_sumOfMineCheques";
            this.tbx_sumOfMineCheques.ReadOnly = true;
            this.tbx_sumOfMineCheques.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_sumOfMineCheques.Size = new System.Drawing.Size(104, 21);
            this.tbx_sumOfMineCheques.TabIndex = 37;
            // 
            // tbl_personsDataGridView
            // 
            this.tbl_personsDataGridView.AllowUserToAddRows = false;
            this.tbl_personsDataGridView.AllowUserToDeleteRows = false;
            this.tbl_personsDataGridView.AllowUserToResizeRows = false;
            this.tbl_personsDataGridView.AutoGenerateColumns = false;
            this.tbl_personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.detect});
            this.tbl_personsDataGridView.DataSource = this.bs_viwIndebtedCreditor;
            this.tbl_personsDataGridView.Location = new System.Drawing.Point(9, 192);
            this.tbl_personsDataGridView.Name = "tbl_personsDataGridView";
            this.tbl_personsDataGridView.ReadOnly = true;
            this.tbl_personsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_personsDataGridView.Size = new System.Drawing.Size(590, 93);
            this.tbl_personsDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "person_familyAndName";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام خانوادگی و نام";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "person_phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "شماره تلفن";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "person_remainMoney";
            this.dataGridViewTextBoxColumn9.HeaderText = "مانده";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // detect
            // 
            this.detect.DataPropertyName = "detect";
            this.detect.HeaderText = "تشخیص";
            this.detect.Name = "detect";
            this.detect.ReadOnly = true;
            // 
            // bs_viwIndebtedCreditor
            // 
            this.bs_viwIndebtedCreditor.DataMember = "viw_indebtedCreditor";
            this.bs_viwIndebtedCreditor.DataSource = this.ds_viewIndebtedCreditor;
            // 
            // ds_viewIndebtedCreditor
            // 
            this.ds_viewIndebtedCreditor.DataSetName = "ds_viewIndebtedCreditor";
            this.ds_viewIndebtedCreditor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "لیست اشـــخاص بدهکار و بستانکار :";
            // 
            // tbx_sumOfCreditors
            // 
            this.tbx_sumOfCreditors.Location = new System.Drawing.Point(18, 291);
            this.tbx_sumOfCreditors.Name = "tbx_sumOfCreditors";
            this.tbx_sumOfCreditors.ReadOnly = true;
            this.tbx_sumOfCreditors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_sumOfCreditors.Size = new System.Drawing.Size(107, 21);
            this.tbx_sumOfCreditors.TabIndex = 42;
            // 
            // tbx_sumOfIndebteds
            // 
            this.tbx_sumOfIndebteds.Location = new System.Drawing.Point(261, 291);
            this.tbx_sumOfIndebteds.Name = "tbx_sumOfIndebteds";
            this.tbx_sumOfIndebteds.ReadOnly = true;
            this.tbx_sumOfIndebteds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_sumOfIndebteds.Size = new System.Drawing.Size(107, 21);
            this.tbx_sumOfIndebteds.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "جمع حساب های پرداختی :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "جمع حـــسابهای دریافتی :";
            // 
            // tbx_entireObjectsCost
            // 
            this.tbx_entireObjectsCost.Location = new System.Drawing.Point(355, 425);
            this.tbx_entireObjectsCost.Name = "tbx_entireObjectsCost";
            this.tbx_entireObjectsCost.ReadOnly = true;
            this.tbx_entireObjectsCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_entireObjectsCost.Size = new System.Drawing.Size(107, 21);
            this.tbx_entireObjectsCost.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "ارزش کل کالاهای اولیه :";
            // 
            // ds_objectGrouping
            // 
            this.ds_objectGrouping.DataSetName = "ds_objectGrouping";
            this.ds_objectGrouping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_objects
            // 
            this.bs_objects.DataMember = "tbl_objects";
            this.bs_objects.DataSource = this.ds_objectGrouping;
            // 
            // tbl_objectsTableAdapter
            // 
            this.tbl_objectsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_sumOfAcountAndCashes);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbx_sumOfAccounts);
            this.groupBox2.Controls.Add(this.tbx_sumOfCashes);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(349, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 101);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مــــوجودی بانک وصندوق :";
            // 
            // tbx_sumOfAcountAndCashes
            // 
            this.tbx_sumOfAcountAndCashes.Location = new System.Drawing.Point(6, 73);
            this.tbx_sumOfAcountAndCashes.Name = "tbx_sumOfAcountAndCashes";
            this.tbx_sumOfAcountAndCashes.ReadOnly = true;
            this.tbx_sumOfAcountAndCashes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_sumOfAcountAndCashes.Size = new System.Drawing.Size(107, 21);
            this.tbx_sumOfAcountAndCashes.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "جمع مـــوجودی نقدی :";
            // 
            // tbx_sumOfAccounts
            // 
            this.tbx_sumOfAccounts.Location = new System.Drawing.Point(6, 46);
            this.tbx_sumOfAccounts.Name = "tbx_sumOfAccounts";
            this.tbx_sumOfAccounts.ReadOnly = true;
            this.tbx_sumOfAccounts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_sumOfAccounts.Size = new System.Drawing.Size(107, 21);
            this.tbx_sumOfAccounts.TabIndex = 48;
            // 
            // tbx_sumOfCashes
            // 
            this.tbx_sumOfCashes.Location = new System.Drawing.Point(6, 19);
            this.tbx_sumOfCashes.Name = "tbx_sumOfCashes";
            this.tbx_sumOfCashes.ReadOnly = true;
            this.tbx_sumOfCashes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_sumOfCashes.Size = new System.Drawing.Size(107, 21);
            this.tbx_sumOfCashes.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(128, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "جـــمع موجودی بانک ها:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "مـــوجودی صندوق :";
            // 
            // viw_accountsDataGridView
            // 
            this.viw_accountsDataGridView.AllowUserToAddRows = false;
            this.viw_accountsDataGridView.AllowUserToDeleteRows = false;
            this.viw_accountsDataGridView.AutoGenerateColumns = false;
            this.viw_accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viw_accountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.viw_accountsDataGridView.DataSource = this.bs_viewAccounts;
            this.viw_accountsDataGridView.Location = new System.Drawing.Point(12, 320);
            this.viw_accountsDataGridView.Name = "viw_accountsDataGridView";
            this.viw_accountsDataGridView.ReadOnly = true;
            this.viw_accountsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viw_accountsDataGridView.Size = new System.Drawing.Size(300, 126);
            this.viw_accountsDataGridView.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "accountTitle";
            this.dataGridViewTextBoxColumn1.HeaderText = "حـــساب و صندوق";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "account_totalPrice";
            this.dataGridViewTextBoxColumn2.HeaderText = "مــــوجودی";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bs_viewAccounts
            // 
            this.bs_viewAccounts.DataMember = "viw_accounts";
            this.bs_viewAccounts.DataSource = this.ds_viewAccounts;
            // 
            // ds_viewAccounts
            // 
            this.ds_viewAccounts.DataSetName = "ds_viewAccounts";
            this.ds_viewAccounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbl_personsTableAdapter = null;
            this.tableAdapterManager1.tbl_visitorsTableAdapter = null;
            this.tableAdapterManager1.tbl_zonesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Novin.ds_personsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viw_accountsTableAdapter
            // 
            this.viw_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = Novin.ds_viewAccountsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viw_indebtedCreditorTableAdapter
            // 
            this.viw_indebtedCreditorTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(477, 460);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(122, 23);
            this.btn_ok.TabIndex = 47;
            this.btn_ok.Text = "تــــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(397, 460);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.Text = "انــــصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_primaryCycleEnd
            // 
            this.ClientSize = new System.Drawing.Size(611, 492);
            this.Controls.Add(this.viw_accountsDataGridView);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbx_entireObjectsCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbx_sumOfCreditors);
            this.Controls.Add(this.tbx_sumOfIndebteds);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbl_personsDataGridView);
            this.Controls.Add(this.tbx_sumOfMineCheques);
            this.Controls.Add(this.tbx_sumOfNotMineCheques);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl_navigation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mTbx_accDocDate);
            this.Name = "frm_primaryCycleEnd";
            this.Text = "انتـــهای عملیات اول دوره";
            this.Load += new System.EventHandler(this.frm_primaryCycleEnd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Cheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_viewCheques)).EndInit();
            this.pnl_navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_personsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viwIndebtedCreditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_viewIndebtedCreditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objects)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viw_accountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_viewAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_viewAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTbx_accDocDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl_navigation;
        private System.Windows.Forms.Label lbl_currentMineChequePosition;
        private System.Windows.Forms.Button btn_priorCheque;
        private System.Windows.Forms.Button btn_nextCheque;
        private ds_viewCheques ds_viewCheques;
        private System.Windows.Forms.BindingSource bs_Cheques;
        private Novin.ds_viewChequesTableAdapters.viw_chequesTableAdapter viw_chequesTableAdapter;
        private Novin.ds_viewChequesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox chq_numberTextBox;
        private System.Windows.Forms.TextBox person_familyAndNameTextBox;
        private System.Windows.Forms.TextBox tbx_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_chequeKind;
        private System.Windows.Forms.Label lbl_chequePriceInChars;
        private System.Windows.Forms.Label lbl_owner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_sumOfNotMineCheques;
        private System.Windows.Forms.TextBox tbx_sumOfMineCheques;
        private System.Windows.Forms.ComboBox cbx_whichCheq;
        private Novin.ds_personsTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView tbl_personsDataGridView;
        private ds_viewIndebtedCreditor ds_viewIndebtedCreditor;
        private System.Windows.Forms.BindingSource bs_viwIndebtedCreditor;
        private Novin.ds_viewIndebtedCreditorTableAdapters.viw_indebtedCreditorTableAdapter viw_indebtedCreditorTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_sumOfCreditors;
        private System.Windows.Forms.TextBox tbx_sumOfIndebteds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_entireObjectsCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn detect;
        private ds_objectGrouping ds_objectGrouping;
        private System.Windows.Forms.BindingSource bs_objects;
        private Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter tbl_objectsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_sumOfAcountAndCashes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_sumOfAccounts;
        private System.Windows.Forms.TextBox tbx_sumOfCashes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private ds_viewAccounts ds_viewAccounts;
        private System.Windows.Forms.BindingSource bs_viewAccounts;
        private Novin.ds_viewAccountsTableAdapters.viw_accountsTableAdapter viw_accountsTableAdapter;
        private Novin.ds_viewAccountsTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView viw_accountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}
