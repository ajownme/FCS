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
    public partial class frmBoxSet : Form
    {
        InsertSP InsertSP = new InsertSP();
        UpdateSP UpdateSP = new UpdateSP();
        ConDB ConDB = new ConDB();
        DataTable BoxtDT = new DataTable();
        DataTable ItemDT = new DataTable();
        bool NewOrEdit;
        bool CalculateFlag;
        int LoginID;
        public frmBoxSet(int loginID)
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmFreightSet_Load(object sender, EventArgs e)
        {
            LoadToGrid();
            GridToFormObj();
            LoadToListItem();
            UIEffect("Default");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxCode.Text == "" || txtBoxName.Text == "" || txtItemQty.Text == "" || txtLength.Text == "" || txtWidth.Text == "" || txtHeight.Text == "")
            {
                MessageBox.Show("Incomplete Input", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Save Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (NewOrEdit == false){
                        InsertSP.InsertBox(this.LoginID,txtBoxCode.Text, txtBoxName.Text, double.Parse(txtLength.Text), double.Parse(txtWidth.Text), double.Parse(txtHeight.Text),txtCBMPBox.Text, int.Parse(txtItemQty.Text));
                        MessageBox.Show("Successfully Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        UpdateSP.UpdateBox( int.Parse(BoxtDT.Rows[dgvBox.CurrentRow.Index]["BoxNo"].ToString()), txtBoxCode.Text, txtBoxName.Text, double.Parse(txtLength.Text), double.Parse(txtWidth.Text), double.Parse(txtHeight.Text), txtCBMPBox.Text, int.Parse(txtItemQty.Text));
                        MessageBox.Show("Successfully Updated", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    UIEffect("Save");
                    LoadToGrid();
                    GridToFormObj();
                    LoadToListItem();

                }
            }
        }

        private void LoadToGrid()
        {
            BoxtDT = ConDB.GetBox(@"SELECT  * From Box WHERE Deleted= 0 ORDER BY CreatedDate DESC ");   
            dgvBox.DataSource = BoxtDT;
        }

        private void UIEffect(string Effect)
        {
            switch (Effect)
            {
                case "Default":
                    txtBoxCode.ReadOnly = true;
                    txtBoxName.ReadOnly = true;
                    txtItemQty.ReadOnly = true;
                    txtCBMPBox.ReadOnly = true;
                    txtLength.ReadOnly = true;
                    txtWidth.ReadOnly = true;
                    txtHeight.ReadOnly = true;

                    lstProduct.Enabled = true;
                    dgvBox.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;
                    //dgvLocation.Enabled = true;
                    break;

                case "New":
                    txtBoxCode.ReadOnly = false;
                    txtBoxName.ReadOnly = false;
                    txtItemQty.ReadOnly = false;
                    txtCBMPBox.ReadOnly = true;
                    txtLength.ReadOnly = false;
                    txtWidth.ReadOnly = false;
                    txtHeight.ReadOnly = false;

                    lstProduct.Enabled = true;
                    dgvBox.Enabled = false;
                    txtSearch.ReadOnly = true;

                    btnSave.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    txtBoxCode.Clear();
                    txtBoxName.Clear();
                    txtItemQty.Clear();
                    txtCBMPBox.Clear();
                    txtLength.Clear();
                    txtWidth.Clear();
                    txtHeight.Clear();
                    lstProduct.Items.Clear();
                    break;

                case "Cancel":
                    txtBoxCode.ReadOnly = true;
                    txtBoxName.ReadOnly = true;
                    txtItemQty.ReadOnly = true;
                    txtCBMPBox.ReadOnly = true;
                    txtLength.ReadOnly = true;
                    txtWidth.ReadOnly = true;
                    txtHeight.ReadOnly = true;

                    lstProduct.Enabled = true;
                    dgvBox.Enabled = true;
                    txtSearch.ReadOnly = false;

               
                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;

                    txtBoxCode.Clear();
                    txtBoxName.Clear();
                    txtItemQty.Clear();
                    txtCBMPBox.Clear();
                    txtLength.Clear();
                    txtWidth.Clear();
                    txtHeight.Clear();
                    lstProduct.Items.Clear();

                    break;

                case "Edit":
                    txtBoxCode.ReadOnly = false;
                    txtBoxName.ReadOnly = false;
                    txtItemQty.ReadOnly = false;
                    txtCBMPBox.ReadOnly = true;
                    txtLength.ReadOnly = false;
                    txtWidth.ReadOnly = false;
                    txtHeight.ReadOnly = false;

                    lstProduct.Enabled = true;
                    dgvBox.Enabled = false;
                    txtSearch.ReadOnly = true;

                
                    btnSave.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    //txtCBMPBox.Clear();
                    //txtLength.Clear();
                    //txtWidth.Clear();
                    //txtHeight.Clear();
                    //dgvLocation.Enabled = false;
                    break;

                case "Save":
                    txtBoxCode.ReadOnly = true;
                    txtBoxName.ReadOnly = true;
                    txtItemQty.ReadOnly = true;
                    txtCBMPBox.ReadOnly = true;
                    txtLength.ReadOnly = true;
                    txtWidth.ReadOnly = true;
                    txtHeight.ReadOnly = true;

                    lstProduct.Enabled = true;
                    dgvBox.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;

                    break;

                case "Delete":
                    txtBoxCode.Clear();
                    txtBoxName.Clear();
                    txtItemQty.Clear();
                    txtCBMPBox.Clear();
                    txtLength.Clear();
                    txtWidth.Clear();
                    txtHeight.Clear();
                    lstProduct.Items.Clear();
                    break;
            }

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
         
            calculcateCBM();
        }

        private void calculcateCBM()
        {
            try {
                if (CalculateFlag != true)
                {
                    if (txtLength.Text != "" && txtWidth.Text != "" || txtHeight.Text != "")
                    {
                        double dl = double.Parse(txtLength.Text) / 100;
                        double dw = double.Parse(txtWidth.Text) / 100;
                        double dh = double.Parse(txtHeight.Text) / 100;

                        //double dl = double.Parse( txtLength.Text +"00" );
                        //double dw = double.Parse("0.0" + txtWidth.Text);
                        //double dh = double.Parse("0.0" + txtHeight.Text);

                        //string sl = dl.ToString("0.00");
                        //string sw = dw.ToString("0.00");
                        //string sh = dh.ToString("0.00");

                        // double s = double.Parse(sl) * double.Parse(sw) * double.Parse(sh) ;

                        double s = dl* dw * dh;
                        //   double s = double.Parse("0." + txtLength.Text) * double.Parse("0." + txtWidth.Text) * double.Parse("0." + txtHeight.Text);
                        txtCBMPBox.Text =  s.ToString();
                    }
                }

            }
            catch (Exception ex) {

            }
          
            
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
      
            calculcateCBM();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
          
            calculcateCBM();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewOrEdit = true;
            CalculateFlag = false;
            UIEffect("Edit");
        }

        private void dgvBox_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CalculateFlag = true;
            GridToFormObj();
            LoadToListItem();
        }

        private void GridToFormObj()
        {
            if (BoxtDT.Rows.Count >= 1)
            {
                txtBoxCode.Text = BoxtDT.Rows[dgvBox.CurrentRow.Index]["BoxCode"].ToString();
                txtBoxName.Text = BoxtDT.Rows[dgvBox.CurrentRow.Index]["BoxName"].ToString();
                txtItemQty.Text = BoxtDT.Rows[dgvBox.CurrentRow.Index]["BoxItemQty"].ToString();
                txtCBMPBox.Text = BoxtDT.Rows[dgvBox.CurrentRow.Index]["CBMPerBox"].ToString();
                txtLength.Text = BoxtDT.Rows[dgvBox.CurrentRow.Index]["Length"].ToString();
                txtWidth.Text = BoxtDT.Rows[dgvBox.CurrentRow.Index]["Width"].ToString();
                txtHeight.Text = BoxtDT.Rows[dgvBox.CurrentRow.Index]["Height"].ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewOrEdit = false;
            CalculateFlag = false;
            UIEffect("New");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BoxtDT = ConDB.GetBox(@"SELECT  * From Box " +
                @" WHERE BoxCode like '%" + txtSearch.Text + "%' or " +
                @" BoxName like '%" + txtSearch.Text + "%' and " +
                 @" Deleted = 0 ORDER BY CreatedDate DESC ");
            dgvBox.DataSource = BoxtDT;
        }

        private void LoadToListItem()
        {
            if (BoxtDT.Rows.Count >= 1)
            {
                ItemDT = ConDB.GetItem(@"SELECT  * From Item WHERE BoxNo = '" + BoxtDT.Rows[dgvBox.CurrentRow.Index]["BoxNo"].ToString() + "'and  Deleted = 0 ORDER BY ItemCode ASC ");
                // if (LocationDT.Rows.Count >= 1) {
                lstProduct.Items.Clear();
                for (int i = 0; i < ItemDT.Rows.Count; i++)
                {
                    lstProduct.Items.Add(ItemDT.Rows[i]["ItemCode"].ToString());
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UIEffect("Cancel");
            LoadToGrid();
            GridToFormObj();
            LoadToListItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvBox.Rows.Count >= 1)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Delete Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        RemoveSP.DeleteShipmentRoute(int.Parse(txtBoxCode.Text));
            //        MessageBox.Show("Successfully Deleted", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        UIEffect("Delete");
            //        LoadToGrid();
            //        GridToFormObj();
            //        LoadToListItem();
            //    }
            //}
        }

        private void txtBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = false;
                return;
            }

            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtItemQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = false;
                return;
            }

            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = false;
                return;
            }

            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = false;
                return;
            }

            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxCode_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
