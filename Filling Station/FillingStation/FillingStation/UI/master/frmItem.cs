using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillingStation.UI.master
{
    public partial class frmItem : MetroFramework.Forms.MetroForm
    {
        public frmItem()
        {
            InitializeComponent();
        }
        string currentevent;
        internal DataTable SearchResult, SearchResult1;

        private void frmItem_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
            UpdateSearchList();
        }
        internal void UpdateSearchList()
        {
            SearchResult = new Logic.ItemService().getSearchResults();
            SearchResult1 = new Logic.ItemService().getSearchResults();
            dgdItemSearch.DataSource = SearchResult;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtItemID.Text=="")
            {
                MessageBox.Show("Please eEnter Valied Item ID");
                txtItemID.Focus();
            }

            else if(txtItemID.Text!="")
            {
                if(currentevent=="newmode")
                {
                    try
                    {
                        if(new Logic.ItemService().insertItem(fromUi()))
                        {
                            MessageBox.Show("Save Successfully");
                            clearfield();
                            cancelprotectedfield();
                            UpdateSearchList();
                        }
                        else
                        {
                            MessageBox.Show("save failed");
                        }
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                }

                else if (currentevent == "editmode")
                {
                    try
                    {
                        if (new Logic.ItemService().updateItem(fromUi()))
                        {
                            MessageBox.Show("Updated");
                            clearfield();                  //CLEAR FIELD
                            cancelprotectedfield();          //CANCEL PROTECTION
                            UpdateSearchList();
                        }
                        else
                        {

                            MessageBox.Show("Not Updated");
                        }
                    }
                    catch (Exception ex2)
                    {

                        throw ex2;
                    }
                }
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            currentevent = "newmode";
            clearfield();
            cancelprotectedfield();
            //INSERT NEXT VALIEDD ID

            txtItemID.Text = findNextId().ToString();
        }

        private Logic.Item fromUi()
        {
            Logic.Item itm = new Logic.Item();

            itm.strItemID =   txtItemID.Text;
            itm.strItemName = txtItemName.Text;
            itm.strItemDescription = txtItemDesc.Text;
            if (rbtlubricant.Checked)
            {
                itm.strItemCategory = "lubricant";
            }
            else if (rbtother.Checked)
            {
                itm.strItemCategory = "other";
            }
            itm.strItemUoM = cmbItemUoM.SelectedItem.ToString();
            itm.fltItemReOderLevel = float.Parse(txtReOrderLevel.Text);
            itm.fltcurrentStock = float.Parse(txtcurrrentStock.Text);
            itm.dmlItemCostPrice = Convert.ToDecimal(txtItmCostPrice.Text);
            itm.dmlItemSellingPrice = Convert.ToDecimal(txtItemSellingPrice.Text);

            return itm;
        }

        private void clearfield()
        {
            txtItemID.Text="";
            txtItemName.Text="";
            txtItemDesc.Text="";
            rbtlubricant.Checked = true;
            rbtother.Checked = false;
            cmbItemUoM.SelectedItem = "l";
            txtReOrderLevel.Text = "0.00";
            txtcurrrentStock.Text = "0.00";
            txtItmCostPrice.Text = "0.00";
            txtItemSellingPrice.Text = "0.00";
            txtsearch.Text = "";

        }

        private void cancelprotectedfield()
        {
            txtItemID.Enabled = true;
            txtItemName.Enabled = true;
            txtItemDesc.Enabled = true;
            rbtlubricant.Enabled = true;
            rbtother.Enabled = true;
            cmbItemUoM.Enabled = true;
            txtReOrderLevel.Enabled = true;
            txtcurrrentStock.Enabled = true;
            txtItmCostPrice.Enabled = true;
            txtItemSellingPrice.Enabled = true;
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            if (!dgdItemSearch.Visible)
            {
                dgdItemSearch.Visible = true;
            }
        }

        private void txtsearch_Leave(object sender, EventArgs e)
         {
            if (!txtsearch.Focused && !dgdItemSearch.Focused)
            {
                dgdItemSearch.Visible = false;
            }
        }

        private void dgdItemSearch_Leave(object sender, EventArgs e)
        {
            if (!txtsearch.Focused && !dgdItemSearch.Focused)
            {
                dgdItemSearch.Visible = false;
            }
        }

        private void dgdItemSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtsearch.Text = this.dgdItemSearch.CurrentRow.Cells[0].Value.ToString();
            dgdItemSearch.Visible = false;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != string.Empty)
            {
                if (new Logic.ItemService().ValiedId(txtsearch.Text) != 0)
                {
                    currentevent = "viewmode";
                    toItem(new Logic.ItemService().seaarchItemId(txtsearch.Text));
                    portectField();
                }
                else if (new Logic.ItemService().ValiedId(txtsearch.Text) == 0)
                {
                    MessageBox.Show("Please Enter Valied Item ID");
                    txtsearch.Focus();
                }
            }
            else if (txtsearch.Text == string.Empty)
            {
                MessageBox.Show("Please enter valied Item ID");
                txtsearch.Focus();
            }
        }

        public string findNextId()
        {
            int countNext;
            string ItemID = "";
            int ans = 1;

            for (countNext = 1; ans != 0; countNext++)
            {
                ItemID = "ITM/" + countNext.ToString().PadLeft(Data.Global.itemLength, '0');
                ans = new Logic.ItemService().NextId(ItemID);
            }
            return ItemID;
        }

        internal void toItem(Logic.Item itm)
        {


            txtItemID.Text = itm.strItemID;
            txtItemName.Text = itm.strItemName;
            txtItemDesc.Text = itm.strItemDescription;        
            if (itm.strItemCategory == "lubricant")
            {
                rbtlubricant.Checked=true;
            }
            else if (itm.strItemCategory == "other")
            {
                rbtother.Checked = true;
            }
            cmbItemUoM.SelectedText = itm.strItemUoM;
            txtReOrderLevel.Text = Convert.ToString(itm.fltItemReOderLevel);
            txtcurrrentStock.Text = Convert.ToString(itm.fltcurrentStock);
            txtItmCostPrice.Text= Convert.ToString(itm.dmlItemCostPrice);
            txtItemSellingPrice.Text=Convert.ToString(itm.dmlItemSellingPrice);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != string.Empty)                                                           // Check search box(Combo box) fill or not
            {
                if (new Logic.ItemService().ValiedId(txtsearch.Text) != 0)                            // Search id or NIC in Database
                {
                    currentevent = "editmode";
                    toItem(new Logic.ItemService().seaarchItemId(txtsearch.Text));
                    cancelprotectedfield();       //CANCEL PROTECTION
                    txtItemID.Enabled = false;
                }
                else if (new Logic.ItemService().ValiedId(txtsearch.Text) == 0)                       // Search id or NIC in Database
                {
                    MessageBox.Show("Please Enter Valied Item ID");
                    txtsearch.Focus();
                }
            }
            else if (txtsearch.Text == string.Empty)                                                      // Check search box(Combo box) fill or not
            {
                MessageBox.Show("Please enter valied Item ID");
                txtsearch.Focus();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsearch.Text))
            {
                DataView dv = SearchResult.DefaultView;
                //dv.RowFilter = string.Format("SupplierID like'%{0}%' or SupplierName like'%{0}%'", txtSearchBox.Text);
                dv.RowFilter = string.Format("ID like'%{0}%' or NME like'%{0}%'", txtsearch.Text);
                dgdItemSearch.DataSource = dv.ToTable();
            }
            else if (string.IsNullOrEmpty(txtsearch.Text))
            {
                dgdItemSearch.DataSource = null;
                dgdItemSearch.DataSource = SearchResult1;
                dgdItemSearch.Refresh();
            }
        }

        internal void portectField()
        {
            txtItemID.Enabled = false;
            txtItemName.Enabled = false;
            txtItemDesc.Enabled = false;
            rbtlubricant.Enabled = false;
            rbtother.Enabled = false;
            cmbItemUoM.Enabled = false;
            txtReOrderLevel.Enabled = false;
            txtcurrrentStock.Enabled = false;
            txtItmCostPrice.Enabled = false;
            txtItemSellingPrice.Enabled = false;
        }

    }
}
