using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }

        public Doctor() : base()
        {
            Specialty = "Gynecologist";
        }



    }
}
