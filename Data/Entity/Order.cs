using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
   public class Order
    {
        public int Id { get; set; }
        
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Order> orders { get; set; }
    }
}
