using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class VerkoopArtikel : Artikel
    {
        private double _verkoopprijs;
        private int _minimumvoorraadniveau;

        public VerkoopArtikel() : base()
        {
        }
        public VerkoopArtikel(string naam, int aantalInStock, double verkoopprijs, int? minimumvoorraadniveau) : base(naam, aantalInStock)
        {
            Verkoopprijs = verkoopprijs;
            Minimumvoorraadniveau = minimumvoorraadniveau;
        }

        public double Verkoopprijs { get { return _verkoopprijs; } set { _verkoopprijs = value; } }
        public int? Minimumvoorraadniveau { get { return _minimumvoorraadniveau; } set { _minimumvoorraadniveau = (int)value; } }
    }
}
