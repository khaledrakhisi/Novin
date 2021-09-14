using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_store : frm_FATHER
    {
        public frm_store()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frm_store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_stores.tbl_stores' table. You can move, or remove it, as needed.
            this.tbl_storesTableAdapter.Fill(this.ds_stores.tbl_stores);

        }

        private void updateTheDatabase()
        {
            this.Validate();
            this.bs_stores.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_stores);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string s_storeName = "";
            int n_pos = 0;
            s_storeName = cls_inputBox.show("نام انبار را وارد نمایید:");
            if (s_storeName != "")
            {
                DataRow row_newStore;
                row_newStore = ds_stores.tbl_stores.NewRow();

                row_newStore["store_name"] = s_storeName;//                                

                ds_stores.tbl_stores.Rows.Add(row_newStore);

                updateTheDatabase();

                n_pos =(int) row_newStore["store_id"];
                n_pos = bs_stores.Find("store_id", n_pos);
                if (n_pos != -1)
                {
                    bs_stores.Position = n_pos;
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string s_storeName = "";
            s_storeName = ds_stores.tbl_stores.Rows[bs_stores.Position]["store_name"].ToString();
            s_storeName = cls_inputBox.show("تغییرات لازم را اعمال کنید", s_storeName);
            if (s_storeName != "")
            {
                ds_stores.tbl_stores.Rows[bs_stores.Position]["store_name"] = s_storeName;
                updateTheDatabase();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            updateTheDatabase();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ds_stores.tbl_stores.Rows[bs_stores.Position]["store_id"].ToString() == "1")
            {
                cls_msgBox.show("حداقل یک انبار باید وجود داشته باشد");
                return;
            }

            if (cls_msgBox.show("آیا از حذف انبار مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {
               
                bs_stores.RemoveCurrent();

                updateTheDatabase();
            }
        }

       
    }
}
