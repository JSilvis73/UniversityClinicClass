using System;
using System.Collections.Generic;

namespace UniversityClinicClass
{
    public class Employee
    {

        public List<Employee> employees = new List<Employee>();

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
            employees.Add(new Doctor() {Name = "Dr.Dre", EmployeeNumber = 1, Specialty = "Diagnosing Patient | Specialty: Gyno" });
            employees.Add(new Nurse() { Name = "Nurse Joy", EmployeeNumber = 2, WorkStatus = "Taking care of 1 Patient" });
            employees.Add(new Receptionist() { Name = "Margaret", EmployeeNumber = 3 });
            employees.Add(new Janitor() { Name = "Pat", EmployeeNumber = 4 });
        }


        public virtual void ViewInfo()
        {
                Console.Write($"|Employees ID: {EmployeeNumber}| Employee Name: {Name}| Salary:{Salary}| Paid Status: {PaidStatus}|Work Status: ");
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

        public void PayAllEmployees()
        {
            foreach (Employee employeeList in employees)
            {
                employeeList.PayEmployee();

            }

        }

        public void SelectEmployeeForBlood(Patient firstPatient)
        {
            Console.WriteLine("Pick an employee to draw blood");
            string input = Console.ReadLine();
            int userChoice = Convert.ToInt32(input);
            Employee selectedEmployee = employees[userChoice - 1];
            Console.WriteLine(selectedEmployee.Name);
            selectedEmployee.DrawBlood(firstPatient);

        }


        public virtual void DrawBlood(Patient firstPatient)
        {
            Console.WriteLine("An Employee can't draw Blood.");
        }

        public void SelectEmployeeCareForBlood(Patient firstPatient)
        {
            Console.WriteLine("Pick an employee to draw blood");
            string input = Console.ReadLine();
            int userChoice = Convert.ToInt32(input);
            Employee selectedEmployee = employees[userChoice - 1];
            Console.WriteLine(selectedEmployee.Name);
            selectedEmployee.CareForPatient(firstPatient);
         

        }


        public virtual void CareForPatient(Patient firstPatient)
        {
            Console.WriteLine("An Employee can't care for a Patient.");
        }



    }
}
