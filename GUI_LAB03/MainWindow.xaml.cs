using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace GUI_LAB03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainWindowViewModel vm;

        public bool darkModeToggle;
        public MainWindow()
        {
            InitializeComponent();

            darkModeToggle = false;

            vm = new MainWindowViewModel();

            this.DataContext = vm;
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {

            Trooper nt = new Trooper();
            nt.Name = (lb_all.SelectedItem as Trooper).Name;
            nt.Cost = (lb_all.SelectedItem as Trooper).Cost;
            nt.Vitality = (lb_all.SelectedItem as Trooper).Vitality;
            nt.Power = (lb_all.SelectedItem as Trooper).Power;
            vm.Army.Add(nt);
            l_money.Content = vm.Army.Sum(t => t.value);
        }

        private void bt_remove_Click(object sender, RoutedEventArgs e)
        {
            vm.Army.Remove(lb_army.SelectedItem as Trooper);
        }

        private void bt_edit_Click(object sender, RoutedEventArgs e)
        {
            TrooperEditor te = new TrooperEditor(lb_all.SelectedItem as Trooper);
            if (te.ShowDialog() == true)
            {
            }
            else
            {

            }
        }

		private void bt_DarkMode_Click(object sender, RoutedEventArgs e)
		{
			if (!darkModeToggle)
			{
                Grid_Main.Background = new SolidColorBrush(Color.FromRgb(40, 43, 48));
                lb_all.Background= new SolidColorBrush(Color.FromRgb(54, 57, 62));
                lb_army.Background= new SolidColorBrush(Color.FromRgb(54, 57, 62)); 
                darkModeToggle =true;
			}
			else
			{
                Grid_Main.Background = Brushes.White;
                lb_all.Background = Brushes.White;
                lb_army.Background = Brushes.White;
                darkModeToggle = false;

            }
		}
	}
}
