using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class DataLayer
    {
        public List<Student> StudentList;
        public Dictionary<string, string> ClassLocation;

        public DataLayer()
        {
            StudentList = new List<Student>();
            ClassLocation = new Dictionary<string, string>();
            //Import data from files
            Import();
            //
            //StudentList.Add(new Student("ASD", 2, 3));
            //StudentList.Add(new Student("BSD", 3, 5));
            //
        }

        void Import() //Read from files
        {

        }

        void Export() //Write in files
        {

        }
    }
}
