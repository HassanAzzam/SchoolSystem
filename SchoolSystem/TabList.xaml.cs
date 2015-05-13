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
using System.Threading;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolSystem
{
    /// <summary>
    /// Interaction logic for TabList.xaml
    /// </summary>
    public partial class TabList : UserControl
    {
        Thickness SelectedTab_Margin;
        TextBlock SelectedTab;
        public static Brush Grey;
        public static Brush White = (Brush)new BrushConverter().ConvertFrom("#FFEAEAEA");
        double M;
        Thread Switcher;

        public TabList()
        {
            InitializeComponent();
            SelectedTab_Margin = AddButton.Margin;
            M = Highlighter.Margin.Left;
            Grey = (Brush)(new BrushConverter().ConvertFrom("#FF1F1F1F"));
            Switcher = new Thread(Animate);
        }

        private void Tab_Click(object sender, MouseButtonEventArgs e)
        {
            TextBlock Tab = sender as TextBlock;
            SelectedTab = Tab;
            SelectedTab_Margin = SelectedTab.Margin;

            Switcher = new Thread(Animate);
            Switcher.Start();


            if (Tab.Name == "AddButton")
            {
                Plus1.Fill = Brushes.White;
                Plus2.Fill = Brushes.White;
                AddButton.Foreground = Brushes.White;

                Lens1.Fill = Grey;
                Lens2.Stroke = Grey;
                Lens2.Fill = Brushes.White;
                SearchButton.Foreground = Grey;

                Plus21.Fill = Grey;
                Plus22.Fill = Grey;
                AddClass.Foreground = Grey;
            }
            else if (Tab.Name == "AddClass")
            {
                Plus1.Fill = Grey;
                Plus2.Fill = Grey;
                AddButton.Foreground = Grey;

                Lens1.Fill = Grey;
                Lens2.Stroke = Grey;
                Lens2.Fill = Brushes.White;
                SearchButton.Foreground = Grey;

                Plus21.Fill = Brushes.White;
                Plus22.Fill = Brushes.White;
                AddClass.Foreground = Brushes.White;
            }
            else
            {
                Plus1.Fill = Grey;
                Plus2.Fill = Grey;
                AddButton.Foreground = Grey;

                Lens1.Fill = Brushes.White;
                Lens2.Stroke = Brushes.White;
                Lens2.Fill = Grey;
                SearchButton.Foreground = Brushes.White;

                Plus21.Fill = Grey;
                Plus22.Fill = Grey;
                AddClass.Foreground = Grey;
            }
        }

        void Animate()
        {
            while(M != SelectedTab_Margin.Left)
            {
                M += (SelectedTab_Margin.Left - M) / 100;
                Application.Current.Dispatcher.Invoke(delegate
                 {
                     Highlighter.Margin = new Thickness(M, Highlighter.Margin.Top, Highlighter.Margin.Right, Highlighter.Margin.Bottom);
                 });
            }
        }

        ~TabList()
        {
            if (Switcher.IsAlive) Switcher.Abort();
        }

        public string CurrentTab
        {
            get
            {
                return SelectedTab.Name;
            }
        }
    }
}
