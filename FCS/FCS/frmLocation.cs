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

        public partial class frmLocation : Form
        {
        DataTable LocationDT = new DataTable();
        DataTable ShipmentRouteDT = new DataTable();
        ConDB ConDB = new ConDB();
        InsertSP InsertSP = new InsertSP();
        UpdateSP UpdateSP = new UpdateSP();
        RemoveSP RemoveSP = new RemoveSP();
        // PublicRef PublicRef = new PublicRef();
        private int LoginID;
        bool NewOrEdit { get; set; }
        bool RouteSearchFlag { get; set; }
        int RouteNoStr { get; set; }

        public frmLocation(int loginID)
            {
                InitializeComponent();
            this.LoginID = loginID;
            }

       

            private void frmLocation_Load(object sender, EventArgs e)
            {   
           
            LoadToGrid();
           GridToFormObj();  
            UIEffect("Default");
            
        }

            private void LoadToGrid()
            {
        
            LocationDT = ConDB.GetLocation(@"SELECT  Location.*, ShipmentRoute.RouteName From Location Inner Join ShipmentRoute on Location.RouteNo = ShipmentRoute.RouteNo WHERE Location.Deleted = 0 ORDER BY Location.CreatedDate DESC ");
           // if (LocationDT.Rows.Count >= 1) {
                dgvLocation.DataSource = LocationDT;
           // }
           
        }

     

        private void GridToFormObj() {
            if (LocationDT.Rows.Count >= 1)
            {
                txtLocaCode.Text = LocationDT.Rows[dgvLocation.CurrentRow.Index]["LocationCode"].ToString();
                txtLocaName.Text = LocationDT.Rows[dgvLocation.CurrentRow.Index]["LocationName"].ToString();
                txtSRoute.Text = LocationDT.Rows[dgvLocation.CurrentRow.Index]["RouteName"].ToString();
                RouteNoStr = int.Parse(LocationDT.Rows[dgvLocation.CurrentRow.Index]["RouteNo"].ToString());
            }
               
        }

            private void UIEffect(string Effect)
            {
                switch (Effect)
                {
                    case "Default":
                    txtSearch.ReadOnly = false;
                    txtLocaCode.ReadOnly = true;
                    txtLocaName.ReadOnly = true;
                    //cmbRouteCode.ReadOnly = true;
                    txtLocaName.ReadOnly = true;
                        btnSave.Enabled = false;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnCancel.Enabled = false;
                    dgvLocation.Enabled = true;
                    break;

                    case "New":
                    txtLocaCode.ReadOnly = false;
                    txtSearch.ReadOnly = true;
                    txtLocaName.ReadOnly = false;
                        txtLocaCode.Clear();
                        txtLocaName.Clear();
                    txtSRoute.Text = "";
                        btnSave.Enabled = true;
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        btnCancel.Enabled = true;
                       // txtLocaCode.Text = IncrementID.IncrementMethod().ToString();
                    dgvLocation.Enabled = false;
                    break;

                    case "Cancel":
                    txtLocaCode.ReadOnly = true;
                    txtLocaName.ReadOnly = true;
                    txtSearch.ReadOnly = false;
                    btnSave.Enabled = false;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnCancel.Enabled = false;
                    dgvLocation.Enabled = true;
                    break;

                    case "Edit":
                    txtSearch.ReadOnly = true;
                    txtLocaCode.ReadOnly = false;
                    txtLocaName.ReadOnly = false;
                        btnSave.Enabled = true;
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        btnCancel.Enabled = true;
                    dgvLocation.Enabled = false;
                    break;

                    case "Save":
                    txtLocaName.ReadOnly = true;
                    txtLocaCode.ReadOnly = true;
                    txtSearch.ReadOnly = false;
                    btnSave.Enabled = false;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnCancel.Enabled = false;
                    dgvLocation.Enabled = true;
                    txtLocaCode.Clear();
                    txtLocaName.Clear();
                    break;

                case "Delete":        
                    txtLocaCode.Clear();
                    txtLocaName.Clear();
                    txtSRoute.Clear();
                    break;
            }

        }

        private void dgvLocation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridToFormObj();       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RouteSearchFlag = true;
            NewOrEdit = false;
            UIEffect("New");
           // LoadToCMBRoute();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RouteSearchFlag = false;
            UIEffect("Cancel");
            GridToFormObj();
            // int i;


            // MessageBox.Show(i.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            RouteSearchFlag = true;
            NewOrEdit = true;
            UIEffect("Edit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtLocaCode.Text == "" || txtLocaName.Text == "" || txtSRoute.Text == "")
            {
                MessageBox.Show("Incomplete Input", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Save Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (NewOrEdit == false)
                    {
                        InsertSP.InsertLocation(LoginID, txtLocaCode.Text, txtLocaName.Text, RouteNoStr);
                        MessageBox.Show("Successfully Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (NewOrEdit == true)
                    {
                        UpdateSP.UpdateLocation(int.Parse(LocationDT.Rows[dgvLocation.CurrentRow.Index]["LocationNo"].ToString()),txtLocaCode.Text, txtLocaName.Text, int.Parse(RouteNoStr.ToString()));
                        MessageBox.Show("Successfully Updated", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    RouteSearchFlag = false;
                    UIEffect("Save");
                    LoadToGrid();
                    GridToFormObj();
                }
                  
            }


           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          //  PublicRef.ForInputSecurity(txtSearch.Text, txtSearch);
            LocationDT = ConDB.GetLocation(@"SELECT  * From Location " +
                    @" WHERE LocationCode like '%" + txtSearch.Text + "%' or " +
                    @" LocationName like '%" + txtSearch.Text + "%' and " +
                     @" Deleted = 0 ORDER BY CreatedDate DESC " );
            dgvLocation.DataSource = LocationDT;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvLocation.Rows.Count   >= 1) {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Delete Validation", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    RemoveSP.DeleteLocation(int.Parse(LocationDT.Rows[dgvLocation.CurrentRow.Index]["LocationNo"].ToString()));
                    MessageBox.Show("Successfully Deleted", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UIEffect("Delete");
                    LoadToGrid();
                    GridToFormObj();

                }       
            }
        }

        private void txtLocaCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = false;
                return;
            }

            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }


        //private void LoadToCMBRoute()
        //{
            
        //    ShipmentRouteDT = ConDB.GetShipmentRoute(@"SELECT  * From ShipmentRoute WHERE  Deleted = 0 ORDER BY RouteCode ASC ");
        //    if (ShipmentRouteDT.Rows.Count >= 1)
        //    {
        //        cmbRouteCode.Items.Clear();
        //        for (int i = 0; i < ShipmentRouteDT.Rows.Count; i++)
        //        {
        //            cmbRouteCode.Items.Add(ShipmentRouteDT.Rows[i]["RouteCode"].ToString());
        //        }

        //    }

        //}

        private void cmbRouteCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtLocaName_TextChanged(object sender, EventArgs e)
        {
           // PublicRef.ForInputSecurity(txtLocaName.Text, txtLocaName);
        }

        private void txtSRoute_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (RouteSearchFlag == true)
            {
                frmSRouteSearch frmSRouteSearch = new frmSRouteSearch();
                frmSRouteSearch.ShowDialog();
                RouteNoStr = frmSRouteSearch.BackRNum;
                txtSRoute.Text = frmSRouteSearch.BackRName;

            }
        }

   
    }
    }
