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
            // creating an instance of Characteristic
            var characteristic1 = new Characteristic();
            characteristic1.CategoryId = IdCat.Book;
            characteristic1.CharName = " Age Range";
            characteristic1.CharValue = 10 - 12;
            characteristic1.IdChar = 1;

            var characteristic2 = new Characteristic();
            characteristic2.CategoryId = IdCat.Book;
            characteristic2.CharName = "Grade Level";
            characteristic2.CharValue = 4 ;
            characteristic2.CharValue = 2;

            var characteristic3 = new Characteristic();
            characteristic3.CategoryId = IdCat.Clothes;
            characteristic3.CharName = "Product Dimension";
            characteristic3.CharValue = 15 * 13;
            characteristic3.IdChar = 1;

            var characteristic4 = new Characteristic();
            characteristic4.CategoryId = IdCat.Clothes;
            characteristic4.CharName = "Shipping Weight";
            characteristic4.CharValue = 1;
            characteristic4.IdChar = 2;
            // creating an instance of Item
            var item1 = new Item();
            //item1.ItemId = 123
            item1.ItemName = "El Principito";
            item1.Itemdescription = "Autor = Antoine de Saint-Exupéry";


            Console.WriteLine("Item Name: {0}, description:{1}",
                item1.ItemName, item1.Itemdescription);














        }
    }
}