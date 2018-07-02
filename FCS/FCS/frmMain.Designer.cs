namespace FCS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnLocation = new System.Windows.Forms.ToolStripButton();
            this.btnShipmentR = new System.Windows.Forms.ToolStripButton();
            this.btnItemSet = new System.Windows.Forms.ToolStripButton();
            this.btnFreightSet = new System.Windows.Forms.ToolStripButton();
            this.btnProforma = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShimpentRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSupplierFreight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTranWayBill = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOther = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUserAccount = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnLocation,
            this.btnShipmentR,
            this.btnItemSet,
            this.btnFreightSet,
            this.btnProforma,
            this.btnOther,
            this.btnUserAccount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 55);
            this.btnNew.Text = "New Freight Charge";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.AutoSize = false;
            this.btnLocation.BackColor = System.Drawing.Color.Transparent;
            this.btnLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnLocation.Image")));
            this.btnLocation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(50, 55);
            this.btnLocation.Text = "Location";
            this.btnLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnShipmentR
            // 
            this.btnShipmentR.AutoSize = false;
            this.btnShipmentR.BackColor = System.Drawing.Color.Transparent;
            this.btnShipmentR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShipmentR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShipmentR.Image = ((System.Drawing.Image)(resources.GetObject("btnShipmentR.Image")));
            this.btnShipmentR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShipmentR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShipmentR.Name = "btnShipmentR";
            this.btnShipmentR.Size = new System.Drawing.Size(50, 55);
            this.btnShipmentR.Text = "Shipment Route";
            this.btnShipmentR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShipmentR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShipmentR.Click += new System.EventHandler(this.btnShipmentR_Click);
            // 
            // btnItemSet
            // 
            this.btnItemSet.AutoSize = false;
            this.btnItemSet.BackColor = System.Drawing.Color.Transparent;
            this.btnItemSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnItemSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItemSet.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSet.Image")));
            this.btnItemSet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnItemSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemSet.Name = "btnItemSet";
            this.btnItemSet.Size = new System.Drawing.Size(50, 55);
            this.btnItemSet.Text = "Item";
            this.btnItemSet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItemSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnItemSet.Click += new System.EventHandler(this.btnItemSet_Click);
            // 
            // btnFreightSet
            // 
            this.btnFreightSet.AutoSize = false;
            this.btnFreightSet.BackColor = System.Drawing.Color.Transparent;
            this.btnFreightSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFreightSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFreightSet.Image = ((System.Drawing.Image)(resources.GetObject("btnFreightSet.Image")));
            this.btnFreightSet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFreightSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFreightSet.Name = "btnFreightSet";
            this.btnFreightSet.Size = new System.Drawing.Size(50, 55);
            this.btnFreightSet.Text = "Box Set";
            this.btnFreightSet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFreightSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFreightSet.Click += new System.EventHandler(this.btnFreightSet_Click);
            // 
            // btnProforma
            // 
            this.btnProforma.BackColor = System.Drawing.Color.Transparent;
            this.btnProforma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProforma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProforma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBox,
            this.tsmShimpentRoute,
            this.tsmSupplierFreight,
            this.tsmTranWayBill});
            this.btnProforma.Image = ((System.Drawing.Image)(resources.GetObject("btnProforma.Image")));
            this.btnProforma.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProforma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProforma.Name = "btnProforma";
            this.btnProforma.Size = new System.Drawing.Size(50, 55);
            this.btnProforma.Text = "Proforma";
            this.btnProforma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProforma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmBox
            // 
            this.tsmBox.Name = "tsmBox";
            this.tsmBox.Size = new System.Drawing.Size(178, 22);
            this.tsmBox.Text = "Box";
            this.tsmBox.Click += new System.EventHandler(this.tsmBox_Click);
            // 
            // tsmShimpentRoute
            // 
            this.tsmShimpentRoute.Name = "tsmShimpentRoute";
            this.tsmShimpentRoute.Size = new System.Drawing.Size(178, 22);
            this.tsmShimpentRoute.Text = "Shipment Route";
            this.tsmShimpentRoute.Click += new System.EventHandler(this.tsmShimpentRoute_Click);
            // 
            // tsmSupplierFreight
            // 
            this.tsmSupplierFreight.Name = "tsmSupplierFreight";
            this.tsmSupplierFreight.Size = new System.Drawing.Size(178, 22);
            this.tsmSupplierFreight.Text = "Supplier Freight";
            this.tsmSupplierFreight.Click += new System.EventHandler(this.tsmSupplierFreight_Click);
            // 
            // tsmTranWayBill
            // 
            this.tsmTranWayBill.Name = "tsmTranWayBill";
            this.tsmTranWayBill.Size = new System.Drawing.Size(178, 22);
            this.tsmTranWayBill.Text = "Transaction Waybill";
            this.tsmTranWayBill.Click += new System.EventHandler(this.tsmTranWayBill_Click);
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.Color.Transparent;
            this.btnOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOther.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.btnOther.Image = ((System.Drawing.Image)(resources.GetObject("btnOther.Image")));
            this.btnOther.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOther.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(50, 55);
            this.btnOther.Text = "Other";
            this.btnOther.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem1.Text = "Upload Item";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.AutoSize = false;
            this.btnUserAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnUserAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUserAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUserAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccount.Image")));
            this.btnUserAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUserAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.Size = new System.Drawing.Size(50, 55);
            this.btnUserAccount.Text = "User Account";
            this.btnUserAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserAccount.Click += new System.EventHandler(this.btnUserAccount_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enigma Technologies Inc : All Rights Reserved @ 2017";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnShipmentR;
        private System.Windows.Forms.ToolStripButton btnItemSet;
        private System.Windows.Forms.ToolStripButton btnUserAccount;
        private System.Windows.Forms.ToolStripButton btnFreightSet;
        private System.Windows.Forms.ToolStripButton btnLocation;
        private System.Windows.Forms.ToolStripDropDownButton btnProforma;
        private System.Windows.Forms.ToolStripMenuItem tsmTranWayBill;
        private System.Windows.Forms.ToolStripDropDownButton btnOther;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmSupplierFreight;
        private System.Windows.Forms.ToolStripMenuItem tsmBox;
        private System.Windows.Forms.ToolStripMenuItem tsmShimpentRoute;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
    }
}

