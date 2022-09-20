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

        public MainWindow()
        {
            InitializeComponent();

            vm = new MainWindowViewModel();

            this.DataContext = vm;
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            vm.Army.Add(lb_all.SelectedItem as Trooper);
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
    }
}
