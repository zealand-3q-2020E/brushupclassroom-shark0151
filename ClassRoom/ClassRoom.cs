using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassRoom
{
    class ClassRoom
    {
        public string ClassName;
        public List<Student> Students;
        public DateTime SemesterStart;
        public ClassRoom()
        { }

        public override string ToString()
        {
            string Output = "This Classroom is " + ClassName +" Starting in: " + SemesterStart + "\n" + "Students are: \n";
            foreach(Student x in Students)
            {
                Output += x.GetName() + "\n";
            }
            return Output;
        }

        public void Seasons()
        {
            int Spring = 0;
            int Summer = 0;
            int Autumn = 0;
            int Winter = 0;
            foreach (Student x in Students)
            {
                if (x.Season() == "Spring")
                    Spring++;
                if (x.Season() == "Summer")
                    Summer++;
                if (x.Season() == "Autumn")
                    Autumn++;
                if (x.Season() == "Winter")
                    Winter++;
            }
            Console.WriteLine("Spring: " + Spring + "\n");
            Console.WriteLine("Summer: " + Summer + "\n");
            Console.WriteLine("Autumn: " + Autumn + "\n");
            Console.WriteLine("Winter: " + Winter + "\n");
        }
    }
}
