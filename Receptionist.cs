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
            OnPhone = true;
        }



    }
}
