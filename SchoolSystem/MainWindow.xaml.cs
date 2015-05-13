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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public enum MainWindowState
    {
        InsertStudent,
        SearchMenu,
        InsertClass
    }
    public partial class MainWindow : Window
    {
        MainWindowState State;
        UserControl CurrentControl;
        DataLayer Data;

        public MainWindow()
        {
            InitializeComponent();
            Data = DataLayer.GetInstance();
            CurrentControl = new InsertStudent() { Margin = new Thickness(0, 0, 0, 0), };
            MainGrid.Children.Add(CurrentControl);
            State = MainWindowState.InsertStudent;
        }

        private void Exit_Button(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Tabs_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string CurrentClickedTab = Tabs.CurrentTab;
            if (CurrentClickedTab == "AddButton")
            {
                if(State == MainWindowState.SearchMenu)
                {
                    CurrentControl = new InsertStudent() { Margin = new Thickness(0, 0, 0, 0), };
                    MainGrid.Children.Add(CurrentControl);
                }
                else if (State == MainWindowState.InsertClass)
                {
                    CurrentControl = new InsertStudent() { Margin = new Thickness(0, 0, 0, 0), };
                    MainGrid.Children.Add(CurrentControl);
                }
                State = MainWindowState.InsertStudent;
            }
            else if (CurrentClickedTab == "AddClass")
            {
                if (State == MainWindowState.SearchMenu)
                {
                    CurrentControl = new InsertClass() { Margin = new Thickness(0, 0, 0, 0), };
                    MainGrid.Children.Add(CurrentControl);
                }
                else if (State == MainWindowState.InsertStudent)
                {
                    CurrentControl = new InsertClass() { Margin = new Thickness(0, 0, 0, 0), };
                    MainGrid.Children.Add(CurrentControl);
                }
                State = MainWindowState.InsertClass;

            }
            else
            {
                if (State == MainWindowState.InsertStudent)
                {
                    CurrentControl = new SearchControl() { Margin = new Thickness(0, 0, 0, 0), };
                    MainGrid.Children.Add(CurrentControl);
                }
                else if (State == MainWindowState.InsertClass)
                {
                    CurrentControl = new SearchControl() { Margin = new Thickness(0, 0, 0, 0), };
                    MainGrid.Children.Add(CurrentControl);
                }
                State = MainWindowState.SearchMenu;
            }
        }
    }
}
