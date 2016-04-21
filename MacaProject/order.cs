using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    class order
    {
        /// <summary>
        /// Price of the Items
        /// </summary>
        private double itemPrice;
        private int itemQuantity;
        private double Total;

        #region Methods

        public double cart (double ItemPrice, int ItemQuantity)
        {
            Total = ItemPrice * ItemQuantity;
            return Total;

        }
        #endregion

    }

}
}
