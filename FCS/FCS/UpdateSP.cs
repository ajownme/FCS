using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCS
{
    class UpdateSP
    {
        PublicRef PublicRef = new PublicRef();
        public void UpdateLocation(int LocationNo,  string lc, string ln , int rn)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateLocation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@LocationNo", SqlDbType.Int).Value = LocationNo;
                    cmd.Parameters.Add("@LocationCode", SqlDbType.NVarChar).Value = lc;
                    cmd.Parameters.Add("@LocationName", SqlDbType.NVarChar).Value = ln;
                    cmd.Parameters.Add("@RouteNo", SqlDbType.Int).Value = rn;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void UpdateShipmentRoute(int routeNo, string rc, string rn, double rmc , double RPerCBMCharge)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateShipmentRoute", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@RouteNo", SqlDbType.Int).Value = routeNo;
                    cmd.Parameters.Add("@RouteCode", SqlDbType.NVarChar).Value = rc;
                    cmd.Parameters.Add("@RouteName", SqlDbType.NVarChar).Value = rn;
                    cmd.Parameters.Add("@RMinCharge", SqlDbType.Float).Value = rmc;
                    cmd.Parameters.Add("@RPerCBMCharge", SqlDbType.Float).Value = RPerCBMCharge;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void UpdateBox(int boxno ,string bc, string bn, double l, double w, double h, string cbmpb, int iq)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateBox", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@BoxNo", SqlDbType.Int).Value = boxno;
                    cmd.Parameters.Add("@BoxCode", SqlDbType.NVarChar).Value = bc;
                    cmd.Parameters.Add("@BoxName", SqlDbType.NVarChar).Value = bn;
                    cmd.Parameters.Add("@Length", SqlDbType.Float).Value = l;
                    cmd.Parameters.Add("@Width", SqlDbType.Float).Value = w;
                    cmd.Parameters.Add("@Height", SqlDbType.Float).Value = h;
                    cmd.Parameters.Add("@CBMPerBox", SqlDbType.NVarChar).Value = cbmpb;
                    cmd.Parameters.Add("@BoxItemQty", SqlDbType.Int).Value = iq;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void UpdateItem(int itemNo , string ic, string In, int bn)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateItem", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@ItemNo", SqlDbType.Int).Value = itemNo;
                    cmd.Parameters.Add("@ItemCode", SqlDbType.NVarChar).Value = ic;
                    cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = In;
                    cmd.Parameters.Add("@BoxNo", SqlDbType.Int).Value = bn;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void UpdateUserAccount( int LoginID, string UserName, string Password, bool Location, bool ShipmentRoute, bool Item, bool Box, bool Proforma, bool Other, bool UserAccount, bool New)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateUserAccount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = LoginID;
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
                    cmd.Parameters.Add("@Location", SqlDbType.Bit).Value = Location;
                    cmd.Parameters.Add("@ShipmentRoute", SqlDbType.Bit).Value = ShipmentRoute;
                    cmd.Parameters.Add("@Item", SqlDbType.Bit).Value = Item;
                    cmd.Parameters.Add("@Box", SqlDbType.Bit).Value = Box;
                    cmd.Parameters.Add("@Proforma", SqlDbType.Bit).Value = Proforma;
                    cmd.Parameters.Add("@Other", SqlDbType.Bit).Value = Other;
                    cmd.Parameters.Add("@UserAccount", SqlDbType.Bit).Value = UserAccount;
                    cmd.Parameters.Add("@New", SqlDbType.Bit).Value = New;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }






    }
}
