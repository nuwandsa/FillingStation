using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillingStation.UI.Stock
{
    public partial class frmRemainingBalance : MetroFramework.Forms.MetroForm
    {
        public frmRemainingBalance()
        {
            InitializeComponent();
        }
        internal DataTable SearchResult, SearchResult1, SearchResultRB;
        private void frmRemainingBalance_Load(object sender, EventArgs e)
        {
            UpdateSearchList();
            totable();
        }

        private void txtRBItemCode_Click(object sender, EventArgs e)
        {
            if (!dgdRBItemSearch.Visible)
            {
                dgdRBItemSearch.Visible = true;
            }
        }

        private void txtRBItemCode_Leave(object sender, EventArgs e)
        {
            if (!txtRBItemCode.Focused && !dgdRBItemSearch.Focused)
            {
                dgdRBItemSearch.Visible = false;
            }

            if (txtRBItemCode.Text != string.Empty && !dgdRBItemSearch.Focused)
            {
                if (new Logic.ItemService().ValiedId(txtRBItemCode.Text) != 0)
                {
                    toItemDeit(new Logic.ItemService().seaarchItemId(txtRBItemCode.Text));

                }
                else if (new Logic.ItemService().ValiedId(txtRBItemCode.Text) == 0)
                {
                    MessageBox.Show("Please Enter Valied Item ID");
                    txtRBItemCode.Focus();
                }
            }
        }

        internal void toItemDeit(Logic.Item itm)
        {
            txtRBItemCode.Text = itm.strItemID;
            txtRBItemName.Text = itm.strItemName;
            txtRBUoM.SelectedText = itm.strItemUoM;
            txtRBQty.Text = Convert.ToString(new Logic.RemainingQtyService().getQty(itm.strItemID));

        }

        private void txtRBItemCode_TextChanged(object sender, EventArgs e)
        {
            dgdRBItemSearch.Visible = true;
            if (!string.IsNullOrEmpty(txtRBItemCode.Text))
            {
                DataView dv = SearchResult.DefaultView;
                //dv.RowFilter = string.Format("SupplierID like'%{0}%' or SupplierName like'%{0}%'", txtSearchBox.Text);
                dv.RowFilter = string.Format("ID like'%{0}%' or NME like'%{0}%'", txtRBItemCode.Text);
                dgdRBItemSearch.DataSource = dv.ToTable();
            }
            else if (string.IsNullOrEmpty(txtRBItemCode.Text))
            {
                dgdRBItemSearch.DataSource = null;
                dgdRBItemSearch.DataSource = SearchResult1;
                dgdRBItemSearch.Refresh();
            }
        }

        private void dgdRBItemSearch_Leave(object sender, EventArgs e)
        {
            if (!txtRBItemCode.Focused && !dgdRBItemSearch.Focused)
            {
                dgdRBItemSearch.Visible = false;
            }
        }

        private void dgdRBItemSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtRBItemCode.Text = this.dgdRBItemSearch.CurrentRow.Cells[0].Value.ToString();
            txtRBItemName.Text = this.dgdRBItemSearch.CurrentRow.Cells[1].Value.ToString();
            Logic.Item itm = new Logic.Item();
            itm = new Logic.ItemService().seaarchItemId(txtRBItemCode.Text);
            txtRBUoM.Text = itm.strItemUoM;
            txtRBQty.Text = Convert.ToString(new Logic.RemainingQtyService().getQty(itm.strItemID));
            dgdRBItemSearch.Visible = false;
            
            
        }

        internal void UpdateSearchList()
        {
            SearchResult = new Logic.ItemService().getSearchResults();
            SearchResult1 = new Logic.ItemService().getSearchResults();
            SearchResultRB = new Logic.RemainingQtyService().getSearchResults();
            dgdRBItemSearch.DataSource = SearchResult;
        }

        private void totable()
        {
            dgdRB.Rows.Clear();
            for (int i = 0; i < SearchResultRB.Rows.Count; i++)
            {
                dgdRB.Rows.Add();

                dgdRB.Rows[i].Cells["colRBItemCode"].Value = SearchResultRB.Rows[i]["id"];
                dgdRB.Rows[i].Cells["colRBItemName"].Value = SearchResultRB.Rows[i]["nme"];
                dgdRB.Rows[i].Cells["colRBItemUoM"].Value = SearchResultRB.Rows[i]["uom"];
                dgdRB.Rows[i].Cells["colRBQuantity"].Value = SearchResultRB.Rows[i]["qty"];
            }
        }

        internal void clearfields()
        {
            txtRBItemCode.Text = "";
            txtRBItemName.Clear();
            txtRBUoM.Text = "";
            txtRBQty.Text = "0.00";
        }
    }
}
