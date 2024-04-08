using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class GebruikersRol
    {
        private Guid _guid;
        private string _naam;
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

        public GebruikersRol()
        {
            Guid = Guid.NewGuid();
        }
        public GebruikersRol(string eenNaam, bool kanBewerkenXml, bool kanAanmakenXml, bool kanLezenXml, bool kanEncrypterenXml, bool kanBewerkenTxt, bool kanAanmakenTxt, bool kanLezenTxt, bool kanEncrypterenTxt, bool kanBewerkenJson, bool kanAanmakenJson, bool kanLezenJson, bool kanEncrypterenJson)
        {
            KanBewerkenXml = kanBewerkenXml;
            KanAanmakenXml = kanAanmakenXml;
            KanLezenXml = kanLezenXml;
            KanEncrypterenXml = kanEncrypterenXml;
            KanBewerkenTxt = kanBewerkenTxt;
            KanAanmakenTxt = kanAanmakenTxt;
            KanLezenTxt = kanLezenTxt;
            KanEncrypterenTxt = kanEncrypterenTxt;
            KanBewerkenJson = kanBewerkenJson;
            KanAanmakenJson = kanAanmakenJson;
            KanLezenJson = kanLezenJson;
            KanEncrypterenJson = kanEncrypterenJson;
            Naam = eenNaam;
            Guid = Guid.NewGuid();
        }

        public bool KanBewerkenXml { get { return _kanBewerkenXml; } set { _kanBewerkenXml = value; } }
        public bool KanAanmakenXml { get { return _kanAanmakenXml; } set { _kanAanmakenXml = value; } }
        public bool KanLezenXml { get { return _kanLezenXml; } set { _kanLezenXml = value; } }
        public bool KanEncrypterenXml { get { return _kanEncrypterenXml; } set { _kanEncrypterenXml = value; } }
        public bool KanBewerkenTxt { get { return _kanBewerkenTxt; } set { _kanBewerkenTxt = value; } }
        public bool KanAanmakenTxt { get { return _kanAanmakenTxt; } set { _kanAanmakenTxt = value; } }
        public bool KanLezenTxt { get { return _kanLezenTxt; } set { _kanLezenTxt = value; } }
        public bool KanEncrypterenTxt { get { return _kanEncrypterenTxt; } set { _kanEncrypterenTxt = value; } }
        public bool KanBewerkenJson { get { return _kanBewerkenJson; } set { _kanBewerkenJson = value; } }
        public bool KanAanmakenJson { get { return _kanAanmakenJson; } set { _kanAanmakenJson = value; } }
        public bool KanLezenJson { get { return _kanLezenJson; } set { _kanLezenJson = value; } }
        public bool KanEncrypterenJson { get { return _kanEncrypterenJson; } set { _kanEncrypterenJson = value; } }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public Guid Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        public override string ToString()
        {
            return Naam;
        }
        public override bool Equals(object? obj) //Bart: Equals check voor Guid
        {
            bool resultaat = false;
            if (obj != null)
            {
                if (GetType() == obj.GetType())
                {
                    GebruikersRol gr = (GebruikersRol)obj;
                    if (this.Guid == gr.Guid)
                    {
                        resultaat = true;
                    }
                }
            }
            return resultaat;
        }
    }
}
