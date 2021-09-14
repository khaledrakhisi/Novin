using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_objectsUnits : Novin.frm_FATHER
    {
        public frm_objectsUnits()
        {
            InitializeComponent();
        }

        private void updateTheDatabase()
        {
            this.Validate();
            this.bs_objectUnits.EndEdit();
            this.tbl_objectUnitsTableAdapter.Update(this.ds_objectGrouping.tbl_objectUnits);
        }

        private void frm_objectsUnits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objectUnits' table. You can move, or remove it, as needed.
            this.tbl_objectUnitsTableAdapter.Fill(this.ds_objectGrouping.tbl_objectUnits);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string s_objectUnitTitle = "";
            int n_pos = 0;
            s_objectUnitTitle = cls_inputBox.show("عنوان واحد کالا را وارد نمایید:");
            if (s_objectUnitTitle != "")
            {
                DataRow row_newObjectUnit;
                row_newObjectUnit = ds_objectGrouping.tbl_objectUnits.NewRow();

                row_newObjectUnit["objectUnit_title"] = s_objectUnitTitle;//
                row_newObjectUnit["objectUnit_retailTitle"] = "عدد";//

                ds_objectGrouping.tbl_objectUnits.Rows.Add(row_newObjectUnit);

                updateTheDatabase();

                n_pos = (int)row_newObjectUnit["objectUnit_id"];
                n_pos = bs_objectUnits.Find("objectUnit_id", n_pos);
                if (n_pos != -1)
                {
                    bs_objectUnits.Position = n_pos;
                }
            }
        }

        private void tbx_retailTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if ((int)ds_objectGrouping.tbl_objectUnits.Rows[bs_objectUnits.Position]["objectUnit_id"] <= 4)
            {
                cls_msgBox.show("این واحدها پیش فرض برنامه هستند و قابل تغییر نیستند");
                return;
            }

            string s_objectUnitName = "";
            s_objectUnitName = ds_objectGrouping.tbl_objectUnits.Rows[bs_objectUnits.Position]["objectUnit_title"].ToString();
            s_objectUnitName = cls_inputBox.show("تغییرات لازم را اعمال کنید", s_objectUnitName);
            if (s_objectUnitName != "")
            {
                ds_objectGrouping.tbl_objectUnits.Rows[bs_objectUnits.Position]["objectUnit_title"] = s_objectUnitName;
                updateTheDatabase();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if ((int)ds_objectGrouping.tbl_objectUnits.Rows[bs_objectUnits.Position]["objectUnit_id"] <= 4)
            {
                cls_msgBox.show("این واحدها پیش فرض برنامه هستند و قابل حذف نیستند");
                return;
            }

            if (cls_msgBox.show("آیا از حذف این واحد مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {
                bs_objectUnits.RemoveCurrent();

                updateTheDatabase();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            updateTheDatabase();
        }

        private void bs_objectUnits_CurrentChanged(object sender, EventArgs e)
        {
            if ((int)ds_objectGrouping.tbl_objectUnits.Rows[bs_objectUnits.Position]["objectUnit_id"] <= 4)
            {
                tbx_retailTitle.ReadOnly = true;
            }
            else
            {
                tbx_retailTitle.ReadOnly = false;
            }
        }
    }
}
