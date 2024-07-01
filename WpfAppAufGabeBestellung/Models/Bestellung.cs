using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAufGabeBestellung
{
    internal class Bestellung
    {
        private bool bitAndBiteCard;
        private ObservableCollection<Posten> postens;

     

        public Bestellung()
        {
           
            Postens = new ObservableCollection<Posten>()
            {
                new Essen(true,"pizza",12),
                new Essen(false,"pizza",10),
                new Getraenk(true, true,"happyhour",12)
            };
        }

        public bool BitAndBiteCard { get => bitAndBiteCard; set => bitAndBiteCard = value; }
        internal ObservableCollection<Posten> Postens { get => postens; set => postens = value; }

        public double  BerechneBestellung()
        {
            var price = Postens.Sum(x => x.BerechnePreis());
            if(BitAndBiteCard) return price*0.95;
            return price;
        }

    }
}
