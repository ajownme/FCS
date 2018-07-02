using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace FCS
{
    public partial class frmInvoice : Form
    {
        PublicRef PublicRef = new PublicRef();
      //  List<Mapping> _list;
        //public List<Mapping> ThisList {
        //    get { return _list; }
        //    set { _list=value}
        //}
        int FreightNostr;
        public int FreightNo
        {
            get { return FreightNostr; }
            set { FreightNostr = value; }
        }

        ReportDocument rpt = new ReportDocument();
            public frmInvoice()
        {
            InitializeComponent();
            //_list = list;
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            string queryString = "SELECT   FreightTranHD.CreatedBy ,FreightTranHD.CreatedDate,  FreightTranDT.FreightNoDT, FreightTranDT.BoxNameDT, (SELECT CONCAT(FreightTranDT.BLengthDT , ' x ' ,FreightTranDT.BWidthDT ,' x ',FreightTranDT.BHeightDT ) )as BoxDim, FreightTranDT.CBMPerBoxDT, " +
                " (SELECT sum(t2.BoxQtyDT)  FROM FreightTranDT as t2 where   FreightTranDT.BoxNo = t2.BoxNo and  FreightTranDT.FreightNoDT = t2.FreightNoDT) as DistinctBoxQty, " +
                " (SELECT sum(Cast(t3.CBMDT as float))  FROM FreightTranDT as t3 where   FreightTranDT.BoxNo = t3.BoxNo and  FreightTranDT.FreightNoDT = t3.FreightNoDT)as DistinctCBMTotal, " +
                " (SELECT sum(Cast(t4.AmountDT as float))  FROM FreightTranDT as t4 where FreightTranDT.BoxNo = t4.BoxNo and FreightTranDT.FreightNoDT = t4.FreightNoDT)as DistinctAmountTotal, " +
                " ShipmentRoute.RMinCharge , Location.LocationName , FreightTranHD.Remarks , FreightTranHD.PONumHD " +
                 " FROM FreightTranDT left join FreightTranHD on FreightTranDT.FreightNoDT = FreightTranHD.FreightNoHD left join Location on FreightTranDT.LocationNo = Location.LocationNo " +
                 " left join ShipmentRoute on FreightTranDT.RouteNo = ShipmentRoute.RouteNo " +
                 " where FreightTranDT.FreightNoDT = '" + int.Parse(FreightNo.ToString()) + "' " +
                " group by  FreightTranHD.CreatedBy ,FreightTranHD.CreatedDate,  FreightTranDT.FreightNoDT, FreightTranDT.BoxNo, FreightTranDT.BoxNameDT,  FreightTranDT.BLengthDT  ,  FreightTranDT.BWidthDT ,FreightTranDT.BHeightDT, FreightTranDT.CBMPerBoxDT , ShipmentRoute.RMinCharge , Location.LocationName  , FreightTranHD.Remarks, FreightTranHD.PONumHD";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                db.Open();
                List<MapInvoice> list = db.Query<MapInvoice>(queryString, commandType: CommandType.Text).ToList();
                cryInvoice1.SetDataSource(list);
                crystalReportViewer1.ReportSource = cryInvoice1;
            }


          

            //ConnectionInfo connInfo = new ConnectionInfo();
            //connInfo.ServerName = "10.0.14.14";
            //connInfo.DatabaseName = "FCSDB";
            //connInfo.LoginID = "dba";
            //connInfo.Password = "enigmatech";

            //TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
            //tableLogOnInfo.ConnectionInfo = connInfo;



            //rpt.Load(@"C:\Users\arjay\Desktop\DeadsFeb18\FCS\FCS\cryInvoice.rpt");
            //rpt.SetParameterValue("FreightNo", FreightNo.ToString());

            //foreach (Table table in rpt.Database.Tables)
            //{
            //    table.ApplyLogOnInfo(tableLogOnInfo);
            //    table.LogOnInfo.ConnectionInfo.ServerName = connInfo.ServerName;
            //    table.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName;
            //    table.LogOnInfo.ConnectionInfo.LoginID = connInfo.LoginID;
            //    table.LogOnInfo.ConnectionInfo.Password = connInfo.Password;
            //}        
            //crystalReportViewer1.ReportSource = rpt;       
            //crystalReportViewer1.Show();
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
