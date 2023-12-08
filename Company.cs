using System;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string name, DateTime createdon) {
            Name = name;
            CreatedOn = createdon;
            Employees = new List<Employee>();
        }

        public void ListEmployees(Company company, Employee employee)
        {
           Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {company.Name} as a {employee.Title} since {employee.StartDate}");
        }
    }
}