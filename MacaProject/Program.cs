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
            characteristic2.CategoryId = IdCat.Clothes;
            characteristic2.CharName = "Product Dimension";
            characteristic2.CharValue = 15 * 13;
            characteristic2.IdChar = 1;
            var characteristic3 = new Characteristic();
            characteristic3.CategoryId = IdCat.Book;
            characteristic3.CharName = "Grade Level";
            characteristic3.CharValue = 4 and up;
            characteristic3.CharValue = 2;
            var characteristic4 = new Characteristic();
            characteristic4.CategoryId = IdCat.Clothes;
            characteristic4.CharName = "Shipping Weight";
            characteristic4.CharValue = 1;
            characteristic4.IdChar = 2;


             
        
        
        
        }
    }
}
 