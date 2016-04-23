using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    // creation of enum 

    public enum CatDescription

    {
        Book,
        Clothes,

    }
    
    public class Categories
    {
        #region variable
        private static int lastCatId = 0;
        #endregion
        public int CatId { get; set; }
        public CatDescription DescriptionOfCat { get; set; }
        public int ItemId { get; set; }
        
        #region constructor
        public Categories ()
        {
            CatId = ++ lastCatId;
                
        }

        #endregion

    }
}
