using System.Data;

namespace Project_2__Bart_
{
    public partial class FrmPrijszetting : Form
    {
        private Form1 frm1Instance;

        public FrmPrijszetting(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        private void FrmPrijszetting_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                var sortedList = frm1Instance.LijstVerkoopArtikels.OrderBy(artikel => artikel.Naam).ToList();
                lstVerkoopArtikels.DataSource = sortedList;
                lstVerkoopArtikels.DisplayMember = "Naam";
            }
            catch
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void btnBewerken_Click(object sender, EventArgs e)
        {
            try
            {
                VerkoopArtikel geselecteerdArtikel = (VerkoopArtikel)lstVerkoopArtikels.SelectedItem;
                geselecteerdArtikel.Verkoopprijs = Convert.ToDouble(txtPrijs.Text);
                geselecteerdArtikel.Minimumvoorraadniveau = Convert.ToInt32(txtMinimumvoorraadniveau.Text);
                List<VerkoopArtikel> updatedList = new List<VerkoopArtikel>();
                foreach (var artikel in frm1Instance.LijstVerkoopArtikels)
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
                frm1Instance.LijstVerkoopArtikels = updatedList;
                frm1Instance.VerkoopArtikelenSchrijven();
                var sortedList = frm1Instance.LijstVerkoopArtikels.OrderBy(artikel => artikel.Naam).ToList();
                lstVerkoopArtikels.DataSource = sortedList;
                lstVerkoopArtikels.DisplayMember = "Naam";
                MessageBox.Show("Gegevens werden aangepast.");
            }
            catch
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void lstVerkoopArtikels_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstVerkoopArtikels.SelectedItem != null)
                {
                    VerkoopArtikel geselecteerdArtikel = (VerkoopArtikel)lstVerkoopArtikels.SelectedItem;
                    txtPrijs.Text = Convert.ToString(geselecteerdArtikel.Verkoopprijs);
                    txtMinimumvoorraadniveau.Text = Convert.ToString(geselecteerdArtikel.Minimumvoorraadniveau);
                }
            }
            catch
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
    }
}
