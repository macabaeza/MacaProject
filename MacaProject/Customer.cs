using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
   
    
/// <summary>
/// this is about Amazon customer account
/// </summary>
    public class Customer
    {

        #region Properties
        /// <summary>
        /// Properties for the Customer
        /// </summary>
       [Key]
        public int CustomerId { get; private set; }
        /// Account name for the account
        public String Name { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        // one customer many orders
        public virtual ICollection<order> Orders { get; set; }

        #endregion

    }
}
