namespace FCS
{
    partial class frmBoxSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoxSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvBox = new System.Windows.Forms.DataGridView();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBMPerBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 60);
            this.groupBox1.TabIndex = 27;
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
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvBox
            // 
            this.dgvBox.AllowUserToAddRows = false;
            this.dgvBox.AllowUserToDeleteRows = false;
            this.dgvBox.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedBy,
            this.CreatedDate,
            this.ModifyBy,
            this.ModifyDate,
            this.Deleted,
            this.BoxCode,
            this.BoxName,
            this.Length,
            this.Width,
            this.Height,
            this.CBMPerBox,
            this.ItemQty});
            this.dgvBox.Location = new System.Drawing.Point(12, 87);
            this.dgvBox.Name = "dgvBox";
            this.dgvBox.ReadOnly = true;
            this.dgvBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBox.Size = new System.Drawing.Size(326, 264);
            this.dgvBox.TabIndex = 28;
            this.dgvBox.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBox_RowHeaderMouseDoubleClick);
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            this.CreatedBy.Visible = false;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Visible = false;
            // 
            // ModifyBy
            // 
            this.ModifyBy.DataPropertyName = "ModifyBy";
            this.ModifyBy.HeaderText = "ModifyBy";
            this.ModifyBy.Name = "ModifyBy";
            this.ModifyBy.ReadOnly = true;
            this.ModifyBy.Visible = false;
            // 
            // ModifyDate
            // 
            this.ModifyDate.DataPropertyName = "ModifyDate";
            this.ModifyDate.HeaderText = "ModifyDate";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ReadOnly = true;
            this.ModifyDate.Visible = false;
            // 
            // Deleted
            // 
            this.Deleted.DataPropertyName = "Deleted";
            this.Deleted.HeaderText = "Deleted";
            this.Deleted.Name = "Deleted";
            this.Deleted.ReadOnly = true;
            this.Deleted.Visible = false;
            // 
            // BoxCode
            // 
            this.BoxCode.DataPropertyName = "BoxCode";
            this.BoxCode.HeaderText = "BoxCode";
            this.BoxCode.Name = "BoxCode";
            this.BoxCode.ReadOnly = true;
            // 
            // BoxName
            // 
            this.BoxName.DataPropertyName = "BoxName";
            this.BoxName.HeaderText = "BoxName";
            this.BoxName.Name = "BoxName";
            this.BoxName.ReadOnly = true;
            this.BoxName.Width = 210;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Visible = false;
            this.Length.Width = 50;
            // 
            // Width
            // 
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            this.Width.Visible = false;
            this.Width.Width = 50;
            // 
            // Height
            // 
            this.Height.DataPropertyName = "Height";
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            this.Height.Visible = false;
            this.Height.Width = 50;
            // 
            // CBMPerBox
            // 
            this.CBMPerBox.DataPropertyName = "CBMPerBox";
            this.CBMPerBox.HeaderText = "CBMPerBox";
            this.CBMPerBox.Name = "CBMPerBox";
            this.CBMPerBox.ReadOnly = true;
            this.CBMPerBox.Visible = false;
            this.CBMPerBox.Width = 70;
            // 
            // ItemQty
            // 
            this.ItemQty.DataPropertyName = "ItemQty";
            this.ItemQty.HeaderText = "ItemQty";
            this.ItemQty.Name = "ItemQty";
            this.ItemQty.ReadOnly = true;
            this.ItemQty.Visible = false;
            this.ItemQty.Width = 50;
            // 
            // frmBoxSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(350, 365);
            this.Controls.Add(this.dgvBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBoxSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box Search";
            this.Load += new System.EventHandler(this.frmBoxSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBMPerBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQty;
    }
}