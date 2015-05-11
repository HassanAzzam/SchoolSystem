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
    /// Interaction logic for SearchControl.xaml
    /// </summary>
    public partial class SearchControl : UserControl
    {
        DataLayer Data;

        public SearchControl(ref DataLayer Data)
        {
            InitializeComponent();
            this.Data = Data;
            FillComboBoxes();
        }

        void Display()
        {
            DisplayList.Children.Clear();
            foreach (var Student in Data.StudentList)
            {
                if ((Student.Name == SelectedName.SelectedItem.ToString() || SelectedName.SelectedIndex == 0) && (Student.Year == SelectedYear.SelectedItem.ToString() || SelectedYear.SelectedIndex == 0) && (Student.Class == SelectedClass.SelectedItem.ToString() || SelectedClass.SelectedIndex == 0) && (Data.ClassLocation[Student.Class]==SelectedClass.SelectedItem.ToString()|| SelectedLocation.SelectedIndex == 0))
                {
                    DisplayList.Children.Add(new TextBlock() { Text = Student.ID.ToString(), TextAlignment = TextAlignment.Center, Height = 40, Width = 80, FontWeight = FontWeights.Light, FontSize = 24, });
                    DisplayList.Children.Add(new TextBlock() { Text = Student.Name.ToString(), TextAlignment = TextAlignment.Center, Height = 40, Width = 195, FontWeight = FontWeights.Light, FontSize = 24, });
                    DisplayList.Children.Add(new TextBlock() { Text = Student.Year.ToString(), TextAlignment = TextAlignment.Center, Height = 40, Width = 95.5, FontWeight = FontWeights.Light, FontSize = 24, });
                    DisplayList.Children.Add(new TextBlock() { Text = Student.Class.ToString(), TextAlignment = TextAlignment.Center, Height = 40, Width = 95.5, FontWeight = FontWeights.Light, FontSize = 24, });
                }
            }
        }

        void FillComboBoxes()
        {
            
            HashSet<string> Container_Name, Container_Year, Container_Location, Container_Class;
            Container_Class = new HashSet<string>();
            Container_Location = new HashSet<string>();
            Container_Name = new HashSet<string>();
            Container_Year = new HashSet<string>();

            Container_Name.Add("Any");
            Container_Year.Add("Any");
            Container_Class.Add("Any");
            Container_Location.Add("Any");
            

            foreach (var Student in Data.StudentList)
            {
                Container_Name.Add(Student.Name);
                Container_Location.Add(Data.ClassLocation[Student.Class]);
                Container_Year.Add(Student.Year);
                Container_Class.Add(Student.Class);
            }
 
            SelectedName.ItemsSource = Container_Name;
            SelectedLocation.ItemsSource = Container_Location;
            SelectedYear.ItemsSource = Container_Year;
            SelectedClass.ItemsSource = Container_Class;

            SelectedClass.SelectedIndex = 0;
            SelectedYear.SelectedIndex = 0;
            SelectedLocation.SelectedIndex = 0;
            SelectedName.SelectedIndex = 0;
        }

        private void Refresh(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedName.SelectedIndex >= 0 && SelectedLocation.SelectedIndex >= 0 && SelectedYear.SelectedIndex >= 0 && SelectedClass.SelectedIndex >= 0)
            {
                Display();
            }
        }
    }
}
