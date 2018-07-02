
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
namespace FCS
{
    public partial class frmNew : Form
    {
        InsertSP InsertSP = new InsertSP();
        IncrementID IncrementID = new IncrementID();
        ConDB ConDB = new ConDB();
        PublicRef PublicRef = new PublicRef();
        RemoveSP RemoveSP = new RemoveSP();

        DataTable ItemDataTable = new DataTable();
        DataTable LocationDataTable = new DataTable();
        DataTable DataTableFreightDT = new DataTable();
        DataTable DataTableFreightHD = new DataTable();
        DataTable ExcelDT = new System.Data.DataTable();

        DataSet InitialTranDS = new DataSet();

        private string BaseCost;
        private string suppName;
        private string suppPO;
        private bool DeleteFlag;
        private string OpfdPathStr;
        private int LoginID;
        public frmNew(int loginID)
        {
            InitializeComponent();
            this.LoginID = loginID;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
           
            //LoadToGrid();
           
            OpenFileDialog opfd = new OpenFileDialog();

            if (opfd.ShowDialog() == DialogResult.OK)
            {
                IncremToText();
                OpfdPathStr = opfd.FileName;
                UIEffect("Upload");
                DeleteFlag = false;
            }
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            if (IncrementID.IncrementInitFreightNo().ToString() != txtFreightNo.Text)
            {
               // MessageBox.Show("changeNo");
                IncremToText();
            }

            SavingInitTran();
           
        }
       
        private void SavingInitTran() {

            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + OpfdPathStr + " ;Extended Properties='Excel 8.0;HDR=Yes;'";
            OleDbConnection conn = new OleDbConnection(con);
            conn.Open();
            ExcelDT = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string ExcelSheetName1 = ExcelDT.Rows[0]["Table_Name"].ToString();    //get First Excel Sheet Name
            OleDbDataAdapter da1 = new OleDbDataAdapter("Select * FROM [" + ExcelSheetName1 + "]", con);
            da1.Fill(ExcelDT);

            for (int r = 0; r < ExcelDT.Rows.Count; r++)    //Find Supplier Name and PO Num
            {
                for (int c = 0; c < ExcelDT.Columns.Count; c++) 
                {
                    string q = ExcelDT.Rows[r][c].ToString();
                    if (q.Contains("SUPPLIER:"))
                    {
                        suppName = ExcelDT.Rows[r + 1][c].ToString() + ExcelDT.Rows[r + 2][c].ToString();
                        suppPO = ExcelDT.Rows[r][c + 1].ToString().Remove(0, 9).Trim();
                    }
                }
            }


            for (int r = 0; r < ExcelDT.Rows.Count; r++)    //Find BaseCost
            {
                for (int c = 0; c < ExcelDT.Columns.Count; c++)
                {
                    string q = ExcelDT.Rows[r][c].ToString();
                    if (q.Contains("TOTAL BASE COST:"))
                    {
                        BaseCost = ExcelDT.Rows[r][c].ToString().Remove(0, 16).Trim();
                    }
                }
            }

            string ExcelSheetName2 = ExcelDT.Rows[1]["Table_Name"].ToString();    //get Second Excel Sheet Name
            if (ExcelSheetName2 != "")
            {
                OleDbDataAdapter da2 = new OleDbDataAdapter("Select * FROM [" + ExcelSheetName2 + "]", con);
                ExcelDT.Clear();
                da2.Fill(ExcelDT);

                for (int i = 0; i < ExcelDT.Rows.Count; i++) //Find Products
                {
                    for (int c = 0; c < ExcelDT.Columns.Count; c++)
                    {
                        string q = ExcelDT.Rows[i][c].ToString();
                        if (q.Split('-').Length - 1 == 2)
                        {
                            DataValidation(ExcelDT.Rows[i][c].ToString(), ExcelDT.Rows[i][c + 3].ToString(), ExcelDT.Rows[i][c + 2].ToString());
                        }
                    }
                }
                conn.Close();
                InitialTranLoadToGrid();
                UIEffect("Initialize");
                DeleteFlag = true;
            }
            else
            {
                MessageBox.Show("Incomplete Excel ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataValidation(string localItemCode, string localLocationCode , string localItemQty) {
            string localItemNo = "";
            string localLocationNo = "";
            string localBoxNo="";
            string localRouteNo="";
            ItemDataTable = ConDB.ForNewItemCompare(@"Select Item.* from Item where Item.ItemCode = '" + localItemCode + "' and Item.Deleted = 0");
            if (ItemDataTable.Rows.Count >= 1)
            {
                localItemNo = ItemDataTable.Rows[0]["ItemNo"].ToString();
                localBoxNo = ItemDataTable.Rows[0][8].ToString();
            }
            LocationDataTable = ConDB.ForNewLocationCompare(@"Select Location.* from Location   where Location.LocationCode = '" + localLocationCode + "' and Location.Deleted=0");
            if (LocationDataTable.Rows.Count >= 1)
            {
                localLocationNo= LocationDataTable.Rows[0]["LocationNo"].ToString();
                localRouteNo = LocationDataTable.Rows[0][8].ToString();
                txtDestination.Text = LocationDataTable.Rows[0]["LocationName"].ToString();
            }          
            InsertSP.InsertInitialTran( int.Parse(txtFreightNo.Text), localItemCode, localBoxNo , localLocationCode, localRouteNo , localItemNo , localLocationNo , localItemQty , suppName, suppPO);                   
        }


        private void InitialTranLoadToGrid() {
            InitialTranDS = ConDB.GetInitialTran(@"Select InitialTran.InitTranNo , InitialTran.FreightNo , InitialTran.ItemCode ,Box.BoxCode , InitialTran.LocationCode , ShipmentRoute.RouteCode,  InitialTran.ItemQty ,InitialTran.Exclude From InitialTran Left Join Box On InitialTran.BoxNo = box.BoxNo Left Join ShipmentRoute on InitialTran.RouteNo = ShipmentRoute.RouteNo where InitialTran.FreightNo = '" + int.Parse(txtFreightNo.Text) +"'");
            dgvTran.DataSource = InitialTranDS.Tables[0];
            dgvTran.Columns[0].Visible = false;
            dgvTran.Columns[1].Visible = false; 
            dgvTran.Columns[2].ReadOnly = true; //dgvTran.Columns[2].Width = 150;
            dgvTran.Columns[3].ReadOnly = true;
            dgvTran.Columns[4].ReadOnly = true; //dgvTran.Columns[4].Width = 150;
            dgvTran.Columns[5].ReadOnly = true;

        }

        private void FinalTransLoadToGrid() {
            DataTableFreightDT = ConDB.GetFreightTranDT(@"SELECT  FreightTranDT.BoxNameDT, (SELECT CONCAT(FreightTranDT.BLengthDT , ' x ' ,FreightTranDT.BWidthDT ,' x ',FreightTranDT.BHeightDT ) )as BoxDim, FreightTranDT.CBMPerBoxDT, " +
                @" (SELECT sum(t2.BoxQtyDT)  FROM FreightTranDT as t2 where   FreightTranDT.BoxNo = t2.BoxNo and  FreightTranDT.FreightNoDT = t2.FreightNoDT )as DistinctBoxQty, " +
                @" (SELECT sum( Cast(t3.CBMDT as float))  FROM FreightTranDT as t3 where   FreightTranDT.BoxNo = t3.BoxNo and  FreightTranDT.FreightNoDT = t3.FreightNoDT )as DistinctCMBTotal, " +
                @" (SELECT sum( Cast(t4.AmountDT as float))  FROM FreightTranDT as t4 where   FreightTranDT.BoxNo = t4.BoxNo and  FreightTranDT.FreightNoDT = t4.FreightNoDT)as DistinctAmountTotal " +
                @" FROM FreightTranDT "+
                @" where FreightTranDT.FreightNoDT = '" + int.Parse(txtFreightNo.Text) + "'" +
                @" group by   FreightTranDT.FreightNoDT,  FreightTranDT.BoxNo, FreightTranDT.BoxNameDT,  FreightTranDT.BLengthDT  ,  FreightTranDT.BWidthDT ,FreightTranDT.BHeightDT, FreightTranDT.CBMPerBoxDT");
            dgvTran.DataSource = DataTableFreightDT;
            dgvTran.Columns[0].ReadOnly = true; dgvTran.Columns[0].Width = 180; dgvTran.Columns[0].HeaderText = "BoxName"; 
            dgvTran.Columns[1].ReadOnly = true; dgvTran.Columns[1].Width = 120; dgvTran.Columns[1].HeaderText = "BoxDim(LxWxH)";
            dgvTran.Columns[2].ReadOnly = true; dgvTran.Columns[2].Width = 60; dgvTran.Columns[2].HeaderText = "CBM";
            dgvTran.Columns[3].ReadOnly = true; dgvTran.Columns[3].Width = 70; dgvTran.Columns[3].HeaderText = "TotalBoxQty";
            dgvTran.Columns[4].ReadOnly = true; dgvTran.Columns[4].Width = 70; dgvTran.Columns[4].HeaderText = "TotalCBM";
            dgvTran.Columns[5].ReadOnly = true; dgvTran.Columns[5].Width = 100; dgvTran.Columns[5].HeaderText = "TotalAmount";
            dgvTran.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTran.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTran.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

           
        }
       
        private void btnBuild_Click(object sender, EventArgs e)
        {
            updateInitialTran();
            if (txtDestination.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Build Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvTran.DataSource = null;
                    dgvTran.Refresh();
                    BuildInitialTran();
                    FinalTransLoadToGrid();


                    TranHDToFormObj();
                    UIEffect("Build");
                    DeleteFlag = false;
                }
            }
            else {
                MessageBox.Show("Unknown Destination", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void TranHDToFormObj() {
            DataTableFreightHD = ConDB.GetFreightTranHD("Select * From FreightTranHD where FreightTranHD.FreightNoHD= '" + int.Parse(txtFreightNo.Text) + "'");
            txtBoxTot.Text= DataTableFreightHD.Rows[0]["FTotalBoxQty"].ToString();
            txtCBMTot.Text = DataTableFreightHD.Rows[0]["FTotalCBM"].ToString();
            double dblTotalAmt = 0;
            dblTotalAmt = double.Parse( DataTableFreightHD.Rows[0]["FTotalAmount"].ToString());
            txtAmtTot.Text = dblTotalAmt.ToString(".00");
        }
     
        private void ValidateItemQty() {
            InitialTranDS = ConDB.GetInitialTran(@"Select Box.BoxNo, Box.BoxCode , Box.BoxItemQty, InitialTran.ItemQty From InitialTran Left Join Box On InitialTran.BoxNo = box.BoxNo where InitialTran.FreightNo = '" + int.Parse(txtFreightNo.Text) + "' and InitialTran.Exclude  <> '1'");
            DataTable localDT = new DataTable();
            localDT = InitialTranDS.Tables[0];
            for (int i = 0; i < localDT.Rows.Count; i++)
            {
                int ItemQtyToBoxQty = 0;
                if (localDT.Rows[i]["BoxItemQty"].ToString() != "1")
                {                  
                    ItemQtyToBoxQty = int.Parse(localDT.Rows[i]["ItemQty"].ToString()) / int.Parse(DataTableFreightDT.Rows[i]["BoxItemQty"].ToString());
                  
                }
                ItemQtyToBoxQty= int.Parse(localDT.Rows[i]["ItemQty"].ToString());
            
            }
           

        }
        private void BuildInitialTran()
        {
            DataTableFreightDT = ConDB.GetFreightTranDT(@"Select  InitialTran.FreightNo,   InitialTran.Itemno , InitialTran.BoxNo , InitialTran.LocationNo ,  " +
                @" InitialTran.RouteNo , InitialTran.ItemQty   , Box.CBMPerBox , ShipmentRoute.RMinCharge,ShipmentRoute.RPerCBMCharge, " +
                @" Box.BoxName , Box.Length, Box.Width, Box.Height , ShipmentRoute.RouteName , Location.LocationName, Box.BoxItemQty " +
                @" From InitialTran  Left Join Box On InitialTran.BoxNo = box.BoxNo " +
                @" Left Join ShipmentRoute on InitialTran.RouteNo = ShipmentRoute.RouteNo " +
                @" Left Join Location on InitialTran.LocationNo = Location.LocationNo " +
                @" Where InitialTran.FreightNo= '" + int.Parse(txtFreightNo.Text) + "' and  " +
                @" InitialTran.BoxNo is not null  and InitialTran.RouteNo is not null and Exclude <> '1'");
        

            double localCBMDT=0;
            double localAmountDT = 0;
            for (int i = 0; i < DataTableFreightDT.Rows.Count; i++)
            {
                int ItemQtyToBoxQty = 0;
                if (DataTableFreightDT.Rows[i]["BoxItemQty"].ToString() != "1")
                {
                    ItemQtyToBoxQty = int.Parse(DataTableFreightDT.Rows[i]["ItemQty"].ToString()) / int.Parse(DataTableFreightDT.Rows[i]["BoxItemQty"].ToString());
                    // BuildInitialTran(ItemQtyToBoxQty);
                }
                else {
                    ItemQtyToBoxQty = int.Parse(DataTableFreightDT.Rows[i]["ItemQty"].ToString());
                }
               

                localCBMDT = double.Parse(DataTableFreightDT.Rows[i]["CBMPerBox"].ToString()) * double.Parse(DataTableFreightDT.Rows[i]["ItemQty"].ToString());
                if (localCBMDT <= 0.25)
                {
                    localAmountDT = double.Parse(DataTableFreightDT.Rows[i]["RMinCharge"].ToString());
                }
                else {
                    localAmountDT = localCBMDT * double.Parse(DataTableFreightDT.Rows[i]["RPerCBMCharge"].ToString());
                }

             
                InsertSP.InsertFreightTranDT(int.Parse( DataTableFreightDT.Rows[i]["FreightNo"].ToString()), int.Parse(DataTableFreightDT.Rows[i]["ItemNo"].ToString()) , int.Parse(DataTableFreightDT.Rows[i]["BoxNo"].ToString()), int.Parse(DataTableFreightDT.Rows[i]["LocationNo"].ToString()) , int.Parse(DataTableFreightDT.Rows[i]["RouteNo"].ToString()), DataTableFreightDT.Rows[i]["CBMPerBox"].ToString() , double.Parse( DataTableFreightDT.Rows[i]["RMinCharge"].ToString()), ItemQtyToBoxQty, localCBMDT.ToString() , localAmountDT.ToString(), DataTableFreightDT.Rows[i]["BoxName"].ToString(), double.Parse( DataTableFreightDT.Rows[i]["Length"].ToString()), double.Parse(DataTableFreightDT.Rows[i]["Width"].ToString()), double.Parse(DataTableFreightDT.Rows[i]["Height"].ToString()), DataTableFreightDT.Rows[i]["RouteName"].ToString(), DataTableFreightDT.Rows[i]["LocationName"].ToString());
            }


            int localBoxQty = 0;
            double localTotalCBM = 0;
            double localTotAmount = 0;
          
            DataTableFreightHD = ConDB.GetFreightTranDT("SELECT *  FROM FreightTranDT where FreightTranDT.FreightNoDT = '" + int.Parse(txtFreightNo.Text) + "'");
            for (int i = 0; i < DataTableFreightHD.Rows.Count; i++)
            {
                localBoxQty += int.Parse( DataTableFreightHD.Rows[i]["BoxQtyDT"].ToString());
                localTotalCBM+= double.Parse(DataTableFreightHD.Rows[i]["CBMDT"].ToString());
                localTotAmount += double.Parse(DataTableFreightHD.Rows[i]["AmountDT"].ToString());
            }

            InsertSP.InsertFreightTranHD(this.LoginID, int.Parse(txtFreightNo.Text), localBoxQty,localTotalCBM.ToString() , localTotAmount.ToString() , suppName , suppPO , rtbRemarks.Text , BaseCost);

            //InitialTranDS.
            //InsertSP.InsertFreightTranDT();
            //dgvTran.DataSource = InitialTranDS.Tables[0];

            //InitialTranDS = ConDB.GetInitialTran(@"Select  MainInitTran.*,  Box.BoxCode , ShipmentRoute.RouteCode , box.CBMPerBox , ShipmentRoute.RMinCharge , " +
            //    @" ( select count(*) from InitialTran  as childInitTran where  childInitTran.BoxNo= MainInitTran.BoxNo ) as TBCPerBoxGroup "+
            //    @" From InitialTran as MainInitTran Left Join Box On MainInitTran.BoxNo = box.BoxNo "+
            //    @" Left Join ShipmentRoute on MainInitTran.RouteNo = ShipmentRoute.RouteNo "+
            //    @" Where MainInitTran.FreightNo= '1' and box.BoxCode<>'' and ShipmentRoute.RouteCode<>'' and Exclude <> '1'");
            //dgvTran.DataSource = InitialTranDS.Tables[0];
            //dgvTran.Columns[0].Visible = false;
            //dgvTran.Columns[1].ReadOnly = true; dgvTran.Columns[1].Width = 55;
            //dgvTran.Columns[2].ReadOnly = true;
            //dgvTran.Columns[3].ReadOnly = true; dgvTran.Columns[3].Width = 40;
            //dgvTran.Columns[4].ReadOnly = true; dgvTran.Columns[4].Width = 75;
            //dgvTran.Columns[5].ReadOnly = true; dgvTran.Columns[5].Width = 55;
            //dgvTran.Columns[6].Visible = false;
            //dgvTran.Columns[7].Visible = false;
            //dgvTran.Columns[8].Visible = false;
            //dgvTran.Columns[9].Visible = false;
            //dgvTran.Columns[10].Visible = false;
            //dgvTran.Columns[11].ReadOnly = true; dgvTran.Columns[11].Width = 70;
            //dgvTran.Columns[12].ReadOnly = true; dgvTran.Columns[12].Width = 70;
            //dgvTran.Columns[13].Visible = false;
            //  if (ItemMatchDT.Rows[0]["BoxNo"].ToString()!="" || ItemMatchDT.Rows[0]["RouteNo"].ToString() != "" || bool.Parse( ItemMatchDT.Rows[0]["Exlude"].ToString()) != true) {

            //}
        }


        private void updateInitialTran() {

            SqlDataAdapter sda = new SqlDataAdapter("Select InitTranNo , Exclude , ItemQty From InitialTran", "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'");
            SqlCommandBuilder scmb = new SqlCommandBuilder(sda);
            sda.Update(InitialTranDS);
        }
        private void btnViewP_Click(object sender, EventArgs e)
        {

            // List<Mapping> list = 
            //           string queryString = @"SELECT   FreightTranHD.CreatedBy ,FreightTranHD.CreatedDate,  FreightTranDT.FreightNoDT, FreightTranDT.BoxNameDT, (SELECT CONCAT(FreightTranDT.BLengthDT , ' x ' ,FreightTranDT.BWidthDT ,' x ',FreightTranDT.BHeightDT ) )as BoxDim, FreightTranDT.CBMPerBoxDT, " +
            //   @" (SELECT sum(t2.BoxQtyDT)  FROM FreightTranDT as t2 where   FreightTranDT.BoxNo = t2.BoxNo and  FreightTranDT.FreightNoDT = t2.FreightNoDT) as DistinctBoxQty, "+
            //  @" (SELECT sum(Cast(t3.CBMDT as float))  FROM FreightTranDT as t3 where   FreightTranDT.BoxNo = t3.BoxNo and  FreightTranDT.FreightNoDT = t3.FreightNoDT)as DistinctCBMTotal, "+
            //@" (SELECT sum(Cast(t4.AmountDT as float))  FROM FreightTranDT as t4 where FreightTranDT.BoxNo = t4.BoxNo and FreightTranDT.FreightNoDT = t4.FreightNoDT)as DistinctAmountTotal, "+
            //@" ShipmentRoute.RMinCharge , Location.LocationName , FreightTranHD.Remarks , FreightTranHD.PONumHD "+
            //   @" FROM FreightTranDT "+
            //   @" left join FreightTranHD on FreightTranDT.FreightNoDT = FreightTranHD.FreightNoHD "+
            //   @" left join Location on FreightTranDT.LocationNo = Location.LocationNo "+
            //   @" left join ShipmentRoute on FreightTranDT.RouteNo = ShipmentRoute.RouteNo "+
            //  // @" where FreightTranDT.FreightNoDT = 5 " +
            //  @" where FreightTranDT.FreightNoDT = '" + int.Parse(txtFreightNo.Text) + "' " +
            //   @" group by  FreightTranHD.CreatedBy ,FreightTranHD.CreatedDate,  FreightTranDT.FreightNoDT, FreightTranDT.BoxNo, FreightTranDT.BoxNameDT,  FreightTranDT.BLengthDT  ,  FreightTranDT.BWidthDT ,FreightTranDT.BHeightDT, FreightTranDT.CBMPerBoxDT , ShipmentRoute.RMinCharge , Location.LocationName  , FreightTranHD.Remarks, FreightTranHD.PONumHD";

            //           string connection = "Data Source='" + PublicRef.GetServerHost() + "';Initial Catalog='" + PublicRef.GetDatabaseName() + "';Persist Security Info=True;User ID='" + PublicRef.GetUserName() + "';Password='" + PublicRef.GetPassword() + "'";
            //           using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString)) {
            //               db.Open();
            //               List<Mapping> list = db.Query<Mapping>(queryString,commandType: CommandType.Text).ToList();
            //               frmInvoice frmInvoice = new frmInvoice(list);
            //               frmInvoice.WindowState = FormWindowState.Maximized;
            //               frmInvoice.ShowDialog();
            //           }

            UIEffect("ViewPrint");
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmInvoice))
                {
                    form.Activate();
                    return;
                }
            }
            frmInvoice frmInvoice = new frmInvoice();
            frmInvoice.WindowState = FormWindowState.Maximized;
            frmInvoice.FreightNo = int.Parse(txtFreightNo.Text);
            frmInvoice.ShowDialog();

        }

       
        private void UIEffect(string Effect)
        {
            switch (Effect)
            {
                case "Default":                
                    btnUpload.Enabled = true;
                    btnInitialize.Enabled = false;
                    btnBuild.Enabled = false;
                    btnViewP.Enabled = false;
                    rtbRemarks.ReadOnly = true;
                    break;

                case "Upload":
                    btnUpload.Enabled = false;
                    btnInitialize.Enabled = true;
                    btnBuild.Enabled = false;
                    btnViewP.Enabled = false;
                    dgvTran.DataSource = null;
                    dgvTran.Refresh();
                    txtDestination.Clear();
                    rtbRemarks.Clear();         
                    break;

                case "Initialize":
                    btnUpload.Enabled = false;
                    btnInitialize.Enabled = false;
                    btnBuild.Enabled = true;
                    btnViewP.Enabled = false;
                    rtbRemarks.ReadOnly = false;
                    break;

                case "Build":
                    btnUpload.Enabled = false;
                    btnInitialize.Enabled = false;
                    btnBuild.Enabled = false;
                    btnViewP.Enabled = true;
                    rtbRemarks.ReadOnly = true;
                    txtBoxTot.Visible = true;
                    txtCBMTot.Visible = true;
                    txtAmtTot.Visible = true;
                    break;

                case "ViewPrint":
                    btnUpload.Enabled = true;
                    btnInitialize.Enabled = false;
                    btnBuild.Enabled = false;
                    btnViewP.Enabled = true;
                    rtbRemarks.ReadOnly = true;
                    txtBoxTot.Visible = false;
                    txtCBMTot.Visible = false;
                    txtAmtTot.Visible = false;
                    break;

            }

        }
        private void frmNew_Load(object sender, EventArgs e)
        {
            
           UIEffect("Default");


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        
        }

        private void IncremToText() {
            txtFreightNo.Text = IncrementID.IncrementInitFreightNo().ToString();
        }

        private void dgvTran_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
              e.Control.KeyPress += new KeyPressEventHandler(Column_KeyPress);
         }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DeleteFlag==true) {             
                    RemoveSP.DeleteInitTran(int.Parse(txtFreightNo.Text));            
            }
        }





        //private void GetExcelColumnHeader(int header row) {

        //}





    }

}
