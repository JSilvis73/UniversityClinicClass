using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Janitor : Employee
    {
        public bool IsSweeping { get; set; }

        public Janitor()
        {
            IsSweeping = true;
            Salary = 40000;
            PaidStatus = false;
        }

        public Janitor(string name, int id)
        {
            Name = name;
            EmployeeNumber = id;
            IsSweeping = true;
            Salary = 40000;
            PaidStatus = false;
        }

        public override void ViewInfo()
        {
            base.ViewInfo();
            Console.Write($"{IsSweeping}");
        }

        public override void DrawBlood(Patient firstPatient)
        {
            Console.WriteLine("An Employee can't draw Blood.");
        }
    }
}
