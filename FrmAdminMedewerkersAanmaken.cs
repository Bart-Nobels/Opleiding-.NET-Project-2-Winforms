using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmAdminMedewerkersAanmaken : Form
    {
        private Form1 frm1Instance;
        private bool checkGebruikersnaam = false;

        public FrmAdminMedewerkersAanmaken(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikersRol> LijstGebruikersrollenAdminMedewerkerAanmaken
        {
            get { return frm1Instance.LijstGebruikersrollen; }
            set { frm1Instance.LijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikersAdminMedewerkerAanmaken
        {
            get { return frm1Instance.LijstGebruikers; }
            set { frm1Instance.LijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingenAdminMedewerkerAanmaken
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlusAdminMedewerkerAanmaken
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAdminMedewerkerAanmaken
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmAdminMedewerkersAanmaken_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            cmbGebruikersrol.DataSource = LijstGebruikersrollenAdminMedewerkerAanmaken;
            lstAfdelingen.DataSource = LijstAfdelingenAdminMedewerkerAanmaken;
            lstAfdelingen.ClearSelected(); //Zorgt er voor dat er geen item in de listbox geselecteerd staat
        }
        private void btnAanmaken_Click(object sender, EventArgs e) //Bart: gebruikersrollen aanmaken
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNaam.Text))
                {
                    GebruikersRol mijnGebruikersrol = new GebruikersRol(txtNaam.Text, cbXMLBewerken.Checked, cbXMLAanmaken.Checked, cbXMLLezen.Checked, cbXMLEncrypteren.Checked, cbTXTBewerken.Checked, cbTXTAanmaken.Checked, cbTXTLezen.Checked, cbTXTEncrypteren.Checked, cbJSONBewerken.Checked, cbJSONAanmaken.Checked, cbJSONLezen.Checked, cbJSONEncrypteren.Checked);
                    bool checkBestaandeGebruikersrol = false;
                    foreach (GebruikersRol gr in LijstGebruikersrollenAdminMedewerkerAanmaken) //Bart: Check of GebruikersRol al bestaat
                    {
                        if (gr.Naam.ToUpper() == mijnGebruikersrol.Naam.ToUpper())
                        {
                            checkBestaandeGebruikersrol = true;
                            break;
                        }
                    }
                    if (checkBestaandeGebruikersrol == false)
                    {
                        LijstGebruikersrollenAdminMedewerkerAanmaken.Add(mijnGebruikersrol);
                        RollenSchrijven();
                        RefreshGebruikersRol();
                        UncheckAllCheckboxes();
                        txtNaam.Text = string.Empty;
                        MessageBox.Show("De gebruikersrol is aangemaakt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Er bestaat reeds een gebruikersrol met deze naam. Gelieve een andere naam te kiezen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        UncheckAllCheckboxes();
                        txtNaam.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Gelieve eerst een naam in te vullen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanmaken van de gebruikersrol", ex.GetType().ToString());
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
        private void btnGebruikerAanmaken_Click(object sender, EventArgs e) //Bart: GebruikersPlus aanmaken
        {
            try
            {
                GebruikerPlus nieuweGebruikerPlus;
                bool checkGebruikerPlusBestaat = false;

                if (!string.IsNullOrEmpty(txtNaamGebruiker.Text) && !string.IsNullOrEmpty(txtVoornaamGebruiker.Text) && !string.IsNullOrEmpty(txtGebruikersnaamGebruiker.Text) && !string.IsNullOrEmpty(txtPaswoordGebruiker.Text))
                {
                    if (!txtNaamGebruiker.Text.Any(char.IsDigit) && !txtVoornaamGebruiker.Text.Any(char.IsDigit))
                    {
                        if (double.TryParse(txtLoonGebruiker.Text, out double result))
                        {
                            foreach (GebruikerPlus gp in LijstGebruikersPlusAdminMedewerkerAanmaken)
                            {
                                if (txtGebruikersnaamGebruiker.Text == gp.Gebruikersnaam)
                                {
                                    checkGebruikersnaam = true; 
                                    break;
                                }
                            }
                            if (checkGebruikersnaam == false)
                            {
                                nieuweGebruikerPlus = new GebruikerPlus();
                                nieuweGebruikerPlus.GebruikersRol = (GebruikersRol)cmbGebruikersrol.SelectedItem;
                                nieuweGebruikerPlus.Naam = txtNaamGebruiker.Text;
                                nieuweGebruikerPlus.Voornaam = txtVoornaamGebruiker.Text;
                                nieuweGebruikerPlus.Gebruikersnaam = txtGebruikersnaamGebruiker.Text;
                                nieuweGebruikerPlus.Paswoord = txtPaswoordGebruiker.Text;
                                nieuweGebruikerPlus.Adres = txtAdresGebruiker.Text;
                                nieuweGebruikerPlus.Rekeningnummer = txtRekeningnummerGebruiker.Text;
                                nieuweGebruikerPlus.Telefoonnummer = txtTelefoonnummerGebruiker.Text;
                                nieuweGebruikerPlus.Loon = Double.Parse(txtLoonGebruiker.Text.Replace(".", ","));
                                nieuweGebruikerPlus.TellerPaswoord = Convert.ToInt32(nudTellerPaswoord.Value);

                                nieuweGebruikerPlus.LijstAfdelingen = new List<Afdeling>();
                                foreach (Afdeling eenAfdeling in lstAfdelingen.SelectedItems) //Bart: geselecteerde afdelingen ui listbox toevoegen aan nieuweGebruikerPlus.LijstAfdelingen
                                {
                                    nieuweGebruikerPlus.LijstAfdelingen.Add(eenAfdeling);
                                }

                                foreach (GebruikerPlus gp in LijstGebruikersPlusAdminMedewerkerAanmaken) //Bart: Check of GebruikerPlus al bestaat
                                {
                                    if (gp.Naam.ToUpper() == nieuweGebruikerPlus.Naam.ToUpper() && gp.Voornaam.ToUpper() == nieuweGebruikerPlus.Voornaam.ToUpper() && gp.Gebruikersnaam.ToUpper() == nieuweGebruikerPlus.Gebruikersnaam.ToUpper())
                                    {
                                        checkGebruikerPlusBestaat = true;
                                        break;
                                    }
                                }
                                if (checkGebruikerPlusBestaat == false)
                                {
                                    LijstGebruikersPlusAdminMedewerkerAanmaken.Add(nieuweGebruikerPlus);
                                    GebruikersPlusSchrijven();
                                    VeldenGebruikerPlusLeegmaken();
                                    RefreshListboxAfdelingen();
                                    MessageBox.Show("De medewerker werd aangemaakt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (SystemException se)
            {
                MessageBox.Show(se.Message, se.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het aanmaken van de medewerker.", ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
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
        private void RefreshListboxAfdelingen()
        {
            lstAfdelingen.DataSource = null;
            lstAfdelingen.DataSource = LijstAfdelingenAdminMedewerkerAanmaken;
            lstAfdelingen.ClearSelected();
        }
        private void RefreshGebruikersRol()
        {
            cmbGebruikersrol.DataSource = null;
            cmbGebruikersrol.DataSource = LijstGebruikersrollenAdminMedewerkerAanmaken;
        }
        private void VeldenGebruikerPlusLeegmaken()
        {
            cmbGebruikersrol.DataSource = null;
            cmbGebruikersrol.DataSource = LijstGebruikersrollenAdminMedewerkerAanmaken;
            txtNaamGebruiker.Text = string.Empty;
            txtVoornaamGebruiker.Text = string.Empty;
            txtGebruikersnaamGebruiker.Text = string.Empty;
            txtPaswoordGebruiker.Text = string.Empty;
            txtAdresGebruiker.Text = string.Empty;
            txtTelefoonnummerGebruiker.Text = string.Empty;
            txtRekeningnummerGebruiker.Text = string.Empty;
            txtLoonGebruiker.Text = string.Empty;
            nudTellerPaswoord.Value = 0;
        }
        private void RollenSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("Rollen");
            xmlDoc.AppendChild(mainRoot);

            foreach (GebruikersRol dezeRol in LijstGebruikersrollenAdminMedewerkerAanmaken)
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
        private void GebruikersPlusSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("GebruikersPlus");
            xmlDoc.AppendChild(mainRoot);

            foreach (GebruikerPlus dezeGebruikerPlus in LijstGebruikersPlusAdminMedewerkerAanmaken)
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
