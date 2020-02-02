using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Employee
    {
        Doctor doctor = new Doctor();
        Nurse nurse = new Nurse();
        Receptionist receptionist = new Receptionist();
        Janitor janitor = new Janitor();
        Employee employee = new Employee();

        public List<Employee> employees = new List<Employee>();
        //employees.Add(doctor);
        //    employees.Add(nurse);
        //    employees.Add(receptionist);
        //    employees.Add(janitor);


        public string name;
        public int employeeNumber;
        public int salary;
        public bool paidStatus;




        public Employee(string name, int employeeNumber, int salary, bool paidStatus)
        {
            this.name = name;
            this.employeeNumber = employeeNumber;
            this.salary = salary;
            paidStatus = false;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public bool PaidStatus
        {
            get { return paidStatus; }
            set { paidStatus = false; }
        }




        //Employee[] employees = new Employee[4];

        //Employee[] customClassArray;

        //Employee[] employees = new Employee[4];







        //{
        // new Doctor() { Name= "Dr.Dre", EmployeeNumber= 1},
        // new Nurse() { Name= "Nurse Joy", EmployeeNumber= 2},
        // new Receptionist() { Name= "Margaret", EmployeeNumber= 3},
        // new Janitor() {Name="Pat", EmployeeNumber=4}

        // };

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

        public Employee()
        {
            PaidStatus = false;
        }



        //public Employee(string name, int employeeNumber, bool paidStatus, int salary)
        //{
        // Name = name;
        // EmployeeNumber = employeeNumber;
        // PaidStatus = paidStatus;
        //    Salary = salary;

        //}




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
