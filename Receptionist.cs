using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Receptionist : Employee
    {
        public string WorkStatus { get; set; }

        public Receptionist()
        {
    
            WorkStatus = "On Phone";
            Salary = 45000;
            PaidStatus = false;
        }

        public Receptionist(string name, int id, string workStatus)
        {
            Name = name;
            EmployeeNumber = id;
            WorkStatus = workStatus;
            Salary = 45000;
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

