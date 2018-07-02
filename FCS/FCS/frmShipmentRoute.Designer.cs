namespace FCS
{
    partial class frmShipmentRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipmentRoute));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRouteCode = new System.Windows.Forms.TextBox();
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.grpRoute = new System.Windows.Forms.GroupBox();
            this.txtPerCBMCharge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRminCharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RPerCBMCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMinCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Route Code:";
            // 
            // txtRouteCode
            // 
            this.txtRouteCode.Location = new System.Drawing.Point(116, 15);
            this.txtRouteCode.Name = "txtRouteCode";
            this.txtRouteCode.Size = new System.Drawing.Size(78, 20);
            this.txtRouteCode.TabIndex = 1;
            this.txtRouteCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRouteNo_KeyPress);
            // 
            // lstLocation
            // 
            this.lstLocation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.Location = new System.Drawing.Point(304, 16);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(226, 95);
            this.lstLocation.TabIndex = 2;
            this.lstLocation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstLocation_MouseDoubleClick);
            // 
            // grpRoute
            // 
            this.grpRoute.Controls.Add(this.txtPerCBMCharge);
            this.grpRoute.Controls.Add(this.label5);
            this.grpRoute.Controls.Add(this.txtRouteName);
            this.grpRoute.Controls.Add(this.label3);
            this.grpRoute.Controls.Add(this.txtRminCharge);
            this.grpRoute.Controls.Add(this.label2);
            this.grpRoute.Controls.Add(this.label1);
            this.grpRoute.Controls.Add(this.lstLocation);
            this.grpRoute.Controls.Add(this.txtRouteCode);
            this.grpRoute.Location = new System.Drawing.Point(12, 4);
            this.grpRoute.Name = "grpRoute";
            this.grpRoute.Size = new System.Drawing.Size(551, 127);
            this.grpRoute.TabIndex = 3;
            this.grpRoute.TabStop = false;
            this.grpRoute.Text = "Route Detail";
            // 
            // txtPerCBMCharge
            // 
            this.txtPerCBMCharge.Location = new System.Drawing.Point(116, 70);
            this.txtPerCBMCharge.Name = "txtPerCBMCharge";
            this.txtPerCBMCharge.Size = new System.Drawing.Size(78, 20);
            this.txtPerCBMCharge.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Per CBM Charge :";
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(116, 43);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(172, 20);
            this.txtRouteName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Route Name:";
            // 
            // txtRminCharge
            // 
            this.txtRminCharge.Location = new System.Drawing.Point(116, 98);
            this.txtRminCharge.Name = "txtRminCharge";
            this.txtRminCharge.Size = new System.Drawing.Size(78, 20);
            this.txtRminCharge.TabIndex = 4;
            this.txtRminCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRminCharge_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimum Charge:";
            // 
            // dgvRoute
            // 
            this.dgvRoute.AllowUserToAddRows = false;
            this.dgvRoute.AllowUserToDeleteRows = false;
            this.dgvRoute.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedBy,
            this.CreatedDate,
            this.ModifyBy,
            this.ModifyDate,
            this.Deleted,
            this.RouteNo,
            this.RouteCode,
            this.RouteName,
            this.RPerCBMCharge,
            this.RMinCharge});
            this.dgvRoute.Location = new System.Drawing.Point(23, 55);
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.ReadOnly = true;
            this.dgvRoute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRoute.Size = new System.Drawing.Size(504, 110);
            this.dgvRoute.TabIndex = 7;
            this.dgvRoute.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoute_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dgvRoute);
            this.groupBox1.Location = new System.Drawing.Point(15, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 178);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Route List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(65, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(126, 20);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(473, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(126, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(358, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(242, 325);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(15, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // RouteNo
            // 
            this.RouteNo.DataPropertyName = "RouteNo";
            this.RouteNo.HeaderText = "RouteNo";
            this.RouteNo.Name = "RouteNo";
            this.RouteNo.ReadOnly = true;
            this.RouteNo.Visible = false;
            // 
            // RouteCode
            // 
            this.RouteCode.DataPropertyName = "RouteCode";
            this.RouteCode.HeaderText = "Route Code";
            this.RouteCode.Name = "RouteCode";
            this.RouteCode.ReadOnly = true;
            // 
            // RouteName
            // 
            this.RouteName.DataPropertyName = "RouteName";
            this.RouteName.HeaderText = "RouteName";
            this.RouteName.Name = "RouteName";
            this.RouteName.ReadOnly = true;
            this.RouteName.Width = 180;
            // 
            // RPerCBMCharge
            // 
            this.RPerCBMCharge.DataPropertyName = "RPerCBMCharge";
            this.RPerCBMCharge.FillWeight = 50F;
            this.RPerCBMCharge.HeaderText = "PerCBMCharge";
            this.RPerCBMCharge.Name = "RPerCBMCharge";
            this.RPerCBMCharge.ReadOnly = true;
            // 
            // RMinCharge
            // 
            this.RMinCharge.DataPropertyName = "RMinCharge";
            this.RMinCharge.HeaderText = "Min. Charge";
            this.RMinCharge.Name = "RMinCharge";
            this.RMinCharge.ReadOnly = true;
            this.RMinCharge.Width = 130;
            // 
            // frmShipmentRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 367);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRoute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmShipmentRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipment Route";
            this.Load += new System.EventHandler(this.frmShipmentRoute_Load);
            this.grpRoute.ResumeLayout(false);
            this.grpRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRouteCode;
        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.GroupBox grpRoute;
        private System.Windows.Forms.TextBox txtRminCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRoute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPerCBMCharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPerCBMCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMinCharge;
    }
}