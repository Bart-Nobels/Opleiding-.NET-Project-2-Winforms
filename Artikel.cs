using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class Artikel
    {
        private string _naam;
        private int _aantalInStock;
        private Guid _guid;

        public Artikel()
        {
            Guid = Guid.NewGuid();
        }
        public Artikel(string naam, int aantalInStock)
        {
            Guid = Guid.NewGuid();

            Naam = naam;
            AantalInStock = aantalInStock;
        }

        public string Naam { get { return _naam; } set { _naam = value; } }
        public int AantalInStock { get { return _aantalInStock; } set { _aantalInStock = value; } }
        public Guid Guid { get { return _guid; } set { _guid = value; } }
    }
}
