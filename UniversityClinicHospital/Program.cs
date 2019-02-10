using System;

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
            PerformActivitiesMenu();
        }
        
        public static void PerformActivitiesMenu()
        {
            //Nurse = draw blood or give medicine  or call 
            //doctor = draw blood or give medicine or call
            //receptionist = call 
            //janitor = sweep
            // doctor is 1, nurse is 2, receptionist is 3, janitor is 4
            string userInput;
            bool running = true;

            while (running)
            {

                Console.WriteLine("What do you want to do?");
                userInput = Console.ReadLine();

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

                    default:
                        Console.WriteLine("Invalid response please choose option one");
                        break;
                }

            }
            

                
               
        }


    }

}
