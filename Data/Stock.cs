using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStockManagement.Data
{
    /// <summary>
    /// Information regarding stock.
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Breaking-force (BF) for specific order.
        /// </summary>
        public uint BreakingForce { get; set; }

        /// <summary>
        /// Gram-Square-Meter (GSM) for specific order.
        /// </summary>
        public uint GSM { get; set; }

        /// <summary>
        /// Size for specific order(Paper size). 
        /// </summary>
        public decimal Size { get; set; }

        /// <summary>
        /// Weight for specific order. (Generally in Kilograms.)
        /// </summary>
        public decimal Weight { get; set; }
    }
}
