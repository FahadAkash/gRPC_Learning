using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRP_LEARNING.model
{
    public class Order
    {
        public string ProductId { get; set; }
        public string OrderId { get; set; } 
        public int Quantity {get ; set ;}
        public Product product { get; set; }
    }
}