using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Models
{
    /// <summary>
    /// A model of the customer table
    /// </summary>
    public class Customer
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
