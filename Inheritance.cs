using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillarsOOP.Inheritance
{
    internal class Person
    {
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age => DateTime.Today.Year - BirthDate.Year;
    }

    internal class Teacher : Person
    {
        public Teacher(string firstName, string lastName, DateTime birthDate)
            : base(firstName, lastName, birthDate)
        {
            Disciplines = new List<string>();
        }

        public List<string> Disciplines { get; set; }
    }

    internal class Student : Person
    {
        public Student(int id, string firstName, string lastName, DateTime birthDate)
            : base(firstName, lastName, birthDate)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
