using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStockManagement.Data
{
    /// <summary>
    /// Information of date tracking regarding aperticluar order. 
    /// </summary>
    public class DateTracker
    {
        /// <summary>
        /// Start date of perticular order.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End Date of perticular order.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
