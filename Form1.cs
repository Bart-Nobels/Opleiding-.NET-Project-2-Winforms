using System.Xml;

namespace Project_2__Bart_
{
    public partial class Form1 : Form
    {
        GebruikerPlus _ingelogdeGebruiker;
        static string superAdminNaam = "Hans";  //Beter linken naar extern bestand in cloud
        static string superAdminPaswoord = "123";

        public Form1()
        {
            InitializeComponent();
        }

        private List<GebruikersRol> _lijstGebruikersrollen = new List<GebruikersRol>();
        private List<Gebruiker> _lijstGebruikers = new List<Gebruiker>();
        private List<Afdeling> _lijstAfdelingen = new List<Afdeling>();
        private List<GebruikerPlus> _lijstGebruikersPlus = new List<GebruikerPlus>();
        private List<Klant> _lijstKlanten = new List<Klant>();
        private List<Leverancier> _lijstLeveranciers = new List<Leverancier>();
        private List<AankoopArtikel> _lijstAankoopArtikels = new List<AankoopArtikel>();
        private List<VerkoopArtikel> _lijstVerkoopArtikels = new List<VerkoopArtikel>();
        private List<AankoopFactuur> _lijstAankoopFacturen = new List<AankoopFactuur>();
        private List<VerkoopFactuur> _lijstVerkoopFacturen = new List<VerkoopFactuur>();

        public List<GebruikersRol> LijstGebruikersrollen
        {
            get { return _lijstGebruikersrollen; }
            set { _lijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikers
        {
            get { return _lijstGebruikers; }
            set { _lijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingen
        {
            get { return _lijstAfdelingen; }
            set { _lijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlus
        {
            get { return _lijstGebruikersPlus; }
            set { _lijstGebruikersPlus = value; }
        }
        public List<Klant> LijstKlanten
        {
            get { return _lijstKlanten; }
            set { _lijstKlanten = value; }
        }
        public List<Leverancier> LijstLeveranciers
        {
            get { return _lijstLeveranciers; }
            set { _lijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikels
        {
            get { return _lijstAankoopArtikels; }
            set { _lijstAankoopArtikels = value; }
        }
        public List<VerkoopArtikel> LijstVerkoopArtikels
        {
            get { return _lijstVerkoopArtikels; }
            set { _lijstVerkoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturen
        {
            get { return _lijstAankoopFacturen; }
            set { _lijstAankoopFacturen = value; }
        }
        public List<VerkoopFactuur> LijstVerkoopFacturen
        {
            get { return _lijstVerkoopFacturen; }
            set { _lijstVerkoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruiker
        {
            get { return _ingelogdeGebruiker; }
            set { _ingelogdeGebruiker = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bart: Hier worden alle lijsten ingelezen.
            AfdelingenInlezen();
            RollenInlezen();
            GebruikersInlezen();
            GebruikersPlusInlezen();
            AankoopArtikelenInlezen();
            VerkoopArtikelenInlezen();
            AankoopFacturenInlezen();
            VerkoopFacturenInlezen();
            KlantenInlezen();
            LeveranciersInlezen();

            //Bart: Doorverwijzen naar FrmLogin waar de gerbuiker zich eerst zal moeten inloggen.
            FrmLogin frmLogin = new FrmLogin(this);
            frmLogin.LijstGebruikersPlusLogin = LijstGebruikersPlus;

            //Bart: Als DialogResult.OK is in FrmLogin dan wordt hier nagekeken welke soort gebruiker je bent => doorverwijzing naar juiste dashboard.
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                if (!(IngelogdeGebruiker.Gebruikersnaam == superAdminNaam) && !(IngelogdeGebruiker.Gebruikersnaam == superAdminPaswoord))
                {
                    foreach (GebruikersRol g in LijstGebruikersrollen)
                    {
                        if (g.Guid.Equals(IngelogdeGebruiker.GebruikersRol.Guid))
                        {
                            if (g.Naam.ToUpper() == "ADMIN")
                            {
                                FrmAdminDashboard frmAdminDashboard = new FrmAdminDashboard(this);
                                frmAdminDashboard.LijstGebruikersrollenAdmin = LijstGebruikersrollen;
                                frmAdminDashboard.LijstGebruikersAdmin = LijstGebruikers;
                                frmAdminDashboard.LijstAfdelingenAdmin = LijstAfdelingen;
                                frmAdminDashboard.LijstGebruikersPlusAdmin = LijstGebruikersPlus;
                                frmAdminDashboard.LijstKlantenAdmin = LijstKlanten;
                                frmAdminDashboard.LijstLeveranciersAdmin = LijstLeveranciers;
                                frmAdminDashboard.LijstAankoopArtikelsAdmin = LijstAankoopArtikels;
                                frmAdminDashboard.LijstVerkoopArtikelsAdmin = LijstVerkoopArtikels;
                                frmAdminDashboard.LijstAankoopFacturenAdmin = LijstAankoopFacturen;
                                frmAdminDashboard.LijstVerkoopFacturenAdmin = LijstVerkoopFacturen;
                                frmAdminDashboard.IngelogdeGebruikerAdmin = IngelogdeGebruiker;
                                frmAdminDashboard.Show();
                            }
                            else if (g.Naam.ToUpper() == "MANAGER")
                            {
                                FrmManagerDashboard frmManagerDashboard = new FrmManagerDashboard(this);
                                frmManagerDashboard.LijstGebruikersrollenManager = LijstGebruikersrollen;
                                frmManagerDashboard.LijstGebruikersManager = LijstGebruikers;
                                frmManagerDashboard.LijstAfdelingenManager = LijstAfdelingen;
                                frmManagerDashboard.LijstGebruikersPlusManager = LijstGebruikersPlus;
                                frmManagerDashboard.LijstKlantenManager = LijstKlanten;
                                frmManagerDashboard.LijstLeveranciersManager = LijstLeveranciers;
                                frmManagerDashboard.LijstAankoopArtikelsManager = LijstAankoopArtikels;
                                frmManagerDashboard.LijstVerkoopArtikelsManager = LijstVerkoopArtikels;
                                frmManagerDashboard.LijstAankoopFacturenManager = LijstAankoopFacturen;
                                frmManagerDashboard.LijstVerkoopFacturenManager = LijstVerkoopFacturen;
                                frmManagerDashboard.IngelogdeGebruikerManager = IngelogdeGebruiker;
                                frmManagerDashboard.Show();
                            }

                            else if (g.Naam.ToUpper() == "WERKNEMER")
                            {
                                FrmWerknemersDashboard frmWerknemerDashboard = new FrmWerknemersDashboard(this);
                                frmWerknemerDashboard.LijstGebruikersrollenWN = LijstGebruikersrollen;
                                frmWerknemerDashboard.LijstGebruikersWN = LijstGebruikers;
                                frmWerknemerDashboard.LijstAfdelingenWN = LijstAfdelingen;
                                frmWerknemerDashboard.LijstGebruikersPlusWN = LijstGebruikersPlus;
                                frmWerknemerDashboard.LijstKlantenWN = LijstKlanten;
                                frmWerknemerDashboard.LijstLeveranciersWN = LijstLeveranciers;
                                frmWerknemerDashboard.LijstAankoopArtikelsWN = LijstAankoopArtikels;
                                frmWerknemerDashboard.LijstVerkoopArtikelsWN = LijstVerkoopArtikels;
                                frmWerknemerDashboard.LijstAankoopFacturenWN = LijstAankoopFacturen;
                                frmWerknemerDashboard.LijstVerkoopFacturenWN = LijstVerkoopFacturen;
                                frmWerknemerDashboard.IngelogdeGebruikerWN = IngelogdeGebruiker;
                                frmWerknemerDashboard.Show();
                            }
                        }
                    }
                }
                else
                {
                    FrmSuperAdmin frmSuperAdmin = new FrmSuperAdmin(this);
                    frmSuperAdmin.LijstGebruikersrollenSuperAdmin = LijstGebruikersrollen;
                    frmSuperAdmin.LijstAfdelingenSuperAdmin = LijstAfdelingen;
                    frmSuperAdmin.LijstGebruikersPlusSuperAdmin = LijstGebruikersPlus;
                    frmSuperAdmin.IngelogdeGebruikerSuperAdmin = IngelogdeGebruiker;
                    frmSuperAdmin.Show();
                }
            }
            else
            {
                Application.Exit();
            }
        }
        private void GebruikersInlezen()
        {
            if (System.IO.File.Exists("Gebruikers.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("Gebruikers.xml");

                    XmlNodeList nodeGebruikers = xmlDoc.SelectNodes("//Gebruiker");
                    foreach (XmlNode nodeGebruiker in nodeGebruikers)
                    {
                        Gebruiker dezeGebruiker = new Gebruiker();
                        dezeGebruiker.LijstAfdelingen = new List<Afdeling>();
                        dezeGebruiker.GebruikersRol = new GebruikersRol();
                        dezeGebruiker.Guid = Guid.Parse(nodeGebruiker.ChildNodes[0].InnerText);
                        dezeGebruiker.Naam = nodeGebruiker.ChildNodes[1].InnerText;
                        dezeGebruiker.Voornaam = nodeGebruiker.ChildNodes[2].InnerText;
                        dezeGebruiker.Gebruikersnaam = nodeGebruiker.ChildNodes[3].InnerText;
                        dezeGebruiker.Paswoord = nodeGebruiker.ChildNodes[4].InnerText;

                        XmlNodeList nodesAfdelingen = nodeGebruiker.SelectNodes(".//Afdelingen/Afdeling");
                        foreach (XmlNode dezeAfdeling in nodesAfdelingen)
                        {
                            Afdeling afdeling1 = new Afdeling();
                            afdeling1.Naam = dezeAfdeling.ChildNodes[0].InnerText;
                            afdeling1.Guid = Guid.Parse(dezeAfdeling.ChildNodes[1].InnerText);
                            dezeGebruiker.LijstAfdelingen.Add(afdeling1);
                        }

                        dezeGebruiker.GebruikersRol.Guid = Guid.Parse(nodeGebruiker.ChildNodes[6].InnerText);
                        dezeGebruiker.GebruikersRol.Naam = nodeGebruiker.ChildNodes[7].InnerText;
                        dezeGebruiker.GebruikersRol.KanBewerkenXml = bool.Parse(nodeGebruiker.ChildNodes[8].InnerText);
                        dezeGebruiker.GebruikersRol.KanAanmakenXml = bool.Parse(nodeGebruiker.ChildNodes[9].InnerText);
                        dezeGebruiker.GebruikersRol.KanLezenXml = bool.Parse(nodeGebruiker.ChildNodes[10].InnerText);
                        dezeGebruiker.GebruikersRol.KanEncrypterenXml = bool.Parse(nodeGebruiker.ChildNodes[11].InnerText);
                        dezeGebruiker.GebruikersRol.KanBewerkenTxt = bool.Parse(nodeGebruiker.ChildNodes[12].InnerText);
                        dezeGebruiker.GebruikersRol.KanAanmakenTxt = bool.Parse(nodeGebruiker.ChildNodes[13].InnerText);
                        dezeGebruiker.GebruikersRol.KanLezenTxt = bool.Parse(nodeGebruiker.ChildNodes[14].InnerText);
                        dezeGebruiker.GebruikersRol.KanEncrypterenTxt = bool.Parse(nodeGebruiker.ChildNodes[15].InnerText);
                        dezeGebruiker.GebruikersRol.KanBewerkenJson = bool.Parse(nodeGebruiker.ChildNodes[16].InnerText);
                        dezeGebruiker.GebruikersRol.KanAanmakenJson = bool.Parse(nodeGebruiker.ChildNodes[17].InnerText);
                        dezeGebruiker.GebruikersRol.KanLezenJson = bool.Parse(nodeGebruiker.ChildNodes[18].InnerText);
                        dezeGebruiker.GebruikersRol.KanEncrypterenJson = bool.Parse(nodeGebruiker.ChildNodes[19].InnerText);
                        LijstGebruikers.Add(dezeGebruiker);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met gebruikersgegevens.", ex.GetType().ToString());
                }
            }
        }
        private void GebruikersPlusInlezen()
        {
            if (System.IO.File.Exists("GebruikersPlus.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("GebruikersPlus.xml");

                    XmlNodeList nodeGebruikersPlus = xmlDoc.SelectNodes("//GebruikerPlus");
                    foreach (XmlNode nodeGebruikerPlus in nodeGebruikersPlus)
                    {
                        GebruikerPlus dezeGebruikerPlus = new GebruikerPlus();
                        dezeGebruikerPlus.LijstAfdelingen = new List<Afdeling>();
                        dezeGebruikerPlus.GebruikersRol = new GebruikersRol();
                        dezeGebruikerPlus.Guid = Guid.Parse(nodeGebruikerPlus.ChildNodes[0].InnerText);
                        dezeGebruikerPlus.Naam = nodeGebruikerPlus.ChildNodes[1].InnerText;
                        dezeGebruikerPlus.Voornaam = nodeGebruikerPlus.ChildNodes[2].InnerText;
                        dezeGebruikerPlus.Gebruikersnaam = nodeGebruikerPlus.ChildNodes[3].InnerText;
                        dezeGebruikerPlus.Paswoord = nodeGebruikerPlus.ChildNodes[4].InnerText;
                        dezeGebruikerPlus.Adres = nodeGebruikerPlus.ChildNodes[5].InnerText;
                        dezeGebruikerPlus.Telefoonnummer = nodeGebruikerPlus.ChildNodes[6].InnerText;
                        dezeGebruikerPlus.Rekeningnummer = nodeGebruikerPlus.ChildNodes[7].InnerText;
                        dezeGebruikerPlus.Loon = double.Parse(nodeGebruikerPlus.ChildNodes[8].InnerText);
                        dezeGebruikerPlus.TellerPaswoord = int.Parse(nodeGebruikerPlus.ChildNodes[9].InnerText);

                        XmlNodeList nodesAfdelingen = nodeGebruikerPlus.SelectNodes(".//Afdelingen/Afdeling");
                        foreach (XmlNode dezeAfdeling in nodesAfdelingen)
                        {
                            Afdeling afdeling1 = new Afdeling();
                            afdeling1.Naam = dezeAfdeling.ChildNodes[0].InnerText;
                            afdeling1.Guid = Guid.Parse(dezeAfdeling.ChildNodes[1].InnerText);
                            afdeling1.Omschrijving = dezeAfdeling.ChildNodes[2].InnerText;
                            dezeGebruikerPlus.LijstAfdelingen.Add(afdeling1);
                        }

                        dezeGebruikerPlus.GebruikersRol.Guid = Guid.Parse(nodeGebruikerPlus.ChildNodes[11].InnerText);
                        dezeGebruikerPlus.GebruikersRol.Naam = nodeGebruikerPlus.ChildNodes[12].InnerText;
                        dezeGebruikerPlus.GebruikersRol.KanBewerkenXml = bool.Parse(nodeGebruikerPlus.ChildNodes[13].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanAanmakenXml = bool.Parse(nodeGebruikerPlus.ChildNodes[14].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanLezenXml = bool.Parse(nodeGebruikerPlus.ChildNodes[15].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanEncrypterenXml = bool.Parse(nodeGebruikerPlus.ChildNodes[16].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanBewerkenTxt = bool.Parse(nodeGebruikerPlus.ChildNodes[17].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanAanmakenTxt = bool.Parse(nodeGebruikerPlus.ChildNodes[18].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanLezenTxt = bool.Parse(nodeGebruikerPlus.ChildNodes[19].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanEncrypterenTxt = bool.Parse(nodeGebruikerPlus.ChildNodes[20].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanBewerkenJson = bool.Parse(nodeGebruikerPlus.ChildNodes[21].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanAanmakenJson = bool.Parse(nodeGebruikerPlus.ChildNodes[22].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanLezenJson = bool.Parse(nodeGebruikerPlus.ChildNodes[23].InnerText);
                        dezeGebruikerPlus.GebruikersRol.KanEncrypterenJson = bool.Parse(nodeGebruikerPlus.ChildNodes[24].InnerText);
                        LijstGebruikersPlus.Add(dezeGebruikerPlus);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met gebruikersgegevens.", ex.GetType().ToString());
                }
            }
        }
        private void RollenInlezen()
        {
            if (System.IO.File.Exists("Gebruikersrollen.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("Gebruikersrollen.xml");

                    XmlNodeList nodeGebruikersrollen = xmlDoc.SelectNodes("//Rol");
                    foreach (XmlNode nodeRol in nodeGebruikersrollen)
                    {
                        GebruikersRol dezeRol = new GebruikersRol();
                        dezeRol.Naam = nodeRol.ChildNodes[0].InnerText;
                        dezeRol.Guid = Guid.Parse(nodeRol.ChildNodes[1].InnerText);

                        dezeRol.KanBewerkenXml = bool.Parse(nodeRol.ChildNodes[2].InnerText);
                        dezeRol.KanAanmakenXml = bool.Parse(nodeRol.ChildNodes[3].InnerText);
                        dezeRol.KanLezenXml = bool.Parse(nodeRol.ChildNodes[4].InnerText);
                        dezeRol.KanEncrypterenXml = bool.Parse(nodeRol.ChildNodes[5].InnerText);
                        dezeRol.KanBewerkenTxt = bool.Parse(nodeRol.ChildNodes[6].InnerText);
                        dezeRol.KanAanmakenTxt = bool.Parse(nodeRol.ChildNodes[7].InnerText);
                        dezeRol.KanLezenTxt = bool.Parse(nodeRol.ChildNodes[8].InnerText);
                        dezeRol.KanEncrypterenTxt = bool.Parse(nodeRol.ChildNodes[9].InnerText);
                        dezeRol.KanBewerkenJson = bool.Parse(nodeRol.ChildNodes[10].InnerText);
                        dezeRol.KanAanmakenJson = bool.Parse(nodeRol.ChildNodes[11].InnerText);
                        dezeRol.KanLezenJson = bool.Parse(nodeRol.ChildNodes[12].InnerText);
                        dezeRol.KanEncrypterenJson = bool.Parse(nodeRol.ChildNodes[13].InnerText);
                        LijstGebruikersrollen.Add(dezeRol);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met gebruikersrollen.", ex.GetType().ToString());
                }
            }
        }
        private void AfdelingenInlezen()
        {
            if (System.IO.File.Exists("Afdelingen.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("Afdelingen.xml");

                    XmlNodeList nodeAfdelingen = xmlDoc.SelectNodes("//Afdeling");
                    foreach (XmlNode dezeAfdeling in nodeAfdelingen)
                    {
                        Afdeling afdeling1 = new Afdeling();
                        afdeling1.Naam = dezeAfdeling.ChildNodes[0].InnerText;
                        afdeling1.Guid = Guid.Parse(dezeAfdeling.ChildNodes[1].InnerText);
                        afdeling1.Omschrijving = dezeAfdeling.ChildNodes[2].InnerText;
                        LijstAfdelingen.Add(afdeling1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met afdelingen.", ex.GetType().ToString());
                }
            }
        }
        private void KlantenInlezen()
        {
            if (System.IO.File.Exists("Klanten.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("Klanten.xml");

                    XmlNodeList nodeKlanten = xmlDoc.SelectNodes("//Klant");
                    foreach (XmlNode nodeKlant in nodeKlanten)
                    {
                        Klant dezeKlant = new Klant();
                        dezeKlant.LijstVerkoopfacturenKlant = new List<VerkoopFactuur>();
                        dezeKlant.Guid = Guid.Parse(nodeKlant.ChildNodes[0].InnerText);
                        dezeKlant.Naam = nodeKlant.ChildNodes[1].InnerText;
                        dezeKlant.Adres = nodeKlant.ChildNodes[2].InnerText;
                        dezeKlant.Telefoonnummer = nodeKlant.ChildNodes[3].InnerText;
                        dezeKlant.Email = nodeKlant.ChildNodes[4].InnerText;
                        dezeKlant.TotaalSaldoVerkoop = double.Parse(nodeKlant.ChildNodes[5].InnerText);

                        XmlNodeList nodesVerkoopFacturen = nodeKlant.SelectNodes(".//VerkoopFacturen/VerkoopFactuur");
                        foreach (XmlNode verkoopFactuur in nodesVerkoopFacturen)
                        {
                            VerkoopFactuur eenVerkoopFactuur = new VerkoopFactuur();
                            eenVerkoopFactuur.DezeGebruikerPlus = new GebruikerPlus();
                            eenVerkoopFactuur.EenKlant = new Klant();
                            eenVerkoopFactuur.LijstVerkoopArtikels = new List<VerkoopArtikel>();
                            eenVerkoopFactuur.Datum = Convert.ToDateTime(verkoopFactuur.ChildNodes[0].InnerText);
                            eenVerkoopFactuur.Guid = Guid.Parse(verkoopFactuur.ChildNodes[1].InnerText);
                            eenVerkoopFactuur.DezeGebruikerPlus.Naam = verkoopFactuur.ChildNodes[2].InnerText;
                            eenVerkoopFactuur.DezeGebruikerPlus.Voornaam = verkoopFactuur.ChildNodes[3].InnerText;
                            eenVerkoopFactuur.EenKlant.Naam = verkoopFactuur.ChildNodes[4].InnerText;

                            XmlNodeList nodesVerkoopArtikelen = verkoopFactuur.SelectNodes(".//VerkoopArtikelen/VerkoopArtikel");
                            foreach (XmlNode verkoopArtikel in nodesVerkoopArtikelen)
                            {
                                VerkoopArtikel eenVerkoopArtikel = new VerkoopArtikel();
                                eenVerkoopArtikel.Naam = verkoopArtikel.ChildNodes[0].InnerText;
                                eenVerkoopArtikel.Guid = Guid.Parse(verkoopArtikel.ChildNodes[1].InnerText);
                                eenVerkoopArtikel.AantalInStock = int.Parse(verkoopArtikel.ChildNodes[2].InnerText);
                                eenVerkoopArtikel.Verkoopprijs = double.Parse(verkoopArtikel.ChildNodes[3].InnerText);
                                eenVerkoopFactuur.LijstVerkoopArtikels.Add(eenVerkoopArtikel);
                            }
                            dezeKlant.LijstVerkoopfacturenKlant.Add(eenVerkoopFactuur);
                        }
                        LijstKlanten.Add(dezeKlant);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met klanten.", ex.GetType().ToString());
                }
            }
        }
        private void LeveranciersInlezen()
        {
            if (System.IO.File.Exists("Leveranciers.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("Leveranciers.xml");

                    XmlNodeList nodeLeveranciers = xmlDoc.SelectNodes("//Leverancier");
                    foreach (XmlNode nodeLeverancier in nodeLeveranciers)
                    {
                        Leverancier dezeLeverancier = new Leverancier();
                        dezeLeverancier.LijstAankoopfacturenKlant = new List<AankoopFactuur>();
                        dezeLeverancier.Guid = Guid.Parse(nodeLeverancier.ChildNodes[0].InnerText);
                        dezeLeverancier.Naam = nodeLeverancier.ChildNodes[1].InnerText;
                        dezeLeverancier.Adres = nodeLeverancier.ChildNodes[2].InnerText;
                        dezeLeverancier.Telefoonnummer = nodeLeverancier.ChildNodes[3].InnerText;
                        dezeLeverancier.Email = nodeLeverancier.ChildNodes[4].InnerText;
                        dezeLeverancier.TotaalSaldoAankoop = double.Parse(nodeLeverancier.ChildNodes[5].InnerText);

                        XmlNodeList nodesAankoopFacturen = nodeLeverancier.SelectNodes(".//AankoopFacturen/AankoopFactuur");
                        foreach (XmlNode aankoopFactuur in nodesAankoopFacturen)
                        {
                            AankoopFactuur eenAankoopFactuur = new AankoopFactuur();
                            eenAankoopFactuur.DezeGebruikerPlus = new GebruikerPlus();
                            eenAankoopFactuur.EenLeverancier = new Leverancier();
                            eenAankoopFactuur.LijstAankoopArtikels = new List<AankoopArtikel>();
                            eenAankoopFactuur.Datum = Convert.ToDateTime(aankoopFactuur.ChildNodes[0].InnerText);
                            eenAankoopFactuur.Guid = Guid.Parse(aankoopFactuur.ChildNodes[1].InnerText);
                            eenAankoopFactuur.DezeGebruikerPlus.Naam = aankoopFactuur.ChildNodes[2].InnerText;
                            eenAankoopFactuur.DezeGebruikerPlus.Voornaam = aankoopFactuur.ChildNodes[3].InnerText;
                            eenAankoopFactuur.EenLeverancier.Naam = aankoopFactuur.ChildNodes[4].InnerText;

                            XmlNodeList nodesAankoopArtikelen = aankoopFactuur.SelectNodes(".//AankoopArtikelen/AankoopArtikel");
                            foreach (XmlNode aankoopArtikel in nodesAankoopArtikelen)
                            {
                                AankoopArtikel eenAankoopArtikel = new AankoopArtikel();
                                eenAankoopArtikel.Naam = aankoopArtikel.ChildNodes[0].InnerText;
                                eenAankoopArtikel.Guid = Guid.Parse(aankoopArtikel.ChildNodes[1].InnerText);
                                eenAankoopArtikel.AantalInStock = int.Parse(aankoopArtikel.ChildNodes[2].InnerText);
                                eenAankoopArtikel.Aankoopprijs = double.Parse(aankoopArtikel.ChildNodes[3].InnerText);
                                eenAankoopArtikel.PlaatsInWarenhuis = aankoopArtikel.ChildNodes[4].InnerText;
                                eenAankoopArtikel.Datum = Convert.ToDateTime(aankoopArtikel.ChildNodes[5].InnerText);
                                eenAankoopFactuur.LijstAankoopArtikels.Add(eenAankoopArtikel);
                            }
                            dezeLeverancier.LijstAankoopfacturenKlant.Add(eenAankoopFactuur);
                        }
                        LijstLeveranciers.Add(dezeLeverancier);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met leveranciers.", ex.GetType().ToString());
                }
            }
        }
        private void AankoopArtikelenInlezen()
        {
            if (System.IO.File.Exists("AankoopArtikelen.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("AankoopArtikelen.xml");

                    XmlNodeList nodeAankoopArtikels = xmlDoc.SelectNodes("//AankoopArtikel");
                    foreach (XmlNode nodeAankoopArtikel in nodeAankoopArtikels)
                    {
                        AankoopArtikel eenAankoopArtikel = new AankoopArtikel();
                        eenAankoopArtikel.Naam = nodeAankoopArtikel.ChildNodes[0].InnerText;
                        eenAankoopArtikel.Guid = Guid.Parse(nodeAankoopArtikel.ChildNodes[1].InnerText);
                        eenAankoopArtikel.AantalInStock = int.Parse(nodeAankoopArtikel.ChildNodes[2].InnerText);
                        eenAankoopArtikel.Aankoopprijs = double.Parse(nodeAankoopArtikel.ChildNodes[3].InnerText);
                        eenAankoopArtikel.PlaatsInWarenhuis = nodeAankoopArtikel.ChildNodes[4].InnerText;
                        eenAankoopArtikel.Datum = Convert.ToDateTime(nodeAankoopArtikel.ChildNodes[5].InnerText);

                        LijstAankoopArtikels.Add(eenAankoopArtikel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met aankoopartikelen.", ex.GetType().ToString());
                }
            }
        }
        private void VerkoopArtikelenInlezen()
        {
            if (System.IO.File.Exists("VerkoopArtikelen.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("VerkoopArtikelen.xml");

                    XmlNodeList nodeVerkoopArtikelen = xmlDoc.SelectNodes("//VerkoopArtikel");
                    foreach (XmlNode nodeVerkoopArtikel in nodeVerkoopArtikelen)
                    {
                        VerkoopArtikel eenVerkoopArtikel = new VerkoopArtikel();
                        eenVerkoopArtikel.Naam = nodeVerkoopArtikel.ChildNodes[0].InnerText;
                        eenVerkoopArtikel.Guid = Guid.Parse(nodeVerkoopArtikel.ChildNodes[1].InnerText);
                        eenVerkoopArtikel.AantalInStock = int.Parse(nodeVerkoopArtikel.ChildNodes[2].InnerText);
                        eenVerkoopArtikel.Verkoopprijs = double.Parse(nodeVerkoopArtikel.ChildNodes[3].InnerText);

                        LijstVerkoopArtikels.Add(eenVerkoopArtikel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met verkoopartikelen.", ex.GetType().ToString());
                }
            }
        }
        private void AankoopFacturenInlezen()
        {
            if (System.IO.File.Exists("AankoopFacturen.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("AankoopFacturen.xml");

                    XmlNodeList nodeAankoopFacturen = xmlDoc.SelectNodes("//AankoopFactuur");
                    foreach (XmlNode nodeAankoopFactuur in nodeAankoopFacturen)
                    {
                        AankoopFactuur eenAankoopFactuur = new AankoopFactuur();
                        eenAankoopFactuur.DezeGebruikerPlus = new GebruikerPlus();
                        eenAankoopFactuur.EenLeverancier = new Leverancier();
                        eenAankoopFactuur.LijstAankoopArtikels = new List<AankoopArtikel>();
                        eenAankoopFactuur.Datum = Convert.ToDateTime(nodeAankoopFactuur.ChildNodes[0].InnerText);
                        eenAankoopFactuur.Guid = Guid.Parse(nodeAankoopFactuur.ChildNodes[1].InnerText);
                        eenAankoopFactuur.DezeGebruikerPlus.Naam = nodeAankoopFactuur.ChildNodes[2].InnerText;
                        eenAankoopFactuur.DezeGebruikerPlus.Voornaam = nodeAankoopFactuur.ChildNodes[3].InnerText;
                        eenAankoopFactuur.EenLeverancier.Naam = nodeAankoopFactuur.ChildNodes[4].InnerText;

                        XmlNodeList nodesAankoopArtikelen = nodeAankoopFactuur.SelectNodes(".//AankoopArtikelen/AankoopArtikel");
                        foreach (XmlNode aankoopArtikel in nodesAankoopArtikelen)
                        {
                            AankoopArtikel eenAankoopArtikel = new AankoopArtikel();
                            eenAankoopArtikel.Naam = aankoopArtikel.ChildNodes[0].InnerText;
                            eenAankoopArtikel.Guid = Guid.Parse(aankoopArtikel.ChildNodes[1].InnerText);
                            eenAankoopArtikel.AantalInStock = int.Parse(aankoopArtikel.ChildNodes[2].InnerText);
                            eenAankoopArtikel.Aankoopprijs = double.Parse(aankoopArtikel.ChildNodes[3].InnerText);
                            eenAankoopArtikel.PlaatsInWarenhuis = aankoopArtikel.ChildNodes[4].InnerText;
                            eenAankoopArtikel.Datum = Convert.ToDateTime(aankoopArtikel.ChildNodes[5].InnerText);
                            eenAankoopFactuur.LijstAankoopArtikels.Add(eenAankoopArtikel);
                        }
                        LijstAankoopFacturen.Add(eenAankoopFactuur);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met aankoopfacturen.", ex.GetType().ToString());
                }
            }
        }
        private void VerkoopFacturenInlezen()
        {
            if (System.IO.File.Exists("VerkoopFacturen.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("VerkoopFacturen.xml");

                    XmlNodeList nodeVerkoopFacturen = xmlDoc.SelectNodes("//VerkoopFactuur");
                    foreach (XmlNode nodeVerkoopFactuur in nodeVerkoopFacturen)
                    {
                        VerkoopFactuur eenVerkoopFactuur = new VerkoopFactuur();
                        eenVerkoopFactuur.DezeGebruikerPlus = new GebruikerPlus();
                        eenVerkoopFactuur.EenKlant = new Klant();
                        eenVerkoopFactuur.LijstVerkoopArtikels = new List<VerkoopArtikel>();
                        eenVerkoopFactuur.Datum = Convert.ToDateTime(nodeVerkoopFactuur.ChildNodes[0].InnerText);
                        eenVerkoopFactuur.Guid = Guid.Parse(nodeVerkoopFactuur.ChildNodes[1].InnerText);
                        eenVerkoopFactuur.DezeGebruikerPlus.Naam = nodeVerkoopFactuur.ChildNodes[2].InnerText;
                        eenVerkoopFactuur.DezeGebruikerPlus.Voornaam = nodeVerkoopFactuur.ChildNodes[3].InnerText;
                        eenVerkoopFactuur.EenKlant.Naam = nodeVerkoopFactuur.ChildNodes[4].InnerText;

                        XmlNodeList nodesVerkoopArtikelen = nodeVerkoopFactuur.SelectNodes(".//VerkoopArtikelen/VerkoopArtikel");
                        foreach (XmlNode verkoopArtikel in nodesVerkoopArtikelen)
                        {
                            VerkoopArtikel eenVerkoopArtikel = new VerkoopArtikel();
                            eenVerkoopArtikel.Naam = verkoopArtikel.ChildNodes[0].InnerText;
                            eenVerkoopArtikel.Guid = Guid.Parse(verkoopArtikel.ChildNodes[1].InnerText);
                            eenVerkoopArtikel.AantalInStock = int.Parse(verkoopArtikel.ChildNodes[2].InnerText);
                            eenVerkoopArtikel.Verkoopprijs = double.Parse(verkoopArtikel.ChildNodes[3].InnerText);
                            eenVerkoopFactuur.LijstVerkoopArtikels.Add(eenVerkoopArtikel);
                        }
                        LijstVerkoopFacturen.Add(eenVerkoopFactuur);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het opladen van de lijst met verkoopfacturen.", ex.GetType().ToString());
                }
            }
        }
        public void KlantenSchrijven() 
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("Klanten");
                xmlDoc.AppendChild(mainRoot);

                foreach (Klant dezeKlant in LijstKlanten)
                {
                    XmlElement root = xmlDoc.CreateElement("Klant");
                    mainRoot.AppendChild(root);

                    XmlElement klantID = xmlDoc.CreateElement("ID");
                    klantID.InnerText = dezeKlant.Guid.ToString();
                    root.AppendChild(klantID);

                    XmlElement klantNaam = xmlDoc.CreateElement("Naam");
                    klantNaam.InnerText = dezeKlant.Naam;
                    root.AppendChild(klantNaam);

                    XmlElement adres = xmlDoc.CreateElement("Adres");
                    adres.InnerText = dezeKlant.Adres;
                    root.AppendChild(adres);

                    XmlElement telefoonnummer = xmlDoc.CreateElement("Telefoonnummer");
                    telefoonnummer.InnerText = dezeKlant.Telefoonnummer;
                    root.AppendChild(telefoonnummer);

                    XmlElement emailadres = xmlDoc.CreateElement("E-mail");
                    emailadres.InnerText = dezeKlant.Email;
                    root.AppendChild(emailadres);

                    XmlElement totaalSaldoVerkoop = xmlDoc.CreateElement("TotaalSaldoVerkoop");
                    totaalSaldoVerkoop.InnerText = dezeKlant.TotaalSaldoVerkoop.ToString().Replace(".", ",");
                    root.AppendChild(totaalSaldoVerkoop);

                    XmlElement verkoopFacturen = xmlDoc.CreateElement("VerkoopFacturen");
                    foreach (VerkoopFactuur dezeVerkoopFactuur in dezeKlant.LijstVerkoopfacturenKlant)
                    {
                        XmlElement verkoopFactuur = xmlDoc.CreateElement("VerkoopFactuur");
                        verkoopFacturen.AppendChild(verkoopFactuur);

                        XmlElement datumOpmaakFactuur = xmlDoc.CreateElement("DatumOpmaakFactuur");
                        datumOpmaakFactuur.InnerText = dezeVerkoopFactuur.Datum.ToString();
                        verkoopFactuur.AppendChild(datumOpmaakFactuur);

                        XmlElement verkoopFactuurID = xmlDoc.CreateElement("ID");
                        verkoopFactuurID.InnerText = dezeVerkoopFactuur.Guid.ToString();
                        verkoopFactuur.AppendChild(verkoopFactuurID);

                        XmlElement naamMedewerker = xmlDoc.CreateElement("NaamMedewerker");
                        naamMedewerker.InnerText = dezeVerkoopFactuur.DezeGebruikerPlus.Naam;
                        verkoopFactuur.AppendChild(naamMedewerker);

                        XmlElement voornaamMedewerker = xmlDoc.CreateElement("VoornaamMedewerker");
                        voornaamMedewerker.InnerText = dezeVerkoopFactuur.DezeGebruikerPlus.Voornaam;
                        verkoopFactuur.AppendChild(voornaamMedewerker);

                        XmlElement naamKlant = xmlDoc.CreateElement("NaamKlant");
                        naamKlant.InnerText = dezeVerkoopFactuur.EenKlant.Naam;
                        verkoopFactuur.AppendChild(naamKlant);

                        XmlElement verkoopArtikelen = xmlDoc.CreateElement("VerkoopArtikelen");
                        foreach (VerkoopArtikel ditVerkoopArtikel in dezeVerkoopFactuur.LijstVerkoopArtikels)
                        {
                            XmlElement verkoopArtikel = xmlDoc.CreateElement("VerkoopArtikel");
                            verkoopArtikelen.AppendChild(verkoopArtikel);

                            XmlElement naam = xmlDoc.CreateElement("Naam");
                            naam.InnerText = ditVerkoopArtikel.Naam;
                            verkoopArtikel.AppendChild(naam);

                            XmlElement verkoopArtikelID = xmlDoc.CreateElement("ID");
                            verkoopArtikelID.InnerText = ditVerkoopArtikel.Guid.ToString();
                            verkoopArtikel.AppendChild(verkoopArtikelID);

                            XmlElement aantalInStock = xmlDoc.CreateElement("AantalInStock");
                            aantalInStock.InnerText = ditVerkoopArtikel.AantalInStock.ToString();
                            verkoopArtikel.AppendChild(aantalInStock);

                            XmlElement verkoopprijs = xmlDoc.CreateElement("Verkoopprijs");
                            verkoopprijs.InnerText = ditVerkoopArtikel.Verkoopprijs.ToString().Replace(".", ",");
                            verkoopArtikel.AppendChild(verkoopprijs);
                        }
                        verkoopFactuur.AppendChild(verkoopArtikelen);
                    }
                    root.AppendChild(verkoopFacturen);
                }
                xmlDoc.Save("Klanten.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de lijst met klanten.", ex.GetType().ToString());
            }
        }
        public void LeveranciersSchrijven() 
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("Leveranciers");
                xmlDoc.AppendChild(mainRoot);

                foreach (Leverancier dezeLeverancier in LijstLeveranciers)
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
        public void AankoopArtikelenSchrijven() 
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("AankoopArtikelen");
                xmlDoc.AppendChild(mainRoot);

                foreach (AankoopArtikel ditAankoopArtikel in LijstAankoopArtikels)
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
        public void VerkoopArtikelenSchrijven() 
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("VerkoopArtikelen");
                xmlDoc.AppendChild(mainRoot);

                foreach (VerkoopArtikel ditVerkoopArtikel in LijstVerkoopArtikels)
                {
                    XmlElement root = xmlDoc.CreateElement("VerkoopArtikel");
                    mainRoot.AppendChild(root);

                    XmlElement naam = xmlDoc.CreateElement("Naam");
                    naam.InnerText = ditVerkoopArtikel.Naam;
                    root.AppendChild(naam);

                    XmlElement verkoopArtikelID = xmlDoc.CreateElement("ID");
                    verkoopArtikelID.InnerText = ditVerkoopArtikel.Guid.ToString();
                    root.AppendChild(verkoopArtikelID);

                    XmlElement aantalInStock = xmlDoc.CreateElement("AantalInStock");
                    aantalInStock.InnerText = ditVerkoopArtikel.AantalInStock.ToString();
                    root.AppendChild(aantalInStock);

                    XmlElement verkoopprijs = xmlDoc.CreateElement("Verkoopprijs");
                    verkoopprijs.InnerText = ditVerkoopArtikel.Verkoopprijs.ToString().Replace(".", ",");
                    root.AppendChild(verkoopprijs);
                }
                xmlDoc.Save("VerkoopArtikelen.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de lijst met verkoopartikelen.", ex.GetType().ToString());
            }
        }
        public void AankoopFacturenSchrijven() 
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("AankoopFacturen");
                xmlDoc.AppendChild(mainRoot);

                foreach (AankoopFactuur dezeAankoopFactuur in LijstAankoopFacturen)
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
        public void VerkoopFacturenSchrijven() 
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement mainRoot = xmlDoc.CreateElement("VerkoopFacturen");
                xmlDoc.AppendChild(mainRoot);

                foreach (VerkoopFactuur dezeVerkoopFactuur in LijstVerkoopFacturen)
                {
                    XmlElement root = xmlDoc.CreateElement("VerkoopFactuur");
                    mainRoot.AppendChild(root);

                    XmlElement datumOpmaakFactuur = xmlDoc.CreateElement("DatumOpmaakFactuur");
                    datumOpmaakFactuur.InnerText = dezeVerkoopFactuur.Datum.ToString();
                    root.AppendChild(datumOpmaakFactuur);

                    XmlElement verkoopFactuurID = xmlDoc.CreateElement("ID");
                    verkoopFactuurID.InnerText = dezeVerkoopFactuur.Guid.ToString();
                    root.AppendChild(verkoopFactuurID);

                    XmlElement naamMedewerker = xmlDoc.CreateElement("NaamMedewerker");
                    naamMedewerker.InnerText = dezeVerkoopFactuur.DezeGebruikerPlus.Naam;
                    root.AppendChild(naamMedewerker);

                    XmlElement voornaamMedewerker = xmlDoc.CreateElement("VoornaamMedewerker");
                    voornaamMedewerker.InnerText = dezeVerkoopFactuur.DezeGebruikerPlus.Voornaam;
                    root.AppendChild(voornaamMedewerker);

                    XmlElement naamKlant = xmlDoc.CreateElement("NaamKlant");
                    naamKlant.InnerText = dezeVerkoopFactuur.EenKlant.Naam;
                    root.AppendChild(naamKlant);

                    XmlElement verkoopArtikelen = xmlDoc.CreateElement("VerkoopArtikelen");
                    foreach (VerkoopArtikel ditVerkoopArtikel in dezeVerkoopFactuur.LijstVerkoopArtikels)
                    {
                        XmlElement verkoopArtikel = xmlDoc.CreateElement("VerkoopArtikel");
                        verkoopArtikelen.AppendChild(verkoopArtikel);

                        XmlElement naam = xmlDoc.CreateElement("Naam");
                        naam.InnerText = ditVerkoopArtikel.Naam;
                        verkoopArtikel.AppendChild(naam);

                        XmlElement verkoopArtikelID = xmlDoc.CreateElement("ID");
                        verkoopArtikelID.InnerText = ditVerkoopArtikel.Guid.ToString();
                        verkoopArtikel.AppendChild(verkoopArtikelID);

                        XmlElement aantalInStock = xmlDoc.CreateElement("AantalInStock");
                        aantalInStock.InnerText = ditVerkoopArtikel.AantalInStock.ToString();
                        verkoopArtikel.AppendChild(aantalInStock);

                        XmlElement verkoopprijs = xmlDoc.CreateElement("Verkoopprijs");
                        verkoopprijs.InnerText = ditVerkoopArtikel.Verkoopprijs.ToString().Replace(".", ",");
                        verkoopArtikel.AppendChild(verkoopprijs);
                    }
                    root.AppendChild(verkoopArtikelen);
                }
                xmlDoc.Save("VerkoopFacturen.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de lijst met verkoopfacturen.", ex.GetType().ToString());
            }
        }
    }
}
