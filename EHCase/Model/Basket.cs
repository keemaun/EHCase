using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Model
{
    public class Basket //Would probably have base Model class that has general properties like ID and UniqueID
    {
        public int ID { get; set; }

        public Guid UniqueID { get; set; }

        public string UserEmail { get; set; } //User identifier

        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}
