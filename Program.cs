﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    class Program
    {

        public static void Main(string[] args)
        {

            Employee myEmployee = new Employee();
            bool playing = true;

            //Seeed Data here
            myEmployee.CreateEmployeeList();

            //Create a patient
            Patient firstPatient = new Patient();

            while (playing)
            {
                Console.WriteLine("Main_Menu \n");
                Console.WriteLine("Press 1 if you would like to view a list of all hospital employees");
                Console.WriteLine("Press 2 if you would like to pay all employees");
                Console.WriteLine("Press 3 Draw Patient Blood");
                Console.WriteLine("Press 4 Care For Patient");
                Console.WriteLine("Press 5 if you would like to check the status of the patients");
                Console.WriteLine("Press 6 if you would like to exit");
                string userInput = Console.ReadLine();
          
                switch (userInput)
                {
                    case "1":
                        myEmployee.ShowList();
                        break;

                    case "2":
                        myEmployee.PayAllEmployees();
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
