using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCS
{
    class InsertSP 
    {
        PublicRef PublicRef = new PublicRef();
        IncrementID IncrementID = new IncrementID();

        public void InsertLocation(int loginID , string lc, string ln , int rn)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("AddLocation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = loginID;
                    cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@ModifyBy", SqlDbType.Int).Value = DBNull.Value;
                    cmd.Parameters.Add("@ModifyDate", SqlDbType.DateTime).Value = DBNull.Value;
                    cmd.Parameters.Add("@Deleted", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@LocationNo", SqlDbType.Int).Value = IncrementID.IncrementLocation();
                    cmd.Parameters.Add("@LocationCode", SqlDbType.NVarChar).Value = lc;
                    cmd.Parameters.Add("@LocationName", SqlDbType.NVarChar).Value = ln;
                    cmd.Parameters.Add("@RouteNo", SqlDbType.Int).Value = rn;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void InsertShipmentRoute(int loginID, string rc, string rn, double rmc , double RPerCBMCharge)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("AddShipmentRoute", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = loginID;
                    cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@Deleted", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@RouteNo", SqlDbType.Int).Value = IncrementID.IncrementShipmentRoute();
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


        public void InsertBox(int loginID,string bc, string bn, double l , double w , double h , string cbmpb , int iq)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("AddBox", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = loginID;
                    cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@Deleted", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@BoxNo", SqlDbType.Int).Value = IncrementID.IncrementBox();
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

        public void InsertItem(int loginID,string ic, string In ,  int bc)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("AddItem", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = loginID;
                    cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@Deleted", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@ItemNo", SqlDbType.Int).Value = IncrementID.IncrementItem();
                    cmd.Parameters.Add("@ItemCode", SqlDbType.NVarChar).Value = ic;
                    cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = In;
                    cmd.Parameters.Add("@BoxNo", SqlDbType.Int).Value = bc;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        //public void InsertExcelItem(string ic, string In, int bc)
        //{
        //    string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
        //    //   DataTable dtBranch = new DataTable();
        //    using (SqlConnection con = new SqlConnection(connString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("AddItem", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = frmMain.LoginID;
        //            cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //            cmd.Parameters.Add("@Deleted", SqlDbType.Bit).Value = 0;
        //            cmd.Parameters.Add("@ItemNo", SqlDbType.Int).Value = IncrementID.IncrementItem();
        //            cmd.Parameters.Add("@ItemCode", SqlDbType.NVarChar).Value = ic;
        //            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = In;
        //            cmd.Parameters.Add("@BoxCode", SqlDbType.Int).Value = bc;
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            con.Dispose();
        //        }
        //    }
        //}


        public void InsertInitialTran( int Fno ,string ic, string boxNo, string lc, string RouteNo , string ItemNo , string LocationNo ,string localItemQty ,string SuppName , string PONum)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("AddInitialTran", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@InitTranNo", SqlDbType.Int).Value = IncrementID.IncrementInitTranNo();
                    cmd.Parameters.Add("@FreightNo", SqlDbType.Int).Value = Fno;
                    if (ic == "") { cmd.Parameters.Add("@ItemCode", SqlDbType.NVarChar).Value = DBNull.Value;
                    } else { cmd.Parameters.Add("@ItemCode", SqlDbType.NVarChar).Value = ic; }

                    if (boxNo == "") { cmd.Parameters.Add("@BoxNo", SqlDbType.Int).Value = DBNull.Value;
                    } else { cmd.Parameters.Add("@BoxNo", SqlDbType.Int).Value = int.Parse(boxNo); }

                    if (lc == ""){ cmd.Parameters.Add("@LocationCode", SqlDbType.NVarChar).Value = DBNull.Value;
                    } else { cmd.Parameters.Add("@LocationCode", SqlDbType.NVarChar).Value = lc; }

                    if (RouteNo == ""){ cmd.Parameters.Add("@RouteNo", SqlDbType.Int).Value = DBNull.Value;
                    } else { cmd.Parameters.Add("@RouteNo", SqlDbType.Int).Value = int.Parse(RouteNo); }

                    if (boxNo == "" || RouteNo == "") { cmd.Parameters.Add("@Exclude", SqlDbType.NVarChar).Value = 1;
                    }
                    else { cmd.Parameters.Add("@Exclude", SqlDbType.NVarChar).Value = 0; }

                    if (ItemNo == ""){ cmd.Parameters.Add("@ItemNo", SqlDbType.Int).Value = DBNull.Value;
                    }else { cmd.Parameters.Add("@ItemNo", SqlDbType.Int).Value = int.Parse(ItemNo); }


                    if (LocationNo == ""){ cmd.Parameters.Add("@LocationNo", SqlDbType.Int).Value = DBNull.Value;
                    }else { cmd.Parameters.Add("@LocationNo", SqlDbType.Int).Value = int.Parse(LocationNo); }

                    if (localItemQty == ""){cmd.Parameters.Add("@ItemQty", SqlDbType.Int).Value = DBNull.Value;
                    }else { cmd.Parameters.Add("@ItemQty", SqlDbType.Int).Value = int.Parse(localItemQty); }

                    cmd.Parameters.Add("@SuppName", SqlDbType.NVarChar).Value = SuppName;
                    cmd.Parameters.Add("@PONum", SqlDbType.NVarChar).Value = PONum;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void InsertFreightTranDT(int FreightNoDT, int ItemNo, int BoxNo, int LocationNo, int RouteNo, string CBMPerBoxDT, double RMinChargeDT, int ItemQtyDT , string CBMDT , string AmountDT, string BoxNameDT, double BLengthDT , double BWidthDT , double BHeightDT,string  RouteNameDT, string LocationNameDT)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("AddFreightTranDT", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SeqNoDT", SqlDbType.Int).Value = IncrementID.IncrementFreightTranDT();
                    cmd.Parameters.Add("@FreightNoDT", SqlDbType.Int).Value = FreightNoDT;
                    cmd.Parameters.Add("@ItemNo", SqlDbType.Int).Value = ItemNo;
                    cmd.Parameters.Add("@BoxNo", SqlDbType.Int).Value = BoxNo;
                    cmd.Parameters.Add("@LocationNo", SqlDbType.Int).Value = LocationNo;
                    cmd.Parameters.Add("@RouteNo", SqlDbType.Int).Value = RouteNo;
                    cmd.Parameters.Add("@CBMPerBoxDT", SqlDbType.NVarChar).Value = CBMPerBoxDT;
                    cmd.Parameters.Add("@RMinChargeDT", SqlDbType.Float).Value = RMinChargeDT;
                    cmd.Parameters.Add("@BoxQtyDT", SqlDbType.Int).Value = ItemQtyDT;
                    cmd.Parameters.Add("@CBMDT", SqlDbType.NVarChar).Value = CBMDT;
                    cmd.Parameters.Add("@AmountDT", SqlDbType.Float).Value = AmountDT;
                    cmd.Parameters.Add("@BoxNameDT", SqlDbType.NVarChar).Value = BoxNameDT;
                    cmd.Parameters.Add("@BLengthDT", SqlDbType.Float).Value = BLengthDT;
                    cmd.Parameters.Add("@BWidthDT", SqlDbType.Float).Value = BWidthDT;
                    cmd.Parameters.Add("@BHeightDT", SqlDbType.Float).Value = BHeightDT;
                    cmd.Parameters.Add("@RouteNameDT", SqlDbType.NVarChar).Value = RouteNameDT;
                    cmd.Parameters.Add("@LocationNameDT", SqlDbType.NVarChar).Value = LocationNameDT;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }


        public void InsertFreightTranHD(int loginID, int FreightNoHD, int FTotalBoxQty, string FTotalCBM, string FTotalAmount , string SuppNameHD, string PONumHD, string Remarks , string BaseCost)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("AddFreightTranHD", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = loginID;
                    cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@FreightNoHD", SqlDbType.Int).Value = FreightNoHD;
                    cmd.Parameters.Add("@FTotalBoxQty", SqlDbType.Int).Value = FTotalBoxQty;
                    cmd.Parameters.Add("@FTotalCBM", SqlDbType.NVarChar).Value = FTotalCBM;
                    cmd.Parameters.Add("@FTotalAmount", SqlDbType.NVarChar).Value = FTotalAmount;
                    cmd.Parameters.Add("@SuppNameHD", SqlDbType.NVarChar).Value = SuppNameHD;
                    cmd.Parameters.Add("@PONumHD", SqlDbType.NVarChar).Value = PONumHD;
                    cmd.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = Remarks;
                    cmd.Parameters.Add("@BaseCost", SqlDbType.NVarChar).Value = BaseCost;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                }
            }
        }

        public void InsertUserAccount(int loginID,string UserName, string Password, bool Location, bool ShipmentRoute, bool Item, bool Box, bool Proforma, bool Other, bool UserAccount, bool New)
        {
            string connString = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //   DataTable dtBranch = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("AddUserAccount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = loginID;
                    cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.Add("@Deleted", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = IncrementID.IncrementUserAccount();
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
