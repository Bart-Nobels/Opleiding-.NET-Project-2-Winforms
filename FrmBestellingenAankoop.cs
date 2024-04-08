using System.Text.Json;
using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmBestellingenAankoop : Form
    {
        static string bedrijfsnaam = "Bools & Booze";
        private string currentDirectory;
        private string selectedFilePath;
        private double totaalsaldoBestelling = 0;
        private string directorySleutelTeam2 = Environment.CurrentDirectory + @"\Sleutels\HuidigeSleutel_Team2\Sleutel_Groep_2.txt";
        private string directorySleutelTeam3 = Environment.CurrentDirectory + @"\Sleutels\HuidigeSleutel_Team3\Sleutel_Groep_3.txt";
        private string nieuwFilePath;
        private char[] arrSleutel;

        Form1 frm1Instance;
        DialogResult antwoordMessageBox;
        JsonOpmaak voorlopigeJsonOpmaak;
        JsonArtikel geselecteerdeArtikel;
        Encryptie nieuweEncryptie;
        List<JsonArtikel> lijstJsonArtikelsBestelling = new List<JsonArtikel>();
        List<JsonArtikel> lijstArtikelsCombobox;

        public FrmBestellingenAankoop(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusAankoopBestellingen
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Leverancier> LijstLeveranciersAankoopBestellingen
        {
            get { return frm1Instance.LijstLeveranciers; }
            set { frm1Instance.LijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikelsAankoopBestellingen
        {
            get { return frm1Instance.LijstAankoopArtikels; }
            set { frm1Instance.LijstAankoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturenAankoopBestellingen
        {
            get { return frm1Instance.LijstAankoopFacturen; }
            set { frm1Instance.LijstAankoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAankoopBestellingen
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmBestellingenAankoop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            rdoJSONBestellingenAankoop.Checked = true;
            rdoJSONBestellingPlaatsen.Checked = true;
            nudAantal.ValueChanged += nudAantal_ValueChanged;
        }
        private void nudAantal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (geselecteerdeArtikel != null)
                {
                    int maxAantal = geselecteerdeArtikel.Aantal;

                    if (nudAantal.Value > maxAantal)
                    {
                        MessageBox.Show($"Aantal kan niet groter zijn dan {maxAantal}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nudAantal.Value = maxAantal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanpassen van het aantal.", ex.GetType().ToString());
            }
        }
        private void cmbArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbArtikel.SelectedItem != null)
                {
                    foreach (JsonArtikel jsona in voorlopigeJsonOpmaak.Levering)
                    {
                        if (jsona == cmbArtikel.SelectedItem)
                        {
                            geselecteerdeArtikel = jsona;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het selecteren van een artikel.", ex.GetType().ToString());
            }
        }
        private void btnBestelbestandZoeken_Click(object sender, EventArgs e)
        {
            FormulierLeegmaken();
            currentDirectory = Environment.CurrentDirectory + @"\BestelbestandenLeveranciers";
            if (Directory.Exists(currentDirectory))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = currentDirectory;

                        if (rdoJSONBestellingenAankoop.Checked)
                        {
                            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                        }
                        else
                        {
                            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                        }
                        openFileDialog.FilterIndex = 1;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            selectedFilePath = openFileDialog.FileName;
                            txtBestelbestandZoeken.Text = Path.GetFileName(selectedFilePath);

                            if (CheckEncrypted(selectedFilePath) == false)
                            {
                                if (rdoJSONBestellingenAankoop.Checked)
                                {
                                    JSONBestandJsonOpmaakInlezen(selectedFilePath);
                                }
                                else
                                {
                                    XMLBestandJsonOpmaakInlezen(selectedFilePath);
                                }
                                CmbArtikelVullen();
                                txtBedrijfsnaam.Text = voorlopigeJsonOpmaak.Bedrijfsnaam;
                            }
                            else
                            {
                                SleutelInlezen(directorySleutelTeam2);
                                nieuwFilePath = selectedFilePath.Replace("_Encrypted", "");
                                nieuweEncryptie = new Encryptie();

                                if (rdoJSONBestellingenAankoop.Checked && txtBestelbestandZoeken.Text.EndsWith(".json") && IngelogdeGebruikerAankoopBestellingen.GebruikersRol.KanEncrypterenJson == true)
                                {
                                    nieuweEncryptie.Decrypteren(selectedFilePath, nieuwFilePath, arrSleutel); //Bart: Decryptie
                                    JSONBestandJsonOpmaakInlezen(nieuwFilePath);
                                    File.Delete(nieuwFilePath);
                                    CmbArtikelVullen();
                                    txtBedrijfsnaam.Text = voorlopigeJsonOpmaak.Bedrijfsnaam;
                                }
                                else if (rdoXMLBestellingenAankoop.Checked && txtBestelbestandZoeken.Text.EndsWith(".xml") && IngelogdeGebruikerAankoopBestellingen.GebruikersRol.KanEncrypterenXml == true)
                                {
                                    nieuweEncryptie.Decrypteren(selectedFilePath, nieuwFilePath, arrSleutel); //Bart: Decryptie
                                    XMLBestandJsonOpmaakInlezen(nieuwFilePath);
                                    File.Delete(nieuwFilePath);
                                    CmbArtikelVullen();
                                    txtBedrijfsnaam.Text = voorlopigeJsonOpmaak.Bedrijfsnaam;
                                }
                                else
                                {
                                    FormulierLeegmaken();
                                    MessageBox.Show("U heeft niet de juiste rechten om dit bestand te openen.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het zoeken naar een document.", ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("De map met documenten kon niet gevonden worden.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnToevoegenBestellingenAankoop_Click(object sender, EventArgs e)
        {
            try
            {
                JsonArtikel eenArtikelVoorBestelling = new JsonArtikel();

                if (cmbArtikel.SelectedItem != null)
                {
                    if (geselecteerdeArtikel != null)
                    {
                        if (nudAantal.Value != 0)
                        {
                            eenArtikelVoorBestelling.Prijs = geselecteerdeArtikel.Prijs;
                            eenArtikelVoorBestelling.Naam = geselecteerdeArtikel.Naam;
                            eenArtikelVoorBestelling.Aantal = Convert.ToInt32(nudAantal.Value);

                            lijstJsonArtikelsBestelling.Add(eenArtikelVoorBestelling);

                            txtOverzichtBestellingBestellingenAankoop.Text += eenArtikelVoorBestelling.ToString();

                            totaalsaldoBestelling += eenArtikelVoorBestelling.Prijs * eenArtikelVoorBestelling.Aantal;
                            txtTotaalsaldoBestelling.Text = totaalsaldoBestelling.ToString("C");

                            nudAantal.Value = 0;

                            lijstArtikelsCombobox.Remove(geselecteerdeArtikel);
                            RefreshCombobox();
                        }
                        else
                        {
                            MessageBox.Show("Het aantal flessen kan niet 0 zijn.", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gelieve eerst een artikel te selecteren.", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    btnToevoegenBestellingenAankoop.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het toevoegen van het artikel.", ex.GetType().ToString());
            }
        }
        private void btnBestellingPlaatsenBestellingenAankoop_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOverzichtBestellingBestellingenAankoop.Text != string.Empty)
                {
                    antwoordMessageBox = MessageBox.Show("Bent u zeker dat u deze bestelling wil plaatsen?", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (antwoordMessageBox == DialogResult.Yes)
                    {
                        string directory = Environment.CurrentDirectory + @"\Bestellingen";
                        string pad = Environment.CurrentDirectory + @"\Bestellingen\" + txtNaamBestandBestelling.Text;

                        JsonOpmaak eenJsonOpmaakVoorBestelling = new JsonOpmaak();

                        eenJsonOpmaakVoorBestelling.Levering = lijstJsonArtikelsBestelling;
                        eenJsonOpmaakVoorBestelling.Bedrijfsnaam = bedrijfsnaam;
                        eenJsonOpmaakVoorBestelling.DatumOntvangst = DateTime.Now;


                        if (!Directory.Exists(directory))                                                //Bart: maakt nieuwe map aan als deze nog niet bestaat
                        {
                            Directory.CreateDirectory(directory);
                        }
                        if (!cbEncryptieBestellingenAankoop.Checked)                                      //Bart: als encryptie niet aanstaat.
                        {
                            if (rdoJSONBestellingPlaatsen.Checked)
                            {
                                pad += ".json";

                                if (!System.IO.File.Exists(pad))
                                {
                                    JSONBestandJsonOpmaakBestellingSchrijven(pad, eenJsonOpmaakVoorBestelling);
                                    FormulierLeegmaken();
                                }
                                else
                                {
                                    MessageBox.Show("Er bestaat reeds een bestelling met deze naam. Gelieve een andere naam te kiezen aub.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtNaamBestandBestelling.Text = string.Empty;
                                }
                            }
                            else
                            {
                                pad += ".xml";

                                if (!System.IO.File.Exists(pad))
                                {
                                    XMLBestandJsonOpmaakBestellingSchrijven(pad, eenJsonOpmaakVoorBestelling);
                                    FormulierLeegmaken();
                                }
                                else
                                {
                                    MessageBox.Show("Er bestaat reeds een bestelling met deze naam. Gelieve een andere naam te kiezen aub.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtNaamBestandBestelling.Text = string.Empty;
                                }
                            }
                        }
                        else                                                                              //Bart: als encryptie wel aanstaat.
                        {
                            SleutelInlezen(directorySleutelTeam3);
                            nieuweEncryptie = new Encryptie();
                            string bronBestand = Environment.CurrentDirectory + @"\Bestellingen\" + txtNaamBestandBestelling.Text;

                            //Bart: Bestandsnaam moet eindigen met _Encrypted (zo afgesproken met team 2)
                            if (rdoJSONBestellingPlaatsen.Checked && IngelogdeGebruikerAankoopBestellingen.GebruikersRol.KanEncrypterenJson == true)
                            {
                                bronBestand += ".json";
                                pad += "_Encrypted.json";

                                if (!System.IO.File.Exists(bronBestand))
                                {
                                    JSONBestandJsonOpmaakBestellingSchrijven(bronBestand, eenJsonOpmaakVoorBestelling);
                                    nieuweEncryptie.Encrypteren(bronBestand, pad, arrSleutel);                                 //Bart: Encryptie
                                    FormulierLeegmaken();
                                    File.Delete(bronBestand);
                                }
                                else
                                {
                                    MessageBox.Show("Er bestaat reeds een bestelling met deze naam. Gelieve een andere naam te kiezen aub.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtNaamBestandBestelling.Text = string.Empty;
                                }
                            }
                            else if (rdoXMLBestellingPlaatsen.Checked && IngelogdeGebruikerAankoopBestellingen.GebruikersRol.KanEncrypterenXml == true)
                            {
                                bronBestand += ".xml";
                                pad += "_Encrypted.xml";

                                if (!System.IO.File.Exists(bronBestand))
                                {
                                    XMLBestandJsonOpmaakBestellingSchrijven(bronBestand, eenJsonOpmaakVoorBestelling);
                                    nieuweEncryptie.Encrypteren(bronBestand, pad, arrSleutel);                                 //Bart: Encryptie
                                    FormulierLeegmaken();
                                    File.Delete(bronBestand);
                                }
                                else
                                {
                                    MessageBox.Show("Er bestaat reeds een bestelling met deze naam. Gelieve een andere naam te kiezen aub.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtNaamBestandBestelling.Text = string.Empty;
                                }
                            }
                            else
                            {
                                MessageBox.Show("U heeft niet de juiste rechten om dit bestand te encrypteren.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cbEncryptieBestellingenAankoop.Checked = false;
                            }
                        }
                        rdoJSONBestellingenAankoop.Checked = true;
                        rdoJSONBestellingPlaatsen.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Het document voor de bestelling werd NIET aangemaakt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Gelieve eerst artikels toe te voegen aub.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het plaatsen van de bestelling.", ex.GetType().ToString());
            }
        }
        private void btnFormulierLeegmaken_Click(object sender, EventArgs e)
        {
            try
            {
                antwoordMessageBox = MessageBox.Show("Bent u zeker dat u het formulier wil leegmaken?" + Environment.NewLine + "De bestelling zal NIET geplaatst worden.", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (antwoordMessageBox == DialogResult.Yes)
                {
                    FormulierLeegmaken();
                    rdoJSONBestellingenAankoop.Checked = true;
                    rdoJSONBestellingPlaatsen.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het leegmaken van het formulier.", ex.GetType().ToString());
            }
        }
        private void btnTerugBestellingenAankoop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FormulierLeegmaken()
        {
            cmbArtikel.DataSource = null;

            txtBestelbestandZoeken.Text = string.Empty;
            txtBedrijfsnaam.Text = string.Empty;
            txtOverzichtBestellingBestellingenAankoop.Text = string.Empty;
            txtNaamBestandBestelling.Text = string.Empty;
            txtTotaalsaldoBestelling.Text = string.Empty;

            nudAantal.Value = 0;
            cbEncryptieBestellingenAankoop.Checked = false;
            lijstJsonArtikelsBestelling = new List<JsonArtikel>();
            totaalsaldoBestelling = 0;
            btnToevoegenBestellingenAankoop.Enabled = true;
        }
        private bool CheckEncrypted(string filePath)
        {
            string naamFileZonderExtentie = Path.GetFileNameWithoutExtension(filePath);
            bool eindigdOp_Encrypted = false;

            if (naamFileZonderExtentie.ToUpper().Contains("_ENCRYPTED"))
            {
                eindigdOp_Encrypted = true;
            }

            return eindigdOp_Encrypted;
        }
        private void CmbArtikelVullen()
        {
            try
            {
                if (voorlopigeJsonOpmaak != null)
                {
                    if (voorlopigeJsonOpmaak.Levering != null)
                    {
                        lijstArtikelsCombobox = new List<JsonArtikel>(voorlopigeJsonOpmaak.Levering);
                        RefreshCombobox();
                    }
                    else
                    {
                        MessageBox.Show("Er is een fout opgetreden bij het inladen van de artikels.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van de gegevens.", ex.GetType().ToString());
            }
        }
        private void JSONBestandJsonOpmaakInlezen(string filePath)
        {
            try
            {
                voorlopigeJsonOpmaak = new JsonOpmaak();
                using (StreamReader mijnReader = new StreamReader(filePath))
                {
                    string json = mijnReader.ReadToEnd();
                    voorlopigeJsonOpmaak = JsonSerializer.Deserialize<JsonOpmaak>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inlezen van het JSON-bestand.", ex.GetType().ToString());
            }
        }
        private void XMLBestandJsonOpmaakInlezen(string filePath)
        {
            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);

                    XmlNode nodeBestelling = xmlDoc.SelectSingleNode("/Bestelling/Bestelling");

                    if (nodeBestelling != null)
                    {
                        voorlopigeJsonOpmaak = new JsonOpmaak();
                        voorlopigeJsonOpmaak.Levering = new List<JsonArtikel>();

                        XmlNode datumNode = nodeBestelling.SelectSingleNode("Datum");
                        voorlopigeJsonOpmaak.DatumOntvangst = DateTime.Parse(datumNode.InnerText);

                        XmlNode bedrijfsnaamNode = nodeBestelling.SelectSingleNode("Bedrijfsnaam");
                        voorlopigeJsonOpmaak.Bedrijfsnaam = bedrijfsnaamNode.InnerText;

                        XmlNodeList nodesJsonArtikelen = nodeBestelling.SelectNodes(".//Artikelen/Artikel");
                        foreach (XmlNode ditArtikel in nodesJsonArtikelen)
                        {
                            JsonArtikel artikel1 = new JsonArtikel();

                            artikel1.Naam = ditArtikel.ChildNodes[0].InnerText;
                            artikel1.Aantal = int.Parse(ditArtikel.ChildNodes[1].InnerText);
                            artikel1.Prijs = double.Parse(ditArtikel.ChildNodes[2].InnerText);

                            voorlopigeJsonOpmaak.Levering.Add(artikel1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Het XML formulier kan niet worden ingelezen, omdat dit niet het correcte formaat (Bestelling/Bestelling) heeft.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inlezen van het XML-bestand.", ex.GetType().ToString());
            }
        }
        private void JSONBestandJsonOpmaakBestellingSchrijven(string filePath, JsonOpmaak eenJsonOpmaak)
        {
            try
            {
                string json = JsonSerializer.Serialize(eenJsonOpmaak, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, json);

                MessageBox.Show("De bestelling is succesvol weggeschreven naar een JSON-bestand.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanmaken van het JSON-bestand.", ex.GetType().ToString());
            }
        }
        private void XMLBestandJsonOpmaakBestellingSchrijven(string filePath, JsonOpmaak eenJsonOpmaak)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("Bestelling");
                xmlDoc.AppendChild(mainRoot);

                XmlElement root = xmlDoc.CreateElement("Bestelling");
                mainRoot.AppendChild(root);

                XmlElement datumBestelling = xmlDoc.CreateElement("Datum");
                datumBestelling.InnerText = eenJsonOpmaak.DatumOntvangst.ToString();
                root.AppendChild(datumBestelling);

                XmlElement bedrijfsnaam = xmlDoc.CreateElement("Bedrijfsnaam");
                bedrijfsnaam.InnerText = eenJsonOpmaak.Bedrijfsnaam;
                root.AppendChild(bedrijfsnaam);

                XmlElement artikelen = xmlDoc.CreateElement("Artikelen");
                foreach (JsonArtikel ditArtikel in eenJsonOpmaak.Levering)
                {
                    XmlElement artikel = xmlDoc.CreateElement("Artikel");
                    artikelen.AppendChild(artikel);

                    XmlElement artikelNaam = xmlDoc.CreateElement("Naam");
                    artikelNaam.InnerText = ditArtikel.Naam;
                    artikel.AppendChild(artikelNaam);

                    XmlElement artikelAantal = xmlDoc.CreateElement("Aantal");
                    artikelAantal.InnerText = ditArtikel.Aantal.ToString();
                    artikel.AppendChild(artikelAantal);

                    XmlElement artikelPrijs = xmlDoc.CreateElement("Prijs");
                    artikelPrijs.InnerText = ditArtikel.Prijs.ToString().Replace(".", ",");
                    artikel.AppendChild(artikelPrijs);
                }
                root.AppendChild(artikelen);

                xmlDoc.Save(filePath);

                MessageBox.Show("De bestelling is succesvol weggeschreven naar een XML-bestand.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanmaken van het XML-bestand.", ex.GetType().ToString());
            }
        }
        private void SleutelInlezen(string pad)
        {
            arrSleutel = null;
            using (StreamReader mijnreader = new StreamReader(pad))
            {
                arrSleutel = mijnreader.ReadToEnd().ToCharArray();
            }
        }
        private void RefreshCombobox()
        {
            cmbArtikel.DataSource = null;
            cmbArtikel.DataSource = lijstArtikelsCombobox;
            cmbArtikel.DisplayMember = "Naam";
        }
    }
}


