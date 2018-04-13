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
    public partial class frmOpenningBalence : MetroFramework.Forms.MetroForm
    {
        public frmOpenningBalence()
        {
            InitializeComponent();
        }
        internal DataTable SearchResult, SearchResult1;

        private void frmOpenningBalence_Load(object sender, EventArgs e)
        {
            UpdateSearchList();
        }

        private void txtOBItemCode_Click(object sender, EventArgs e)
        {
            if (!dgdOBItemSearch.Visible)
            {
                dgdOBItemSearch.Visible = true;
            }
        }

        private void txtOBItemCode_Leave(object sender, EventArgs e)
        {
            if (!txtOBItemCode.Focused && !dgdOBItemSearch.Focused)
            {
                dgdOBItemSearch.Visible = false;
            }

            if (txtOBItemCode.Text != string.Empty && !dgdOBItemSearch.Focused)
            {
                if (new Logic.ItemService().ValiedId(txtOBItemCode.Text) != 0)
                {
                    toItemDeit(new Logic.ItemService().seaarchItemId(txtOBItemCode.Text));

                }
                else if (new Logic.ItemService().ValiedId(txtOBItemCode.Text) == 0)
                {
                    MessageBox.Show("Please Enter Valied Item ID");
                    txtOBItemCode.Focus();
                }
            }

         }

        internal void toItemDeit(Logic.Item itm)
        {
            txtOBItemCode.Text = itm.strItemID;
            txtOBItemName.Text = itm.strItemName;
            txtOBUoM.SelectedText = itm.strItemUoM;

        }

        private void txtOBItemCode_TextChanged(object sender, EventArgs e)
        {
            dgdOBItemSearch.Visible = true;
            if (!string.IsNullOrEmpty(txtOBItemCode.Text))
            {
                DataView dv = SearchResult.DefaultView;
                //dv.RowFilter = string.Format("SupplierID like'%{0}%' or SupplierName like'%{0}%'", txtSearchBox.Text);
                dv.RowFilter = string.Format("ID like'%{0}%' or NME like'%{0}%'", txtOBItemCode.Text);
                dgdOBItemSearch.DataSource = dv.ToTable();
            }
            else if (string.IsNullOrEmpty(txtOBItemCode.Text))
            {
                dgdOBItemSearch.DataSource = null;
                dgdOBItemSearch.DataSource = SearchResult1;
                dgdOBItemSearch.Refresh();
            }
        }

        private void dgdOBItemSearch_Leave(object sender, EventArgs e)
        {
            if (!txtOBItemCode.Focused && !dgdOBItemSearch.Focused)
            {
                dgdOBItemSearch.Visible = false;
            }
        }

        private void dgdOBItemSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtOBItemCode.Text = this.dgdOBItemSearch.CurrentRow.Cells[0].Value.ToString();
            txtOBItemName.Text = this.dgdOBItemSearch.CurrentRow.Cells[1].Value.ToString();
            Logic.Item itm = new Logic.Item();
            itm = new Logic.ItemService().seaarchItemId(txtOBItemCode.Text);
            txtOBUoM.Text = itm.strItemUoM;
            dgdOBItemSearch.Visible = false;
            txtOBQty.Focus();
        }

        private void btnPOsave_Click(object sender, EventArgs e)
        {
            if(new Logic.ItemService().ValiedId(txtOBItemCode.Text)>0)
            {
              
            }
        }

        internal Logic.OB ObtoSave()
        {
            Logic.OB ob = new Logic.OB();
            ob.ItemID = txtOBItemCode.Text;
            ob.UoM = txtOBUoM.Text;
            ob.Qty = Convert.ToDecimal(txtOBQty.Text);

            return ob;
        }

        internal void UpdateSearchList()
        {
            SearchResult = new Logic.ItemService().getSearchResults();
            SearchResult1 = new Logic.ItemService().getSearchResults();
            dgdOBItemSearch.DataSource = SearchResult;
        }

    }
}
