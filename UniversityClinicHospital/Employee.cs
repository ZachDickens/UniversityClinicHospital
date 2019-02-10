using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Employee
    {
        public string Name;
        public int Salary;
        public string JobTitle;
        public int EmployeeID;
        bool paid = false;
        
        public List<Employee> Employees { get; set; }

        public Employee(string name, int employeeid, string jobtitle, int salary)
        {
            Name = name;
            Salary = salary;
            JobTitle = jobtitle;
            EmployeeID = employeeid;

            Employees = new List<Employee>()
            {
                new Employee("Joe", 967, "Doctor", 90000),
                new Employee("Megan", 542, "Nurse", 50000),
                new Employee("Tiffany", 323, "Receptionist", 45000),
                new Employee("Brent", 212, "Janitor", 40000)
            };

        }
        public Employee()
        {

        }
        
        public void PaySalary(string name, int salary, string jobtitle, int employeeid)
        {
            if (paid == true)
            {
                Console.WriteLine("You have already paid all your employees");
            }
            else 
            {               
                Console.WriteLine("You have paid all your employees");
            }
            
            
        }

        public void PrintList()
        {
            Console.WriteLine(" Name | Employee ID | Job Title | Salary");
        }
        // janitor clean up floor in patients room
        // receptionist call doctor for emergency
        // nurse draw blood 
        // doctor draw blood if blood level increases, health decreases
        
        


    }
}