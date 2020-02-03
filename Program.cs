using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    class Program
    {

        public static void Main(string[] args)
        {
            Patient fstPatient = new Patient();
            Employee myEmployee = new Employee();
            bool playing = true;

            //Seeed Data here
            myEmployee.CreateEmployeeList();

            //Create a patient
            Patient firstPatient = new Patient();

            while (playing)
            {
                Console.WriteLine("Main_Menu \n");
                Console.WriteLine("Press 1 Display List of Employees");
                Console.WriteLine("Press 2 Pay All Employees");
                Console.WriteLine("Press 3 Draw Patient Blood");
                Console.WriteLine("Press 4 Care For Patient");
                Console.WriteLine("Press 5 Exit Program");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("-----------------------------------------------------");
                        myEmployee.ShowList();
                        break;

                    case "2":
                        myEmployee.PayAllEmployees();
                        Console.WriteLine("All your employees have been paid.");
                        break;



                    case "3":
                        myEmployee.ShowList();
                        myEmployee.SelectEmployeeForBlood(firstPatient);
                        break;

                    case "4":
                        myEmployee.ShowList();
                        myEmployee.SelectEmployeeCareForBlood(firstPatient);
                        break;


                    case "5":
                        playing = false;
                        Console.WriteLine("Exiting Program");
                        break;

                    default:
                        break;
                }

            }

        }
    }
}
