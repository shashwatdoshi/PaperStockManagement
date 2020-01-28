using ProjectStockManagement.PaperStockManagementDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectStockManagement
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when ADD VEHICLE button will be pressed.
        /// </summary>
        /// <param name="sender">Insatance of Object.</param>
        /// <param name="e">Instance of EventArgs.</param>
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            // Add new Vehicle details to data-base.
            using (var paperStockManagementDB = new PaperStockManagementDBEntities())
            {
                var vehicle = new Vehicle();
                vehicle.Number = txtAddVehicle.Text;
                paperStockManagementDB.Vehicles.Add(vehicle);
                paperStockManagementDB.SaveChanges();
            }

            this.Close();
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender">Insatance of Object.</param>
        /// <param name="e">Insatance of EventArgs.</param>
        private void btnCancleVehicle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ocuurs when any key will press.
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of KeyPressEventArgs.</param>
        private void AddVehicle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
