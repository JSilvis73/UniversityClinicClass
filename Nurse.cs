using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Nurse : Employee
    {
        public int NumOfPatients { get; set; }

        public Nurse()
        {
            Salary = 50000;
            PaidStatus = false;
        }

        public Nurse(string name, int id, int numOfPatients)
        {
            Name = name;
            EmployeeNumber = id;
            NumOfPatients = numOfPatients;
            Salary = 50000;
            PaidStatus = false;
        }



    }
}
