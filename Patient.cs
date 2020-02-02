using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    public class Patient
    {

        public int BloodLevel { get; set; }
        public int HealthStatus { get; set; }

        public Patient()
        {
            BloodLevel = 50;
            HealthStatus = 100;
        }

    }
}
