namespace ProjectStockManagement
{
    partial class AddPartyDetail
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
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.txtContactNo = new System.Windows.Forms.MaskedTextBox();
            this.lblContactNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.addPartyDetails = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCanclePartyDetail = new MaterialSkin.Controls.MaterialFlatButton();
            this.grdCtrlAddParty = new DevExpress.XtraGrid.GridControl();
            this.grdViewAddParty = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlAddParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAddParty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BeepOnError = true;
            this.txtName.Location = new System.Drawing.Point(167, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtContactNo
            // 
            this.txtContactNo.BeepOnError = true;
            this.txtContactNo.Location = new System.Drawing.Point(167, 78);
            this.txtContactNo.Mask = "0000000000";
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(249, 20);
            this.txtContactNo.TabIndex = 3;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Depth = 0;
            this.lblContactNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContactNo.Location = new System.Drawing.Point(30, 79);
            this.lblContactNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(90, 19);
            this.lblContactNo.TabIndex = 2;
            this.lblContactNo.Text = "Contact No:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(30, 133);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 19);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 133);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 50);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.BeepOnError = true;
            this.txtEmail.Location = new System.Drawing.Point(167, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(30, 222);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 19);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // addPartyDetails
            // 
            this.addPartyDetails.AutoSize = true;
            this.addPartyDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPartyDetails.Depth = 0;
            this.addPartyDetails.Location = new System.Drawing.Point(34, 288);
            this.addPartyDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addPartyDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.addPartyDetails.Name = "addPartyDetails";
            this.addPartyDetails.Primary = false;
            this.addPartyDetails.Size = new System.Drawing.Size(135, 36);
            this.addPartyDetails.TabIndex = 8;
            this.addPartyDetails.Text = "ADD PARTY DETAIL";
            this.addPartyDetails.UseVisualStyleBackColor = true;
            this.addPartyDetails.Click += new System.EventHandler(this.addPartyDetails_Click);
            // 
            // btnCanclePartyDetail
            // 
            this.btnCanclePartyDetail.AutoSize = true;
            this.btnCanclePartyDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCanclePartyDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCanclePartyDetail.Depth = 0;
            this.btnCanclePartyDetail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanclePartyDetail.Location = new System.Drawing.Point(242, 288);
            this.btnCanclePartyDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCanclePartyDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCanclePartyDetail.Name = "btnCanclePartyDetail";
            this.btnCanclePartyDetail.Primary = false;
            this.btnCanclePartyDetail.Size = new System.Drawing.Size(64, 36);
            this.btnCanclePartyDetail.TabIndex = 9;
            this.btnCanclePartyDetail.Text = "CANCLE";
            this.btnCanclePartyDetail.UseVisualStyleBackColor = true;
            this.btnCanclePartyDetail.Click += new System.EventHandler(this.btnCanclePartyDetail_Click);
            // 
            // grdCtrlAddParty
            // 
            this.grdCtrlAddParty.DataSource = typeof(ProjectStockManagement.PaperStockManagementDB.Client);
            this.grdCtrlAddParty.Location = new System.Drawing.Point(34, 334);
            this.grdCtrlAddParty.MainView = this.grdViewAddParty;
            this.grdCtrlAddParty.Name = "grdCtrlAddParty";
            this.grdCtrlAddParty.Size = new System.Drawing.Size(400, 200);
            this.grdCtrlAddParty.TabIndex = 10;
            this.grdCtrlAddParty.UseEmbeddedNavigator = true;
            this.grdCtrlAddParty.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewAddParty});
            // 
            // grdViewAddParty
            // 
            this.grdViewAddParty.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colContact,
            this.colAddress,
            this.colEmail});
            this.grdViewAddParty.GridControl = this.grdCtrlAddParty;
            this.grdViewAddParty.Name = "grdViewAddParty";
            this.grdViewAddParty.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.grdViewAddParty_RowDeleted);
            this.grdViewAddParty.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grdViewAddParty_RowUpdated);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colContact
            // 
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // AddPartyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.grdCtrlAddParty);
            this.Controls.Add(this.btnCanclePartyDetail);
            this.Controls.Add(this.addPartyDetails);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximumSize = new System.Drawing.Size(600, 700);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "AddPartyDetail";
            this.Text = "Add Party Details";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartyDetail_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlAddParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAddParty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblName;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtContactNo;
        private MaterialSkin.Controls.MaterialLabel lblContactNo;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialFlatButton addPartyDetails;
        private MaterialSkin.Controls.MaterialFlatButton btnCanclePartyDetail;
        private DevExpress.XtraGrid.GridControl grdCtrlAddParty;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewAddParty;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
    }
}