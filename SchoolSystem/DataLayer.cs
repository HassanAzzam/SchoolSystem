using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections;

namespace SchoolSystem
{
    public class DataLayer
    {
        public ObservableCollection<Student> StudentList;
        public Dictionary<string, string> ClassLocation;
        static DataLayer Instance;

        private DataLayer()
        {
            StudentList = new ObservableCollection<Student>();
            StudentList.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(StudentList_Changed);
            ClassLocation = new Dictionary<string, string>();
            //Import data from files
            Import();
        }

        private void StudentList_Changed(object sender, EventArgs e)
        {
            ExportStudents();
        }

        public static DataLayer GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DataLayer();
            }
            return Instance;
        }

        void Import() //Read from files
        {
            FileStream file;
            string Records;

            #region  Classes and Location

            try { file = new FileStream(@"F:\Classes.txt", FileMode.Open); } catch { goto Student; }
            StreamReader SR = new StreamReader(file);
            Records = SR.ReadToEnd();
            for(int i = 0; i < Records.Length; i += 25)
            {
                string Record = Records.Substring(i, 25);

                string ID = Record.Substring(0, 5);
                try { ID = ID.Substring(0, ID.IndexOf('\0')); } catch { }

                string Location = Record.Substring(5, 20);
                try { Location = Location.Substring(0, Location.IndexOf('\0')); } catch { }

                ClassLocation.Add(ID, Location);

            }
            SR.Close();
            file.Close();

        #endregion

        Student:
            #region Student

            try { file = new FileStream(@"F:\Students.txt", FileMode.Open); } catch { return; }
            SR = new StreamReader(file);
            Records = SR.ReadToEnd();
            for(int i = 0; i < Records.Length; i+=100)
            {
                int RealRecord_Len = Records.Substring(i, 100).IndexOf('\0');

                string[] Line;
                Line = Records.Substring(i, RealRecord_Len).Split(',');
                Line[0] = Line[0].Substring(3);
                Line[1] = Line[1].Substring(5);
                Line[2] = Line[2].Substring(5);
                Line[3] = Line[3].Substring(6);

                StudentList.Add(new Student(Line[0], Line[1], Line[2], Line[3]));
            }
            SR.Close();
            file.Close();

            #endregion
        }

        private void ExportStudents() //Write in files
        {
            FileStream file;
            try { File.Delete(@"F:\Students.txt"); } catch { }
            try { file = new FileStream(@"F:\Students.txt", FileMode.Append); } catch { return; }
            StreamWriter SW = new StreamWriter(file);
            foreach (Student Stud in StudentList)
            {
                string Line = "ID=" + Stud.ID + ",Name=" + Stud.Name + ",Year=" + Stud.Year + ",Class=" + Stud.Class;
                while (Line.Length < 100) Line += "\0";
                SW.Write(Line);
            }
            SW.Close();
            file.Close();
            
        }

        public void ExportClasses() //Write in files
        {
            try { File.Delete(@"F:\Classes.txt"); } catch { }
            FileStream file = new FileStream(@"F:\Classes.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(file);
            foreach (var Class in ClassLocation)
            {
                string ID = Class.Key, Location = Class.Value;
                while (ID.Length < 5) ID += "\0";
                while (Location.Length < 20) Location += "\0";
                SW.Write(ID);
                SW.Write(Location);
            }
            SW.Close();
            file.Close();

        }

    }
}
