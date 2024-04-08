using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class Gebruiker
    {
        private Guid _guid;
        private string _naam;
        private string _voornaam;
        private string _gebruikersnaam;
        private string _paswoord;
        private GebruikersRol _gebruikersRol;
        private string _naamRol;                
        private bool _kanBewerkenXml;
        private bool _kanAanmakenXml;
        private bool _kanLezenXml;
        private bool _kanEncrypterenXml;
        private bool _kanBewerkenTxt;
        private bool _kanAanmakenTxt;
        private bool _kanLezenTxt;
        private bool _kanEncrypterenTxt;
        private bool _kanBewerkenJson;
        private bool _kanAanmakenJson;
        private bool _kanLezenJson;
        private bool _kanEncrypterenJson;
        private List<Afdeling> _lijstAfdelingen;

        public Gebruiker()
        {
            Guid = Guid.NewGuid();

        }
        public Gebruiker(GebruikersRol eenRol, string naam, string voornaam, string gebruikersnaam, string paswoord, List<Afdeling> eenLijstAfdelingen)
        {
            Guid = Guid.NewGuid();
            GebruikersRol = eenRol;
            Naam = naam;
            Voornaam = voornaam;
            Gebruikersnaam = gebruikersnaam;
            Paswoord = paswoord;
            LijstAfdelingen = eenLijstAfdelingen;

            _naamRol = eenRol.Naam;                     
            _kanBewerkenXml = eenRol.KanBewerkenXml;
            _kanAanmakenXml = eenRol.KanAanmakenXml;
            _kanLezenXml = eenRol.KanLezenXml;
            _kanEncrypterenXml = eenRol.KanEncrypterenXml;
            _kanBewerkenTxt = eenRol.KanBewerkenTxt;
            _kanAanmakenTxt = eenRol.KanAanmakenTxt;
            _kanLezenTxt = eenRol.KanLezenTxt;
            _kanEncrypterenTxt = eenRol.KanEncrypterenTxt;
            _kanBewerkenJson = eenRol.KanBewerkenJson;
            _kanAanmakenJson = eenRol.KanAanmakenJson;
            _kanLezenJson = eenRol.KanLezenJson;
            _kanEncrypterenJson = eenRol.KanEncrypterenJson;
        }

        public string Naam { get { return _naam; } set { _naam = value; } }
        public string Voornaam { get { return _voornaam; } set { _voornaam = value; } }
        public string Gebruikersnaam { get { return _gebruikersnaam; } set { _gebruikersnaam = value; } }
        public string Paswoord { get { return _paswoord; } set { _paswoord = value; } }
        public Guid Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }
        public List<Afdeling> LijstAfdelingen { get { return _lijstAfdelingen; } set { _lijstAfdelingen = value; } }
        public GebruikersRol GebruikersRol { get { return _gebruikersRol; } set { _gebruikersRol = value; } }

        public override bool Equals(object? obj) //Bart: Equals check voor Gebruikersnaam en Paswoord
        {
            bool resultaat = false;
            if (obj != null)
            {
                if (GetType() == obj.GetType())
                {
                    Gebruiker g = (Gebruiker)obj;
                    if (this.Gebruikersnaam == g.Gebruikersnaam && this.Paswoord == g.Paswoord)
                    {
                        resultaat = true;
                    }
                }
            }
            return resultaat;
        }
    }
}
