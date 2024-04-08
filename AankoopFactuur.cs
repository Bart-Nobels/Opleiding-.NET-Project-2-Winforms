using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class AankoopFactuur : Factuur
    {
        private List<AankoopArtikel> _lijstAankoopArtikels;
        private Leverancier _eenLeverancier;
        private string _naamLeverancier;
        private string _naamGebruikerPlus;
        private string _voornaamGebruikerPlus;

        public AankoopFactuur()
        {
        }
        public AankoopFactuur(DateTime datum, GebruikerPlus eenGebruikerPlus, Leverancier eenLeverancier, List<AankoopArtikel> eenLijstAankoopArtikels) : base(datum, eenGebruikerPlus)
        {
            LijstAankoopArtikels = eenLijstAankoopArtikels;
            EenLeverancier = eenLeverancier;

            _naamLeverancier = eenLeverancier.Naam;
            _naamGebruikerPlus = eenGebruikerPlus.Naam;
            _voornaamGebruikerPlus = eenGebruikerPlus.Voornaam;
        }

        public List<AankoopArtikel> LijstAankoopArtikels { get { return _lijstAankoopArtikels; } set { _lijstAankoopArtikels = value; } }
        public Leverancier EenLeverancier { get { return _eenLeverancier; } set { _eenLeverancier = value; } }
    }
}
