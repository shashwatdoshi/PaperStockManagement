using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraBars.Navigation;
using ProjectStockManagement.PaperStockManagementDB;

namespace ProjectStockManagement
{
    public partial class PaperStockManagement : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Contains all added values for Breaking-force(BF).
        /// </summary>
        public static BindingList<int> BFList = new BindingList<int>();

        /// <summary>
        /// Contains all added values for Gram per square meter(GSM).
        /// </summary>
        public static BindingList<int> GSMList = new BindingList<int>();

        /// <summary>
        /// Contains all added values for Party detail(Party name).
        /// </summary>
        public static BindingList<string> PartyNameList = new BindingList<string>();

        public static BindingList<Stock> StockList = new BindingList<Stock>();
        public PaperStockManagement()
        {
            InitializeComponent();
            
            // Get data from database.
            FetchDBListData();

            // Set data to member variables.
            AssignDBListData();
        }

        private void FetchDBListData()
        {
            using (var paperStockManagementDB = new PaperStockManagementDBEntities())
            {
                foreach (BreakingForce breakingForce in paperStockManagementDB.BreakingForces.ToList())
                {
                    BFList.Add(breakingForce.Value);
                }

                foreach (GSM gsm in paperStockManagementDB.GSMs.ToList())
                {
                    GSMList.Add(gsm.Value);
                }

                foreach (Client client in paperStockManagementDB.Clients.ToList())
                {
                    PartyNameList.Add(client.Name);
                }

                foreach (Stock stock in paperStockManagementDB.Stocks.ToList())
                {
                    StockList.Add(stock);
                }
            }
        }

        private void AssignDBListData()
        {
            // Add data to all BF contained combobox.
            cmbBF.DataSource = BFList;
            cmbManualDispatchBF.DataSource = BFList;
            cmbReportBF.DataSource = BFList;

            // Add data to all GSM contained combobox.
            cmbGSM.DataSource = GSMList;
            cmbManualDispatchGSM.DataSource = GSMList;
            cmbReportGSM.DataSource = GSMList;

            // Add data to all Party detail contained combobox.
            cmbAddOrderPartyName.DataSource = PartyNameList;
            cmbPartyName.DataSource = PartyNameList;
            cmbReportPartyName.DataSource = PartyNameList;

            // Add data to BF | GSM | SIZE | WEIGHT | QUANTITY contained combobox.
            cmbAddOrderDetail.DataSource = StockList;
        }
        private void btnAddBF_Click(object sender, EventArgs e)
        {
            AddBF addBF = new AddBF();
            addBF.Show();

        }

        private void btnAddGSM_Click(object sender, EventArgs e)
        {
            AddGSM addGSM = new AddGSM();
            addGSM.Show();
        }

        private void btnAddParty_Click(object sender, EventArgs e)
        {
            AddPartyDetail addPartyDetail = new AddPartyDetail();
            addPartyDetail.Show();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.Show();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            dlgPrintReport.ShowDialog();
        }

        private void mainNavigation_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
            RefreshDataSource();
        }

        private void RefreshDataSource()
        {
            BFList.ResetBindings();
            GSMList.ResetBindings();
            PartyNameList.ResetBindings();
        }

        private void LoadDataSource()
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var paperStockManagementDB = new PaperStockManagementDBEntities())
            {
                var stock = new Stock();
                stock.BreakingForce = Int32.Parse(cmbBF.SelectedItem.ToString());
                stock.GSM = Int32.Parse(cmbGSM.SelectedItem.ToString());
                stock.Weight = Int32.Parse(txtWeight.Text);
                stock.Size = Int32.Parse(txtSize.Text);
                paperStockManagementDB.Stocks.Add(stock);

                var inventory = new StockInventory();
                inventory.Date = dateTimePicker1.Value;
                inventory.Stock = stock;
                inventory.Quantity = Int32.Parse(txtStockQuantity.Text);
                paperStockManagementDB.StockInventories.Add(inventory);

                paperStockManagementDB.SaveChanges();
            }
        }
    }
}