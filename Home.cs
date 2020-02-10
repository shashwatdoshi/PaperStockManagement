using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using MaterialSkin.Controls;
using ProjectStockManagement.PaperStockManagementDB;

namespace ProjectStockManagement
{
    public partial class PaperStockManagement : MaterialSkin.Controls.MaterialForm
    {
        public static BindingList<int> BFList = new BindingList<int>();
        public static BindingList<int> GSMList = new BindingList<int>();
        public PaperStockManagement()
        {
            InitializeComponent();
            //MaterialSkin.MaterialSkinManager materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue700, MaterialSkin.Accent.Blue100, MaterialSkin.TextShade.WHITE);
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

                cmbBF.DataSource = BFList;
                cmbGSM.DataSource = GSMList;
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                var inventory = new StockInventory();
                inventory.Date = dateTimePicker1.Value;
                inventory.Stock = stock;
                inventory.Quantity = 1;
                paperStockManagementDB.Stocks.Add(stock);
                paperStockManagementDB.StockInventories.Add(inventory);
                paperStockManagementDB.SaveChanges();
            }
        }
    }
}