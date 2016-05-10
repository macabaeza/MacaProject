using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    public class order
    {
        [Key]
        public int OrderId { get; set; }
        public decimal Total { get; set; }
        public virtual Customer Customer { get; set; }
        // an order has many order details
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }

        

        #region Methods

        public double cart (double OrderPrice, int OrderQuantity)
        {
            Total = OrderPrice * OrderQuantity;
            return Total;

        }
        #endregion

    }

}

