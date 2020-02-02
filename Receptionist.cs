using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist()
        {
    
            OnPhone = true;
            Salary = 45000;
            PaidStatus = false;
        }

        public Receptionist(string name, int id )
        {
            Name = name;
            EmployeeNumber = id;
            OnPhone = true;
            Salary = 45000;
            PaidStatus = false;
        }


        public override void ViewInfo()
        {
            base.ViewInfo();
            Console.Write($"{OnPhone}");
        }


        public override void DrawBlood(Patient firstPatient)
        {
            Console.WriteLine("An Employee can't draw Blood.");
        }
    }
}

