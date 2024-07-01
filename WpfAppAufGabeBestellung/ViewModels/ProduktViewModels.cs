using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAufGabeBestellung.ViewModels
{
    class ProduktViewModels:ViewModelBase
    {
        private Bestellung bestellung ;
        public ProduktViewModels()
        {
            Bestellung = new Bestellung();
            
        }

        internal Bestellung Bestellung { get => bestellung;
            set
            {
                bestellung = value;
                OnPropertyChanged(nameof(Bestellung));
            }  
        }
        public ObservableCollection<Posten> Postens { get => bestellung.Postens; set
            {
                bestellung.Postens = value;
                OnPropertyChanged(nameof(Bestellung));
            } }
    }
}
