using System;
using System.Collections.Generic;
namespace oopExample
{
    public class Allaowns
    {
        public Allaowns()
        {
            Employees = new List<Employee>();
        }

        public int  Id { get; set; }

        public string AllowandName  { get; set; }

        public decimal AllowanceValue { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
