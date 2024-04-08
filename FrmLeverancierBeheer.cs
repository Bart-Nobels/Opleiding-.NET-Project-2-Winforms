namespace Project_2__Bart_
{
    public partial class FrmLeverancierBeheer : Form
    {
        private Form1 frm1Instance;

        public FrmLeverancierBeheer(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
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
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                Leverancier geselecteerdeLeverancier = (Leverancier)lstLeveranciers.SelectedItem;
                frm1Instance.LijstLeveranciers.Remove(geselecteerdeLeverancier);
                MessageBox.Show("De leverancier werd succesvol verwijderd.","Melding",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lstLeveranciers.DataSource = null;
                lstLeveranciers.DisplayMember = "Naam";
                lstLeveranciers.DataSource = frm1Instance.LijstLeveranciers;
                frm1Instance.LeveranciersSchrijven();
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
                Leverancier geselecteerdeLeverancier = (Leverancier)lstLeveranciers.SelectedItem;
                geselecteerdeLeverancier.Naam = txtNaam.Text;
                geselecteerdeLeverancier.Adres = txtAdres.Text;
                geselecteerdeLeverancier.Telefoonnummer = txtTelefoonnummer.Text;
                geselecteerdeLeverancier.Email = txtEmail.Text;

                List<Leverancier> updatedList = new List<Leverancier>();
                foreach (var leverancier in frm1Instance.LijstLeveranciers)
                {
                    if (leverancier.Guid == geselecteerdeLeverancier.Guid)
                    {
                        updatedList.Add(geselecteerdeLeverancier);
                    }
                    else
                    {
                        updatedList.Add(leverancier);
                    }
                }
                frm1Instance.LijstLeveranciers = updatedList;
                MessageBox.Show("De leverancier werd succesvol bewerkt.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstLeveranciers.DataSource = null;
                var sortedList = frm1Instance.LijstLeveranciers.OrderBy(leverancier => leverancier.Naam).ToList();
                lstLeveranciers.DataSource = sortedList;
                lstLeveranciers.DisplayMember = "Naam";
                frm1Instance.LeveranciersSchrijven();
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
                if (((Leverancier)lstLeveranciers.SelectedItem != null))
                {
                    Leverancier geselecteerdeLeverancier = (Leverancier)lstLeveranciers.SelectedItem;
                    txtNaam.Text = geselecteerdeLeverancier.Naam;
                    txtAdres.Text = geselecteerdeLeverancier.Adres;
                    txtTelefoonnummer.Text = geselecteerdeLeverancier.Telefoonnummer;
                    txtEmail.Text = geselecteerdeLeverancier.Email;
                    txtTotaalSaldo.Text = geselecteerdeLeverancier.TotaalSaldoAankoop.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
        //private void FrmLeverancierBeheer_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var sortedList = frm1Instance.LijstLeveranciers.OrderBy(leverancier => leverancier.Naam).ToList();
        //        lstLeveranciers.DataSource = sortedList;
        //        lstLeveranciers.DisplayMember = "Naam";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Onbekende fout!");
        //    }
        //}
        private void FrmLeverancierBeheer_Load_1(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                var sortedList = frm1Instance.LijstLeveranciers.OrderBy(leverancier => leverancier.Naam).ToList();
                lstLeveranciers.DataSource = sortedList;
                lstLeveranciers.DisplayMember = "Naam";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Onbekende fout!");
            }
        }
    }
}
