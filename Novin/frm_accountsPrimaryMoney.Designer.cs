namespace Novin
{
    partial class frm_accountsPrimaryMoney
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
            this.ds_accounts = new Novin.ds_accounts();
            this.bs_accounts = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_accountsTableAdapter = new Novin.ds_accountsTableAdapters.tbl_accountsTableAdapter();
            this.tableAdapterManager = new Novin.ds_accountsTableAdapters.TableAdapterManager();
            this.tbl_accountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_moneyInChars = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_accountsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_accounts
            // 
            this.ds_accounts.DataSetName = "ds_accounts";
            this.ds_accounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_accounts
            // 
            this.bs_accounts.DataMember = "tbl_accounts";
            this.bs_accounts.DataSource = this.ds_accounts;
            this.bs_accounts.CurrentChanged += new System.EventHandler(this.bs_accounts_CurrentChanged);
            // 
            // tbl_accountsTableAdapter
            // 
            this.tbl_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_accountsTableAdapter = this.tbl_accountsTableAdapter;
            this.tableAdapterManager.tbl_accountTypesTableAdapter = null;
            this.tableAdapterManager.tbl_banksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Novin.ds_accountsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_accountsDataGridView
            // 
            this.tbl_accountsDataGridView.AllowUserToAddRows = false;
            this.tbl_accountsDataGridView.AllowUserToDeleteRows = false;
            this.tbl_accountsDataGridView.AutoGenerateColumns = false;
            this.tbl_accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_accountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7});
            this.tbl_accountsDataGridView.DataSource = this.bs_accounts;
            this.tbl_accountsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tbl_accountsDataGridView.Name = "tbl_accountsDataGridView";
            this.tbl_accountsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbl_accountsDataGridView.Size = new System.Drawing.Size(270, 220);
            this.tbl_accountsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "account_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "حـــساب";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "account_totalPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "مــــوجودی";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_close.Location = new System.Drawing.Point(12, 278);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "لـــغو";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Location = new System.Drawing.Point(170, 280);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(110, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "تائـــید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_moneyInChars
            // 
            this.lbl_moneyInChars.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_moneyInChars.Location = new System.Drawing.Point(12, 235);
            this.lbl_moneyInChars.Name = "lbl_moneyInChars";
            this.lbl_moneyInChars.Size = new System.Drawing.Size(270, 42);
            this.lbl_moneyInChars.TabIndex = 11;
            // 
            // frm_accountsPrimaryMoney
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(292, 313);
            this.Controls.Add(this.lbl_moneyInChars);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbl_accountsDataGridView);
            this.Name = "frm_accountsPrimaryMoney";
            this.Text = "  مــــوجوی صندوق و حساب های بانکی";
            this.Load += new System.EventHandler(this.frm_accountsPrimaryMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_accountsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ds_accounts ds_accounts;
        private System.Windows.Forms.BindingSource bs_accounts;
        private Novin.ds_accountsTableAdapters.tbl_accountsTableAdapter tbl_accountsTableAdapter;
        private Novin.ds_accountsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_accountsDataGridView;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_moneyInChars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btn_ok;
    }
}
