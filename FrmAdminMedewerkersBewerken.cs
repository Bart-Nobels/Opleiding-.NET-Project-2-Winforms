using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmAdminMedewerkersBewerken : Form
    {
        static string superAdminNaam = "Hans";  //Beter linken naar extern bestand in cloud
        static string superAdminPaswoord = "123";

        private Form1 frm1Instance;
        GebruikerPlus geselecteerdeWerknemer;
        List<GebruikerPlus> lijstTijdelijkeOpslagGebruikersPlus;

        public FrmAdminMedewerkersBewerken(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }
        public List<GebruikersRol> LijstGebruikersrollenAdminMedewerkerBewerken
        {
            get { return frm1Instance.LijstGebruikersrollen; }
            set { frm1Instance.LijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikersAdminMedewerkerBewerken
        {
            get { return frm1Instance.LijstGebruikers; }
            set { frm1Instance.LijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingenAdminMedewerkerBewerken
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlusAdminMedewerkerBewerken
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAdminMedewerkerBewerken
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmAdminMedewerkersBewerken_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                lijstTijdelijkeOpslagGebruikersPlus = new List<GebruikerPlus>();

                foreach (GebruikerPlus g in LijstGebruikersPlusAdminMedewerkerBewerken) //Bart: Als ingelogdegebruiker een superadmin is alleen admins tonen.
                {
                    if (!(IngelogdeGebruikerAdminMedewerkerBewerken.Gebruikersnaam == superAdminNaam) && !(IngelogdeGebruikerAdminMedewerkerBewerken.Gebruikersnaam == superAdminPaswoord))
                    {
                        lstMedewerkers.Items.Add(g.ToString());
                        lijstTijdelijkeOpslagGebruikersPlus.Add(g);
                    }
                    else
                    {
                        if (g.GebruikersRol.Naam.ToUpper() == "ADMIN" || g.GebruikersRol.Naam.ToUpper() == "ADMINISTRATOR")
                        {
                            lstMedewerkers.Items.Add(g.ToString());
                            lijstTijdelijkeOpslagGebruikersPlus.Add(g);
                        }
                    }
                }
                RefreshListboxMedewerkers();
                RefreshListboxAfdelingen();
                geselecteerdeWerknemer = (GebruikerPlus)lstMedewerkers.SelectedItem; //Bart: kijkt in geselecteerdeWerknemer.LijstAfdelingen en selecteerd de afdelingen van die gebruiker in de listbox.
                for (int i = 0; i < lstAfdelingen.Items.Count; i++)
                {
                    Afdeling a = (Afdeling)lstAfdelingen.Items[i];

                    if (geselecteerdeWerknemer.LijstAfdelingen.Any(afd => afd == a))
                    {
                        lstAfdelingen.SetSelected(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van de lijst met werknemers.", ex.GetType().ToString());
            }
        }
        private void lstMedewerkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstMedewerkers.SelectedItem != null)
                {
                    geselecteerdeWerknemer = (GebruikerPlus)lstMedewerkers.SelectedItem;

                    RefreshGebruikersRol();

                    cmbGebruikersrol.SelectedItem = geselecteerdeWerknemer.GebruikersRol;

                    txtNaamGebruiker.Text = geselecteerdeWerknemer.Naam;
                    txtVoornaamGebruiker.Text = geselecteerdeWerknemer.Voornaam;
                    txtGebruikersnaamGebruiker.Text = geselecteerdeWerknemer.Gebruikersnaam;
                    txtPaswoordGebruiker.Text = geselecteerdeWerknemer.Paswoord;
                    txtAdresGebruiker.Text = geselecteerdeWerknemer.Adres;
                    txtRekeningnummerGebruiker.Text = geselecteerdeWerknemer.Rekeningnummer;
                    txtTelefoonnummerGebruiker.Text = geselecteerdeWerknemer.Telefoonnummer;
                    txtLoonGebruiker.Text = geselecteerdeWerknemer.Loon.ToString("0.00");
                    nudTellerPaswoord.Value = geselecteerdeWerknemer.TellerPaswoord;

                    RefreshListboxAfdelingen();

                    for (int i = 0; i < lstAfdelingen.Items.Count; i++) //Bart: kijkt in geselecteerdeWerknemer.LijstAfdelingen en selecteerd de afdelingen van die gebruiker in de listbox.
                    {
                        Afdeling a = (Afdeling)lstAfdelingen.Items[i];

                        foreach (Afdeling afd in geselecteerdeWerknemer.LijstAfdelingen)
                        {
                            if (a.Guid == afd.Guid)
                            {
                                lstAfdelingen.SetSelected(i, true);
                            }
                        }
                    }

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
        private void cmbGebruikersrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (geselecteerdeWerknemer != null)
                {
                    if (cmbGebruikersrol.SelectedIndex != -1)
                    {
                        GebruikersRol geselecteerdeRol = (GebruikersRol)cmbGebruikersrol.SelectedItem;

                        cbXMLBewerken.Checked = geselecteerdeRol.KanBewerkenXml;
                        cbXMLAanmaken.Checked = geselecteerdeRol.KanAanmakenXml;
                        cbXMLLezen.Checked = geselecteerdeRol.KanLezenXml;
                        cbXMLEncrypteren.Checked = geselecteerdeRol.KanEncrypterenXml;
                        cbTXTBewerken.Checked = geselecteerdeRol.KanBewerkenTxt;
                        cbTXTAanmaken.Checked = geselecteerdeRol.KanAanmakenTxt;
                        cbTXTLezen.Checked = geselecteerdeRol.KanLezenTxt;
                        cbTXTEncrypteren.Checked = geselecteerdeRol.KanEncrypterenTxt;
                        cbJSONBewerken.Checked = geselecteerdeRol.KanBewerkenJson;
                        cbJSONAanmaken.Checked = geselecteerdeRol.KanAanmakenJson;
                        cbJSONLezen.Checked = geselecteerdeRol.KanLezenJson;
                        cbJSONEncrypteren.Checked = geselecteerdeRol.KanEncrypterenJson;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het laden van de gebruikersrollen.", ex.GetType().ToString());
            }
        }
        private void btnBewerken_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstMedewerkers.SelectedItem != null)
                {
                    if (!string.IsNullOrEmpty(txtNaamGebruiker.Text) && !string.IsNullOrEmpty(txtVoornaamGebruiker.Text) && !string.IsNullOrEmpty(txtGebruikersnaamGebruiker.Text) && !string.IsNullOrEmpty(txtPaswoordGebruiker.Text))
                    {
                        if (!txtNaamGebruiker.Text.Any(char.IsDigit) && !txtVoornaamGebruiker.Text.Any(char.IsDigit))
                        {
                            if (double.TryParse(txtLoonGebruiker.Text, out double result))
                            {
                                GebruikerPlus geselecteerdeWerknemer = (GebruikerPlus)lstMedewerkers.SelectedItem;

                                geselecteerdeWerknemer.GebruikersRol = (GebruikersRol)cmbGebruikersrol.SelectedItem;
                                geselecteerdeWerknemer.Naam = txtNaamGebruiker.Text;
                                geselecteerdeWerknemer.Voornaam = txtVoornaamGebruiker.Text;
                                geselecteerdeWerknemer.Gebruikersnaam = txtGebruikersnaamGebruiker.Text;
                                geselecteerdeWerknemer.Paswoord = txtPaswoordGebruiker.Text;
                                geselecteerdeWerknemer.Adres = txtAdresGebruiker.Text;
                                geselecteerdeWerknemer.Rekeningnummer = txtRekeningnummerGebruiker.Text;
                                geselecteerdeWerknemer.Telefoonnummer = txtTelefoonnummerGebruiker.Text;
                                geselecteerdeWerknemer.Loon = Convert.ToDouble(txtLoonGebruiker.Text.Replace(".", ","));
                                geselecteerdeWerknemer.TellerPaswoord = Convert.ToInt32(nudTellerPaswoord.Value);

                                foreach (Afdeling eenAfdeling in lstAfdelingen.Items) //Bart: voegt geselecteerde items toe aan geselecteerdeWerknemer.LijstAfdelingen en verwijderd de niet geselecteerde items.
                                {
                                    if (lstAfdelingen.SelectedItems.Contains(eenAfdeling))
                                    {
                                        if (!geselecteerdeWerknemer.LijstAfdelingen.Contains(eenAfdeling))
                                        {
                                            geselecteerdeWerknemer.LijstAfdelingen.Add(eenAfdeling);
                                        }
                                    }
                                    else
                                    {
                                        if (geselecteerdeWerknemer.LijstAfdelingen.Contains(eenAfdeling))
                                        {
                                            geselecteerdeWerknemer.LijstAfdelingen.Remove(eenAfdeling);
                                        }
                                    }
                                }

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

                                RollenSchrijven();
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
        private void RefreshListboxMedewerkers()
        {
            lstMedewerkers.DataSource = null;
            lstMedewerkers.DataSource = lijstTijdelijkeOpslagGebruikersPlus;
        }
        private void RefreshGebruikersRol()
        {
            cmbGebruikersrol.DataSource = null;
            cmbGebruikersrol.DataSource = LijstGebruikersrollenAdminMedewerkerBewerken;
        }
        private void RefreshListboxAfdelingen()
        {
            lstAfdelingen.DataSource = null;
            lstAfdelingen.DataSource = LijstAfdelingenAdminMedewerkerBewerken;
            lstAfdelingen.ClearSelected();
        }
        private void RollenSchrijven()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("Rollen");
                xmlDoc.AppendChild(mainRoot);

                foreach (GebruikersRol dezeRol in LijstGebruikersrollenAdminMedewerkerBewerken)
                {
                    XmlElement root = xmlDoc.CreateElement("Rol");
                    mainRoot.AppendChild(root);

                    XmlElement rolNaam = xmlDoc.CreateElement("Naam");
                    rolNaam.InnerText = dezeRol.Naam;
                    root.AppendChild(rolNaam);

                    XmlElement rolID = xmlDoc.CreateElement("RolID");
                    rolID.InnerText = dezeRol.Guid.ToString();
                    root.AppendChild(rolID);

                    XmlElement xmlBewerken = xmlDoc.CreateElement("XMLBewerken");
                    xmlBewerken.InnerText = dezeRol.KanBewerkenXml.ToString();
                    root.AppendChild(xmlBewerken);

                    XmlElement xmlAanmaken = xmlDoc.CreateElement("XMLAanmaken");
                    xmlAanmaken.InnerText = dezeRol.KanAanmakenXml.ToString();
                    root.AppendChild(xmlAanmaken);

                    XmlElement xmlLezen = xmlDoc.CreateElement("XMLLezen");
                    xmlLezen.InnerText = dezeRol.KanLezenXml.ToString();
                    root.AppendChild(xmlLezen);

                    XmlElement xmlEncrypteren = xmlDoc.CreateElement("XMLEncrypteren");
                    xmlEncrypteren.InnerText = dezeRol.KanEncrypterenXml.ToString();
                    root.AppendChild(xmlEncrypteren);

                    XmlElement txtBewerken = xmlDoc.CreateElement("TXTBewerken");
                    txtBewerken.InnerText = dezeRol.KanBewerkenTxt.ToString();
                    root.AppendChild(txtBewerken);

                    XmlElement txtAanmaken = xmlDoc.CreateElement("TXTAanmaken");
                    txtAanmaken.InnerText = dezeRol.KanAanmakenTxt.ToString();
                    root.AppendChild(txtAanmaken);

                    XmlElement txtLezen = xmlDoc.CreateElement("TXTLezen");
                    txtLezen.InnerText = dezeRol.KanLezenTxt.ToString();
                    root.AppendChild(txtLezen);

                    XmlElement txtEncrypteren = xmlDoc.CreateElement("TXTEncrypteren");
                    txtEncrypteren.InnerText = dezeRol.KanEncrypterenTxt.ToString();
                    root.AppendChild(txtEncrypteren);

                    XmlElement jsonBewerken = xmlDoc.CreateElement("JSONBewerken");
                    jsonBewerken.InnerText = dezeRol.KanBewerkenJson.ToString();
                    root.AppendChild(jsonBewerken);

                    XmlElement jsonAanmaken = xmlDoc.CreateElement("JSONAanmaken");
                    jsonAanmaken.InnerText = dezeRol.KanAanmakenJson.ToString();
                    root.AppendChild(jsonAanmaken);

                    XmlElement jsonLezen = xmlDoc.CreateElement("JSONLezen");
                    jsonLezen.InnerText = dezeRol.KanLezenJson.ToString();
                    root.AppendChild(jsonLezen);

                    XmlElement jsonEncrypteren = xmlDoc.CreateElement("JSONEncrypteren");
                    jsonEncrypteren.InnerText = dezeRol.KanEncrypterenJson.ToString();
                    root.AppendChild(jsonEncrypteren);
                }
                xmlDoc.Save("Gebruikersrollen.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de lijst met gebruikersrollen.", ex.GetType().ToString());
            }
        }
        private void GebruikersPlusSchrijven()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("GebruikersPlus");
                xmlDoc.AppendChild(mainRoot);

                foreach (GebruikerPlus dezeGebruikerPlus in LijstGebruikersPlusAdminMedewerkerBewerken)
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
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de lijst met gebruikersgegevens.", ex.GetType().ToString());
            }
        }
    }
}
