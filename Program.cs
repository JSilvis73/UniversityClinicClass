using System;

namespace UniversityClinicClass
{
    class Program
    {

        static void Main(string[] args)
        {
           
            Employee employee = new Employee();

            //string userChoice = Console.ReadLine();

          
                    Console.WriteLine("Main_Menu \n");
                    Console.WriteLine("Press 1 if you would like to view a list of all hospital employees");
                    Console.WriteLine("Press 2 if you would like to pay all employees");
                    Console.WriteLine("Press 3 if you would like all employees to perform their tasks");
                    Console.WriteLine("Press 4 if you would like to check the employees current action");
                    Console.WriteLine("Press 5 if you would like to check the status of the patients");
                    Console.WriteLine("Press 6 if you would like to exit");
                    Console.ReadLine();


                    //switch (userChoice)
                    //{
                    //    case "1":
                    //        employee.ViewInfo();
                    //        break;

                    //    case "2":
                    //        employee.PayAllEmployees();
                    //        break;

                    //    default:
                    //        break;
                    //}

        }
    }
}
