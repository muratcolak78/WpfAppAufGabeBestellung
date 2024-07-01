using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAufGabeBestellung
{
    internal class Essen : Posten
    {
        private bool extragross;

        public Essen(bool extragross, string name, double price): base(name, price) 
        {
            Extragross = extragross;
        }

        public bool Extragross { get => extragross;
            set
            {
                extragross = value;
                OnPropertyChanged(nameof(Extragross));
            }
        }

        public override double BerechnePreis()
        {
            if (extragross) return Price * 1.2;
            return Price;
        }
    }
}
