namespace ProjectStockManagement
{
    partial class DeleteOrder
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
            this.grdCtrlDeleteOrder = new DevExpress.XtraGrid.GridControl();
            this.grdViewDeleteOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Size = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GSM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BreakingForce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Weight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlDeleteOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDeleteOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrlDeleteOrder
            // 
            this.grdCtrlDeleteOrder.DataSource = typeof(ProjectStockManagement.PaperStockManagementDB.Order);
            this.grdCtrlDeleteOrder.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.grdCtrlDeleteOrder.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdCtrlDeleteOrder.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.grdCtrlDeleteOrder.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdCtrlDeleteOrder.EmbeddedNavigator.ToolTip = "Orders";
            this.grdCtrlDeleteOrder.Location = new System.Drawing.Point(12, 12);
            this.grdCtrlDeleteOrder.MainView = this.grdViewDeleteOrder;
            this.grdCtrlDeleteOrder.Name = "grdCtrlDeleteOrder";
            this.grdCtrlDeleteOrder.Size = new System.Drawing.Size(850, 460);
            this.grdCtrlDeleteOrder.TabIndex = 0;
            this.grdCtrlDeleteOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewDeleteOrder});
            // 
            // grdViewDeleteOrder
            // 
            this.grdViewDeleteOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClientName,
            this.Size,
            this.GSM,
            this.BreakingForce,
            this.ClientID,
            this.StockID,
            this.Weight,
            this.Quantity,
            this.AddedDate,
            this.ID});
            this.grdViewDeleteOrder.GridControl = this.grdCtrlDeleteOrder;
            this.grdViewDeleteOrder.Name = "grdViewDeleteOrder";
            this.grdViewDeleteOrder.OptionsSelection.MultiSelect = true;
            this.grdViewDeleteOrder.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // ClientName
            // 
            this.ClientName.Caption = "ClientName";
            this.ClientName.FieldName = "Client.Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.OptionsColumn.AllowEdit = false;
            this.ClientName.Visible = true;
            this.ClientName.VisibleIndex = 4;
            // 
            // Size
            // 
            this.Size.Caption = "Size";
            this.Size.FieldName = "Stock.Size";
            this.Size.Name = "Size";
            this.Size.OptionsColumn.AllowEdit = false;
            this.Size.Visible = true;
            this.Size.VisibleIndex = 2;
            // 
            // GSM
            // 
            this.GSM.Caption = "GSM";
            this.GSM.FieldName = "Stock.GSM";
            this.GSM.Name = "GSM";
            this.GSM.OptionsColumn.AllowEdit = false;
            this.GSM.Visible = true;
            this.GSM.VisibleIndex = 3;
            // 
            // BreakingForce
            // 
            this.BreakingForce.Caption = "BreakingForce";
            this.BreakingForce.FieldName = "Stock.BreakingForce";
            this.BreakingForce.Name = "BreakingForce";
            this.BreakingForce.OptionsColumn.AllowEdit = false;
            this.BreakingForce.Visible = true;
            this.BreakingForce.VisibleIndex = 1;
            // 
            // ClientID
            // 
            this.ClientID.Caption = "ClientID";
            this.ClientID.FieldName = "ClientID";
            this.ClientID.Name = "ClientID";
            this.ClientID.OptionsColumn.AllowEdit = false;
            // 
            // StockID
            // 
            this.StockID.Caption = "StockID";
            this.StockID.FieldName = "StockID";
            this.StockID.Name = "StockID";
            this.StockID.OptionsColumn.AllowEdit = false;
            this.StockID.Visible = true;
            this.StockID.VisibleIndex = 5;
            // 
            // Weight
            // 
            this.Weight.Caption = "Weight";
            this.Weight.FieldName = "Stock.Weight";
            this.Weight.Name = "Weight";
            this.Weight.OptionsColumn.AllowEdit = false;
            this.Weight.Visible = true;
            this.Weight.VisibleIndex = 6;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.AllowEdit = false;
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 7;
            // 
            // AddedDate
            // 
            this.AddedDate.Caption = "AddedDate";
            this.AddedDate.FieldName = "AddedDate";
            this.AddedDate.Name = "AddedDate";
            this.AddedDate.OptionsColumn.AllowEdit = false;
            this.AddedDate.Visible = true;
            this.AddedDate.VisibleIndex = 8;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdCtrlDeleteOrder);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "DeleteOrder";
            this.Text = "DeleteOrder";
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlDeleteOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDeleteOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlDeleteOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewDeleteOrder;
        private DevExpress.XtraGrid.Columns.GridColumn ClientName;
        private DevExpress.XtraGrid.Columns.GridColumn Size;
        private DevExpress.XtraGrid.Columns.GridColumn GSM;
        private DevExpress.XtraGrid.Columns.GridColumn BreakingForce;
        private DevExpress.XtraGrid.Columns.GridColumn ClientID;
        private DevExpress.XtraGrid.Columns.GridColumn StockID;
        private DevExpress.XtraGrid.Columns.GridColumn Weight;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn AddedDate;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}