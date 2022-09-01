using System;
using System.Collections.Generic;
namespace oopExample
{
    public class Punshment
    {
        public Punshment()
        {
            Employees = new List<Employee>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal value { get; set; }

        public DateTime Date { get; set; }

        public List<Employee> Employees { get; set; } 

    }
}
