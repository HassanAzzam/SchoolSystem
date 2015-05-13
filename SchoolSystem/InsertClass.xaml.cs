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
    /// Interaction logic for InsertClass.xaml
    /// </summary>
    public partial class InsertClass : UserControl
    {
        DataLayer Data;
        public InsertClass()
        {
            InitializeComponent();
            Data = DataLayer.GetInstance();
        }

        private void AddStudent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bool Duplication = false;
            foreach(string ID in Data.ClassLocation.Keys)
            {
                if (ID == ClassID.Text) Duplication = true;
            }
            if (!Duplication) //if no duplication
            {
                Data.ClassLocation.Add(ClassID.Text,Location.Text);
                Data.ExportClasses();
                RespondMessage.Text = "Class has been added Successfully!";
                RespondMessage.Foreground = (Brush)new BrushConverter().ConvertFrom("#FF008312"); //Green
            }
            else
            {
                RespondMessage.Text = "Class already exists!";
                RespondMessage.Foreground = (Brush)new BrushConverter().ConvertFrom("#FFC90000"); //Red
            }
            RespondMessage.Visibility = Visibility.Visible;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox S = sender as TextBox;
            RespondMessage.Visibility = Visibility.Hidden;
        }

    }
}
