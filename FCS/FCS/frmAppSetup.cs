using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using System.Data.SqlClient;

namespace FCS
{
  
    public partial class frmAppSetup : Form
    {
      public  Thread th;
        PublicRef ConSetup = new PublicRef();
        public frmAppSetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //read
            //  object cc = Registry.CurrentUser.OpenSubKey(@"FCSKey").GetValue("ServerHost");

        

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToRegister();
        }

        private void ToRegister() {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"FCSKey");
            reg.SetValue("ServerHost", txtServerHost.Text);
            reg.SetValue("DatabaseName", txtDatabaseName.Text);
            reg.SetValue("UserName", txtUserName.Text);
            reg.SetValue("Password", txtPassword.Text);
            validateFirstUse();
        }

        private void validateFirstUse() {
            object cc = Registry.CurrentUser.OpenSubKey(@"FCSKey");

            if (cc != null)
            {
                try
                {

                    string connString = "Data Source='" + ConSetup.GetServerHost() + "';Initial Catalog='" + ConSetup.GetDatabaseName() + "';Persist Security Info=True;User ID='" + ConSetup.GetUserName() + "';Password='" + ConSetup.GetPassword() + "'";
                    using (SqlConnection con = new SqlConnection(connString))
                    {
                        con.Open();
                    }

                    this.Close();
                    th = new Thread(OpenNext);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                catch (Exception)
                {

                    MessageBox.Show("Application Setup Mismatch", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
     
        }

        private void frmAppSetup_Load(object sender, EventArgs e)
        {
            validateFirstUse();
        }

        private void OpenNext(object obj) {
            Application.Run(new frmLogin());
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ToRegister();
            }
        }
    }
}
