using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp04_10.Models
{
    class Student:Person
    {
        private static int _id;
        public int Id { get; }
        public string[] Lessons { get; set; } = new string[0];

        public Student()
        {
            _id++;
            Id = _id;
        }
    }
}
