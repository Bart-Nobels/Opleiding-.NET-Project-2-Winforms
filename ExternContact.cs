using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class ExternContact
    {
        private string _naam;
        private string? _adres;
        private string? _telefoonnummer;
        private string? _email;
        private Guid _guid;

        public ExternContact()
        {
            Guid = Guid.NewGuid();
        }
        public ExternContact(string naam, string? adres, string? telefoonnummer, string? email)
        {
            Guid = Guid.NewGuid();

            Naam = naam;
            Adres = adres;
            Telefoonnummer = telefoonnummer;
            Email = email;
        }

        public string Naam { get { return _naam; } set { _naam = value; } }
        public string Adres { get { return _adres; } set { _adres = value; } }
        public string Telefoonnummer { get { return _telefoonnummer; } set { _telefoonnummer = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public Guid Guid { get { return _guid; } set { _guid = value; } }
    }
}
