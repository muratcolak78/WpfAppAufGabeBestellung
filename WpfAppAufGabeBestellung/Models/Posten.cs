using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAufGabeBestellung.ViewModels;

namespace WpfAppAufGabeBestellung
{
    abstract class Posten:ViewModelBase
    {
        protected string Name { get=>Name; set=>OnPropertyChanged(nameof(Name)); }
        protected double Price { get=>Price; set=>OnPropertyChanged(nameof(Price)); }

        

        protected Posten(string name, double price)
        {
            Name = name;
            Price = price;
            
        }

        

        public abstract double BerechnePreis();

      
    }
}
