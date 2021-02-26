using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Models
{
    public class Order
    {
        public int Id { get; private set; }
        public Customer Customer { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public bool ShippingSameAsBilling { get; set; }
        public OrderItem[] Items { get; set; }
        public ShippingOption ChosenShipping { get; set; }

    }
}
