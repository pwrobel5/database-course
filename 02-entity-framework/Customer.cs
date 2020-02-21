using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BD_Entity
{
    public class Customer
    {
        [Key]
        public String CompanyName { get; set; }
        public String Description { get; set; }
        public List<Order> Orders { get; set; }
    }
}