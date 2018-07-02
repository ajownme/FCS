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
    public partial class frmSuppFreightReport : Form
    {
        public frmSuppFreightReport()
        {
            InitializeComponent();
        }

        private void rbOpt1_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButton();
        }

        private void CheckRadioButton() {
            if (rbOpt1.Checked == true)
            {
                grpOpt1.Enabled = true;
                grpOpt2.Enabled = false;
            }
            else {
                grpOpt1.Enabled = false;
                grpOpt2.Enabled = true;
            }
        }

        private void rbOpt2_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButton();
        }

        private void frmSuppFreight_Load(object sender, EventArgs e)
        {
            CheckRadioButton();
            PickerFormat();
        }

        private void PickerFormat() {
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "MMMM dd,yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "MMMM dd,yyyy";
        }

        private void txtSupp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmSupplierSearch frmSupplierSearch = new frmSupplierSearch();
            frmSupplierSearch.ShowDialog();
            txtSuppName.Text = frmSupplierSearch.BackSuppName;
        }

        private void btnViewPrint_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(crvSupplierReport))
                {
                    form.Activate();
                    return;
                }
            }

            if (rbOpt1.Checked == true)
            {

                crvSupplierReport frmSupplierReport = new crvSupplierReport();
                frmSupplierReport.QueryString = @"Select   SuppNameHD,FreightNoHD,PONumHD,CreatedDate,Cast(FTotalAmount as float) as FTotalAmt,BaseCost " +
                    @" FROM FreightTranHD  " +
                    @" WHERE CreatedDate between   '" + dtpFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00' and '" + dtpTo.Value.ToString("yyyy-MM-dd") + " 23:59:59' " +
                    @"and SuppNameHD = '" + txtSuppName.Text + "' ";
                frmSupplierReport.DateRange = "   Date:      "+dtpFrom.Value.ToString("MMMM dd,yyyy") + "   -  " + dtpTo.Value.ToString("MMMM dd,yyyy");
                frmSupplierReport.WindowState = FormWindowState.Maximized;
                frmSupplierReport.ShowDialog();
            }
            else {
                crvSupplierReport frmSupplierReport = new crvSupplierReport();
                frmSupplierReport.QueryString = @"Select   SuppNameHD,FreightNoHD,PONumHD,CreatedDate,Cast(FTotalAmount as float) as FTotalAmt,BaseCost " +
                   @" FROM FreightTranHD  " +
                   @" WHERE PONumHD= '" + int.Parse( txtPONum.Text)+"'";
                frmSupplierReport.DateRange = "";
                frmSupplierReport.WindowState = FormWindowState.Maximized;
                frmSupplierReport.ShowDialog();
            }
        }
    }
}
