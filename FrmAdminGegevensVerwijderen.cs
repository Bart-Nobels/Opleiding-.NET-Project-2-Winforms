using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmAdminGegevensVerwijderen : Form
    {
        private string currentDirectory;
        private string selectedFilePath;

        Form1 frm1Instance;
        GebruikerPlus geselecteerdeGebruiker;
        DialogResult antwoordMessageBox;
        List<GebruikersRol> lijstGebruikersRollenNaCheck;
        List<GebruikerPlus> lijstGebruikerPlusNaCheck;

        public FrmAdminGegevensVerwijderen(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikersRol> LijstGebruikersrollenAdminGegevensVerwijderen
        {
            get { return frm1Instance.LijstGebruikersrollen; }
            set { frm1Instance.LijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikersAdminGegevensVerwijderen
        {
            get { return frm1Instance.LijstGebruikers; }
            set { frm1Instance.LijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingenAdminGegevensVerwijderen
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlusAdminGegevensVerwijderen
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAdminGegevensVerwijderen
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmAdminGegevensVerwijderen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            rdoTXT.Checked = true;

            try
            {
                //Bart: cmbVerwijderGebruiker vullen
                lijstGebruikerPlusNaCheck = new List<GebruikerPlus>(); //Bart: Bijhouden welke GebruikersPlus slagen voor de check

                foreach (GebruikerPlus gp in LijstGebruikersPlusAdminGegevensVerwijderen)
                {
                    if (!gp.Equals(IngelogdeGebruikerAdminGegevensVerwijderen)) //Bart: Ingelogdegebruiker uitsluiten uit lijst -> je kan jezelf niet verwijderen.
                    {
                        lijstGebruikerPlusNaCheck.Add(gp); //Bart: GebruikersPlus hier toevoegen aan de voorlopige list
                        cmbVerwijderGebruiker.Items.Add(gp.ToString());
                    }
                }
                RefreshCmbVerwijderGebruiker(); //Bart: In deze methode verwijzen naar lijstGebruikerPlusNaCheck om correct te refreshen!
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van de lijst met gebruikers.", ex.GetType().ToString());
            }
            try
            {
                //Bart: cmbVerwijderGebruikersrol vullen
                lijstGebruikersRollenNaCheck = new List<GebruikersRol>(); //Bart: Bijhouden welke GebruikersRollen slagen voor de check

                foreach (GebruikersRol g in LijstGebruikersrollenAdminGegevensVerwijderen)
                {
                    string gebruikersRol = g.Naam.ToUpper();
                    if (!gebruikersRol.Equals("ADMIN") && !gebruikersRol.Equals("ADMINISTRATOR")) //Bart: Check of gebruikersrol admin is of niet -> rol admin mag niet verwijderd worden.
                    {
                        lijstGebruikersRollenNaCheck.Add(g); //Bart: Gebruikersrollen hier toevoegen aan de voorlopige list
                        cmbVerwijderGebruikersrol.Items.Add(g.ToString());
                    }
                }
                RefreshCmbVerwijderGebruikersRol(); //Bart: In deze methode verwijzen naar lijstGebruikersRollenNaCheck om correct te refreshen!
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van de lijst met gebruikersrollen.", ex.GetType().ToString());
            }
            try
            {
                //Bart: cmbVerwijderAfdeling vullen
                foreach (Afdeling a in LijstAfdelingenAdminGegevensVerwijderen)
                {
                    cmbVerwijderAfdeling.Items.Add(a.ToString());
                }
                RefreshCmbVerwijderAfdeling();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van de lijst met afdelingen.", ex.GetType().ToString());
            }
        }
        private void cmbVerwijderGebruiker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVerwijderGebruiker.SelectedValue != null)
                {
                    geselecteerdeGebruiker = (GebruikerPlus)cmbVerwijderGebruiker.SelectedValue; //Bart: DIT TOEPASSEN IN DE ANDERE SCHERMEN !!!!

                    txtGebruikersrol.Text = geselecteerdeGebruiker.GebruikersRol.ToString();
                    txtNaamGebruiker.Text = geselecteerdeGebruiker.Naam;
                    txtVoornaamGebruiker.Text = geselecteerdeGebruiker.Voornaam;
                    txtGebruikersnaamGebruiker.Text = geselecteerdeGebruiker.Gebruikersnaam;
                    txtPaswoordGebruiker.Text = geselecteerdeGebruiker.Paswoord;
                    txtAdresGebruiker.Text = geselecteerdeGebruiker.Adres;
                    txtRekeningnummerGebruiker.Text = geselecteerdeGebruiker.Rekeningnummer;
                    txtTelefoonnummerGebruiker.Text = geselecteerdeGebruiker.Telefoonnummer;
                    txtLoonGebruiker.Text = geselecteerdeGebruiker.Loon.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het weergeven van de geselecteerde gebruiker.", ex.GetType().ToString());
            }
        }
        private void btnVerwijderMedewerker_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVerwijderGebruiker.SelectedIndex != -1)
                {
                    antwoordMessageBox = MessageBox.Show("Bent u zeker dat u deze gebruiker wil verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (antwoordMessageBox == DialogResult.Yes)
                    {
                        foreach (GebruikerPlus gp in LijstGebruikersPlusAdminGegevensVerwijderen)
                        {
                            if (gp.Equals((GebruikerPlus)cmbVerwijderGebruiker.SelectedItem))
                            {
                                LijstGebruikersPlusAdminGegevensVerwijderen.Remove(gp);
                                lijstGebruikerPlusNaCheck.Remove(gp);
                                break;
                            }
                        }
                        GebruikersPlusSchrijven();
                        TXTLeegmaken();
                        RefreshCmbVerwijderGebruiker();
                        MessageBox.Show("De gebruiker is verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("De gebruiker is NIET verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Gelieve eerst een gebruiker te selecteren aub.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de gebruiker.", ex.GetType().ToString());
            }
        }
        private void btnVerwijderGebruikersrol_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkGebruikersrolIsActief = false;
                if (cmbVerwijderGebruikersrol.SelectedIndex != -1)
                {
                    foreach (GebruikerPlus gp in LijstGebruikersPlusAdminGegevensVerwijderen) //Bart: check of er nog gebruikers zijn die aan deze gebruikersrol gekoppeld zijn.
                    {
                        if (gp.GebruikersRol.Equals((GebruikersRol)cmbVerwijderGebruikersrol.SelectedItem))
                        {
                            checkGebruikersrolIsActief = true;
                            break;
                        }
                    }
                    if (checkGebruikersrolIsActief == false) //Bart: als er geen gebruikers gekoppeld staan aan de gebruikersrol -> gebruikersrol verwijderen.
                    {
                        antwoordMessageBox = MessageBox.Show("Bent u zeker dat u deze gebruikersrol wil verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (antwoordMessageBox == DialogResult.Yes)
                        {
                            foreach (GebruikersRol gr in LijstGebruikersrollenAdminGegevensVerwijderen)
                            {
                                if (gr.Equals((GebruikersRol)cmbVerwijderGebruikersrol.SelectedItem))
                                {
                                    LijstGebruikersrollenAdminGegevensVerwijderen.Remove(gr);
                                    lijstGebruikersRollenNaCheck.Remove(gr);
                                    break;
                                }
                            }
                            RollenSchrijven();
                            RefreshCmbVerwijderGebruikersRol();
                            MessageBox.Show("De gebruikersrol is verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("De gebruikersrol is NIET verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("De gebruikersrol kan niet verwijderd worden. Er zijn nog gebruikers gekoppeld aan deze gebruikersrol.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Gelieve eerst een gebruikersrol te selecteren aub.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de gebruikersrol.", ex.GetType().ToString());
            }
        }
        private void btnVerwijderAfdeling_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkAfdelingIsActief = false;
                if (cmbVerwijderAfdeling.SelectedIndex != -1)
                {
                    foreach (GebruikerPlus gp in LijstGebruikersPlusAdminGegevensVerwijderen) //Bart: check of er nog gebruikers zijn die aan deze afdeling gekoppeld zijn.
                    {
                        foreach (Afdeling a in gp.LijstAfdelingen)
                        {
                            if (a.Equals((Afdeling)cmbVerwijderAfdeling.SelectedItem))
                            {
                                checkAfdelingIsActief = true;
                                break;
                            }
                        }
                    }
                    if (checkAfdelingIsActief == false) //Bart: als er geen gebruikers gekoppeld staan aan de afdeling -> afdeling verwijderen.
                    {
                        antwoordMessageBox = MessageBox.Show("Bent u zeker dat u deze afdeling wil verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (antwoordMessageBox == DialogResult.Yes)
                        {
                            foreach (Afdeling a in LijstAfdelingenAdminGegevensVerwijderen)
                            {
                                if (a.Equals((Afdeling)cmbVerwijderAfdeling.SelectedItem))
                                {
                                    LijstAfdelingenAdminGegevensVerwijderen.Remove(a);
                                    break;
                                }
                            }
                            AfdelingenSchrijven();
                            RefreshCmbVerwijderAfdeling();
                            MessageBox.Show("De afdeling is verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("De afdeling is NIET verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("De afdeling kan niet verwijderd worden. Er zijn nog gebruikers gekoppeld aan deze afdeling.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Gelieve eerst een afdeling te selecteren aub.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het verwijderen van de afdeling.", ex.GetType().ToString());
            }
        }
        private void btnZoekDocument_Click(object sender, EventArgs e)
        {
            currentDirectory = Environment.CurrentDirectory;
            if (Directory.Exists(currentDirectory))
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = currentDirectory;
                        if (rdoTXT.Checked)
                        {
                            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        }
                        else if (rdoXML.Checked)
                        {
                            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                        }
                        else if (rdoJSON.Checked)
                        {
                            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                        }
                        openFileDialog.FilterIndex = 1;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            selectedFilePath = openFileDialog.FileName;
                            txtNaamDocument.Text = Path.GetFileNameWithoutExtension(selectedFilePath);
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
        private void btnVerwijderDocument_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                try
                {
                    antwoordMessageBox = MessageBox.Show("Bent u zeker dat u dit document wil verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (antwoordMessageBox == DialogResult.Yes)
                    {
                        File.Delete(selectedFilePath);
                        MessageBox.Show("Document is succesvol verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNaamDocument.Text = string.Empty;
                        selectedFilePath = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Het document is NIET verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het verwijderen van het document.", ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("Gelieve eerst een document te selecteren aub.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void RefreshCmbVerwijderGebruikersRol()
        {
            cmbVerwijderGebruikersrol.DataSource = null;
            cmbVerwijderGebruikersrol.DataSource = lijstGebruikersRollenNaCheck;
        }
        private void RefreshCmbVerwijderGebruiker()
        {
            cmbVerwijderGebruiker.DataSource = null;
            cmbVerwijderGebruiker.DataSource = lijstGebruikerPlusNaCheck;
        }
        private void RefreshCmbVerwijderAfdeling()
        {
            cmbVerwijderAfdeling.DataSource = null;
            cmbVerwijderAfdeling.DataSource = LijstAfdelingenAdminGegevensVerwijderen;
        }
        private void TXTLeegmaken()
        {
            txtGebruikersrol.Text = string.Empty;
            txtNaamGebruiker.Text = string.Empty;
            txtVoornaamGebruiker.Text = string.Empty;
            txtGebruikersnaamGebruiker.Text = string.Empty;
            txtPaswoordGebruiker.Text = string.Empty;
            txtAdresGebruiker.Text = string.Empty;
            txtRekeningnummerGebruiker.Text = string.Empty;
            txtTelefoonnummerGebruiker.Text = string.Empty;
            txtLoonGebruiker.Text = string.Empty;
        }
        private void AfdelingenSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("Afdelingen");
            xmlDoc.AppendChild(mainRoot);

            foreach (Afdeling dezeAfdeling in LijstAfdelingenAdminGegevensVerwijderen)
            {
                XmlElement root = xmlDoc.CreateElement("Afdeling");
                mainRoot.AppendChild(root);

                XmlElement afdelingsNaam = xmlDoc.CreateElement("Naam");
                afdelingsNaam.InnerText = dezeAfdeling.Naam;
                root.AppendChild(afdelingsNaam);

                XmlElement afdelingsID = xmlDoc.CreateElement("ID");
                afdelingsID.InnerText = dezeAfdeling.Guid.ToString();
                root.AppendChild(afdelingsID);

                XmlElement afdelingOmschrijving = xmlDoc.CreateElement("Omschrijving");
                afdelingOmschrijving.InnerText = dezeAfdeling.Omschrijving;
                root.AppendChild(afdelingOmschrijving);
            }
            xmlDoc.Save("Afdelingen.xml");
        }
        private void RollenSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("Rollen");
            xmlDoc.AppendChild(mainRoot);

            foreach (GebruikersRol dezeRol in LijstGebruikersrollenAdminGegevensVerwijderen)
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

            foreach (GebruikerPlus dezeGebruikerPlus in LijstGebruikersPlusAdminGegevensVerwijderen)
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

