using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class Afdeling
    {
        private string _naam;
        private Guid _guid;
        private string? _omschrijving;

        public Afdeling()
        {
            Guid = Guid.NewGuid();
        }
        public Afdeling(string eenNaam, string? eenOmschrijving)
        {
            Naam = eenNaam;
            Guid = Guid.NewGuid();
            Omschrijving = eenOmschrijving;
        }

        public string Naam { get { return _naam; } set { _naam = value; } }
        public Guid Guid { get { return _guid; } set { _guid = value; } }
        public string Omschrijving { get { return _omschrijving; } set { _omschrijving = value; } }

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
                    Afdeling a = (Afdeling)obj;
                    if (this.Guid == a.Guid)
                    {
                        resultaat = true;
                    }
                }
            }
            return resultaat;
        }
    }
}
