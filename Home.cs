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

namespace ProjectStockManagement
{
    public partial class PaperStockManagement : MaterialSkin.Controls.MaterialForm
    {
        public PaperStockManagement()
        {
            InitializeComponent();
            //MaterialSkin.MaterialSkinManager materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue700, MaterialSkin.Accent.Blue100, MaterialSkin.TextShade.WHITE);
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
    }
}