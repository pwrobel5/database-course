using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BD_Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public String Name { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        [Column("UnitPrice", TypeName="money")]
        public decimal UnitPrice { get; set; }
    }
}