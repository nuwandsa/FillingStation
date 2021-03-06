﻿using System;
using System.Collections.Generic;
using System.Data;
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

        internal DataTable getSearchResults()
        {
            string query = "SELECT ob.`stritemid` as id,ob.`struom` as uom, ob.`dcmlqty` as qty,itm.`strItemName` as nme FROM tblopeningbalance ob INNER JOIN tblitem itm ON ob.stritemid=itm.`strItemID`";
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
    }
}
