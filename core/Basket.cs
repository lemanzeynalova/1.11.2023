using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public class Basket
    {
       List<BasketItem> items=new();
        public int TotalCount { get; set; }
        public int DisCount { get; set; }
    }
}
