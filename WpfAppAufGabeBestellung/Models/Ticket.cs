using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAufGabeBestellung
{
    internal class Ticket : Posten
    {
        private DateTime startTime;
        private int minuten;

        public Ticket(DateTime startTime, int minuten, string name, double price ): base( name,  price)
        {
            StartTime = startTime;
            Minuten = minuten;
        }

        public DateTime StartTime { get => startTime;
            set
            {
                startTime = value;
                OnPropertyChanged(nameof(StartTime));
            }  
        }
        public int Minuten { get => minuten;
            set
            {
                minuten = value;
                OnPropertyChanged(nameof(Minuten));
            } 
        }

        public override double BerechnePreis()
        {
            return Price*Minuten;
        }
    }
}
