namespace Project_2__Bart_
{
    public partial class FrmWerknemersDashboard : Form
    {
        private Form1 frm1Instance;

        public FrmWerknemersDashboard(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        FrmVerslagen verslagenScherm;
        FrmVerkoop verkoopScherm;
        FrmAankoop aankoopScherm;

        public List<GebruikersRol> LijstGebruikersrollenWN
        {
            get { return frm1Instance.LijstGebruikersrollen; }
            set { frm1Instance.LijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikersWN
        {
            get { return frm1Instance.LijstGebruikers; }
            set { frm1Instance.LijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingenWN
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlusWN
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Klant> LijstKlantenWN
        {
            get { return frm1Instance.LijstKlanten; }
            set { frm1Instance.LijstKlanten = value; }
        }
        public List<Leverancier> LijstLeveranciersWN
        {
            get { return frm1Instance.LijstLeveranciers; }
            set { frm1Instance.LijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikelsWN
        {
            get { return frm1Instance.LijstAankoopArtikels; }
            set { frm1Instance.LijstAankoopArtikels = value; }
        }
        public List<VerkoopArtikel> LijstVerkoopArtikelsWN
        {
            get { return frm1Instance.LijstVerkoopArtikels; }
            set { frm1Instance.LijstVerkoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturenWN
        {
            get { return frm1Instance.LijstAankoopFacturen; }
            set { frm1Instance.LijstAankoopFacturen = value; }
        }
        public List<VerkoopFactuur> LijstVerkoopFacturenWN
        {
            get { return frm1Instance.LijstVerkoopFacturen; }
            set { frm1Instance.LijstVerkoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerWN
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmWerknemersDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                bool verkoopGevonden = false;
                bool aankoopGevonden = false;
                foreach (var afdeling in IngelogdeGebruikerWN.LijstAfdelingen)
                {
                    if (afdeling.Naam.ToUpper() == "VERKOOP")
                    {
                        verkoopGevonden = true;
                    }
                    if (afdeling.Naam.ToUpper() == "AANKOOP")
                    {
                        aankoopGevonden = true;
                    }
                }
                if (verkoopGevonden == false)
                {
                    btnVerkoop.Enabled = false;
                }
                if (aankoopGevonden == false)
                {
                    btnAankoop.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets misgelopen bij het vrijgeven van de buttons.", ex.GetType().ToString());
            }
        }
        //private void BtnPersoonlijkeInfo_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        GebruikerPlus eenGebruikerPlus = new GebruikerPlus();
        //        MessageBox.Show(eenGebruikerPlus.PersoonlijkeInfo(LijstGebruikersPlusWN, IngelogdeGebruikerWN));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Er is iets misgelopen bij het laden van de persoonlijke info", ex.GetType().ToString());
        //    }
        //}
        //private void btnVerkoop_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    FrmVerkoop verkoopScherm = new FrmVerkoop(frm1Instance);
        //    verkoopScherm.LijstGebruikersPlusVerkoop = frm1Instance.LijstGebruikersPlus;
        //    verkoopScherm.LijstKlantenVerkoop = frm1Instance.LijstKlanten;
        //    verkoopScherm.LijstVerkoopArtikelsVerkoop = frm1Instance.LijstVerkoopArtikels;
        //    verkoopScherm.LijstVerkoopFacturenVerkoop = frm1Instance.LijstVerkoopFacturen;
        //    verkoopScherm.IngelogdeGebruikerVerkoop = frm1Instance.IngelogdeGebruiker;
        //    verkoopScherm.FormClosed += (s, args) => this.Show();   //Bart: Toon deze form wanneer de andere form wordt gesloten !!!
        //    verkoopScherm.ShowDialog();
        //}
        //private void btnAankoop_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    FrmAankoop aankoopScherm = new FrmAankoop(frm1Instance);
        //    aankoopScherm.LijstGebruikersPlusAankoop = frm1Instance.LijstGebruikersPlus;
        //    aankoopScherm.LijstLeveranciersAankoop = frm1Instance.LijstLeveranciers;
        //    aankoopScherm.LijstAankoopArtikelsAankoop = frm1Instance.LijstAankoopArtikels;
        //    aankoopScherm.LijstAankoopFacturenAankoop = frm1Instance.LijstAankoopFacturen;
        //    aankoopScherm.IngelogdeGebruikerAankoop = frm1Instance.IngelogdeGebruiker;
        //    aankoopScherm.FormClosed += (s, args) => this.Show();
        //    aankoopScherm.ShowDialog();
        //}
        //private void btnVerslagen_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    FrmVerslagen verslagenScherm = new FrmVerslagen(frm1Instance);
        //    verslagenScherm.IngelogdeGebruikerVerslagen = frm1Instance.IngelogdeGebruiker;
        //    verslagenScherm.FormClosed += (s, args) => this.Show();
        //    verslagenScherm.ShowDialog();
        //}
        //private void btnAfmelden_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    Form1 frm1 = new Form1();
        //    frm1.Show();
        //}
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void btnMinimize_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        //private void btnMaximize_Click(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //    }

        //}
        private void btnVerslagen_Click_1(object sender, EventArgs e)
        {
            if (verslagenScherm == null)
            {
                verslagenScherm = new FrmVerslagen(frm1Instance);
                verslagenScherm.FormClosed += Verslagen_FormClosed;
                verslagenScherm.MdiParent = this;
                verslagenScherm.Show();
                verslagenScherm.WindowState = FormWindowState.Minimized;
                verslagenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                verslagenScherm.Activate();
            }
        }
        private void Verslagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            verslagenScherm = null;
        }
        private void btnVerkoop_Click(object sender, EventArgs e)
        {
            if (verkoopScherm == null)
            {
                verkoopScherm = new FrmVerkoop(frm1Instance);
                verkoopScherm.FormClosed += Verkoop_FormClosed;
                verkoopScherm.MdiParent = this;
                verkoopScherm.LijstGebruikersPlusVerkoop = frm1Instance.LijstGebruikersPlus;
                verkoopScherm.LijstKlantenVerkoop = frm1Instance.LijstKlanten;
                verkoopScherm.LijstVerkoopArtikelsVerkoop = frm1Instance.LijstVerkoopArtikels;
                verkoopScherm.LijstVerkoopFacturenVerkoop = frm1Instance.LijstVerkoopFacturen;
                verkoopScherm.IngelogdeGebruikerVerkoop = frm1Instance.IngelogdeGebruiker;
                verkoopScherm.Show();
                verkoopScherm.WindowState = FormWindowState.Minimized;
                verkoopScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                verkoopScherm.Activate();
            }
        }
        private void btnAankoop_Click(object sender, EventArgs e)
        {
            if (aankoopScherm == null)
            {
                aankoopScherm = new FrmAankoop(frm1Instance);
                aankoopScherm.FormClosed += Aankoop_FormClosed;
                aankoopScherm.MdiParent = this;
                aankoopScherm.LijstGebruikersPlusAankoop = frm1Instance.LijstGebruikersPlus;
                aankoopScherm.LijstLeveranciersAankoop = frm1Instance.LijstLeveranciers;
                aankoopScherm.LijstAankoopArtikelsAankoop = frm1Instance.LijstAankoopArtikels;
                aankoopScherm.LijstAankoopFacturenAankoop = frm1Instance.LijstAankoopFacturen;
                aankoopScherm.IngelogdeGebruikerAankoop = frm1Instance.IngelogdeGebruiker;
                aankoopScherm.Show();
                aankoopScherm.WindowState = FormWindowState.Minimized;
                aankoopScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                aankoopScherm.Activate();
            }
        }
        private void Verkoop_FormClosed(object sender, FormClosedEventArgs e)
        {
            verkoopScherm = null;
        }
        private void Aankoop_FormClosed(object sender, FormClosedEventArgs e)
        {
            aankoopScherm = null;
        }
        private void btnAfmelden_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
        private void BtnPersoonlijkeInfo_Click_1(object sender, EventArgs e)
        {
            try
            {
                GebruikerPlus eenGebruikerPlus = new GebruikerPlus();
                MessageBox.Show(eenGebruikerPlus.PersoonlijkeInfo(LijstGebruikersPlusWN, IngelogdeGebruikerWN));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets misgelopen bij het laden van de persoonlijke info", ex.GetType().ToString());
            }
        }
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
