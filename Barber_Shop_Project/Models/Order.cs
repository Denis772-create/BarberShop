using System;
using System.Collections.Generic;

#nullable disable

namespace Barber_Shop_Project.Models
{
    public class Order
    {
        public string HaircutName { get; set; }
        public long Id { get; set; }
        public string UsersId { get; set; }
        public long EmployeesId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateOfRecording { get; set; }

        public virtual Employee Employees { get; set; }
        public virtual User Users { get; set; }
    }
}