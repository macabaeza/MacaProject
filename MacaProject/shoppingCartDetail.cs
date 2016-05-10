using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
   public class shoppingCartDetail
    {
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual Item Item { get; set; }
    }
}
