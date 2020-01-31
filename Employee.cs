using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Employee
    {
    List<Employee> allEmployees = new List<Employee>();
        public string Name { get; set;}
        public int EmployeeNumber { get; set;}
        public int Salary { get; set;}
        public bool PaidStatus { get; set;}
        public Employee()
        {
            PaidStatus = false;
        }

        public Employee(string name, int employeeNumber, bool paidStatus)
        {
         Name = name;
         EmployeeNumber = employeeNumber;
         PaidStatus = paidStatus;

        }
        public virtual void PayEmployee()
        {
           PaidStatus = true;
        }

    }
}
