using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class Leverancier : ExternContact
    {
        private double _totaalSaldoAankoop;
        private List<AankoopFactuur> _lijstAankoopfacturenKlant;

        public Leverancier() : base()
        {
        }
        public Leverancier(string naam, string? adres, string? telefoonnummer, string? email, double totaalSaldoAankoop) : base(naam, adres, telefoonnummer, email)
        {
            TotaalSaldoAankoop = totaalSaldoAankoop;
        }

        public double TotaalSaldoAankoop { get { return _totaalSaldoAankoop; } set { _totaalSaldoAankoop = value; } }
        public List<AankoopFactuur> LijstAankoopfacturenKlant { get { return _lijstAankoopfacturenKlant; } set { _lijstAankoopfacturenKlant = value; } }
    }
}
