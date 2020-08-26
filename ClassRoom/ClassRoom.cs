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
            string Output = "This Classroom is " + ClassName + "\n" + "Students are: \n";
            foreach(Student x in Students)
            {
                Output += x.GetName() + "\n";
            }
            return Output;
        }
    }
}
