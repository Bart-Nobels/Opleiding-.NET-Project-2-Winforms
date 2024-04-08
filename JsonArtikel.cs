using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class JsonArtikel
    {
        private string _naam;
        private int _aantal;
        private double _prijs;

        public JsonArtikel()
        {
        }
        public JsonArtikel(string naam, int aantal, double prijs)
        {
            Naam = naam;
            Aantal = aantal;
            Prijs = prijs;
        }

        public string Naam { get { return _naam; } set { _naam = value; } }
        public int Aantal { get { return _aantal; } set { _aantal = value; } }
        public double Prijs { get { return _prijs; } set { _prijs = value; } }

        public override string ToString()
        {
            int padLeftAfstand = 25;
            return "Naam artikel: ".PadLeft(padLeftAfstand) + Naam + Environment.NewLine +
                "Aantal flessen: ".PadLeft(padLeftAfstand) + Aantal + Environment.NewLine +
                "Prijs per stuk: ".PadLeft(padLeftAfstand) + Prijs.ToString("C") + Environment.NewLine +
                $"Totaalprijs {Naam}: ".PadLeft(padLeftAfstand) + TotaalPrijs().ToString("C") + Environment.NewLine + Environment.NewLine;
        }
        public double TotaalPrijs()
        {
            return Aantal * Prijs;
        }
    }
}
