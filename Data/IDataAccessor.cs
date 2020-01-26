using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStockManagement.Data
{
    public interface IDataAccessor
    {
        /// <summary>
        /// Add breaking force
        /// </summary>
        /// <param name="breakingForce"></param>
        bool AddBreakingForce(int breakingForce);

        /// <summary>
        /// Adds GSM
        /// </summary>
        /// <param name="GSM"></param>
        bool  AddGSM(int GSM);

        /// <summary>
        /// Gets list of breaking force 
        /// </summary>
        /// <returns></returns>
        IList<int> GetBreakingForceList();

        /// <summary>
        /// Gets list of GSM
        /// </summary>
        /// <returns></returns>
        IList<int> GetGSMList();

        bool  AddClient(Client client);

        IList<Client> GetClients();

        bool  AddVehicle(Vehicle vehicle);

        IList<Vehicle> GetVehicles();

        bool  AddOrder(Order order);

        bool  AddOrders(IList<Order> orders);

        IList<Order> GetOrders();

        bool  AddStock(Stock stock);

        bool  AddStocks(IList<Stock> stocks);

        IList<Stock> GetStocks();
    }
}
