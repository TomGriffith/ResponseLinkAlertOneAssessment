using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Models
{
    /// <summary>
    /// A model of the Address table
    /// </summary>
    public class Address
    {
        public int Id { get; private set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        
    }
}
