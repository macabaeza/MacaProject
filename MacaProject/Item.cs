using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    public enum ItemCategory

    {
        Book,
        Clothes,

    }
    /// <summary>
    /// Items for selling, creating a static instance for id
    /// </summary>
    public class Item
    {
        
        #region Properties 
        // Items Id
        [Key] 
        public int ItemId { get; set; }
        // name of the item
        [StringLength(10,ErrorMessage = "Item name cannot be more than 10 character length.")]
        public string ItemName { get; set; }
        //descriptions of the items
        public string ItemDescription { get; set; }

        public virtual Customer Customer { get; set; }

        public ItemCategory categoryofItem { get; set; }
       
        // creation of multiples characteristic for one item
        public virtual ICollection<Characteristic> Characteristics { get; set; }
        
       


        #endregion
       
       


    }
}
