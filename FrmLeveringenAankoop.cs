using System.Text.Json;
using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmLeveringenAankoop : Form
    {
        private string currentDirectory;
        private string selectedFilePath;
        private double totaalsaldoLevering = 0;
        private string directorySleutelTeam2 = Environment.CurrentDirectory + @"\Sleutels\HuidigeSleutel_Team2\Sleutel_Groep_2.txt";
        static string[] opdelingWarenhuis = new string[] { "A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "C1", "C2", "C3", "C4", "C5", "C6" };
        private string nieuwFilePath;
        private char[] arrSleutel;

        Form1 frm1Instance;
        DialogResult antwoordMessageBox;
        JsonOpmaak voorlopigeJsonOpmaak;
        Encryptie nieuweEncryptie;
        Leverancier dezeLeverancier;
        AankoopFactuur nieuweAankoopfactuur;
        List<AankoopArtikel> lijstAankoopArtikelenVoorFactuur;

        public FrmLeveringenAankoop(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusAankoopLeveringen
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Leverancier> LijstLeveranciersAankoopLeveringen
        {
            get { return frm1Instance.LijstLeveranciers; }
            set { frm1Instance.LijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikelsAankoopLeveringen
        {
            get { return frm1Instance.LijstAankoopArtikels; }
            set { frm1Instance.LijstAankoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturenAankoopLeveringen
        {
            get { return frm1Instance.LijstAankoopFacturen; }
            set { frm1Instance.LijstAankoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAankoopLeveringen
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }
        public List<VerkoopArtikel> LijstVerkoopArtikelsAankoopLeveringen
        {
            get { return frm1Instance.LijstVerkoopArtikels; }
            set { frm1Instance.LijstVerkoopArtikels = value; }
        }

        private void FrmLeveringenAankoop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            rdoJSONLeveringenAankoop.Checked = true;
        }
        private void btnZoekenLeveringenAankoop_Click(object sender, EventArgs e)
        {
            FormulierLeegmaken();
            currentDirectory = Environment.CurrentDirectory + @"\Leveringen";
            if (Directory.Exists(currentDirectory))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = currentDirectory;

                        if (rdoJSONLeveringenAankoop.Checked)
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
                            txtBestandsNaamLeveringenAankoop.Text = Path.GetFileName(selectedFilePath);

                            if (CheckEncrypted(selectedFilePath) == false)
                            {
                                if (rdoJSONLeveringenAankoop.Checked)
                                {
                                    JSONBestandJsonOpmaakLeveringInlezen(selectedFilePath);
                                }
                                else
                                {
                                    XMLBestandJsonOpmaakLeveringInlezen(selectedFilePath);
                                }
                                TekstboxenVullenNaZoekenBestand();
                                OpvullenComboboxPlaatsInWarenhuid();
                            }
                            else
                            {
                                //Bart: HIER DECRYPTIE:
                                SleutelInlezen(directorySleutelTeam2);
                                nieuwFilePath = selectedFilePath.Replace("_Encrypted", "");
                                nieuweEncryptie = new Encryptie();

                                if (rdoJSONLeveringenAankoop.Checked && txtBestandsNaamLeveringenAankoop.Text.EndsWith(".json") && IngelogdeGebruikerAankoopLeveringen.GebruikersRol.KanEncrypterenJson == true)
                                {
                                    nieuweEncryptie.Decrypteren(selectedFilePath, nieuwFilePath, arrSleutel); //Bart: Decryptie
                                    JSONBestandJsonOpmaakLeveringInlezen(nieuwFilePath);
                                    File.Delete(nieuwFilePath);
                                    TekstboxenVullenNaZoekenBestand();
                                    OpvullenComboboxPlaatsInWarenhuid();
                                }
                                else if (rdoXMLLeveringenAankoop.Checked && txtBestandsNaamLeveringenAankoop.Text.EndsWith(".xml") && IngelogdeGebruikerAankoopLeveringen.GebruikersRol.KanEncrypterenXml == true)
                                {
                                    nieuweEncryptie.Decrypteren(selectedFilePath, nieuwFilePath, arrSleutel); //Bart: Decryptie
                                    XMLBestandJsonOpmaakLeveringInlezen(nieuwFilePath);
                                    File.Delete(nieuwFilePath);
                                    TekstboxenVullenNaZoekenBestand();
                                    OpvullenComboboxPlaatsInWarenhuid();
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
        private void btnVerwerkenLeveringenAankoop_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != string.Empty)
            {
                if (cmbPlaatsInWarenhuis.SelectedIndex != -1)
                {
                    antwoordMessageBox = MessageBox.Show("Bent u zeker dat u deze levering wil verwerken?", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (antwoordMessageBox == DialogResult.Yes)
                    {
                        try
                        {
                            lijstAankoopArtikelenVoorFactuur = new List<AankoopArtikel>();
                            dezeLeverancier = new Leverancier();
                            nieuweAankoopfactuur = new AankoopFactuur();

                            NieuwAankoopArtikelAanmaken();
                            LeverancierZoekenOfAanmaken();
                            NieuweAankoopFactuurOpmaken();

                            foreach (Leverancier l in LijstLeveranciersAankoopLeveringen)  //Bart: nieuwe aankoopfactuur toevoegen aan leverancier
                            {
                                if (dezeLeverancier.Naam.ToUpper() == l.Naam.ToUpper())
                                {
                                    l.LijstAankoopfacturenKlant.Add(nieuweAankoopfactuur);
                                    break;
                                }
                            }
                            LeveranciersSchrijven();
                            AankoopArtikelenSchrijven();
                            AankoopFacturenSchrijven();

                            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
                            {
                                try
                                {
                                    string doelmap = Environment.CurrentDirectory + @"\LeveringenArchief";

                                    BestandVerplaatsen(selectedFilePath, doelmap); //Bart: Leveringsbestand verplaatsen naar archief
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Er is een fout opgetreden bij het archiveren van het leveringsdocument.", ex.GetType().ToString());
                                }
                            }
                                MessageBox.Show("De levering is succesvol verwerkt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormulierLeegmaken();
                            }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Er is een fout opgetreden bij het verwerken van de levering.", ex.GetType().ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("De levering werd NIET verwerkt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Gelieve eerst een plaats in het warenhuis te selecteren.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("U moet eerst een levering zoeken alvorens u deze kan verwerken.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnFormulierLeegmaken_Click(object sender, EventArgs e)
        {
            try
            {
                antwoordMessageBox = MessageBox.Show("Bent u zeker dat u het formulier wil leegmaken?" + Environment.NewLine + "De levering zal NIET verwerkt worden.", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (antwoordMessageBox == DialogResult.Yes)
                {
                    FormulierLeegmaken();
                    rdoJSONLeveringenAankoop.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het leegmaken van het formulier.", ex.GetType().ToString());
            }
        }
        private void btnTerugLeveringenAankoop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void JSONBestandJsonOpmaakLeveringInlezen(string filePath)
        {
            try
            {
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
        private void XMLBestandJsonOpmaakLeveringInlezen(string filePath)
        {
            try
            {

                if (System.IO.File.Exists(filePath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);

                    XmlNode nodeLevering = xmlDoc.SelectSingleNode("/Levering/Levering");

                    if (nodeLevering != null)
                    {
                        voorlopigeJsonOpmaak = new JsonOpmaak();
                        voorlopigeJsonOpmaak.Levering = new List<JsonArtikel>();

                        XmlNode datumNode = nodeLevering.SelectSingleNode("Datum");
                        voorlopigeJsonOpmaak.DatumOntvangst = DateTime.Parse(datumNode.InnerText);

                        XmlNode bedrijfsnaamNode = nodeLevering.SelectSingleNode("Bedrijfsnaam");
                        voorlopigeJsonOpmaak.Bedrijfsnaam = bedrijfsnaamNode.InnerText;

                        XmlNodeList nodesJsonArtikelen = nodeLevering.SelectNodes(".//Artikelen/Artikel");
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
                        MessageBox.Show("Het XML formulier kan niet worden ingelezen, omdat dit niet het correcte formaat (Levering/Levering) heeft.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inlezen van het XML-bestand.", ex.GetType().ToString());
            }
        }
        private void OpvullenComboboxPlaatsInWarenhuid()
        {
            foreach (string plaatsInWarenhuis in opdelingWarenhuis)
            {
                bool komtNergensVoor = true;

                foreach (AankoopArtikel a in LijstAankoopArtikelsAankoopLeveringen)
                {
                    if (a.PlaatsInWarenhuis == plaatsInWarenhuis)
                    {
                        komtNergensVoor = false;
                        break;
                    }
                }
                if (komtNergensVoor)
                {
                    cmbPlaatsInWarenhuis.Items.Add(plaatsInWarenhuis);
                }
            }
        }
        private void TekstboxenVullenNaZoekenBestand()
        {
            try
            {
                if (voorlopigeJsonOpmaak != null)
                {
                    foreach (JsonArtikel a in voorlopigeJsonOpmaak.Levering)
                    {
                        txtOutput.Text += a.ToString();
                        totaalsaldoLevering += a.Prijs * a.Aantal;
                        txtTotaalsaldoLevering.Text = totaalsaldoLevering.ToString("0.00");
                    }
                    txtNaamLeverancier.Text = voorlopigeJsonOpmaak.Bedrijfsnaam;
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
        private void NieuwAankoopArtikelAanmaken()
        {
            try
            {
                foreach (JsonArtikel jsonA in voorlopigeJsonOpmaak.Levering)
                {
                    AankoopArtikel nieuwAankoopArtikel = new AankoopArtikel();
                    nieuwAankoopArtikel.Naam = jsonA.Naam;
                    nieuwAankoopArtikel.AantalInStock = jsonA.Aantal;    //IS DIT CORRECT? PAS LATER TOTAAL VAN ALLE SMIRNOFF ENZ BEREKENEN??
                    nieuwAankoopArtikel.Aankoopprijs = jsonA.Prijs;
                    nieuwAankoopArtikel.Datum = voorlopigeJsonOpmaak.DatumOntvangst;            //KLOPT DIT?
                    nieuwAankoopArtikel.PlaatsInWarenhuis = cmbPlaatsInWarenhuis.SelectedItem.ToString();

                    LijstAankoopArtikelsAankoopLeveringen.Add(nieuwAankoopArtikel);
                    lijstAankoopArtikelenVoorFactuur.Add(nieuwAankoopArtikel);

                    if (LijstVerkoopArtikelsAankoopLeveringen.Any(v => v.Naam.ToUpper() == nieuwAankoopArtikel.Naam.ToUpper()))
                    {
                        foreach (Artikel v in LijstVerkoopArtikelsAankoopLeveringen)
                        {
                            if (v.Naam.ToUpper() == nieuwAankoopArtikel.Naam.ToUpper())
                            {
                                v.AantalInStock += nieuwAankoopArtikel.AantalInStock;
                                frm1Instance.VerkoopArtikelenSchrijven();
                                break;
                            }
                        }

                    }
                    else
                    {
                        VerkoopArtikel nieuwVerkoopArtikel = new VerkoopArtikel();
                        nieuwVerkoopArtikel.Naam = nieuwAankoopArtikel.Naam;
                        nieuwVerkoopArtikel.AantalInStock = nieuwAankoopArtikel.AantalInStock;
                        nieuwVerkoopArtikel.Verkoopprijs = 1000;

                        // Add the new Verkoopartikel to LijstVerkoopArtikelsAankoopLeveringen
                        LijstVerkoopArtikelsAankoopLeveringen.Add(nieuwVerkoopArtikel);
                        frm1Instance.VerkoopArtikelenSchrijven();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het opslaan van de aangekochte artikelen.", ex.GetType().ToString());
            }
        }
        private void LeverancierZoekenOfAanmaken()
        {
            try
            {
                bool checkLeverancierBestaat = false;
                if (LijstLeveranciersAankoopLeveringen.Count != 0)
                {
                    foreach (Leverancier l in LijstLeveranciersAankoopLeveringen) //Bart: nakijken in lijst of leverancier al bestaat.
                    {
                        if (voorlopigeJsonOpmaak.Bedrijfsnaam.ToUpper() == l.Naam.ToUpper())
                        {
                            l.TotaalSaldoAankoop += Convert.ToDouble(txtTotaalsaldoLevering.Text.Replace(".", ","));
                            dezeLeverancier = l;
                            checkLeverancierBestaat = true;
                            break;
                        }
                        else
                        {
                            dezeLeverancier.Naam = voorlopigeJsonOpmaak.Bedrijfsnaam;
                            dezeLeverancier.TotaalSaldoAankoop = Convert.ToDouble(txtTotaalsaldoLevering.Text.Replace(".", ","));
                            dezeLeverancier.LijstAankoopfacturenKlant = new List<AankoopFactuur>();
                        }
                    }
                    if (checkLeverancierBestaat == false)
                    {
                        LijstLeveranciersAankoopLeveringen.Add(dezeLeverancier);
                    }
                }
                else
                {
                    dezeLeverancier.Naam = voorlopigeJsonOpmaak.Bedrijfsnaam;
                    dezeLeverancier.TotaalSaldoAankoop = Convert.ToDouble(txtTotaalsaldoLevering.Text.Replace(".", ","));
                    dezeLeverancier.LijstAankoopfacturenKlant = new List<AankoopFactuur>();
                    LijstLeveranciersAankoopLeveringen.Add(dezeLeverancier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het opslaan van de leverancier.", ex.GetType().ToString());
            }
        }
        private void NieuweAankoopFactuurOpmaken()
        {
            try
            {
                nieuweAankoopfactuur.Datum = DateTime.Now;
                nieuweAankoopfactuur.DezeGebruikerPlus = IngelogdeGebruikerAankoopLeveringen;
                nieuweAankoopfactuur.EenLeverancier = dezeLeverancier;
                nieuweAankoopfactuur.LijstAankoopArtikels = lijstAankoopArtikelenVoorFactuur;
                LijstAankoopFacturenAankoopLeveringen.Add(nieuweAankoopfactuur);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanmaken van de factuurgegevens.", ex.GetType().ToString());
            }
        }
        private void FormulierLeegmaken()
        {
            cmbPlaatsInWarenhuis.SelectedIndex = -1;
            cmbPlaatsInWarenhuis.Items.Clear();

            txtBestandsNaamLeveringenAankoop.Text = string.Empty;
            txtNaamLeverancier.Text = string.Empty;
            txtOutput.Text = string.Empty;
            txtTotaalsaldoLevering.Text = string.Empty;

            lijstAankoopArtikelenVoorFactuur = new List<AankoopArtikel>();
            totaalsaldoLevering = 0;
        }
        private void LeveranciersSchrijven()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("Leveranciers");
                xmlDoc.AppendChild(mainRoot);

                foreach (Leverancier dezeLeverancier in LijstLeveranciersAankoopLeveringen)
                {
                    XmlElement root = xmlDoc.CreateElement("Leverancier");
                    mainRoot.AppendChild(root);

                    XmlElement leverancierID = xmlDoc.CreateElement("ID");
                    leverancierID.InnerText = dezeLeverancier.Guid.ToString();
                    root.AppendChild(leverancierID);

                    XmlElement leverancierNaam = xmlDoc.CreateElement("Naam");
                    leverancierNaam.InnerText = dezeLeverancier.Naam;
                    root.AppendChild(leverancierNaam);

                    XmlElement adres = xmlDoc.CreateElement("Adres");
                    adres.InnerText = dezeLeverancier.Adres;
                    root.AppendChild(adres);

                    XmlElement telefoonnummer = xmlDoc.CreateElement("Telefoonnummer");
                    telefoonnummer.InnerText = dezeLeverancier.Telefoonnummer;
                    root.AppendChild(telefoonnummer);

                    XmlElement emailadres = xmlDoc.CreateElement("E-mail");
                    emailadres.InnerText = dezeLeverancier.Email;
                    root.AppendChild(emailadres);

                    XmlElement totaalSaldoAankoop = xmlDoc.CreateElement("TotaalSaldoVerkoop");
                    totaalSaldoAankoop.InnerText = dezeLeverancier.TotaalSaldoAankoop.ToString().Replace(".", ",");
                    root.AppendChild(totaalSaldoAankoop);

                    XmlElement aankoopFacturen = xmlDoc.CreateElement("AankoopFacturen");
                    foreach (AankoopFactuur dezeAankoopFactuur in dezeLeverancier.LijstAankoopfacturenKlant)
                    {
                        XmlElement aankoopFactuur = xmlDoc.CreateElement("AankoopFactuur");
                        aankoopFacturen.AppendChild(aankoopFactuur);

                        XmlElement datumOpmaakFactuur = xmlDoc.CreateElement("DatumOpmaakFactuur");
                        datumOpmaakFactuur.InnerText = dezeAankoopFactuur.Datum.ToString();
                        aankoopFactuur.AppendChild(datumOpmaakFactuur);

                        XmlElement aankoopFactuurID = xmlDoc.CreateElement("ID");
                        aankoopFactuurID.InnerText = dezeAankoopFactuur.Guid.ToString();
                        aankoopFactuur.AppendChild(aankoopFactuurID);

                        XmlElement naamMedewerker = xmlDoc.CreateElement("NaamMedewerker");
                        naamMedewerker.InnerText = dezeAankoopFactuur.DezeGebruikerPlus.Naam;
                        aankoopFactuur.AppendChild(naamMedewerker);

                        XmlElement voornaamMedewerker = xmlDoc.CreateElement("VoornaamMedewerker");
                        voornaamMedewerker.InnerText = dezeAankoopFactuur.DezeGebruikerPlus.Voornaam;
                        aankoopFactuur.AppendChild(voornaamMedewerker);

                        XmlElement naamLeverancier = xmlDoc.CreateElement("NaamLeverancier");
                        naamLeverancier.InnerText = dezeAankoopFactuur.EenLeverancier.Naam;
                        aankoopFactuur.AppendChild(naamLeverancier);

                        XmlElement aankoopArtikelen = xmlDoc.CreateElement("AankoopArtikelen");
                        foreach (AankoopArtikel ditAankoopArtikel in dezeAankoopFactuur.LijstAankoopArtikels)
                        {
                            XmlElement aankoopArtikel = xmlDoc.CreateElement("AankoopArtikel");
                            aankoopArtikelen.AppendChild(aankoopArtikel);

                            XmlElement naam = xmlDoc.CreateElement("Naam");
                            naam.InnerText = ditAankoopArtikel.Naam;
                            aankoopArtikel.AppendChild(naam);

                            XmlElement aankoopArtikelID = xmlDoc.CreateElement("ID");
                            aankoopArtikelID.InnerText = ditAankoopArtikel.Guid.ToString();
                            aankoopArtikel.AppendChild(aankoopArtikelID);

                            XmlElement aantalInStock = xmlDoc.CreateElement("AantalInStock");
                            aantalInStock.InnerText = ditAankoopArtikel.AantalInStock.ToString();
                            aankoopArtikel.AppendChild(aantalInStock);

                            XmlElement aankoopprijs = xmlDoc.CreateElement("Aankoopprijs");
                            aankoopprijs.InnerText = ditAankoopArtikel.Aankoopprijs.ToString().Replace(".", ",");
                            aankoopArtikel.AppendChild(aankoopprijs);

                            XmlElement plaatsInWarenhuis = xmlDoc.CreateElement("PlaatsInWarenhuis");
                            plaatsInWarenhuis.InnerText = ditAankoopArtikel.PlaatsInWarenhuis;
                            aankoopArtikel.AppendChild(plaatsInWarenhuis);

                            XmlElement datumAankoopArtikel = xmlDoc.CreateElement("DatumVanAankoop");
                            datumAankoopArtikel.InnerText = ditAankoopArtikel.Datum.ToString();
                            aankoopArtikel.AppendChild(datumAankoopArtikel);
                        }
                        aankoopFactuur.AppendChild(aankoopArtikelen);
                    }
                    root.AppendChild(aankoopFacturen);
                }
                xmlDoc.Save("Leveranciers.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de lijst met leveranciers.", ex.GetType().ToString());
            }
        }
        private void AankoopArtikelenSchrijven()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("AankoopArtikelen");
                xmlDoc.AppendChild(mainRoot);

                foreach (AankoopArtikel ditAankoopArtikel in LijstAankoopArtikelsAankoopLeveringen)
                {
                    XmlElement root = xmlDoc.CreateElement("AankoopArtikel");
                    mainRoot.AppendChild(root);

                    XmlElement naam = xmlDoc.CreateElement("Naam");
                    naam.InnerText = ditAankoopArtikel.Naam;
                    root.AppendChild(naam);

                    XmlElement aankoopArtikelID = xmlDoc.CreateElement("ID");
                    aankoopArtikelID.InnerText = ditAankoopArtikel.Guid.ToString();
                    root.AppendChild(aankoopArtikelID);

                    XmlElement aantalInStock = xmlDoc.CreateElement("AantalInStock");
                    aantalInStock.InnerText = ditAankoopArtikel.AantalInStock.ToString();
                    root.AppendChild(aantalInStock);

                    XmlElement aankoopprijs = xmlDoc.CreateElement("Aankoopprijs");
                    aankoopprijs.InnerText = ditAankoopArtikel.Aankoopprijs.ToString().Replace(".", ",");
                    root.AppendChild(aankoopprijs);

                    XmlElement plaatsInWarenhuis = xmlDoc.CreateElement("PlaatsInWarenhuis");
                    plaatsInWarenhuis.InnerText = ditAankoopArtikel.PlaatsInWarenhuis;
                    root.AppendChild(plaatsInWarenhuis);

                    XmlElement datumAankoopArtikel = xmlDoc.CreateElement("DatumVanAankoop");
                    datumAankoopArtikel.InnerText = ditAankoopArtikel.Datum.ToString();
                    root.AppendChild(datumAankoopArtikel);
                }
                xmlDoc.Save("AankoopArtikelen.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de lijst met aankoopartikelen.", ex.GetType().ToString());
            }
        }
        private void AankoopFacturenSchrijven()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("AankoopFacturen");
                xmlDoc.AppendChild(mainRoot);

                foreach (AankoopFactuur dezeAankoopFactuur in LijstAankoopFacturenAankoopLeveringen)
                {
                    XmlElement root = xmlDoc.CreateElement("AankoopFactuur");
                    mainRoot.AppendChild(root);

                    XmlElement datumOpmaakFactuur = xmlDoc.CreateElement("DatumOpmaakFactuur");
                    datumOpmaakFactuur.InnerText = dezeAankoopFactuur.Datum.ToString();
                    root.AppendChild(datumOpmaakFactuur);

                    XmlElement aankoopFactuurID = xmlDoc.CreateElement("ID");
                    aankoopFactuurID.InnerText = dezeAankoopFactuur.Guid.ToString();
                    root.AppendChild(aankoopFactuurID);

                    XmlElement naamMedewerker = xmlDoc.CreateElement("NaamMedewerker");
                    naamMedewerker.InnerText = dezeAankoopFactuur.DezeGebruikerPlus.Naam;
                    root.AppendChild(naamMedewerker);

                    XmlElement voornaamMedewerker = xmlDoc.CreateElement("VoornaamMedewerker");
                    voornaamMedewerker.InnerText = dezeAankoopFactuur.DezeGebruikerPlus.Voornaam;
                    root.AppendChild(voornaamMedewerker);

                    XmlElement naamLeverancier = xmlDoc.CreateElement("NaamLeverancier");
                    naamLeverancier.InnerText = dezeAankoopFactuur.EenLeverancier.Naam;
                    root.AppendChild(naamLeverancier);

                    XmlElement aankoopArtikelen = xmlDoc.CreateElement("AankoopArtikelen");
                    foreach (AankoopArtikel ditAankoopArtikel in dezeAankoopFactuur.LijstAankoopArtikels)
                    {
                        XmlElement aankoopArtikel = xmlDoc.CreateElement("AankoopArtikel");
                        aankoopArtikelen.AppendChild(aankoopArtikel);

                        XmlElement naam = xmlDoc.CreateElement("Naam");
                        naam.InnerText = ditAankoopArtikel.Naam;
                        aankoopArtikel.AppendChild(naam);

                        XmlElement aankoopArtikelID = xmlDoc.CreateElement("ID");
                        aankoopArtikelID.InnerText = ditAankoopArtikel.Guid.ToString();
                        aankoopArtikel.AppendChild(aankoopArtikelID);

                        XmlElement aantalInStock = xmlDoc.CreateElement("AantalInStock");
                        aantalInStock.InnerText = ditAankoopArtikel.AantalInStock.ToString();
                        aankoopArtikel.AppendChild(aantalInStock);

                        XmlElement aankoopprijs = xmlDoc.CreateElement("Aankoopprijs");
                        aankoopprijs.InnerText = ditAankoopArtikel.Aankoopprijs.ToString().Replace(".", ",");
                        aankoopArtikel.AppendChild(aankoopprijs);

                        XmlElement plaatsInWarenhuis = xmlDoc.CreateElement("PlaatsInWarenhuis");
                        plaatsInWarenhuis.InnerText = ditAankoopArtikel.PlaatsInWarenhuis;
                        aankoopArtikel.AppendChild(plaatsInWarenhuis);

                        XmlElement datumAankoopArtikel = xmlDoc.CreateElement("DatumVanAankoop");
                        datumAankoopArtikel.InnerText = ditAankoopArtikel.Datum.ToString();
                        aankoopArtikel.AppendChild(datumAankoopArtikel);
                    }
                    root.AppendChild(aankoopArtikelen);
                }
                xmlDoc.Save("AankoopFacturen.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de lijst met aankoopfacturen.", ex.GetType().ToString());
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
        private void BestandVerplaatsen(string bestandspad, string doelmap)
        {
            if (!Directory.Exists(doelmap))
            {
                Directory.CreateDirectory(doelmap);
            }

            DateTime origineleDatum = File.GetCreationTime(bestandspad); //Bart: zoekt de originele opmaakdatum van het bestand.
            string nieuweBestandsnaam = Path.GetFileNameWithoutExtension(bestandspad) + "_" + origineleDatum.ToString("yyyyMMdd_HHmmss") + Path.GetExtension(bestandspad);
            string doelBestand = Path.Combine(doelmap, nieuweBestandsnaam);

            if (!File.Exists(doelBestand))
            {
                File.Move(bestandspad, doelBestand);
            }
            else
            {
                File.Delete(bestandspad);
            }
        }
    }
}
