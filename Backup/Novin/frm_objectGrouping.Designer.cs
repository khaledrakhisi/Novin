namespace Novin
{
    partial class frm_objectGrouping
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_selectedNodeText = new System.Windows.Forms.TextBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_deletePerson = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_newSlave = new System.Windows.Forms.Button();
            this.btn_newMaster = new System.Windows.Forms.Button();
            this.ds_objectGrouping = new Novin.ds_objectGrouping();
            this.bs_masterGroups = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_masterGroupsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_masterGroupsTableAdapter();
            this.tbl_slaveGroupsTableAdapter = new Novin.ds_objectGroupingTableAdapters.tbl_slaveGroupsTableAdapter();
            this.bs_slaveGroups = new System.Windows.Forms.BindingSource(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_masterGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_slaveGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "عنوان :";
            // 
            // tbx_selectedNodeText
            // 
            this.tbx_selectedNodeText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_selectedNodeText.Location = new System.Drawing.Point(184, 104);
            this.tbx_selectedNodeText.Name = "tbx_selectedNodeText";
            this.tbx_selectedNodeText.Size = new System.Drawing.Size(166, 23);
            this.tbx_selectedNodeText.TabIndex = 15;
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.Color.Azure;
            this.btn_modify.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_modify.ForeColor = System.Drawing.Color.Blue;
            this.btn_modify.Location = new System.Drawing.Point(113, 99);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(65, 30);
            this.btn_modify.TabIndex = 14;
            this.btn_modify.Text = "ثبت";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_deletePerson
            // 
            this.btn_deletePerson.BackColor = System.Drawing.Color.Azure;
            this.btn_deletePerson.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deletePerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deletePerson.Location = new System.Drawing.Point(42, 99);
            this.btn_deletePerson.Name = "btn_deletePerson";
            this.btn_deletePerson.Size = new System.Drawing.Size(65, 30);
            this.btn_deletePerson.TabIndex = 11;
            this.btn_deletePerson.Text = "حذف";
            this.btn_deletePerson.UseVisualStyleBackColor = false;
            this.btn_deletePerson.Click += new System.EventHandler(this.btn_deletePerson_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(12, 133);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(414, 198);
            this.treeView1.TabIndex = 13;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_newSlave);
            this.groupBox2.Controls.Add(this.btn_newMaster);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 66);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "";
            this.groupBox2.Text = "گروه ها";
            // 
            // btn_newSlave
            // 
            this.btn_newSlave.BackColor = System.Drawing.Color.Azure;
            this.btn_newSlave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newSlave.ForeColor = System.Drawing.Color.Green;
            this.btn_newSlave.Location = new System.Drawing.Point(81, 21);
            this.btn_newSlave.Name = "btn_newSlave";
            this.btn_newSlave.Size = new System.Drawing.Size(123, 30);
            this.btn_newSlave.TabIndex = 1;
            this.btn_newSlave.Text = "* گروه فرعی جدید";
            this.btn_newSlave.UseVisualStyleBackColor = false;
            this.btn_newSlave.Click += new System.EventHandler(this.btn_newSlave_Click);
            // 
            // btn_newMaster
            // 
            this.btn_newMaster.BackColor = System.Drawing.Color.Azure;
            this.btn_newMaster.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newMaster.ForeColor = System.Drawing.Color.Green;
            this.btn_newMaster.Location = new System.Drawing.Point(210, 21);
            this.btn_newMaster.Name = "btn_newMaster";
            this.btn_newMaster.Size = new System.Drawing.Size(123, 30);
            this.btn_newMaster.TabIndex = 0;
            this.btn_newMaster.Text = "* گروه اصلی جدید";
            this.btn_newMaster.UseVisualStyleBackColor = false;
            this.btn_newMaster.Click += new System.EventHandler(this.btn_newMaster_Click);
            // 
            // ds_objectGrouping
            // 
            this.ds_objectGrouping.DataSetName = "ds_objectGrouping";
            this.ds_objectGrouping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_masterGroups
            // 
            this.bs_masterGroups.DataMember = "tbl_masterGroups";
            this.bs_masterGroups.DataSource = this.ds_objectGrouping;
            // 
            // tbl_masterGroupsTableAdapter
            // 
            this.tbl_masterGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_slaveGroupsTableAdapter
            // 
            this.tbl_slaveGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // bs_slaveGroups
            // 
            this.bs_slaveGroups.DataMember = "tbl_slaveGroups";
            this.bs_slaveGroups.DataSource = this.ds_objectGrouping;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(23, 337);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(102, 24);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "بستن";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(237, 337);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(173, 24);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "تـــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // frm_objectGrouping
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(438, 373);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbx_selectedNodeText);
            this.Controls.Add(this.btn_deletePerson);
            this.Controls.Add(this.btn_modify);
            this.KeyPreview = true;
            this.Name = "frm_objectGrouping";
            this.Text = "گروه بندی کـــالا ها";
            this.Load += new System.EventHandler(this.frm_objectGrouping_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_objectGrouping_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectGrouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_masterGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_slaveGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_selectedNodeText;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_deletePerson;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_newSlave;
        private System.Windows.Forms.Button btn_newMaster;
        private ds_objectGrouping ds_objectGrouping;
        private System.Windows.Forms.BindingSource bs_masterGroups;
        private Novin.ds_objectGroupingTableAdapters.tbl_masterGroupsTableAdapter tbl_masterGroupsTableAdapter;
        private Novin.ds_objectGroupingTableAdapters.tbl_slaveGroupsTableAdapter tbl_slaveGroupsTableAdapter;
        private System.Windows.Forms.BindingSource bs_slaveGroups;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ok;

    }
}
