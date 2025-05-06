using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Model
{
    public enum Ranking
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5
    }
    public class ProductRanking
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public Ranking Ranking { get; set; }

        public string UserEmail { get; set; } //User identifier
    }
}
