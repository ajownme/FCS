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
    public partial class frmItem : Form
    {
       
        InsertSP InsertSP = new InsertSP();
        UpdateSP UpdateSP = new UpdateSP();
        RemoveSP RemoveSP = new RemoveSP();

        DataTable ItemDT = new DataTable();
        ConDB ConDB = new ConDB();
        bool NewOrEdit;
        bool BoxSearchFlag;
        int BoxNoStr;
        int LoginID;

        public frmItem(int loginID)
        {
            InitializeComponent();
            this.LoginID = loginID;
            //fromBoxSearch = x;
            //txtFGroup.Text = fromBoxSearch;

        }

   
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemCode.Text == "" || txtItemName.Text == "" || txtBSetup.Text == "")
            {
                MessageBox.Show("Incomplete Input", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Save Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (NewOrEdit == false){
                        InsertSP.InsertItem(this.LoginID,txtItemCode.Text  , txtItemName.Text, int.Parse(BoxNoStr.ToString()));
                        MessageBox.Show("Successfully Saved", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (NewOrEdit == true){
                     UpdateSP.UpdateItem( int.Parse(ItemDT.Rows[dgvItem.CurrentRow.Index]["ItemNo"].ToString()), txtItemCode.Text, txtItemName.Text, int.Parse(BoxNoStr.ToString()));
                        MessageBox.Show("Successfully Updated", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    UIEffect("Save");
                    LoadToGrid();
                    GridToFormObj();
                    BoxSearchFlag = false;
                }
                    
            }
               
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            BoxSearchFlag = false;
            LoadToGrid();
            GridToFormObj();
            UIEffect("Default");
        }
        private void UIEffect(string Effect)
        {
            switch (Effect)
            {
                case "Default":
                    txtItemCode.ReadOnly = true;
                    txtItemName.ReadOnly = true;
                    txtBSetup.ReadOnly = true;
    
                    dgvItem.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    break;

                case "New":
                    txtItemCode.ReadOnly = false;
                    txtItemName.ReadOnly = false;
                    txtBSetup.ReadOnly = true;

                    dgvItem.Enabled = false;
                    txtSearch.ReadOnly = true;

                    btnSave.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    txtItemCode.Clear();
                    txtItemName.Clear();
                    txtBSetup.Clear();
 
                    break;

                case "Cancel":
                    txtItemCode.ReadOnly = true;
                    txtItemName.ReadOnly = true;
                    txtBSetup.ReadOnly = true;

                    dgvItem.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;

                    txtItemCode.Clear();
                    txtItemName.Clear();
                    txtBSetup.Clear();

                    break;

                case "Edit":
                    txtItemCode.ReadOnly = false;
                    txtItemName.ReadOnly = false;
                    txtBSetup.ReadOnly = true;

                    dgvItem.Enabled = false;
                    txtSearch.ReadOnly = true;

                    btnSave.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    break;

                case "Save":
                    txtItemCode.ReadOnly = true;
                    txtItemName.ReadOnly = true;
                    txtBSetup.ReadOnly = true;

                    dgvItem.Enabled = true;
                    txtSearch.ReadOnly = false;

                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;

                    break;

                case "Delete":
                    txtItemCode.Clear();
                    txtItemName.Clear();
                    txtBSetup.Clear();
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BoxSearchFlag = true;
            NewOrEdit = false;
            UIEffect("New");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BoxSearchFlag = true;
            NewOrEdit = true;
            UIEffect("Edit");
        }

        private void LoadToGrid()
        {
            ItemDT = ConDB.GetItem(@"SELECT   Item.*, Box.BoxName FROM   Item INNER JOIN Box ON Item.BoxNo = Box.BoxNo  WHERE Item.Deleted = 0 ORDER BY CreatedDate DESC ");
            // if (LocationDT.Rows.Count >= 1) {
            dgvItem.DataSource = ItemDT;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ItemDT = ConDB.GetItem(@"SELECT  * From Item " +
                @" WHERE ItemCode like '%" + txtSearch.Text + "%' or " +
                @" ItemName like '%" + txtSearch.Text + "%' and " +
                 @" Deleted = 0 ORDER BY CreatedDate DESC ");
            dgvItem.DataSource = ItemDT;
        }

        private void dgvItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridToFormObj();

        }
        private void GridToFormObj()
        {
            if (ItemDT.Rows.Count >= 1)
            {
                txtItemCode.Text = ItemDT.Rows[dgvItem.CurrentRow.Index]["ItemCode"].ToString();
                txtItemName.Text = ItemDT.Rows[dgvItem.CurrentRow.Index]["ItemName"].ToString();
                txtBSetup.Text = ItemDT.Rows[dgvItem.CurrentRow.Index]["BoxName"].ToString();
                BoxNoStr = int.Parse(ItemDT.Rows[dgvItem.CurrentRow.Index]["BoxNo"].ToString());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BoxSearchFlag = false;
            UIEffect("Cancel");
            LoadToGrid();
            GridToFormObj();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItem.Rows.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Delete Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    RemoveSP.DeleteItem(int.Parse(ItemDT.Rows[dgvItem.CurrentRow.Index]["ItemNo"].ToString()));
                    MessageBox.Show("Successfully Deleted", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UIEffect("Delete");
                    LoadToGrid();
                    GridToFormObj();
                }
            }
       }

        private void txtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = false;
                return;
            }

            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtFGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (BoxSearchFlag == true) {
                frmBoxSearch frmBoxSearch = new frmBoxSearch();
                frmBoxSearch.ShowDialog();
                BoxNoStr = frmBoxSearch.BackBNum;
                txtBSetup.Text = frmBoxSearch.BackBName;

            }

        }



        //public void toFGroup(string q) {
        //    txtFGroup.Text = q;
        //}
    }
}
