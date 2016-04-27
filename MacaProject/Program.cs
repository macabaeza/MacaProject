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
                Console.WriteLine("1. Name ");
                Console.WriteLine("2. Description");
                Console.WriteLine("3. Print Id ");
                Console.WriteLine("0. Exit");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("What is the Item name?");
                        var ItemId = Console.ReadLine();

                        var Item1 = Factory.CreateItem(123, " El Principito", " In 2000 Harcourt proudly reissued Antoine de Saint-Exupéry's masterpiece, The Little Prince, in a sparkling new format.");

                        Console.WriteLine("Item Id: {0}, name:{1}, description: {2}",
                            Item1.ItemId, Item1.ItemName, Item1.ItemDescription);

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

        static void PrintItems()

        {
            foreach (var item in Factory.items)

            {
                Console.WriteLine("Id: {0}, Name: {1}",
                    item.ItemId, item.ItemName);

            }
        }
    }
}