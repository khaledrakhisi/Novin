using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_itemSelection : Novin.frm_FATHER
    {
        public frm_itemSelection()
        {
            InitializeComponent();
        }
        private int n_openMode;
        
        /// <summary>
        ///invoiceBuy  = 0
        ///invoiceSell = 1
        ///invoiceBackBuy = 2
        ///invoiceBackSell = 3 
        /// </summary>
        public int openMode
        {
            get { return n_openMode; }
            set { n_openMode = value; }
        }
        private int n_invoiceID;
        public int invoiceID
        {
            get { return n_invoiceID; }
            set { n_invoiceID = value; }
        }
        private bool b_isItForReturnInvoice;
        public bool isItForReturnInvoice
        {
            get { return b_isItForReturnInvoice; }
            set { b_isItForReturnInvoice = value; }
        }

        private void loadGroups()
        {
            int i = 0;

            treeView1.Nodes.Clear();
           
            foreach (DataRow _masterRow in ds_objectGrouping.tbl_masterGroups.Rows)
            {
                bs_slaveGroups.Filter = "masterGroup_id = " + _masterRow["masterGroup_id"].ToString();
                
                TreeNode[] treeNode = new TreeNode[bs_slaveGroups.Count];

                i = 0;
                int j = 0;
                foreach (DataRow _slaveRow in ds_objectGrouping.tbl_slaveGroups.Rows)
                {
                    if (ds_objectGrouping.tbl_slaveGroups.Rows[i]["masterGroup_id"].ToString() == _masterRow["masterGroup_id"].ToString())
                    {
                        //collecting the child nodes                    
                        TreeNode tt = new TreeNode(_slaveRow["slaveGroup_title"].ToString());
                        treeNode[j] = tt;
                        treeNode[j].Tag = _slaveRow["slaveGroup_id"].ToString();
                        j++;
                    }
                    i++;
                }
                //adding the root node
                TreeNode treeRoot = new TreeNode(_masterRow["masterGroup_title"].ToString(), treeNode);
                treeRoot.ForeColor = Color.Blue;

                this.treeView1.Nodes.Add(treeRoot);
                treeRoot.Tag = _masterRow["masterGroup_id"].ToString();
            }
            this.treeView1.RightToLeftLayout = true;

            bs_slaveGroups.RemoveFilter();
        }

        private void frm_itemSelection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_wastedInvoices.tbl_itemsWasted' table. You can move, or remove it, as needed.
            this.tbl_itemsWastedTableAdapter.Fill(this.ds_wastedInvoices.tbl_itemsWasted);
            // TODO: This line of code loads data into the 'ds_sellInvoices.tbl_itemsSell' table. You can move, or remove it, as needed.
            this.tbl_itemsSellTableAdapter.Fill(this.ds_sellInvoices.tbl_itemsSell);
            // TODO: This line of code loads data into the 'ds_buyInvoices.tbl_itemsBuy' table. You can move, or remove it, as needed.
            this.tbl_itemsBuyTableAdapter.Fill(this.ds_buyInvoices.tbl_itemsBuy);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objects' table. You can move, or remove it, as needed.
            this.tbl_objectsTableAdapter.Fill(this.ds_objectGrouping.tbl_objects);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_slaveGroups' table. You can move, or remove it, as needed.
            this.tbl_slaveGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_slaveGroups);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_masterGroups' table. You can move, or remove it, as needed.
            this.tbl_masterGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_masterGroups);

            loadGroups();


            switch (openMode)
            {
                case 0://buy items
                    {
                        dgw_invoiceBuy.Visible = true;                        
                        bs_itemsBuy.Filter = "invoiceBuy_id = " + invoiceID.ToString() + " AND invoiceBuy_kind = " + (!b_isItForReturnInvoice).ToString();
                    } break;
                case 1://sell items
                    {
                        dgw_invoiceSell.Visible = true;                        
                        bs_itemsSell.Filter = "invoiceSell_id = " + invoiceID.ToString() + " AND invoiceSell_kind = " + (!b_isItForReturnInvoice).ToString();
                    } break;
               case 2://wasted items
                   {
                       dgw_itemsWasted.Visible = true;
                       bs_itemsWasted.Filter = "invoiceWasted_id = " + invoiceID.ToString();
                   }break;
                //case 3:{dgw_invoiceBackSell.Visible=true;}break;
            }
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Level == 1)
            {
                bs_objects.Filter = "slaveGroup_id = " + e.Node.Tag;
            }
        }

        private void treeView1_LocationChanged(object sender, EventArgs e)
        {
           
        }

        private void lst_objects_DoubleClick(object sender, EventArgs e)
        {
            //the 'Tag' property has bounded to 'object_id' field so when we want obtain the 
            //selected object 'Object_id' we should get the value of Tag
            //try
            //{
            int n_objectID = (int)lst_objects.Tag;

            if (openMode == 0)//0 means open Buy mode
            {
                //if the object does not exist in the items buy table.
                if (bs_itemsBuy.Find("object_id", n_objectID) == -1)
                {
                    DataRow row_selectedObject = ds_objectGrouping.tbl_objects.Rows.Find(n_objectID);
                    int n_objectEntity = (int)row_selectedObject["object_entity"];
                    int n_objectRetailInUnit = (int)row_selectedObject["object_retailInUnit"];
                    long n_itemBuyRetailPrice = (long)row_selectedObject["object_retailBuyPrice"];
                    short n_discountPrecent = (short)row_selectedObject["object_discountPrice"];

                    int n_objectUnitCount = (int)n_objectEntity / n_objectRetailInUnit;
                    int n_objectRetailCount = (int)n_objectEntity % n_objectRetailInUnit;

                    DataRow row_newItemBuy;
                    row_newItemBuy = ds_buyInvoices.tbl_itemsBuy.NewRow();

                    //row_newItemBuy["itemBuy_id"] = 1;//
                    row_newItemBuy["invoiceBuy_id"] = n_invoiceID; //
                    row_newItemBuy["invoiceBuy_kind"] = !b_isItForReturnInvoice; //
                    row_newItemBuy["object_id"] = n_objectID;//
                    row_newItemBuy["itemBuy_unitCount"] = n_objectUnitCount;//
                    row_newItemBuy["itemBuy_retailCount"] = n_objectRetailCount;//
                    row_newItemBuy["itemBuy_retailPrice"] = n_itemBuyRetailPrice;//
                    row_newItemBuy["itemBuy_taxPercent"] = 0;//
                    row_newItemBuy["itemBuy_discountPercent"] = n_discountPrecent;//
                    row_newItemBuy["itemBuy_comment"] = "";//

                    ds_buyInvoices.tbl_itemsBuy.Rows.Add(row_newItemBuy);
                }
            }
            else if (openMode == 1)//1 means open sell mode
            {
                if (bs_itemsSell.Find("object_id", n_objectID) == -1)
                {
                    DataRow row_selectedObject = ds_objectGrouping.tbl_objects.Rows.Find(n_objectID);
                    int n_objectEntity = (int)row_selectedObject["object_entity"];
                    int n_objectRetailInUnit = (int)row_selectedObject["object_retailInUnit"];
                    long n_itemSellRetailPrice = (long)row_selectedObject["object_retailSellPrice"];
                    short n_discountPrecent = (short)row_selectedObject["object_discountPrice"];

                    int n_objectUnitCount = (int)n_objectEntity / n_objectRetailInUnit;
                    int n_objectRetailCount = (int)n_objectEntity % n_objectRetailInUnit;

                    DataRow row_newItemSell;
                    row_newItemSell = ds_sellInvoices.tbl_itemsSell.NewRow();
                    row_newItemSell["invoiceSell_id"] = n_invoiceID; //
                    row_newItemSell["invoiceSell_kind"] = !b_isItForReturnInvoice; //
                    row_newItemSell["object_id"] = n_objectID;//
                    row_newItemSell["itemSell_unitCount"] = n_objectUnitCount;//
                    row_newItemSell["itemSell_retailCount"] = n_objectRetailCount;//
                    row_newItemSell["itemSell_retailPrice"] = n_itemSellRetailPrice;//
                    row_newItemSell["itemSell_taxPercent"] = 0;//
                    row_newItemSell["itemSell_totalPrice"] = 0;//
                    row_newItemSell["itemSell_visitorPercent"] = 0;//
                    row_newItemSell["itemSell_discountPercent"] = n_discountPrecent;//
                    row_newItemSell["itemSell_comment"] = "";//
                    row_newItemSell["itemSell_transportPrice"] = 0;//

                    ds_sellInvoices.tbl_itemsSell.Rows.Add(row_newItemSell);
                }
            }
            else if (openMode == 2)//2 means open wasted mode
            {
                if (bs_itemsWasted.Find("object_id", n_objectID) == -1)
                {
                    DataRow row_selectedObject = ds_objectGrouping.tbl_objects.Rows.Find(n_objectID);
                    int n_objectEntity = (int)row_selectedObject["object_entity"];
                    int n_objectRetailInUnit = (int)row_selectedObject["object_retailInUnit"];
                    long n_itemWastedRetailPrice = (long)row_selectedObject["object_retailSellPrice"];
                    short n_discountPrecent = (short)row_selectedObject["object_discountPrice"];

                    int n_objectUnitCount = (int)n_objectEntity / n_objectRetailInUnit;
                    int n_objectRetailCount = (int)n_objectEntity % n_objectRetailInUnit;

                    DataRow row_newItemWasted;
                    row_newItemWasted = ds_wastedInvoices.tbl_itemsWasted.NewRow();
                    row_newItemWasted["invoiceWasted_id"] = n_invoiceID; //                    
                    row_newItemWasted["object_id"] = n_objectID;//
                    row_newItemWasted["itemWasted_unitCount"] = n_objectUnitCount;//
                    row_newItemWasted["itemWasted_retailCount"] = n_objectRetailCount;//
                    row_newItemWasted["itemWasted_retailPrice"] = n_itemWastedRetailPrice;//                    
                    row_newItemWasted["itemWasted_comment"] = "";//                    

                    ds_wastedInvoices.tbl_itemsWasted.Rows.Add(row_newItemWasted);
                }
            }

            //}
            //catch
            //{
            //}
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //bs_itemsBuy.EndEdit();
            //tbl_itemsBuyTableAdapter.Update(ds_buyInvoices.tbl_itemsBuy);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (openMode == 0)//0 means open Buy mode
            {
                bs_itemsBuy.RemoveCurrent();
            }
            else if (openMode == 1)//1 means open sell mode
            {
                bs_itemsSell.RemoveCurrent();
            }
            else if (openMode == 2)//2 means open wasted mode
            {
                bs_itemsWasted.RemoveCurrent();
            }

        }

        private void bs_itemsBuy_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void bs_itemsBuy_ListChanged(object sender, ListChangedEventArgs e)
        {
            try
            {
                if (bs_itemsBuy.Count >= 1)
                {
                    //btn_ok.Enabled = true;
                    btn_delete.Enabled = true;
                }
                else
                {
                    //btn_ok.Enabled = false;
                    btn_delete.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void lst_objects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
