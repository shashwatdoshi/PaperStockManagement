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
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.grdCtrlDeleteOrder.UseEmbeddedNavigator = true;
            this.grdCtrlDeleteOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewDeleteOrder});
            // 
            // grdViewDeleteOrder
            // 
            this.grdViewDeleteOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClient,
            this.colClientID,
            this.colDeleted,
            this.colEndDate,
            this.colID,
            this.colQuantity,
            this.colStartDate,
            this.colStock,
            this.colStockID,
            this.colVehicle,
            this.colVehicleID});
            this.grdViewDeleteOrder.GridControl = this.grdCtrlDeleteOrder;
            this.grdViewDeleteOrder.Name = "grdViewDeleteOrder";
            // 
            // colClient
            // 
            this.colClient.FieldName = "Client";
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 0;
            // 
            // colClientID
            // 
            this.colClientID.FieldName = "ClientID";
            this.colClientID.Name = "colClientID";
            this.colClientID.Visible = true;
            this.colClientID.VisibleIndex = 1;
            // 
            // colDeleted
            // 
            this.colDeleted.FieldName = "Deleted";
            this.colDeleted.Name = "colDeleted";
            this.colDeleted.Visible = true;
            this.colDeleted.VisibleIndex = 2;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 3;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 4;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 6;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 7;
            // 
            // colStockID
            // 
            this.colStockID.FieldName = "StockID";
            this.colStockID.Name = "colStockID";
            this.colStockID.Visible = true;
            this.colStockID.VisibleIndex = 8;
            // 
            // colVehicle
            // 
            this.colVehicle.FieldName = "Vehicle";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.Visible = true;
            this.colVehicle.VisibleIndex = 9;
            // 
            // colVehicleID
            // 
            this.colVehicleID.FieldName = "VehicleID";
            this.colVehicleID.Name = "colVehicleID";
            this.colVehicleID.Visible = true;
            this.colVehicleID.VisibleIndex = 10;
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 482);
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
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colClientID;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colStockID;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleID;
    }
}