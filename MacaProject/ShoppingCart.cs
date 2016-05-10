using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
   public class ShoppingCart
    {
        #region
        [Key]
        public int ShoppingCartId { get; set; }
        public decimal SubTotal { get; set; }
        public virtual Customer customer { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual shoppingCartDetail shoppingCartDetail { get; set; }

    }
}
