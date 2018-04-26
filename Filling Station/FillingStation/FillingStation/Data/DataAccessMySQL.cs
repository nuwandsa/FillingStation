using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FillingStation.Data
{
    class DataAccessMySQL
    {
        static string connectionString = "Server=" + Data.Global.myServerName +
                                         "Database=" + Data.Global.myDatabaseName +
                                         "Uid=" + Data.Global.myUserName +
                                         "Pwd=" + Data.Global.myPassword;
        static MySqlConnection con = new MySqlConnection(connectionString);

        

        internal static MySqlConnection Connect()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con = new MySqlConnection();
                    con.ConnectionString = connectionString;
                    con.Open();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Mysql Connection Failed !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
            return con;
        }
        internal static MySqlDataReader ReadData(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            //dr =cmd.ExecuteReader();
            
            return dr;
        }

        internal static bool AddEditDel(string query)
        {
            int i = 0;
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                throw;
            }
            if (i == 0)
                return false;
            else
                return true;
        }
        internal static string GetCount(string fieldName, string tblName)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT ifnull((MAX(" + fieldName + ")+1), 1) FROM " + tblName, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetValue(0).ToString();
        }

        internal static DataTable GetData(string quary, string tbl)
        {
            DataTable dt = new DataTable();
            MySqlCommand com = new MySqlCommand(quary, con);
            MySqlDataAdapter ad = new MySqlDataAdapter(com);
            dt.Load(com.ExecuteReader());
            return dt;
        }
        internal static DataTable GetData(string quary)
        {
            DataTable dt = new DataTable();
            MySqlCommand com = new MySqlCommand(quary, con);
            MySqlDataAdapter ad = new MySqlDataAdapter();
            ad.SelectCommand = com;
            //con_new.Open();
            ad.Fill(dt);
            //con_new.Close();
            return dt;
        }

        internal static int getOneIntValue(string quary)
        {
            try
            {

                MySqlCommand com = new MySqlCommand(quary, con);
                // return (int) com.ExecuteScalar();
                int ans = Convert.ToInt32(com.ExecuteScalar());
                return ans;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal static decimal getOneDecimalValue(string quary)
        {
            try
            {

                MySqlCommand com = new MySqlCommand(quary, con);
                // return (int) com.ExecuteScalar();
                decimal ans = Convert.ToDecimal(com.ExecuteScalar());
                return ans;
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal static int countRow(string quary)
        {
            int count;
            try
            {
                MySqlCommand com = new MySqlCommand(quary, con);
                //return (Int32)com.ExecuteScalar();
                 count = Convert.ToInt32(com.ExecuteScalar());
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
