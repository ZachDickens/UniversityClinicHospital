using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        //use bool for sweeping or not
        bool sweeping = false;
        public Janitor()
        {
            Salary = 40000;
            Name = "Brent";
            EmployeeID = 212;
            JobTitle = "Janitor";
        }

        public void JanitorIsSweeping()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 2);
            if (number == 1)
            {
                sweeping = true;
                Console.WriteLine("The Janitor is busy sweeping right now");
            }
            else
            {
                sweeping = false;
                Console.WriteLine("The Janitor is not sweeping right now");
            }
        }
    }
}
