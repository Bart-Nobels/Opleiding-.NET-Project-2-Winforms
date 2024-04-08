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
    public partial class FrmVerkoopOverzicht : Form
    {
        private Form1 frm1Instance;

        public FrmVerkoopOverzicht(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusVerkoopOverzicht
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Klant> LijstKlantenVerkoopOverzicht
        {
            get { return frm1Instance.LijstKlanten; }
            set { frm1Instance.LijstKlanten = value; }
        }
        public List<VerkoopArtikel> LijstVerkoopArtikelsVerkoopOverzicht
        {
            get { return frm1Instance.LijstVerkoopArtikels; }
            set { frm1Instance.LijstVerkoopArtikels = value; }
        }
        public List<VerkoopFactuur> LijstVerkoopFacturenVerkoopOverzicht
        {
            get { return frm1Instance.LijstVerkoopFacturen; }
            set { frm1Instance.LijstVerkoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerVerkoopOverzicht
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnWeergeven_Click(object sender, EventArgs e)
        {
            if (rdoArtikelsInStock.Checked)
            {
                txtWeergave.Text = "Artikelnaam" + "Aantal in stock".PadLeft(40) + "Verkoopprijs".PadLeft(40) + Environment.NewLine + Environment.NewLine;
                foreach (var artikel in LijstVerkoopArtikelsVerkoopOverzicht)
                {
                    txtWeergave.Text += artikel.Naam + artikel.AantalInStock.ToString().PadLeft(40) + Convert.ToString(artikel.Verkoopprijs).PadLeft(40) + Convert.ToString(artikel.Minimumvoorraadniveau).PadLeft(40) + Environment.NewLine;
                }

            }

            else if (rdoKlanten.Checked)
            {
                txtWeergave.Text = "Naam" + "Adres".PadLeft(40) + "Telefoonnummer".PadLeft(40) + "E-mailadres".PadLeft(40) + "Totaal Saldo".PadLeft(40) + Environment.NewLine + Environment.NewLine;
                foreach (var klant in LijstKlantenVerkoopOverzicht)
                {
                    txtWeergave.Text += klant.Naam + klant.Adres.PadLeft(40) + klant.Telefoonnummer.PadLeft(40) + klant.Email.PadLeft(40) + Convert.ToString(klant.TotaalSaldoVerkoop).PadLeft(40) + Environment.NewLine;
                }
            }

            else if (rdoVerkoopFacturen.Checked)
            {
                txtWeergave.Text = "Datum" + "Werknemer".PadLeft(40) + "Klant".PadLeft(40) + "Artikelnaam".PadLeft(40) + "Verkoopprijs".PadLeft(40) + Environment.NewLine + Environment.NewLine;
                foreach (var factuur in LijstVerkoopFacturenVerkoopOverzicht)
                {
                    txtWeergave.Text += factuur.Datum + factuur.DezeGebruikerPlus.Voornaam.PadLeft(40) + " " + factuur.DezeGebruikerPlus.Naam + factuur.EenKlant.Naam.PadLeft(40);
                    foreach (VerkoopArtikel artikel in factuur.LijstVerkoopArtikels)
                    {
                        txtWeergave.Text += (artikel.Naam).PadLeft(40) + artikel.Verkoopprijs.ToString().PadLeft(40);
                    }
                    txtWeergave.Text += Environment.NewLine;
                }
            }
        }
        private void FrmVerkoopOverzicht_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
