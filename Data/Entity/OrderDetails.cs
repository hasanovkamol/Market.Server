using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
   public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId{get;set;}
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quetity { get; set; }
        public double UnitPrice { get; set; }
        public double Descount { get; set; }
    }
}
