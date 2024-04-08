using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class VerkoopFactuur : Factuur
    {
        private List<VerkoopArtikel> _lijstVerkooppArtikels;
        private Klant _eenKlant;
        private string _naamKlant;
        private string _naamGebruikerPlus;
        private string _voornaamGebruikerPlus;

        public VerkoopFactuur()
        {
        }
        public VerkoopFactuur(DateTime datum, GebruikerPlus eenGebruikerPlus, Klant eenKlant, List<VerkoopArtikel> eenLijstVerkoopArtikels) : base(datum, eenGebruikerPlus)
        {
            LijstVerkoopArtikels = eenLijstVerkoopArtikels;
            EenKlant = eenKlant;

            _naamKlant = eenKlant.Naam;
            _naamGebruikerPlus = eenGebruikerPlus.Naam;
            _voornaamGebruikerPlus = eenGebruikerPlus.Voornaam;

        }

        public List<VerkoopArtikel> LijstVerkoopArtikels { get { return _lijstVerkooppArtikels; } set { _lijstVerkooppArtikels = value; } }
        public Klant EenKlant { get { return _eenKlant; } set { _eenKlant = value; } }
    }
}
