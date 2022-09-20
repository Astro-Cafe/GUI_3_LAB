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
        public string name { get; set; }

        private int power;
        private int vitalty;
        private int cost;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }


        public int Power
        {
            get { return power; }
            set { power = value; }
        }


        public int Vitality
        {
            get { return vitalty; }
            set { vitalty = value; }
        }


        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }


    }
}
