using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectStockManagement.PaperStockManagementDB;

namespace ProjectStockManagement
{
    public partial class AddBF : Form
    {
        public AddBF()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Occurs when ADD button will be pressed.
        /// </summary>
        /// <param name="sender">Insatance of Object.</param>
        /// <param name="e">Instance of EventArgs.</param>
        private void btnAddBF_Click(object sender, EventArgs e)
        {
            // Add new GSM value to data-base.
            using (var paperStockManagementDB = new PaperStockManagementDBEntities())
            {
                var breakingForce = new BreakingForce();
                breakingForce.Value = Int32.Parse(txtAddBF.Text);
                paperStockManagementDB.BreakingForces.Add(breakingForce);
                paperStockManagementDB.SaveChanges();
            }

            this.Close();
        }

        /// <summary>
        /// Ocuurs when any key will press.
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of KeyPressEventArgs.</param>
        private void txtAddBF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check weather pressed key is in between 0-9.
            if (e.KeyChar < (char)Keys.D0 || e.KeyChar > (char)Keys.D9)
            {
                e.Handled = true;

                // Check if pressed key is backspace or not.
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

            // Occurs when ESC button will be pressed.
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender">Insatance of Object.</param>
        /// <param name="e">Insatance of EventArgs.</param>
        private void btnCancleBF_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
