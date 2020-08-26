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

        public string Season()
        {
            if (BirthMonth == 1 || BirthMonth == 2 || BirthMonth == 12)
                return "Winter";
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
                return "Spring";
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
                return "Summer";
            if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
                return "Autumn";
            return "Invalid Data";
        }

    }
}
