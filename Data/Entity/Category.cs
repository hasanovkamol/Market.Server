using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entity
{
   public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Category Name")]
        public string Category_Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Photo Path")]
        public string PhotoPath { get; set; }
        public List<Product> products { get; set; }

    }
}
