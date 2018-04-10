using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStation.Logic
{
    class Invoice
    {
        public string strInvoNo { get; set; }
        public string strPOSInvoCusName { get; set; }
        public decimal dcmlPOSInvoiceTotal { get; set; }
        public decimal dcmlPOSInvoTotDiscount { get; set; }
        public decimal dcmlPOSInvoTotalDue { get; set; }
        public string strPOSInvoPaymentMethod { get; set; }
        public decimal dcmlPOSInvoPaidAmount { get; set; }
        public decimal dcmlPOSInvoBalance { get; set; }
    }

    class InvoItem
    {
        public string strInvoItemCode { get; set; }
        public string strInvoItemName { get; set; }
        public decimal dcmlInvoQty { get; set; }
        public string strInvoItemUoM { get; set; }
        public decimal dcmlInvoUnitPrice { get; set; }
        public decimal dcmlInvoItmSubTot { get; set; }
    }

    class POSInvoService
    {
        internal int NextId(string nextid)
        {
            int ans = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM tblinvoice WHERE strInvoiceNo='" + nextid + "'";
                using (Data.DataAccessMySQL.Connect())
                {
                    try
                    {
                        ans = Data.DataAccessMySQL.getOneIntValue(query);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return ans;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
