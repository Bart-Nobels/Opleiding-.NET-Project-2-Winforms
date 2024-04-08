using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class GebruikerPlus : Gebruiker
    {
        private string _adres;
        private string _rekeningnummer;
        private string _telefoonnummer;
        private double _loon;
        private int _tellerPaswoord;

        public GebruikerPlus() : base() { }
        public GebruikerPlus(GebruikersRol eenRol, string naam, string voornaam, string gebruikersnaam, string paswoord, List<Afdeling> eenLijstAfdelingen, int tellerPaswoord, string adres, string rekeningnummer,
                            string telefoonnummer, double loon) : base(eenRol, naam, voornaam, gebruikersnaam, paswoord, eenLijstAfdelingen)
        {
            Adres = adres;
            Rekeningnummer = rekeningnummer;
            Telefoonnummer = telefoonnummer;
            Loon = loon;
            TellerPaswoord = tellerPaswoord;
        }
        public string Adres
        {
            get { return _adres; }
            set
            {
                if (ControleAdres(value))
                {
                    _adres = value;
                }
                else
                {
                    throw new SystemException("Het ingevoerde adres heeft niet het correcte formaat (bv. Voorbeeldstraat 123, 1000 Brussel).");
                }
            }
        }
        public string Rekeningnummer
        {
            get { return _rekeningnummer; }
            set
            {
                if (ControleRekeningnummerBelgie(value)) //Bart: Controle op Belgisch rekeningnummer
                {
                    _rekeningnummer = value;
                }
                else
                {
                    throw new SystemException("Het ingevoerde rekeningnummer heeft niet het correcte formaat (bv. BE98765432154321).");
                }
            }
        }
        public string Telefoonnummer
        {
            get { return _telefoonnummer; }
            set
            {
                if (ControleTelefoonnummerBelgie(value) || ControleGSMBelgie(value)) //Bart: Controle op correct Telefoonnummer of GSM
                {
                    _telefoonnummer = value;
                }
                else
                {
                    throw new SystemException("Het ingevoerde telefoonnummer heeft niet het correcte formaat (bv. 02 123 45 67 of 0474 11 22 33).");
                }
            }
        }
        public double Loon
        {
            get { return _loon; }
            set
            {
                if (Double.TryParse(value.ToString(), out double result)) //Bart: Controle of getal een decimaal getal is
                {
                    _loon = value;
                }
                else
                {
                    throw new SystemException("Het ingevoerde loon moet een decimaal getal zijn.");
                }
            }
        }
        public int TellerPaswoord
        {
            get { return _tellerPaswoord; }
            set
            {
                if (value >= 0 && value <= 3) //Bart: Controle of waarder van teller binnen juiste grenzen ligt
                {
                    _tellerPaswoord = value;
                }
                else
                {
                    value = 0;
                    throw new SystemException("De teller kan niet kleiner zijn dan 0 en niet groter dan 3.");
                }
            }
        }

        public bool ControleAdres(string adres)
        {
            string patroonAdres = @"^[a-zA-Z0-9\s,'-]*\d{1,5}\s?[a-zA-Z\s,'-]*$";
            return Regex.IsMatch(adres, patroonAdres);
        }
        public bool ControleRekeningnummerBelgie(string rekeningnummer)
        {
            string patroonRekeningnummer = @"^BE\d{2}\d{4}\d{4}\d{4}$";
            return Regex.IsMatch(rekeningnummer, patroonRekeningnummer);
        }
        public bool ControleTelefoonnummerBelgie(string telefoonnummer)
        {
            bool checkTelefoonnummer = false;
            string patroonTelefoonnummer1 = @"^(\+(32|0)|0)?\s?([1-9])([0-9])(\s?[0-9]{2}){3}$";
            string patroonTelefoonnummer2 = @"^(\+(32|0)|0)?\s?([1-9])\s?([0-9]{3})(\s?[0-9]{2}){2}$";
            if (Regex.IsMatch(telefoonnummer, patroonTelefoonnummer1) || Regex.IsMatch(telefoonnummer, patroonTelefoonnummer2))
            {
                checkTelefoonnummer = true;
            }
            return checkTelefoonnummer;
        }
        public bool ControleGSMBelgie(string GSM)
        {
            string patroonGSM = @"^(\+(32|0)|0)?\s?([4-7])([0-9]{2})(\s?[0-9]{2}){3}$";
            return Regex.IsMatch(GSM, patroonGSM);
        }
        public override bool Equals(object? obj) //Bart: Equals check voor Guid
        {
            bool resultaat = false;
            if (obj != null)
            {
                if (GetType() == obj.GetType())
                {
                    GebruikerPlus gp = (GebruikerPlus)obj;
                    if (this.Guid == gp.Guid)
                    {
                        resultaat = true;
                    }
                }
            }
            return resultaat;
        }
        public string PersoonlijkeInfo(List<GebruikerPlus> eenLijstGebruikerPlus, Gebruiker eenIngelogdeGebruiker) //Bart: Methode voor MessageBox persoonlijke info
        {
            string resultaat = string.Empty;
            foreach (GebruikerPlus gp in eenLijstGebruikerPlus)
            {
                if (gp.Guid.Equals(eenIngelogdeGebruiker.Guid))
                {
                    resultaat ="                  Naam:  " + gp.Naam + Environment.NewLine +
                        "           Voornaam:  " + gp.Voornaam + Environment.NewLine +
                        "  Gebruikersnaam:  " + gp.Gebruikersnaam + Environment.NewLine +
                        "                  Adres:  " + gp.Adres + Environment.NewLine +
                        " Telefoonnummer:  " + gp.Telefoonnummer + Environment.NewLine +
                        "Rekeningnummer:  " + gp.Rekeningnummer + Environment.NewLine +
                        "                   Loon:  " + gp.Loon.ToString("0.00") + Environment.NewLine;
                }
            }
            return resultaat;
        }
        public override string ToString() //om naam en voornaam in listbox weer te geven
        {
            return Naam + " " + Voornaam;
        }
    }
}
