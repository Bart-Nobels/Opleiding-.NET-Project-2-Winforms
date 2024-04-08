using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2__Bart_
{
    public partial class FrmOverzichtAankoop : Form
    {
        private Form1 frm1Instance;

        public FrmOverzichtAankoop(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusAankoopOverzicht
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Leverancier> LijstLeveranciersAankoopOverzicht
        {
            get { return frm1Instance.LijstLeveranciers; }
            set { frm1Instance.LijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikelsAankoopOverzicht
        {
            get { return frm1Instance.LijstAankoopArtikels; }
            set { frm1Instance.LijstAankoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturenAankoopOverzicht
        {
            get { return frm1Instance.LijstAankoopFacturen; }
            set { frm1Instance.LijstAankoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAankoopOverzicht
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void btnTerugOverzichtAankoop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnWeergevenOverzichtAankoop_Click(object sender, EventArgs e)
        {
            if (rdoArtikelsInStock.Checked)
            {
                txtWeergave.Text = "Artikelnaam" + "Aantal in stock".PadLeft(40) + "Aankoopprijs".PadLeft(40) + "Plaats in warenhuis".PadLeft(40) + "Datum aankoop".PadLeft(40) + Environment.NewLine + Environment.NewLine;
                foreach (var artikel in LijstAankoopArtikelsAankoopOverzicht)
                {
                    txtWeergave.Text += artikel.Naam + artikel.AantalInStock.ToString().PadLeft(40) + Convert.ToString(artikel.Aankoopprijs).PadLeft(40) + artikel.PlaatsInWarenhuis.PadLeft(40) + artikel.Datum.ToString().PadLeft(40) + Environment.NewLine;
                }

            }

            else if (rdoLeveranciers.Checked)
            {
                txtWeergave.Text = "Naam" + "Adres".PadLeft(40) + "Telefoonnummer".PadLeft(40) + "E-mailadres".PadLeft(40) + "Totaal Saldo".PadLeft(40) + Environment.NewLine + Environment.NewLine;
                foreach (var leverancier in LijstLeveranciersAankoopOverzicht)
                {
                    txtWeergave.Text += leverancier.Naam + leverancier.Adres.PadLeft(40) + leverancier.Telefoonnummer.PadLeft(40) + leverancier.Email.PadLeft(40) + Convert.ToString(leverancier.TotaalSaldoAankoop).PadLeft(40) + Environment.NewLine;
                }
            }

            else if (rdoAankoopFacturen.Checked)
            {
                txtWeergave.Text = "Datum" + "Werknemer".PadLeft(40) + "Klant".PadLeft(40) + "Artikelnaam".PadLeft(40) + "Aankoopprijs per stuk".PadLeft(40) + "Bedrag Factuur".PadLeft(40) + Environment.NewLine + Environment.NewLine;
                foreach (var factuur in LijstAankoopFacturenAankoopOverzicht)
                {
                    txtWeergave.Text += factuur.Datum + factuur.DezeGebruikerPlus.Voornaam.PadLeft(40) + " " + factuur.DezeGebruikerPlus.Naam + factuur.EenLeverancier.Naam.PadLeft(40); //ingelogde gebruiker moet gebruikerPLUS zijn
                    foreach (AankoopArtikel artikel in factuur.LijstAankoopArtikels)
                    {
                        txtWeergave.Text += artikel.Naam.PadLeft(40) + artikel.Aankoopprijs.ToString().PadLeft(40) + "€ ".PadLeft(40) + (artikel.Aankoopprijs * artikel.AantalInStock);
                    }
                    txtWeergave.Text += Environment.NewLine;
                }
            }
        }
        private void txtWeergave_TextChanged(object sender, EventArgs e)
        {

        }
        private void FrmOverzichtAankoop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
