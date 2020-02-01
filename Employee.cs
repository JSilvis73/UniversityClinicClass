using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Employee
    {
        public string Name { get; set;}
        public int EmployeeNumber { get; set;}
        public int Salary { get; set;}
        public bool PaidStatus { get; set;}

        public List<Employee> employees = new List<Employee>()
        {
         new Doctor() { Name= "Dr.Dre", EmployeeNumber= 1},
         new Nurse() { Name= "Nurse Joy", EmployeeNumber= 2},
         new Receptionist() { Name= "Margaret", EmployeeNumber= 3},
         new Janitor() {Name="Pat", EmployeeNumber=4}

            };

        public void ViewInfo()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].Name +"   "+ employees[i].EmployeeNumber +"  "+ employees[i].Salary +"  "+ employees[i].PaidStatus);
            }
        }

        public Employee()
        {
            PaidStatus = false;
        }


        
        public Employee(string name, int employeeNumber, bool paidStatus, int salary)
        {
         Name = name;
         EmployeeNumber = employeeNumber;
         PaidStatus = paidStatus;
            Salary = salary;

        }


       

        public virtual bool PayEmployee()
        {
           PaidStatus = true;
           return PaidStatus;
        }

    
        public virtual void PayAllEmployees()
        {
            //foreach (var employee in employees)
            //{
            //    employee.PaidStatus = true;

            //}
            for (int i = 0; i < employees.Count; i++)
            {

                employees[i].PayEmployee();

                Console.WriteLine(Name,PaidStatus);

            }
        }
    


    }
}
