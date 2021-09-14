namespace Novin
{
    partial class frm_objectEntityReport
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
            this.ds_objectGrouping = new Novin.ds_objectGrouping();
            this.bs_slaveGroups = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_slaveGroupsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_slaveGroupsTableAdapter();
            this.bs_objects = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_objectsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter();
            this.gbx_TypeReport = new System.Windows.Forms.GroupBox();
            this.chk_showAllObject = new System.Windows.Forms.CheckBox();
            this.rdu_object = new System.Windows.Forms.RadioButton();
            this.rdu_slaveGroups = new System.Windows.Forms.RadioButton();
            this.pnl_slaveGroups = new System.Windows.Forms.Panel();
            this.tbx_SlaveGroupsID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnl_Object = new System.Windows.Forms.Panel();
            this.tbx_objectID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_slaveGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objects)).BeginInit();
            this.gbx_TypeReport.SuspendLayout();
            this.pnl_slaveGroups.SuspendLayout();
            this.pnl_Object.SuspendLayout();
            this.SuspendLayout();
            // 
            // ds_objectGrouping
            // 
            this.ds_objectGrouping.DataSetName = "ds_objectGrouping";
            this.ds_objectGrouping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_slaveGroups
            // 
            this.bs_slaveGroups.DataMember = "tbl_slaveGroups";
            this.bs_slaveGroups.DataSource = this.ds_objectGrouping;
            // 
            // tbl_slaveGroupsTableAdapter
            // 
            this.tbl_slaveGroupsTableAdapter.ClearBeforeFill = true;
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
            // gbx_TypeReport
            // 
            this.gbx_TypeReport.Controls.Add(this.rdu_object);
            this.gbx_TypeReport.Controls.Add(this.rdu_slaveGroups);
            this.gbx_TypeReport.Location = new System.Drawing.Point(7, 12);
            this.gbx_TypeReport.Name = "gbx_TypeReport";
            this.gbx_TypeReport.Size = new System.Drawing.Size(464, 65);
            this.gbx_TypeReport.TabIndex = 3;
            this.gbx_TypeReport.TabStop = false;
            this.gbx_TypeReport.Text = "نوع گزارش";
            // 
            // chk_showAllObject
            // 
            this.chk_showAllObject.AutoSize = true;
            this.chk_showAllObject.Location = new System.Drawing.Point(384, 12);
            this.chk_showAllObject.Name = "chk_showAllObject";
            this.chk_showAllObject.Size = new System.Drawing.Size(15, 14);
            this.chk_showAllObject.TabIndex = 4;
            this.toolTip1.SetToolTip(this.chk_showAllObject, " نمایش تمام کالاها ");
            this.chk_showAllObject.UseVisualStyleBackColor = true;
            this.chk_showAllObject.CheckedChanged += new System.EventHandler(this.chk_showAllObject_CheckedChanged);
            // 
            // rdu_object
            // 
            this.rdu_object.AutoSize = true;
            this.rdu_object.Location = new System.Drawing.Point(182, 32);
            this.rdu_object.Name = "rdu_object";
            this.rdu_object.Size = new System.Drawing.Size(50, 17);
            this.rdu_object.TabIndex = 3;
            this.rdu_object.Text = "کــــلا";
            this.rdu_object.UseVisualStyleBackColor = true;
            this.rdu_object.CheckedChanged += new System.EventHandler(this.rdu_object_CheckedChanged);
            // 
            // rdu_slaveGroups
            // 
            this.rdu_slaveGroups.AutoSize = true;
            this.rdu_slaveGroups.Checked = true;
            this.rdu_slaveGroups.Location = new System.Drawing.Point(368, 32);
            this.rdu_slaveGroups.Name = "rdu_slaveGroups";
            this.rdu_slaveGroups.Size = new System.Drawing.Size(76, 17);
            this.rdu_slaveGroups.TabIndex = 2;
            this.rdu_slaveGroups.TabStop = true;
            this.rdu_slaveGroups.Text = "گروه فرعی";
            this.rdu_slaveGroups.UseVisualStyleBackColor = true;
            this.rdu_slaveGroups.CheckedChanged += new System.EventHandler(this.rdu_slaveGroups_CheckedChanged);
            // 
            // pnl_slaveGroups
            // 
            this.pnl_slaveGroups.Controls.Add(this.tbx_SlaveGroupsID);
            this.pnl_slaveGroups.Controls.Add(this.label1);
            this.pnl_slaveGroups.Controls.Add(this.comboBox1);
            this.pnl_slaveGroups.Location = new System.Drawing.Point(245, 83);
            this.pnl_slaveGroups.Name = "pnl_slaveGroups";
            this.pnl_slaveGroups.Size = new System.Drawing.Size(226, 72);
            this.pnl_slaveGroups.TabIndex = 6;
            // 
            // tbx_SlaveGroupsID
            // 
            this.tbx_SlaveGroupsID.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_SlaveGroupsID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_slaveGroups, "slaveGroup_id", true));
            this.tbx_SlaveGroupsID.Location = new System.Drawing.Point(81, 8);
            this.tbx_SlaveGroupsID.Name = "tbx_SlaveGroupsID";
            this.tbx_SlaveGroupsID.Size = new System.Drawing.Size(73, 21);
            this.tbx_SlaveGroupsID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "گروه فرعی";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bs_slaveGroups;
            this.comboBox1.DisplayMember = "slaveGroup_title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "slaveGroup_id";
            // 
            // pnl_Object
            // 
            this.pnl_Object.Controls.Add(this.tbx_objectID);
            this.pnl_Object.Controls.Add(this.label2);
            this.pnl_Object.Controls.Add(this.comboBox2);
            this.pnl_Object.Enabled = false;
            this.pnl_Object.Location = new System.Drawing.Point(7, 83);
            this.pnl_Object.Name = "pnl_Object";
            this.pnl_Object.Size = new System.Drawing.Size(232, 72);
            this.pnl_Object.TabIndex = 7;
            // 
            // tbx_objectID
            // 
            this.tbx_objectID.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_objectID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_objects, "object_id", true));
            this.tbx_objectID.Location = new System.Drawing.Point(106, 8);
            this.tbx_objectID.Name = "tbx_objectID";
            this.tbx_objectID.Size = new System.Drawing.Size(73, 21);
            this.tbx_objectID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "نام کالا";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.bs_objects;
            this.comboBox2.DisplayMember = "object_title";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "object_id";
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(299, 187);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 57;
            this.btn_ok.Text = "تــــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(218, 187);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 58;
            this.btn_cancel.Text = "انــــصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_objectEntityReport
            // 
            this.ClientSize = new System.Drawing.Size(480, 222);
            this.Controls.Add(this.chk_showAllObject);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pnl_Object);
            this.Controls.Add(this.pnl_slaveGroups);
            this.Controls.Add(this.gbx_TypeReport);
            this.Name = "frm_objectEntityReport";
            this.Text = "   گــــزارش کــــالا";
            this.Load += new System.EventHandler(this.frm_objectEntityReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_slaveGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objects)).EndInit();
            this.gbx_TypeReport.ResumeLayout(false);
            this.gbx_TypeReport.PerformLayout();
            this.pnl_slaveGroups.ResumeLayout(false);
            this.pnl_slaveGroups.PerformLayout();
            this.pnl_Object.ResumeLayout(false);
            this.pnl_Object.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ds_objectGrouping ds_objectGrouping;
        private System.Windows.Forms.BindingSource bs_slaveGroups;
        private Novin.ds_objectGroupingTableAdapters.tbl_slaveGroupsTableAdapter tbl_slaveGroupsTableAdapter;
        private System.Windows.Forms.BindingSource bs_objects;
        private Novin.ds_objectGroupingTableAdapters.tbl_objectsTableAdapter tbl_objectsTableAdapter;
        private System.Windows.Forms.GroupBox gbx_TypeReport;
        private System.Windows.Forms.RadioButton rdu_object;
        private System.Windows.Forms.RadioButton rdu_slaveGroups;
        private System.Windows.Forms.Panel pnl_slaveGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnl_Object;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tbx_SlaveGroupsID;
        private System.Windows.Forms.TextBox tbx_objectID;
        private System.Windows.Forms.CheckBox chk_showAllObject;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
