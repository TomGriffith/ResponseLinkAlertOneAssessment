using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Models
{
    public class Order
    {
        [Key]
        public int Id { get; private set; }
        public Customer Customer { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public bool ShippingSameAsBilling { get; set; }
        public ShippingOption ChosenShipping { get; set; }

        public virtual ICollection<Item> Items { get; set; }

    }
}
