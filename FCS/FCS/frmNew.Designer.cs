namespace FCS
{
    partial class frmNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNew));
            this.dgvTran = new System.Windows.Forms.DataGridView();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnViewP = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbRemarks = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFreightNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmtTot = new System.Windows.Forms.TextBox();
            this.txtCBMTot = new System.Windows.Forms.TextBox();
            this.txtBoxTot = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTran
            // 
            this.dgvTran.AllowUserToAddRows = false;
            this.dgvTran.AllowUserToDeleteRows = false;
            this.dgvTran.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTran.Location = new System.Drawing.Point(13, 90);
            this.dgvTran.Name = "dgvTran";
            this.dgvTran.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTran.Size = new System.Drawing.Size(641, 214);
            this.dgvTran.TabIndex = 0;
            this.dgvTran.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTran_EditingControlShowing);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(12, 337);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(110, 30);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnViewP
            // 
            this.btnViewP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewP.Location = new System.Drawing.Point(406, 337);
            this.btnViewP.Name = "btnViewP";
            this.btnViewP.Size = new System.Drawing.Size(110, 30);
            this.btnViewP.TabIndex = 2;
            this.btnViewP.Text = "View Print";
            this.btnViewP.UseVisualStyleBackColor = true;
            this.btnViewP.Click += new System.EventHandler(this.btnViewP_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.Location = new System.Drawing.Point(276, 337);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(110, 30);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialize.Location = new System.Drawing.Point(141, 337);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(110, 30);
            this.btnInitialize.TabIndex = 4;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbRemarks);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDestination);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFreightNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rtbRemarks
            // 
            this.rtbRemarks.Location = new System.Drawing.Point(416, 17);
            this.rtbRemarks.Name = "rtbRemarks";
            this.rtbRemarks.Size = new System.Drawing.Size(208, 61);
            this.rtbRemarks.TabIndex = 10;
            this.rtbRemarks.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remarks:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(99, 54);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(235, 24);
            this.txtDestination.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Destination:";
            // 
            // txtFreightNo
            // 
            this.txtFreightNo.Location = new System.Drawing.Point(99, 17);
            this.txtFreightNo.Name = "txtFreightNo";
            this.txtFreightNo.ReadOnly = true;
            this.txtFreightNo.Size = new System.Drawing.Size(82, 24);
            this.txtFreightNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Freight No:";
            // 
            // txtAmtTot
            // 
            this.txtAmtTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmtTot.Location = new System.Drawing.Point(565, 304);
            this.txtAmtTot.Name = "txtAmtTot";
            this.txtAmtTot.ReadOnly = true;
            this.txtAmtTot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmtTot.Size = new System.Drawing.Size(89, 21);
            this.txtAmtTot.TabIndex = 7;
            this.txtAmtTot.Visible = false;
            this.txtAmtTot.WordWrap = false;
            // 
            // txtCBMTot
            // 
            this.txtCBMTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCBMTot.Location = new System.Drawing.Point(485, 304);
            this.txtCBMTot.Name = "txtCBMTot";
            this.txtCBMTot.ReadOnly = true;
            this.txtCBMTot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCBMTot.Size = new System.Drawing.Size(73, 21);
            this.txtCBMTot.TabIndex = 10;
            this.txtCBMTot.Visible = false;
            this.txtCBMTot.WordWrap = false;
            // 
            // txtBoxTot
            // 
            this.txtBoxTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTot.Location = new System.Drawing.Point(428, 304);
            this.txtBoxTot.Name = "txtBoxTot";
            this.txtBoxTot.ReadOnly = true;
            this.txtBoxTot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxTot.Size = new System.Drawing.Size(50, 21);
            this.txtBoxTot.TabIndex = 12;
            this.txtBoxTot.Visible = false;
            this.txtBoxTot.WordWrap = false;
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(666, 377);
            this.Controls.Add(this.txtBoxTot);
            this.Controls.Add(this.txtCBMTot);
            this.Controls.Add(this.txtAmtTot);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnViewP);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.dgvTran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNew_FormClosing);
            this.Load += new System.EventHandler(this.frmNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTran;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnViewP;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFreightNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmtTot;
        private System.Windows.Forms.RichTextBox rtbRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCBMTot;
        private System.Windows.Forms.TextBox txtBoxTot;
    }
}