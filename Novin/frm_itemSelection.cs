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

        private int n_rangePrice;
        public int rangePrice
        {
            get { return n_rangePrice; }
            set { n_rangePrice = value; }
        }
        private void updateTheObjectsDataset()
        {
            this.Validate();
            bs_objects.EndEdit();
            tbl_objectsTableAdapter.Update(ds_objectGrouping.tbl_objects);
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
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objectUnits' table. You can move, or remove it, as needed.
            this.tbl_objectUnitsTableAdapter.Fill(this.ds_objectGrouping.tbl_objectUnits);

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
                        // TODO: This line of code loads data into the 'ds_buyInvoices.tbl_itemsBuy' table. You can move, or remove it, as needed.
                        this.tbl_itemsBuyTableAdapter.Fill(this.ds_buyInvoices.tbl_itemsBuy, n_invoiceID, !b_isItForReturnInvoice);

                        dgw_invoiceBuy.Visible = true;
                        cbx_allPrice.Visible = false;
                        //bs_itemsBuy.Filter = "invoiceBuy_id = " + invoiceID.ToString() + " AND invoiceBuy_kind = " + (!b_isItForReturnInvoice).ToString();
                    } break;
                case 1://sell items
                    {
                        // TODO: This line of code loads data into the 'ds_sellInvoices.tbl_itemsSell' table. You can move, or remove it, as needed.
                        this.tbl_itemsSellTableAdapter.Fill(this.ds_sellInvoices.tbl_itemsSell, n_invoiceID, !b_isItForReturnInvoice);

                        dgw_invoiceSell.Visible = true;
                        //bs_itemsSell.Filter = "invoiceSell_id = " + invoiceID.ToString() + " AND invoiceSell_kind = " + (!b_isItForReturnInvoice).ToString();
                    } break;
                case 2://wasted items
                    {
                        // TODO: This line of code loads data into the 'ds_wastedInvoices.tbl_itemsWasted' table. You can move, or remove it, as needed.
                        this.tbl_itemsWastedTableAdapter.Fill(this.ds_wastedInvoices.tbl_itemsWasted, n_invoiceID);

                        dgw_itemsWasted.Visible = true;
                        //bs_itemsWasted.Filter = "invoiceWasted_id = " + invoiceID.ToString();
                    } break;
                //case 3:{dgw_invoiceBackSell.Visible=true;}break;
            }
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
            try
            {
                int n_object_id = 0;
                string s_objectTitle = "";
                string s_objectUnitTitle = "";
                int n_objectRetailInUnit = 0;

                n_object_id = (int)ds_buyInvoices.tbl_itemsBuy.Rows[bs_itemsBuy.Position]["object_id"];

                s_objectTitle = tbl_objectsTableAdapter.getObjectTitle(n_object_id);
                s_objectUnitTitle = (string) tbl_objectsTableAdapter.getObjectUnitTitle(n_object_id);
                n_objectRetailInUnit = (int)tbl_objectsTableAdapter.getObjectRetailInUnit(n_object_id);

                tbx_objectTitle.Text = s_objectTitle;
                tbx_unitTitle.Text = s_objectUnitTitle;                
                tbx_retailInUnit.Text = n_objectRetailInUnit.ToString();
            }
            catch
            {
            }
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

        private void bs_itemsSell_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int n_object_id = 0;
                string s_objectTitle = "";
                string s_objectUnitTitle = "";
                int n_objectRetailInUnit = 0;

                n_object_id = (int)ds_sellInvoices.tbl_itemsSell.Rows[bs_itemsSell.Position]["object_id"];

                s_objectTitle = tbl_objectsTableAdapter.getObjectTitle(n_object_id);
                s_objectUnitTitle = (string)tbl_objectsTableAdapter.getObjectUnitTitle(n_object_id);
                n_objectRetailInUnit = (int)tbl_objectsTableAdapter.getObjectRetailInUnit(n_object_id);

                tbx_objectTitle.Text = s_objectTitle;
                //tbx_unitTitle.Text = s_objectUnitTitle;
                tbx_retailInUnit.Text = n_objectRetailInUnit.ToString();
            }
            catch
            {
            }
        }

        private void bs_itemsSell_ListChanged(object sender, ListChangedEventArgs e)
        {
            try
            {
                if (bs_itemsSell.Count >= 1)
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

        private void bs_itemsWasted_ListChanged(object sender, ListChangedEventArgs e)
        {
            try
            {
                if (bs_itemsWasted.Count >= 1)
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

        private void bs_itemsWasted_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int n_object_id = 0;
                string s_objectTitle = "";
                string s_objectUnitTitle = "";
                int n_objectRetailInUnit = 0;
                long n_objectBuyPrice = 0;
                long n_objectSalePrice = 0;

                n_object_id = (int)ds_wastedInvoices.tbl_itemsWasted.Rows[bs_itemsWasted.Position]["object_id"];

                s_objectTitle = tbl_objectsTableAdapter.getObjectTitle(n_object_id);
                s_objectUnitTitle =(string) tbl_objectsTableAdapter.getObjectUnitTitle(n_object_id);
                n_objectRetailInUnit = (int)tbl_objectsTableAdapter.getObjectRetailInUnit(n_object_id);
                n_objectBuyPrice = (long)tbl_objectsTableAdapter.getObjectRetailBuyPrice(n_object_id);
                n_objectSalePrice = (long)tbl_objectsTableAdapter.getObjectRetailSellPrice(n_object_id);

                tbx_objectTitle.Text = s_objectTitle;
                tbx_unitTitle.Text = s_objectUnitTitle;
                tbx_retailInUnit.Text = n_objectRetailInUnit.ToString();
                //tbx_objectBuyPrice.Text = n_objectBuyPrice.ToString();
                //tbx_objectSalePrice.Text = n_objectSalePrice.ToString();
            }
            catch
            {
            }
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                bs_objects.Filter = "slaveGroup_id = " + treeView1.SelectedNode.Tag;
            }
        }

        private void treeView1_Enter(object sender, EventArgs e)
        {
            //this.AcceptButton = null;
            treeView1.BackColor = Color.LightYellow;
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dgv_objects.Focus();
            }
        }

        private void dgv_objects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //the 'Tag' property has bounded to 'object_id' field so when we want obtain the 
            //selected object 'Object_id' we should get the value of Tag
            try
            {
            int n_objectID = (int)dgv_objects.Tag;

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
                    this.itemWastedretailCountDataGridViewTextBoxColumn.MaxInputLength = 100;
                    ds_buyInvoices.tbl_itemsBuy.Rows.Add(row_newItemBuy);
                }
            }
            else if (openMode == 1)//1 means open sell mode
            {
                //if (bs_itemsSell.Find("object_id", n_objectID) == -1)// for ashantyun
                //{
                    DataRow row_selectedObject = ds_objectGrouping.tbl_objects.Rows.Find(n_objectID);
                    int n_objectEntity = (int)row_selectedObject["object_entity"];
                    int n_objectRetailInUnit = (int)row_selectedObject["object_retailInUnit"];
                    //long n_itemSellRetailPrice = (long)row_selectedObject["object_retailSellPrice"];
                    int n_itemSellRetailPrice = Convert.ToInt32(cbx_allPrice.Text);
                    short n_discountPrecent = (short)row_selectedObject["object_discountPrice"];

                    int n_objectUnitCount = (int)n_objectEntity / n_objectRetailInUnit;
                    int n_objectRetailCount = (int)n_objectEntity % n_objectRetailInUnit;

                    if (n_objectEntity <= 0)
                    {
                        cls_msgBox.show("موجودی صفر است");
                        return;
                    }
                    DataRow row_newItemSell;
                    row_newItemSell = ds_sellInvoices.tbl_itemsSell.NewRow();
                    row_newItemSell["invoiceSell_id"] = n_invoiceID; //
                    row_newItemSell["invoiceSell_kind"] = !b_isItForReturnInvoice; //
                    row_newItemSell["object_id"] = n_objectID;//
                    if (bs_itemsSell.Find("object_id", n_objectID) == -1)
                    {
                        row_newItemSell["itemSell_retailCount"] = n_objectRetailCount;//
                        row_newItemSell["itemSell_unitCount"] = n_objectUnitCount;//
                        
                    }
                    else
                    {// for bare dovom , pas eshantiyun ast
                        row_newItemSell["itemSell_retailCount"] = 0;//
                        row_newItemSell["itemSell_unitCount"] = 0;//
                    }
                    row_newItemSell["itemSell_retailPrice"] = n_itemSellRetailPrice;//
                    row_newItemSell["itemSell_taxPercent"] = 0;//
                    row_newItemSell["itemSell_totalPrice"] = 0;//
                    row_newItemSell["itemSell_visitorPercent"] = 0;//
                    row_newItemSell["itemSell_discountPercent"] = n_discountPrecent;//
                    row_newItemSell["itemSell_comment"] = "";//
                    row_newItemSell["itemSell_transportPrice"] = 0;//

                    ds_sellInvoices.tbl_itemsSell.Rows.Add(row_newItemSell);
                //}
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

            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void dgv_objects_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                dgv_objects_CellDoubleClick(null, null);
                //tbx_searchObjects.Focus();
            }
            else
            {
                //tbx_searchObjects.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateTheObjectsDataset();
        }

        private void btn_objectsForm_Click(object sender, EventArgs e)
        {
            frm_objects _objects = new frm_objects();
            _objects.ShowDialog();

            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objects' table. You can move, or remove it, as needed.
            this.tbl_objectsTableAdapter.Fill(this.ds_objectGrouping.tbl_objects);

            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_slaveGroups' table. You can move, or remove it, as needed.
            this.tbl_slaveGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_slaveGroups);

            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_masterGroups' table. You can move, or remove it, as needed.
            this.tbl_masterGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_masterGroups);

            loadGroups();
        }

       private void bs_objects_CurrentChanged(object sender, EventArgs e)
        {
            if (bs_objects.Count == 0) return;

            cbx_allPrice.Items.Clear();
            cbx_allPrice.Items.Add(ds_objectGrouping.tbl_objects[bs_objects.Position]["object_retailSellPrice"].ToString());
            cbx_allPrice.Items.Add(ds_objectGrouping.tbl_objects[bs_objects.Position]["object_sellPrice2"].ToString());
            cbx_allPrice.Items.Add(ds_objectGrouping.tbl_objects[bs_objects.Position]["object_sellPrice3"].ToString());

            cbx_allPrice.SelectedIndex = n_rangePrice - 1;
        }

       private void btn_showObjectGrouping_Click(object sender, EventArgs e)
       {
           if (btn_showObjectGrouping.Text == "<")//if expand
           {
               pnl_groupingSet.Left = 400;
               pnl_objectSet.Width = pnl_groupingSet.Left - 10;
               btn_showObjectGrouping.Text = ">";

               try
               {
                   bs_objects.Filter = "slaveGroup_id = " + treeView1.SelectedNode.Tag;
               }
               catch
               {
               }
               treeView1.Focus();
           }
           else//if collapse
           {
               pnl_groupingSet.Left = 640;
               pnl_objectSet.Width = pnl_groupingSet.Left - 10;               
               btn_showObjectGrouping.Text = "<";

               bs_objects.RemoveFilter();

               tbx_searchObjects.Focus();
           }
       }

       private void tbx_searchObjects_TextChanged(object sender, EventArgs e)
       {
           string s_filterExpression = "";
           if (chk_searchWithin.Checked)
           {
               s_filterExpression = "object_title LIKE '%{0}%'";
           }
           else
           {
               s_filterExpression = "object_title LIKE '{0}%'";
           }
           if (btn_showObjectGrouping.Text == ">")//if object groups already expanded
           {
               try
               {
                   s_filterExpression += " AND slaveGroup_id = " + treeView1.SelectedNode.Tag;
               }
               catch
               {
               }
           }
           s_filterExpression = string.Format(s_filterExpression, tbx_searchObjects.Text);
           bs_objects.Filter = s_filterExpression;
       }

       private void tbx_searchObjects_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar == (char)Keys.Return) dgv_objects.Focus();
       }            

       private void dgw_invoiceSell_CellEndEdit(object sender, DataGridViewCellEventArgs e)
       {
           //DataRow row_selectedObject = ds_buyInvoices.tbl_itemsBuy.Rows. .Find(n_objectID);
           int n_itemSell_unitCount = (int)ds_sellInvoices.tbl_itemsSell.Rows[bs_itemsSell.Position]["itemSell_unitCount"];
           long n_itemSell_retailCount = (long )ds_sellInvoices.tbl_itemsSell.Rows[bs_itemsSell.Position]["itemSell_retailCount"];
           int n_objectID = (int)ds_sellInvoices.tbl_itemsSell.Rows[bs_itemsSell.Position]["object_id"];


           DataRow row_selectedObject = ds_objectGrouping.tbl_objects.Rows.Find(n_objectID);
           int n_objectEntity = (int)row_selectedObject["object_entity"];
           int n_objectRetailInUnit = (int)row_selectedObject["object_retailInUnit"];

           int n_objectUnitCount = (int)n_objectEntity / n_objectRetailInUnit;
           int n_objectRetailCount = n_objectEntity - (n_itemSell_unitCount * n_objectRetailInUnit);

           if (e.ColumnIndex == 0)
           {
               if (n_itemSell_unitCount > n_objectUnitCount)
               {
                   ds_sellInvoices.tbl_itemsSell.Rows[bs_itemsSell.Position]["itemSell_unitCount"] = n_objectUnitCount - (n_itemSell_retailCount / n_objectRetailInUnit);
                   n_itemSell_unitCount = (int)ds_sellInvoices.tbl_itemsSell.Rows[bs_itemsSell.Position]["itemSell_unitCount"];
                   n_objectRetailCount = n_objectEntity - (n_itemSell_unitCount * n_objectRetailInUnit);
                   ds_sellInvoices.tbl_itemsSell.Rows[bs_itemsSell.Position]["itemSell_retailCount"] = n_objectRetailCount;
               }

           }
           else if ( e.ColumnIndex == 1)
           {
               if (n_itemSell_retailCount > n_objectRetailCount)
               {
                   ds_sellInvoices.tbl_itemsSell.Rows[bs_itemsSell.Position]["itemSell_retailCount"] = n_objectRetailCount;
               }
           }
       }

       private void frm_itemSelection_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control)
           {
               if (e.KeyCode == Keys.Right)
               {
                   if (btn_showObjectGrouping.Text == ">")//if objectGrouping already expanded
                   {
                       treeView1.Focus();
                   }
               }
               else if (e.KeyCode == Keys.Left)
               {
                   if (btn_showObjectGrouping.Text == ">")//if objectGrouping already expanded
                   {
                       dgv_objects.Focus();
                   }
               }
               else if (e.KeyCode == Keys.Down)
               {
                   if (!dgv_objects.Focused)
                   {
                       dgv_objects.Focus();
                   }
                   else
                   {
                       if (openMode == 0)//0 means open Buy mode
                       {
                           dgw_invoiceBuy.Focus();
                       }
                       else if (openMode == 1)//1 means open sell mode
                       {
                           dgw_invoiceSell.Focus();
                       }
                       else if (openMode == 2)//2 means open wasted mode
                       {
                           dgw_itemsWasted.Focus();
                       }
                   }
               }
               else if (e.KeyCode == Keys.Up)
               {
                   if (!dgv_objects.Focused)
                   {
                       dgv_objects.Focus();
                   }
                   else
                   {
                       tbx_searchObjects.Focus();
                   }
               }
               else if (e.KeyCode == Keys.Space)
               {
                   btn_showObjectGrouping.PerformClick();
               }
               else if (e.KeyCode == Keys.Enter)
               {
                   btn_ok.PerformClick();
               }
               else if (e.KeyCode == Keys.Delete)
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

               //e.Handled = true;
               e.SuppressKeyPress = true;
           }           
       }

       private void dgv_objects_Enter(object sender, EventArgs e)
       {
           dgv_objects.BackgroundColor = Color.LightYellow;
       }

       private void dgv_objects_Leave(object sender, EventArgs e)
       {
           dgv_objects.BackgroundColor = Color.Silver;
       }

       private void dgw_itemsWasted_Enter(object sender, EventArgs e)
       {
           dgw_itemsWasted.BackgroundColor = Color.LightYellow;
       }

       private void dgw_itemsWasted_Leave(object sender, EventArgs e)
       {
           dgw_itemsWasted.BackgroundColor = Color.Silver;
       }

       private void dgw_invoiceSell_Enter(object sender, EventArgs e)
       {
           dgw_invoiceSell.BackgroundColor = Color.LightYellow;
       }

       private void dgw_invoiceSell_Leave(object sender, EventArgs e)
       {
           dgw_invoiceSell.BackgroundColor = Color.Silver;
       }

       private void dgw_invoiceBuy_Enter(object sender, EventArgs e)
       {
           dgw_invoiceBuy.BackgroundColor = Color.LightYellow;
       }

       private void dgw_invoiceBuy_Leave(object sender, EventArgs e)
       {
           dgw_invoiceBuy.BackgroundColor = Color.Silver;
       }

       private void tbx_searchObjects_Enter(object sender, EventArgs e)
       {
           tbx_searchObjects.BackColor = Color.LightYellow;
       }

       private void tbx_searchObjects_Leave(object sender, EventArgs e)
       {
           tbx_searchObjects.BackColor = Color.White;
       }

       private void treeView1_Leave(object sender, EventArgs e)
       {
           treeView1.BackColor = Color.White;
       }

       private void frm_itemSelection_KeyPress(object sender, KeyPressEventArgs e)
       {
           //هرکارکتری از حروف الفبا فشرده شود تکس باکس جستجو فوکوس میشود اما اگر عدد فشرده شود خیر
           long isNumber = 0;
           if ((!long.TryParse(e.KeyChar.ToString(), out isNumber)) && (e.KeyChar != (char)Keys.Back))
           {
               tbx_searchObjects.Focus();
           }
       }

       private void dgw_itemsWasted_KeyDown(object sender, KeyEventArgs e)
       {           
       }

       private int get_numberOfAshantyunToTakhfif(int n_numberOfAshantyun)
       {
           return 0;
       }
    }
}
