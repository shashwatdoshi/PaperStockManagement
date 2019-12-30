using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStockManagement.Data
{
    /// <summary>
    /// Information regarding an order.
    /// </summary>
     public class Order
    {
        /// <summary>
        /// ID for specific Order.
        /// </summary>
        public uint ID { get; set; }

        /// <summary>
        /// Client detail for specif order.
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// Stock information for specific order.
        /// </summary>
        public Stock Stock { get; set; }

        /// <summary>
        /// Vehicle information for specific order.
        /// </summary>
        public Vehicle Vehicle { get; set; }

        /// <summary>
        /// Date traker for specific order.
        /// </summary>
        public DateTracker DateTracker { get; set; }
    }
}
