namespace Novin
{
    partial class frm_visitors
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
            this.bs_visitors = new System.Windows.Forms.BindingSource(this.components);
            this.ds_visitors = new Novin.ds_visitors();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_responsibleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.tbl_visitorsTableAdapter = new Novin.ds_visitorsTableAdapters.tbl_visitorsTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pag_visitors = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bs_zones = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_saveZone = new System.Windows.Forms.Button();
            this.btn_deleteZone = new System.Windows.Forms.Button();
            this.btn_renameZone = new System.Windows.Forms.Button();
            this.btn_newZone = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbl_zonesTableAdapter = new Novin.ds_visitorsTableAdapters.tbl_zonesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bs_visitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_visitors)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pag_visitors.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_zones)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_stores
            // 
            this.cbx_stores.DataSource = this.bs_visitors;
            this.cbx_stores.DisplayMember = "visitor_name";
            this.cbx_stores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_stores.FormattingEnabled = true;
            this.cbx_stores.Location = new System.Drawing.Point(146, 19);
            this.cbx_stores.Name = "cbx_stores";
            this.cbx_stores.Size = new System.Drawing.Size(140, 21);
            this.cbx_stores.TabIndex = 39;
            this.cbx_stores.ValueMember = "visitor_id";
            // 
            // bs_visitors
            // 
            this.bs_visitors.DataMember = "tbl_visitors";
            this.bs_visitors.DataSource = this.ds_visitors;
            // 
            // ds_visitors
            // 
            this.ds_visitors.DataSetName = "ds_visitors";
            this.ds_visitors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(40, 181);
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
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.btn_delete.Text = "حذف ویزیتور";
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
            this.btn_edit.Text = "تغییرنام ویزیتور";
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
            this.btn_add.Text = "* ویزیتور جدید";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "نام ویزیتور :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_responsibleName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_comment);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(16, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 132);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سایر مشخصات ویزیتور :";
            // 
            // tbx_responsibleName
            // 
            this.tbx_responsibleName.Location = new System.Drawing.Point(264, 20);
            this.tbx_responsibleName.Name = "tbx_responsibleName";
            this.tbx_responsibleName.Size = new System.Drawing.Size(100, 21);
            this.tbx_responsibleName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "توضیحات :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "شماره تلفن :";
            // 
            // tbx_comment
            // 
            this.tbx_comment.Location = new System.Drawing.Point(6, 48);
            this.tbx_comment.Multiline = true;
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(375, 69);
            this.tbx_comment.TabIndex = 11;
            // 
            // tbl_visitorsTableAdapter
            // 
            this.tbl_visitorsTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pag_visitors);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 264);
            this.tabControl1.TabIndex = 40;
            // 
            // pag_visitors
            // 
            this.pag_visitors.Controls.Add(this.cbx_stores);
            this.pag_visitors.Controls.Add(this.groupBox1);
            this.pag_visitors.Controls.Add(this.groupBox2);
            this.pag_visitors.Controls.Add(this.label2);
            this.pag_visitors.Location = new System.Drawing.Point(4, 22);
            this.pag_visitors.Name = "pag_visitors";
            this.pag_visitors.Padding = new System.Windows.Forms.Padding(3);
            this.pag_visitors.Size = new System.Drawing.Size(482, 238);
            this.pag_visitors.TabIndex = 0;
            this.pag_visitors.Text = "ویزیتور";
            this.pag_visitors.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "منطقه";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bs_zones;
            this.comboBox1.DisplayMember = "zone_title";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.ValueMember = "zone_id";
            // 
            // bs_zones
            // 
            this.bs_zones.DataMember = "tbl_zones";
            this.bs_zones.DataSource = this.ds_visitors;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(17, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 132);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "سایر مشخصات ویزیتور :";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_zones, "visitor_id", true));
            this.comboBox2.DataSource = this.bs_visitors;
            this.comboBox2.DisplayMember = "visitor_name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(220, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 41;
            this.comboBox2.ValueMember = "visitor_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "ویزیتور مربوطه :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(389, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "توضیحات :";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(6, 48);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 69);
            this.textBox2.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btn_saveZone);
            this.groupBox4.Controls.Add(this.btn_deleteZone);
            this.groupBox4.Controls.Add(this.btn_renameZone);
            this.groupBox4.Controls.Add(this.btn_newZone);
            this.groupBox4.Location = new System.Drawing.Point(41, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 44);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            // 
            // btn_saveZone
            // 
            this.btn_saveZone.BackColor = System.Drawing.Color.Azure;
            this.btn_saveZone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_saveZone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_saveZone.ForeColor = System.Drawing.Color.Blue;
            this.btn_saveZone.Location = new System.Drawing.Point(16, 11);
            this.btn_saveZone.Name = "btn_saveZone";
            this.btn_saveZone.Size = new System.Drawing.Size(90, 23);
            this.btn_saveZone.TabIndex = 8;
            this.btn_saveZone.Text = "ثبت و خروج";
            this.btn_saveZone.UseVisualStyleBackColor = false;
            this.btn_saveZone.Click += new System.EventHandler(this.btn_saveZone_Click);
            // 
            // btn_deleteZone
            // 
            this.btn_deleteZone.BackColor = System.Drawing.Color.Azure;
            this.btn_deleteZone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deleteZone.ForeColor = System.Drawing.Color.Red;
            this.btn_deleteZone.Location = new System.Drawing.Point(106, 11);
            this.btn_deleteZone.Name = "btn_deleteZone";
            this.btn_deleteZone.Size = new System.Drawing.Size(90, 23);
            this.btn_deleteZone.TabIndex = 7;
            this.btn_deleteZone.Text = "حذف منطقه";
            this.btn_deleteZone.UseVisualStyleBackColor = false;
            this.btn_deleteZone.Click += new System.EventHandler(this.btn_deleteZone_Click);
            // 
            // btn_renameZone
            // 
            this.btn_renameZone.BackColor = System.Drawing.Color.Azure;
            this.btn_renameZone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_renameZone.Location = new System.Drawing.Point(196, 11);
            this.btn_renameZone.Name = "btn_renameZone";
            this.btn_renameZone.Size = new System.Drawing.Size(90, 23);
            this.btn_renameZone.TabIndex = 6;
            this.btn_renameZone.Text = "تغییرنام ویزیتور";
            this.btn_renameZone.UseVisualStyleBackColor = false;
            this.btn_renameZone.Click += new System.EventHandler(this.btn_renameZone_Click);
            // 
            // btn_newZone
            // 
            this.btn_newZone.BackColor = System.Drawing.Color.Azure;
            this.btn_newZone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newZone.ForeColor = System.Drawing.Color.Green;
            this.btn_newZone.Location = new System.Drawing.Point(286, 11);
            this.btn_newZone.Name = "btn_newZone";
            this.btn_newZone.Size = new System.Drawing.Size(90, 23);
            this.btn_newZone.TabIndex = 5;
            this.btn_newZone.Text = "* منطقه جدید";
            this.btn_newZone.UseVisualStyleBackColor = false;
            this.btn_newZone.Click += new System.EventHandler(this.btn_newZone_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "نام منطقه :";
            // 
            // tbl_zonesTableAdapter
            // 
            this.tbl_zonesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_visitors
            // 
            this.ClientSize = new System.Drawing.Size(511, 287);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_visitors";
            this.Text = "  ویزیتور";
            this.Load += new System.EventHandler(this.frm_visitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_visitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_visitors)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pag_visitors.ResumeLayout(false);
            this.pag_visitors.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_zones)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox tbx_responsibleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_comment;
        private ds_visitors ds_visitors;
        private System.Windows.Forms.BindingSource bs_visitors;
        private Novin.ds_visitorsTableAdapters.tbl_visitorsTableAdapter tbl_visitorsTableAdapter;
        private System.Windows.Forms.TabPage pag_visitors;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_saveZone;
        private System.Windows.Forms.Button btn_deleteZone;
        private System.Windows.Forms.Button btn_renameZone;
        private System.Windows.Forms.Button btn_newZone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bs_zones;
        private Novin.ds_visitorsTableAdapters.tbl_zonesTableAdapter tbl_zonesTableAdapter;
        public System.Windows.Forms.TabControl tabControl1;
    }
}
