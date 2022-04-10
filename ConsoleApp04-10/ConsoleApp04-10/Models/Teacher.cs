using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp04_10.Models
{
    class Teacher:Person
    {
        private static int _id;
        private double _experience;
        public int Id { get;}
        public double Experience {
            get => _experience;
            set
            {
                if (value > 0 && value <= 80)
                {
                    _experience = value;
                }
                else throw new Exception();
            }
        }
        public Teacher()
        {
            _id++;
            Id = _id;
        }


        public void TeacherInfo()
        {
            Console.WriteLine($@"Id -->{Id}
            Experience --> {Experience}");
        }

    }
}
