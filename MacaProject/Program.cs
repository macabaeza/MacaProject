using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Welcome to Amazon****");
            string option;
            Customer customer;
            do
            {
                Console.WriteLine("1.Create an Item");
                Console.WriteLine("2.Order Item");
                Console.WriteLine("3.Print Items");
                Console.WriteLine("0.Exit");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        
                        try
                        {
                            customer = VerifyCustomer();
                            Console.Write("What is the name of Item? ");
                            var itemName = Console.ReadLine();

                            Console.Write("What is the description of the item? ");
                            var itemDescription = Console.ReadLine();

                            Console.WriteLine("What is the category of the item? ");
                            Console.WriteLine("1.Book");
                            Console.WriteLine("2.Clothe");
                            var categoryofItem = Console.ReadLine();
                            ItemCategory itemCategory = ItemCategory.Clothe;
                            if (categoryofItem == "1")
                            {
                                itemCategory = ItemCategory.Book;
                            }


                            var item1 = Factory.CreateItem(itemName, itemDescription,
                                itemCategory, customer);

                            Console.WriteLine(" Item name:{0},Item description:{2}, Item category:{3},customer:{4} ",
                                 item1.ItemName, item1.ItemDescription, item1.categoryofItem, item1.Customer);

                        }
                        catch (ArgumentNullException ax)

                        {
                            Console.WriteLine("Failed - {0}", ax.Message);
                        }
                        catch (DbEntityValidationException dx)
                        {
                            Console.WriteLine("Failed creating an item - {0}", dx.Message);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;
                    case "2":
                         customer = VerifyCustomer();
                        //Console.Write("What is the name of the item?");
                        break;
                    case "3":
                        customer = VerifyCustomer();
                        break;
                    case "4":
                        //PrintItems();
                        break;
                    case "0":
                        Console.WriteLine("Good bye!");
                        return;

                    default:
                        break;
                }
            } while (option != "0");
        }
    private static Customer VerifyCustomer()
        {
            Console.WriteLine("What is your email Address?");
            var emailAddress = Console.ReadLine();

            var customer = Factory.FindCustomer(emailAddress);
            if (customer == null)
            {
                Console.Write("What is your name?");
                var name = Console.ReadLine();
                Factory.CreateCustomer(name, emailAddress);
            }
      return customer;
        }

        // static void PrintItems()

        //{
        //   foreach (var item in Factory.items)

        //   {
        //       Console.WriteLine("Id: {0}, Name: {1}",
        //        item.ItemId, item.ItemName);
        //
        //          }
        //     }
    }
}