using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacaProject
{
    public class OrderDetail
    {
        [Key]
        public int ItemId { get; set; }

        public double TotalPrice { get; set; }

        public virtual ICollection <Item> Items { get; set; }
    }
}
