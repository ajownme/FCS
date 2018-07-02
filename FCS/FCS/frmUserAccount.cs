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
    public partial class frmUserAccount : Form
    {
        UpdateSP UpdateSP = new UpdateSP();
        ConDB ConDB = new ConDB();
        DataTable DTUserAccount = new DataTable();
        InsertSP InsertSP = new InsertSP();
        bool NewOrEdit;

        private bool bitNew;
        private bool bitLocation;
        private bool bitShipmentRoute;
        private bool bitItem;
        private bool bitBox;
        private bool bitProforma;
        private bool bitOther;
        private bool bitUserAccount;
        private int UserID;
        private string newPass;
        private int LoginID;


        public frmUserAccount(int loginID)
        {
            InitializeComponent();
            this.LoginID = loginID;
        }

     
        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            NewOrEdit = false;
            UIEffect("Default");
            TreeViewSetUp();
            LoadToGrid();
            GridToFormObj();
        }

        private void TreeViewSetUp()
        {
            trvPermission.ItemHeight = 25; 
            trvPermission.Nodes.Add("New"); //trvPermission.Nodes[0].BackColor = Color;
            trvPermission.Nodes.Add("Location");
            trvPermission.Nodes.Add("ShipmentRoute");
            trvPermission.Nodes.Add("Item");
            trvPermission.Nodes.Add("Box");
            trvPermission.Nodes.Add("Proforma");
            trvPermission.Nodes.Add("Other");
            trvPermission.Nodes.Add("UserAccount");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void CheckTNodeValues() {
            if (trvPermission.Nodes[0].Checked == true) { bitNew = true; } else { bitNew= false; }
            if (trvPermission.Nodes[1].Checked == true) { bitLocation = true; } else { bitLocation = false; }
            if (trvPermission.Nodes[2].Checked == true) { bitShipmentRoute = true; } else { bitShipmentRoute = false; }
            if (trvPermission.Nodes[3].Checked == true) { bitItem = true; } else { bitItem = false; }
            if (trvPermission.Nodes[4].Checked == true) { bitBox = true; } else { bitBox = false; }
            if (trvPermission.Nodes[5].Checked == true) { bitProforma = true; } else { bitProforma = false; }
            if (trvPermission.Nodes[6].Checked == true) { bitOther = true; } else { bitOther = false; }
            if (trvPermission.Nodes[7].Checked == true) { bitUserAccount = true; } else { bitUserAccount = false; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "" || txtNewPass.Text == "" )
            {
                MessageBox.Show("Incomplete Input", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Save Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (NewOrEdit == false) {
                        CheckTNodeValues();
                        newPass = txtNewPass.Text;
                        InsertSP.InsertUserAccount(this.LoginID,txtUserName.Text, newPass, bitLocation, bitShipmentRoute, bitItem, bitBox, bitProforma, bitOther, bitUserAccount, bitNew);
                        MessageBox.Show("Successfully Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UIEffect("Save");
                        LoadToGrid();
                        GridToFormObj();

                    } else if (NewOrEdit == true) {
                        ForEditingPword();
                    }

                 
                  
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UIEffect("Edit");
            NewOrEdit = true;
        }

        private void ValidateSaving() {

            if (NewOrEdit==true) {

            }
        }

        private void UIEffect(string Effect)
        {
            switch (Effect)
            {
                case "Default":
                    txtUserName.ReadOnly = true;
                    txtOldPass.ReadOnly = true;
                    txtNewPass.ReadOnly = true;
                    dgvAccount.Enabled = true;
                    trvPermission.Enabled = false;       
                    txtSearch.ReadOnly = false;
                    btnUADetail.Enabled = false;    
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    break;

                case "New":
                    txtUserName.ReadOnly = false;
                    txtUserName.Enabled = true;
                    txtOldPass.Enabled = false;
                    txtNewPass.Enabled = false;
                    trvPermission.Enabled = true;

                    dgvAccount.Enabled = false;
                    txtSearch.ReadOnly = true;

                    btnSave.Enabled = true;
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                   txtUserName.Clear();
                    txtNewPass.Text = "123";
                   txtOldPass.Clear();

                    break;

                case "Cancel":
                    txtUserName.ReadOnly = true;
                    txtOldPass.ReadOnly = true;
                    txtNewPass.ReadOnly = true;
                    txtNewPass.Enabled = true;
                    dgvAccount.Enabled = true;
                    txtSearch.ReadOnly = false;
                    trvPermission.Enabled = false;
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    btnUADetail.Enabled = true;
                    txtUserName.Clear();
                   txtNewPass.Clear();
                   txtOldPass.Clear();

                    break;

                case "Edit":
                   // grpAcctDetails.Enabled = false;
                    txtUserName.ReadOnly = true;
                    txtOldPass.ReadOnly = true;
                    txtNewPass.ReadOnly = true;
                    trvPermission.Enabled = true;
                    dgvAccount.Enabled = false;
                    txtUserName.Enabled = false;
                    txtOldPass.Enabled = false;
                    txtNewPass.Enabled = false;
                    btnUADetail.Enabled = true;
                    txtSearch.ReadOnly = true;

                    btnSave.Enabled = true;
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                   // txtNewPass.Clear();
                    break;

                case "Save":
                    txtUserName.ReadOnly = true;
                    txtNewPass.ReadOnly = true;
                    txtOldPass.ReadOnly = true;
                    trvPermission.Enabled = false;
                    dgvAccount.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;

                    break;

                case "Delete":
                    txtUserName.Clear();
                    txtNewPass.Clear();
                    txtOldPass.Clear();
                    break;

                case "UADetail":
                    txtUserName.Clear();
                    txtOldPass.Clear();
                    txtNewPass.Clear();
                    txtUserName.ReadOnly = false;
                    txtNewPass.ReadOnly = false;
                    txtOldPass.ReadOnly = false;
                    txtUserName.Enabled = true;
                    txtOldPass.Enabled = true;
                    txtNewPass.Enabled = true;
                    btnUADetail.Enabled = false;
                    break;


            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewOrEdit = false;
            UIEffect("New");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UIEffect("Cancel");
            GridToFormObj();
        }


        private void LoadToGrid() {

            DTUserAccount = ConDB.GetUserAccount(@"Select * From UserAccount where Deleted = 0 order by CreatedDate DESC ");
            dgvAccount.DataSource = DTUserAccount;
        }


        private void GridToFormObj()
        {
            if (DTUserAccount.Rows.Count >= 1)
            {
                UserID = int.Parse(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["UserID"].ToString());
                txtUserName.Text = DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["UserName"].ToString();
                txtOldPass.Text = DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["Password"].ToString();
                txtNewPass.Text = DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["Password"].ToString();
                if (Convert.ToBoolean(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["New"]) == true)
                {trvPermission.Nodes[0].Checked = true; } else { trvPermission.Nodes[0].Checked = false; }

                if (Convert.ToBoolean(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["Location"]) == true)
                { trvPermission.Nodes[1].Checked = true; }
                else { trvPermission.Nodes[1].Checked = false; }

                if (Convert.ToBoolean(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["ShipmentRoute"]) == true)
                { trvPermission.Nodes[2].Checked = true; }
                else { trvPermission.Nodes[2].Checked = false; }

                if (Convert.ToBoolean(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["Item"]) == true)
                { trvPermission.Nodes[3].Checked = true; }
                else { trvPermission.Nodes[3].Checked = false; }

                if (Convert.ToBoolean(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["Box"]) == true)
                { trvPermission.Nodes[4].Checked = true; }
                else { trvPermission.Nodes[4].Checked = false; }

                if (Convert.ToBoolean(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["Proforma"]) == true)
                { trvPermission.Nodes[5].Checked = true; }
                else { trvPermission.Nodes[5].Checked = false; }

                if (Convert.ToBoolean(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["Other"]) == true)
                { trvPermission.Nodes[6].Checked = true; }
                else { trvPermission.Nodes[6].Checked = false; }

                if (Convert.ToBoolean(DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["UserAccount"]) == true)
                { trvPermission.Nodes[7].Checked = true; }
                else { trvPermission.Nodes[7].Checked = false; }

            }

        }

        private void dgvAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridToFormObj();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DTUserAccount = ConDB.GetUserAccount(@"SELECT  * FROM UserAccount  " +
                @" WHERE UserName like '%" + txtSearch.Text + "%' and " +
                @" Deleted = 0 ORDER BY CreatedDate DESC ");
            dgvAccount.DataSource = DTUserAccount;
        }

        private void ForEditingPword() {
            if (DTUserAccount.Rows[dgvAccount.CurrentRow.Index]["Password"].ToString() == txtOldPass.Text)
            {
                newPass = txtNewPass.Text;
                CheckTNodeValues();
                UpdateSP.UpdateUserAccount(int.Parse(UserID.ToString()), txtUserName.Text, newPass, bitLocation, bitShipmentRoute, bitItem, bitBox, bitProforma, bitOther, bitUserAccount, bitNew);
                MessageBox.Show("Successfully Updated", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UIEffect("Save");
                LoadToGrid();
                GridToFormObj();

            }
            else {
                MessageBox.Show("Invalid Password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUADetail_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to edit Account Detail?", "Editing Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                UIEffect("UADetail");
            }
               
        }
    }
}
