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
        public static List<Item> items = new List<Item>();

        /// <summary>
        /// create a new item
        /// </summary>
        /// <param name="itemName">name item</param>
        /// <param name="descriptionId">description for Item</param>
        /// <returns>new Item</returns>
        public static Item CreateItem (int itemId, string itemName, string descriptionId)
        {
            var item = new Item
            {
                ItemName = itemName,
                ItemDescription = descriptionId
            };
            items.Add(item);
            return item;

        }
    }
}
