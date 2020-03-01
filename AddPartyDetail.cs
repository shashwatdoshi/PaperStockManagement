using System;
using System.Windows.Forms;
using ProjectStockManagement.PaperStockManagementDB;

namespace ProjectStockManagement
{
    /// <summary>
    /// Contain necessary action for adding Party details.
    /// </summary>
    public partial class AddPartyDetail : Form
    {
        /// <summary>
        /// Initialize insatance(constructor) of AddPartyDetail.
        /// </summary>
        public AddPartyDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when ADD PARTY DETAILS button will be pressed.
        /// </summary>
        /// <param name="sender">Insatance of Object.</param>
        /// <param name="e">Instance of EventArgs.</param>
        private void addPartyDetails_Click(object sender, EventArgs e)
        {
            // Add new Party details to data-base.
            using (var paperStockManagementDB = new PaperStockManagementDBEntities())
            {
                var client = new Client();
                client.Name = txtName.Text;
                client.Contact = decimal.Parse(txtContactNo.Text);
                client.Address = txtAddress.Text;
                client.Email = txtEmail.Text;
                paperStockManagementDB.Clients.Add(client);
                paperStockManagementDB.SaveChanges();
                PaperStockManagement.PartyNameList.Add(client.Name);
            }

            this.Close();
        }

        /// <summary>
        /// Ocuurs when any key will press.
        /// </summary>
        /// <param name="sender">Insatance of Object.</param>
        /// <param name="e">Insatance of KeyPressEventArgs.</param>
        private void AddPartyDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        private void btnCanclePartyDetail_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
