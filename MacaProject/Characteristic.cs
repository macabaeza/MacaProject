using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{  
   public class Characteristic
    {
        #region variable
        public static int LastIdCharacteristic = 0;
        #endregion
        [Key]
        public int IdCharacteristic { get; set; }
        public string CharacteristicName { get; set; }
        public int CharacteristicValue { get; set; }
        // building a relationship Btw categories and Characteristics
        public virtual Categories categories { get; set; }
        
        
        #region constructor
        public Characteristic()
        {
            IdCharacteristic = ++LastIdCharacteristic;

        }
        #endregion

    }
}
