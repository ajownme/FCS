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
   
    public partial class frmShipmentRoute : Form
    {
        //  PublicRef PublicRef = new PublicRef();
        InsertSP InsertSP = new InsertSP();
        UpdateSP UpdateSP = new UpdateSP();
        RemoveSP RemoveSP = new RemoveSP();
        DataTable ShipmentRouteDT = new DataTable();
        DataTable LocationDT = new DataTable();
        ConDB ConDB = new ConDB();
        bool NewOrEdit;
        private int LoginID;

        public frmShipmentRoute(int loginID)
        {    
            InitializeComponent();
            this.LoginID = loginID;
        }


        private void UIEffect(string Effect)
        {
            switch (Effect)
            {
                case "Default":
                    txtRouteCode.ReadOnly = true;
                    txtRouteName.ReadOnly = true;
                    txtRminCharge.ReadOnly = true;
                    lstLocation.Enabled = true;
                    dgvRoute.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;
                    //dgvLocation.Enabled = true;
                    break;

                case "New":
                    txtRouteCode.ReadOnly = false;
                    txtRouteName.ReadOnly = false;
                    txtRminCharge.ReadOnly = false;
                    lstLocation.Enabled = true;
                    dgvRoute.Enabled = false;
                    txtSearch.ReadOnly = true;

                    btnSave.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    txtRouteCode.Clear();
                    txtRouteName.Clear();
                    txtRminCharge.Clear();
                    lstLocation.Items.Clear();
                    break;

                case "Cancel":
                    txtRouteCode.ReadOnly = true;
                    txtRouteName.ReadOnly = true;
                    txtRminCharge.ReadOnly = true;
                    lstLocation.Enabled = true;
                    dgvRoute.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;

                    txtRouteCode.Clear();
                    txtRouteName.Clear();
                    txtRminCharge.Clear();
                    lstLocation.Items.Clear();
                    break;

                case "Edit":
                    txtRouteCode.ReadOnly = false;
                    txtRouteName.ReadOnly = false;
                    txtRminCharge.ReadOnly = false;
                    lstLocation.Enabled = true;
                    dgvRoute.Enabled = false;
                    txtSearch.ReadOnly = true;

                    btnSave.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    //dgvLocation.Enabled = false;
                    break;

                case "Save":
                    txtRouteCode.ReadOnly = true;
                    txtRouteName.ReadOnly = true;
                    txtRminCharge.ReadOnly = true;
                    lstLocation.Enabled = true;
                    dgvRoute.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;

                    break;

                case "Delete":
                    txtRouteCode.Clear();
                    txtRouteName.Clear();
                    txtRminCharge.Clear();
                    lstLocation.Items.Clear();
                    break;
            }

        }

        private void lstLocation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(frmLocation))
            //    {
            //        form.Close();
            //        return;
            //    }
            //}
            //frmLocation frmLocation = new frmLocation(true);     
            //frmLocation.Size = new Size(602, 350);
            //frmLocation.Show();
            //this.Close();
        }

        private void frmShipmentRoute_Load(object sender, EventArgs e)
        {
            LoadToGridSRoute();
            GridToFormObj();
            LoadToListLocation();
             UIEffect("Default");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UIEffect("Cancel");
            LoadToGridSRoute();
            GridToFormObj();
            LoadToListLocation();
            // MessageBox.Show(LocationVal.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewOrEdit = false;
            UIEffect("New");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRouteCode.Text == "" || txtRouteName.Text == "" || txtRminCharge.Text == "")
            {
                MessageBox.Show("Incomplete Input", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Save Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (NewOrEdit == false)
                    {
                        InsertSP.InsertShipmentRoute(this.LoginID ,txtRouteCode.Text, txtRouteName.Text, double.Parse(txtRminCharge.Text), double.Parse(txtPerCBMCharge.Text));
                        MessageBox.Show("Successfully Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (NewOrEdit == true)
                    {
                        UpdateSP.UpdateShipmentRoute(int.Parse(ShipmentRouteDT.Rows[dgvRoute.CurrentRow.Index]["RouteNo"].ToString()), txtRouteCode.Text, txtRouteName.Text, double.Parse(txtRminCharge.Text), double.Parse(txtPerCBMCharge.Text));
                        MessageBox.Show("Successfully Updated", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    UIEffect("Save");
                    LoadToGridSRoute();
                    GridToFormObj();
                }
                    
               
            }

          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewOrEdit = true;
            UIEffect("Edit");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvRoute.Rows.Count >= 1)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Delete Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        RemoveSP.DeleteShipmentRoute(int.Parse(txtRouteNo.Text));
            //        MessageBox.Show("Successfully Deleted", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        UIEffect("Delete");
            //        LoadToGridSRoute();
            //        GridToFormObj();
            //        LoadToListLocation();
            //    }
            //}
               

        }

        private void LoadToGridSRoute()
        {

            ShipmentRouteDT = ConDB.GetShipmentRoute(@"SELECT  * From ShipmentRoute WHERE Deleted = 0 ORDER BY CreatedDate DESC ");
            // if (LocationDT.Rows.Count >= 1) {
            dgvRoute.DataSource = ShipmentRouteDT;
        }

        private void LoadToListLocation()
        {
            if (ShipmentRouteDT.Rows.Count >= 1)
            {
                LocationDT = ConDB.GetLocation(@"SELECT  * From Location WHERE RouteNo= '" + ShipmentRouteDT.Rows[dgvRoute.CurrentRow.Index]["RouteNo"].ToString() + "'and  Deleted = 0 ORDER BY LocationCode ASC ");
                // if (LocationDT.Rows.Count >= 1) {
                lstLocation.Items.Clear();
                for (int i = 0; i < LocationDT.Rows.Count; i++)
                {
                    lstLocation.Items.Add(LocationDT.Rows[i]["LocationCode"].ToString());
                }

            }
        }

        private void dgvRoute_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            GridToFormObj();
            LoadToListLocation();
            // MessageBox.Show(ShipmentRouteDT.Rows[dgvRoute.CurrentRow.Index]["RouteCode"].ToString());

        }

        private void GridToFormObj()
        {
            if (ShipmentRouteDT.Rows.Count >= 1)
            {
                txtRouteCode.Text = ShipmentRouteDT.Rows[dgvRoute.CurrentRow.Index]["RouteCode"].ToString();
                txtRouteName.Text = ShipmentRouteDT.Rows[dgvRoute.CurrentRow.Index]["RouteName"].ToString();
                txtRminCharge.Text = ShipmentRouteDT.Rows[dgvRoute.CurrentRow.Index]["RMinCharge"].ToString();
                txtPerCBMCharge.Text = ShipmentRouteDT.Rows[dgvRoute.CurrentRow.Index]["RPerCBMCharge"].ToString();
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           // PublicRef.ForInputSecurity(txtSearch.Text, txtSearch);
            ShipmentRouteDT = ConDB.GetShipmentRoute(@"SELECT  * From ShipmentRoute " +
                 @" WHERE RouteCode like '%" + txtSearch.Text + "%' or " +
                 @" RouteName like '%" + txtSearch.Text + "%' and " +
                  @" Deleted = 0 ORDER BY CreatedDate DESC ");
            dgvRoute.DataSource = ShipmentRouteDT;
        }

        private void txtRouteNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = false;
                return;
            }

            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtRminCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = false;
                return;
            }

            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
                e.Handled = true;
            
        }

   
   
    }
}
