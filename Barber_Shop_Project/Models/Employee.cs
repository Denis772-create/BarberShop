using System;
using System.Collections.Generic;

#nullable disable

namespace Barber_Shop_Project.Models
{
    public class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public long Id { get; set; }
        public string MobilePhone { get; set; }
        public string Position { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}