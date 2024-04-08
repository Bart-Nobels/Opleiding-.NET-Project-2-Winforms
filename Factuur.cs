namespace Project_2__Bart_
{
    public class Factuur
    {
        private DateTime _datum;
        private Guid _guid;
        private GebruikerPlus _dezeGebruikerPlus;
        private Guid _guidGebruikerPlus;
        private string _gebruikersnaamGebruikerPlus;

        public Factuur()
        {
            Guid = Guid.NewGuid();
        }
        public Factuur(DateTime datum, GebruikerPlus eenGebruikerPlus)
        {
            Guid = Guid.NewGuid();
            Datum = datum;
            DezeGebruikerPlus = eenGebruikerPlus;

            _guidGebruikerPlus = eenGebruikerPlus.Guid;
            _gebruikersnaamGebruikerPlus = eenGebruikerPlus.Gebruikersnaam;

        }

        public DateTime Datum { get { return _datum; } set { _datum = value; } }
        public Guid Guid { get { return _guid; } set { _guid = value; } }
        public GebruikerPlus DezeGebruikerPlus { get { return _dezeGebruikerPlus; } set { _dezeGebruikerPlus = value; } }
    }
}
