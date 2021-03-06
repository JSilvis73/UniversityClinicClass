﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Doctor : Employee
    {

        public string Specialty { get; set; }
   
        public Doctor()
        {
            Salary = 90000;
            PaidStatus = false;
        }

        public Doctor(string name, int id, string specialty) 
        {
            Name = name;
            EmployeeNumber = id;
            Specialty = specialty;
            Salary = 90000;
            PaidStatus = false;

        }

        public override void ViewInfo()
        {
            base.ViewInfo();
            Console.Write($"{Specialty}");
        }

        public override void DrawBlood(Patient firstPatient)
        {
            firstPatient.BloodLevel -= 10;
            Console.WriteLine($"Dr. Drew Blood and new level is {firstPatient.BloodLevel}");
        }

        public override void CareForPatient(Patient firstPatient)
        {
            firstPatient.HealthStatus += 10;
            Console.WriteLine($"Dr. Drew Blood and new level is {firstPatient.HealthStatus}");
        }
    }
}
