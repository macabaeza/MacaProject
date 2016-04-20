using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{

  
    /// <summary>
    /// Items for selling in a bookstore
    /// </summary>
    public class Product
    {
        #region Properties
        /// <summary>
        /// title of the Items
        /// </summary>
        /// 
        public string ItemId { get; set; }
        public int ItemName { get; set; }
        /// <summary>
        /// descriptions of the items
        /// </summary>
        public string Itemdescription { get; set; }
        /// <summary>
        /// Price of the Items
        /// </summary>
        public double ItemPrice { get; set; }


        #endregion

        #region Methods


        #endregion

    }
}
