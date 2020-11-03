using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
   public class Category
    {
        public int Id { get; set; }
        public string Category_Name { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public List<Product> products { get; set; }

    }
}
