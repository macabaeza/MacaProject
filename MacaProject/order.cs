using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public double Total { get; set; }
        
        //order is associated to one customer
        public virtual Customer Customer { get; set; }
        // an order has many order details
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        

        #region Methods

        public double cart (double OrderPrice, int OrderQuantity)
        {
            Total = OrderPrice * OrderQuantity;
            return Total;

        }
        #endregion

    }

}

