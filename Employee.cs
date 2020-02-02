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
            employees.Add(new Doctor() {Name = "Dr.Dre", EmployeeNumber = 1, Specialty = "Gyno" });
            employees.Add(new Nurse() { Name = "Nurse Joy", EmployeeNumber = 2, NumOfPatients = 1 });
            employees.Add(new Receptionist() { Name = "Margaret", EmployeeNumber = 3 });
            employees.Add(new Janitor() { Name = "Pat", EmployeeNumber = 4 });
        }


        public virtual void ViewInfo()
        {
                Console.Write($"{EmployeeNumber} {Name} {Salary} {PaidStatus}");
        }


        public void ShowList()
        {
            foreach (Employee employeeList in employees)
            {
                employeeList.ViewInfo();
                Console.WriteLine();
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


    

    }
}
