using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class BasketItem
    {
        public Book Book { get; set; }
        public int Count { get; set; }
        public int DiscountPercent { get; set; }
    }
}
