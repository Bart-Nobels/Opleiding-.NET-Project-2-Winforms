using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class AankoopArtikel : Artikel
    {
        private double _aankoopprijs;
        private string _plaatsInWarenhuis;
        private DateTime _datum;

        public AankoopArtikel() : base()
        {
        }
        public AankoopArtikel(string naam, int aantalInStock, double aankoopprijs, string plaatsInWarenhuis, DateTime datum) : base(naam, aantalInStock)
        {
            Aankoopprijs = aankoopprijs;
            PlaatsInWarenhuis = plaatsInWarenhuis;
            Datum = datum;
        }

        public double Aankoopprijs { get { return _aankoopprijs; } set { _aankoopprijs = value; } }
        public string PlaatsInWarenhuis { get { return _plaatsInWarenhuis; } set { _plaatsInWarenhuis = value; } }
        public DateTime Datum { get { return _datum; } set { _datum = value; } }
    }
}
