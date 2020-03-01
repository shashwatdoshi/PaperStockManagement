using System;
using System.Windows.Forms;
using ProjectStockManagement.PaperStockManagementDB;

namespace ProjectStockManagement
{
    /// <summary>
    /// Contain necessary action for adding GSM details.
    /// </summary>
    public partial class AddGSM : Form
    {
        /// <summary>
        /// Initialize insatance(constructor) of AddGSM.
        /// </summary>
        public AddGSM()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ocuurs when any key will press.
        /// </summary>
        /// <param name="sender">Instance of Object.</param>
        /// <param name="e">Instance of KeyPressEventArgs.</param>
        private void txtAddGSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check weather pressed key is in between 0-9.
            if (e.KeyChar < (char)Keys.D0  || e.KeyChar > (char)Keys.D9)
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
        /// Occurs when ADD button will be pressed.
        /// </summary>
        /// <param name="sender">Insatance of Object.</param>
        /// <param name="e">Instance of EventArgs.</param>
        private void btnAddGSM_Click(object sender, EventArgs e)
        {
            // Add new Breaking-force value to data-base.
            using (var paperStockManagementDB = new PaperStockManagementDBEntities())
            {
                var gSM = new GSM();
                gSM.Value = Int32.Parse(txtAddGSM.Text);
                paperStockManagementDB.GSMs.Add(gSM);
                paperStockManagementDB.SaveChanges();
                PaperStockManagement.GSMList.Add(gSM.Value);
            }

            this.Close();
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender">Insatance of Object.</param>
        /// <param name="e">Insatance of EventArgs.</param>
        private void btnCancleGSM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
