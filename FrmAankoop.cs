namespace Project_2__Bart_
{
    public partial class FrmAankoop : Form
    {
        private Form1 frm1Instance;
        FrmOverzichtAankoop aankoopOverzichtScherm;
        FrmInventarisAankoop aankoopInventarisScherm;
        FrmBestellingenAankoop aankoopBestellingenScherm;
        FrmLeveringenAankoop aankoopLeveringenScherm;
        FrmLeverancierBeheer leverancierBeheerScherm;

        public FrmAankoop(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusAankoop
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Leverancier> LijstLeveranciersAankoop
        {
            get { return frm1Instance.LijstLeveranciers; }
            set { frm1Instance.LijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikelsAankoop
        {
            get { return frm1Instance.LijstAankoopArtikels; }
            set { frm1Instance.LijstAankoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturenAankoop
        {
            get { return frm1Instance.LijstAankoopFacturen; }
            set { frm1Instance.LijstAankoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAankoop
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmAankoop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void BtnOverzichtAankoop_Click(object sender, EventArgs e)
        {
            if (aankoopOverzichtScherm == null)
            {
                aankoopOverzichtScherm = new FrmOverzichtAankoop(frm1Instance);
                aankoopOverzichtScherm.LijstGebruikersPlusAankoopOverzicht = frm1Instance.LijstGebruikersPlus;
                aankoopOverzichtScherm.LijstLeveranciersAankoopOverzicht = frm1Instance.LijstLeveranciers;
                aankoopOverzichtScherm.LijstAankoopArtikelsAankoopOverzicht = frm1Instance.LijstAankoopArtikels;
                aankoopOverzichtScherm.LijstAankoopFacturenAankoopOverzicht = frm1Instance.LijstAankoopFacturen;
                aankoopOverzichtScherm.IngelogdeGebruikerAankoopOverzicht = frm1Instance.IngelogdeGebruiker;
                aankoopOverzichtScherm.FormClosed += (s, args) => this.Show();
                aankoopOverzichtScherm.FormClosed += AankoopOverzichtScherm_FormClosed;
                aankoopOverzichtScherm.MdiParent = this.MdiParent;
                aankoopOverzichtScherm.Show();
                aankoopOverzichtScherm.WindowState = FormWindowState.Minimized;
                aankoopOverzichtScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                aankoopOverzichtScherm.Activate();
            }
        }
        private void btnInventarisBewerkenAankoop_Click(object sender, EventArgs e)
        {
            if (aankoopInventarisScherm == null)
            {
                aankoopInventarisScherm = new FrmInventarisAankoop(frm1Instance);
                aankoopInventarisScherm.LijstGebruikersPlusAankoopInventaris = frm1Instance.LijstGebruikersPlus;
                aankoopInventarisScherm.LijstLeveranciersAankoopInventaris = frm1Instance.LijstLeveranciers;
                aankoopInventarisScherm.LijstAankoopArtikelsAankoopInventaris = frm1Instance.LijstAankoopArtikels;
                aankoopInventarisScherm.LijstAankoopFacturenAankoopInventaris = frm1Instance.LijstAankoopFacturen;
                aankoopInventarisScherm.IngelogdeGebruikerAankoopInventaris = frm1Instance.IngelogdeGebruiker;
                aankoopInventarisScherm.FormClosed += (s, args) => this.Show();
                aankoopInventarisScherm.FormClosed += AankoopInventarisScherm_FormClosed;
                aankoopInventarisScherm.MdiParent = this.MdiParent;
                aankoopInventarisScherm.Show();
                aankoopInventarisScherm.WindowState = FormWindowState.Minimized;
                aankoopInventarisScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                aankoopInventarisScherm.Activate();
            }
        }
        private void btnBestellingen_Click(object sender, EventArgs e)
        {
            if (aankoopBestellingenScherm == null)
            {
                aankoopBestellingenScherm = new FrmBestellingenAankoop(frm1Instance);
                aankoopBestellingenScherm.LijstGebruikersPlusAankoopBestellingen = frm1Instance.LijstGebruikersPlus;
                aankoopBestellingenScherm.LijstLeveranciersAankoopBestellingen = frm1Instance.LijstLeveranciers;
                aankoopBestellingenScherm.LijstAankoopArtikelsAankoopBestellingen = frm1Instance.LijstAankoopArtikels;
                aankoopBestellingenScherm.LijstAankoopFacturenAankoopBestellingen = frm1Instance.LijstAankoopFacturen;
                aankoopBestellingenScherm.IngelogdeGebruikerAankoopBestellingen = frm1Instance.IngelogdeGebruiker;
                aankoopBestellingenScherm.FormClosed += (s, args) => this.Show();
                aankoopBestellingenScherm.FormClosed += AankoopBestellingenScherm_FormClosed;
                aankoopBestellingenScherm.MdiParent = this.MdiParent;
                aankoopBestellingenScherm.Show();
                aankoopBestellingenScherm.WindowState = FormWindowState.Minimized;
                aankoopBestellingenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                aankoopBestellingenScherm.Activate();
            }
        }
        private void btnLeveringenAankoop_Click(object sender, EventArgs e)
        {
            if (aankoopLeveringenScherm == null)
            {
                aankoopLeveringenScherm = new FrmLeveringenAankoop(frm1Instance);
                aankoopLeveringenScherm.LijstGebruikersPlusAankoopLeveringen = frm1Instance.LijstGebruikersPlus;
                aankoopLeveringenScherm.LijstLeveranciersAankoopLeveringen = frm1Instance.LijstLeveranciers;
                aankoopLeveringenScherm.LijstAankoopArtikelsAankoopLeveringen = frm1Instance.LijstAankoopArtikels;
                aankoopLeveringenScherm.LijstAankoopFacturenAankoopLeveringen = frm1Instance.LijstAankoopFacturen;
                aankoopLeveringenScherm.IngelogdeGebruikerAankoopLeveringen = frm1Instance.IngelogdeGebruiker;
                aankoopLeveringenScherm.FormClosed += (s, args) => this.Show();
                aankoopLeveringenScherm.FormClosed += AankoopLeveringenScherm_FormClosed;
                aankoopLeveringenScherm.MdiParent = this.MdiParent;
                aankoopLeveringenScherm.Show();
                aankoopLeveringenScherm.WindowState = FormWindowState.Minimized;
                aankoopLeveringenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                aankoopLeveringenScherm.Activate();
            }
        }
        private void btnLeverancierBeheer_Click(object sender, EventArgs e)
        {
            if (leverancierBeheerScherm == null)
            {
                leverancierBeheerScherm = new FrmLeverancierBeheer(frm1Instance);
                leverancierBeheerScherm.FormClosed += (s, args) => this.Show();
                leverancierBeheerScherm.FormClosed += LeverancierBeheerScherm_FormClosed;
                leverancierBeheerScherm.MdiParent = this.MdiParent;
                leverancierBeheerScherm.Show();
                leverancierBeheerScherm.WindowState = FormWindowState.Minimized;
                leverancierBeheerScherm.WindowState = FormWindowState.Maximized;
            }

        }
        private void btnTerugAankoop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AankoopOverzichtScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            aankoopOverzichtScherm = null;
        }
        private void AankoopInventarisScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            aankoopInventarisScherm = null;
        }
        private void AankoopBestellingenScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            aankoopBestellingenScherm = null;
        }
        private void AankoopLeveringenScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            aankoopLeveringenScherm = null;
        }
        private void LeverancierBeheerScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            leverancierBeheerScherm = null;
        }
    }
}
