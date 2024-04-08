namespace Project_2__Bart_
{
    public class Encryptie
    {
        char[] arrSymbolen = "' !\"#$%&()*+,-.\\/0123456789:<=>@?ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~;éèêëûüôöîïâäà\r\n".ToCharArray();

        public Encryptie()
        {
        }

        public void Encrypteren(string bronBestand, string doelBestand, char[] sleutel)
        {
            char[] input = File.ReadAllText(bronBestand).ToCharArray();
            string output = "";
            int index;

            if (sleutel != null)
            {
                foreach (char c in input)
                {
                    index = Array.IndexOf(arrSymbolen, c);
                    output += sleutel[index];
                }
                File.WriteAllText(doelBestand, output);
            }
            else
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van de sleutel.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Decrypteren(string bronBestand, string doelBestand, char[] sleutel)
        {
            char[] input = File.ReadAllText(bronBestand).ToCharArray();
            string output = "";
            int index;

            foreach (char c in input)
            {
                index = Array.IndexOf(sleutel, c);
                output += arrSymbolen[index];
            }

            File.WriteAllText(doelBestand, output);
        }
        public void GenereerNieuweSleutelEnSchrijfWeg(string bestandsnaam, string directory)
        {
            Random random = new Random();
            int randomNumber;
            char[] sleutelSymbolen = "' !\"#$%&()*+,-.\\/0123456789:<=>@?ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~;éèêëûüôöîïâäà\r\n".ToCharArray();
            char[] arrSleutel;
            arrSleutel = new char[sleutelSymbolen.Length];

            if (!File.Exists(bestandsnaam))
            {
                if (!Directory.Exists(directory))               //maakt nieuwe map aan als deze nog niet bestaat
                {
                    Directory.CreateDirectory(directory);
                }
                for (int i = 0; i < sleutelSymbolen.Length; i++)
                {
                    do
                    {
                        randomNumber = random.Next(0, sleutelSymbolen.Length);
                    } while (sleutelSymbolen[randomNumber] == 'µ');

                    arrSleutel[i] = sleutelSymbolen[randomNumber];
                    sleutelSymbolen[randomNumber] = 'µ';                     // omdat we spatie ook encrypteren , gebruiken we hier een character dat we nooit gaan typen ipv spatie (kan mss ook anders?)
                }
                SchrijfStringWeg(arrSleutel, bestandsnaam);
            }

            else
            {
                MessageBox.Show("Gelieve de huidige sleutel eerst te verwijderen of verplaatsen naar en andere map.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SchrijfStringWeg(char[] nieuweSleutel, string bestandsnaam) //Bart: Om Sleutel weg te schrijven naar een txt.
        {
            try
            {
                string volledigPad = Path.Combine(Path.GetDirectoryName(bestandsnaam), Path.GetFileName(bestandsnaam));
                using (StreamWriter mijnWriter = new StreamWriter(volledigPad))
                {
                    mijnWriter.WriteLine(nieuweSleutel);
                }
                MessageBox.Show("De sleutel werd aangemaakt in een txt-bestand en is vanaf nu actief.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het opslaan van de sleutel in een txt-bestand.", ex.GetType().ToString());
            }
        }
    }
}

