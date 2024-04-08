namespace Project_2__Bart_
{
    public partial class FrmKlantenBeheer : Form
    {
        private Form1 frm1Instance;

        public FrmKlantenBeheer(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        private void FrmKlantenBeheer_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                var sortedList = frm1Instance.LijstKlanten.OrderBy(klant => klant.Naam).ToList();
                sortedList.Insert(0, frm1Instance.LijstKlanten[0]);
                for (int i = 1; i < sortedList.Count; i++)
                {
                    if (sortedList[i].Naam == sortedList[0].Naam)
                    {
                        sortedList.RemoveAt(i);
                    }
                }
                lstKlanten.DataSource = sortedList;
                lstKlanten.DisplayMember = "Naam";
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
                if ((Klant)lstKlanten.SelectedItem == frm1Instance.LijstKlanten[0])
                {
                    MessageBox.Show("U kan de Default gebruiker niet verwijderen");
                }
                else
                {
                    Klant geselecteerdeKlant = (Klant)lstKlanten.SelectedItem;
                    frm1Instance.LijstKlanten.Remove(geselecteerdeKlant);
                    MessageBox.Show("De Klant werd succesvol verwijderd.","Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstKlanten.DataSource = null;
                    var sortedList = frm1Instance.LijstKlanten.OrderBy(klant => klant.Naam).ToList();
                    sortedList.Insert(0, frm1Instance.LijstKlanten[0]);
                    for (int i = 1; i < sortedList.Count; i++)
                    {
                        if (sortedList[i].Naam == sortedList[0].Naam)
                        {
                            sortedList.RemoveAt(i);
                        }
                    }
                    lstKlanten.DataSource = sortedList;
                    lstKlanten.DisplayMember = "Naam";
                    frm1Instance.KlantenSchrijven();
                }
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
                if ((Klant)lstKlanten.SelectedItem == frm1Instance.LijstKlanten[0])
                {
                    MessageBox.Show("U kan de Default gebruiker niet aanpassen.");
                }
                else
                {
                    Klant geselecteerdeKlant = (Klant)lstKlanten.SelectedItem;
                    geselecteerdeKlant.Naam = txtNaam.Text;
                    geselecteerdeKlant.Adres = txtAdres.Text;
                    geselecteerdeKlant.Telefoonnummer = txtTelefoonnummer.Text;
                    geselecteerdeKlant.Email = txtEmail.Text;

                    List<Klant> updatedList = new List<Klant>();
                    foreach (var klant in frm1Instance.LijstKlanten)
                    {
                        if (klant.Guid == geselecteerdeKlant.Guid)
                        {
                            updatedList.Add(geselecteerdeKlant);
                        }
                        else
                        {
                            updatedList.Add(klant);
                        }
                    }
                    frm1Instance.LijstKlanten = updatedList;

                    lstKlanten.DataSource = null;
                    var sortedList = frm1Instance.LijstKlanten.OrderBy(klant => klant.Naam).ToList();
                    sortedList.Insert(0, frm1Instance.LijstKlanten[0]);
                    for (int i = 1; i < sortedList.Count; i++)
                    {
                        if (sortedList[i].Naam == sortedList[0].Naam)
                        {
                            sortedList.RemoveAt(i);
                        }
                    }
                    lstKlanten.DataSource = sortedList;
                    lstKlanten.DisplayMember = "Naam";
                    frm1Instance.KlantenSchrijven();
                    MessageBox.Show("Gegevens werden aangepast.","Melding", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        private void lstKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((Klant)lstKlanten.SelectedItem != null))
                {
                    Klant geselecteerdeKlant = (Klant)lstKlanten.SelectedItem;
                    txtNaam.Text = geselecteerdeKlant.Naam;
                    txtAdres.Text = geselecteerdeKlant.Adres;
                    txtTelefoonnummer.Text = geselecteerdeKlant.Telefoonnummer;
                    txtEmail.Text = geselecteerdeKlant.Email;
                    txtTotaalSaldo.Text = geselecteerdeKlant.TotaalSaldoVerkoop.ToString();
                }
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
    }
}
