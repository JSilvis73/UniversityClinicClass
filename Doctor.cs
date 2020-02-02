using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        

        public Doctor() 
        {
            Name = "Dr. Dre";
            EmployeeNumber = 1;
            Specialty = "Gynecologist";
            Salary = 90000;

        }
        



    }
}
