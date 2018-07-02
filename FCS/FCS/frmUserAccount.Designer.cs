namespace FCS
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpAcctDetails = new System.Windows.Forms.GroupBox();
            this.btnUADetail = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpRegistry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPrintRegistry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holiday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegReports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortBReports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealBReports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBReports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAccess_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpPermission = new System.Windows.Forms.GroupBox();
            this.trvPermission = new System.Windows.Forms.TreeView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAcctDetails.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.grpPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(126, 346);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(351, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(238, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(14, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpAcctDetails
            // 
            this.grpAcctDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpAcctDetails.Controls.Add(this.btnUADetail);
            this.grpAcctDetails.Controls.Add(this.txtUserName);
            this.grpAcctDetails.Controls.Add(this.label5);
            this.grpAcctDetails.Controls.Add(this.txtNewPass);
            this.grpAcctDetails.Controls.Add(this.label4);
            this.grpAcctDetails.Controls.Add(this.txtOldPass);
            this.grpAcctDetails.Controls.Add(this.Label1);
            this.grpAcctDetails.Location = new System.Drawing.Point(14, 23);
            this.grpAcctDetails.Name = "grpAcctDetails";
            this.grpAcctDetails.Size = new System.Drawing.Size(254, 122);
            this.grpAcctDetails.TabIndex = 35;
            this.grpAcctDetails.TabStop = false;
            this.grpAcctDetails.Text = "Account Details";
            // 
            // btnUADetail
            // 
            this.btnUADetail.Location = new System.Drawing.Point(6, -2);
            this.btnUADetail.Name = "btnUADetail";
            this.btnUADetail.Size = new System.Drawing.Size(86, 23);
            this.btnUADetail.TabIndex = 41;
            this.btnUADetail.Text = "Account Detail";
            this.btnUADetail.UseVisualStyleBackColor = true;
            this.btnUADetail.Click += new System.EventHandler(this.btnUADetail_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(123, 20);
            this.txtUserName.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "UserName:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(97, 87);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(122, 20);
            this.txtNewPass.TabIndex = 20;
            this.txtNewPass.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "New Password:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(97, 58);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(123, 20);
            this.txtOldPass.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Old Password:";
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.dgvAccount);
            this.grpSearch.Controls.Add(this.label6);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Location = new System.Drawing.Point(14, 158);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(254, 167);
            this.grpSearch.TabIndex = 38;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Account List";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Password,
            this.EmpRegistry,
            this.FPrintRegistry,
            this.Branch,
            this.Company,
            this.Department,
            this.Holiday,
            this.Location,
            this.TimeLimit,
            this.UserAccess,
            this.RegReports,
            this.ShortBReports,
            this.MealBReports,
            this.OBReports,
            this.Created_By,
            this.Date_Created,
            this.Modify_By,
            this.Date_Modify,
            this.Deleted,
            this.UserAccess_ID});
            this.dgvAccount.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAccount.Location = new System.Drawing.Point(28, 49);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 20;
            this.dgvAccount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAccount.Size = new System.Drawing.Size(192, 102);
            this.dgvAccount.TabIndex = 18;
            this.dgvAccount.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_RowHeaderMouseClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 250;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // EmpRegistry
            // 
            this.EmpRegistry.DataPropertyName = "EmpRegistry";
            this.EmpRegistry.HeaderText = "EmpRegistry";
            this.EmpRegistry.Name = "EmpRegistry";
            this.EmpRegistry.ReadOnly = true;
            this.EmpRegistry.Visible = false;
            // 
            // FPrintRegistry
            // 
            this.FPrintRegistry.DataPropertyName = "FPrintRegistry";
            this.FPrintRegistry.HeaderText = "FPrintRegistry";
            this.FPrintRegistry.Name = "FPrintRegistry";
            this.FPrintRegistry.ReadOnly = true;
            this.FPrintRegistry.Visible = false;
            // 
            // Branch
            // 
            this.Branch.DataPropertyName = "Branch";
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            this.Branch.Visible = false;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Visible = false;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Visible = false;
            // 
            // Holiday
            // 
            this.Holiday.DataPropertyName = "Holiday";
            this.Holiday.HeaderText = "Holiday";
            this.Holiday.Name = "Holiday";
            this.Holiday.ReadOnly = true;
            this.Holiday.Visible = false;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Visible = false;
            // 
            // TimeLimit
            // 
            this.TimeLimit.DataPropertyName = "TimeLimit";
            this.TimeLimit.HeaderText = "TimeLimit";
            this.TimeLimit.Name = "TimeLimit";
            this.TimeLimit.ReadOnly = true;
            this.TimeLimit.Visible = false;
            // 
            // UserAccess
            // 
            this.UserAccess.DataPropertyName = "UserAccess";
            this.UserAccess.HeaderText = "UserAccess";
            this.UserAccess.Name = "UserAccess";
            this.UserAccess.ReadOnly = true;
            this.UserAccess.Visible = false;
            // 
            // RegReports
            // 
            this.RegReports.DataPropertyName = "RegReports";
            this.RegReports.HeaderText = "RegReports";
            this.RegReports.Name = "RegReports";
            this.RegReports.ReadOnly = true;
            this.RegReports.Visible = false;
            // 
            // ShortBReports
            // 
            this.ShortBReports.DataPropertyName = "ShortBReports";
            this.ShortBReports.HeaderText = "ShortBReports";
            this.ShortBReports.Name = "ShortBReports";
            this.ShortBReports.ReadOnly = true;
            this.ShortBReports.Visible = false;
            // 
            // MealBReports
            // 
            this.MealBReports.DataPropertyName = "MealBReports";
            this.MealBReports.HeaderText = "MealBReports";
            this.MealBReports.Name = "MealBReports";
            this.MealBReports.ReadOnly = true;
            this.MealBReports.Visible = false;
            // 
            // OBReports
            // 
            this.OBReports.DataPropertyName = "OBReports";
            this.OBReports.HeaderText = "OBReports";
            this.OBReports.Name = "OBReports";
            this.OBReports.ReadOnly = true;
            this.OBReports.Visible = false;
            // 
            // Created_By
            // 
            this.Created_By.DataPropertyName = "Created_By";
            this.Created_By.HeaderText = "Created_By";
            this.Created_By.Name = "Created_By";
            this.Created_By.ReadOnly = true;
            this.Created_By.Visible = false;
            // 
            // Date_Created
            // 
            this.Date_Created.DataPropertyName = "Date_Created";
            this.Date_Created.HeaderText = "Date_Created";
            this.Date_Created.Name = "Date_Created";
            this.Date_Created.ReadOnly = true;
            this.Date_Created.Visible = false;
            // 
            // Modify_By
            // 
            this.Modify_By.DataPropertyName = "Modify_By";
            this.Modify_By.HeaderText = "Modify_By";
            this.Modify_By.Name = "Modify_By";
            this.Modify_By.ReadOnly = true;
            this.Modify_By.Visible = false;
            // 
            // Date_Modify
            // 
            this.Date_Modify.DataPropertyName = "Date_Modify";
            this.Date_Modify.HeaderText = "Date_Modify";
            this.Date_Modify.Name = "Date_Modify";
            this.Date_Modify.ReadOnly = true;
            this.Date_Modify.Visible = false;
            // 
            // Deleted
            // 
            this.Deleted.DataPropertyName = "Deleted";
            this.Deleted.HeaderText = "Deleted";
            this.Deleted.Name = "Deleted";
            this.Deleted.ReadOnly = true;
            this.Deleted.Visible = false;
            // 
            // UserAccess_ID
            // 
            this.UserAccess_ID.DataPropertyName = "UserAccess_ID";
            this.UserAccess_ID.HeaderText = "UserAccess_ID";
            this.UserAccess_ID.Name = "UserAccess_ID";
            this.UserAccess_ID.ReadOnly = true;
            this.UserAccess_ID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(82, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpPermission
            // 
            this.grpPermission.BackColor = System.Drawing.Color.Transparent;
            this.grpPermission.Controls.Add(this.trvPermission);
            this.grpPermission.Location = new System.Drawing.Point(298, 23);
            this.grpPermission.Name = "grpPermission";
            this.grpPermission.Size = new System.Drawing.Size(259, 302);
            this.grpPermission.TabIndex = 39;
            this.grpPermission.TabStop = false;
            this.grpPermission.Text = "Permission Access";
            // 
            // trvPermission
            // 
            this.trvPermission.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trvPermission.CheckBoxes = true;
            this.trvPermission.Location = new System.Drawing.Point(21, 32);
            this.trvPermission.Name = "trvPermission";
            this.trvPermission.Size = new System.Drawing.Size(220, 254);
            this.trvPermission.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(462, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 30);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 387);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpPermission);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpAcctDetails);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAccount";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.grpAcctDetails.ResumeLayout(false);
            this.grpAcctDetails.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.grpPermission.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.GroupBox grpAcctDetails;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtNewPass;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtOldPass;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox grpSearch;
        internal System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpRegistry;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPrintRegistry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Holiday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortBReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealBReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modify_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAccess_ID;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.GroupBox grpPermission;
        private System.Windows.Forms.TreeView trvPermission;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUADetail;
    }
}