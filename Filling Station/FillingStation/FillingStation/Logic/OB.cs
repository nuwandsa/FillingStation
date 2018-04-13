using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStation.Logic
{
    class OB
    {
        public String ItemID { get; set; }
        public string UoM { get; set; }
        public decimal Qty { get; set; }
    }

    class OBService
    {
        internal bool insertOB(Logic.OB ob)
        {
            try
            {
                string query = "INSERT INTO tblopeningbalance "
                                                   + "(stritemid"
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
    }
}
