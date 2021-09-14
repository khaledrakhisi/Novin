namespace Novin
{
    partial class frm_objectsUnits
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
            this.cbx_stores = new System.Windows.Forms.ComboBox();
            this.bs_objectUnits = new System.Windows.Forms.BindingSource(this.components);
            this.ds_objectGrouping = new Novin.ds_objectGrouping();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_retailTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_objectUnitsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_objectUnitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objectUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_stores
            // 
            this.cbx_stores.DataSource = this.bs_objectUnits;
            this.cbx_stores.DisplayMember = "objectUnit_title";
            this.cbx_stores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stores.FormattingEnabled = true;
            this.cbx_stores.Location = new System.Drawing.Point(106, 12);
            this.cbx_stores.Name = "cbx_stores";
            this.cbx_stores.Size = new System.Drawing.Size(140, 21);
            this.cbx_stores.TabIndex = 39;
            this.cbx_stores.ValueMember = "objectUnit_id";
            // 
            // bs_objectUnits
            // 
            this.bs_objectUnits.DataMember = "tbl_objectUnits";
            this.bs_objectUnits.DataSource = this.ds_objectGrouping;
            this.bs_objectUnits.CurrentChanged += new System.EventHandler(this.bs_objectUnits_CurrentChanged);
            // 
            // ds_objectGrouping
            // 
            this.ds_objectGrouping.DataSetName = "ds_objectGrouping";
            this.ds_objectGrouping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(9, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 44);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Azure;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_close.ForeColor = System.Drawing.Color.Blue;
            this.btn_close.Location = new System.Drawing.Point(16, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "ثبت و خروج";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(106, 11);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "حذف واحد";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Azure;
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.Location = new System.Drawing.Point(196, 11);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 23);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "تغییرنام واحد";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Azure;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.ForeColor = System.Drawing.Color.Green;
            this.btn_add.Location = new System.Drawing.Point(286, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "* واحد جدید";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "نام واحد :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_retailTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 52);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سایر مشخصات واحد کـــالا:";
            // 
            // tbx_retailTitle
            // 
            this.tbx_retailTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_objectUnits, "objectUnit_RetailTitle", true));
            this.tbx_retailTitle.Location = new System.Drawing.Point(75, 20);
            this.tbx_retailTitle.Name = "tbx_retailTitle";
            this.tbx_retailTitle.Size = new System.Drawing.Size(100, 21);
            this.tbx_retailTitle.TabIndex = 16;
            this.tbx_retailTitle.TextChanged += new System.EventHandler(this.tbx_retailTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام جزء :";
            // 
            // tbl_objectUnitsTableAdapter
            // 
            this.tbl_objectUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_objectsUnits
            // 
            this.ClientSize = new System.Drawing.Size(410, 146);
            this.Controls.Add(this.cbx_stores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_objectsUnits";
            this.Text = "  واحد کــــالا";
            this.Load += new System.EventHandler(this.frm_objectsUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_objectUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_stores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_retailTitle;
        private System.Windows.Forms.Label label1;
        private ds_objectGrouping ds_objectGrouping;
        private System.Windows.Forms.BindingSource bs_objectUnits;
        private Novin.ds_objectGroupingTableAdapters.tbl_objectUnitsTableAdapter tbl_objectUnitsTableAdapter;
    }
}
