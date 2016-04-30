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
                Console.WriteLine("1.Item name");
                Console.WriteLine("2.Item id");
                Console.WriteLine("3. Item description");
                Console.WriteLine("4. Item price");
                Console.WriteLine("5. Print Items");
                Console.WriteLine("0. Exit");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("What is the name of Item?");
                        var itemName = Console.ReadLine();

                        var item1 = Factory.CreateItem(itemName, 123, " In 2000 Harcourt proudly reissued Antoine de Saint-Exupéry's masterpiece.", 123);

                        Console.WriteLine(" Item name:{0},Item id: {1},Item description:{2}, Item price: {3}",
                             item1.ItemName, item1.ItemId, item1.ItemDescription, item1.ItemPrice);

                        break;
                    case "2":
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

        //static void PrintItems()

       // {
       //     foreach (var item in Factory.items)

       //     {
       //         Console.WriteLine("Id: {0}, Name: {1}",
       //            item.ItemId, item.ItemName);

      //      }
      //}
    }
}