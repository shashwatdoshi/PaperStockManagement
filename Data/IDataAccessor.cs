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
        void AddBreakingForce(int breakingForce);

        /// <summary>
        /// Adds GSM
        /// </summary>
        /// <param name="GSM"></param>
        void AddGSM(int GSM);

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

        void AddClient(Client client);

        void AddVehicle(Vehicle vehicle);

        void AddOrder(Order order);

        void AddOrders(IList<Order> orders);

        void AddStock(Stock stock);

        void AddStocks(IList<Stock> stocks);
    }
}
