using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCS
{
    class ConDB 
    {
        PublicRef ConSetup = new PublicRef();

        string serverhost { get; set; }
        public DataTable GetLocation(string StrQuery)
        {
            //serverhost = ConSetup.GetServerHost();
            string connString = "Data Source='"+ ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
           // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dtEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtEmployee);
                con.Close();
                return dtEmployee;
            }
        }

        public DataTable GetShipmentRoute(string StrQuery)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dtEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtEmployee);
                con.Close();
                return dtEmployee;
            }
        }

        public DataTable GetBox(string StrQuery)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dtEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtEmployee);
                con.Close();
                return dtEmployee;
            }
        }

        public DataTable GetItem(string StrQuery)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dtEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtEmployee);
                con.Close();
                return dtEmployee;
            }
        }


        public DataTable ForNewItemCompare(string StrQuery)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dtEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtEmployee);
                con.Close();
                return dtEmployee;
            }
        }

        public DataTable ForNewLocationCompare(string StrQuery)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dtEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dtEmployee);
                con.Close();
                return dtEmployee;
            }
        }


        public DataSet GetInitialTran(string StrQuery)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataSet dsEmployee = new DataSet();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dsEmployee);
                con.Close();
                return dsEmployee;
            }
        }

        public DataTable GetFreightTranDT(string StrQuery)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dsEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dsEmployee);
                con.Close();
                return dsEmployee;
            }
        }

        public DataTable GetFreightTranHD(string StrQuery)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dsEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dsEmployee);
                con.Close();
                return dsEmployee;
            }
        }

        public DataTable GetUserAccount(string StrQuery)
        {
         
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            // string connString = "Data Source='"+DBServerName+"';Initial Catalog='"+DBName+"';Persist Security Info=True;User ID='"+DBUserName+"';Password='"+DBPassword+"'";
            DataTable dsEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(StrQuery, con);
                dap.Fill(dsEmployee);
                con.Close();
                return dsEmployee;
            }
        }






    }
}
