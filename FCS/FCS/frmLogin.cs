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
    public partial class frmLogin : Form
    {
  
        ConDB ConDB = new ConDB();
        DataTable AccountDT = new DataTable();
        public frmLogin()
        {
            InitializeComponent();
        }

 

        private void LogValidate(){
            AccountDT = ConDB.GetUserAccount(@"Select * From UserAccount where UserName= '" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'");
            if (AccountDT.Rows.Count >= 1)
            {
               
                frmMain frmMain = new frmMain(int.Parse(AccountDT.Rows[0]["UserID"].ToString()));
               // frmMain.LoginID = int.Parse(AccountDT.Rows[0]["UserID"].ToString());
                frmMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

  


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogValidate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogValidate();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogValidate();
            }
        }
    }
}
