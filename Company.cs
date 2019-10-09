using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> EmployeeList = new List<Employee>();
        public Company(string name, DateTime companyCreatedDate)
        {
            Name = name;
            CreatedOn = companyCreatedDate;
        }
        public void ListEmployees()
        {
            Console.WriteLine("Acme Employee List");
            Console.WriteLine("-----------------");
            foreach (Employee employee in EmployeeList)
            {

                Console.WriteLine($"{employee.FirstName} {employee.LastName} || Start Date: {employee.StartDate}");
            }
        }
    }
}


