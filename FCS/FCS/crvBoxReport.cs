﻿using Dapper;
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
    public partial class crvBoxReport : Form
    {
        string QueryStringstr;
        public string QueryString
        {
            get { return QueryStringstr; }
            set { QueryStringstr = value; }
        }


        public crvBoxReport()
        {
            InitializeComponent();
        }

        private void crvBoxReport_Load(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                db.Open();
                List<MapBox> list = db.Query<MapBox>(QueryString, commandType: CommandType.Text).ToList();
                cryBox1.SetDataSource(list);
                // cryShipmentRoute1.SetParameterValue("DateRange", DateRange.ToString());
                crystalReportViewer1.ReportSource = cryBox1;
                crystalReportViewer1.Refresh();
                db.Close();
            }

        }
    }
}