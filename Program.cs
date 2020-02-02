using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicClass
{
    class Program
    {

        public static void Main(string[] args)
        {
            //Doctor doctor = new Doctor();
            //Nurse nurse = new Nurse();
            //Receptionist receptionist = new Receptionist();
            //Janitor janitor = new Janitor();
            //Employee employee = new Employee();
            //Employee hospital = new Employee();

            List<Employee> employees = new List<Employee>();
            //employees.Add(doctor);
            //employees.Add(nurse);
            //employees.Add(receptionist);
            //employees.Add(janitor);

            bool playing = true;

            do
            {

                
                Console.WriteLine("Main_Menu \n");
                Console.WriteLine("Press 1 if you would like to view a list of all hospital employees");
                Console.WriteLine("Press 2 if you would like to pay all employees");
                Console.WriteLine("Press 3 if you would like all employees to perform their tasks");
                Console.WriteLine("Press 4 if you would like to check the employees current action");
                Console.WriteLine("Press 5 if you would like to check the status of the patients");
                Console.WriteLine("Press 6 if you would like to exit");
               // Console.WriteLine(employee.GetData());

                
                
                string userInput = Console.ReadLine();
                //Employee employee = new Employee();
                //Employee doctor = new Doctor();
                


                
               
                switch (userInput)
                {
                    case "1":
                       employee.ViewInfo();
                        break;

                    case "2":
                        employee.PayAllEmployees();
                        break;

                    case "3":
                        playing = false;
                        Console.WriteLine("Exiting Program");
                        break;

                    default:
                        break;
                }

            } while (playing);
            
        }
    }
}
