namespace Novin
{
    partial class frm_accountingChapters
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ds_accounting = new Novin.ds_accounting();
            this.bs_KOLs = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KOLsTableAdapter = new Novin.ds_accountingTableAdapters.tbl_KOLsTableAdapter();
            this.bs_MOEENs = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MOEENsTableAdapter = new Novin.ds_accountingTableAdapters.tbl_MOEENsTableAdapter();
            this.bs_TAFs = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TAFsTableAdapter = new Novin.ds_accountingTableAdapters.tbl_TAFsTableAdapter();
            this.grp_actionsSet = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_chapterType = new System.Windows.Forms.ComboBox();
            this.pnl_chapterPropsSet = new System.Windows.Forms.Panel();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_KOLs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MOEENs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TAFs)).BeginInit();
            this.grp_actionsSet.SuspendLayout();
            this.pnl_chapterPropsSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(27, 152);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(414, 269);
            this.treeView1.TabIndex = 14;
            // 
            // ds_accounting
            // 
            this.ds_accounting.DataSetName = "ds_accounting";
            this.ds_accounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_KOLs
            // 
            this.bs_KOLs.DataMember = "tbl_KOLs";
            this.bs_KOLs.DataSource = this.ds_accounting;
            // 
            // tbl_KOLsTableAdapter
            // 
            this.tbl_KOLsTableAdapter.ClearBeforeFill = true;
            // 
            // bs_MOEENs
            // 
            this.bs_MOEENs.DataMember = "tbl_MOEENs";
            this.bs_MOEENs.DataSource = this.ds_accounting;
            // 
            // tbl_MOEENsTableAdapter
            // 
            this.tbl_MOEENsTableAdapter.ClearBeforeFill = true;
            // 
            // bs_TAFs
            // 
            this.bs_TAFs.DataMember = "tbl_TAFs";
            this.bs_TAFs.DataSource = this.ds_accounting;
            // 
            // tbl_TAFsTableAdapter
            // 
            this.tbl_TAFsTableAdapter.ClearBeforeFill = true;
            // 
            // grp_actionsSet
            // 
            this.grp_actionsSet.BackColor = System.Drawing.Color.Transparent;
            this.grp_actionsSet.Controls.Add(this.btn_save);
            this.grp_actionsSet.Controls.Add(this.btn_delete);
            this.grp_actionsSet.Controls.Add(this.btn_edit);
            this.grp_actionsSet.Controls.Add(this.btn_add);
            this.grp_actionsSet.Location = new System.Drawing.Point(38, 12);
            this.grp_actionsSet.Name = "grp_actionsSet";
            this.grp_actionsSet.Size = new System.Drawing.Size(393, 44);
            this.grp_actionsSet.TabIndex = 39;
            this.grp_actionsSet.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Azure;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_save.Location = new System.Drawing.Point(16, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "ثبت";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(108, 11);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "حذف ";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Azure;
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.Location = new System.Drawing.Point(200, 11);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(73, 23);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "تغییرنام";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Azure;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.ForeColor = System.Drawing.Color.Green;
            this.btn_add.Location = new System.Drawing.Point(275, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "*سرفصل جدید";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "سرفصل های حسابداری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "ماهیت :";
            // 
            // cbx_chapterType
            // 
            this.cbx_chapterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_chapterType.FormattingEnabled = true;
            this.cbx_chapterType.Items.AddRange(new object[] {
            "بدهکار",
            "بستانکار",
            "بدهکار / بستانکار"});
            this.cbx_chapterType.Location = new System.Drawing.Point(196, 3);
            this.cbx_chapterType.Name = "cbx_chapterType";
            this.cbx_chapterType.Size = new System.Drawing.Size(141, 21);
            this.cbx_chapterType.TabIndex = 42;
            // 
            // pnl_chapterPropsSet
            // 
            this.pnl_chapterPropsSet.Controls.Add(this.cbx_chapterType);
            this.pnl_chapterPropsSet.Controls.Add(this.label2);
            this.pnl_chapterPropsSet.Location = new System.Drawing.Point(30, 64);
            this.pnl_chapterPropsSet.Name = "pnl_chapterPropsSet";
            this.pnl_chapterPropsSet.Size = new System.Drawing.Size(409, 58);
            this.pnl_chapterPropsSet.TabIndex = 43;
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.AutoSize = true;
            this.lbl_prompt.ForeColor = System.Drawing.Color.Red;
            this.lbl_prompt.Location = new System.Drawing.Point(31, 84);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(0, 13);
            this.lbl_prompt.TabIndex = 44;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(210, 429);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(226, 22);
            this.btn_ok.TabIndex = 45;
            this.btn_ok.Text = "تـــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(31, 429);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(133, 22);
            this.btn_close.TabIndex = 46;
            this.btn_close.Text = "بستن";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // frm_accountingChapters
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(469, 463);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_prompt);
            this.Controls.Add(this.pnl_chapterPropsSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_actionsSet);
            this.Controls.Add(this.treeView1);
            this.Name = "frm_accountingChapters";
            this.Text = "   سرفصل های حسابداری";
            this.Load += new System.EventHandler(this.frm_accountingChapters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_KOLs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MOEENs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TAFs)).EndInit();
            this.grp_actionsSet.ResumeLayout(false);
            this.pnl_chapterPropsSet.ResumeLayout(false);
            this.pnl_chapterPropsSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private ds_accounting ds_accounting;
        private System.Windows.Forms.BindingSource bs_KOLs;
        private Novin.ds_accountingTableAdapters.tbl_KOLsTableAdapter tbl_KOLsTableAdapter;
        private System.Windows.Forms.BindingSource bs_MOEENs;
        private Novin.ds_accountingTableAdapters.tbl_MOEENsTableAdapter tbl_MOEENsTableAdapter;
        private System.Windows.Forms.BindingSource bs_TAFs;
        private Novin.ds_accountingTableAdapters.tbl_TAFsTableAdapter tbl_TAFsTableAdapter;
        private System.Windows.Forms.GroupBox grp_actionsSet;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_chapterType;
        private System.Windows.Forms.Panel pnl_chapterPropsSet;
        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
    }
}