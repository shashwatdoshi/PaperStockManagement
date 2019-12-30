using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStockManagement.Data
{
    /// <summary>
    /// Information regarding perticular vehicle.
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Number of perticular vehicle.
        /// i.e GJ-36-XXXX
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Driver detais for pericular vehicle.
        /// </summary>
        public Driver Driver { get; set; }
    }
}
