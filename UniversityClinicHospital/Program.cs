using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Program 
    {
        
        public static void Main(string[] args) 
        {
            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Receptionist receptionist = new Receptionist();
            Janitor janitor = new Janitor();
            Employee employee = new Employee();
            Patient patient = new Patient(20, 10);
            List<Employee> Employees = new List<Employee>()

            {
                new Employee("Joe", 967, "Doctor", 90000),
                new Employee("Megan", 542, "Nurse", 50000),
                new Employee("Tiffany", 323, "Receptionist", 45000),
                new Employee("Brent", 212, "Janitor", 40000)
            };

            PerformActivitiesMenu( doctor, nurse, receptionist, janitor, Employees, patient);
            
            
        }
        
        public static void PerformActivitiesMenu(Doctor doctor, Nurse nurse, Receptionist receptionist, Janitor janitor, List<Employee> Employees, Patient patient)
        {
            //Nurse = draw blood or give medicine  or call 
            //doctor = draw blood or give medicine or call
            //receptionist = call 
            //janitor = sweep
            // doctor is 1, nurse is 2, receptionist is 3, janitor is 4

            //welcome to university hospital directory
            //
            
            string userInput;
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the University Clinic Hospital Staff Directory");

                PrintList(Employees);

                Console.WriteLine("Press 1 to select an employee to interact with");
                Console.WriteLine("Press 2 to pay all the employees");
                Console.WriteLine("Press 0 to close the program");
                
                userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Press 1 for Doctor " +
                                          "Press 2 for Nurse " +
                                          "Press 3 for Receptionist " +
                                          "Press 4 for Janitor ");

                        userInput = Console.ReadLine();                    
                        if (userInput == "1")
                        {
                            Console.WriteLine("You have chosen Doctor");
                            Console.WriteLine("Press 1 to draw blood" +
                                              "Press 2 to give medicine" +
                                              "Press 3 to call a doctor to report to the emergency room");
                            userInput = Console.ReadLine();
                            if (Console.ReadLine() == "1")
                            {
                                Console.ReadLine();
                                Console.WriteLine("The Doctor has drawn the patient's blood");
                                

                            }
                            if (Console.ReadLine() == "2")
                            {
                                Console.WriteLine("The Doctor has given the patient medicine");
                            }
                            if (Console.ReadLine() == "3")
                            {
                                Console.WriteLine("The Doctor calls a doctor to the emergency room");
                            }

                        }
                        if (Console.ReadLine() == "2")
                        {
                            Console.WriteLine("You have chosen Nurse");
                            Console.WriteLine("Press 1 to draw blood" +
                                              "Press 2 to give medicine" +
                                              "Press 3 to call a doctor to report to the emergency room");
                            
                            if (Console.ReadLine() == "1")
                            {
                                Console.WriteLine("The Nurse has drawn the patient's blood");
                            }
                            if (Console.ReadLine() == "2")
                            {
                                Console.WriteLine("The Nurse has given the patient medicine");
                            }
                            if (Console.ReadLine() == "3")
                            {
                                Console.WriteLine("The Nurse calls a doctor to the emergency room");

                            }


                        }
                        if (Console.ReadLine() == "3")
                        {
                            Console.WriteLine("You have chosen Receptionist");
                            Console.WriteLine("Press 1 to call a doctor to report to the emergency room");
                            
                            if (Console.ReadLine() == "1")
                            {
                                Console.WriteLine("The Receptionist calls a doctor to the emergency room");
                            }
                        }
                        if (Console.ReadLine() == "4")
                        {
                            Console.WriteLine("You have chosen Janitor");
                            Console.WriteLine("Press 1 to sweep the emergency room floor");
                            
                            if (Console.ReadLine() == "1")
                            {
                                Console.WriteLine("The Janitor has swept the emergency room floor");
                            }
                        }
                        break;

                    case "2":

                        Console.WriteLine("You have paid all of the employees");

                        break;

                    case "0":
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Invalid response please choose option one");
                        break;
                }

            }
            

                
               
        }

        public static void PrintList(List<Employee> employee)
        {
            Console.WriteLine(" Name | Employee ID | Job Title | Salary");
            foreach (Employee e in employee)
            {

                e.PrintEmployee(e);

            }

        }
        // janitor clean up floor in patients room
        // receptionist call doctor for emergency
        // nurse draw blood 
        // doctor draw blood if blood level increases, health decreases

        
        
    }

}
