using System;
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
    public partial class frm_objects : frm_FATHER
    {
        private bool b_dataHasChanged = false;

        public frm_objects()
        {
            InitializeComponent();
        }

        public int n_objectIDForEdit = 0;
        public bool EditMode;//true == this form opened for Edit as frm_reportPreview
        public bool b_userCanEditThePrimaryCycleEntity = false;

        private void updateTheDatabase()
        {
            this.Validate();
            bs_objects.EndEdit();
            tbl_objectsTableAdapter.Update(ds_objectGrouping.tbl_objects);

            b_dataHasChanged = false;
        }

        private void frm_objects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_stores.tbl_stores' table. You can move, or remove it, as needed.
            this.tbl_storesTableAdapter.Fill(this.ds_stores.tbl_stores);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_masterGroups' table. You can move, or remove it, as needed.
            this.tbl_masterGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_masterGroups);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_slaveGroups' table. You can move, or remove it, as needed.
            this.tbl_slaveGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_slaveGroups);            
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objects' table. You can move, or remove it, as needed.
            this.tbl_objectsTableAdapter.Fill(this.ds_objectGrouping.tbl_objects);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objectUnits' table. You can move, or remove it, as needed.
            this.tbl_objectUnitsTableAdapter.Fill(this.ds_objectGrouping.tbl_objectUnits);

            if (EditMode == true)
            {
                int n_pos = bs_objects.Find("object_id", n_objectIDForEdit);
                if (n_pos != -1) bs_objects.Position = n_pos;
            }

            if (bs_slaveGroups.Count <= 0)
            {
                cls_msgBox.show("گروه فرعی تعریف نشده است");
                frm_objectGrouping _objectGrouping = new frm_objectGrouping();
                _objectGrouping.ShowDialog();

                // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_masterGroups' table. You can move, or remove it, as needed.
                this.tbl_masterGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_masterGroups);
                // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_slaveGroups' table. You can move, or remove it, as needed.
                this.tbl_slaveGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_slaveGroups);      
            }

            if (!cls_accDoc.isItPrimaryCycle && !b_userCanEditThePrimaryCycleEntity)
            {
                tbx_primaryEntity.Enabled = false;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/fxref_system.data/html/1a75122b-5578-2d83-4e5f-4c0868dbacf1.htm
            try
            {
                string s_objectTitle = cls_inputBox.show("نام کالا را وارد نمایید");

                if (s_objectTitle != "")
                {
                    DataRow drw_newObject;
                    drw_newObject = ds_objectGrouping.tbl_objects.NewRow();

                    //drw_newObject["object_id"] = 1;
                    drw_newObject["slaveGroup_id"] = 1;//(int) ds_objectGrouping.tbl_slaveGroups.Rows[bs_slaveGroups.Position]["slaveGroup_title"];
                    drw_newObject["object_title"] = s_objectTitle;
                    drw_newObject["store_id"] = 1;//
                    drw_newObject["objectUnit_id"] = 1;//کارتن
                    drw_newObject["object_retailInUnit"] = 1;//
                    drw_newObject["object_retailCount"] = 0;//
                    drw_newObject["object_entity"] = 0;//
                    drw_newObject["object_sellPrice"] = 0;//
                    drw_newObject["object_discountPrice"] = 0;//
                    drw_newObject["object_retailBuyPrice"] = 0;//
                    drw_newObject["object_retailSellPrice"] = 0;//
                    drw_newObject["object_date"] = "";//
                    drw_newObject["object_expireDate"] = "";//                 
                    drw_newObject["object_sellMonth"] = 0;//                    
                    drw_newObject["object_lessSell"] = 0;//                    
                    drw_newObject["object_alarmRange"] = 0;//
                    drw_newObject["object_primaryEntity"] = 0;//
                    drw_newObject["object_isItLessSell"] = 0;//

                    ds_objectGrouping.tbl_objects.Rows.Add(drw_newObject);

                    updateTheDatabase();

                    bs_objects.Position = bs_objects.Find("object_title", s_objectTitle);

                    b_dataHasChanged = true;
                }
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            try
            {
                string s_objectTitle = (string)ds_objectGrouping.tbl_objects.Rows[bs_objects.Position]["object_title"];
                string s_newObjectTitle = cls_inputBox.show("تغییرات لازم را انجام دهید", s_objectTitle);

                if (s_newObjectTitle != "")
                {
                    ds_objectGrouping.tbl_objects.Rows[bs_objects.Position]["object_title"] = s_newObjectTitle;
                    updateTheDatabase();
                    b_dataHasChanged = true;
                }
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void btn_deletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_msgBox.show("آیا از حذف کردن کــــالا مطمئنید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {
                    bs_objects.RemoveCurrent();
                    updateTheDatabase();
                    b_dataHasChanged = true;
                }
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void btn_modifyPersonProperties_Click(object sender, EventArgs e)
        {
            try
            {                
                int n_object_id = (int)ds_objectGrouping.tbl_objects.Rows[bs_objects.Position]["object_id"];
                cls_storing _storing = new cls_storing();
                int n_objectEntity = _storing.getAnObjectEntity(n_object_id);

                ds_objectGrouping.tbl_objects.Rows[bs_objects.Position]["object_entity"] = n_objectEntity;
                updateTheDatabase();
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void lst_slaveGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bs_slaveGroups.Count > 0)
                {
                    //if the END-USER selected the slaveGroup ,the MasterGroup Title of that slave Group will appear
                    int n_masterGroupID = (int)ds_objectGrouping.tbl_slaveGroups.Rows[bs_slaveGroups.Position]["masterGroup_id"];
                    int n_masterGroupPosition = bs_masterGroups.Find("masterGroup_id", n_masterGroupID);
                    string s_masterGroupTitle = (string)ds_objectGrouping.tbl_masterGroups.Rows[n_masterGroupPosition]["masterGroup_title"];
                    lbl_masterGroupTitle.Text = s_masterGroupTitle;
                }
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

        private void btn_groupingForm_Click(object sender, EventArgs e)
        {
            frm_objectGrouping _objectGrouping = new frm_objectGrouping();
            _objectGrouping.ShowDialog();

            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_masterGroups' table. You can move, or remove it, as needed.
            this.tbl_masterGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_masterGroups);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_slaveGroups' table. You can move, or remove it, as needed.
            this.tbl_slaveGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_slaveGroups);
        }

        private void tbx_buyPriceAvg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            int isNumber = 0;

            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }
    }
}
