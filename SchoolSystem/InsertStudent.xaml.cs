using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolSystem
{
    /// <summary>
    /// Interaction logic for InsertControl.xaml
    /// </summary>
    public partial class InsertStudent : UserControl
    {
        DataLayer Data;
       
        public InsertStudent()
        {
            this.Data = DataLayer.GetInstance();
            InitializeComponent();
        }

        private void AddStudent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bool Duplication = false;
            foreach (Student Stud in Data.StudentList)
            {
                if (Stud.ID == StudentID.Text) Duplication = true;
            }
            if (!Duplication) //if no duplication
            {
                Data.StudentList.Add(new Student(StudentID.Text,StudentName.Text,StudentYear.Text,StudentClass.Text));
                RespondMessage.Text = "Student has been added Successfully!";
                RespondMessage.Foreground =(Brush)new BrushConverter().ConvertFrom("#FF008312"); //Green
            }
            else
            {
                RespondMessage.Text = "Student already exists!";
                RespondMessage.Foreground = (Brush)new BrushConverter().ConvertFrom("#FFC90000"); //Red
            }
            RespondMessage.Visibility = Visibility.Visible;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox S = sender as TextBox;

            if (UsedChars > 78)
            {
                S.Text = S.Text.Remove(S.Text.Length - 1);
                S.CaretIndex = S.Text.Length;
            }

            RespondMessage.Visibility = Visibility.Hidden;
        }

        int UsedChars
        {
            get
            {
                return  StudentName.Text.Length + StudentYear.Text.Length + StudentClass.Text.Length + StudentID.Text.Length;
            }
        }
    }
}
