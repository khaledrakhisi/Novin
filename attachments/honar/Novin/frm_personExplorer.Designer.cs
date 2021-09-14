namespace Novin
{
    partial class frm_personExplorer
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
            this.chk_indebtedPersons = new System.Windows.Forms.CheckBox();
            this.chk_creditorPersons = new System.Windows.Forms.CheckBox();
            this.chk_unIndebtedUnCreditorPersons = new System.Windows.Forms.CheckBox();
            this.grp_visitorSet = new System.Windows.Forms.GroupBox();
            this.btn_newVisitor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_visitors = new System.Windows.Forms.ComboBox();
            this.bs_visitors = new System.Windows.Forms.BindingSource(this.components);
            this.ds_visitors = new Novin.ds_visitors();
            this.chk_filterByVisitor = new System.Windows.Forms.CheckBox();
            this.grp_zonesSet = new System.Windows.Forms.GroupBox();
            this.btn_newZone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bs_zones = new System.Windows.Forms.BindingSource(this.components);
            this.chk_filterByZone = new System.Windows.Forms.CheckBox();
            this.tbl_visitorsTableAdapter = new Novin.ds_visitorsTableAdapters.tbl_visitorsTableAdapter();
            this.tbl_zonesTableAdapter = new Novin.ds_visitorsTableAdapters.tbl_zonesTableAdapter();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grp_visitorSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_visitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_visitors)).BeginInit();
            this.grp_zonesSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_zones)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_indebtedPersons
            // 
            this.chk_indebtedPersons.AutoSize = true;
            this.chk_indebtedPersons.Checked = true;
            this.chk_indebtedPersons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_indebtedPersons.Location = new System.Drawing.Point(296, 12);
            this.chk_indebtedPersons.Name = "chk_indebtedPersons";
            this.chk_indebtedPersons.Size = new System.Drawing.Size(99, 17);
            this.chk_indebtedPersons.TabIndex = 0;
            this.chk_indebtedPersons.Text = "نمایش بدهکاران";
            this.chk_indebtedPersons.UseVisualStyleBackColor = true;
            // 
            // chk_creditorPersons
            // 
            this.chk_creditorPersons.AutoSize = true;
            this.chk_creditorPersons.Location = new System.Drawing.Point(175, 12);
            this.chk_creditorPersons.Name = "chk_creditorPersons";
            this.chk_creditorPersons.Size = new System.Drawing.Size(107, 17);
            this.chk_creditorPersons.TabIndex = 1;
            this.chk_creditorPersons.Text = "نمایش بستانکاران";
            this.chk_creditorPersons.UseVisualStyleBackColor = true;
            // 
            // chk_unIndebtedUnCreditorPersons
            // 
            this.chk_unIndebtedUnCreditorPersons.AutoSize = true;
            this.chk_unIndebtedUnCreditorPersons.Location = new System.Drawing.Point(30, 12);
            this.chk_unIndebtedUnCreditorPersons.Name = "chk_unIndebtedUnCreditorPersons";
            this.chk_unIndebtedUnCreditorPersons.Size = new System.Drawing.Size(131, 17);
            this.chk_unIndebtedUnCreditorPersons.TabIndex = 2;
            this.chk_unIndebtedUnCreditorPersons.Text = "نمایش افراد بی حساب";
            this.chk_unIndebtedUnCreditorPersons.UseVisualStyleBackColor = true;
            // 
            // grp_visitorSet
            // 
            this.grp_visitorSet.Controls.Add(this.btn_newVisitor);
            this.grp_visitorSet.Controls.Add(this.label1);
            this.grp_visitorSet.Controls.Add(this.cbx_visitors);
            this.grp_visitorSet.Enabled = false;
            this.grp_visitorSet.Location = new System.Drawing.Point(12, 50);
            this.grp_visitorSet.Name = "grp_visitorSet";
            this.grp_visitorSet.Size = new System.Drawing.Size(400, 62);
            this.grp_visitorSet.TabIndex = 3;
            this.grp_visitorSet.TabStop = false;
            // 
            // btn_newVisitor
            // 
            this.btn_newVisitor.Location = new System.Drawing.Point(31, 19);
            this.btn_newVisitor.Name = "btn_newVisitor";
            this.btn_newVisitor.Size = new System.Drawing.Size(34, 23);
            this.btn_newVisitor.TabIndex = 53;
            this.btn_newVisitor.Text = "...";
            this.btn_newVisitor.UseVisualStyleBackColor = true;
            this.btn_newVisitor.Click += new System.EventHandler(this.btn_newVisitor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ویزیتور :";
            // 
            // cbx_visitors
            // 
            this.cbx_visitors.DataSource = this.bs_visitors;
            this.cbx_visitors.DisplayMember = "visitor_name";
            this.cbx_visitors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_visitors.FormattingEnabled = true;
            this.cbx_visitors.Location = new System.Drawing.Point(71, 21);
            this.cbx_visitors.Name = "cbx_visitors";
            this.cbx_visitors.Size = new System.Drawing.Size(209, 21);
            this.cbx_visitors.TabIndex = 6;
            this.cbx_visitors.ValueMember = "visitor_id";
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
            // chk_filterByVisitor
            // 
            this.chk_filterByVisitor.AutoSize = true;
            this.chk_filterByVisitor.Location = new System.Drawing.Point(265, 46);
            this.chk_filterByVisitor.Name = "chk_filterByVisitor";
            this.chk_filterByVisitor.Size = new System.Drawing.Size(141, 17);
            this.chk_filterByVisitor.TabIndex = 5;
            this.chk_filterByVisitor.Text = "بدهکاران یک ویزیتور خاص";
            this.chk_filterByVisitor.UseVisualStyleBackColor = true;
            this.chk_filterByVisitor.CheckedChanged += new System.EventHandler(this.chk_filterByVisitor_CheckedChanged);
            // 
            // grp_zonesSet
            // 
            this.grp_zonesSet.Controls.Add(this.btn_newZone);
            this.grp_zonesSet.Controls.Add(this.label2);
            this.grp_zonesSet.Controls.Add(this.comboBox1);
            this.grp_zonesSet.Enabled = false;
            this.grp_zonesSet.Location = new System.Drawing.Point(12, 118);
            this.grp_zonesSet.Name = "grp_zonesSet";
            this.grp_zonesSet.Size = new System.Drawing.Size(400, 74);
            this.grp_zonesSet.TabIndex = 4;
            this.grp_zonesSet.TabStop = false;
            // 
            // btn_newZone
            // 
            this.btn_newZone.Location = new System.Drawing.Point(31, 25);
            this.btn_newZone.Name = "btn_newZone";
            this.btn_newZone.Size = new System.Drawing.Size(34, 23);
            this.btn_newZone.TabIndex = 54;
            this.btn_newZone.Text = "...";
            this.btn_newZone.UseVisualStyleBackColor = true;
            this.btn_newZone.Click += new System.EventHandler(this.btn_newZone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "منطقه :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bs_zones;
            this.comboBox1.DisplayMember = "zone_title";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "zone_id";
            // 
            // bs_zones
            // 
            this.bs_zones.DataMember = "tbl_zones";
            this.bs_zones.DataSource = this.ds_visitors;
            // 
            // chk_filterByZone
            // 
            this.chk_filterByZone.AutoSize = true;
            this.chk_filterByZone.Location = new System.Drawing.Point(265, 115);
            this.chk_filterByZone.Name = "chk_filterByZone";
            this.chk_filterByZone.Size = new System.Drawing.Size(142, 17);
            this.chk_filterByZone.TabIndex = 6;
            this.chk_filterByZone.Text = "بدهکاران یک منطقه خاص";
            this.chk_filterByZone.UseVisualStyleBackColor = true;
            this.chk_filterByZone.CheckedChanged += new System.EventHandler(this.chk_filterByZone_CheckedChanged);
            // 
            // tbl_visitorsTableAdapter
            // 
            this.tbl_visitorsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_zonesTableAdapter
            // 
            this.tbl_zonesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(249, 215);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 51;
            this.btn_ok.Text = "تــــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(168, 215);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 52;
            this.btn_cancel.Text = "انــــصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_personExplorer
            // 
            this.ClientSize = new System.Drawing.Size(424, 246);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.chk_filterByZone);
            this.Controls.Add(this.chk_filterByVisitor);
            this.Controls.Add(this.grp_zonesSet);
            this.Controls.Add(this.grp_visitorSet);
            this.Controls.Add(this.chk_unIndebtedUnCreditorPersons);
            this.Controls.Add(this.chk_creditorPersons);
            this.Controls.Add(this.chk_indebtedPersons);
            this.Name = "frm_personExplorer";
            this.Text = "";
            this.Load += new System.EventHandler(this.frm_personExplorer_Load);
            this.grp_visitorSet.ResumeLayout(false);
            this.grp_visitorSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_visitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_visitors)).EndInit();
            this.grp_zonesSet.ResumeLayout(false);
            this.grp_zonesSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_zones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_indebtedPersons;
        private System.Windows.Forms.CheckBox chk_creditorPersons;
        private System.Windows.Forms.CheckBox chk_unIndebtedUnCreditorPersons;
        private System.Windows.Forms.GroupBox grp_visitorSet;
        private System.Windows.Forms.GroupBox grp_zonesSet;
        private System.Windows.Forms.CheckBox chk_filterByVisitor;
        private System.Windows.Forms.CheckBox chk_filterByZone;
        private System.Windows.Forms.ComboBox cbx_visitors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private ds_visitors ds_visitors;
        private System.Windows.Forms.BindingSource bs_visitors;
        private Novin.ds_visitorsTableAdapters.tbl_visitorsTableAdapter tbl_visitorsTableAdapter;
        private System.Windows.Forms.BindingSource bs_zones;
        private Novin.ds_visitorsTableAdapters.tbl_zonesTableAdapter tbl_zonesTableAdapter;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_newVisitor;
        private System.Windows.Forms.Button btn_newZone;
    }
}
