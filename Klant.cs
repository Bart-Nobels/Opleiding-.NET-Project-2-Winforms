using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class Klant : ExternContact
    {
        private double _totaalSaldoVerkoop;
        private List<VerkoopFactuur> _lijstVerkoopfacturenKlant;

        public Klant() : base()
        {
        }
        public Klant(string naam, string adres, string? telefoonnummer, string? email, double totaalSaldoVerkoop, List<VerkoopFactuur> lijstVerkoopfacturenKlant) : base(naam, adres, telefoonnummer, email)
        {
            TotaalSaldoVerkoop = totaalSaldoVerkoop;
            LijstVerkoopfacturenKlant = lijstVerkoopfacturenKlant;
        }

        public double TotaalSaldoVerkoop { get { return _totaalSaldoVerkoop; } set { _totaalSaldoVerkoop = value; } }
        public List<VerkoopFactuur> LijstVerkoopfacturenKlant { get { return _lijstVerkoopfacturenKlant; } set { _lijstVerkoopfacturenKlant = value; } }
    }
}
