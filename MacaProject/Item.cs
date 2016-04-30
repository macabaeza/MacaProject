using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{ 
  

    /// <summary>
    /// Items for selling, creating a static instance for id
    /// </summary>
    public class Item
    {
        #region variables
        private static int lastItemId = 0;

        #endregion
        #region Properties
        // name of the item
        public string ItemName { get; set; }
        // Items Id 
        public int ItemId { get; set; }
        //descriptions of the items
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        #endregion
        #region Constructor
        public Item()
        {
           ItemId = ++lastItemId;
        }
        #endregion
       


    }
}
