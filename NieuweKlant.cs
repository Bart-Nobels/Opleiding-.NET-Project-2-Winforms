namespace Project_2__Bart_.Kassa
{
    public partial class NieuweKlant : Form
    {
        private Form1 frm1Instance;

        public NieuweKlant(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<Klant> LijstKlantenVerkoopKassaNieuweKlant
        {
            get { return frm1Instance.LijstKlanten; }
            set { frm1Instance.LijstKlanten = value; }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNaam.Text == "")
                {
                    MessageBox.Show("Gelieve een naam in te vullen.");
                }
                else
                {
                    Klant klant = new Klant(txtNaam.Text, txtAdres.Text, txtTelefoon.Text, txtEmail.Text, 0, new List<VerkoopFactuur>());
                    LijstKlantenVerkoopKassaNieuweKlant.Add(klant);
                    frm1Instance.KlantenSchrijven();
                    MessageBox.Show("Uw klant werd aangemaakt.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
    }
}
