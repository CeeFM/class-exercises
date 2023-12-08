using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("My Company", System.DateTime.Now);
            // Create three employees
            Employee Colin = new Employee("Colin", "Matteson", "Top MothaFuckin Code Boy", System.DateTime.Now);
            Employee Fake = new Employee("Fake", "Ass", "Def The Worst", System.DateTime.Now);
            Employee theWorst = new Employee("The", "Worst", "I dunno this motherfucker does nothing", System.DateTime.Now);
            // Assign the employees to the company
            myCompany.Employees.Add(Colin);
            myCompany.Employees.Add(Fake);
            myCompany.Employees.Add(theWorst);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            myCompany.ListEmployees(myCompany, Colin);
            myCompany.ListEmployees(myCompany, Fake);
            myCompany.ListEmployees(myCompany, theWorst);
        }
    }
}