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
    public partial class frmSupplierSearch : Form
    {
        ConDB ConDB = new ConDB();
        DataTable DTFreightTranHD = new DataTable();
        string backSuppNamestr;
        public string BackSuppName
        {
            get { return backSuppNamestr; }
            set { backSuppNamestr = value; }
        }

        public frmSupplierSearch()
        {
            InitializeComponent();
        }

        private void SupplierSearch_Load(object sender, EventArgs e)
        {
            LoadToGrid();
        }
        private void LoadToGrid() {
            DTFreightTranHD = ConDB.GetFreightTranHD(@"Select Distinct(SuppNameHD) from FreightTranHD");
            dgvSupp.DataSource = DTFreightTranHD;
           dgvSupp.Columns[0].Width = 300;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DTFreightTranHD = ConDB.GetFreightTranHD(@"Select Distinct(SuppNameHD) from FreightTranHD " +
             @" WHERE SuppNameHD like '%" + txtSearch.Text + "%' ");
            dgvSupp.DataSource = DTFreightTranHD;
        }

        private void dgvSupp_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DTFreightTranHD.Rows.Count >= 1) {
                BackSuppName = DTFreightTranHD.Rows[dgvSupp.CurrentRow.Index]["SuppNameHD"].ToString();
                this.Hide();
            }
           
        }
    }
}
