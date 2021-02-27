using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Models
{
    /// <summary>
    /// A model of the Item table
    /// </summary>
    public class Item
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
    }
}

