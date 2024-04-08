using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmSuperAdmin : Form
    {
        private Form1 frm1Instance;
        private bool checkGebruikerPlusBestaat;
        private GebruikerPlus gebruikerPlus;
        private bool checkGebruikersnaam = false;

        public FrmSuperAdmin(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikersRol> LijstGebruikersrollenSuperAdmin
        {
            get { return frm1Instance.LijstGebruikersrollen; }
            set { frm1Instance.LijstGebruikersrollen = value; }
        }
        public List<Afdeling> LijstAfdelingenSuperAdmin
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlusSuperAdmin
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public GebruikerPlus IngelogdeGebruikerSuperAdmin
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmSuperAdmin_Load(object sender, EventArgs e)
        {
            cmbGebruikersrol.DataSource = LijstGebruikersrollenSuperAdmin;
        }
        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNaam.Text))
                {
                    GebruikersRol mijnGebruikersrol = new GebruikersRol(txtNaam.Text, cbXMLBewerken.Checked, cbXMLAanmaken.Checked, cbXMLLezen.Checked, cbXMLEncrypteren.Checked, cbTXTBewerken.Checked, cbTXTAanmaken.Checked, cbTXTLezen.Checked, cbTXTEncrypteren.Checked, cbJSONBewerken.Checked, cbJSONAanmaken.Checked, cbJSONLezen.Checked, cbJSONEncrypteren.Checked);
                    LijstGebruikersrollenSuperAdmin.Add(mijnGebruikersrol);
                    RollenSchrijven();
                    cmbGebruikersrol.DataSource = null;
                    cmbGebruikersrol.DataSource = LijstGebruikersrollenSuperAdmin;
                    UncheckAllCheckboxes();
                    txtNaam.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Gelieve de naam in te vullen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanmaken van de gebruikersrol.", ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnGebruikerAanmaken_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNaamGebruiker.Text) && !string.IsNullOrEmpty(txtVoornaamGebruiker.Text) && !string.IsNullOrEmpty(txtGebruikersnaamGebruiker.Text) && !string.IsNullOrEmpty(txtPaswoordGebruiker.Text))
                {
                    if (!txtNaamGebruiker.Text.Any(char.IsDigit) && !txtVoornaamGebruiker.Text.Any(char.IsDigit))
                    {
                        if(LijstGebruikersPlusSuperAdmin != null)
                        {
                            foreach (GebruikerPlus gp in LijstGebruikersPlusSuperAdmin)
                            {
                                if (txtGebruikersnaamGebruiker.Text == gp.Gebruikersnaam)
                                {
                                    checkGebruikersnaam = true;
                                    break;
                                }
                            }
                            if (checkGebruikersnaam == false)
                            {
                                gebruikerPlus = new GebruikerPlus((GebruikersRol)cmbGebruikersrol.SelectedItem, txtNaamGebruiker.Text, txtVoornaamGebruiker.Text,
                                                           txtGebruikersnaamGebruiker.Text, txtPaswoordGebruiker.Text, new List<Afdeling>(), 0, "Voorbeeldstraat 123, 1111 Voorbeeld", "BE00000000000000", "099 99 99 99", 0);

                                foreach (GebruikerPlus gp in LijstGebruikersPlusSuperAdmin) //Bart: Check of GebruikerPlus al bestaat
                                {
                                    if (gp.Naam.ToUpper() == gebruikerPlus.Naam.ToUpper() && gp.Voornaam.ToUpper() == gebruikerPlus.Voornaam.ToUpper() && gp.Gebruikersnaam.ToUpper() == gebruikerPlus.Gebruikersnaam.ToUpper())
                                    {
                                        checkGebruikerPlusBestaat = true;
                                        break;
                                    }
                                }
                                if (checkGebruikerPlusBestaat == false)
                                {
                                    LijstGebruikersPlusSuperAdmin.Add(gebruikerPlus);
                                    GebruikersPlusSchrijven();
                                    VeldenGebruikerLeegmaken();
                                    MessageBox.Show("De gebruiker werd aangemaakt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Deze medewerker werd reeds aangemaakt. Gelieve naar medewerkers bewerken te gaan indien u deze wenst te wijzigen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Er is reeds een gebruiker met deze gebruikersnaam. Gelieve een andere te kiezen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            checkGebruikersnaam = false;
                        }
                        else
                        {
                            gebruikerPlus = new GebruikerPlus((GebruikersRol)cmbGebruikersrol.SelectedItem, txtNaamGebruiker.Text, txtVoornaamGebruiker.Text,
                                                            txtGebruikersnaamGebruiker.Text, txtPaswoordGebruiker.Text, new List<Afdeling>(), 0, "Voorbeeldstraat 123, 1111 Voorbeeld", "BE00000000000000", "099 99 99 99", 0);
                            LijstGebruikersPlusSuperAdmin.Add(gebruikerPlus);
                            GebruikersPlusSchrijven();
                            VeldenGebruikerLeegmaken();
                            MessageBox.Show("De gebruiker werd aangemaakt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanmaken van de gebruiker.", ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            CheckAllCheckboxes();
        }
        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            UncheckAllCheckboxes();
        }
        private void btnAdminBewerken_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminMedewerkersBewerken medewerkersBewerkenScherm = new FrmAdminMedewerkersBewerken(frm1Instance);
            medewerkersBewerkenScherm.LijstGebruikersrollenAdminMedewerkerBewerken = frm1Instance.LijstGebruikersrollen;
            medewerkersBewerkenScherm.LijstGebruikersAdminMedewerkerBewerken = frm1Instance.LijstGebruikers;
            medewerkersBewerkenScherm.LijstAfdelingenAdminMedewerkerBewerken = frm1Instance.LijstAfdelingen;
            medewerkersBewerkenScherm.LijstGebruikersPlusAdminMedewerkerBewerken = frm1Instance.LijstGebruikersPlus;
            medewerkersBewerkenScherm.IngelogdeGebruikerAdminMedewerkerBewerken = frm1Instance.IngelogdeGebruiker;
            medewerkersBewerkenScherm.FormClosed += (s, args) => this.Show();
            medewerkersBewerkenScherm.ShowDialog();
        }
        private void btnEncryptieBenodigdheden_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminEncryptie medencryptieScherm = new FrmAdminEncryptie(frm1Instance);
            medencryptieScherm.IngelogdeGebruikerAdminEncryptie = frm1Instance.IngelogdeGebruiker;
            medencryptieScherm.FormClosed += (s, args) => this.Show();
            medencryptieScherm.ShowDialog();
        }
        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CheckAllCheckboxes()
        {
            cbXMLAanmaken.Checked = true;
            cbXMLBewerken.Checked = true;
            cbXMLLezen.Checked = true;
            cbXMLEncrypteren.Checked = true;
            cbTXTAanmaken.Checked = true;
            cbTXTBewerken.Checked = true;
            cbTXTLezen.Checked = true;
            cbTXTEncrypteren.Checked = true;
            cbJSONAanmaken.Checked = true;
            cbJSONBewerken.Checked = true;
            cbJSONLezen.Checked = true;
            cbJSONEncrypteren.Checked = true;
        }
        private void UncheckAllCheckboxes()
        {
            cbXMLAanmaken.Checked = false;
            cbXMLBewerken.Checked = false;
            cbXMLLezen.Checked = false;
            cbXMLEncrypteren.Checked = false;
            cbTXTAanmaken.Checked = false;
            cbTXTBewerken.Checked = false;
            cbTXTLezen.Checked = false;
            cbTXTEncrypteren.Checked = false;
            cbJSONAanmaken.Checked = false;
            cbJSONBewerken.Checked = false;
            cbJSONLezen.Checked = false;
            cbJSONEncrypteren.Checked = false;
        }
        private void VeldenGebruikerLeegmaken()
        {
            cmbGebruikersrol.DataSource = null;
            cmbGebruikersrol.DataSource = LijstGebruikersrollenSuperAdmin;
            txtNaamGebruiker.Text = string.Empty;
            txtVoornaamGebruiker.Text = string.Empty;
            txtGebruikersnaamGebruiker.Text = string.Empty;
            txtPaswoordGebruiker.Text = string.Empty;
        }
        private void GebruikersPlusSchrijven()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("GebruikersPlus");
                xmlDoc.AppendChild(mainRoot);

                foreach (GebruikerPlus dezeGebruikerPlus in LijstGebruikersPlusSuperAdmin)
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
        private void RollenSchrijven()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("Rollen");
                xmlDoc.AppendChild(mainRoot);

                foreach (GebruikersRol dezeRol in LijstGebruikersrollenSuperAdmin)
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
    }
}
