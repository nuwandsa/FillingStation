using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillingStation.UI.Sales
{
    public partial class frmInvoice : MetroFramework.Forms.MetroForm
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        string currentevent;
        internal DataTable SearchResult, SearchResult1;

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            btnInvoNew_Click(sender, e);
            UpdateSearchList();
        }

        internal void UpdateSearchList()
        {
            SearchResult = new Logic.ItemService().getSearchResults();
            SearchResult1 = new Logic.ItemService().getSearchResults();
            dgdInvoItemSearch.DataSource = SearchResult;
        }

        private void txtItemCode_Click(object sender, EventArgs e)
        {
            if (!dgdInvoItemSearch.Visible)
            {
                dgdInvoItemSearch.Visible = true;
            }
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            if (!txtItemCode.Focused && !dgdInvoItemSearch.Focused)
            {
                dgdInvoItemSearch.Visible = false;
            }

            if (txtItemCode.Text != string.Empty && !dgdInvoItemSearch.Focused)
            {
                if (new Logic.ItemService().ValiedId(txtItemCode.Text) != 0)
                {
                    toItemDeit(new Logic.ItemService().seaarchItemId(txtItemCode.Text));
                  
                }
                else if (new Logic.ItemService().ValiedId(txtItemCode.Text) == 0)
                {
                    MessageBox.Show("Please Enter Valied Item ID");
                    txtItemCode.Focus();
                }
            }
          
        }

        private void btnInvoNew_Click(object sender, EventArgs e)
        {
            currentevent = "newmode";
            clearfield();
            cancelprotectField();

            txtInvoiceID.Text = findNextId().ToString();
        }

        internal void clearfield()
        {
            txtCustomer.Clear();
            txtInvoicesearch.Clear();
            txtItemCode.Clear();
            txtItemName.Clear();
            txtItemQuantity.Text ="0.00";
            txtUoM.Clear();
            txtItmUnitPrice.Text = "0.00";
            txtSubTotal.Text = "0.00";
            dgdInvoice.Rows.Clear();
            txtInvoiceTotal.Text = "0.00";
            txtInvoDiscRate.Text = "0.00";
            txtInvoiceDiscount.Text = "0.00";
            txtInvoiceTotalDue.Text = "0.00";
            cboInvoicePaymentMethod.SelectedItem = "Cash";
            txtInvoicePaidAmount.Text = "0.00";
            txtPayingAmount.Text = "0.00";
            txtInvoiceBalance.Text = "0.00";
        }

        internal void cancelprotectField()
        {
            txtCustomer.Enabled = true;
            txtInvoicesearch.Enabled = true;
            txtItemCode.Enabled = true;
            txtItemName.Enabled = true;
            txtItemQuantity.Enabled = true;
            txtUoM.Enabled = true;
            txtItmUnitPrice.Enabled = true;
            txtSubTotal.Enabled = true;
            dgdInvoice.Enabled = true;
            txtInvoiceTotal.Enabled = true;
            txtInvoDiscRate.Enabled = true;
            txtInvoiceDiscount.Enabled = true;
            txtInvoiceTotalDue.Enabled = true;
            cboInvoicePaymentMethod.Enabled = true;
            txtPayingAmount.Text = "0.00";
            txtInvoiceBalance.Enabled = true;
        }
        public string findNextId()
        {
            int countNext;
            string invoID = "";
            int ans = 1;

            for (countNext = 1; ans != 0; countNext++)
            {
                invoID = "INVO-" + countNext.ToString().PadLeft(Data.Global.invoiceLength, '0');
                ans = new Logic.POSInvoService().NextId(invoID);
            }
            return invoID;
        }

        internal void toItemDeit(Logic.Item itm)
        {
            txtItemCode.Text = itm.strItemID;
            txtItemName.Text = itm.strItemName;
            txtUoM.SelectedText = itm.strItemUoM;
            txtItmUnitPrice.Text = Convert.ToString(itm.dmlItemSellingPrice);
        }
        private void dgdInvoItemSearch_Leave(object sender, EventArgs e)
        {
            if (!txtItemCode.Focused && !dgdInvoItemSearch.Focused)
            {
                dgdInvoItemSearch.Visible = false;
            }
        }

        private void dgdInvoItemSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtItemCode.Text = this.dgdInvoItemSearch.CurrentRow.Cells[0].Value.ToString();
            txtItemName.Text= this.dgdInvoItemSearch.CurrentRow.Cells[1].Value.ToString();
            dgdInvoItemSearch.Visible = false;
            txtItemQuantity.Focus();
        }

        private void txtItemQuantity_Leave(object sender, EventArgs e)
        {
            decimal distance;
            if (txtItemQuantity.Text != "")
            {
                if (decimal.TryParse(txtItemQuantity.Text, out distance))
                {
                    txtSubTotal.Text = Convert.ToString(Convert.ToDouble(txtItemQuantity.Text) * Convert.ToDouble(txtItmUnitPrice.Text));
                }
                    }
        }


        private void txtItemQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtItemCode.Focus();
                Logic.InvoItem invit = new Logic.InvoItem();
                invit.strInvoItemCode = txtItemCode.Text;
                invit.strInvoItemName = txtItemName.Text;
                invit.dcmlInvoQty = decimal.Parse(txtItemQuantity.Text);
                invit.strInvoItemUoM = txtUoM.Text;
                invit.dcmlInvoUnitPrice = decimal.Parse(txtItmUnitPrice.Text);
                invit.dcmlInvoItmSubTot = Convert.ToDecimal(txtSubTotal.Text);

                toTable(invit);

                txtItemCode.Clear();
                txtItemName.Clear();
                txtItemQuantity.Text = "0.00";
                txtUoM.Clear();
                txtItmUnitPrice.Text = "0.00";
                txtSubTotal.Text = "0.00";

                txtInvoiceTotal.Text = Convert.ToString(calculateTotal());

            }
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            dgdInvoItemSearch.Visible = true;
            if (!string.IsNullOrEmpty(txtItemCode.Text))
            {
                DataView dv = SearchResult.DefaultView;
                //dv.RowFilter = string.Format("SupplierID like'%{0}%' or SupplierName like'%{0}%'", txtSearchBox.Text);
                dv.RowFilter = string.Format("ID like'%{0}%' or NME like'%{0}%'", txtItemCode.Text);
                dgdInvoItemSearch.DataSource = dv.ToTable();
            }
            else if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                dgdInvoItemSearch.DataSource = null;
                dgdInvoItemSearch.DataSource = SearchResult1;
                dgdInvoItemSearch.Refresh();
            }
        }

        internal void toTable(Logic.InvoItem invit)
        {

            int cunt = dgdInvoice.RowCount-1;
            dgdInvoice.Rows.Add();

            dgdInvoice.Rows[cunt].Cells["colInvoiceItemCode"].Value = Convert.ToString(invit.strInvoItemCode);
            dgdInvoice.Rows[cunt].Cells["colInvoiceItemName"].Value = invit.strInvoItemName;
            dgdInvoice.Rows[cunt].Cells["colInvoiceQuantity"].Value = invit.dcmlInvoQty;
            dgdInvoice.Rows[cunt].Cells["colInvoiceItemUoM"].Value = invit.strInvoItemUoM;
            dgdInvoice.Rows[cunt].Cells["colInvoiceUnitPrice"].Value = invit.dcmlInvoUnitPrice;
            dgdInvoice.Rows[cunt].Cells["colInvoiceSubTotal"].Value = invit.dcmlInvoItmSubTot;

            //dgdInvoice.SelectedRows[0].Cells["colInvoiceItemCode"].Value = Convert.ToString(invit.strInvoItemCode);
            //dgdInvoice.SelectedRows[0].Cells["colInvoiceItemName"].Value = invit.strInvoItemName;
            //dgdInvoice.SelectedRows[0].Cells["colInvoiceQuantity"].Value = invit.dcmlInvoQty;
            //dgdInvoice.SelectedRows[0].Cells["colInvoiceItemUoM"].Value = invit.strInvoItemUoM;
            //dgdInvoice.SelectedRows[0].Cells["colInvoiceUnitPrice"].Value = invit.dcmlInvoUnitPrice;
            //dgdInvoice.SelectedRows[0].Cells["colInvoiceSubTotal"].Value = invit.dcmlInvoItmSubTot;
        }



        private bool emptyorNull(DataGridViewCell cell)
        {
            bool empty = false;
            if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrWhiteSpace(cell.Value.ToString()))
            {
                empty = true;
            }
            return empty;
        }

        private void dgdInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgdInvoice.Columns[e.ColumnIndex].Name == "colInvoiceSubTotal")
            {
                txtInvoiceTotal.Text=Convert.ToString(calculateTotal());
            }
        }

        private decimal calculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgdInvoice.Rows.Count; i++)
            {
                if (!emptyorNull(dgdInvoice.Rows[i].Cells["colInvoiceSubTotal"]))
                {
                    total += Convert.ToDecimal(dgdInvoice.Rows[i].Cells["colInvoiceSubTotal"].Value);
                }
            }
            return total;
        }

        private void txtInvoDiscRate_Leave(object sender, EventArgs e)
        {
            txtInvoiceDiscount.Text = Convert.ToString(caldiscount());
        }

        private void txtInvoDiscRate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                cboInvoicePaymentMethod.Focus();
            }
        }

        private void txtInvoiceTotal_TextChanged(object sender, EventArgs e)
        {
            txtInvoiceTotalDue.Text = Convert.ToString(calTotdue());
        }

        internal decimal caldiscount()
        {
            decimal discount = (Convert.ToDecimal(txtInvoiceTotal.Text) /100) * Convert.ToDecimal(txtInvoDiscRate.Text);
            return discount;
        }

        private void txtInvoiceDiscount_TextChanged(object sender, EventArgs e)
        {
            txtInvoiceTotalDue.Text = Convert.ToString(calTotdue());
        }

        internal decimal calTotdue()
        {
            decimal totdue = Convert.ToDecimal(txtInvoiceTotal.Text) - Convert.ToDecimal(txtInvoiceDiscount.Text);
            return totdue;
        }

        private void txtPayingAmount_TextChanged(object sender, EventArgs e)
        {
            txtInvoiceBalance.Text = Convert.ToString(calBalence());
        }

        private void btnInvosave_Click(object sender, EventArgs e)
        {
              
        }

        internal decimal calBalence()
        {
            decimal bal = Convert.ToDecimal(txtInvoiceTotalDue.Text) - Convert.ToDecimal(txtPayingAmount.Text);
            return bal;
        }

        internal DataTable fromInvoTable()
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < dgdInvoice.Columns.Count; i++)
            {
                dt.Columns.Add(dgdInvoice.Columns[i].Name);
            }
            foreach (DataGridViewRow row in dgdInvoice.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgdInvoice.Columns.Count; j++)
                {
                    dr[dgdInvoice.Columns[j].Name] = row.Cells[j].Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

    }
}
