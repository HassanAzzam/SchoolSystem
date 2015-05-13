using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Student
    {
        public string ID;
        public string Name, Year, Class;
        const int Max_Len = 100;

        public Student(string Id, string Name, string Year, string Class)
        {
            this.Name = Name;
            this.Year = Year;
            this.Class = Class;
            this.ID = Id;
        }
        
        static public bool operator==(Student A, Student B)
        {
            if (A.ID == B.ID && A.Name == B.Name && A.Year == B.Year && A.Class == B.Class)
                return true;
            return false;
        }

        static public bool operator !=(Student A, Student B)
        {
            if (A.ID != B.ID || A.Name != B.Name || A.Year != B.Year || A.Class != B.Class)
                return true;
            return false;
        }
    }
}
