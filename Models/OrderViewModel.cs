using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OrderViewModel
    {
        public int? SalesOrderID { get; set; }
        public SalesOrderHeader OrderHeader { get; set; }
        public List<SalesOrderDetail> OrderDetails { get; set; }
        public Customer Customer { get; set; }
    }
}