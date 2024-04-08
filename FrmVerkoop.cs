using Project_2__Bart_.Kassa;
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
    public partial class FrmVerkoop : Form
    {
        private Form1 frm1Instance;
        FrmVerkoopOverzicht verkoopOverzichtScherm;
        FrmVerkoopKassa verkoopKassa;
        FrmKlantenBeheer verkoopKlantenbeheer;

        public FrmVerkoop(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikerPlus> LijstGebruikersPlusVerkoop
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Klant> LijstKlantenVerkoop
        {
            get { return frm1Instance.LijstKlanten; }
            set { frm1Instance.LijstKlanten = value; }
        }
        public List<VerkoopArtikel> LijstVerkoopArtikelsVerkoop
        {
            get { return frm1Instance.LijstVerkoopArtikels; }
            set { frm1Instance.LijstVerkoopArtikels = value; }
        }
        public List<VerkoopFactuur> LijstVerkoopFacturenVerkoop
        {
            get { return frm1Instance.LijstVerkoopFacturen; }
            set { frm1Instance.LijstVerkoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerVerkoop
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void BtnOverzichtVerkoop_Click(object sender, EventArgs e)
        {

            if (verkoopOverzichtScherm == null)
            {
                verkoopOverzichtScherm = new FrmVerkoopOverzicht(frm1Instance);
                verkoopOverzichtScherm.LijstGebruikersPlusVerkoopOverzicht = frm1Instance.LijstGebruikersPlus;
                verkoopOverzichtScherm.LijstKlantenVerkoopOverzicht = frm1Instance.LijstKlanten;
                verkoopOverzichtScherm.LijstVerkoopArtikelsVerkoopOverzicht = frm1Instance.LijstVerkoopArtikels;
                verkoopOverzichtScherm.LijstVerkoopFacturenVerkoopOverzicht = frm1Instance.LijstVerkoopFacturen;
                verkoopOverzichtScherm.IngelogdeGebruikerVerkoopOverzicht = frm1Instance.IngelogdeGebruiker;
                verkoopOverzichtScherm.FormClosed += (s, args) => this.Show();
                verkoopOverzichtScherm.FormClosed += VerkoopOverzichtScherm_FormClosed;
                verkoopOverzichtScherm.MdiParent = this.MdiParent;
                verkoopOverzichtScherm.Show();
                verkoopOverzichtScherm.WindowState = FormWindowState.Minimized;
                verkoopOverzichtScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                verkoopOverzichtScherm.WindowState = FormWindowState.Normal;
            }

        }
        private void btnKassa_Click(object sender, EventArgs e)
        {
            FrmVerkoopKassa verkoopKassa = new FrmVerkoopKassa(frm1Instance);
            verkoopKassa.LijstGebruikersPlusVerkoopKassa = frm1Instance.LijstGebruikersPlus;
            verkoopKassa.LijstKlantenVerkoopKassa = frm1Instance.LijstKlanten;
            verkoopKassa.LijstVerkoopArtikelsVerkoopKassa = frm1Instance.LijstVerkoopArtikels;
            verkoopKassa.LijstVerkoopFacturenVerkoopKassa = frm1Instance.LijstVerkoopFacturen;
            verkoopKassa.IngelogdeGebruikerVerkoopKassa = frm1Instance.IngelogdeGebruiker;
            verkoopKassa.FormClosed += (s, args) => this.Show();
            verkoopKassa.WindowState = FormWindowState.Minimized;
            verkoopKassa.WindowState = FormWindowState.Maximized;
            verkoopKassa.ShowDialog();
        }
        private void btnKlantenbeheer_Click(object sender, EventArgs e)
        {
           if(verkoopKlantenbeheer == null)
            {
            verkoopKlantenbeheer = new FrmKlantenBeheer(frm1Instance);
                verkoopKlantenbeheer.FormClosed += (s, args) => this.Show();
                verkoopKlantenbeheer.FormClosed += VerkoopKlantenbeheer_FormClosed;
                verkoopKlantenbeheer.MdiParent = this.MdiParent;
                verkoopKlantenbeheer.Show();
                verkoopKlantenbeheer.WindowState = FormWindowState.Minimized;
                verkoopKlantenbeheer.WindowState = FormWindowState.Maximized;   
            }
     
        }
        private void btnTerugVerkoop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FrmVerkoop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void VerkoopOverzichtScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            verkoopOverzichtScherm = null;
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void VerkoopKlantenbeheer_FormClosed(object sender, FormClosedEventArgs e)
        {
            verkoopKlantenbeheer = null;    
        }
    }
}
