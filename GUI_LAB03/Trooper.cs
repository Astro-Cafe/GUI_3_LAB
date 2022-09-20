using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI_LAB03
{
    public class Trooper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        

        private string name;
        private int power;
        private int vitalty;
        private int cost;
        public int value 
        { 
            get
            {
                return power*vitalty*cost;
            } 
        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Save(int newPow, int newVit, int newCost)
        {
            Power = newPow;
            Vitality = newVit;
            Cost = newCost;
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
        public int Power
        {
            get { return power; }
            set { power = value; OnPropertyChanged(); }
        }


        public int Vitality
        {
            get { return vitalty; }
            set { vitalty = value; OnPropertyChanged(); }
        }


        public int Cost
        {
            get { return cost; }
            set { cost = value; OnPropertyChanged(); }
        }


    }
}
