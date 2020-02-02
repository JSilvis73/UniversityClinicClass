using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Janitor : Employee
    {
        public bool IsSweeping { get; set; }

        public Janitor() : base()
        {
            Name = "Rick";
            EmployeeNumber = 4;
            IsSweeping = true;
            Salary = 40000;
        }

    }
}
