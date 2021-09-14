using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Novin
{
    public partial class frm_persons : frm_FATHER
    {
        private bool b_dataHasChanged=false;
        public frm_persons()
        {
            InitializeComponent();
        }

        public bool b_userCanEditPrimaryCycleData = false;

        public void new_person(string s_familyAndName)
        {
            //ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/fxref_system.data/html/1a75122b-5578-2d83-4e5f-4c0868dbacf1.htm

            cls_moeens _moeens = new cls_moeens();
            //در اینجا سرفصل معین مربوط به حساب تعریف شده ایجاد میشود                

            _moeens.kol_id = "103";
            _moeens.moeen_title = "";
            _moeens.insertRelatedMoeen();

            DataRow drw_newPerson;
            drw_newPerson = ds_persons.tbl_persons.NewRow();
            drw_newPerson["person_id"] = cls_visitors.getNextPersonID();
            drw_newPerson["moeen_id"] = _moeens.moeen_id;
            drw_newPerson["zone_id"] = 1;
            drw_newPerson["person_familyAndName"] = s_familyAndName;
            drw_newPerson["person_beforeType"] = 0;
            drw_newPerson["person_remainMoney"] = 0;
            drw_newPerson["person_nowRemainMoney"] = 0;
            drw_newPerson["person_isPersonel"] = false;
            drw_newPerson["person_isCustomer"] = true;
            drw_newPerson["person_isSeller"] = false;
            drw_newPerson["person_isInter"] = false;
            drw_newPerson["person_discountPercent"] = 0;
            drw_newPerson["person_creditCeil"] = 0;

            ds_persons.tbl_persons.Rows.Add(drw_newPerson);

            bs_persons.Position = bs_persons.Find("person_familyAndName", s_familyAndName);

            //                
            _moeens.moeen_title = s_familyAndName;
            _moeens.updateRelatedMoeen();

            updateTheDatabase();

            b_dataHasChanged = false;
        }        

        private void interpretData()
        {
            try
            {
                short n_beforeType = (short)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_beforeType"];
                if (n_beforeType == 0) //it means person is not indebted or creditor
                {
                    rdu_NoBeforeMoney.Checked = true;
                }
                else if (n_beforeType == 1)//it means person is indebted
                {
                    rdu_indebtedBefore.Checked = true;
                }
                else if (n_beforeType == 2)//person is crediror
                {
                    rdu_creditorBefore.Checked = true;
                }
            }
            catch
            {
            }
        }

        private void updateTheDatabase()
        {
            try
            {
                if (bs_persons.Position != -1)
                {
                    if (ds_persons.tbl_persons.Rows[bs_persons.Position].RowState != DataRowState.Deleted)
                    {
                        //interpret the boolean data
                        if (rdu_creditorBefore.Checked)
                        {
                            ds_persons.tbl_persons.Rows[bs_persons.Position]["person_beforeType"] = 2;
                        }
                        else if (rdu_indebtedBefore.Checked)
                        {
                            ds_persons.tbl_persons.Rows[bs_persons.Position]["person_beforeType"] = 1;
                        }
                        else if (rdu_NoBeforeMoney.Checked)
                        {
                            ds_persons.tbl_persons.Rows[bs_persons.Position]["person_beforeType"] = 0;
                        }
                    }
                }
                this.Validate();
                bs_persons.EndEdit();
                tbl_personsTableAdapter.Update(ds_persons.tbl_persons);

                b_dataHasChanged = false;
            }
            catch (SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void frm_persons_Load(object sender, EventArgs e)
        {
            tableAdapterManager.Connection.ConnectionString = cls_myDataAccessLayer.ConnectionString;
            
            this.tbl_zonesTableAdapter.Fill(this.ds_persons.tbl_zones);
            
            this.tbl_visitorsTableAdapter.Fill(this.ds_persons.tbl_visitors);
            
            this.tbl_personsTableAdapter.FillByFilter(this.ds_persons.tbl_persons, 1);                      
           
            interpretData();

            if (!cls_accDoc.isItPrimaryCycle && !b_userCanEditPrimaryCycleData)
            {
                grp_RadioButtons.Enabled = false;
            }
        }

        private void btn_newPerson_Click(object sender, EventArgs e)
        {
            //ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/fxref_system.data/html/1a75122b-5578-2d83-4e5f-4c0868dbacf1.htm
            string s_familyAndName = cls_inputBox.show("نام خانوادگی و نام طرف حساب");

            if(s_familyAndName != "")
            {
                new_person(s_familyAndName);                
            }
        }

        private void btn_renamePerosn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs_persons.Count <= 0)
                {
                    return;
                }

                string s_person_familyAndName = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_familyAndName"];
                string s_newFamilyAndName = cls_inputBox.show("تغییرات لازم را انجام دهید", s_person_familyAndName);

                if (s_newFamilyAndName != "")
                {
                    ds_persons.tbl_persons.Rows[bs_persons.Position]["person_familyAndName"] = s_newFamilyAndName;

                    //در اینجا سرفصل معین مربوط به این طرف حساب به روز میشود
                    string s_moeen_id = "";
                    s_moeen_id = (string) ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                    cls_moeens _moeens = new cls_moeens();
                    _moeens.moeen_id = s_moeen_id;
                    _moeens.moeen_title = s_newFamilyAndName;
                    _moeens.updateRelatedMoeen();
                    /////////////////////////////////////////////////////////

                    updateTheDatabase();

                    b_dataHasChanged = false;
                }                
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void btn_deletePerson_Click(object sender, EventArgs e)
        {            
            if (bs_persons.Position == -1) return;
            try
            {
                if (bs_persons.Count <= 0)
                {
                    return;
                }

                if (cls_msgBox.show("آیا از حذف کردن طرف حساب مطمئنید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {
                    //در اینجا سرفصل معین مربوط به این طرف حساب به روز میشود
                    string s_moeen_id = "";
                    s_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                    cls_moeens _moeens = new cls_moeens();
                    _moeens.moeen_id = s_moeen_id;
                    _moeens.deleteRelatedMoeen();

                    bs_persons.RemoveCurrent();
                    /////////////////////////////////////////////                    

                    updateTheDatabase();

                    b_dataHasChanged = false;
                }
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void btn_modifyPersonProperties_Click(object sender, EventArgs e)
        {
            if (bs_persons.Count <= 0)
            {
                return;
            }

            //محاسبه مانده فعلی طرف حساب
            string s_person_moeen_id = "";
            s_person_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
            cls_visitors.setPersonNowRemainMoney(s_person_moeen_id);

            updateTheDatabase();
            
            if (b_userCanEditPrimaryCycleData && !cls_accDoc.isItPrimaryCycle)
            {
                //در اینجا باید سطرهای سندهای افتتاحیه از اول ساخته بشوند
                frm_primaryCycleEnd _primaryCycleEnd = new frm_primaryCycleEnd();
                _primaryCycleEnd.frm_primaryCycleEnd_Load(null, null);
                _primaryCycleEnd.issuseFirstAndSecondAccdoc();
            }
        }

        private void bs_persons_CurrentChanged(object sender, EventArgs e)
        {
            interpretData();

            //display person face
            try
            {
                byte[] arrPic = (byte[])(ds_persons.tbl_persons.Rows[bs_persons.Position]["person_pic"]); //(ds.Tables["Persons"].Rows[0]["Photo"]);

                MemoryStream ms = new MemoryStream(arrPic);

                pic_personFace.Image = Image.FromStream(ms);
            }
            catch
            {
                pic_personFace.Image = null;
            }
        }

        private void rdu_NoBeforeMoney_CheckedChanged(object sender, EventArgs e)
        {
            pnl_beforeMoney.Visible = !rdu_NoBeforeMoney.Checked;
        }

        private void rdu_indebtedBefore_CheckedChanged(object sender, EventArgs e)
        {
            if (rdu_indebtedBefore.Checked)
            {
                lbl_beforeRemainMoneyPrompt.Text = "مبلغ بدهکاری";
            }
        }

        private void rdu_creditorBefore_CheckedChanged(object sender, EventArgs e)
        {
            if (rdu_creditorBefore.Checked)
            {
                lbl_beforeRemainMoneyPrompt.Text = "مبلغ بستانکاری";
            }
        }

        private void tbx_indebtedOrCreditorPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s_remainMoney = tbx_indebtedOrCreditorPrice.Text.Replace(",", "");
                lbl_priceInChars.Text = cls_numberConvertor.convertToChars(s_remainMoney) + " ریال ";
            }
            catch
            {
            }
        }

        private void frm_persons_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (b_dataHasChanged)
            {
                DialogResult result= cls_msgBox.show("آیا تغییرات ذخیره شوند ؟", "", cls_msgBox.buttons.YesAndNoAndCancel);
                if (result == DialogResult.Yes)
                {
                    b_dataHasChanged = false;

                    updateTheDatabase();

                    //this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.No)
                {
                    //b_dataHasChanged = false;
                    //this.Close();
                }
            }
        }

        private void cmb_familyAndName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = bs_persons.DataSource;
                frmFindRecords.bindingSource1.DataMember = bs_persons.DataMember;
                frmFindRecords.listDisplayMember = "person_FamilyAndName";
                frmFindRecords.listValueMember = "person_id";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                if (frmFindRecords.ShowDialog() == DialogResult.OK)
                {
                    if (frmFindRecords.foundRecordID != "-1")
                    {
                        int nPosition = bs_persons.Find("person_id", frmFindRecords.foundRecordID);
                        bs_persons.Position = nPosition;
                    }

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
        }

        private void numricTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void tbx_nationalNumber_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("");
        }

        private void tbx_nationalNumber_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("");
        }

        private void tbx_nationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            long isNumber = 0;
            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void frm_persons_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void tbx_creditCeil_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s_creditCeilMoney = tbx_creditCeil.Text.Replace(",", "");
                lbl_creditCeilInChars.Text = cls_numberConvertor.convertToChars(s_creditCeilMoney) + " ریال ";
            }
            catch
            {
            }
        }

        private void btn_choosepicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pic_personFace.Image = Image.FromFile(openFileDialog1.FileName);
                    MemoryStream ms = new MemoryStream();
                    byte[] arrPic = ms.GetBuffer();
                    try
                    {
                        pic_personFace.Image.Save(ms, pic_personFace.Image.RawFormat);
                        arrPic = ms.GetBuffer();
                    }
                    catch
                    {
                    }
                    finally
                    {
                        ms.Close();
                    }
                    ds_persons.tbl_persons.Rows[bs_persons.Position]["person_pic"] = arrPic;
                }
                catch
                {
                }
            }
        }

        private void tbx_discountPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_creditCeil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            long isNumber = 0;

            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            btn_modifyPersonProperties.PerformClick();
            Close();
        }

        private void btn_deletePic_Click(object sender, EventArgs e)
        {
            pic_personFace.Image = null;
            ds_persons.tbl_persons.Rows[bs_persons.Position]["person_pic"] = null;
        }

        private void frm_persons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btn_newPerson.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btn_renamePerosn.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btn_modifyPersonProperties.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btn_deletePerson.PerformClick();
            }
        }

      
    }
}
