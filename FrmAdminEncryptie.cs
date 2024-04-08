namespace Project_2__Bart_
{
    public partial class FrmAdminEncryptie : Form
    {
        string directory;
        string selectedFilePath;
        string pad;
        private Form1 frm1Instance;
        DialogResult antwoordMessageBox;
        Encryptie nieuweEncryptie;

        public FrmAdminEncryptie(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }
        public GebruikerPlus IngelogdeGebruikerAdminEncryptie
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmAdminEncryptie_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void btnSleutelAanmaken_Click(object sender, EventArgs e)
        {
            try
            {
                antwoordMessageBox = MessageBox.Show("Bent u zeker dat u een nieuwe sleutel wil aanmaken? De oude zal gearchiveerd worden.", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (antwoordMessageBox == DialogResult.Yes)
                {
                    string huidigeSleutelPad = Environment.CurrentDirectory + @"\Sleutels\HuidigeSleutel_Team3";
                    string archiefSleutelPad = Environment.CurrentDirectory + @"\Sleutels\ArchiefSleutels_Team3";

                    VerplaatsEnHernoemBestanden(huidigeSleutelPad, archiefSleutelPad); //Bart: Huidige sleutel eerst archiveren.

                    directory = Environment.CurrentDirectory + @"\Sleutels\HuidigeSleutel_Team3";
                    pad = Path.Combine(directory, "Sleutel_Groep_3.txt");
                    nieuweEncryptie = new Encryptie();

                    nieuweEncryptie.GenereerNieuweSleutelEnSchrijfWeg(pad, directory); //Bart: nieuwe sleutel aanmaken + toeovegen aan juiste map.
                }
                else
                {
                    MessageBox.Show("De nieuwe sleutel is NIET aangemaakt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanmaken van de sleutel.", ex.GetType().ToString());
            }
        }
        private void btnSleutelZoeken_Click(object sender, EventArgs e)
        {
            directory = Environment.CurrentDirectory + @"\Sleutels";
            SleutelsZoeken(directory, txtNaamBestaandeSleutel);
        }
        private void btnSleutelVerwijderen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                try
                {
                    antwoordMessageBox = MessageBox.Show("Bent u zeker dat u deze sleutel wil verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (antwoordMessageBox == DialogResult.Yes)
                    {
                        File.Delete(selectedFilePath);
                        MessageBox.Show("De sleutel is succesvol verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNaamBestaandeSleutel.Text = string.Empty;
                        selectedFilePath = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("De sleutel is NIET verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de sleutel.", ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("Gelieve eerst een sleutel te zoeken aub.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSleutelLeverancierZoeken_Click(object sender, EventArgs e)
        {
            directory = Environment.CurrentDirectory + @"\Sleutels\SLEUTEL_LEVERANCIER";
            SleutelsZoeken(directory, txtNaamSleutelLeverancier);
        }
        private void btnSleutelLeverancierToepassen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                try
                {
                    antwoordMessageBox = MessageBox.Show("Bent u zeker dat u deze nieuwe sleutel wil toepassen? De oude zal gearchiveerd worden.", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (antwoordMessageBox == DialogResult.Yes)
                    {
                        string beginmap = Environment.CurrentDirectory + @"\Sleutels\HuidigeSleutel_Team2";
                        string doelmap = Environment.CurrentDirectory + @"\Sleutels\ArchiefSleutels_Team2";

                        VerplaatsEnHernoemBestanden(beginmap, doelmap); //Bart: Huidige sleutel eerst archiveren.

                        string nieuweNaam = "Sleutel_Groep_2.txt";  //Bart: naam nieuw bestand aanpassen + in juist map toevoegen.
                        string nieuwFilePath = Path.Combine(Environment.CurrentDirectory, @"Sleutels\HuidigeSleutel_Team2", nieuweNaam);
                        File.Move(selectedFilePath, nieuwFilePath);

                        MessageBox.Show("De sleutel is succesvol toegevoegd. Deze zal vanaf nu toegepast worden.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNaamSleutelLeverancier.Text = string.Empty;
                        selectedFilePath = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("De nieuwe sleutel is NIET toegepast.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het toepassen van de nieuwe sleutel.", ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("Gelieve eerst een sleutel te zoeken aub.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void VerplaatsEnHernoemBestanden(string beginmap, string doelmap)   //Bart: methode om bestanden te verplaatsen
        {
            string[] bestanden = Directory.GetFiles(beginmap);

            if (!Directory.Exists(doelmap))
            {
                Directory.CreateDirectory(doelmap);
            }
            foreach (string bestand in bestanden)
            {
                DateTime origineleDatum = File.GetCreationTime(bestand); //Bart: zoekt de originele opmaakdatum van het bestand.
                string nieuweBestandsnaam = Path.GetFileNameWithoutExtension(bestand) + "_" + origineleDatum.ToString("yyyyMMdd_HHmmss") + Path.GetExtension(bestand);
                string doelBestand = Path.Combine(doelmap, nieuweBestandsnaam);

                if (!File.Exists(doelBestand))
                {
                    File.Move(bestand, doelBestand);
                }
                else
                {
                    File.Delete(bestand);
                }
            }
        }
        private void SleutelsZoeken(string directory, TextBox txtBox)
        {
            if (Directory.Exists(directory))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = directory;

                        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";


                        openFileDialog.FilterIndex = 1;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            selectedFilePath = openFileDialog.FileName;
                            txtBox.Text = Path.GetFileNameWithoutExtension(selectedFilePath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het zoeken naar een sleutel.", ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("De map met sleutels kon niet gevonden worden.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}

