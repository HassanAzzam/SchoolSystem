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
        InsertMenu,
        SearchMenu
    }
    public partial class MainWindow : Window
    {
        MainWindowState State;
        UserControl CurrentControl;
        DataLayer Data;

        public MainWindow()
        {
            InitializeComponent();
            Data = new DataLayer();
            CurrentControl = new InsertControl(ref Data) { Margin = new Thickness(0, 0, 0, 0), };
            MainGrid.Children.Add(CurrentControl);
            State = MainWindowState.InsertMenu;
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
                    CurrentControl = new InsertControl(ref Data) { Margin = new Thickness(0, 0, 0, 0), };
                    MainGrid.Children.Add(CurrentControl);
                    State = MainWindowState.InsertMenu;
                }
            }
            else
            {
                if (State == MainWindowState.InsertMenu)
                {
                    CurrentControl = new SearchControl(ref Data) { Margin = new Thickness(0, 0, 0, 0), };
                    MainGrid.Children.Add(CurrentControl);
                    State = MainWindowState.SearchMenu;
                }
            }
        }
    }
}
