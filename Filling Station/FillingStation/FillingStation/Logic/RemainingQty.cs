using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStation.Logic
{
    class RemainingQty
    {
        public string ItenID { get; set; }
        public string UoM { get; set; }
        public decimal Qty { get; set; }
    }
    class RemainingQtyService
    {
        internal bool insertRQty(Logic.OB ob)
        {
            try
            {
                string query = "INSERT INTO tblremainingqty "
                                                   + "(strItemID"
                                                   + ",struom"
                                                   + ",dcmlqty"
                                                   + ")" +
                                            "VALUES "
                                                   + "('" + ob.ItemID + "'"
                                                   + ",'" + ob.UoM + "'"
                                                   + ",'" + ob.Qty + "'"
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

        internal DataTable getSearchResults()
        {
            string query = "SELECT rb.`strItemID` as id,rb.`struom` as uom, rb.`dcmlqty` as qty,itm.`strItemName` as nme FROM tblremainingqty rb INNER JOIN tblitem itm ON rb.stritemid=itm.`strItemID`";
            DataTable DT = new DataTable();
            try
            {
                using (Data.DataAccessMySQL.Connect())
                {
                    try
                    {
                        DT = Data.DataAccessMySQL.GetData(query);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return DT;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal decimal getQty(string itemid)
        {
            string query = "SELECT dcmlqty FROM tblremainingqty WHERE strItemID='" +itemid+ "' ";
            decimal qty;
            try
            {
                using (Data.DataAccessMySQL.Connect())
                {
                    try
                    {
                       qty = Data.DataAccessMySQL.getOneDecimalValue(query);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    return qty;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
