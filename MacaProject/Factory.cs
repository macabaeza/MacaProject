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
        public static FactoryModel db = new FactoryModel();
        #endregion


        public static Customer FindCustomer(string emailAddress)
        {
            if (string.IsNullOrEmpty (emailAddress))
            {
                throw new ArgumentNullException
                    (" Email address can not be empty");
            }
            return db.Customers.Where(
                 c => c.EmailAddress == emailAddress)
                 .FirstOrDefault();
        }

        public static Customer CreateCustomer(string name, string emailAddress)
        {
            var customer = new Customer
            {
                Name = name,
                EmailAddress = emailAddress
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }
        /// <summary>
        /// Creating an Item
        /// </summary>
        /// <param name="itemName">Item Name</param>
        /// <param name="itemDescription">item Description</param>
        /// <param name="categoryofItem">Item Category</param>
        
       /// <returns>New Item</returns>

        public static Item CreateItem (string itemName, string itemDescription, 
            ItemCategory categoryofItem, Customer customer)
        {
            var item = new Item
            {
                ItemName = itemName,
                ItemDescription = itemDescription,
                categoryofItem = categoryofItem,
                Customer = customer
                
            };

            db.Items.Add(item);
            db.SaveChanges();
            return item;

        }
    }
}
