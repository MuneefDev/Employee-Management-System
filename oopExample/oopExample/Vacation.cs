using System;
using System.Collections.Generic;
namespace oopExample
{
    public class Vacation
    {
        public enum VacationTypes
        {
            annual=1,
            Sick,
            Rest
        }
                       

        public Vacation()
        {
            Employees = new List<Employee>();
        }


        public int VacationsId { get; set; }

        public string VacationName { get; set;}

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
