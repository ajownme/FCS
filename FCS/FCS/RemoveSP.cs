using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCS
{
    class RemoveSP
    {

        PublicRef ConSetup = new PublicRef();
        public void DeleteLocation(int lc)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteLocation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.Add("@LocationNo", SqlDbType.Int).Value = lc;
                    cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        //public void DeleteShipmentRoute(int rc)
        //{
        //    string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
        //    //   DataTable dtBranch = new DataTable();
        //    using (SqlConnection con = new SqlConnection(connString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("DeleteShipmentRoute", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            con.Open();
        //            cmd.Parameters.Add("@RouteCode", SqlDbType.Int).Value = rc;
        //            cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
        //            cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //            cmd.ExecuteNonQuery();
        //            con.Dispose();
        //        }
        //    }
        //}

        //public void DeleteBox(int rc)
        //{
        //    string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
        //    //   DataTable dtBranch = new DataTable();
        //    using (SqlConnection con = new SqlConnection(connString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("DeleteBox", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            con.Open();
        //            cmd.Parameters.Add("@RouteCode", SqlDbType.Int).Value = rc;
        //            cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
        //            cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //            cmd.ExecuteNonQuery();
        //            con.Dispose();
        //        }
        //    }
        //}

        public void DeleteItem(int ItemNo)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteItem", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.Add("@ItemNo", SqlDbType.Int).Value = ItemNo;
                    cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void DeleteInitTran(int fn)
        {
            string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteInitialTran", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.Add("@FreightNo", SqlDbType.Int).Value = fn;
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }



    }
}
