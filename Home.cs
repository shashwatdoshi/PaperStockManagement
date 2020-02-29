﻿using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using ProjectStockManagement.PaperStockManagementDB;

namespace ProjectStockManagement
{
    public partial class PaperStockManagement : Form
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

        /// <summary>
        /// Contains all added values for Stock detail.
        /// </summary>
        public static BindingList<Stock> StockList = new BindingList<Stock>();
        
        /// <summary>
        /// Contains all added values for Stock detail in format.
        /// </summary>
        public static BindingList<string> ExStockList = new BindingList<string>();

        /// <summary>
        /// Initialize insatance(constructor) of PaperStockManagement.
        /// </summary>
        public PaperStockManagement()
        {
            InitializeComponent();

            // Get data from database.
            FetchDBListData();

            // Set data to member variables.
            AssignDBListData();

            gridControl1.DataSource = CreateDataSource();
        }

        /// <summary>
        /// Get data values from database.
        /// </summary>
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
                    ExStockList.Add(string.Format("{0} | {1} | {2} | {3}",
                        stock.BreakingForce, stock.GSM, stock.Size, stock.Weight));
                }
            }
        }

        /// <summary>
        /// Set data values to member variables.
        /// </summary>
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
            cmbAddOrderDetail.DataSource = ExStockList;
        }

        /// <summary>
        /// Open Add Break-force form on-click.
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of EventArgs.</param>
        private void btnAddBF_Click(object sender, EventArgs e)
        {
            AddBF addBF = new AddBF();
            addBF.Show();
        }

        /// <summary>
        /// Open Add GSM form on-click.
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of EventArgs.</param>
        private void btnAddGSM_Click(object sender, EventArgs e)
        {
            AddGSM addGSM = new AddGSM();
            addGSM.Show();
        }

        /// <summary>
        /// Open Party detail form on button click.
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of EventArgs.</param>
        private void btnAddParty_Click(object sender, EventArgs e)
        {
            AddPartyDetail addPartyDetail = new AddPartyDetail();
            addPartyDetail.Show();
        }

        /// <summary>
        /// Open Add Vehicle form on button click.
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of EventArgs.</param>
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.Show();
        }

        /// <summary>
        /// Open Print dailog on button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            dlgPrintReport.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of SelectedPageChangingEventArgs.</param>
        private void mainNavigation_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
            RefreshDataSource();
        }

        /// <summary>
        /// Refresh data sources.
        /// </summary>
        private void RefreshDataSource()
        {
            BFList.ResetBindings();
            GSMList.ResetBindings();
            PartyNameList.ResetBindings();
        }

        /// <summary>
        /// Save all the data on button click.
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of EventsArgs.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var paperStockManagementDB = new PaperStockManagementDBEntities())
            {
                var stock = new Stock();
                stock.BreakingForce = Int32.Parse(cmbBF.SelectedItem.ToString());
                stock.GSM = Int32.Parse(cmbGSM.SelectedItem.ToString());
                stock.Weight = Int32.Parse(txtWeight.Text);
                stock.Size = Int32.Parse(txtSize.Text);
                var inventory = new StockInventory();
                inventory.Date = dateTimePicker1.Value;
                inventory.Stock = stock;
                inventory.Quantity = Int32.Parse(txtStockQuantity.Text);
                paperStockManagementDB.Stocks.Add(stock);
                paperStockManagementDB.StockInventories.Add(inventory);
                paperStockManagementDB.SaveChanges();
            }
        }

        DataTable dataTable;
        private DataTable CreateDataSource()
        {
            dataTable = new DataTable();
            dataTable.TableName = "GridTempTable";
            dataTable.Columns.Add("Client", typeof(string));
            dataTable.Columns.Add("BF", typeof(int));
            dataTable.Columns.Add("GSM", typeof(int));
            dataTable.Columns.Add("Size", typeof(float));
            dataTable.Columns.Add("Weight", typeof(float));
            dataTable.Columns.Add("Quantity", typeof(long));

            return dataTable;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

        }
    }
}