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
    public partial class frmBoxSearch : Form
    {
        DataTable BoxtDT = new DataTable();
        ConDB ConDB = new ConDB();
        string backBNamestr;
        public string BackBName
        {
            get { return backBNamestr; }
            set { backBNamestr = value; }
        }

        int backBNumstr;
        public int BackBNum
        {
            get { return backBNumstr; }
            set { backBNumstr = value; }
        }


        public frmBoxSearch()
        {
            InitializeComponent();
        }

        private void frmBoxSearch_Load(object sender, EventArgs e)
        {
            LoadToGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BoxtDT = ConDB.GetBox(@"SELECT  * From Box " +
              @" WHERE BoxCode like '%" + txtSearch.Text + "%' or " +
              @" BoxName like '%" + txtSearch.Text + "%' and " +
               @" Deleted = 0 ORDER BY CreatedDate DESC ");
            dgvBox.DataSource = BoxtDT;
        }

        private void LoadToGrid()
        {
            BoxtDT = ConDB.GetBox(@"SELECT  * From Box WHERE Deleted = 0 ORDER BY CreatedDate DESC ");

            dgvBox.DataSource = BoxtDT;
        }

        private void dgvBox_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (BoxtDT.Rows.Count >= 1) {
                BackBNum = int.Parse(BoxtDT.Rows[dgvBox.CurrentRow.Index]["BoxNo"].ToString());
                BackBName = BoxtDT.Rows[dgvBox.CurrentRow.Index]["BoxName"].ToString();
                this.Hide();
            }
         
        }
    }
}
