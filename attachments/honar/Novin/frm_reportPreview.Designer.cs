namespace Novin
{
    partial class frm_reportPreview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_modifyInvoice = new System.Windows.Forms.Button();
            this.tbx_total2 = new System.Windows.Forms.TextBox();
            this.tbx_total1 = new System.Windows.Forms.TextBox();
            this.tbx_total3 = new System.Windows.Forms.TextBox();
            this.tbx_detect = new System.Windows.Forms.TextBox();
            this.pnl_remainSet = new System.Windows.Forms.Panel();
            this.pnl_priorRemainSet = new System.Windows.Forms.Panel();
            this.tbx_priorDetect = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_prior3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_prior2 = new System.Windows.Forms.TextBox();
            this.tbx_prior1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_indebtedCreditor = new System.Windows.Forms.Panel();
            this.lbl_reportComment = new System.Windows.Forms.Label();
            this.ds_objectLessSell = new Novin.ds_objectLessSell();
            this.bs_objectLessSell = new System.Windows.Forms.BindingSource(this.components);
            this.sp_objectLessSellTableAdapter = new Novin.ds_objectLessSellTableAdapters.sp_objectLessSellTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_ = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_remainSet.SuspendLayout();
            this.pnl_priorRemainSet.SuspendLayout();
            this.pnl_indebtedCreditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectLessSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objectLessSell)).BeginInit();
            this.pnl_.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title1
            // 
            this.lbl_title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title1.Font = new System.Drawing.Font("2  Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_title1.Location = new System.Drawing.Point(12, 2);
            this.lbl_title1.Name = "lbl_title1";
            this.lbl_title1.Size = new System.Drawing.Size(797, 49);
            this.lbl_title1.TabIndex = 0;
            this.lbl_title1.Text = "شــرکت پخش بـهرامی";
            this.lbl_title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title2
            // 
            this.lbl_title2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title2.BackColor = System.Drawing.Color.White;
            this.lbl_title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_title2.Font = new System.Drawing.Font("2  Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_title2.ForeColor = System.Drawing.Color.Blue;
            this.lbl_title2.Location = new System.Drawing.Point(12, 51);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(798, 29);
            this.lbl_title2.TabIndex = 1;
            this.lbl_title2.Text = "دفــــتر روزنــــــامه";
            this.lbl_title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("2  Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(797, 283);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(421, 474);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(106, 23);
            this.btn_ok.TabIndex = 55;
            this.btn_ok.Text = "بستن";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Location = new System.Drawing.Point(688, 474);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(114, 23);
            this.btn_print.TabIndex = 56;
            this.btn_print.Text = "چــاپ";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_modifyInvoice
            // 
            this.btn_modifyInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modifyInvoice.Location = new System.Drawing.Point(533, 474);
            this.btn_modifyInvoice.Name = "btn_modifyInvoice";
            this.btn_modifyInvoice.Size = new System.Drawing.Size(149, 23);
            this.btn_modifyInvoice.TabIndex = 57;
            this.btn_modifyInvoice.Text = "اصلاح سند";
            this.btn_modifyInvoice.UseVisualStyleBackColor = true;
            this.btn_modifyInvoice.Click += new System.EventHandler(this.btn_modifyInvoice_Click);
            // 
            // tbx_total2
            // 
            this.tbx_total2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_total2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_total2.Location = new System.Drawing.Point(0, 7);
            this.tbx_total2.Name = "tbx_total2";
            this.tbx_total2.ReadOnly = true;
            this.tbx_total2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_total2.Size = new System.Drawing.Size(105, 21);
            this.tbx_total2.TabIndex = 59;
            this.tbx_total2.Text = "0";
            // 
            // tbx_total1
            // 
            this.tbx_total1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_total1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_total1.Location = new System.Drawing.Point(111, 7);
            this.tbx_total1.Name = "tbx_total1";
            this.tbx_total1.ReadOnly = true;
            this.tbx_total1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_total1.Size = new System.Drawing.Size(107, 21);
            this.tbx_total1.TabIndex = 58;
            this.tbx_total1.Text = "0";
            // 
            // tbx_total3
            // 
            this.tbx_total3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_total3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_total3.Location = new System.Drawing.Point(44, 4);
            this.tbx_total3.Name = "tbx_total3";
            this.tbx_total3.ReadOnly = true;
            this.tbx_total3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_total3.Size = new System.Drawing.Size(105, 21);
            this.tbx_total3.TabIndex = 60;
            this.tbx_total3.Text = "0";
            // 
            // tbx_detect
            // 
            this.tbx_detect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_detect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_detect.Location = new System.Drawing.Point(7, 4);
            this.tbx_detect.Name = "tbx_detect";
            this.tbx_detect.ReadOnly = true;
            this.tbx_detect.Size = new System.Drawing.Size(31, 21);
            this.tbx_detect.TabIndex = 61;
            this.tbx_detect.Text = "---";
            this.tbx_detect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_remainSet
            // 
            this.pnl_remainSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_remainSet.Controls.Add(this.tbx_detect);
            this.pnl_remainSet.Controls.Add(this.tbx_total3);
            this.pnl_remainSet.Location = new System.Drawing.Point(12, 434);
            this.pnl_remainSet.Name = "pnl_remainSet";
            this.pnl_remainSet.Size = new System.Drawing.Size(155, 35);
            this.pnl_remainSet.TabIndex = 62;
            // 
            // pnl_priorRemainSet
            // 
            this.pnl_priorRemainSet.Controls.Add(this.tbx_priorDetect);
            this.pnl_priorRemainSet.Controls.Add(this.label4);
            this.pnl_priorRemainSet.Controls.Add(this.tbx_prior3);
            this.pnl_priorRemainSet.Controls.Add(this.label3);
            this.pnl_priorRemainSet.Location = new System.Drawing.Point(12, 83);
            this.pnl_priorRemainSet.Name = "pnl_priorRemainSet";
            this.pnl_priorRemainSet.Size = new System.Drawing.Size(155, 49);
            this.pnl_priorRemainSet.TabIndex = 65;
            // 
            // tbx_priorDetect
            // 
            this.tbx_priorDetect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_priorDetect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_priorDetect.Location = new System.Drawing.Point(7, 25);
            this.tbx_priorDetect.Name = "tbx_priorDetect";
            this.tbx_priorDetect.ReadOnly = true;
            this.tbx_priorDetect.Size = new System.Drawing.Size(31, 21);
            this.tbx_priorDetect.TabIndex = 61;
            this.tbx_priorDetect.Text = "---";
            this.tbx_priorDetect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "تشخیص";
            // 
            // tbx_prior3
            // 
            this.tbx_prior3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_prior3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_prior3.Location = new System.Drawing.Point(44, 25);
            this.tbx_prior3.Name = "tbx_prior3";
            this.tbx_prior3.ReadOnly = true;
            this.tbx_prior3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_prior3.Size = new System.Drawing.Size(105, 21);
            this.tbx_prior3.TabIndex = 60;
            this.tbx_prior3.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "بـــاقیمانده";
            // 
            // tbx_prior2
            // 
            this.tbx_prior2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_prior2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_prior2.Location = new System.Drawing.Point(7, 24);
            this.tbx_prior2.Name = "tbx_prior2";
            this.tbx_prior2.ReadOnly = true;
            this.tbx_prior2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_prior2.Size = new System.Drawing.Size(105, 21);
            this.tbx_prior2.TabIndex = 64;
            this.tbx_prior2.Text = "0";
            // 
            // tbx_prior1
            // 
            this.tbx_prior1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_prior1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_prior1.Location = new System.Drawing.Point(118, 24);
            this.tbx_prior1.Name = "tbx_prior1";
            this.tbx_prior1.ReadOnly = true;
            this.tbx_prior1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_prior1.Size = new System.Drawing.Size(107, 21);
            this.tbx_prior1.TabIndex = 63;
            this.tbx_prior1.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "بـــدهکار";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "بــــستانکار";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "منقول از صفحه قبل :";
            // 
            // pnl_indebtedCreditor
            // 
            this.pnl_indebtedCreditor.Controls.Add(this.label5);
            this.pnl_indebtedCreditor.Controls.Add(this.label2);
            this.pnl_indebtedCreditor.Controls.Add(this.label1);
            this.pnl_indebtedCreditor.Controls.Add(this.tbx_prior2);
            this.pnl_indebtedCreditor.Controls.Add(this.tbx_prior1);
            this.pnl_indebtedCreditor.Location = new System.Drawing.Point(167, 83);
            this.pnl_indebtedCreditor.Name = "pnl_indebtedCreditor";
            this.pnl_indebtedCreditor.Size = new System.Drawing.Size(372, 62);
            this.pnl_indebtedCreditor.TabIndex = 71;
            // 
            // lbl_reportComment
            // 
            this.lbl_reportComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_reportComment.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_reportComment.Location = new System.Drawing.Point(545, 87);
            this.lbl_reportComment.Name = "lbl_reportComment";
            this.lbl_reportComment.Size = new System.Drawing.Size(257, 45);
            this.lbl_reportComment.TabIndex = 72;
            // 
            // ds_objectLessSell
            // 
            this.ds_objectLessSell.DataSetName = "ds_objectLessSell";
            this.ds_objectLessSell.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_objectLessSell
            // 
            this.bs_objectLessSell.DataMember = "sp_objectLessSell";
            this.bs_objectLessSell.DataSource = this.ds_objectLessSell;
            // 
            // sp_objectLessSellTableAdapter
            // 
            this.sp_objectLessSellTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "جمع";
            // 
            // pnl_
            // 
            this.pnl_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_.Controls.Add(this.label6);
            this.pnl_.Controls.Add(this.tbx_total2);
            this.pnl_.Controls.Add(this.tbx_total1);
            this.pnl_.Location = new System.Drawing.Point(167, 431);
            this.pnl_.Name = "pnl_";
            this.pnl_.Size = new System.Drawing.Size(256, 37);
            this.pnl_.TabIndex = 74;
            // 
            // frm_reportPreview
            // 
            this.ClientSize = new System.Drawing.Size(821, 509);
            this.Controls.Add(this.pnl_);
            this.Controls.Add(this.lbl_reportComment);
            this.Controls.Add(this.pnl_indebtedCreditor);
            this.Controls.Add(this.pnl_priorRemainSet);
            this.Controls.Add(this.pnl_remainSet);
            this.Controls.Add(this.btn_modifyInvoice);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_title2);
            this.Controls.Add(this.lbl_title1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "frm_reportPreview";
            this.Text = "";
            this.Load += new System.EventHandler(this.frm_reportPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_remainSet.ResumeLayout(false);
            this.pnl_remainSet.PerformLayout();
            this.pnl_priorRemainSet.ResumeLayout(false);
            this.pnl_priorRemainSet.PerformLayout();
            this.pnl_indebtedCreditor.ResumeLayout(false);
            this.pnl_indebtedCreditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_objectLessSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objectLessSell)).EndInit();
            this.pnl_.ResumeLayout(false);
            this.pnl_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title1;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_modifyInvoice;
        private System.Windows.Forms.TextBox tbx_total2;
        private System.Windows.Forms.TextBox tbx_total1;
        private System.Windows.Forms.TextBox tbx_total3;
        private System.Windows.Forms.TextBox tbx_detect;
        private System.Windows.Forms.Panel pnl_remainSet;
        private System.Windows.Forms.Panel pnl_priorRemainSet;
        private System.Windows.Forms.TextBox tbx_priorDetect;
        private System.Windows.Forms.TextBox tbx_prior3;
        private System.Windows.Forms.TextBox tbx_prior2;
        private System.Windows.Forms.TextBox tbx_prior1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_indebtedCreditor;
        public System.Windows.Forms.Label lbl_reportComment;
        private ds_objectLessSell ds_objectLessSell;
        private System.Windows.Forms.BindingSource bs_objectLessSell;
        private Novin.ds_objectLessSellTableAdapters.sp_objectLessSellTableAdapter sp_objectLessSellTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_;
    }
}
