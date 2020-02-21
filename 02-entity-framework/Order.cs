using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BD_Entity
{
    public class Order
    {
        public int OrderID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [Required]
        public int NumberOfUnits { get; set; }

        [ForeignKey("Customer")]
        public String CompanyName { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
