using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStockManagement.Data
{
    /// <summary>
    /// Information regarding a perticular client.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Name of the client.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID number of client.
        /// </summary>
        public ulong ID { get; set; }

        /// <summary>
        /// Contact number of client.
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Address details of client.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Email ID of client.
        /// </summary>
        public string EmailID { get; set; }
    }
}
