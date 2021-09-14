namespace Novin
{
    partial class frm_modify
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
            this.rdu_invoiceModification = new System.Windows.Forms.RadioButton();
            this.rdu_accDocModification = new System.Windows.Forms.RadioButton();
            this.cbx_invoiceType = new System.Windows.Forms.ComboBox();
            this.tbx_accDocNO = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_invoiceControls = new System.Windows.Forms.Panel();
            this.tbx_invoiceNO = new System.Windows.Forms.TextBox();
            this.pnl_invoiceControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdu_invoiceModification
            // 
            this.rdu_invoiceModification.AutoSize = true;
            this.rdu_invoiceModification.Checked = true;
            this.rdu_invoiceModification.Location = new System.Drawing.Point(286, 15);
            this.rdu_invoiceModification.Name = "rdu_invoiceModification";
            this.rdu_invoiceModification.Size = new System.Drawing.Size(96, 17);
            this.rdu_invoiceModification.TabIndex = 0;
            this.rdu_invoiceModification.TabStop = true;
            this.rdu_invoiceModification.Text = "اصلاح فــــاکتور ";
            this.rdu_invoiceModification.UseVisualStyleBackColor = true;
            this.rdu_invoiceModification.CheckedChanged += new System.EventHandler(this.rdu_invoiceModification_CheckedChanged);
            // 
            // rdu_accDocModification
            // 
            this.rdu_accDocModification.AutoSize = true;
            this.rdu_accDocModification.Location = new System.Drawing.Point(306, 51);
            this.rdu_accDocModification.Name = "rdu_accDocModification";
            this.rdu_accDocModification.Size = new System.Drawing.Size(76, 17);
            this.rdu_accDocModification.TabIndex = 1;
            this.rdu_accDocModification.TabStop = true;
            this.rdu_accDocModification.Text = "اصلاح سند";
            this.rdu_accDocModification.UseVisualStyleBackColor = true;
            this.rdu_accDocModification.CheckedChanged += new System.EventHandler(this.rdu_accDocModification_CheckedChanged);
            // 
            // cbx_invoiceType
            // 
            this.cbx_invoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_invoiceType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_invoiceType.FormattingEnabled = true;
            this.cbx_invoiceType.Items.AddRange(new object[] {
            "خــرید",
            "فــــروش",
            "-----",
            "برگشت از خرید",
            "برگشت از فروش",
            "-----",
            "ضایعات",
            "-----",
            "امــــانی"});
            this.cbx_invoiceType.Location = new System.Drawing.Point(3, 11);
            this.cbx_invoiceType.Name = "cbx_invoiceType";
            this.cbx_invoiceType.Size = new System.Drawing.Size(123, 21);
            this.cbx_invoiceType.TabIndex = 3;
            // 
            // tbx_accDocNO
            // 
            this.tbx_accDocNO.Enabled = false;
            this.tbx_accDocNO.Location = new System.Drawing.Point(144, 47);
            this.tbx_accDocNO.Name = "tbx_accDocNO";
            this.tbx_accDocNO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_accDocNO.Size = new System.Drawing.Size(115, 21);
            this.tbx_accDocNO.TabIndex = 4;
            this.tbx_accDocNO.TextChanged += new System.EventHandler(this.tbx_accDocNO_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(219, 95);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 53;
            this.btn_ok.Text = "تــــائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(138, 95);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 54;
            this.btn_cancel.Text = "انــــصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // pnl_invoiceControls
            // 
            this.pnl_invoiceControls.Controls.Add(this.tbx_invoiceNO);
            this.pnl_invoiceControls.Controls.Add(this.cbx_invoiceType);
            this.pnl_invoiceControls.Location = new System.Drawing.Point(12, 3);
            this.pnl_invoiceControls.Name = "pnl_invoiceControls";
            this.pnl_invoiceControls.Size = new System.Drawing.Size(262, 38);
            this.pnl_invoiceControls.TabIndex = 55;
            // 
            // tbx_invoiceNO
            // 
            this.tbx_invoiceNO.Location = new System.Drawing.Point(132, 11);
            this.tbx_invoiceNO.Name = "tbx_invoiceNO";
            this.tbx_invoiceNO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_invoiceNO.Size = new System.Drawing.Size(115, 21);
            this.tbx_invoiceNO.TabIndex = 4;
            this.tbx_invoiceNO.TextChanged += new System.EventHandler(this.tbx_invoiceNO_TextChanged);
            // 
            // frm_modify
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(394, 127);
            this.Controls.Add(this.pnl_invoiceControls);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tbx_accDocNO);
            this.Controls.Add(this.rdu_accDocModification);
            this.Controls.Add(this.rdu_invoiceModification);
            this.Name = "frm_modify";
            this.Text = "اصــــلاح فاکتور یا سند";
            this.Load += new System.EventHandler(this.frm_modify_Load);
            this.pnl_invoiceControls.ResumeLayout(false);
            this.pnl_invoiceControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdu_invoiceModification;
        private System.Windows.Forms.RadioButton rdu_accDocModification;
        private System.Windows.Forms.ComboBox cbx_invoiceType;
        private System.Windows.Forms.TextBox tbx_accDocNO;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pnl_invoiceControls;
        private System.Windows.Forms.TextBox tbx_invoiceNO;
    }
}
