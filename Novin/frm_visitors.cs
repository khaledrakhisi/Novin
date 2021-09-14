using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_visitors : Novin.frm_FATHER
    {
        public frm_visitors()
        {
            InitializeComponent();
        }

        private void updateTheDatabase()
        {
            this.Validate();
            this.bs_visitors.EndEdit();
            this.tbl_visitorsTableAdapter.Update(ds_visitors.tbl_visitors);
        }

        private void updateTheZonesTable()
        {
            this.Validate();
            this.bs_zones.EndEdit();
            this.tbl_zonesTableAdapter.Update(ds_visitors.tbl_zones);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string s_visitorName = "";
            int n_pos = 0;
            s_visitorName = cls_inputBox.show("نام ویزیتور را وارد نمایید:");
            if (s_visitorName != "")
            {
                DataRow row_newVisitor;
                row_newVisitor = ds_visitors.tbl_visitors.NewRow();

                row_newVisitor["visitor_name"] = s_visitorName;//                                

                ds_visitors.tbl_visitors.Rows.Add(row_newVisitor);

                updateTheDatabase();

                n_pos = (int)row_newVisitor["visitor_id"];
                n_pos = bs_visitors.Find("visitor_id", n_pos);
                if (n_pos != -1)
                {
                    bs_visitors.Position = n_pos;
                }
            }
        }

        private void frm_visitors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_visitors.tbl_zones' table. You can move, or remove it, as needed.
            this.tbl_zonesTableAdapter.Fill(this.ds_visitors.tbl_zones);
            // TODO: This line of code loads data into the 'ds_visitors.tbl_zones' table. You can move, or remove it, as needed.
            this.tbl_zonesTableAdapter.Fill(this.ds_visitors.tbl_zones);
            // TODO: This line of code loads data into the 'ds_visitors.tbl_visitors' table. You can move, or remove it, as needed.
            this.tbl_visitorsTableAdapter.Fill(this.ds_visitors.tbl_visitors);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string s_visitorName = "";
            s_visitorName = ds_visitors.tbl_visitors.Rows[bs_visitors.Position]["visitor_name"].ToString();
            s_visitorName = cls_inputBox.show("تغییرات لازم را اعمال کنید", s_visitorName);
            if (s_visitorName != "")
            {
                ds_visitors.tbl_visitors.Rows[bs_visitors.Position]["visitor_name"] = s_visitorName;
                updateTheDatabase();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ds_visitors.tbl_visitors.Rows[bs_visitors.Position]["visitor_id"].ToString() == "1")
            {
                cls_msgBox.show("حداقل یک ویزیتور باید وجود داشته باشد");
                return;
            }

            if (cls_msgBox.show("آیا از حذف ویزیتور مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {

                bs_visitors.RemoveCurrent();

                updateTheDatabase();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            updateTheDatabase();
        }

        private void btn_newZone_Click(object sender, EventArgs e)
        {
            string s_zoneName = "";
            int n_pos = 0;
            s_zoneName = cls_inputBox.show("نام منطقه را وارد نمایید:");
            if (s_zoneName != "")
            {
                DataRow row_newZone;
                row_newZone = ds_visitors.tbl_zones.NewRow();

                row_newZone["zone_title"] = s_zoneName;// 
                row_newZone["visitor_id"] = 1;// 

                ds_visitors.tbl_zones.Rows.Add(row_newZone);

                updateTheZonesTable();

                n_pos = (int)row_newZone["zone_id"];
                n_pos = bs_zones.Find("zone_id", n_pos);
                if (n_pos != -1)
                {
                    bs_zones.Position = n_pos;
                }
            }
        }

        private void btn_renameZone_Click(object sender, EventArgs e)
        {
            string s_zoneName = "";
            s_zoneName = ds_visitors.tbl_zones.Rows[bs_zones.Position]["zone_title"].ToString();
            s_zoneName = cls_inputBox.show("تغییرات لازم را اعمال کنید", s_zoneName);
            if (s_zoneName != "")
            {
                ds_visitors.tbl_zones.Rows[bs_zones.Position]["zone_title"] = s_zoneName;
                updateTheZonesTable();
            }
        }

        private void btn_deleteZone_Click(object sender, EventArgs e)
        {
            if (ds_visitors.tbl_zones.Rows[bs_zones.Position]["zone_id"].ToString() == "1")
            {
                cls_msgBox.show("حداقل یک منطقه باید وجود داشته باشد");
                return;
            }

            if (cls_msgBox.show("آیا از حذف منطقه مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {

                bs_zones.RemoveCurrent();

                updateTheZonesTable();
            }
        }

        private void btn_saveZone_Click(object sender, EventArgs e)
        {
            updateTheZonesTable();
        }

       
    }
}
