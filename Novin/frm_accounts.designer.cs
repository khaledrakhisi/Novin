namespace Novin
{
    partial class frm_accounts
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_remainMoney = new System.Windows.Forms.TextBox();
            this.bs_accounts = new System.Windows.Forms.BindingSource(this.components);
            this.ds_accounts = new Novin.ds_accounts();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_newBank = new System.Windows.Forms.Button();
            this.cmb_bankName = new System.Windows.Forms.ComboBox();
            this.bs_banks = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_chapterName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_accountNumbers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_totalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_chapterNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_accountType = new System.Windows.Forms.ComboBox();
            this.bs_accountsTypes = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbl_accountsTableAdapter = new Novin.ds_accountsTableAdapters.tbl_accountsTableAdapter();
            this.tbl_accountTypesTableAdapter = new Novin.ds_accountsTableAdapters.tbl_accountTypesTableAdapter();
            this.tbl_banksTableAdapter = new Novin.ds_accountsTableAdapters.tbl_banksTableAdapter();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_banks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accountsTypes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "شماره حساب :";
            // 
            // tbx_remainMoney
            // 
            this.tbx_remainMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_accounts, "account_remain", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbx_remainMoney.Location = new System.Drawing.Point(265, 124);
            this.tbx_remainMoney.Name = "tbx_remainMoney";
            this.tbx_remainMoney.ReadOnly = true;
            this.tbx_remainMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_remainMoney.Size = new System.Drawing.Size(128, 21);
            this.tbx_remainMoney.TabIndex = 14;
            // 
            // bs_accounts
            // 
            this.bs_accounts.DataMember = "tbl_accounts";
            this.bs_accounts.DataSource = this.ds_accounts;
            this.bs_accounts.CurrentChanged += new System.EventHandler(this.bs_accounts_CurrentChanged);
            // 
            // ds_accounts
            // 
            this.ds_accounts.DataSetName = "ds_accounts";
            this.ds_accounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "باقیمانده حساب :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cbx_accountNumbers);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbx_remainMoney);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbx_totalPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbx_chapterNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbx_accountType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 154);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_newBank);
            this.panel1.Controls.Add(this.cmb_bankName);
            this.panel1.Controls.Add(this.tbx_chapterName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 69);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام بانک :";
            // 
            // btn_newBank
            // 
            this.btn_newBank.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newBank.Location = new System.Drawing.Point(4, 4);
            this.btn_newBank.Name = "btn_newBank";
            this.btn_newBank.Size = new System.Drawing.Size(28, 23);
            this.btn_newBank.TabIndex = 22;
            this.btn_newBank.Text = "...";
            this.toolTip1.SetToolTip(this.btn_newBank, "معرفی بانک جدید");
            this.btn_newBank.UseVisualStyleBackColor = true;
            this.btn_newBank.Click += new System.EventHandler(this.btn_newBank_Click);
            // 
            // cmb_bankName
            // 
            this.cmb_bankName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_accounts, "bank_id", true));
            this.cmb_bankName.DataSource = this.bs_banks;
            this.cmb_bankName.DisplayMember = "bank_name";
            this.cmb_bankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bankName.FormattingEnabled = true;
            this.cmb_bankName.Location = new System.Drawing.Point(38, 6);
            this.cmb_bankName.Name = "cmb_bankName";
            this.cmb_bankName.Size = new System.Drawing.Size(93, 21);
            this.cmb_bankName.TabIndex = 8;
            this.cmb_bankName.ValueMember = "bank_id";
            // 
            // bs_banks
            // 
            this.bs_banks.DataMember = "tbl_banks";
            this.bs_banks.DataSource = this.ds_accounts;
            // 
            // tbx_chapterName
            // 
            this.tbx_chapterName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_accounts, "account_chapterName", true));
            this.tbx_chapterName.Location = new System.Drawing.Point(4, 42);
            this.tbx_chapterName.Name = "tbx_chapterName";
            this.tbx_chapterName.Size = new System.Drawing.Size(130, 21);
            this.tbx_chapterName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "نام شعبه :";
            // 
            // cbx_accountNumbers
            // 
            this.cbx_accountNumbers.DataSource = this.bs_accounts;
            this.cbx_accountNumbers.DisplayMember = "account_number";
            this.cbx_accountNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_accountNumbers.FormattingEnabled = true;
            this.cbx_accountNumbers.Location = new System.Drawing.Point(265, 26);
            this.cbx_accountNumbers.Name = "cbx_accountNumbers";
            this.cbx_accountNumbers.Size = new System.Drawing.Size(128, 21);
            this.cbx_accountNumbers.TabIndex = 23;
            this.cbx_accountNumbers.ValueMember = "account_id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "موجودی اول دوره :";
            // 
            // tbx_totalPrice
            // 
            this.tbx_totalPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_accounts, "account_totalPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbx_totalPrice.Location = new System.Drawing.Point(9, 92);
            this.tbx_totalPrice.Name = "tbx_totalPrice";
            this.tbx_totalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_totalPrice.Size = new System.Drawing.Size(127, 21);
            this.tbx_totalPrice.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "شماره شعبه :";
            // 
            // tbx_chapterNo
            // 
            this.tbx_chapterNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_accounts, "account_chapterNo", true));
            this.tbx_chapterNo.Location = new System.Drawing.Point(265, 92);
            this.tbx_chapterNo.Name = "tbx_chapterNo";
            this.tbx_chapterNo.Size = new System.Drawing.Size(128, 21);
            this.tbx_chapterNo.TabIndex = 18;
            this.tbx_chapterNo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "نوع حساب :";
            // 
            // cbx_accountType
            // 
            this.cbx_accountType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_accounts, "accountType_id", true));
            this.cbx_accountType.DataSource = this.bs_accountsTypes;
            this.cbx_accountType.DisplayMember = "accountType_title";
            this.cbx_accountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_accountType.FormattingEnabled = true;
            this.cbx_accountType.Location = new System.Drawing.Point(265, 59);
            this.cbx_accountType.Name = "cbx_accountType";
            this.cbx_accountType.Size = new System.Drawing.Size(128, 21);
            this.cbx_accountType.TabIndex = 14;
            this.cbx_accountType.ValueMember = "accountType_id";
            // 
            // bs_accountsTypes
            // 
            this.bs_accountsTypes.DataMember = "tbl_accountTypes";
            this.bs_accountsTypes.DataSource = this.ds_accounts;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(48, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 44);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Azure;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_close.ForeColor = System.Drawing.Color.Navy;
            this.btn_close.Location = new System.Drawing.Point(16, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "ثبت تغییرات";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(112, 11);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "حذف حساب";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Azure;
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.Location = new System.Drawing.Point(208, 11);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(144, 23);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "اصلاح شماره حساب";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Azure;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.ForeColor = System.Drawing.Color.Green;
            this.btn_add.Location = new System.Drawing.Point(358, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "* حساب جدید";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tbl_accountsTableAdapter
            // 
            this.tbl_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_accountTypesTableAdapter
            // 
            this.tbl_accountTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_banksTableAdapter
            // 
            this.tbl_banksTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(294, 227);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(212, 23);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "تـــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(37, 227);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(128, 23);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "بستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_accounts
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(553, 259);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frm_accounts";
            this.Text = "   ثبت حساب";
            this.Load += new System.EventHandler(this.frm_accounts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_accounts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bs_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_banks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accountsTypes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_remainMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_chapterNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_chapterName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_accountType;
        private System.Windows.Forms.ComboBox cmb_bankName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_totalPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_newBank;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbx_accountNumbers;
        private ds_accounts ds_accounts;
        private System.Windows.Forms.BindingSource bs_accounts;
        private Novin.ds_accountsTableAdapters.tbl_accountsTableAdapter tbl_accountsTableAdapter;
        private System.Windows.Forms.BindingSource bs_accountsTypes;
        private Novin.ds_accountsTableAdapters.tbl_accountTypesTableAdapter tbl_accountTypesTableAdapter;
        private System.Windows.Forms.BindingSource bs_banks;
        private Novin.ds_accountsTableAdapters.tbl_banksTableAdapter tbl_banksTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}
