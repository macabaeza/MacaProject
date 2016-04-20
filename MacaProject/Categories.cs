using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    /// <summary>
    /// creation of enum 
    /// </summary>
         public enum IdCat
    {
        Book,
        Clothes,

    }

    class Categories
    {
        #region
        // description of category

        public string CatDescription { get; set; }
        public IdCat CategoryId { get; set; }
#endregion





    }
}
