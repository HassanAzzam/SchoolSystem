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
        Student SelectedStudent;
        int LastLine = -1;
        

        public SearchControl()
        {
            InitializeComponent();
            this.Data = DataLayer.GetInstance();
            FillComboBoxes();
        }

        void Display()
        {
            DisplayList.Children.Clear();
            foreach (var Student in Data.StudentList)
            {
                if ((Student.Name == SelectedName.SelectedItem.ToString() || SelectedName.SelectedIndex == 0) && (Student.Year == SelectedYear.SelectedItem.ToString() || SelectedYear.SelectedIndex == 0) && (Student.Class == SelectedClass.SelectedItem.ToString() || SelectedClass.SelectedIndex == 0) && (SelectedLocation.SelectedIndex == 0) || (Data.ClassLocation.ContainsKey(Student.Class) && Data.ClassLocation[Student.Class]==SelectedLocation.SelectedItem.ToString()))
                {
                    DisplayList.Children.Add(new TextBlock() { Text = Student.ID.ToString(), TextAlignment = TextAlignment.Center, Height = 40, Width = 80, FontWeight = FontWeights.Light, FontSize = 24, });
                    DisplayList.Children.Add(new TextBlock() { Text = Student.Name.ToString(), TextAlignment = TextAlignment.Center, Height = 40, Width = 195, FontWeight = FontWeights.Light, FontSize = 24, });
                    DisplayList.Children.Add(new TextBlock() { Text = Student.Year.ToString(), TextAlignment = TextAlignment.Center, Height = 40, Width = 96, FontWeight = FontWeights.Light, FontSize = 24, });
                    DisplayList.Children.Add(new TextBlock() { Text = Student.Class.ToString(), TextAlignment = TextAlignment.Center, Height = 40, Width = 95, FontWeight = FontWeights.Light, FontSize = 24, });
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
                try { Container_Location.Add(Data.ClassLocation[Student.Class]); } catch { }
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

        private void DisplayList_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseLeave();
        }
        
        private void DisplayList_MouseMove(object sender, MouseEventArgs e)
        {

            Point P = Mouse.GetPosition(sender as WrapPanel);
            int Line = (int)P.Y / 40;
            Line *= 4;
            if (LastLine != Line && LastLine!=-1) MouseLeave();
            if (Line >= DisplayList.Children.Count) return;
            
            TextBlock tmp1 = DisplayList.Children[Line] as TextBlock, tmp2 = DisplayList.Children[Line+1] as TextBlock, tmp3 = DisplayList.Children[Line+2] as TextBlock, tmp4 = DisplayList.Children[Line+3] as TextBlock;
            if(LastLine!=Line)
            SelectedStudent = new Student(tmp1.Text, tmp2.Text, tmp3.Text, tmp4.Text);

            LastLine = Line;

            tmp1.Text = "";
            tmp1.Background = TabList.Grey;

            tmp2.Text = "Delete";
            tmp2.TextAlignment = TextAlignment.Right; tmp2.Foreground = TabList.White;
            tmp2.Background = TabList.Grey;
            tmp2.FontWeight = FontWeights.Normal;

            tmp3.Text = "";
            tmp3.Background = TabList.Grey;

            tmp4.Text = "";
            tmp4.Background = TabList.Grey;
            //Thickness Thick = DeleteBlock.Margin;
            //Thick.Top = Line * 40;
            //DeleteBlock.Margin = Thick;
            //DeleteBlock.Visibility = Visibility.Visible;
        }

        private void MouseLeave()
        {
            if (LastLine == -1 || LastLine>=DisplayList.Children.Count) return;
            TextBlock tmp = DisplayList.Children[LastLine] as TextBlock;
            tmp.Text = SelectedStudent.ID; tmp.Background = TabList.White;

            tmp = DisplayList.Children[LastLine + 1] as TextBlock;
            tmp.Text = SelectedStudent.Name; tmp.TextAlignment = TextAlignment.Center; tmp.Foreground = Brushes.Black;
            tmp.Background = TabList.White; tmp.FontWeight = FontWeights.Light;

            tmp = DisplayList.Children[LastLine + 2] as TextBlock;
            tmp.Text = SelectedStudent.Year; tmp.Background = TabList.White;

            tmp = DisplayList.Children[LastLine + 3] as TextBlock;
            tmp.Text = SelectedStudent.Class; tmp.Background = TabList.White;
        }

        private void DisplayList_MouseDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < Data.StudentList.Count; i++)
            {
                if (Data.StudentList[i] == SelectedStudent)
                {
                    Data.StudentList.Remove(Data.StudentList[i]);
                    i--;
                }
            }
            LastLine = -1;
            SelectedStudent = null;

            FillComboBoxes();
            Display();
        }
    }
}
