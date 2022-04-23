using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Student
    {

        public Student()
        {
            
        }

        public Student(int id, string name, string surname)
        {
            StudentId = id;
            FirstName = name;
            LastName = surname;
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}