using System;
using System.Windows.Forms;
using System.Data.Entity;
using ProjectStockManagement.PaperStockManagementDB;
using System.Linq;

namespace ProjectStockManagement
{
    public partial class DeleteOrder : Form
    {
        PaperStockManagementDBEntities paperStockManagementDB;

        public DeleteOrder()
        {
            InitializeComponent();

            ProjectStockManagement.PaperStockManagementDB.PaperStockManagementDBEntities dbContext = new ProjectStockManagement.PaperStockManagementDB.PaperStockManagementDBEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Orders.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                grdCtrlDeleteOrder.DataSource = dbContext.Orders.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var paperStockManagementDB = new PaperStockManagementDBEntities())
            {
                for (int i = 0; i < grdViewDeleteOrder.DataRowCount; i++)
                {
                    if (grdViewDeleteOrder.IsRowSelected(i))
                    {
                        //Delete order
                        var orderID = int.Parse(grdViewDeleteOrder.GetRowCellValue(i, "ID").ToString());
                        Order order = paperStockManagementDB.Orders.First(j => j.ID == orderID);
                        paperStockManagementDB.Orders.Remove(order);

                        //Add stock quantity back to main stock
                        paperStockManagementDB.Stocks.First(j => j.ID == order.StockID).Quantity += order.Quantity;
                    }
                }

                paperStockManagementDB.SaveChanges();
            }

            ProjectStockManagement.PaperStockManagementDB.PaperStockManagementDBEntities dbContext = new ProjectStockManagement.PaperStockManagementDB.PaperStockManagementDBEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Orders.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                grdCtrlDeleteOrder.DataSource = dbContext.Orders.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            grdCtrlDeleteOrder.RefreshDataSource();

            grdCtrlDeleteOrder.Refresh();
        }
    }
}
