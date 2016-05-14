using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    public static class Factory
    {
        #region variable
        private static FactoryModel db = new FactoryModel();
        #endregion
/// <summary>
/// Create a new Item
/// </summary>
/// <param name="itemName">Name of the item</param>
/// <param name="itemId">Id of the  item</param>
/// <param name="itemDescription">Description of thr item</param>
/// <param name="itemPrice">Price of the item</param>
/// <returns>a new item</returns>
        
            // creating the method
        public static Item CreateItem (string itemName, int itemId,
            string itemDescription, double itemPrice, Customer customer)
        {
            var item = new Item
            {
                ItemName = itemName,
                ItemId = itemId,
                ItemDescription = itemDescription,
                ItemPrice = itemPrice,
                Customer = customer
            };
            db.Items.Add(item);
            db.SaveChanges();
            return item;

        }

    }
}