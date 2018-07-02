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
    public partial class frmMain : Form
    {

        public int LoginID;

        DataTable AccountDT = new DataTable();
        ConDB ConDB = new ConDB();
        //{
        //    get { return UserIDstr; }
        //    set { UserIDstr = value; }
        //}
        public frmMain(int loginID)
        {
            InitializeComponent();
            this.LoginID = loginID;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["New"].ToString()) == true)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmNew))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmNew frmNew = new frmNew(this.LoginID);
                frmNew.MdiParent = this;
                frmNew.Show();
            } else {
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
    
        }

        private void btnShipmentR_Click(object sender, EventArgs e)
        {

            if (Convert.ToBoolean(AccountDT.Rows[0]["ShipmentRoute"].ToString()) == true)
            {

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmShipmentRoute))
                    {
                        form.Activate();
                        return;
                    }
                }


                frmShipmentRoute frmShipmentRoute = new frmShipmentRoute(this.LoginID);
                frmShipmentRoute.MdiParent = this;
                frmShipmentRoute.Show();
            } else {
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnItemSet_Click(object sender, EventArgs e)
        {

            if (Convert.ToBoolean(AccountDT.Rows[0]["Item"].ToString()) == true)
            {

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmItem))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmItem frmItemSet = new frmItem(this.LoginID);
                frmItemSet.MdiParent = this;
                frmItemSet.Show();
            } else {
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void btnFreightSet_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["Box"].ToString()) == true)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmBoxSet))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmBoxSet frmFreightSet = new frmBoxSet(this.LoginID);
                frmFreightSet.MdiParent = this;
                frmFreightSet.Show();
            } else{
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

          
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["UserAccount"].ToString()) == true)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmUserAccount))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmUserAccount frmUserAccount = new frmUserAccount(this.LoginID);
                frmUserAccount.MdiParent = this;
                frmUserAccount.Show();

            } else{
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


          
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["Location"].ToString()) == true)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmLocation))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmLocation frmLocation = new frmLocation(this.LoginID);
                frmLocation.MdiParent = this;
                frmLocation.Show();

            }
            else {
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          

        }

      

        private void frmMain_Load(object sender, EventArgs e)
        {
            AccountDT = ConDB.GetUserAccount(@"Select * From UserAccount where UserID= '" + LoginID.ToString() + "'");
        }

        private void ValidatePermission() {
          


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["Other"].ToString()) == true)
            {

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmUploadItem))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmUploadItem frmUploadItem = new frmUploadItem(this.LoginID);
                frmUploadItem.MdiParent = this;
                frmUploadItem.Show();
            }
            else
            {
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsmTranWayBill_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["Proforma"].ToString()) == true)
            {

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmTransac))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmTransac frmTransac = new frmTransac();
                frmTransac.MdiParent = this;
                frmTransac.Show();
            } else {
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void tsmSupplierFreight_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["Proforma"].ToString()) == true) {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmSuppFreightReport))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmSuppFreightReport frmSuppFreight = new frmSuppFreightReport();
                frmSuppFreight.MdiParent = this;
                frmSuppFreight.Show();

            } else {
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

               
        }

        private void tsmShimpentRoute_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["Proforma"].ToString()) == true)
            {

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmShipmentRReport))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmShipmentRReport frmShipmentRReport = new frmShipmentRReport();
                frmShipmentRReport.MdiParent = this;
                frmShipmentRReport.Show();
            } else {
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void tsmBox_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(AccountDT.Rows[0]["Proforma"].ToString()) == true)
            {

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmBoxReport))
                    {
                        form.Activate();
                        return;
                    }
                }
                frmBoxReport frmBoxReport = new frmBoxReport();
                frmBoxReport.MdiParent = this;
                frmBoxReport.Show();
            } else{
                MessageBox.Show("Access Denied", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

  

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            Application.Exit();
        }

        private void uploadLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
