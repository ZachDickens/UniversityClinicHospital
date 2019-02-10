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
                paid = true;
            }
            
            
        }

        
        // janitor clean up floor in patients room
        // receptionist call doctor for emergency
        // nurse draw blood 
        // doctor draw blood if blood level increases, health decreases
        
        public void PrintEmployee(Employee X)
        {
            Console.WriteLine("{0} {1} {2} {3}", X.Name, X.EmployeeID, X.JobTitle, X.Salary);

        }


    }
}