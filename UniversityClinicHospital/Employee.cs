using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    class Employee
    {
        string Name;
        int Salary;
        string JobTitle;
        int EmployeeID;

        public Employee(string name, int salary, string jobtitle, int employeeid)
        {
            Name = name;
            Salary = salary;
            JobTitle = jobtitle;
            EmployeeID = employeeid;
        }
        

        public void PaySalary()
        {

            Doctor = 90000; 
            Nurse = 50000;
            Receptionist = 45000;
            Janitor = 40000;
        
        }


    }
}