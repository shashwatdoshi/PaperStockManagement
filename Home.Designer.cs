﻿namespace ProjectStockManagement
{
    partial class PaperStockManagement
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainNavigation = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.addStockNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txtStockQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbGSM = new System.Windows.Forms.ComboBox();
            this.cmbBF = new System.Windows.Forms.ComboBox();
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtWeight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSize = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addOrderNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GSM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Size = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Weight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbAddOrderDetail = new System.Windows.Forms.ComboBox();
            this.cmbAddOrderPartyName = new System.Windows.Forms.ComboBox();
            this.btnCancelOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSaveOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblOrderDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpStockDate = new System.Windows.Forms.DateTimePicker();
            this.dispatchNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txtDriverContactNo = new System.Windows.Forms.MaskedTextBox();
            this.txtDriverName = new System.Windows.Forms.MaskedTextBox();
            this.cmbVehicleInfo = new System.Windows.Forms.ComboBox();
            this.grpManualDispatch = new DevExpress.XtraEditors.GroupControl();
            this.txtManualDispatchQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbManualDispatchGSM = new System.Windows.Forms.ComboBox();
            this.cmbManualDispatchBF = new System.Windows.Forms.ComboBox();
            this.txtManualDispatchWeight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtManualDispatchSize = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rdbManualDispatch = new MaterialSkin.Controls.MaterialRadioButton();
            this.grpAutoDispatch = new DevExpress.XtraEditors.GroupControl();
            this.rdbDispatch = new MaterialSkin.Controls.MaterialRadioButton();
            this.cmbPartyName = new System.Windows.Forms.ComboBox();
            this.txtDispatchSize = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbSelectOrder = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportsNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnPrintReport = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnShowDispatchedOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnShowAddedProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbReportPartyName = new System.Windows.Forms.ComboBox();
            this.cmbReportGSM = new System.Windows.Forms.ComboBox();
            this.cmbReportBF = new System.Windows.Forms.ComboBox();
            this.txtReportWeight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtReportSize = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblToDate = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.homeNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnAddParty = new System.Windows.Forms.Button();
            this.btnAddGSM = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnAddGF = new System.Windows.Forms.Button();
            this.dlgPrintReport = new System.Windows.Forms.PrintDialog();
            this.toolTipAddOrder = new System.Windows.Forms.ToolTip(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigation)).BeginInit();
            this.mainNavigation.SuspendLayout();
            this.addStockNavigationPage.SuspendLayout();
            this.addOrderNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.dispatchNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpManualDispatch)).BeginInit();
            this.grpManualDispatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAutoDispatch)).BeginInit();
            this.grpAutoDispatch.SuspendLayout();
            this.reportsNavigationPage.SuspendLayout();
            this.homeNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainNavigation
            // 
            this.mainNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainNavigation.Controls.Add(this.addStockNavigationPage);
            this.mainNavigation.Controls.Add(this.addOrderNavigationPage);
            this.mainNavigation.Controls.Add(this.dispatchNavigationPage);
            this.mainNavigation.Controls.Add(this.reportsNavigationPage);
            this.mainNavigation.Controls.Add(this.homeNavigationPage);
            this.mainNavigation.Location = new System.Drawing.Point(1, 66);
            this.mainNavigation.Name = "mainNavigation";
            this.mainNavigation.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.homeNavigationPage,
            this.addStockNavigationPage,
            this.addOrderNavigationPage,
            this.dispatchNavigationPage,
            this.reportsNavigationPage});
            this.mainNavigation.RegularSize = new System.Drawing.Size(797, 382);
            this.mainNavigation.SelectedPage = this.homeNavigationPage;
            this.mainNavigation.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.mainNavigation.Size = new System.Drawing.Size(797, 382);
            this.mainNavigation.TabIndex = 1;
            this.mainNavigation.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.mainNavigation_SelectedPageChanging);
            // 
            // addStockNavigationPage
            // 
            this.addStockNavigationPage.Caption = "Add Stock";
            this.addStockNavigationPage.Controls.Add(this.txtStockQuantity);
            this.addStockNavigationPage.Controls.Add(this.cmbGSM);
            this.addStockNavigationPage.Controls.Add(this.cmbBF);
            this.addStockNavigationPage.Controls.Add(this.btnReset);
            this.addStockNavigationPage.Controls.Add(this.btnCancle);
            this.addStockNavigationPage.Controls.Add(this.btnSave);
            this.addStockNavigationPage.Controls.Add(this.txtWeight);
            this.addStockNavigationPage.Controls.Add(this.txtSize);
            this.addStockNavigationPage.Controls.Add(this.lblDate);
            this.addStockNavigationPage.Controls.Add(this.dateTimePicker1);
            this.addStockNavigationPage.Name = "addStockNavigationPage";
            this.addStockNavigationPage.Size = new System.Drawing.Size(670, 309);
            this.addStockNavigationPage.ToolTip = "Add Stock";
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Depth = 0;
            this.txtStockQuantity.Hint = "QUANTITY";
            this.txtStockQuantity.Location = new System.Drawing.Point(562, 73);
            this.txtStockQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.PasswordChar = '\0';
            this.txtStockQuantity.SelectedText = "";
            this.txtStockQuantity.SelectionLength = 0;
            this.txtStockQuantity.SelectionStart = 0;
            this.txtStockQuantity.Size = new System.Drawing.Size(75, 23);
            this.txtStockQuantity.TabIndex = 6;
            this.txtStockQuantity.UseSystemPasswordChar = false;
            // 
            // cmbGSM
            // 
            this.cmbGSM.DisplayMember = "10";
            this.cmbGSM.FormattingEnabled = true;
            this.cmbGSM.Location = new System.Drawing.Point(167, 70);
            this.cmbGSM.Name = "cmbGSM";
            this.cmbGSM.Size = new System.Drawing.Size(100, 21);
            this.cmbGSM.TabIndex = 3;
            this.cmbGSM.Text = "GSM";
            this.cmbGSM.ValueMember = "10,12,15,20";
            // 
            // cmbBF
            // 
            this.cmbBF.DisplayMember = "10";
            this.cmbBF.FormattingEnabled = true;
            this.cmbBF.Location = new System.Drawing.Point(19, 70);
            this.cmbBF.Name = "cmbBF";
            this.cmbBF.Size = new System.Drawing.Size(100, 21);
            this.cmbBF.TabIndex = 2;
            this.cmbBF.Text = "BF";
            // 
            // btnReset
            // 
            this.btnReset.Depth = 0;
            this.btnReset.FlatAppearance.BorderSize = 5;
            this.btnReset.Location = new System.Drawing.Point(400, 141);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(89, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Depth = 0;
            this.btnCancle.Location = new System.Drawing.Point(226, 141);
            this.btnCancle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Primary = true;
            this.btnCancle.Size = new System.Drawing.Size(89, 40);
            this.btnCancle.TabIndex = 8;
            this.btnCancle.Text = "CANCEL";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(57, 141);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(89, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Depth = 0;
            this.txtWeight.Hint = "WEIGHT";
            this.txtWeight.Location = new System.Drawing.Point(450, 73);
            this.txtWeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.SelectedText = "";
            this.txtWeight.SelectionLength = 0;
            this.txtWeight.SelectionStart = 0;
            this.txtWeight.Size = new System.Drawing.Size(75, 23);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.UseSystemPasswordChar = false;
            // 
            // txtSize
            // 
            this.txtSize.Depth = 0;
            this.txtSize.Hint = "SIZE";
            this.txtSize.Location = new System.Drawing.Point(324, 73);
            this.txtSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.SelectedText = "";
            this.txtSize.SelectionLength = 0;
            this.txtSize.SelectionStart = 0;
            this.txtSize.Size = new System.Drawing.Size(75, 23);
            this.txtSize.TabIndex = 4;
            this.txtSize.UseSystemPasswordChar = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(396, 9);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 19);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(450, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // addOrderNavigationPage
            // 
            this.addOrderNavigationPage.AutoSize = true;
            this.addOrderNavigationPage.Caption = "Add Order";
            this.addOrderNavigationPage.Controls.Add(this.gridControl1);
            this.addOrderNavigationPage.Controls.Add(this.cmbAddOrderDetail);
            this.addOrderNavigationPage.Controls.Add(this.cmbAddOrderPartyName);
            this.addOrderNavigationPage.Controls.Add(this.btnCancelOrder);
            this.addOrderNavigationPage.Controls.Add(this.btnSaveOrder);
            this.addOrderNavigationPage.Controls.Add(this.btnAddOrder);
            this.addOrderNavigationPage.Controls.Add(this.lblOrderDate);
            this.addOrderNavigationPage.Controls.Add(this.dtpStockDate);
            this.addOrderNavigationPage.Name = "addOrderNavigationPage";
            this.addOrderNavigationPage.Size = new System.Drawing.Size(670, 373);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(23, 170);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Client,
            this.BF,
            this.GSM,
            this.Size,
            this.Weight,
            this.Quantity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // Client
            // 
            this.Client.Caption = "Client";
            this.Client.Name = "Client";
            this.Client.Visible = true;
            this.Client.VisibleIndex = 0;
            // 
            // BF
            // 
            this.BF.Caption = "BF";
            this.BF.Name = "BF";
            this.BF.Visible = true;
            this.BF.VisibleIndex = 1;
            // 
            // GSM
            // 
            this.GSM.Caption = "GSM";
            this.GSM.Name = "GSM";
            this.GSM.Visible = true;
            this.GSM.VisibleIndex = 2;
            // 
            // Size
            // 
            this.Size.Caption = "Size";
            this.Size.Name = "Size";
            this.Size.Visible = true;
            this.Size.VisibleIndex = 3;
            // 
            // Weight
            // 
            this.Weight.Caption = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.Visible = true;
            this.Weight.VisibleIndex = 4;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 5;
            // 
            // cmbAddOrderDetail
            // 
            this.cmbAddOrderDetail.FormattingEnabled = true;
            this.cmbAddOrderDetail.Location = new System.Drawing.Point(216, 55);
            this.cmbAddOrderDetail.Name = "cmbAddOrderDetail";
            this.cmbAddOrderDetail.Size = new System.Drawing.Size(276, 21);
            this.cmbAddOrderDetail.TabIndex = 11;
            this.cmbAddOrderDetail.Text = "BF | GSM | SIZE | WEIGHT | QUANTITY";
            // 
            // cmbAddOrderPartyName
            // 
            this.cmbAddOrderPartyName.FormattingEnabled = true;
            this.cmbAddOrderPartyName.Location = new System.Drawing.Point(23, 55);
            this.cmbAddOrderPartyName.Name = "cmbAddOrderPartyName";
            this.cmbAddOrderPartyName.Size = new System.Drawing.Size(121, 21);
            this.cmbAddOrderPartyName.TabIndex = 10;
            this.cmbAddOrderPartyName.Text = "Party Name";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Depth = 0;
            this.btnCancelOrder.Location = new System.Drawing.Point(488, 113);
            this.btnCancelOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Primary = true;
            this.btnCancelOrder.Size = new System.Drawing.Size(89, 40);
            this.btnCancelOrder.TabIndex = 9;
            this.btnCancelOrder.Text = "CANCEL";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Depth = 0;
            this.btnSaveOrder.Location = new System.Drawing.Point(248, 113);
            this.btnSaveOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Primary = true;
            this.btnSaveOrder.Size = new System.Drawing.Size(89, 40);
            this.btnSaveOrder.TabIndex = 8;
            this.btnSaveOrder.Text = "SAVE";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Depth = 0;
            this.btnAddOrder.Location = new System.Drawing.Point(23, 113);
            this.btnAddOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Primary = true;
            this.btnAddOrder.Size = new System.Drawing.Size(89, 40);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "ADD";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Depth = 0;
            this.lblOrderDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderDate.Location = new System.Drawing.Point(400, 9);
            this.lblOrderDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(48, 19);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "Date :";
            // 
            // dtpStockDate
            // 
            this.dtpStockDate.Location = new System.Drawing.Point(454, 9);
            this.dtpStockDate.Name = "dtpStockDate";
            this.dtpStockDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStockDate.TabIndex = 2;
            // 
            // dispatchNavigationPage
            // 
            this.dispatchNavigationPage.Caption = "Dispatch Order";
            this.dispatchNavigationPage.Controls.Add(this.txtDriverContactNo);
            this.dispatchNavigationPage.Controls.Add(this.txtDriverName);
            this.dispatchNavigationPage.Controls.Add(this.cmbVehicleInfo);
            this.dispatchNavigationPage.Controls.Add(this.grpManualDispatch);
            this.dispatchNavigationPage.Controls.Add(this.grpAutoDispatch);
            this.dispatchNavigationPage.Controls.Add(this.materialLabel1);
            this.dispatchNavigationPage.Controls.Add(this.dateTimePicker2);
            this.dispatchNavigationPage.Name = "dispatchNavigationPage";
            this.dispatchNavigationPage.Size = new System.Drawing.Size(670, 309);
            // 
            // txtDriverContactNo
            // 
            this.txtDriverContactNo.BeepOnError = true;
            this.txtDriverContactNo.Location = new System.Drawing.Point(303, 275);
            this.txtDriverContactNo.Mask = "+91 00000-00000";
            this.txtDriverContactNo.Name = "txtDriverContactNo";
            this.txtDriverContactNo.Size = new System.Drawing.Size(104, 20);
            this.txtDriverContactNo.TabIndex = 12;
            // 
            // txtDriverName
            // 
            this.txtDriverName.BeepOnError = true;
            this.txtDriverName.Location = new System.Drawing.Point(144, 275);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(131, 20);
            this.txtDriverName.TabIndex = 11;
            // 
            // cmbVehicleInfo
            // 
            this.cmbVehicleInfo.DisplayMember = "10";
            this.cmbVehicleInfo.FormattingEnabled = true;
            this.cmbVehicleInfo.Location = new System.Drawing.Point(17, 275);
            this.cmbVehicleInfo.Name = "cmbVehicleInfo";
            this.cmbVehicleInfo.Size = new System.Drawing.Size(100, 21);
            this.cmbVehicleInfo.TabIndex = 10;
            this.cmbVehicleInfo.Text = "Vehicle Detail";
            // 
            // grpManualDispatch
            // 
            this.grpManualDispatch.Controls.Add(this.txtManualDispatchQuantity);
            this.grpManualDispatch.Controls.Add(this.cmbManualDispatchGSM);
            this.grpManualDispatch.Controls.Add(this.cmbManualDispatchBF);
            this.grpManualDispatch.Controls.Add(this.txtManualDispatchWeight);
            this.grpManualDispatch.Controls.Add(this.txtManualDispatchSize);
            this.grpManualDispatch.Controls.Add(this.rdbManualDispatch);
            this.grpManualDispatch.Location = new System.Drawing.Point(17, 155);
            this.grpManualDispatch.Name = "grpManualDispatch";
            this.grpManualDispatch.ShowCaption = false;
            this.grpManualDispatch.Size = new System.Drawing.Size(650, 100);
            this.grpManualDispatch.TabIndex = 10;
            this.grpManualDispatch.Text = "Manual Dispatch";
            // 
            // txtManualDispatchQuantity
            // 
            this.txtManualDispatchQuantity.Depth = 0;
            this.txtManualDispatchQuantity.Hint = "QUANTITY";
            this.txtManualDispatchQuantity.Location = new System.Drawing.Point(556, 56);
            this.txtManualDispatchQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtManualDispatchQuantity.Name = "txtManualDispatchQuantity";
            this.txtManualDispatchQuantity.PasswordChar = '\0';
            this.txtManualDispatchQuantity.SelectedText = "";
            this.txtManualDispatchQuantity.SelectionLength = 0;
            this.txtManualDispatchQuantity.SelectionStart = 0;
            this.txtManualDispatchQuantity.Size = new System.Drawing.Size(75, 23);
            this.txtManualDispatchQuantity.TabIndex = 10;
            this.txtManualDispatchQuantity.UseSystemPasswordChar = false;
            // 
            // cmbManualDispatchGSM
            // 
            this.cmbManualDispatchGSM.DisplayMember = "10";
            this.cmbManualDispatchGSM.FormattingEnabled = true;
            this.cmbManualDispatchGSM.Location = new System.Drawing.Point(158, 53);
            this.cmbManualDispatchGSM.Name = "cmbManualDispatchGSM";
            this.cmbManualDispatchGSM.Size = new System.Drawing.Size(100, 21);
            this.cmbManualDispatchGSM.TabIndex = 7;
            this.cmbManualDispatchGSM.Text = "GSM";
            this.cmbManualDispatchGSM.ValueMember = "10,12,15,20";
            // 
            // cmbManualDispatchBF
            // 
            this.cmbManualDispatchBF.DisplayMember = "10";
            this.cmbManualDispatchBF.FormattingEnabled = true;
            this.cmbManualDispatchBF.Location = new System.Drawing.Point(10, 53);
            this.cmbManualDispatchBF.Name = "cmbManualDispatchBF";
            this.cmbManualDispatchBF.Size = new System.Drawing.Size(100, 21);
            this.cmbManualDispatchBF.TabIndex = 6;
            this.cmbManualDispatchBF.Text = "BF";
            // 
            // txtManualDispatchWeight
            // 
            this.txtManualDispatchWeight.Depth = 0;
            this.txtManualDispatchWeight.Hint = "WEIGHT";
            this.txtManualDispatchWeight.Location = new System.Drawing.Point(441, 56);
            this.txtManualDispatchWeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtManualDispatchWeight.Name = "txtManualDispatchWeight";
            this.txtManualDispatchWeight.PasswordChar = '\0';
            this.txtManualDispatchWeight.SelectedText = "";
            this.txtManualDispatchWeight.SelectionLength = 0;
            this.txtManualDispatchWeight.SelectionStart = 0;
            this.txtManualDispatchWeight.Size = new System.Drawing.Size(75, 23);
            this.txtManualDispatchWeight.TabIndex = 9;
            this.txtManualDispatchWeight.UseSystemPasswordChar = false;
            // 
            // txtManualDispatchSize
            // 
            this.txtManualDispatchSize.Depth = 0;
            this.txtManualDispatchSize.Hint = "SIZE";
            this.txtManualDispatchSize.Location = new System.Drawing.Point(315, 56);
            this.txtManualDispatchSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtManualDispatchSize.Name = "txtManualDispatchSize";
            this.txtManualDispatchSize.PasswordChar = '\0';
            this.txtManualDispatchSize.SelectedText = "";
            this.txtManualDispatchSize.SelectionLength = 0;
            this.txtManualDispatchSize.SelectionStart = 0;
            this.txtManualDispatchSize.Size = new System.Drawing.Size(75, 23);
            this.txtManualDispatchSize.TabIndex = 8;
            this.txtManualDispatchSize.UseSystemPasswordChar = false;
            // 
            // rdbManualDispatch
            // 
            this.rdbManualDispatch.AutoSize = true;
            this.rdbManualDispatch.Depth = 0;
            this.rdbManualDispatch.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbManualDispatch.Location = new System.Drawing.Point(6, 12);
            this.rdbManualDispatch.Margin = new System.Windows.Forms.Padding(0);
            this.rdbManualDispatch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbManualDispatch.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbManualDispatch.Name = "rdbManualDispatch";
            this.rdbManualDispatch.Ripple = true;
            this.rdbManualDispatch.Size = new System.Drawing.Size(132, 30);
            this.rdbManualDispatch.TabIndex = 0;
            this.rdbManualDispatch.TabStop = true;
            this.rdbManualDispatch.Text = "Manual Dispatch";
            this.rdbManualDispatch.UseVisualStyleBackColor = true;
            // 
            // grpAutoDispatch
            // 
            this.grpAutoDispatch.Controls.Add(this.rdbDispatch);
            this.grpAutoDispatch.Controls.Add(this.cmbPartyName);
            this.grpAutoDispatch.Controls.Add(this.txtDispatchSize);
            this.grpAutoDispatch.Controls.Add(this.cmbSelectOrder);
            this.grpAutoDispatch.Location = new System.Drawing.Point(17, 50);
            this.grpAutoDispatch.Name = "grpAutoDispatch";
            this.grpAutoDispatch.ShowCaption = false;
            this.grpAutoDispatch.Size = new System.Drawing.Size(376, 84);
            this.grpAutoDispatch.TabIndex = 9;
            this.grpAutoDispatch.Text = "Dispatch";
            // 
            // rdbDispatch
            // 
            this.rdbDispatch.AutoSize = true;
            this.rdbDispatch.Checked = true;
            this.rdbDispatch.Depth = 0;
            this.rdbDispatch.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbDispatch.Location = new System.Drawing.Point(6, 6);
            this.rdbDispatch.Margin = new System.Windows.Forms.Padding(0);
            this.rdbDispatch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbDispatch.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbDispatch.Name = "rdbDispatch";
            this.rdbDispatch.Ripple = true;
            this.rdbDispatch.Size = new System.Drawing.Size(83, 30);
            this.rdbDispatch.TabIndex = 9;
            this.rdbDispatch.TabStop = true;
            this.rdbDispatch.Text = "Dispatch";
            this.rdbDispatch.UseVisualStyleBackColor = true;
            // 
            // cmbPartyName
            // 
            this.cmbPartyName.DisplayMember = "10";
            this.cmbPartyName.FormattingEnabled = true;
            this.cmbPartyName.Location = new System.Drawing.Point(5, 46);
            this.cmbPartyName.Name = "cmbPartyName";
            this.cmbPartyName.Size = new System.Drawing.Size(100, 21);
            this.cmbPartyName.TabIndex = 6;
            this.cmbPartyName.Text = "Party Name";
            // 
            // txtDispatchSize
            // 
            this.txtDispatchSize.Depth = 0;
            this.txtDispatchSize.Hint = "SIZE";
            this.txtDispatchSize.Location = new System.Drawing.Point(286, 44);
            this.txtDispatchSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDispatchSize.Name = "txtDispatchSize";
            this.txtDispatchSize.PasswordChar = '\0';
            this.txtDispatchSize.SelectedText = "";
            this.txtDispatchSize.SelectionLength = 0;
            this.txtDispatchSize.SelectionStart = 0;
            this.txtDispatchSize.Size = new System.Drawing.Size(75, 23);
            this.txtDispatchSize.TabIndex = 8;
            this.txtDispatchSize.UseSystemPasswordChar = false;
            // 
            // cmbSelectOrder
            // 
            this.cmbSelectOrder.DisplayMember = "10";
            this.cmbSelectOrder.FormattingEnabled = true;
            this.cmbSelectOrder.Location = new System.Drawing.Point(153, 46);
            this.cmbSelectOrder.Name = "cmbSelectOrder";
            this.cmbSelectOrder.Size = new System.Drawing.Size(100, 21);
            this.cmbSelectOrder.TabIndex = 7;
            this.cmbSelectOrder.Text = "Select Order";
            this.cmbSelectOrder.ValueMember = "10,12,15,20";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(404, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Date :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(458, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // reportsNavigationPage
            // 
            this.reportsNavigationPage.Caption = "Reports";
            this.reportsNavigationPage.Controls.Add(this.btnPrintReport);
            this.reportsNavigationPage.Controls.Add(this.btnShowDispatchedOrder);
            this.reportsNavigationPage.Controls.Add(this.btnShowAddedProduct);
            this.reportsNavigationPage.Controls.Add(this.cmbReportPartyName);
            this.reportsNavigationPage.Controls.Add(this.cmbReportGSM);
            this.reportsNavigationPage.Controls.Add(this.cmbReportBF);
            this.reportsNavigationPage.Controls.Add(this.txtReportWeight);
            this.reportsNavigationPage.Controls.Add(this.txtReportSize);
            this.reportsNavigationPage.Controls.Add(this.lblToDate);
            this.reportsNavigationPage.Controls.Add(this.dateTimePicker4);
            this.reportsNavigationPage.Controls.Add(this.lblFromDate);
            this.reportsNavigationPage.Controls.Add(this.dateTimePicker3);
            this.reportsNavigationPage.Name = "reportsNavigationPage";
            this.reportsNavigationPage.Size = new System.Drawing.Size(670, 309);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.AutoSize = true;
            this.btnPrintReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintReport.Depth = 0;
            this.btnPrintReport.Location = new System.Drawing.Point(232, 211);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Primary = false;
            this.btnPrintReport.Size = new System.Drawing.Size(106, 36);
            this.btnPrintReport.TabIndex = 17;
            this.btnPrintReport.Text = "PRINT REPORT";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnShowDispatchedOrder
            // 
            this.btnShowDispatchedOrder.Depth = 0;
            this.btnShowDispatchedOrder.Location = new System.Drawing.Point(332, 144);
            this.btnShowDispatchedOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowDispatchedOrder.Name = "btnShowDispatchedOrder";
            this.btnShowDispatchedOrder.Primary = true;
            this.btnShowDispatchedOrder.Size = new System.Drawing.Size(138, 38);
            this.btnShowDispatchedOrder.TabIndex = 16;
            this.btnShowDispatchedOrder.Text = "Show Dispatched Order";
            this.btnShowDispatchedOrder.UseVisualStyleBackColor = true;
            // 
            // btnShowAddedProduct
            // 
            this.btnShowAddedProduct.Depth = 0;
            this.btnShowAddedProduct.Location = new System.Drawing.Point(111, 144);
            this.btnShowAddedProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowAddedProduct.Name = "btnShowAddedProduct";
            this.btnShowAddedProduct.Primary = true;
            this.btnShowAddedProduct.Size = new System.Drawing.Size(123, 38);
            this.btnShowAddedProduct.TabIndex = 15;
            this.btnShowAddedProduct.Text = "Show Added Product";
            this.btnShowAddedProduct.UseVisualStyleBackColor = true;
            // 
            // cmbReportPartyName
            // 
            this.cmbReportPartyName.DisplayMember = "10";
            this.cmbReportPartyName.FormattingEnabled = true;
            this.cmbReportPartyName.Location = new System.Drawing.Point(25, 80);
            this.cmbReportPartyName.Name = "cmbReportPartyName";
            this.cmbReportPartyName.Size = new System.Drawing.Size(100, 21);
            this.cmbReportPartyName.TabIndex = 10;
            this.cmbReportPartyName.Text = "Party Name";
            // 
            // cmbReportGSM
            // 
            this.cmbReportGSM.DisplayMember = "10";
            this.cmbReportGSM.FormattingEnabled = true;
            this.cmbReportGSM.Location = new System.Drawing.Point(314, 80);
            this.cmbReportGSM.Name = "cmbReportGSM";
            this.cmbReportGSM.Size = new System.Drawing.Size(100, 21);
            this.cmbReportGSM.TabIndex = 12;
            this.cmbReportGSM.Text = "GSM";
            this.cmbReportGSM.ValueMember = "10,12,15,20";
            // 
            // cmbReportBF
            // 
            this.cmbReportBF.DisplayMember = "10";
            this.cmbReportBF.FormattingEnabled = true;
            this.cmbReportBF.Location = new System.Drawing.Point(172, 80);
            this.cmbReportBF.Name = "cmbReportBF";
            this.cmbReportBF.Size = new System.Drawing.Size(100, 21);
            this.cmbReportBF.TabIndex = 11;
            this.cmbReportBF.Text = "BF";
            // 
            // txtReportWeight
            // 
            this.txtReportWeight.Depth = 0;
            this.txtReportWeight.Hint = "WEIGHT";
            this.txtReportWeight.Location = new System.Drawing.Point(583, 80);
            this.txtReportWeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReportWeight.Name = "txtReportWeight";
            this.txtReportWeight.PasswordChar = '\0';
            this.txtReportWeight.SelectedText = "";
            this.txtReportWeight.SelectionLength = 0;
            this.txtReportWeight.SelectionStart = 0;
            this.txtReportWeight.Size = new System.Drawing.Size(75, 23);
            this.txtReportWeight.TabIndex = 14;
            this.txtReportWeight.UseSystemPasswordChar = false;
            // 
            // txtReportSize
            // 
            this.txtReportSize.Depth = 0;
            this.txtReportSize.Hint = "SIZE";
            this.txtReportSize.Location = new System.Drawing.Point(458, 80);
            this.txtReportSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReportSize.Name = "txtReportSize";
            this.txtReportSize.PasswordChar = '\0';
            this.txtReportSize.SelectedText = "";
            this.txtReportSize.SelectionLength = 0;
            this.txtReportSize.SelectionStart = 0;
            this.txtReportSize.Size = new System.Drawing.Size(75, 23);
            this.txtReportSize.TabIndex = 13;
            this.txtReportSize.UseSystemPasswordChar = false;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Depth = 0;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToDate.Location = new System.Drawing.Point(385, 9);
            this.lblToDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(69, 18);
            this.lblToDate.TabIndex = 9;
            this.lblToDate.Text = "To Date :";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(458, 9);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 8;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Depth = 0;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFromDate.Location = new System.Drawing.Point(21, 9);
            this.lblFromDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(87, 18);
            this.lblFromDate.TabIndex = 7;
            this.lblFromDate.Text = "From Date :";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(111, 9);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 6;
            // 
            // homeNavigationPage
            // 
            this.homeNavigationPage.Caption = "Home Page";
            this.homeNavigationPage.Controls.Add(this.btnAddParty);
            this.homeNavigationPage.Controls.Add(this.btnAddGSM);
            this.homeNavigationPage.Controls.Add(this.btnAddVehicle);
            this.homeNavigationPage.Controls.Add(this.btnAddGF);
            this.homeNavigationPage.Name = "homeNavigationPage";
            this.homeNavigationPage.Size = new System.Drawing.Size(670, 309);
            // 
            // btnAddParty
            // 
            this.btnAddParty.Location = new System.Drawing.Point(282, 133);
            this.btnAddParty.Name = "btnAddParty";
            this.btnAddParty.Size = new System.Drawing.Size(99, 41);
            this.btnAddParty.TabIndex = 3;
            this.btnAddParty.Text = "Add Party";
            this.btnAddParty.UseVisualStyleBackColor = true;
            this.btnAddParty.Click += new System.EventHandler(this.btnAddParty_Click);
            // 
            // btnAddGSM
            // 
            this.btnAddGSM.Location = new System.Drawing.Point(282, 54);
            this.btnAddGSM.Name = "btnAddGSM";
            this.btnAddGSM.Size = new System.Drawing.Size(99, 41);
            this.btnAddGSM.TabIndex = 2;
            this.btnAddGSM.Text = "Add GSM";
            this.btnAddGSM.UseVisualStyleBackColor = true;
            this.btnAddGSM.Click += new System.EventHandler(this.btnAddGSM_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(119, 133);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(99, 41);
            this.btnAddVehicle.TabIndex = 2;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnAddGF
            // 
            this.btnAddGF.Location = new System.Drawing.Point(119, 54);
            this.btnAddGF.Name = "btnAddGF";
            this.btnAddGF.Size = new System.Drawing.Size(99, 41);
            this.btnAddGF.TabIndex = 0;
            this.btnAddGF.Text = "Add GF";
            this.btnAddGF.UseVisualStyleBackColor = true;
            this.btnAddGF.Click += new System.EventHandler(this.btnAddBF_Click);
            // 
            // dlgPrintReport
            // 
            this.dlgPrintReport.UseEXDialog = true;
            // 
            // toolTipAddOrder
            // 
            this.toolTipAddOrder.ToolTipTitle = "Displaying Details in following order. BF | GSM | SIZE | WEIGHT | QUANTITY";
            // 
            // PaperStockManagement
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainNavigation);
            this.Name = "PaperStockManagement";
            this.Text = "Paper Stock Management";
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigation)).EndInit();
            this.mainNavigation.ResumeLayout(false);
            this.mainNavigation.PerformLayout();
            this.addStockNavigationPage.ResumeLayout(false);
            this.addStockNavigationPage.PerformLayout();
            this.addOrderNavigationPage.ResumeLayout(false);
            this.addOrderNavigationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.dispatchNavigationPage.ResumeLayout(false);
            this.dispatchNavigationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpManualDispatch)).EndInit();
            this.grpManualDispatch.ResumeLayout(false);
            this.grpManualDispatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAutoDispatch)).EndInit();
            this.grpAutoDispatch.ResumeLayout(false);
            this.grpAutoDispatch.PerformLayout();
            this.reportsNavigationPage.ResumeLayout(false);
            this.reportsNavigationPage.PerformLayout();
            this.homeNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel_Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement employeesAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement customersAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainAccordionGroup;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPane mainNavigation;
        private DevExpress.XtraBars.Navigation.NavigationPage homeNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage addStockNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage addOrderNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage dispatchNavigationPage;
        private System.Windows.Forms.Button btnAddGF;
        private DevExpress.XtraBars.Navigation.NavigationPage reportsNavigationPage;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnAddParty;
        private System.Windows.Forms.Button btnAddGSM;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtWeight;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSize;
        private MaterialSkin.Controls.MaterialRaisedButton btnReset;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancle;
        private System.Windows.Forms.ComboBox cmbGSM;
        private System.Windows.Forms.ComboBox cmbBF;
        private MaterialSkin.Controls.MaterialLabel lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpStockDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelOrder;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveOrder;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddOrder;
        private System.Windows.Forms.ComboBox cmbVehicleInfo;
        private DevExpress.XtraEditors.GroupControl grpManualDispatch;
        private System.Windows.Forms.ComboBox cmbManualDispatchGSM;
        private System.Windows.Forms.ComboBox cmbManualDispatchBF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtManualDispatchWeight;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtManualDispatchSize;
        private MaterialSkin.Controls.MaterialRadioButton rdbManualDispatch;
        private DevExpress.XtraEditors.GroupControl grpAutoDispatch;
        private MaterialSkin.Controls.MaterialRadioButton rdbDispatch;
        private System.Windows.Forms.ComboBox cmbPartyName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDispatchSize;
        private System.Windows.Forms.ComboBox cmbSelectOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.MaskedTextBox txtDriverName;
        private System.Windows.Forms.MaskedTextBox txtDriverContactNo;
        private MaterialSkin.Controls.MaterialFlatButton btnPrintReport;
        private MaterialSkin.Controls.MaterialRaisedButton btnShowDispatchedOrder;
        private MaterialSkin.Controls.MaterialRaisedButton btnShowAddedProduct;
        private System.Windows.Forms.ComboBox cmbReportPartyName;
        private System.Windows.Forms.ComboBox cmbReportGSM;
        private System.Windows.Forms.ComboBox cmbReportBF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtReportWeight;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtReportSize;
        private MaterialSkin.Controls.MaterialLabel lblToDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private MaterialSkin.Controls.MaterialLabel lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.PrintDialog dlgPrintReport;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStockQuantity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtManualDispatchQuantity;
        private System.Windows.Forms.ComboBox cmbAddOrderPartyName;
        private System.Windows.Forms.ComboBox cmbAddOrderDetail;
        private System.Windows.Forms.ToolTip toolTipAddOrder;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Client;
        private DevExpress.XtraGrid.Columns.GridColumn BF;
        private DevExpress.XtraGrid.Columns.GridColumn GSM;
        private DevExpress.XtraGrid.Columns.GridColumn Size;
        private DevExpress.XtraGrid.Columns.GridColumn Weight;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}