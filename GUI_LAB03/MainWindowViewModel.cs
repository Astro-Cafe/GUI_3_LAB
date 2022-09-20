using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_LAB03
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Trooper> Troopers { get; set; }
        public ObservableCollection<Trooper> Army { get; set; }

        public MainWindowViewModel()
        {
            Troopers = new ObservableCollection<Trooper>();
            Army = new ObservableCollection<Trooper>();
            Troopers.Add(new Trooper() { Name = "marine", Power = 8, Vitality = 6, Cost = 6 });
            Troopers.Add(new Trooper() { Name = "pilot", Power = 7, Vitality = 3, Cost = 10 });
            Troopers.Add(new Trooper() { Name = "infantry", Power = 6, Vitality = 8, Cost = 10 });
            Troopers.Add(new Trooper() { Name = "sniper", Power = 3, Vitality = 3, Cost = 7 });
            Troopers.Add(new Trooper() { Name = "engineer", Power = 4, Vitality = 6, Cost = 8 });

        }
    }
}
