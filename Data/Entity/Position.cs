using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
    public class Position
    {
        public int Id { get; set; }
        public string Pasition_Name { get; set; }
        public List<Employee> employees { get; set; }
    }
}
