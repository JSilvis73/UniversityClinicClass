using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist() : base()
        {
            Name = "Pam";
            EmployeeNumber = 3;
            OnPhone = true;
            Salary = 45000;
        }



    }
}
