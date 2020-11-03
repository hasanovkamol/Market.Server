using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
   public class Employee
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime HireDay { get; set; }
        public string Address { get; set; }
        public string Phone_Nomer { get; set; }
        public string Email { get; set; }
        public string Photo_Path { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }

        public List<Employee> employees { get; set; }

    }
}
