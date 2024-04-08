using System.Runtime.InteropServices;


namespace Project_2__Bart_.Kassa
{
    public partial class FrmVerkoopKassa : Form
    {
        private Form1 frm1Instance;

        public FrmVerkoopKassa(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        private void Kassa_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            timTijd.Start();
            lblTijd.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString();
            lblNaamGebruiker.Text = IngelogdeGebruikerVerkoopKassa.Voornaam;
            timAfmelden.Start();
            var sortedList = frm1Instance.LijstVerkoopArtikels.OrderBy(artikel => artikel.Naam).ToList();
            lbArtikels.DataSource = sortedList;
            lbArtikels.DisplayMember = "Naam";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        string lijst = string.Empty, factuur = string.Empty;
        double totalePrijsFactuur = 0, wisselgeld;
        Klant huidigeKlant = new Klant();
        List<VerkoopArtikel> lijstArtikelsKassa = new List<VerkoopArtikel>();
        List<int> lijstHoeveelheiden = new List<int>();
        int tempStock,hoeveelheid;

        public List<GebruikerPlus> LijstGebruikersPlusVerkoopKassa
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Klant> LijstKlantenVerkoopKassa
        {
            get { return frm1Instance.LijstKlanten; }
            set { frm1Instance.LijstKlanten = value; }
        }
        public List<VerkoopArtikel> LijstVerkoopArtikelsVerkoopKassa
        {
            get { return frm1Instance.LijstVerkoopArtikels; }
            set { frm1Instance.LijstVerkoopArtikels = value; }
        }
        public List<VerkoopFactuur> LijstVerkoopFacturenVerkoopKassa
        {
            get { return frm1Instance.LijstVerkoopFacturen; }
            set { frm1Instance.LijstVerkoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerVerkoopKassa
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void timTIjd_Tick(object sender, EventArgs e)
        {
            lblTijd.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString();
            timTijd.Start();
        }
        private void btnKlantZoeken_Click(object sender, EventArgs e)
        {
            bool klantGevonden = false;
            foreach (var klant in LijstKlantenVerkoopKassa)

            {
                if (txtKlantNaam.Text.Equals(klant.Naam))
                {
                    lblKlantNaam.Text = "Klantnaam: " + klant.Naam;
                    lblTotaalSaldoKlant.Text = "Totaal saldo: " + klant.TotaalSaldoVerkoop;
                    huidigeKlant = klant;
                    klantGevonden = true;
                    break;
                }
            }
            if (klantGevonden == false)
            {
                DialogResult result = MessageBox.Show("Deze klant bestaat nog niet. Wilt u hem aanmaken?", "Klant niet gevonden", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    NieuweKlant nieuweklantScherm = new NieuweKlant(frm1Instance);
                    nieuweklantScherm.Show();
                }
                else if (result == DialogResult.Cancel)
                {

                }
                else if (result == DialogResult.No)
                {
                    huidigeKlant = LijstKlantenVerkoopKassa[0];
                    lblKlantNaam.Text = "Klantnaam: NvT";
                    lblTotaalSaldoKlant.Text = "Totaal saldo: NvT";
                }

            }
            btnToevoegen.Enabled = true;
            btnRembours.Enabled = true;
            btnAfrekenen.Enabled = true;
            btnCash.Enabled = true;
            btnBancontact.Enabled = true;
            btnMaaltijdcheques.Enabled = true;
            btnKredietkaart.Enabled = true;
            btnDoorgaan.Enabled = true;
        }
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            VerkoopArtikel geselecteerdArtikel = new VerkoopArtikel();
            geselecteerdArtikel = (VerkoopArtikel)lbArtikels.SelectedItem;
     
           
            hoeveelheid = Convert.ToInt32(nudHoeveelheid.Value);
            lijstArtikelsKassa.Add(geselecteerdArtikel);
            lijstHoeveelheiden.Add(hoeveelheid);
            totalePrijsFactuur += Convert.ToInt32(nudHoeveelheid.Value) * geselecteerdArtikel.Verkoopprijs;
            lijst += geselecteerdArtikel.Naam + "x".PadLeft(30) + nudHoeveelheid.Value.ToString().PadLeft(5) + "=".PadLeft(5) + " €" + geselecteerdArtikel.Verkoopprijs.ToString().PadLeft(5) + Environment.NewLine;
            txtFactuur.Font = new Font(txtFactuur.Font.FontFamily, txtFactuur.Font.Size, FontStyle.Regular);
            txtFactuur.TextAlign = HorizontalAlignment.Left;
            txtFactuur.Text = lijst;
        }
        private void btnRembours_Click(object sender, EventArgs e)
        {
            VerkoopArtikel geselecteerdArtikel = new VerkoopArtikel();
            geselecteerdArtikel = (VerkoopArtikel)lbArtikels.SelectedItem;
            hoeveelheid = Convert.ToInt32(nudHoeveelheid.Value);

            lijstArtikelsKassa.Add(geselecteerdArtikel);
            lijstHoeveelheiden.Add(hoeveelheid);
            totalePrijsFactuur -= Convert.ToInt32(nudHoeveelheid.Value) * geselecteerdArtikel.Verkoopprijs;
            lijst += geselecteerdArtikel.Naam + "x".PadLeft(30) + "-".PadLeft(5) + (nudHoeveelheid.Value).ToString().PadLeft(5) + "=" + " €" + geselecteerdArtikel.Verkoopprijs.ToString().PadLeft(5) + Environment.NewLine; //nud kan in min gaan
            txtFactuur.Font = new Font(txtFactuur.Font.FontFamily, txtFactuur.Font.Size, FontStyle.Regular);
            txtFactuur.TextAlign = HorizontalAlignment.Left;
            txtFactuur.Text = lijst;
        }
        private void btnAfrekenen_Click(object sender, EventArgs e)
        {

            factuur = "Bools & Booze Bvba" + Environment.NewLine + "Hemelstraat 12" + Environment.NewLine + "1234 Zonnedorp" + Environment.NewLine + "0488/05 77 99" + Environment.NewLine + Environment.NewLine + lijst + Environment.NewLine + "Prijs Aankoop" + "€".PadLeft(40) + Math.Round(totalePrijsFactuur * 0.79, 2).ToString() + Environment.NewLine + "BTW" + "€".PadLeft(40) + Math.Round(totalePrijsFactuur * 0.21, 2).ToString() + Environment.NewLine + "Te Betalen Bedrag" + "€".PadLeft(40) + totalePrijsFactuur.ToString() + Environment.NewLine;
            txtFactuur.Font = new Font(txtFactuur.Font.FontFamily, txtFactuur.Font.Size, FontStyle.Bold);
            txtFactuur.TextAlign = HorizontalAlignment.Center;
            txtFactuur.Text = factuur;
            txtTotaalBedrag.Text = "€" + totalePrijsFactuur;
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            try
            {
                wisselgeld = Convert.ToInt32(txtOntvangen.Text) - totalePrijsFactuur;
                txtWisselgeld.Text = "€" + wisselgeld.ToString();
                factuur += "Cash" + "€".PadLeft(40) + txtOntvangen.Text + Environment.NewLine + "Wisselgeld" + "€".PadLeft(40) + wisselgeld + Environment.NewLine + Environment.NewLine + DateTime.Now + Environment.NewLine + Environment.NewLine + "Bedankt om bij ons te winkelen." + Environment.NewLine + "U werd bediend door " + IngelogdeGebruikerVerkoopKassa.Voornaam + Environment.NewLine + "We hopen u spoedig weer te zien!" + Environment.NewLine + Environment.NewLine + "Bools & Booze Bvba";
                txtFactuur.Font = new Font(txtFactuur.Font.FontFamily, txtFactuur.Font.Size, FontStyle.Bold);
                txtFactuur.TextAlign = HorizontalAlignment.Center;
                txtFactuur.Text = factuur;
            }
            catch
            {
                MessageBox.Show("Gelieve een bedrag in te geven.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBancontact_Click(object sender, EventArgs e)
        {
            if (txtOntvangen.Text == "")
            {
                txtOntvangen.Text = totalePrijsFactuur.ToString();
            }
            txtOntvangen.Enabled = true;
            wisselgeld = Convert.ToInt32(txtOntvangen.Text) - totalePrijsFactuur;
            txtWisselgeld.Text = "€" + wisselgeld.ToString();
            factuur += "Bancontact" + "€".PadLeft(40) + txtOntvangen.Text + Environment.NewLine + "Wisselgeld" + "€".PadLeft(40) + wisselgeld + Environment.NewLine + Environment.NewLine + DateTime.Now + Environment.NewLine + Environment.NewLine + "Bedankt om bij ons te winkelen." + Environment.NewLine + "U werd bediend door " + IngelogdeGebruikerVerkoopKassa.Voornaam + Environment.NewLine + "We hopen u spoedig weer te zien!" + Environment.NewLine + Environment.NewLine + "Bools & Booze Bvba";
            txtFactuur.Font = new Font(txtFactuur.Font.FontFamily, txtFactuur.Font.Size, FontStyle.Bold);
            txtFactuur.TextAlign = HorizontalAlignment.Center;
            txtFactuur.Text = factuur;
        }
        private void btnMaaltijdcheques_Click(object sender, EventArgs e)
        {
            txtOntvangen.Text = "€" + totalePrijsFactuur.ToString();
            txtOntvangen.Enabled = false;
            wisselgeld = 0;
            txtWisselgeld.Text = "€" + wisselgeld.ToString();
            factuur += "Maaltijdcheques" + "€".PadLeft(40) + txtOntvangen.Text + Environment.NewLine + "Wisselgeld" + "€".PadLeft(40) + wisselgeld + Environment.NewLine + Environment.NewLine + DateTime.Now + Environment.NewLine + Environment.NewLine + "Bedankt om bij ons te winkelen." + Environment.NewLine + "U werd bediend door " + IngelogdeGebruikerVerkoopKassa.Voornaam + Environment.NewLine + "We hopen u spoedig weer te zien!" + Environment.NewLine + Environment.NewLine + "Bools & Booze Bvba";
            txtFactuur.Font = new Font(txtFactuur.Font.FontFamily, txtFactuur.Font.Size, FontStyle.Bold);
            txtFactuur.TextAlign = HorizontalAlignment.Center;
            txtFactuur.Text = factuur;
        }
        private void btnKredietkaart_Click(object sender, EventArgs e)
        {
            txtOntvangen.Text = "€" + totalePrijsFactuur.ToString();
            txtOntvangen.Enabled = false;
            wisselgeld = 0;
            txtWisselgeld.Text = "€" + wisselgeld.ToString();
            factuur += "Kredietkaart" + "€".PadLeft(40) + txtOntvangen.Text + Environment.NewLine + "Wisselgeld" + "€".PadLeft(40) + wisselgeld + Environment.NewLine + Environment.NewLine + DateTime.Now + Environment.NewLine + Environment.NewLine + "Bedankt om bij ons te winkelen." + Environment.NewLine + "U werd bediend door " + IngelogdeGebruikerVerkoopKassa.Voornaam + Environment.NewLine + "We hopen u spoedig weer te zien!" + Environment.NewLine + Environment.NewLine + "Bools & Booze Bvba";
            txtFactuur.Font = new Font(txtFactuur.Font.FontFamily, txtFactuur.Font.Size, FontStyle.Bold);
            txtFactuur.TextAlign = HorizontalAlignment.Center;
            txtFactuur.Text = factuur;
        }
        private void btnDoorgaan_Click(object sender, EventArgs e)
        {
            try
            {
                int i = -1;
                VerkoopFactuur factuur1 = new VerkoopFactuur(DateTime.Now, IngelogdeGebruikerVerkoopKassa, huidigeKlant, lijstArtikelsKassa);
                LijstVerkoopFacturenVerkoopKassa.Add(factuur1);
                huidigeKlant.TotaalSaldoVerkoop += totalePrijsFactuur;
                huidigeKlant.LijstVerkoopfacturenKlant.Add(factuur1);
                foreach (var artikelKassal in lijstArtikelsKassa)
                {
                    i++;
                    hoeveelheid = lijstHoeveelheiden[i];
                    foreach (var verkoopartikel in frm1Instance.LijstVerkoopArtikels)
                    {
                        if (artikelKassal.Naam.Equals(verkoopartikel.Naam))
                        {
                            verkoopartikel.AantalInStock -= hoeveelheid;
                            frm1Instance.VerkoopArtikelenSchrijven();
                        }
                    }

                    foreach (var aankoopartikel in frm1Instance.LijstAankoopArtikels.OrderByDescending(a => a.Datum))
                    {
                        if (artikelKassal.Naam.Equals(aankoopartikel.Naam))
                        {
                            if (aankoopartikel.AantalInStock - hoeveelheid > 0)
                            {
                                aankoopartikel.AantalInStock -= hoeveelheid;
                                hoeveelheid = 0;
                                frm1Instance.AankoopArtikelenSchrijven();
                            }
                            else if (aankoopartikel.AantalInStock - hoeveelheid == 0)
                            {
                                aankoopartikel.AantalInStock = 0;
                                frm1Instance.LijstAankoopArtikels.Remove(aankoopartikel);
                                hoeveelheid = 0;
                                frm1Instance.AankoopArtikelenSchrijven();
                            }
                            else if (aankoopartikel.AantalInStock - hoeveelheid < 0)
                            {
                                hoeveelheid = Math.Abs(aankoopartikel.AantalInStock -= hoeveelheid);
                                aankoopartikel.AantalInStock = 0;
                                frm1Instance.LijstAankoopArtikels.Remove(aankoopartikel);
                                frm1Instance.AankoopArtikelenSchrijven();

                            }
                        }

                    }
                }
                frm1Instance.KlantenSchrijven();
                frm1Instance.VerkoopArtikelenSchrijven();
                frm1Instance.VerkoopFacturenSchrijven();
                frm1Instance.AankoopArtikelenSchrijven();
                txtFactuur.Text = "";
                txtOntvangen.Text = "";
                txtTotaalBedrag.Text = "";
                txtWisselgeld.Text = "";
                txtKlantNaam.Text = "";
                lblKlantNaam.Text = "Klantnaam:";
                lblTotaalSaldoKlant.Text = "Totaal saldo:";
                lijst = string.Empty;
                txtOntvangen.Enabled = true;
                factuur = string.Empty;
                totalePrijsFactuur = 0;
                wisselgeld = 0;
                huidigeKlant = new Klant();
                lijstArtikelsKassa.Clear();
                lijstHoeveelheiden.Clear();
                btnToevoegen.Enabled = false;
                btnRembours.Enabled = false;
                btnAfrekenen.Enabled = false;
                btnCash.Enabled = false;
                btnBancontact.Enabled = false;
                btnMaaltijdcheques.Enabled = false;
                btnKredietkaart.Enabled = false;
                btnDoorgaan.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("U kan niet meer artikels verkopen dan u in stock heeft! Gelieve stockmanagement te contacteren.");
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("User32.dll")]

        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        internal struct LASTINPUTINFO
        {
            public uint cbSize;

            public uint dwTime;
        }
        public static uint GetIdleTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            GetLastInputInfo(ref LastUserAction);
            return ((uint)Environment.TickCount - LastUserAction.dwTime);
        }
        private void timAfmelden_Tick(object sender, EventArgs e)
        {


            if (GetIdleTime() > 60000)
                this.Close();

        }
        private void lbArtikels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //private void timAfmelden_Tick(object sender, EventArgs e)
        //{
        //    if (Cursor.Position == previousCursorPosition)
        //    {
        //        idleTime++;
        //        if (idleTime >= 60)
        //        {
        //            this.Close();
        //        }
        //    }
        //    else
        //    {
        //        idleTime = 0;
        //        previousCursorPosition = Cursor.Position;
        //    }
        //}
    }
}

