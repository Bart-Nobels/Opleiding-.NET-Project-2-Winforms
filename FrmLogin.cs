using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmLogin : Form
    {
        private Form1 frm1Instance;
        static string superAdminNaam = "Hans";  //Beter linken naar extern bestand in cloud
        static string superAdminPaswoord = "123";
        private int tellerButtonInloggenClick = 0;
        private bool geblokkeerd = false;

        public FrmLogin(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusLogin
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public GebruikerPlus IngelogdeGebruikerLogin
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                IngelogdeGebruikerLogin = new GebruikerPlus();   //Bart: Om object ingelogde gebruiker te maken (moet niet opgeslagen worden)

                if (LinkIngelogdeGebruikerAanGebruiker() == true)
                {
                    DialogResult = DialogResult.OK;
                    IngelogdeGebruikerLogin.TellerPaswoord = 0;
                }
                else if (txtGebruikersnaam.Text == superAdminNaam && txtPaswoord.Text == superAdminPaswoord)
                {
                    IngelogdeGebruikerLogin.Gebruikersnaam = superAdminNaam;
                    IngelogdeGebruikerLogin.Paswoord = superAdminPaswoord;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    if (tellerButtonInloggenClick < 2 && geblokkeerd == false)
                    {
                        MessageBox.Show("De ingevulde gebruikersnaam en/of het paswoord is niet correct.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TXTLeegmaken();
                        tellerButtonInloggenClick++;
                        foreach (var gebruiker in LijstGebruikersPlusLogin)
                        {
                            if (gebruiker.Gebruikersnaam == txtGebruikersnaam.Text)
                            {
                                gebruiker.TellerPaswoord++;
                                GebruikersPlusSchrijven();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("U heeft te vaak een foutieve gebruikersnaam en/of paswoord ingevuld. De applicatie wordt gesloten.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        foreach (var gebruiker in LijstGebruikersPlusLogin)
                        {
                            if (gebruiker.Gebruikersnaam == txtGebruikersnaam.Text)
                            {
                                gebruiker.TellerPaswoord = 3;
                                GebruikersPlusSchrijven();
                            }
                        }
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets foutgelopen bij het inloggen.", ex.GetType().ToString());
            }
        }
        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool LinkIngelogdeGebruikerAanGebruiker()  //Bart: Op deze manier krijgt IngelogdeGebruiker de guid van de correcte gebruiker !!
        {
            bool resultaat = false;
            foreach (GebruikerPlus gp in LijstGebruikersPlusLogin)
            {
                if (gp.Gebruikersnaam.Equals(txtGebruikersnaam.Text) && gp.Paswoord.Equals(txtPaswoord.Text) && gp.TellerPaswoord < 3)
                {
                    IngelogdeGebruikerLogin = gp;
                    resultaat = true;
                }
                else if (gp.Gebruikersnaam.Equals(txtGebruikersnaam.Text) && gp.TellerPaswoord >= 3)
                {
                    MessageBox.Show("Uw account is geblokkeerd. Neem contact op met de beheerder.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resultaat = false;
                    geblokkeerd = true;
                }
            }
            return resultaat;
        }
        private void TXTLeegmaken()
        {
            txtGebruikersnaam.Text = string.Empty;
            txtPaswoord.Text = string.Empty;
        }
        private void GebruikersPlusSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("GebruikersPlus");
            xmlDoc.AppendChild(mainRoot);

            foreach (GebruikerPlus dezeGebruikerPlus in LijstGebruikersPlusLogin)
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
