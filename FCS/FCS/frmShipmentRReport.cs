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
    public partial class frmShipmentRReport : Form
    {
        private int RouteNo;
        public frmShipmentRReport()
        {
            InitializeComponent();
        }

        private void txtSRouteName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmSRouteSearch frmSRouteSearch = new frmSRouteSearch();
            frmSRouteSearch.ShowDialog();
            txtSRouteName.Text = frmSRouteSearch.BackRName;
            RouteNo = frmSRouteSearch.BackRNum;

        }

        private void btnViewPrint_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(crvShipmentRReport))
                {
                    form.Activate();
                    return;
                }
            }

            if (txtSRouteName.Text == "All")
            {
                crvShipmentRReport crvShipmentRReport = new crvShipmentRReport();
                crvShipmentRReport.QueryString = @"SELECT Location.LocationNo,Location.LocationCode, Location.LocationName,ShipmentRoute.RouteNo , ShipmentRoute.RouteCode, ShipmentRoute.RouteName, ShipmentRoute.RMinCharge " +
                    @" From ShipmentRoute Right Join Location On ShipmentRoute.RouteNo = Location.RouteNo " +
                    @" where Location.Deleted = '0'";
                // frmSupplierReport.DateRange = "   Date:      " + dtpFrom.Value.ToString("MMMM dd,yyyy") + "   -  " + dtpTo.Value.ToString("MMMM dd,yyyy");
                crvShipmentRReport.WindowState = FormWindowState.Maximized;
                crvShipmentRReport.ShowDialog();

            }
            else {
                crvShipmentRReport crvShipmentRReport = new crvShipmentRReport();
                crvShipmentRReport.QueryString = @"SELECT Location.LocationNo,Location.LocationCode, Location.LocationName,ShipmentRoute.RouteNo , ShipmentRoute.RouteCode, ShipmentRoute.RouteName, ShipmentRoute.RMinCharge " +
                    @" From ShipmentRoute Right Join Location On ShipmentRoute.RouteNo = Location.RouteNo " +
                    @" where Location.Deleted = '0' and ShipmentRoute.RouteNo='" + RouteNo .ToString()+ "'";
                // frmSupplierReport.DateRange = "   Date:      " + dtpFrom.Value.ToString("MMMM dd,yyyy") + "   -  " + dtpTo.Value.ToString("MMMM dd,yyyy");
                crvShipmentRReport.WindowState = FormWindowState.Maximized;
                crvShipmentRReport.ShowDialog();

            }
        }
    }
}
