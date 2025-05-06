using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Model
{
    public class OrderLine
    {
        public int ID { get; set; } //OrderLineID

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice { get; set; }
    }
}
