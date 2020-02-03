using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Janitor : Employee
    {
        public string WorkStatus { get; set; }

        public Janitor()
        {
            WorkStatus = "Is Sweeping";
            Salary = 40000;
            PaidStatus = false;
        }

        public Janitor(string name, int id, string workStatus)
        {
            Name = name;
            EmployeeNumber = id;
            WorkStatus = workStatus;
            Salary = 40000;
            PaidStatus = false;
        }

        public override void ViewInfo()
        {
            base.ViewInfo();
            Console.Write($"{WorkStatus}");
        }

        public override void DrawBlood(Patient firstPatient)
        {
            Console.WriteLine("An Employee can't draw Blood.");
        }

        public override void CareForPatient(Patient firstPatient)
        {
            Console.WriteLine("An Employee can't care for patient.");
        }

    }
}
