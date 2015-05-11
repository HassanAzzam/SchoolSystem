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
    public partial class InsertControl : UserControl
    {
        DataLayer Data;

        public InsertControl(ref DataLayer Data)
        {
            this.Data = Data;
            InitializeComponent();
        }

        private void AddStudent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (true) //if no duplication
            {
                Data.StudentList.Add(new Student(StudentName.Text,StudentYear.Text,StudentClass.Text));
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
            RespondMessage.Visibility = Visibility.Hidden;
        }
    }
}
