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
        public void SetName(string NewName)
        {
            Name = NewName;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetBirthDay(int Day)
        {
            //should verify the actual date exists
            BirthDay = Day;
        }

        public int GetBirthDay()
        {
            return BirthDay;
        }

        public void SetBirthMonth(int Month)
        {
            BirthMonth = Month;
        }

        public int GetBirthMonth()
        {
            return BirthMonth;
        }

    }
}
