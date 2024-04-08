namespace Project_2__Bart_
{
    public partial class FrmAdminDashboard : Form
    {
        private Form1 frm1Instance;
        FrmAdminDashboard dashboard;
        FrmAdminToDoLijst toDoLijstScherm;
        FrmAdminBeheer beheerScherm;
        FrmVerslagen verslagenScherm;
        FrmVerkoop verkoopScherm;
        FrmAankoop aankoopScherm;
        FrmAdminEncryptie medencryptieScherm;

        public FrmAdminDashboard(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikersRol> LijstGebruikersrollenAdmin
        {
            get { return frm1Instance.LijstGebruikersrollen; }
            set { frm1Instance.LijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikersAdmin
        {
            get { return frm1Instance.LijstGebruikers; }
            set { frm1Instance.LijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingenAdmin
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlusAdmin
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Klant> LijstKlantenAdmin
        {
            get { return frm1Instance.LijstKlanten; }
            set { frm1Instance.LijstKlanten = value; }
        }
        public List<Leverancier> LijstLeveranciersAdmin
        {
            get { return frm1Instance.LijstLeveranciers; }
            set { frm1Instance.LijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikelsAdmin
        {
            get { return frm1Instance.LijstAankoopArtikels; }
            set { frm1Instance.LijstAankoopArtikels = value; }
        }
        public List<VerkoopArtikel> LijstVerkoopArtikelsAdmin
        {
            get { return frm1Instance.LijstVerkoopArtikels; }
            set { frm1Instance.LijstVerkoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturenAdmin
        {
            get { return frm1Instance.LijstAankoopFacturen; }
            set { frm1Instance.LijstAankoopFacturen = value; }
        }
        public List<VerkoopFactuur> LijstVerkoopFacturenAdmin
        {
            get { return frm1Instance.LijstVerkoopFacturen; }
            set { frm1Instance.LijstVerkoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAdmin
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void BtnPersoonlijkeInfo_Click(object sender, EventArgs e)
        {
            try
            {
                GebruikerPlus eenGebruikerPlus = new GebruikerPlus();
                MessageBox.Show(eenGebruikerPlus.PersoonlijkeInfo(LijstGebruikersPlusAdmin, IngelogdeGebruikerAdmin));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets misgelopen bij het laden van de persoonlijke info", ex.GetType().ToString());
            }
        }
        private void btnToDoLijst_Click(object sender, EventArgs e)
        {
            if (toDoLijstScherm == null)
            {
                toDoLijstScherm = new FrmAdminToDoLijst();
                toDoLijstScherm.FormClosed += ToDoLijst_FormClosed;
                toDoLijstScherm.MdiParent = this;
                toDoLijstScherm.Show();
                toDoLijstScherm.WindowState = FormWindowState.Minimized;
                toDoLijstScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                toDoLijstScherm.Activate();
            }

        }
        private void btnGegevensbeheer_Click(object sender, EventArgs e)
        {
            if (beheerScherm == null)
            {
                beheerScherm = new FrmAdminBeheer(frm1Instance);
                beheerScherm.LijstGebruikersrollenAdminBeheer = frm1Instance.LijstGebruikersrollen;
                beheerScherm.LijstGebruikersAdminBeheer = frm1Instance.LijstGebruikers;
                beheerScherm.LijstAfdelingenAdminBeheer = frm1Instance.LijstAfdelingen;
                beheerScherm.LijstGebruikersPlusAdminBeheer = frm1Instance.LijstGebruikersPlus;
                beheerScherm.IngelogdeGebruikerAdminBeheer = frm1Instance.IngelogdeGebruiker;
                beheerScherm.FormClosed += Beheer_FormClosed;
                beheerScherm.MdiParent = this;
                beheerScherm.Show();
                beheerScherm.WindowState = FormWindowState.Minimized;
                beheerScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                beheerScherm.Activate();
            }

        }
        private void btnVerslagen_Click(object sender, EventArgs e)
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
        private void btnEncryptie_Click(object sender, EventArgs e)
        {
            if (medencryptieScherm == null)
            {
                medencryptieScherm = new FrmAdminEncryptie(frm1Instance);
                medencryptieScherm.FormClosed += Medencryptie_FormClosed;
                medencryptieScherm.MdiParent = this;
                medencryptieScherm.Show();
                medencryptieScherm.WindowState = FormWindowState.Minimized;
                medencryptieScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                medencryptieScherm.Activate();
            }
        }
        private void btnAfmelden_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {

        }
        private void ToDoLijst_FormClosed(object sender, FormClosedEventArgs e)
        {
            toDoLijstScherm = null;
        }
        private void Verslagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            verslagenScherm = null;
        }
        private void Medencryptie_FormClosed(object sender, FormClosedEventArgs e)
        {
            medencryptieScherm = null;
        }
        private void Beheer_FormClosed(object sender, FormClosedEventArgs e)
        {
            beheerScherm = null;
        }
        private void Verkoop_FormClosed(object sender, FormClosedEventArgs e)
        {
            verkoopScherm = null;
        }
        private void Aankoop_FormClosed(object sender, FormClosedEventArgs e)
        {
            aankoopScherm = null;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
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
        private void Header_Paint(object sender, PaintEventArgs e)
        {

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
