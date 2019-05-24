using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
    }
}