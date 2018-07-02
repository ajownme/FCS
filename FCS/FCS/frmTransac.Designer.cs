namespace FCS
{
    partial class frmTransac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransac));
            this.dgvTran = new System.Windows.Forms.DataGridView();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreightNoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotalBoxQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotalCBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppNameHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PONumHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.dgvTran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedBy,
            this.FreightNoHD,
            this.FTotalBoxQty,
            this.FTotalCBM,
            this.FTotalAmount,
            this.SuppNameHD,
            this.PONumHD,
            this.CreatedDate,
            this.Remarks,
            this.BaseCost});
            this.dgvTran.Location = new System.Drawing.Point(12, 85);
            this.dgvTran.Name = "dgvTran";
            this.dgvTran.ReadOnly = true;
            this.dgvTran.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTran.Size = new System.Drawing.Size(560, 255);
            this.dgvTran.TabIndex = 0;
            this.dgvTran.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTran_RowHeaderMouseDoubleClick);
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            this.CreatedBy.Visible = false;
            // 
            // FreightNoHD
            // 
            this.FreightNoHD.DataPropertyName = "FreightNoHD";
            this.FreightNoHD.HeaderText = "FreightNo";
            this.FreightNoHD.Name = "FreightNoHD";
            this.FreightNoHD.ReadOnly = true;
            this.FreightNoHD.Width = 60;
            // 
            // FTotalBoxQty
            // 
            this.FTotalBoxQty.DataPropertyName = "FTotalBoxQty";
            this.FTotalBoxQty.HeaderText = "BoxQty";
            this.FTotalBoxQty.Name = "FTotalBoxQty";
            this.FTotalBoxQty.ReadOnly = true;
            this.FTotalBoxQty.Width = 50;
            // 
            // FTotalCBM
            // 
            this.FTotalCBM.DataPropertyName = "FTotalCBM";
            this.FTotalCBM.HeaderText = "TotalCBM";
            this.FTotalCBM.Name = "FTotalCBM";
            this.FTotalCBM.ReadOnly = true;
            this.FTotalCBM.Width = 60;
            // 
            // FTotalAmount
            // 
            this.FTotalAmount.DataPropertyName = "FTotalAmount";
            this.FTotalAmount.HeaderText = "TotalAmount";
            this.FTotalAmount.Name = "FTotalAmount";
            this.FTotalAmount.ReadOnly = true;
            this.FTotalAmount.Width = 80;
            // 
            // SuppNameHD
            // 
            this.SuppNameHD.DataPropertyName = "SuppNameHD";
            this.SuppNameHD.HeaderText = "SupplierName";
            this.SuppNameHD.Name = "SuppNameHD";
            this.SuppNameHD.ReadOnly = true;
            this.SuppNameHD.Width = 115;
            // 
            // PONumHD
            // 
            this.PONumHD.DataPropertyName = "PONumHD";
            this.PONumHD.HeaderText = "PO #";
            this.PONumHD.Name = "PONumHD";
            this.PONumHD.ReadOnly = true;
            this.PONumHD.Width = 50;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Visible = false;
            this.Remarks.Width = 150;
            // 
            // BaseCost
            // 
            this.BaseCost.DataPropertyName = "BaseCost";
            this.BaseCost.HeaderText = "BaseCost";
            this.BaseCost.Name = "BaseCost";
            this.BaseCost.ReadOnly = true;
            this.BaseCost.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 60);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(51, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 20);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTransac";
            this.Text = "Transaction Waybill";
            this.Load += new System.EventHandler(this.frmTransac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTran;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreightNoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotalBoxQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotalCBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppNameHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PONumHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseCost;
    }
}