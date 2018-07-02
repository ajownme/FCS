using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCS
{
    public partial class frmSRouteSearch : Form
    {
        DataTable SRouteDT = new DataTable();
        ConDB ConDB = new ConDB();
        string backRNamestr;
        public string BackRName
        {
            get { return backRNamestr; }
            set { backRNamestr = value; }
        }

        int backRNumstr;
        public int BackRNum
        {
            get { return backRNumstr; }
            set { backRNumstr = value; }
        }


        public frmSRouteSearch()
        {
            InitializeComponent();
        }

        private void frmSRouteSearch_Load(object sender, EventArgs e)
        {
            LoadToGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SRouteDT = ConDB.GetShipmentRoute(@"SELECT  * From ShipmentRoute " +
            @" WHERE RouteCode like '%" + txtSearch.Text + "%' or " +
            @" RouteName like '%" + txtSearch.Text + "%' and " +
             @" Deleted = 0 ORDER BY CreatedDate DESC ");
            dgvRoute.DataSource = SRouteDT;
        }

        private void LoadToGrid()
        {
            SRouteDT = ConDB.GetBox(@"SELECT  * From ShipmentRoute WHERE Deleted = 0 ORDER BY CreatedDate DESC ");

            dgvRoute.DataSource = SRouteDT;
        }

        private void dgvRoute_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SRouteDT.Rows.Count >= 1) {
                BackRNum = int.Parse(SRouteDT.Rows[dgvRoute.CurrentRow.Index]["RouteNo"].ToString());
                BackRName = SRouteDT.Rows[dgvRoute.CurrentRow.Index]["RouteName"].ToString();
                this.Hide();
            }
         
        }
    }
}
