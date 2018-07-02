using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCS
{
    public partial class frmUploadItem : Form
    {
        ConDB ConDB = new ConDB();
        DataTable ExcelDT = new DataTable();
        DataTable BoxDT = new DataTable();
        InsertSP InsertSP = new InsertSP();
       // private string OpfdPathStr;

        private int LoginID;

        public frmUploadItem(int loginID)
            
        {
            InitializeComponent();
            this.LoginID = loginID;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog opfd = new OpenFileDialog();

            if (opfd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = opfd.FileName;

            }
        }
        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

        private DataParameter _inputParameter;

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //OpenExcel();
            if (!backgroundWorker1.IsBusy)
            {
                _inputParameter.Delay = 10;
                // _inputParameter.Process = 108;
                backgroundWorker1.RunWorkerAsync(_inputParameter);
            }

        }
        private void OpenExcel() {
        
          

            //string q = ExcelDT.Rows[1]["Product Code"].ToString();
            // MessageBox.Show(q.ToString());

            //for (int r = 0; r < ExcelDT.Rows.Count; r++)    //Find Supplier Name and PO Num
            //{
            //    for (int c = 0; c < ExcelDT.Columns.Count; c++)
            //    {
            //        string q = ExcelDT.Rows[r][c].ToString();
            //        if (q.Contains("Product Code"))
            //        {
            //            suppName = ExcelDT.Rows[r + 1][c].ToString() + ExcelDT.Rows[r + 2][c].ToString();
            //            suppPO = ExcelDT.Rows[r][c + 1].ToString().Remove(0, 9).Trim();
            //        }
            //    }
            //}



        }

        private void frmUploadItem_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtFilePath.Text + " ;Extended Properties='Excel 8.0;HDR=Yes;'";
            OleDbConnection conn = new OleDbConnection(con);
            OleDbDataAdapter da = new OleDbDataAdapter("Select * FROM [Sheet1$]", con);
            da.Fill(ExcelDT);

           // int process = ExcelDT.Rows.Count;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;

            try {
                for (int r = 0; r < ExcelDT.Rows.Count; r++)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        backgroundWorker1.ReportProgress(index++ * 100 / ExcelDT.Rows.Count, string.Format("Process data {0}", ExcelDT.Rows.Count));
                        Thread.Sleep(delay); // used to simulate length of operation
                                             //add your code here
                                             //..
                        if (ExcelDT.Rows[r]["Product Code"].ToString() != "" || ExcelDT.Rows[r]["Product Name"].ToString() != "" || ExcelDT.Rows[r]["Box Code"].ToString() != "")
                        {
                            BoxDT = ConDB.GetBox(@"Select BoxNo From Box Where Box.BoxCode ='" + ExcelDT.Rows[r]["Box Code"].ToString() + "'");
                            if (BoxDT.Rows.Count >= 1)
                            {
                                InsertSP.InsertItem(LoginID, ExcelDT.Rows[r]["Product Code"].ToString(), ExcelDT.Rows[r]["Product Name"].ToString(), int.Parse(BoxDT.Rows[0]["BoxNo"].ToString()));
                                
                            }
                        }
                    }

                }
          }
            catch (Exception ex) {
                backgroundWorker1.CancelAsync();
                MessageBox.Show(ex.Message);
            }        
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = e.ProgressPercentage;
               // lblProgress.Text = string.Format("Process...{0}%", e.ProgressPercentage);
                progressBar1.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Upload Item Successfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
