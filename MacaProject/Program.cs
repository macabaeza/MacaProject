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
            Console.WriteLine("1. Create an Id");
            Console.WriteLine("2. Name ");
            Console.WriteLine("3. Description");
            Console.WriteLine("0. Exit");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("What is the Id Number?");
                    var ItemId = Console.ReadLine();

                    var Item1 = Factory.CreateItem(123, " El Principito", " In 2000 Harcourt proudly reissued Antoine de Saint-Exupéry's masterpiece, The Little Prince, in a sparkling new format.");

                    Console.WriteLine("Item Id: {0}, name:{1}, description: {2}",
                        Item1.ItemId, Item1.ItemName, Item1.ItemDescription);

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "0":
                    Console.WriteLine("Good bye!");
                    return;
  
                default:
                    break;
            }
 
        }
    }
}