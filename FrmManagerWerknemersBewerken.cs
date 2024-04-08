using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmManagerWerknemersBewerken : Form
    {
        private Form1 frm1Instance;
        List<GebruikerPlus> lijstGebruikersPlusNaCheckAfdeling;

        public FrmManagerWerknemersBewerken(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusManagerBewerken
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public GebruikerPlus IngelogdeGebruikerManagerBewerken
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmManagerWerknemersBewerken_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                lijstGebruikersPlusNaCheckAfdeling = new List<GebruikerPlus>(); //Bart: Bijhouden welke GebruikersPlus slagen voor de check

                foreach (GebruikerPlus g in LijstGebruikersPlusManagerBewerken)
                {
                    string gebruikersRol = g.GebruikersRol.Naam.ToUpper();
                    if (!gebruikersRol.Equals("ADMIN") && !gebruikersRol.Equals("ADMINISTRATOR")) //Bart: Check of GebruikersPlus admins is, want manager mag gegevens admin niet wijzigen.
                    {
                        foreach (Afdeling a in IngelogdeGebruikerManagerBewerken.LijstAfdelingen)
                        {
                            if (g.LijstAfdelingen.Contains(a))
                            {
                                lijstGebruikersPlusNaCheckAfdeling.Add(g); //Bart: Gebruikersplus hier toevoegen aan de voorlopige list
                                lstWerknemers.Items.Add(g.ToString());
                                break;
                            }
                        }
                    }
                }
                RefreshListbox(); //Bart: In deze methode verwijzen naar lijstGebruikersPlusNaCheckAfdeling om correct te refreshen!
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van de lijst met werknemers.", ex.GetType().ToString());
            }
        }
        private void lstWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstWerknemers.SelectedItem != null)
                {
                    GebruikerPlus geselecteerdeWerknemer = (GebruikerPlus)lstWerknemers.SelectedItem;

                    if(geselecteerdeWerknemer.GebruikersRol.Naam.ToUpper() == "MANAGER") //Bart: Deze cb zorgen er voor dan manager doc van andere afdelingen kan bewerken. 
                    {                                                                    //Alleen admin mag dit aanpassen anders kan manager zichzelf toegang geven zonder enige controle.
                        cbJSONBewerken.Enabled = false;
                        cbTXTBewerken.Enabled = false;
                        cbXMLBewerken.Enabled = false;
                    }
                    else
                    {
                        cbJSONBewerken.Enabled = true;
                        cbTXTBewerken.Enabled = true;
                        cbXMLBewerken.Enabled = true;
                    }

                    txtGebruikersrol.Text = geselecteerdeWerknemer.GebruikersRol.ToString();
                    txtNaamGebruiker.Text = geselecteerdeWerknemer.Naam;
                    txtVoornaamGebruiker.Text = geselecteerdeWerknemer.Voornaam;
                    txtAdresGebruiker.Text = geselecteerdeWerknemer.Adres;
                    txtRekeningnummerGebruiker.Text = geselecteerdeWerknemer.Rekeningnummer;
                    txtTelefoonnummerGebruiker.Text = geselecteerdeWerknemer.Telefoonnummer;
                    txtLoonGebruiker.Text = geselecteerdeWerknemer.Loon.ToString("0.00");

                    cbXMLBewerken.Checked = geselecteerdeWerknemer.GebruikersRol.KanBewerkenXml;
                    cbXMLAanmaken.Checked = geselecteerdeWerknemer.GebruikersRol.KanAanmakenXml;
                    cbXMLLezen.Checked = geselecteerdeWerknemer.GebruikersRol.KanLezenXml;
                    cbXMLEncrypteren.Checked = geselecteerdeWerknemer.GebruikersRol.KanEncrypterenXml;
                    cbTXTBewerken.Checked = geselecteerdeWerknemer.GebruikersRol.KanBewerkenTxt;
                    cbTXTAanmaken.Checked = geselecteerdeWerknemer.GebruikersRol.KanAanmakenTxt;
                    cbTXTLezen.Checked = geselecteerdeWerknemer.GebruikersRol.KanLezenTxt;
                    cbTXTEncrypteren.Checked = geselecteerdeWerknemer.GebruikersRol.KanEncrypterenTxt;
                    cbJSONBewerken.Checked = geselecteerdeWerknemer.GebruikersRol.KanBewerkenJson;
                    cbJSONAanmaken.Checked = geselecteerdeWerknemer.GebruikersRol.KanAanmakenJson;
                    cbJSONLezen.Checked = geselecteerdeWerknemer.GebruikersRol.KanLezenJson;
                    cbJSONEncrypteren.Checked = geselecteerdeWerknemer.GebruikersRol.KanEncrypterenJson;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van de werknemersgegevens.", ex.GetType().ToString());
            }
        }
        private void btnBewerken_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstWerknemers.SelectedItem != null)
                {
                    if (!string.IsNullOrEmpty(txtNaamGebruiker.Text) && !string.IsNullOrEmpty(txtVoornaamGebruiker.Text))
                    {
                        if (!txtNaamGebruiker.Text.Any(char.IsDigit) && !txtVoornaamGebruiker.Text.Any(char.IsDigit))
                        {
                            if (double.TryParse(txtLoonGebruiker.Text, out double result))
                            {
                                GebruikerPlus geselecteerdeWerknemer = (GebruikerPlus)lstWerknemers.SelectedItem;

                                geselecteerdeWerknemer.Naam = txtNaamGebruiker.Text;
                                geselecteerdeWerknemer.Voornaam = txtVoornaamGebruiker.Text;
                                geselecteerdeWerknemer.Adres = txtAdresGebruiker.Text;
                                geselecteerdeWerknemer.Rekeningnummer = txtRekeningnummerGebruiker.Text;
                                geselecteerdeWerknemer.Telefoonnummer = txtTelefoonnummerGebruiker.Text;
                                geselecteerdeWerknemer.Loon = Convert.ToDouble(txtLoonGebruiker.Text.Replace(".", ","));

                                geselecteerdeWerknemer.GebruikersRol.KanBewerkenXml = cbXMLBewerken.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanAanmakenXml = cbXMLAanmaken.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanLezenXml = cbXMLLezen.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanEncrypterenXml = cbXMLEncrypteren.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanBewerkenTxt = cbTXTBewerken.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanAanmakenTxt = cbTXTAanmaken.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanLezenTxt = cbTXTLezen.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanEncrypterenTxt = cbTXTEncrypteren.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanBewerkenJson = cbJSONBewerken.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanAanmakenJson = cbJSONAanmaken.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanLezenJson = cbJSONLezen.Checked;
                                geselecteerdeWerknemer.GebruikersRol.KanEncrypterenJson = cbJSONEncrypteren.Checked;

                                GebruikersPlusSchrijven();

                                MessageBox.Show("De gegevens werden aangepast.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Gelieve een cijfer in te vullen bij loon.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("U mag geen cijfers gebruiken in de naam en/of voornaam.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gelieve eerst de nodige velden in te vullen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("U dient eerst een werknemer te selecteren alvorens u wijzigingen kan doorvoeren.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message, se.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de werknemersgegevens.", ex.GetType().ToString());
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        public void RefreshListbox()
        {
            lstWerknemers.DataSource = null;
            lstWerknemers.DataSource = lijstGebruikersPlusNaCheckAfdeling;
        }
        private void GebruikersPlusSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("GebruikersPlus");
            xmlDoc.AppendChild(mainRoot);

            foreach (GebruikerPlus dezeGebruikerPlus in LijstGebruikersPlusManagerBewerken)
            {
                XmlElement root = xmlDoc.CreateElement("GebruikerPlus");
                mainRoot.AppendChild(root);

                XmlElement gebruikersID = xmlDoc.CreateElement("ID");
                gebruikersID.InnerText = dezeGebruikerPlus.Guid.ToString();
                root.AppendChild(gebruikersID);

                XmlElement gebruikersNaam = xmlDoc.CreateElement("Naam");
                gebruikersNaam.InnerText = dezeGebruikerPlus.Naam;
                root.AppendChild(gebruikersNaam);

                XmlElement gebruikersVoornaam = xmlDoc.CreateElement("Voornaam");
                gebruikersVoornaam.InnerText = dezeGebruikerPlus.Voornaam;
                root.AppendChild(gebruikersVoornaam);

                XmlElement gebruikersnaam = xmlDoc.CreateElement("Gebruikersnaam");
                gebruikersnaam.InnerText = dezeGebruikerPlus.Gebruikersnaam;
                root.AppendChild(gebruikersnaam);

                XmlElement paswoord = xmlDoc.CreateElement("Paswoord");
                paswoord.InnerText = dezeGebruikerPlus.Paswoord;
                root.AppendChild(paswoord);

                XmlElement adres = xmlDoc.CreateElement("Adres");
                adres.InnerText = dezeGebruikerPlus.Adres;
                root.AppendChild(adres);

                XmlElement telefoonnummer = xmlDoc.CreateElement("Telefoonnummer");
                telefoonnummer.InnerText = dezeGebruikerPlus.Telefoonnummer;
                root.AppendChild(telefoonnummer);

                XmlElement rekeningnummer = xmlDoc.CreateElement("Rekeningnummer");
                rekeningnummer.InnerText = dezeGebruikerPlus.Rekeningnummer;
                root.AppendChild(rekeningnummer);

                XmlElement loon = xmlDoc.CreateElement("Loon");
                loon.InnerText = dezeGebruikerPlus.Loon.ToString().Replace(".", ",");
                root.AppendChild(loon);

                XmlElement tellerpaswoord = xmlDoc.CreateElement("TellerPaswoord");
                tellerpaswoord.InnerText = dezeGebruikerPlus.TellerPaswoord.ToString();
                root.AppendChild(tellerpaswoord);

                XmlElement afdelingen = xmlDoc.CreateElement("Afdelingen");
                foreach (Afdeling dezeAfdeling in dezeGebruikerPlus.LijstAfdelingen)
                {
                    XmlElement afdeling = xmlDoc.CreateElement("Afdeling");
                    afdelingen.AppendChild(afdeling);

                    XmlElement afdelingsNaam = xmlDoc.CreateElement("Naam");
                    afdelingsNaam.InnerText = dezeAfdeling.Naam;
                    afdeling.AppendChild(afdelingsNaam);

                    XmlElement afdelingsID = xmlDoc.CreateElement("ID");
                    afdelingsID.InnerText = dezeAfdeling.Guid.ToString();
                    afdeling.AppendChild(afdelingsID);

                    XmlElement afdelingOmschrijving = xmlDoc.CreateElement("Omschrijving");
                    afdelingOmschrijving.InnerText = dezeAfdeling.Omschrijving.ToString();
                    afdeling.AppendChild(afdelingOmschrijving);
                }
                root.AppendChild(afdelingen);

                XmlElement rolID = xmlDoc.CreateElement("RolID");
                rolID.InnerText = dezeGebruikerPlus.GebruikersRol.Guid.ToString();
                root.AppendChild(rolID);

                XmlElement rolNaam = xmlDoc.CreateElement("RolNaam");
                rolNaam.InnerText = dezeGebruikerPlus.GebruikersRol.Naam.ToString();
                root.AppendChild(rolNaam);

                XmlElement xmlBewerken = xmlDoc.CreateElement("XMLBewerken");
                xmlBewerken.InnerText = dezeGebruikerPlus.GebruikersRol.KanBewerkenXml.ToString();
                root.AppendChild(xmlBewerken);

                XmlElement xmlAanmaken = xmlDoc.CreateElement("XMLAanmaken");
                xmlAanmaken.InnerText = dezeGebruikerPlus.GebruikersRol.KanAanmakenXml.ToString();
                root.AppendChild(xmlAanmaken);

                XmlElement xmlLezen = xmlDoc.CreateElement("XMLLezen");
                xmlLezen.InnerText = dezeGebruikerPlus.GebruikersRol.KanLezenXml.ToString();
                root.AppendChild(xmlLezen);

                XmlElement xmlEncrypteren = xmlDoc.CreateElement("XMLEncrypteren");
                xmlEncrypteren.InnerText = dezeGebruikerPlus.GebruikersRol.KanEncrypterenXml.ToString();
                root.AppendChild(xmlEncrypteren);

                XmlElement txtBewerken = xmlDoc.CreateElement("TXTBewerken");
                txtBewerken.InnerText = dezeGebruikerPlus.GebruikersRol.KanBewerkenTxt.ToString();
                root.AppendChild(txtBewerken);

                XmlElement txtAanmaken = xmlDoc.CreateElement("TXTAanmaken");
                txtAanmaken.InnerText = dezeGebruikerPlus.GebruikersRol.KanAanmakenTxt.ToString();
                root.AppendChild(txtAanmaken);

                XmlElement txtLezen = xmlDoc.CreateElement("TXTLezen");
                txtLezen.InnerText = dezeGebruikerPlus.GebruikersRol.KanLezenTxt.ToString();
                root.AppendChild(txtLezen);

                XmlElement txtEncrypteren = xmlDoc.CreateElement("TXTEncrypteren");
                txtEncrypteren.InnerText = dezeGebruikerPlus.GebruikersRol.KanEncrypterenTxt.ToString();
                root.AppendChild(txtEncrypteren);

                XmlElement jsonBewerken = xmlDoc.CreateElement("JSONBewerken");
                jsonBewerken.InnerText = dezeGebruikerPlus.GebruikersRol.KanBewerkenJson.ToString();
                root.AppendChild(jsonBewerken);

                XmlElement jsonAanmaken = xmlDoc.CreateElement("JSONAanmaken");
                jsonAanmaken.InnerText = dezeGebruikerPlus.GebruikersRol.KanAanmakenJson.ToString();
                root.AppendChild(jsonAanmaken);

                XmlElement jsonLezen = xmlDoc.CreateElement("JSONLezen");
                jsonLezen.InnerText = dezeGebruikerPlus.GebruikersRol.KanLezenJson.ToString();
                root.AppendChild(jsonLezen);

                XmlElement jsonEncrypteren = xmlDoc.CreateElement("JSONEncrypteren");
                jsonEncrypteren.InnerText = dezeGebruikerPlus.GebruikersRol.KanEncrypterenJson.ToString();
                root.AppendChild(jsonEncrypteren);
            }
            xmlDoc.Save("GebruikersPlus.xml");
        }
    }
}
