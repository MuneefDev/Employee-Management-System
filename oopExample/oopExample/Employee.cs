using System;
using System.Collections.Generic;
using oopExample.Contract;

namespace oopExample
{
    public partial class Employee : IBusinessLogic
    {

        public Employee()
        { 
            department = new Department();
            Allaownss = new List<Allaowns>();
            vacations = new List<Vacation>();
            Punshments = new List<Punshment>();
        }

        public int employeeID { get; set; }

        public string employeeName { get; set; }
          
        public decimal salary { get; set; }
         
        public string departmentName { get; set; }

        public Department department { get; set; }

        public List<Allaowns> Allaownss { get; set; }

        public List<Vacation> vacations { get; set; }

        public List<Punshment> Punshments { get; set; }

        public void add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void GetDataById()
        {
            throw new NotImplementedException();
        }

        
    }   
}
