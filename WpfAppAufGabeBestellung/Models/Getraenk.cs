using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAufGabeBestellung
{
    internal class Getraenk : Posten
    {
        private bool alkoholish;
        private bool happyhour;

        public Getraenk(bool alkoholish, bool happyhour, string name, double price) : base(name, price)
        {
            Alkoholish = alkoholish;
            Happyhour = happyhour;
        }

        public bool Alkoholish { get => alkoholish;
            set 
            {
                alkoholish = value;
                OnPropertyChanged(nameof(Alkoholish));
            } 
        }
        public bool Happyhour { get => happyhour; set
            {
                happyhour = value;
                OnPropertyChanged(nameof(Happyhour));
            }
             }

        public override double BerechnePreis()
        {
            if (alkoholish && happyhour) return Price / 0.75;
            return Price;
        }
    }
}
