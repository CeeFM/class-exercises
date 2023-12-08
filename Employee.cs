using System;
using System.Reflection.Metadata.Ecma335;

namespace Classes
{
    public class Employee
    {

        // Some readonly properties (let's talk about gets, baby)
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

        public Employee(string firstname, string lastname, string title, DateTime startdate) {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
            StartDate = startdate;
        }

    }
}