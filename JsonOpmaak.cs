using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class JsonOpmaak
    {
        private DateTime _datumOntvangst;
        private string _bedrijfsnaam;
        private List<JsonArtikel> _levering;

        public JsonOpmaak()
        {
        }
        public JsonOpmaak(List<JsonArtikel> lijstLevering, DateTime datumOntvangst, string bedrijfsnaam)
        {
            Levering = lijstLevering;
            DatumOntvangst = datumOntvangst;
            Bedrijfsnaam = bedrijfsnaam;
        }

        public List<JsonArtikel> Levering { get { return _levering; } set { _levering = value; } }
        public DateTime DatumOntvangst { get { return _datumOntvangst; } set { _datumOntvangst = value; } }
        public string Bedrijfsnaam { get { return _bedrijfsnaam; } set { _bedrijfsnaam = value; } }
    }
}
