using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Person
    {
        public string Name;
        public string Surname;
        public byte Age;
        public bool IsMarried;
        public Person()
        {

        }
        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person(byte age,bool ismarried,string name,string surname):this(name,surname)
        {
            Age = age;
            IsMarried = ismarried;

        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($@"Name --> {Name}
            Surname --> {Surname}
            Age --> {Age}
             Is marry --> {IsMarried}");
        }
    }
}
