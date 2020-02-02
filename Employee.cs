using System;
using System.Collections.Generic;

namespace UniversityClinicClass
{
    public class Employee
    {

        public List<Employee> employees = new List<Employee>();
        //employees.Add(doctor);
        //    employees.Add(nurse);
        //    employees.Add(receptionist);
        //    employees.Add(janitor)

        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public int Salary { get; set; }
        public bool PaidStatus { get; set; }


        public Employee()
        {
            PaidStatus = false;
        }


        public Employee(string name, int employeeNumber, int salary, bool paidStatus)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = salary;
            PaidStatus = false;

        }


        public void CreateEmployeeList()
        {
            employees.Add(new Doctor() { Name = "Dr.Dre", EmployeeNumber = 1 });
            employees.Add(new Nurse() { Name = "Nurse Joy", EmployeeNumber = 2 });
            employees.Add(new Receptionist() { Name = "Margaret", EmployeeNumber = 3 });
            employees.Add(new Janitor() { Name = "Pat", EmployeeNumber = 4 });
        }

        //Employee[] employees = new Employee[4];

        //Employee[] customClassArray;

        //Employee[] employees = new Employee[4];




        public void ViewInfo()
        {
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employees);
            //}
            //employee.Name + "   " + employee.EmployeeNumber + "  " + employee.Salary + "  " + employee.PaidStatus

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].Name + "   " + employees[i].EmployeeNumber + "  " + employees[i].Salary + "  " + employees[i].PaidStatus);
            }
        }

     





        public virtual void PayEmployee()
        {
            PaidStatus = true;
        }


        public virtual void PayAllEmployees()
        {
            //foreach (var employee in employees)
            //{
            //    employee.PaidStatus = true;

            //}
            //for (int i = 0; i < employees.Count; i++)
            //{

            //    employees[i].PayEmployee();

            //    Console.WriteLine(Name,PaidStatus);

            //}

        }
        public string GetData()
        {
            return this.Name + "  " + this.EmployeeNumber + "  " + this.Salary + "  " + PaidStatus;
        }

    

    }
}
