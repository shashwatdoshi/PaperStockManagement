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
        public string ClientName { get; set; }

        /// <summary>
        /// ID number of client.
        /// </summary>
        public ulong ClientID { get; set; }

        /// <summary>
        /// Contact number of client.
        /// </summary>
        public string ClientContactNumber { get; set; }

        /// <summary>
        /// Address details of client.
        /// </summary>
        public string ClientAddress { get; set; }

        /// <summary>
        /// Email ID of client.
        /// </summary>
        public string ClientEmailID { get; set; }
    }
}
