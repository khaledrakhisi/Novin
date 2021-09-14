namespace Novin
{
    partial class frm_issuseAccDoc
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
            this.mTbx_accDocDate = new System.Windows.Forms.MaskedTextBox();
            this.num_accDocNO = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_personHisory = new System.Windows.Forms.CheckBox();
            this.btn_showPersonLedger = new System.Windows.Forms.Button();
            this.lbl_detect = new System.Windows.Forms.Label();
            this.tbx_personRemainMoney = new System.Windows.Forms.TextBox();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.bs_persons = new System.Windows.Forms.BindingSource(this.components);
            this.ds_persons = new Novin.ds_persons();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbx_personID = new System.Windows.Forms.TextBox();
            this.tbx_personFamilyAndName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_personDiscountPercent = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.tbx_indebtedMoney = new System.Windows.Forms.TextBox();
            this.tbx_discountMoney = new System.Windows.Forms.TextBox();
            this.tbx_cashMoney = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_useCheque = new System.Windows.Forms.Button();
            this.btn_newCheque = new System.Windows.Forms.Button();
            this.tbx_uesedChequesMoney = new System.Windows.Forms.TextBox();
            this.tbx_chequesMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx_remainMoney = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbx_totalPaidMoney = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_totalMoney = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tbl_personsTableAdapter = new Novin.ds_personsTableAdapters.tbl_personsTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbx_transportPrice = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pnl_transferMoneySet = new System.Windows.Forms.Panel();
            this.grp_personHistorySet = new System.Windows.Forms.GroupBox();
            this.pic_personFace = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_showPersonForm = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.tbx_creditCeil = new System.Windows.Forms.TextBox();
            this.tbx_personComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_accDocNO)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_personDiscountPercent)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_transferMoneySet.SuspendLayout();
            this.grp_personHistorySet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personFace)).BeginInit();
            this.SuspendLayout();
            // 
            // mTbx_accDocDate
            // 
            this.mTbx_accDocDate.AllowDrop = true;
            this.mTbx_accDocDate.AllowPromptAsInput = false;
            this.mTbx_accDocDate.Location = new System.Drawing.Point(268, 11);
            this.mTbx_accDocDate.Mask = "0000/00/00";
            this.mTbx_accDocDate.Name = "mTbx_accDocDate";
            this.mTbx_accDocDate.PromptChar = ' ';
            this.mTbx_accDocDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_accDocDate.Size = new System.Drawing.Size(69, 21);
            this.mTbx_accDocDate.TabIndex = 2;
            // 
            // num_accDocNO
            // 
            this.num_accDocNO.Location = new System.Drawing.Point(21, 12);
            this.num_accDocNO.Name = "num_accDocNO";
            this.num_accDocNO.ReadOnly = true;
            this.num_accDocNO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_accDocNO.Size = new System.Drawing.Size(69, 21);
            this.num_accDocNO.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "شماره سند :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "تاریخ سند :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_personHisory);
            this.groupBox1.Controls.Add(this.btn_showPersonLedger);
            this.groupBox1.Controls.Add(this.lbl_detect);
            this.groupBox1.Controls.Add(this.tbx_personRemainMoney);
            this.groupBox1.Controls.Add(this.tbx_phone);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.tbx_personID);
            this.groupBox1.Controls.Add(this.tbx_personFamilyAndName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 109);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // chk_personHisory
            // 
            this.chk_personHisory.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_personHisory.Location = new System.Drawing.Point(9, 80);
            this.chk_personHisory.Name = "chk_personHisory";
            this.chk_personHisory.Size = new System.Drawing.Size(186, 23);
            this.chk_personHisory.TabIndex = 57;
            this.chk_personHisory.Text = "سابقه طرف حساب (Ctrl+Left)";
            this.chk_personHisory.UseVisualStyleBackColor = true;
            this.chk_personHisory.CheckedChanged += new System.EventHandler(this.chk_personHisory_CheckedChanged);
            // 
            // btn_showPersonLedger
            // 
            this.btn_showPersonLedger.Location = new System.Drawing.Point(206, 80);
            this.btn_showPersonLedger.Name = "btn_showPersonLedger";
            this.btn_showPersonLedger.Size = new System.Drawing.Size(186, 23);
            this.btn_showPersonLedger.TabIndex = 54;
            this.btn_showPersonLedger.Text = "معین طرف حساب (Ctrl+Right)";
            this.btn_showPersonLedger.UseVisualStyleBackColor = true;
            this.btn_showPersonLedger.Click += new System.EventHandler(this.btn_showPersonLedger_Click);
            // 
            // lbl_detect
            // 
            this.lbl_detect.BackColor = System.Drawing.Color.Red;
            this.lbl_detect.ForeColor = System.Drawing.Color.White;
            this.lbl_detect.Location = new System.Drawing.Point(9, 46);
            this.lbl_detect.Name = "lbl_detect";
            this.lbl_detect.Size = new System.Drawing.Size(24, 13);
            this.lbl_detect.TabIndex = 53;
            this.lbl_detect.Text = "---";
            // 
            // tbx_personRemainMoney
            // 
            this.tbx_personRemainMoney.Location = new System.Drawing.Point(39, 42);
            this.tbx_personRemainMoney.Name = "tbx_personRemainMoney";
            this.tbx_personRemainMoney.ReadOnly = true;
            this.tbx_personRemainMoney.Size = new System.Drawing.Size(117, 21);
            this.tbx_personRemainMoney.TabIndex = 9;
            // 
            // tbx_phone
            // 
            this.tbx_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_phone", true));
            this.tbx_phone.Location = new System.Drawing.Point(39, 14);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.ReadOnly = true;
            this.tbx_phone.Size = new System.Drawing.Size(106, 21);
            this.tbx_phone.TabIndex = 8;
            // 
            // bs_persons
            // 
            this.bs_persons.DataMember = "tbl_persons";
            this.bs_persons.DataSource = this.ds_persons;
            // 
            // ds_persons
            // 
            this.ds_persons.DataSetName = "ds_persons";
            this.ds_persons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(151, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "تلفن :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(162, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "مانده :";
            // 
            // tbx_personID
            // 
            this.tbx_personID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_id", true));
            this.tbx_personID.Location = new System.Drawing.Point(243, 41);
            this.tbx_personID.Name = "tbx_personID";
            this.tbx_personID.ReadOnly = true;
            this.tbx_personID.Size = new System.Drawing.Size(67, 21);
            this.tbx_personID.TabIndex = 5;
            // 
            // tbx_personFamilyAndName
            // 
            this.tbx_personFamilyAndName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_familyAndName", true));
            this.tbx_personFamilyAndName.Location = new System.Drawing.Point(191, 14);
            this.tbx_personFamilyAndName.Name = "tbx_personFamilyAndName";
            this.tbx_personFamilyAndName.ReadOnly = true;
            this.tbx_personFamilyAndName.Size = new System.Drawing.Size(119, 21);
            this.tbx_personFamilyAndName.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "کد طرف حساب :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "طرف حساب :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_personDiscountPercent);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.tbx_indebtedMoney);
            this.groupBox2.Controls.Add(this.tbx_discountMoney);
            this.groupBox2.Controls.Add(this.tbx_cashMoney);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btn_useCheque);
            this.groupBox2.Controls.Add(this.btn_newCheque);
            this.groupBox2.Controls.Add(this.tbx_uesedChequesMoney);
            this.groupBox2.Controls.Add(this.tbx_chequesMoney);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(Ctrl+Space)";
            // 
            // num_personDiscountPercent
            // 
            this.num_personDiscountPercent.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs_persons, "person_discountPercent", true));
            this.num_personDiscountPercent.Location = new System.Drawing.Point(37, 88);
            this.num_personDiscountPercent.Name = "num_personDiscountPercent";
            this.num_personDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_personDiscountPercent.Size = new System.Drawing.Size(41, 21);
            this.num_personDiscountPercent.TabIndex = 18;
            this.num_personDiscountPercent.ValueChanged += new System.EventHandler(this.num_personDiscountPercent_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(80, 92);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 13);
            this.label26.TabIndex = 22;
            this.label26.Text = "%";
            // 
            // tbx_indebtedMoney
            // 
            this.tbx_indebtedMoney.Location = new System.Drawing.Point(134, 108);
            this.tbx_indebtedMoney.Name = "tbx_indebtedMoney";
            this.tbx_indebtedMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_indebtedMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_indebtedMoney.TabIndex = 4;
            this.tbx_indebtedMoney.Text = "0";
            this.tbx_indebtedMoney.TextChanged += new System.EventHandler(this.tbx_indebtedMoney_TextChanged);
            this.tbx_indebtedMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_indebtedMoney_KeyUp);
            this.tbx_indebtedMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_indebtedMoney_KeyPress);
            // 
            // tbx_discountMoney
            // 
            this.tbx_discountMoney.Location = new System.Drawing.Point(134, 84);
            this.tbx_discountMoney.Name = "tbx_discountMoney";
            this.tbx_discountMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_discountMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_discountMoney.TabIndex = 3;
            this.tbx_discountMoney.Text = "0";
            this.tbx_discountMoney.TextChanged += new System.EventHandler(this.tbx_discountMoney_TextChanged);
            this.tbx_discountMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_discountMoney_KeyUp);
            this.tbx_discountMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_discountMoney_KeyPress);
            // 
            // tbx_cashMoney
            // 
            this.tbx_cashMoney.Location = new System.Drawing.Point(134, 12);
            this.tbx_cashMoney.Name = "tbx_cashMoney";
            this.tbx_cashMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_cashMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_cashMoney.TabIndex = 0;
            this.tbx_cashMoney.Text = "0";
            this.tbx_cashMoney.TextChanged += new System.EventHandler(this.tbx_cashMoney_TextChanged);
            this.tbx_cashMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_cashMoney_KeyUp);
            this.tbx_cashMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_cashMoney_KeyPress_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(104, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "ریال";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "ریال";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(104, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "ریال";
            // 
            // btn_useCheque
            // 
            this.btn_useCheque.Location = new System.Drawing.Point(50, 60);
            this.btn_useCheque.Name = "btn_useCheque";
            this.btn_useCheque.Size = new System.Drawing.Size(75, 23);
            this.btn_useCheque.TabIndex = 6;
            this.btn_useCheque.Text = "خـــرج چک";
            this.btn_useCheque.UseVisualStyleBackColor = true;
            // 
            // btn_newCheque
            // 
            this.btn_newCheque.Location = new System.Drawing.Point(50, 34);
            this.btn_newCheque.Name = "btn_newCheque";
            this.btn_newCheque.Size = new System.Drawing.Size(75, 23);
            this.btn_newCheque.TabIndex = 5;
            this.btn_newCheque.Text = "چـــــک";
            this.btn_newCheque.UseVisualStyleBackColor = true;
            this.btn_newCheque.Click += new System.EventHandler(this.btn_newCheque_Click);
            // 
            // tbx_uesedChequesMoney
            // 
            this.tbx_uesedChequesMoney.Location = new System.Drawing.Point(134, 60);
            this.tbx_uesedChequesMoney.Name = "tbx_uesedChequesMoney";
            this.tbx_uesedChequesMoney.ReadOnly = true;
            this.tbx_uesedChequesMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_uesedChequesMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_uesedChequesMoney.TabIndex = 2;
            this.tbx_uesedChequesMoney.Text = "0";
            this.tbx_uesedChequesMoney.TextChanged += new System.EventHandler(this.tbx_uesedChequesMoney_TextChanged);
            // 
            // tbx_chequesMoney
            // 
            this.tbx_chequesMoney.Location = new System.Drawing.Point(134, 36);
            this.tbx_chequesMoney.Name = "tbx_chequesMoney";
            this.tbx_chequesMoney.ReadOnly = true;
            this.tbx_chequesMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_chequesMoney.Size = new System.Drawing.Size(196, 21);
            this.tbx_chequesMoney.TabIndex = 1;
            this.tbx_chequesMoney.Text = "0";
            this.tbx_chequesMoney.TextChanged += new System.EventHandler(this.tbx_chequesMoney_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "نسیه :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "تخفیف :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "خرج چک :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "چک :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "نقد :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.tbx_remainMoney);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbx_totalPaidMoney);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 69);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(89, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "ریال";
            // 
            // tbx_remainMoney
            // 
            this.tbx_remainMoney.Location = new System.Drawing.Point(119, 37);
            this.tbx_remainMoney.Name = "tbx_remainMoney";
            this.tbx_remainMoney.ReadOnly = true;
            this.tbx_remainMoney.Size = new System.Drawing.Size(187, 21);
            this.tbx_remainMoney.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "ریال";
            // 
            // tbx_totalPaidMoney
            // 
            this.tbx_totalPaidMoney.Location = new System.Drawing.Point(119, 14);
            this.tbx_totalPaidMoney.Name = "tbx_totalPaidMoney";
            this.tbx_totalPaidMoney.ReadOnly = true;
            this.tbx_totalPaidMoney.Size = new System.Drawing.Size(187, 21);
            this.tbx_totalPaidMoney.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "بــــاقیمانده :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "جمع :";
            // 
            // tbx_comment
            // 
            this.tbx_comment.Location = new System.Drawing.Point(26, 437);
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(316, 21);
            this.tbx_comment.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "تــــوضیحات :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "کل مبـــلغ :";
            // 
            // tbx_totalMoney
            // 
            this.tbx_totalMoney.Location = new System.Drawing.Point(118, 190);
            this.tbx_totalMoney.Name = "tbx_totalMoney";
            this.tbx_totalMoney.ReadOnly = true;
            this.tbx_totalMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_totalMoney.Size = new System.Drawing.Size(144, 21);
            this.tbx_totalMoney.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(88, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "ریال";
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(255, 475);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "تــــائید (Ctrl+Enter)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(21, 469);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(101, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "لغو (Esc)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tbl_personsTableAdapter
            // 
            this.tbl_personsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbx_transportPrice
            // 
            this.tbx_transportPrice.Location = new System.Drawing.Point(42, 2);
            this.tbx_transportPrice.Name = "tbx_transportPrice";
            this.tbx_transportPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_transportPrice.Size = new System.Drawing.Size(146, 21);
            this.tbx_transportPrice.TabIndex = 0;
            this.tbx_transportPrice.Text = "0";
            this.tbx_transportPrice.TextChanged += new System.EventHandler(this.tbx_transportPrice_TextChanged);
            this.tbx_transportPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_transportPrice_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 54;
            this.label22.Text = "ریال";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(201, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "هزینه بــــاربری :";
            // 
            // pnl_transferMoneySet
            // 
            this.pnl_transferMoneySet.Controls.Add(this.tbx_transportPrice);
            this.pnl_transferMoneySet.Controls.Add(this.label22);
            this.pnl_transferMoneySet.Controls.Add(this.label23);
            this.pnl_transferMoneySet.Location = new System.Drawing.Point(74, 152);
            this.pnl_transferMoneySet.Name = "pnl_transferMoneySet";
            this.pnl_transferMoneySet.Size = new System.Drawing.Size(299, 32);
            this.pnl_transferMoneySet.TabIndex = 0;
            // 
            // grp_personHistorySet
            // 
            this.grp_personHistorySet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grp_personHistorySet.Controls.Add(this.pic_personFace);
            this.grp_personHistorySet.Controls.Add(this.label25);
            this.grp_personHistorySet.Controls.Add(this.btn_showPersonForm);
            this.grp_personHistorySet.Controls.Add(this.label24);
            this.grp_personHistorySet.Controls.Add(this.tbx_creditCeil);
            this.grp_personHistorySet.Controls.Add(this.tbx_personComment);
            this.grp_personHistorySet.Location = new System.Drawing.Point(12, 152);
            this.grp_personHistorySet.Name = "grp_personHistorySet";
            this.grp_personHistorySet.Size = new System.Drawing.Size(406, 310);
            this.grp_personHistorySet.TabIndex = 4;
            this.grp_personHistorySet.TabStop = false;
            this.grp_personHistorySet.Text = "سابقه طرف حساب";
            this.grp_personHistorySet.Visible = false;
            // 
            // pic_personFace
            // 
            this.pic_personFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_personFace.Location = new System.Drawing.Point(14, 45);
            this.pic_personFace.Margin = new System.Windows.Forms.Padding(2);
            this.pic_personFace.Name = "pic_personFace";
            this.pic_personFace.Size = new System.Drawing.Size(87, 81);
            this.pic_personFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_personFace.TabIndex = 40;
            this.pic_personFace.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(232, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(153, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "توضیحاتی در مورد طرف حساب :";
            // 
            // btn_showPersonForm
            // 
            this.btn_showPersonForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_showPersonForm.Location = new System.Drawing.Point(150, 262);
            this.btn_showPersonForm.Name = "btn_showPersonForm";
            this.btn_showPersonForm.Size = new System.Drawing.Size(34, 23);
            this.btn_showPersonForm.TabIndex = 38;
            this.btn_showPersonForm.Text = "...";
            this.btn_showPersonForm.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(326, 266);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "حــد اعــتبار :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_creditCeil
            // 
            this.tbx_creditCeil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_creditCeil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_creditCeil", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.tbx_creditCeil.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_creditCeil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbx_creditCeil.Location = new System.Drawing.Point(189, 263);
            this.tbx_creditCeil.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_creditCeil.Name = "tbx_creditCeil";
            this.tbx_creditCeil.ReadOnly = true;
            this.tbx_creditCeil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_creditCeil.Size = new System.Drawing.Size(133, 22);
            this.tbx_creditCeil.TabIndex = 36;
            this.tbx_creditCeil.Text = "0";
            // 
            // tbx_personComment
            // 
            this.tbx_personComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_personComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_persons, "person_comment", true));
            this.tbx_personComment.Location = new System.Drawing.Point(104, 45);
            this.tbx_personComment.Multiline = true;
            this.tbx_personComment.Name = "tbx_personComment";
            this.tbx_personComment.Size = new System.Drawing.Size(288, 213);
            this.tbx_personComment.TabIndex = 0;
            // 
            // frm_issuseAccDoc
            // 
            this.AcceptButton = this.btn_ok;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(431, 504);
            this.Controls.Add(this.grp_personHistorySet);
            this.Controls.Add(this.pnl_transferMoneySet);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbx_comment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_totalMoney);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_accDocNO);
            this.Controls.Add(this.mTbx_accDocDate);
            this.KeyPreview = true;
            this.Name = "frm_issuseAccDoc";
            this.Text = "   صدور سند";
            this.Load += new System.EventHandler(this.frm_issuseAccDoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_issuseAccDoc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.num_accDocNO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_persons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_persons)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_personDiscountPercent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_transferMoneySet.ResumeLayout(false);
            this.pnl_transferMoneySet.PerformLayout();
            this.grp_personHistorySet.ResumeLayout(false);
            this.grp_personHistorySet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_accDocNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_comment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_totalMoney;
        private System.Windows.Forms.Button btn_useCheque;
        private System.Windows.Forms.Button btn_newCheque;
        private System.Windows.Forms.TextBox tbx_uesedChequesMoney;
        private System.Windows.Forms.TextBox tbx_chequesMoney;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbx_remainMoney;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbx_totalPaidMoney;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbx_personID;
        private System.Windows.Forms.TextBox tbx_personFamilyAndName;
        private ds_persons ds_persons;
        private System.Windows.Forms.BindingSource bs_persons;
        private Novin.ds_personsTableAdapters.tbl_personsTableAdapter tbl_personsTableAdapter;
        private System.Windows.Forms.TextBox tbx_personRemainMoney;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_detect;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbx_indebtedMoney;
        private System.Windows.Forms.TextBox tbx_discountMoney;
        private System.Windows.Forms.TextBox tbx_cashMoney;
        private System.Windows.Forms.TextBox tbx_transportPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.MaskedTextBox mTbx_accDocDate;
        private System.Windows.Forms.Panel pnl_transferMoneySet;
        private System.Windows.Forms.Button btn_showPersonLedger;
        private System.Windows.Forms.GroupBox grp_personHistorySet;
        private System.Windows.Forms.TextBox tbx_personComment;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbx_creditCeil;
        private System.Windows.Forms.Button btn_showPersonForm;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chk_personHisory;
        private System.Windows.Forms.PictureBox pic_personFace;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown num_personDiscountPercent;
    }
}
