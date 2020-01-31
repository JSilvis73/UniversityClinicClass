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
            IsSweeping = true;
        }



    }
}
