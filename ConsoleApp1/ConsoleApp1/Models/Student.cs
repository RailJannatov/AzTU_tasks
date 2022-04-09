using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Student:Person
    {
        public string Degree;
        public bool IsHigh;


        public Student(string degree,bool isHigh,string name,string surname,byte age,bool ismarried) :base(age,ismarried,name,surname)
        {
            Degree = degree;
            IsHigh = isHigh;
        }
       public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($@"Degree --> {Degree}
            Is high --> {IsHigh}");
        }

    }
}
