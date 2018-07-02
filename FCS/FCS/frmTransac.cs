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
    public partial class frmTransac : Form
    {
        DataTable DTTranHD = new DataTable();
        ConDB ConDB = new ConDB();
        public frmTransac()
        {
            InitializeComponent();
        }

        private void frmTransac_Load(object sender, EventArgs e)
        {
            LoadToGrid();
        }

        private void LoadToGrid() {
            DTTranHD = ConDB.GetFreightTranHD(@"Select * FROM FreightTranHD order by FreightNoHD");
            dgvTran.DataSource = DTTranHD;
            // dgvTran.Columns[5].ReadOnly = true; dgvTran.Columns[5].Width = 100; dgvTran.Columns[5].HeaderText = "TotalAmount";
            // dgvTran.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           // dgvTran.Columns[0].Visible = false; 
            //dgvTran.Columns[1].Visible = false;
           // dgvTran.Columns[2].ReadOnly = true; dgvTran.Columns[2].Width = 50;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DTTranHD = ConDB.GetFreightTranHD(@"Select * FROM FreightTranHD " +
                  @" WHERE FreightNoHD like '%" + txtSearch.Text + "%' or " +
                  @" FTotalBoxQty like '%" + txtSearch.Text + "%' or " +
                  @" FTotalCBM like '%" + txtSearch.Text + "%' or " +
                  @" FTotalAmount like '%" + txtSearch.Text + "%' or " +
                  @" SuppNameHD like '%" + txtSearch.Text + "%' or " +
                  @" PONumHD like '%" + txtSearch.Text + "%'  ");
            dgvTran.DataSource = DTTranHD;
        }

        private void dgvTran_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DTTranHD.Rows.Count >= 1) {
                // MessageBox.Show(DTTranHD.Rows[dgvTran.CurrentRow.Index]["FreightNoHD"].ToString());
                frmInvoice frmInvoice = new frmInvoice();
                frmInvoice.WindowState = FormWindowState.Maximized;
                frmInvoice.FreightNo = int.Parse(DTTranHD.Rows[dgvTran.CurrentRow.Index]["FreightNoHD"].ToString());
                frmInvoice.ShowDialog();
            }
             
        }
    }
}
