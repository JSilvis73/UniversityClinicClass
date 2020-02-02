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

        public override void ViewInfo()
        {
            base.ViewInfo();
            Console.Write($"{NumOfPatients}");
        }

        public override void DrawBlood(Patient firstPatient)
        {
            firstPatient.BloodLevel -= 6;
            Console.WriteLine($"Nurse Drew Blood and new level is {firstPatient.BloodLevel}");
        }

        public override void CareForPatient(Patient firstPatient)
        {
            firstPatient.HealthStatus = +5;
            Console.WriteLine($"Nurse Drew Blood and new level is {firstPatient.HealthStatus}");
        }
    }


}

