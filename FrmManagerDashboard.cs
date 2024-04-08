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
    public partial class FrmManagerDashboard : Form
    {
        private Form1 frm1Instance;
        FrmVerkoop verkoopScherm;
        FrmAankoop aankoopScherm;
        FrmVerslagen verslagenScherm;
        FrmManagerBerichtAanAdmin managerBerichtAanAdminScherm;
        FrmManagerWerknemersBewerken managerWerknemersBewerkenScherm;
        FrmPrijszetting managerPrijszettingScherm;

        public FrmManagerDashboard(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public List<GebruikersRol> LijstGebruikersrollenManager
        {
            get { return frm1Instance.LijstGebruikersrollen; }
            set { frm1Instance.LijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikersManager
        {
            get { return frm1Instance.LijstGebruikers; }
            set { frm1Instance.LijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingenManager
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlusManager
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public List<Klant> LijstKlantenManager
        {
            get { return frm1Instance.LijstKlanten; }
            set { frm1Instance.LijstKlanten = value; }
        }
        public List<Leverancier> LijstLeveranciersManager
        {
            get { return frm1Instance.LijstLeveranciers; }
            set { frm1Instance.LijstLeveranciers = value; }
        }
        public List<AankoopArtikel> LijstAankoopArtikelsManager
        {
            get { return frm1Instance.LijstAankoopArtikels; }
            set { frm1Instance.LijstAankoopArtikels = value; }
        }
        public List<VerkoopArtikel> LijstVerkoopArtikelsManager
        {
            get { return frm1Instance.LijstVerkoopArtikels; }
            set { frm1Instance.LijstVerkoopArtikels = value; }
        }
        public List<AankoopFactuur> LijstAankoopFacturenManager
        {
            get { return frm1Instance.LijstAankoopFacturen; }
            set { frm1Instance.LijstAankoopFacturen = value; }
        }
        public List<VerkoopFactuur> LijstVerkoopFacturenManager
        {
            get { return frm1Instance.LijstVerkoopFacturen; }
            set { frm1Instance.LijstVerkoopFacturen = value; }
        }
        public GebruikerPlus IngelogdeGebruikerManager
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmManagerDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                bool verkoopGevonden = false;
                bool aankoopGevonden = false;
                foreach (var afdeling in IngelogdeGebruikerManager.LijstAfdelingen)
                {
                    if (afdeling.Naam.ToUpper() == "VERKOOP")
                    {
                        verkoopGevonden = true;
                    }
                    if (afdeling.Naam.ToUpper() == "AANKOOP")
                    {
                        aankoopGevonden = true;
                    }
                }
                if (verkoopGevonden == false)
                {
                    btnVerkoop.Enabled = false;
                }
                if (aankoopGevonden == false)
                {
                    btnAankoop.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets misgelopen bij het vrijgeven van de buttons.", ex.GetType().ToString());
            }
        }
        private void BtnPersoonlijkeInfo_Click(object sender, EventArgs e)
        {
            try
            {
                GebruikerPlus eenGebruikerPlus = new GebruikerPlus();
                MessageBox.Show(eenGebruikerPlus.PersoonlijkeInfo(LijstGebruikersPlusManager, IngelogdeGebruikerManager));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets misgelopen bij het laden van de persoonlijke info", ex.GetType().ToString());
            }
        }
        private void btnVerkoop_Click(object sender, EventArgs e)
        {
            if (verkoopScherm == null)
            {
                verkoopScherm = new FrmVerkoop(frm1Instance);
                verkoopScherm.FormClosed += Verkoop_FormClosed;
                verkoopScherm.MdiParent = this;
                verkoopScherm.LijstGebruikersPlusVerkoop = frm1Instance.LijstGebruikersPlus;
                verkoopScherm.LijstKlantenVerkoop = frm1Instance.LijstKlanten;
                verkoopScherm.LijstVerkoopArtikelsVerkoop = frm1Instance.LijstVerkoopArtikels;
                verkoopScherm.LijstVerkoopFacturenVerkoop = frm1Instance.LijstVerkoopFacturen;
                verkoopScherm.IngelogdeGebruikerVerkoop = frm1Instance.IngelogdeGebruiker;
                verkoopScherm.Show();
                verkoopScherm.WindowState = FormWindowState.Minimized;
                verkoopScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                verkoopScherm.Activate();
            }
        }
        private void btnAankoop_Click(object sender, EventArgs e)
        {
            if (aankoopScherm == null)
            {
                aankoopScherm = new FrmAankoop(frm1Instance);
                aankoopScherm.FormClosed += Aankoop_FormClosed;
                aankoopScherm.MdiParent = this;
                aankoopScherm.LijstGebruikersPlusAankoop = frm1Instance.LijstGebruikersPlus;
                aankoopScherm.LijstLeveranciersAankoop = frm1Instance.LijstLeveranciers;
                aankoopScherm.LijstAankoopArtikelsAankoop = frm1Instance.LijstAankoopArtikels;
                aankoopScherm.LijstAankoopFacturenAankoop = frm1Instance.LijstAankoopFacturen;
                aankoopScherm.IngelogdeGebruikerAankoop = frm1Instance.IngelogdeGebruiker;
                aankoopScherm.Show();
                aankoopScherm.WindowState = FormWindowState.Minimized;
                aankoopScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                aankoopScherm.Activate();
            }
        }
        private void btnVerslagen_Click(object sender, EventArgs e)
        {
            if (verslagenScherm == null)
            {
                verslagenScherm = new FrmVerslagen(frm1Instance);
                verslagenScherm.FormClosed += Verslagen_FormClosed;
                verslagenScherm.MdiParent = this;
                verslagenScherm.Show();
                verslagenScherm.WindowState = FormWindowState.Minimized;
                verslagenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                verslagenScherm.Activate();
            }

        }
        private void btnBerichtAanAdmin_Click(object sender, EventArgs e)
        {
            if (managerBerichtAanAdminScherm == null)
            {
                managerBerichtAanAdminScherm = new FrmManagerBerichtAanAdmin();
                managerBerichtAanAdminScherm.FormClosed += BerichtAanAdmin_FormClosed;
                managerBerichtAanAdminScherm.MdiParent = this;
                managerBerichtAanAdminScherm.Show();
                managerBerichtAanAdminScherm.WindowState = FormWindowState.Minimized;
                managerBerichtAanAdminScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                managerBerichtAanAdminScherm.Activate();
            }
        }
        private void btnWerknemersBewerken_Click(object sender, EventArgs e)
        {
            if (managerWerknemersBewerkenScherm == null)
            {
                managerWerknemersBewerkenScherm = new FrmManagerWerknemersBewerken(frm1Instance);
                managerWerknemersBewerkenScherm.LijstGebruikersPlusManagerBewerken = frm1Instance.LijstGebruikersPlus;
                managerWerknemersBewerkenScherm.IngelogdeGebruikerManagerBewerken = frm1Instance.IngelogdeGebruiker;
                managerWerknemersBewerkenScherm.FormClosed += WerknemersBewerken_FormClosed;
                managerWerknemersBewerkenScherm.MdiParent = this;
                managerWerknemersBewerkenScherm.Show();
                managerWerknemersBewerkenScherm.WindowState = FormWindowState.Minimized;
                managerWerknemersBewerkenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                managerWerknemersBewerkenScherm.Activate();
            }

        }
        private void btnPrijszetting_Click(object sender, EventArgs e)
        {
            if (managerPrijszettingScherm == null)
            {
                managerPrijszettingScherm = new FrmPrijszetting(frm1Instance);
                managerPrijszettingScherm.FormClosed += Prijszetting_FormClosed;
                managerPrijszettingScherm.MdiParent = this;
                managerPrijszettingScherm.Show();
                managerPrijszettingScherm.WindowState = FormWindowState.Minimized;
                managerPrijszettingScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                managerPrijszettingScherm.Activate();
            }
        }
        private void btnAfmelden_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void btnMinimize_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        //private void btnMaximize_Click(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //    }

        //}
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
        private void Verkoop_FormClosed(object sender, FormClosedEventArgs e)
        {
            verkoopScherm = null;
        }
        private void Aankoop_FormClosed(object sender, FormClosedEventArgs e)
        {
            aankoopScherm = null;
        }
        private void Verslagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            verslagenScherm = null;
        }
        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BerichtAanAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            managerBerichtAanAdminScherm = null;
        }
        private void WerknemersBewerken_FormClosed(object sender, FormClosedEventArgs e)
        {
            managerWerknemersBewerkenScherm = null;
        }
        private void Prijszetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            managerPrijszettingScherm = null;   
        }
    }
}
