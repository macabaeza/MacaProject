using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
   
    class Characteristic
    {
        #region variable
        public static int LastIdChart = 0;
        #endregion
        public int IdChar { get; set; }
        public int CategoryId { get; set; }
        public string CharName { get; set; }
        public int CharValue { get; set; }
        #region constructor
        public Characteristic()
        {
            IdChar = ++LastIdChart;

        }
        #endregion

    }
}
