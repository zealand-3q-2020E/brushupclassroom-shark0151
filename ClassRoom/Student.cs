using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Student
    {
        private string Name;
        private int BirthMonth;
        private int BirthDay;

        public Student()
        { }
        public Student(string NewName, int NewMonth, int NewDay)
        {
            Name = NewName;
            BirthMonth = NewMonth;
            BirthDay = NewDay;
        }
        protected void SetName(string NewName)
        {
            Name = NewName;
        }

        protected string GetName()
        {
            return Name;
        }

        protected void SetBirthDay(int Day)
        {
            //should verify the actual date exists
            BirthDay = Day;
        }

        protected int GetBirthDay()
        {
            return BirthDay;
        }

        protected void SetBirthMonth(int Month)
        {
            BirthMonth = Month;
        }

        protected int GetBirthMonth()
        {
            return BirthMonth;
        }

    }
}
