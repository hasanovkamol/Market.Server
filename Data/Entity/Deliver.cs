using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
   public class Deliver
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Company_Name { get; set; }
        public string Company_Phone { get; set; }
        public string Contat_Name { get; set; }
        public string Contact_Title { get; set; }
        public string Address { get; set; }
        public DateTime Contact_Date { get; set; }
        public List<Product> products { get; set; }

    }
}
