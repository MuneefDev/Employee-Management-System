using System;
using System.Collections.Generic;

namespace oopExample
{
    public partial class Employee
    {
        public string lastName { get; set; }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee oEmployee1 = new Employee();
            oEmployee1.employeeID = 1;
            oEmployee1.employeeName = "Muneef";
            oEmployee1.salary = 2000;
            oEmployee1.departmentName = "sales";
            oEmployee1.lastName = "altamimi";
            oEmployee1.department.departmentID = 3;
            
            
            Employee oEmployee2 = new Employee();
            oEmployee2.employeeID = 2;
            oEmployee2.employeeName = "Ali";
            oEmployee2.salary = 1500;
            oEmployee2.departmentName = "software";
            oEmployee2.lastName = "fjj";
            

            Employee oEmployee3 = new Employee();
            oEmployee3.employeeID = 3;
            oEmployee3.employeeName = "Peter";
            oEmployee3.salary = 1300;
            oEmployee3.departmentName = "security";
            oEmployee3.lastName = "ukks";

            
            //hello this in note to check
            //this is another note
           
        }
    }
}
