using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Student
    {
        public static int Id = 0;
        public int ID;
        public string Name, Year, Class;

        public Student(string Name, string Year, string Class)
        {
            this.Name = Name;
            this.Year = Year;
            this.Class = Class;
            this.ID = Id;
            Student.Id++;
        }
    }
}
