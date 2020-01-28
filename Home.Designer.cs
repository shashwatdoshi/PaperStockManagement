namespace ProjectStockManagement
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
            this.mainNavigation = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.addStockNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.grpAutoDispatch = new DevExpress.XtraEditors.GroupControl();
            this.rdbDispatch = new MaterialSkin.Controls.MaterialRadioButton();
            this.cmbPartyName = new System.Windows.Forms.ComboBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbSelectOrder = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportsNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnPrintReport = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnShowDispatchedOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnShowAddedProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigation)).BeginInit();
            this.mainNavigation.SuspendLayout();
            this.addStockNavigationPage.SuspendLayout();
            this.addOrderNavigationPage.SuspendLayout();
            this.dispatchNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpManualDispatch)).BeginInit();
            this.grpManualDispatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAutoDispatch)).BeginInit();
            this.grpAutoDispatch.SuspendLayout();
            this.reportsNavigationPage.SuspendLayout();
            this.homeNavigationPage.SuspendLayout();
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
            // 
            // addStockNavigationPage
            // 
            this.addStockNavigationPage.Caption = "Add Stock";
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
            this.cmbGSM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.btnReset.TabIndex = 8;
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
            this.btnCancle.TabIndex = 7;
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
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.addOrderNavigationPage.Controls.Add(this.btnCancelOrder);
            this.addOrderNavigationPage.Controls.Add(this.btnSaveOrder);
            this.addOrderNavigationPage.Controls.Add(this.btnAddOrder);
            this.addOrderNavigationPage.Controls.Add(this.lblOrderDate);
            this.addOrderNavigationPage.Controls.Add(this.dtpStockDate);
            this.addOrderNavigationPage.Name = "addOrderNavigationPage";
            this.addOrderNavigationPage.Size = new System.Drawing.Size(670, 309);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Depth = 0;
            this.btnCancelOrder.Location = new System.Drawing.Point(488, 256);
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
            this.btnSaveOrder.Location = new System.Drawing.Point(248, 256);
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
            this.btnAddOrder.Location = new System.Drawing.Point(23, 256);
            this.btnAddOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Primary = true;
            this.btnAddOrder.Size = new System.Drawing.Size(89, 40);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "ADD";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Depth = 0;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblOrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderDate.Location = new System.Drawing.Point(400, 9);
            this.lblOrderDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(47, 18);
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
            this.grpManualDispatch.Controls.Add(this.comboBox1);
            this.grpManualDispatch.Controls.Add(this.comboBox2);
            this.grpManualDispatch.Controls.Add(this.materialSingleLineTextField2);
            this.grpManualDispatch.Controls.Add(this.materialSingleLineTextField3);
            this.grpManualDispatch.Controls.Add(this.materialRadioButton1);
            this.grpManualDispatch.Location = new System.Drawing.Point(17, 155);
            this.grpManualDispatch.Name = "grpManualDispatch";
            this.grpManualDispatch.ShowCaption = false;
            this.grpManualDispatch.Size = new System.Drawing.Size(650, 100);
            this.grpManualDispatch.TabIndex = 10;
            this.grpManualDispatch.Text = "Manual Dispatch";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "10";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "GSM";
            this.comboBox1.ValueMember = "10,12,15,20";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "10";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "BF";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "WEIGHT";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(441, 56);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextField2.TabIndex = 9;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "SIZE";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(315, 56);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextField3.TabIndex = 8;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(6, 12);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(132, 30);
            this.materialRadioButton1.TabIndex = 0;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Manual Dispatch";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // grpAutoDispatch
            // 
            this.grpAutoDispatch.Controls.Add(this.rdbDispatch);
            this.grpAutoDispatch.Controls.Add(this.cmbPartyName);
            this.grpAutoDispatch.Controls.Add(this.materialSingleLineTextField1);
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
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "SIZE";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(286, 44);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextField1.TabIndex = 8;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
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
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(404, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 18);
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
            this.reportsNavigationPage.Controls.Add(this.comboBox3);
            this.reportsNavigationPage.Controls.Add(this.comboBox4);
            this.reportsNavigationPage.Controls.Add(this.comboBox5);
            this.reportsNavigationPage.Controls.Add(this.materialSingleLineTextField4);
            this.reportsNavigationPage.Controls.Add(this.materialSingleLineTextField5);
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
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "10";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(25, 80);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.Text = "Party Name";
            // 
            // comboBox4
            // 
            this.comboBox4.DisplayMember = "10";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(314, 80);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 21);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.Text = "GSM";
            this.comboBox4.ValueMember = "10,12,15,20";
            // 
            // comboBox5
            // 
            this.comboBox5.DisplayMember = "10";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(172, 80);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 11;
            this.comboBox5.Text = "BF";
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "WEIGHT";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(583, 80);
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextField4.TabIndex = 14;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "SIZE";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(458, 80);
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextField5.TabIndex = 13;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private DevExpress.XtraEditors.GroupControl grpAutoDispatch;
        private MaterialSkin.Controls.MaterialRadioButton rdbDispatch;
        private System.Windows.Forms.ComboBox cmbPartyName;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.ComboBox cmbSelectOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.MaskedTextBox txtDriverName;
        private System.Windows.Forms.MaskedTextBox txtDriverContactNo;
        private MaterialSkin.Controls.MaterialFlatButton btnPrintReport;
        private MaterialSkin.Controls.MaterialRaisedButton btnShowDispatchedOrder;
        private MaterialSkin.Controls.MaterialRaisedButton btnShowAddedProduct;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialLabel lblToDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private MaterialSkin.Controls.MaterialLabel lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.PrintDialog dlgPrintReport;
    }
}