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
    public class Item
    {
        #region variables
        private static int lastItemId = 0;

        #endregion
        #region Properties
        /// <summary>
        /// title of the Items
        /// </summary>
        /// 
        public int ItemId { get; private set; }
        public string ItemName { get; set; }
        /// <summary>
        /// descriptions of the items
        /// </summary>
        public string Itemdescription { get; set; }
       
        #endregion
        #region Constructor
        public Item()
        {
           ItemId = ++lastItemId;
        }
        #endregion


    }
}
