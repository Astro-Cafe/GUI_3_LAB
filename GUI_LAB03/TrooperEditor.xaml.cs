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
using System.Windows.Shapes;

namespace GUI_LAB03
{
    /// <summary>
    /// Interaction logic for TrooperEditor.xaml
    /// </summary>
    public partial class TrooperEditor : Window
    {
        private Trooper t;
        public TrooperEditor(Trooper troop)
        {
            InitializeComponent();
            this.t = troop;

            tb_power.Text = t.Power.ToString();
            tb_vitality.Text = t.Vitality.ToString();
            tb_cost.Text = t.Cost.ToString();
            

        }

        private void Button_click_save(object sender, RoutedEventArgs e)
        {
            int newPower = int.Parse(tb_power.Text);
            int newVitality = int.Parse(tb_vitality.Text);
            int newCost = int.Parse(tb_cost.Text);
            t.Save(newPower, newVitality, newCost);
            this.DialogResult = true;
        }
    }
}
