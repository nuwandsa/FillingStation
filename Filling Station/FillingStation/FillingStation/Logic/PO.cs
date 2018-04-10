using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStation.Logic
{
    class PO
    {
        public string PONo { get; set; }
        public string POSupplier { get; set; }
        public DateTime PODate { get; set; }
        public string DiliverToAddress { get; set; }
    }

    class POItem
    {
        public string strPOItemCode { get; set; }
        public string strPOItemName { get; set; }
        public decimal dcmlPOQty { get; set; }
        public string strPOItemUoM { get; set; }
        public decimal dcmlPOUnitPrice { get; set; }
        public decimal dcmlPOItmSubTot { get; set; }
    }

   class POService
    {
        internal int NextId(string nextid)
        {
            int ans = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM tblpo WHERE strPoNo='" + nextid + "'";
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

        internal bool insertPOHead(PO po)
        {
            try
            {
                string query = "INSERT INTO tblpo "
                                                   + "(strPONo"
                                                   + ",strSupplier"
                                                   + ",dtePODate"
                                                   + ",strDiliverTOAddress"
                                                   + ")" +
                                            "VALUES "
                                                   + "('" + po.PONo + "'"
                                                   + ",'" + po.POSupplier + "'"
                                                   + ",'" + po.PODate + "'"
                                                   + ",'" + po.DiliverToAddress + "'"
                                                   + ")";
                using (Data.DataAccessMySQL.Connect())
                {
                    try
                    {
                        if (Data.DataAccessMySQL.AddEditDel(query))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex1)
                    {

                        throw ex1;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal void insertPORow(string pmPONO, DataTable PORow)
        {
            DataTable dt = new DataTable();
            string query = "";
            for (int i = 0; i < PORow.Rows.Count; i++)
            {
                if (PORow.Rows[i]["colPOItemCode"].ToString().Trim() != "")
                {
                    try
                    {
                        query = "INSERT INTO tblpoitem "
                                                      + "(strPONo"
                                                      + ",strPOItemCode"
                                                      + ",dcmlPOQty"
                                                      + ",strPOItemUoM"
                                                      + ",dcmlPOUnitPrice"
                                                      + ",dcmlPOItmSubTot"
                                                      + ")" +
                                               "VALUES "
                                                      + "('" + pmPONO + "'"
                                                      + ",'" + PORow.Rows[i]["colPOItemCode"].ToString().Trim() + "'"
                                                      + ",'" + PORow.Rows[i]["colPOQuantity"].ToString().Trim() + "'"
                                                      + ",'" + PORow.Rows[i]["colPOItemUoM"].ToString().Trim() + "'"
                                                      + ",'" + PORow.Rows[i]["colPOUnitPrice"].ToString().Trim() + "'"
                                                      + ",'" + PORow.Rows[i]["colPOSubTotal"].ToString().Trim() + "'"
                                                      + ")";

                        using (Data.DataAccessMySQL.Connect())
                        {
                            try
                            {
                                if (Data.DataAccessMySQL.AddEditDel(query))
                                {
                                    //return true;
                                }
                                else
                                {
                                    //return false;
                                }
                            }
                            catch (Exception ex1)
                            {
                                throw ex1;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        internal bool DeletePORows(string pmPONO)
        {
            try
            {
                string query = "DELETE FROM tblPOTable WHERE strPONO = '" + pmPONO + "' ";

                using (Data.DataAccessMySQL.Connect())
                {
                    try
                    {
                        if (Data.DataAccessMySQL.AddEditDel(query))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex1)
                    {

                        throw ex1;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
} 
