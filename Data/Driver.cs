using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStockManagement.Data
{
    /// <summary>
    /// Information regarding a perticular driver.
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// ID for a specific driver.
        /// </summary>
        public uint ID { get; set; }

        /// <summary>
        /// Name for a specific driver.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contact number for a specific driver.
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Image(Photo of identity) for a specific driver.
        /// </summary>
        public object Image { get; set; }
    }
}
