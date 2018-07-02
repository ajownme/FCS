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
    public partial class frmBoxReport : Form
    {
        private int BoxNo;
        public frmBoxReport()
        {
            InitializeComponent();
        }

        private void btnViewPrint_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(crvBoxReport))
                {
                    form.Activate();
                    return;
                }
            }

            if (txtBoxName.Text == "All")
            {
                crvBoxReport crvBoxReport = new crvBoxReport();
                crvBoxReport.QueryString = @"SELECT Item.ItemCode,Item.ItemName, Box.BoxNo,Box.BoxCode , Box.BoxName, (SELECT CONCAT(Box.Length , ' x ' ,Box.Width,' x ',Box.Height ) )as BoxDim,Box.CBMPerBox,Box.BoxItemQty " +
                    @" From Box Right Join Item On Box.BoxNo = Item.BoxNo  " +
                    @" where Item.Deleted = '0'";
                crvBoxReport.WindowState = FormWindowState.Maximized;
                crvBoxReport.ShowDialog();

            }
            else {
                crvBoxReport crvBoxReport = new crvBoxReport();
                crvBoxReport.QueryString = @"SELECT Item.ItemCode,Item.ItemName, Box.BoxNo,Box.BoxCode , Box.BoxName, (SELECT CONCAT(Box.Length , ' x ' ,Box.Width,' x ',Box.Height ) )as BoxDim,Box.CBMPerBox,Box.BoxItemQty " +
                    @" From Box Right Join Item On Box.BoxNo = Item.BoxNo  " +
                    @" where Item.Deleted = '0' and Box.Boxno= '"+BoxNo.ToString()+"'";
                crvBoxReport.WindowState = FormWindowState.Maximized;
                crvBoxReport.ShowDialog();
            }


        }

        private void txtBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmBoxSearch frmBoxSearch = new frmBoxSearch();
            frmBoxSearch.ShowDialog();
            txtBoxName.Text = frmBoxSearch.BackBName;
            BoxNo = frmBoxSearch.BackBNum;
        }
    }
}
