namespace FCS
{
    partial class frmSuppFreightReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppFreightReport));
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpOpt1 = new System.Windows.Forms.GroupBox();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.grpOpt2 = new System.Windows.Forms.GroupBox();
            this.txtPONum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbOpt2 = new System.Windows.Forms.RadioButton();
            this.rbOpt1 = new System.Windows.Forms.RadioButton();
            this.btnViewPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpOpt1.SuspendLayout();
            this.grpOpt2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(42, 17);
            this.dtpFrom.MinDate = new System.DateTime(2017, 2, 16, 17, 50, 20, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(131, 20);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.Value = new System.DateTime(2017, 2, 22, 23, 59, 59, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(217, 17);
            this.dtpTo.MinDate = new System.DateTime(2017, 2, 16, 17, 50, 20, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(131, 20);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Value = new System.DateTime(2017, 2, 22, 23, 59, 59, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier Name:";
            // 
            // grpOpt1
            // 
            this.grpOpt1.Controls.Add(this.txtSuppName);
            this.grpOpt1.Controls.Add(this.label3);
            this.grpOpt1.Controls.Add(this.groupBox1);
            this.grpOpt1.Location = new System.Drawing.Point(21, 46);
            this.grpOpt1.Name = "grpOpt1";
            this.grpOpt1.Size = new System.Drawing.Size(451, 127);
            this.grpOpt1.TabIndex = 7;
            this.grpOpt1.TabStop = false;
            this.grpOpt1.Text = "Option 1";
            // 
            // txtSuppName
            // 
            this.txtSuppName.Location = new System.Drawing.Point(101, 26);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.ReadOnly = true;
            this.txtSuppName.Size = new System.Drawing.Size(269, 20);
            this.txtSuppName.TabIndex = 6;
            this.txtSuppName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSupp_MouseDoubleClick);
            // 
            // grpOpt2
            // 
            this.grpOpt2.Controls.Add(this.txtPONum);
            this.grpOpt2.Controls.Add(this.label4);
            this.grpOpt2.Location = new System.Drawing.Point(21, 184);
            this.grpOpt2.Name = "grpOpt2";
            this.grpOpt2.Size = new System.Drawing.Size(451, 57);
            this.grpOpt2.TabIndex = 8;
            this.grpOpt2.TabStop = false;
            this.grpOpt2.Text = "Option 2";
            // 
            // txtPONum
            // 
            this.txtPONum.Location = new System.Drawing.Point(101, 21);
            this.txtPONum.Name = "txtPONum";
            this.txtPONum.Size = new System.Drawing.Size(80, 20);
            this.txtPONum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PO Number:";
            // 
            // rbOpt2
            // 
            this.rbOpt2.AutoSize = true;
            this.rbOpt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpt2.Location = new System.Drawing.Point(167, 11);
            this.rbOpt2.Name = "rbOpt2";
            this.rbOpt2.Size = new System.Drawing.Size(82, 22);
            this.rbOpt2.TabIndex = 9;
            this.rbOpt2.Text = "Option 2";
            this.rbOpt2.UseVisualStyleBackColor = true;
            this.rbOpt2.CheckedChanged += new System.EventHandler(this.rbOpt2_CheckedChanged);
            // 
            // rbOpt1
            // 
            this.rbOpt1.AutoSize = true;
            this.rbOpt1.Checked = true;
            this.rbOpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpt1.Location = new System.Drawing.Point(31, 11);
            this.rbOpt1.Name = "rbOpt1";
            this.rbOpt1.Size = new System.Drawing.Size(82, 22);
            this.rbOpt1.TabIndex = 10;
            this.rbOpt1.TabStop = true;
            this.rbOpt1.Text = "Option 1";
            this.rbOpt1.UseVisualStyleBackColor = true;
            this.rbOpt1.CheckedChanged += new System.EventHandler(this.rbOpt1_CheckedChanged);
            // 
            // btnViewPrint
            // 
            this.btnViewPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPrint.Location = new System.Drawing.Point(298, 9);
            this.btnViewPrint.Name = "btnViewPrint";
            this.btnViewPrint.Size = new System.Drawing.Size(93, 30);
            this.btnViewPrint.TabIndex = 11;
            this.btnViewPrint.Text = "View Print";
            this.btnViewPrint.UseVisualStyleBackColor = true;
            this.btnViewPrint.Click += new System.EventHandler(this.btnViewPrint_Click);
            // 
            // frmSuppFreightReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnViewPrint);
            this.Controls.Add(this.rbOpt1);
            this.Controls.Add(this.rbOpt2);
            this.Controls.Add(this.grpOpt2);
            this.Controls.Add(this.grpOpt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSuppFreightReport";
            this.Text = "Supplier Freight Report";
            this.Load += new System.EventHandler(this.frmSuppFreight_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOpt1.ResumeLayout(false);
            this.grpOpt1.PerformLayout();
            this.grpOpt2.ResumeLayout(false);
            this.grpOpt2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpOpt1;
        private System.Windows.Forms.GroupBox grpOpt2;
        private System.Windows.Forms.RadioButton rbOpt2;
        private System.Windows.Forms.RadioButton rbOpt1;
        private System.Windows.Forms.TextBox txtPONum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewPrint;
        private System.Windows.Forms.TextBox txtSuppName;
    }
}