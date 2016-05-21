using System;
using System.Collections.Generic;
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
            do
            {
                Console.WriteLine("1.Create an Item");
                Console.WriteLine("2.Order Item");
                Console.WriteLine("3. Print Items");
                Console.WriteLine("0. Exit");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                       Console.Write("What is the name of Item? ");
                        var itemName = Console.ReadLine();

                        Console.Write("What is the description of the item? ");
                        var itemDescription = Console.ReadLine();


                        Console.WriteLine("What is your email Address?");
                        var emailAddress = Console.ReadLine();

                        var customer = Factory.FindCustomer(emailAddress);
                        var item1 = Factory.CreateItem(itemName, itemDescription, 
                            ItemCategory.Clothes, customer);

                        Console.WriteLine(" Item name:{0},Item description:{2}, Item category:{3},customer:{4} ",
                             item1.ItemName, item1.ItemDescription, item1.categoryofItem, item1.Customer);

     
                        
                        break;
                    case "2":
                        //Console.Write("What is the name of the item?");
                        break;
                    case "3":
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