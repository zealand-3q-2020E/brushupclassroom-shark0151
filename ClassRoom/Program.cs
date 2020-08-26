using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom ThisClass = new ClassRoom();
            ThisClass.ClassName = "3Q";
            ThisClass.SemesterStart = new DateTime(2019, 8, 26);
            ThisClass.Students = new List<Student>
            {
                new Student("Alex", 3, 21),
                new Student("Aukse", 8, 17)
            };
        }
    }
}
