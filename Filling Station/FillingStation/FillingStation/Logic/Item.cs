using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStation.Logic
{
    class Item
    {
        public String strItemID { get; set; }
        public String strItemName { get; set; }
        public string strItemCategory { get; set; }
        public float fltItemReOderLevel { get; set; }
        public float fltcurrentStock { get; set; }
        public string strItemUoM { get; set; }
        public string strItemDescription { get; set; }
        public decimal dmlItemCostPrice { get; set; }
        public decimal dmlItemSellingPrice { get; set; }
    }
//.............................................end class Item..................................................
    class ItemService
    {
        internal bool insertItem(Item pmItem)
        {
            try
            {
                string query = "INSERT INTO tblItem "
                                                   + "(strItemID"                                                   
                                                   + ",strItemName"
                                                   + ",strItemCategory"
                                                   + ",fltItemReorderLevel"
                                                   + ",strItemUoM"
                                                   + ",strItemDescription"
                                                   + ",dcmlItemCostPrice"
                                                   + ",dcmlItemSellingPrice"
                                                   + ")" +
                                            "VALUES "
                                                   + "('" + pmItem.strItemID + "'"                                                   
                                                   + ",'" + pmItem.strItemName + "'"
                                                   + ",'" + pmItem.strItemCategory + "'"
                                                   + ",'" + pmItem.fltItemReOderLevel + "'"
                                                   + ",'" + pmItem.strItemUoM + "'"
                                                   + ",'" + pmItem.strItemDescription + "'"
                                                   + ",'" + pmItem.dmlItemCostPrice + "'"
                                                   + ",'" + pmItem.dmlItemSellingPrice + "'"
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
        //..............................................end insertItem....................................

        internal DataTable getSearchResults()
        {
            string query = "SELECT strItemID as ID,strItemName as NME FROM tblItem";
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
        //....................................................end getSearchResults............................
        internal bool updateItem(Item pmItem)
        {
            try
            {
                string query = "UPDATE tblItem SET "
                                           
                                           + "strItemName='" + pmItem.strItemName + "'"
                                           + ",strItemCategory='" + pmItem.strItemCategory + "'"
                                           + ",fltItemReorderLevel='" + pmItem.fltItemReOderLevel + "'"
                                           + ",strItemUoM='" + pmItem.strItemUoM + "'"
                                           + ",strItemDescription='" + pmItem.strItemDescription + "'"
                                           + ",dCmlItemCostPrice='" + pmItem.dmlItemCostPrice + "'"
                                           + ",dCmlItemSellingPrice='" + pmItem.dmlItemSellingPrice + "'"
                                       + "WHERE strItemID 			    = '" + pmItem.strItemID + "' ";

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
        //...........................................end updateItem.............................................

        internal int NextId(string nextid)
        {
            int ans;
            try
            {
                string query = "SELECT COUNT(*) FROM tblItem WHERE strItemID='" + nextid + "'";
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
        //..............................................end NextId..................................................

        internal int ValiedId(string valiedId)
        {
            int ans = 0;
            try
            {
                string query = "SELECT  COUNT(*) FROM tblItem WHERE strItemID ='" + valiedId + "'";
                using (Data.DataAccessMySQL.Connect())
                {
                    try
                    {
                        ans = Data.DataAccessMySQL.countRow(query);
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
        //.......................................end ValidId.........................................................

        internal Item seaarchItemId(string pmItemId)
        {
            try
            {
                using (Data.DataAccessMySQL.Connect())
                {
                    try
                    {
                        string quary = "SELECT * FROM tblItem WHERE strItemID ='" + pmItemId + "'";
                        MySqlDataReader dr = Data.DataAccessMySQL.ReadData(quary);
                        dr.Read();
                        Item objclsItem = new Item();
                        objclsItem.strItemID = dr["strItemID"].ToString();
                        objclsItem.strItemName = dr["strItemName"].ToString();
                        objclsItem.strItemCategory = dr["strItemCategory"].ToString();
                        objclsItem.fltItemReOderLevel = float.Parse(dr["fltItemReorderLevel"].ToString());
                        objclsItem.strItemUoM = dr["strItemUoM"].ToString();
                        objclsItem.strItemDescription = dr["strItemDescription"].ToString();
                        objclsItem.dmlItemCostPrice = Convert.ToDecimal(dr["dcmlItemCostPrice"].ToString());
                        objclsItem.dmlItemSellingPrice = Convert.ToDecimal(dr["dcmlItemSellingPrice"].ToString());

                        return objclsItem;
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
