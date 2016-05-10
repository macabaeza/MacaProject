using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        // Items Id
        [Key] 
        public int ItemId { get; set; }
        // name of the item
        [StringLength(30, ErrorMessage = "Item name must be less than 30 characters in leng")]
        public string ItemName { get; set; }
        //descriptions of the items
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public virtual Categories Categories { get; set; }
        // creation of multiples characteristic for one item
        public virtual ICollection<Characteristic> Characteristics { get; set; }



        #endregion
        #region Constructor
        public Item()
        {
           ItemId = ++lastItemId;
        }
        #endregion
       


    }
}
