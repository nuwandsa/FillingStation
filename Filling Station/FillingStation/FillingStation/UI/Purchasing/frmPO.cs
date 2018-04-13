using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillingStation.UI.Purchasing
{
    public partial class frmPO : MetroFramework.Forms.MetroForm
    {
        public frmPO()
        {
            InitializeComponent();
        }
        string currentevent;
        internal DataTable SearchResult, SearchResult1;
        private void frmPO_Load(object sender, EventArgs e)
        {
            btnPONew_Click(sender, e);
            UpdateSearchList();
        }

        private void btnPONew_Click(object sender, EventArgs e)
        {
            currentevent = "newmode";
            clearfield();
            cancelprotectField();

            txtPONO.Text = findNextId().ToString();
        }
        internal void UpdateSearchList()
        {
            SearchResult = new Logic.ItemService().getSearchResults();
            SearchResult1 = new Logic.ItemService().getSearchResults();
            dgdPOItemSearch.DataSource = SearchResult;
        }

        public string findNextId()
        {
            int countNext;
            string PONo = "";
            int ans = 1;

            for (countNext = 1; ans != 0; countNext++)
            {
                PONo = "PO-" + countNext.ToString().PadLeft(Data.Global.POLength, '0');
                ans = new Logic.POSInvoService().NextId(PONo);
            }
            return PONo;
        }
        internal void clearfield()
        {
            txtPOsearch.Clear();
            txtPOItemCode.Clear();
            txtPOItemName.Clear();
            txtPOItemQuantity.Text = "0.00";
            txtPOUoM.Clear();
            txtPOItmUnitPrice.Text = "0.00";
            txtPOSubTotal.Text = "0.00";
            dgdPO.Rows.Clear();
            txtPOSuplierName.Clear();
            txtPODliverToAddress.Clear();
            txtPODate.Text = Convert.ToString(DateTime.Today.Date);
        }

        private void txtPOItemCode_Click(object sender, EventArgs e)
        {
            if (!dgdPOItemSearch.Visible)
            {
                dgdPOItemSearch.Visible = true;
            }
        }

        private void txtPOItemCode_Leave(object sender, EventArgs e)
        {
            if (!txtPOItemCode.Focused && !dgdPOItemSearch.Focused)
            {
                dgdPOItemSearch.Visible = false;
            }

            if (txtPOItemCode.Text != string.Empty && !dgdPOItemSearch.Focused)
            {
                if (new Logic.ItemService().ValiedId(txtPOItemCode.Text) != 0)
                {
                    toItemDeit(new Logic.ItemService().seaarchItemId(txtPOItemCode.Text));

                }
                else if (new Logic.ItemService().ValiedId(txtPOItemCode.Text) == 0)
                {
                    MessageBox.Show("Please Enter Valied Item ID");
                    txtPOItemCode.Focus();
                }
            }
        }

        internal void cancelprotectField()
        {
            txtPOItemCode.Enabled = true;
            txtPOItemName.Enabled = true;
            txtPOItemQuantity.Enabled = true;
            txtPOUoM.Enabled = true;
            txtPOItmUnitPrice.Enabled = true;
            txtPOSubTotal.Enabled = true;
            dgdPO.Enabled = true;
            txtPOSuplierName.Enabled = true;
            txtPODliverToAddress.Enabled = true;
            txtPODate.Enabled = true;
        }

        private void txtPOItemCode_TextChanged(object sender, EventArgs e)
        {
            dgdPOItemSearch.Visible = true;
            if (!string.IsNullOrEmpty(txtPOItemCode.Text))
            {
                DataView dv = SearchResult.DefaultView;
                //dv.RowFilter = string.Format("SupplierID like'%{0}%' or SupplierName like'%{0}%'", txtSearchBox.Text);
                dv.RowFilter = string.Format("ID like'%{0}%' or NME like'%{0}%'", txtPOItemCode.Text);
                dgdPOItemSearch.DataSource = dv.ToTable();
            }
            else if (string.IsNullOrEmpty(txtPOItemCode.Text))
            {
                dgdPOItemSearch.DataSource = null;
                dgdPOItemSearch.DataSource = SearchResult1;
                dgdPOItemSearch.Refresh();
            }
        }

        private void dgdPOItemSearch_Leave(object sender, EventArgs e)
        {
            if (!txtPOItemCode.Focused && !dgdPOItemSearch.Focused)
            {
                dgdPOItemSearch.Visible = false;
            } 
        }

        private void dgdPOItemSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtPOItemCode.Text = this.dgdPOItemSearch.CurrentRow.Cells[0].Value.ToString();
            txtPOItemName.Text = this.dgdPOItemSearch.CurrentRow.Cells[1].Value.ToString();
            dgdPOItemSearch.Visible = false;
            txtPOItemQuantity.Focus();
        }

        private void txtPOItemQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPOItemCode.Focus();
                Logic.POItem poitm = new Logic.POItem();
                poitm.strPOItemCode = txtPOItemCode.Text;
                poitm.strPOItemName = txtPOItemName.Text;
                poitm.dcmlPOQty = decimal.Parse(txtPOItemQuantity.Text);
                poitm.strPOItemUoM = txtPOUoM.Text;
                poitm.dcmlPOUnitPrice = decimal.Parse(txtPOItmUnitPrice.Text);
                poitm.dcmlPOItmSubTot = Convert.ToDecimal(txtPOSubTotal.Text);

                toTable(poitm);

                txtPOItemCode.Clear();
                txtPOItemName.Clear();
                txtPOItemQuantity.Text = "0.00";
                txtPOUoM.Clear();
                txtPOItmUnitPrice.Text = "0.00";
                txtPOSubTotal.Text = "0.00";
                 
                //txtInvoiceTotal.Text = Convert.ToString(calculateTotal());

            }
        }

        internal void toItemDeit(Logic.Item itm)
        {
            txtPOItemCode.Text = itm.strItemID;
            txtPOItemName.Text = itm.strItemName;
            txtPOUoM.SelectedText = itm.strItemUoM;
            txtPOItmUnitPrice.Text = Convert.ToString(itm.dmlItemSellingPrice);
        }

        private void btnPOsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPONO.Text))
            {
                MessageBox.Show("Please Enter PO Number");
                txtPONO.Focus();
            }
            if (string.IsNullOrEmpty(txtPOSuplierName.Text))
            {
                MessageBox.Show("Please Enter Supplier");
                txtPOSuplierName.Focus();
            }

            else if (!string.IsNullOrEmpty(txtPONO.Text) && !string.IsNullOrEmpty(txtPOSuplierName.Text))
            {
                if (currentevent == "newmode" || currentevent == "copymode")
                {
                    bool saved = new Logic.POService().insertPOHead(fromPOHead());
                    if (saved)
                    {
                        new Logic.POService().insertPORow(txtPONO.Text, fromPOTable());
                        MessageBox.Show("Saved");
                    }
                }
                //else if (currentevent == "editmode")
                //{
                //    new Logic.POService().DeletePORows(txtPONO.Text);

                //    bool saved = new Logic.POService().updatePO(fromPOHead());
                //    if (saved)
                //    {
                //        new Logic.POService().insertPORow(txtPONO.Text, fromPOTable());
                //        MessageBox.Show("Updated");
                //    }
                //}
            }
            }

        internal void toTable(Logic.POItem poitm)
        {

            int cunt = dgdPO.RowCount - 1;
            dgdPO.Rows.Add();

            dgdPO.Rows[cunt].Cells["colPOItemCode"].Value = Convert.ToString(poitm.strPOItemCode);
            dgdPO.Rows[cunt].Cells["colPOItemName"].Value = poitm.strPOItemName;
            dgdPO.Rows[cunt].Cells["colPOQuantity"].Value = poitm.dcmlPOQty;
            dgdPO.Rows[cunt].Cells["colPOItemUoM"].Value = poitm.strPOItemUoM;
            dgdPO.Rows[cunt].Cells["colPOUnitPrice"].Value = poitm.dcmlPOUnitPrice;
            dgdPO.Rows[cunt].Cells["colPOSubTotal"].Value = poitm.dcmlPOItmSubTot;
        }

        internal Logic.PO fromPOHead()
        {
            Logic.PO po = new Logic.PO();
            po.PONo = txtPONO.Text;
            po.POSupplier = txtPOSuplierName.Text;
            po.PODate = Convert.ToDateTime(txtPODate.Text);
            po.DiliverToAddress = txtPODliverToAddress.Text;

            return po;
        }

        internal DataTable fromPOTable()
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < dgdPO.Columns.Count; i++)
            {
                dt.Columns.Add(dgdPO.Columns[i].Name);
            }
            foreach (DataGridViewRow row in dgdPO.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgdPO.Columns.Count; j++)
                {
                    dr[dgdPO.Columns[j].Name] = row.Cells[j].Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        //internal bool updatePO(Logic.PO pmPO)
        //{
        //    try
        //    {
        //        string query = "UPDATE tblPOHeader SET "
        //                                             + "strPOSupID			='" + pmPO.strPOSupID + "'"
        //                                             + ",dmlPOGrossAmount	='" + pmPO.dmlPOGrossAmount + "'"
        //                                             + ",dmlPODiscount		='" + pmPO.dmlPODiscount + "'"
        //                                             + ",dmlPONetAmount		='" + pmPO.dmlPONetAmount + "'"
        //                                             + ",blnPOApproved		='" + pmPO.blnPOApproved + "'"
        //                                         + "WHERE strPONO 			= '" + pmPO.strPONO + "' ";

        //        using (Data.DataAccessMySQL.Connect())
        //        {
        //            try
        //            {
        //                if (Data.DataAccessMySQL.AddEditDel(query))
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //            catch (Exception ex1)
        //            {

        //                throw ex1;
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
