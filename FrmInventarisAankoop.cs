using System.Data;

namespace Project_2__Bart_
{
    public partial class FrmInventarisAankoop : Form
    {
        private Form1 frm1Instance;

        public FrmInventarisAankoop(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusAankoopInventaris
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Leverancier> LijstLeveranciersAankoopInventaris
        {
            get { return frm1Instance.LijstLeveranciers; }
            set { frm1Instance.LijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikelsAankoopInventaris
        {
            get { return frm1Instance.LijstAankoopArtikels; }
            set { frm1Instance.LijstAankoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturenAankoopInventaris
        {
            get { return frm1Instance.LijstAankoopFacturen; }
            set { frm1Instance.LijstAankoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAankoopInventaris
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmInventarisAankoop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                var sortedList = frm1Instance.LijstAankoopArtikels.OrderBy(artikel => artikel.Naam).ThenBy(artikel => artikel.Datum).ToList();
                lstAankoopartikels.DataSource = sortedList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void btnBewerken_Click(object sender, EventArgs e)
        {
            try
            {
                int stockaanpassingAankoop;
                AankoopArtikel geselecteerdArtikel = (AankoopArtikel)lstAankoopartikels.SelectedItem;
                stockaanpassingAankoop = geselecteerdArtikel.AantalInStock - Convert.ToInt32(txtAantalInstock.Text);
                geselecteerdArtikel.Aankoopprijs = Convert.ToDouble(txtAankoopprijs.Text);
                geselecteerdArtikel.AantalInStock = Convert.ToInt32(txtAantalInstock.Text);
                geselecteerdArtikel.PlaatsInWarenhuis = txtPlaatsInWarenhuis.Text;
                foreach (var artikel in frm1Instance.LijstVerkoopArtikels)
                {
                    if (artikel.Naam == geselecteerdArtikel.Naam)
                    {
                        artikel.AantalInStock = artikel.AantalInStock - stockaanpassingAankoop;
                        frm1Instance.VerkoopArtikelenSchrijven();
                    }
                }
                List<AankoopArtikel> updatedList = new List<AankoopArtikel>();
                foreach (var artikel in frm1Instance.LijstAankoopArtikels)
                {
                    if (artikel.Guid == geselecteerdArtikel.Guid)
                    {
                        updatedList.Add(geselecteerdArtikel);
                    }
                    else
                    {
                        updatedList.Add(artikel);
                    }
                }
                frm1Instance.LijstAankoopArtikels = updatedList;
                lstAankoopartikels.DataSource = null;
                var sortedList = updatedList.OrderBy(artikel => artikel.Naam).ThenBy(artikel => artikel.Datum).ToList();
                lstAankoopartikels.DataSource = sortedList;
                frm1Instance.AankoopArtikelenSchrijven();
                MessageBox.Show("Het artikel is bewerkt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                if (((AankoopArtikel)lstAankoopartikels.SelectedItem != null))
                {
                    AankoopArtikel geselecteerdArtikel = (AankoopArtikel)lstAankoopartikels.SelectedItem;
                    foreach (var artikel in frm1Instance.LijstAankoopArtikels)
                    {
                        if (artikel.Naam == geselecteerdArtikel.Naam && artikel.Datum == geselecteerdArtikel.Datum)
                        {
                            foreach (var verkoopartikel in frm1Instance.LijstVerkoopArtikels)
                            {
                                if (verkoopartikel.Naam == artikel.Naam)
                                {
                                    verkoopartikel.AantalInStock = verkoopartikel.AantalInStock - artikel.AantalInStock;
                                    frm1Instance.VerkoopArtikelenSchrijven();
                                }
                            }
                            frm1Instance.LijstAankoopArtikels.Remove(artikel);
                            break;
                        }
                    }
                }
                lstAankoopartikels.DataSource = null;
                var sortedList = frm1Instance.LijstAankoopArtikels.OrderBy(artikel => artikel.Naam).ThenBy(artikel => artikel.Datum).ToList();
                lstAankoopartikels.DataSource = sortedList;
                frm1Instance.AankoopArtikelenSchrijven();
                MessageBox.Show("Het artikel is verwijderd uit de inventaris.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void lstAankoopartikels_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((AankoopArtikel)lstAankoopartikels.SelectedItem != null))
                {
                    AankoopArtikel geselecteerdArtikel = (AankoopArtikel)lstAankoopartikels.SelectedItem;
                    txtAankoopprijs.Text = geselecteerdArtikel.Aankoopprijs.ToString();
                    txtAantalInstock.Text = geselecteerdArtikel.AantalInStock.ToString();
                    txtPlaatsInWarenhuis.Text = geselecteerdArtikel.PlaatsInWarenhuis;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void lstAankoopartikels_Format(object sender, ListControlConvertEventArgs e)
        {
            try
            {
                string naam = ((AankoopArtikel)e.ListItem).Naam;
                string datum = ((AankoopArtikel)e.ListItem).Datum.ToString("dd/MM/yyyy");
                e.Value = naam + " - " + datum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void btnTerugInventarisAankoop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
    }
}