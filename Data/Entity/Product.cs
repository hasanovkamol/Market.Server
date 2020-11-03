using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
   public class Product
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public double  Unit_Price { get; set; }
        public int UnitInStock { get; set; }
        public int UnitInOrder { get; set; }

        public DateTime LastDate { get; set; }
        public DateTime EnterDate { get; set; }

        public int DeliverId { get; set; }
        public Deliver Deliver { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
