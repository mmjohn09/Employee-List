using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime AcmeCreatedDate = new DateTime(2017, 1, 18);
            Company Acme = new Company("Acme", AcmeCreatedDate);

            Employee Maggie = new Employee()
            {
                FirstName = "Maggie",
                LastName = "Johnson",
                Title = "CEO",
                StartDate = AcmeCreatedDate
            };

            DateTime BobStart = new DateTime(2017, 2, 3);
            Employee Bob = new Employee()
            {
                FirstName = "Bob",
                LastName = "Smith",
                Title = "Engineer",
                StartDate = BobStart
            };

            DateTime BillStart = new DateTime(2019, 5, 21);
            Employee Bill = new Employee()
            {
                FirstName = "Bill",
                LastName = "Jackson",
                Title = "Accountant",
                StartDate = BillStart
            };

            Acme.EmployeeList.Add(Maggie);
            Acme.EmployeeList.Add(Bob);
            Acme.EmployeeList.Add(Bill);

            Acme.ListEmployees();
            
        }
    }
}
