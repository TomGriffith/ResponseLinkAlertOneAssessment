﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Models
{
    /// <summary>
    /// A model of the Shipping Options table
    /// </summary>
    public class ShippingOption
    {
        public int Id { get; private set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
    }
}
