using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Nurse : Employee
    {
        public int NumOfPatients { get; set; }

        public Nurse() : base()
        {
            NumOfPatients = 5;
        }



    }
}
