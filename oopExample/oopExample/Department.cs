using System;
using System.Collections.Generic;
namespace oopExample
{
    public class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }

        public int departmentID { get; set; }

        public string departmentName { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
