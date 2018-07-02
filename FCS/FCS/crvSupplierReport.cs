using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCS
{
    public partial class crvSupplierReport : Form
    {
        string DateRangestr;
        public string DateRange
        {
            get { return DateRangestr; }
            set { DateRangestr = value; }
        }

        string QueryStringstr;
        public string QueryString
        {
            get { return QueryStringstr; }
            set { QueryStringstr = value; }
        }

        public crvSupplierReport()
        {
            InitializeComponent();
        }

        private void frmSupplierReport_Load(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                db.Open();
                List<MapSupplier> list = db.Query<MapSupplier>(QueryString, commandType: CommandType.Text).ToList();
                crySupplier1.SetDataSource(list);
                crySupplier1.SetParameterValue("DateRange" , DateRange.ToString());
                crystalReportViewer1.ReportSource = crySupplier1;
                crystalReportViewer1.Refresh();
                db.Close();
            }

        }
    }
}
