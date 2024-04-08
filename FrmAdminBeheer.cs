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
    public partial class FrmAdminBeheer : Form
    {
        private Form1 frm1Instance;
        FrmAdminAfdelingAanmaken afdelingAanmakenScherm;
        FrmAdminMedewerkersAanmaken medewerkersAanmakenScherm;
        FrmAdminMedewerkersBewerken medewerkersBewerkenScherm;
        FrmAdminGegevensVerwijderen gegevensVerwijderenScherm;

        public FrmAdminBeheer(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }
        public List<GebruikersRol> LijstGebruikersrollenAdminBeheer
        {
            get { return frm1Instance.LijstGebruikersrollen; }
            set { frm1Instance.LijstGebruikersrollen = value; }
        }
        public List<Gebruiker> LijstGebruikersAdminBeheer
        {
            get { return frm1Instance.LijstGebruikers; }
            set { frm1Instance.LijstGebruikers = value; }
        }
        public List<Afdeling> LijstAfdelingenAdminBeheer
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }
        public List<GebruikerPlus> LijstGebruikersPlusAdminBeheer
        {
            get { return frm1Instance.LijstGebruikersPlus; }
            set { frm1Instance.LijstGebruikersPlus = value; }
        }
        public GebruikerPlus IngelogdeGebruikerAdminBeheer
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmAdminBeheer_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void btnAfdelingAanmaken_Click(object sender, EventArgs e)
        {

            if (afdelingAanmakenScherm == null)
            {
                afdelingAanmakenScherm = new FrmAdminAfdelingAanmaken(frm1Instance);
                afdelingAanmakenScherm.FormClosed += AfdelingAanmakenScherm_FormClosed;
                afdelingAanmakenScherm.MdiParent = this.MdiParent;
                afdelingAanmakenScherm.Show();
                afdelingAanmakenScherm.WindowState = FormWindowState.Minimized;
                afdelingAanmakenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                afdelingAanmakenScherm.Activate();
            }
        }
        private void btnMedewerkersAanmaken_Click(object sender, EventArgs e)
        {
            if (medewerkersAanmakenScherm == null)
            {
                medewerkersAanmakenScherm = new FrmAdminMedewerkersAanmaken(frm1Instance);
                medewerkersAanmakenScherm.LijstGebruikersrollenAdminMedewerkerAanmaken = frm1Instance.LijstGebruikersrollen;
                medewerkersAanmakenScherm.LijstGebruikersAdminMedewerkerAanmaken = frm1Instance.LijstGebruikers;
                medewerkersAanmakenScherm.LijstAfdelingenAdminMedewerkerAanmaken = frm1Instance.LijstAfdelingen;
                medewerkersAanmakenScherm.LijstGebruikersPlusAdminMedewerkerAanmaken = frm1Instance.LijstGebruikersPlus;
                medewerkersAanmakenScherm.IngelogdeGebruikerAdminMedewerkerAanmaken = frm1Instance.IngelogdeGebruiker;
                medewerkersAanmakenScherm.FormClosed += (s, args) => this.Show();
                medewerkersAanmakenScherm.FormClosed += MedewerkersAanmakenScherm_FormClosed;
                medewerkersAanmakenScherm.MdiParent = this.MdiParent;
                medewerkersAanmakenScherm.Show();
                medewerkersAanmakenScherm.WindowState = FormWindowState.Minimized;
                medewerkersAanmakenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                medewerkersAanmakenScherm.Activate();
            }
        }
        private void btnMedewerkersBewerken_Click(object sender, EventArgs e)
        {
            if (medewerkersBewerkenScherm == null)
            {
                medewerkersBewerkenScherm = new FrmAdminMedewerkersBewerken(frm1Instance);
                medewerkersBewerkenScherm.LijstGebruikersrollenAdminMedewerkerBewerken = frm1Instance.LijstGebruikersrollen;
                medewerkersBewerkenScherm.LijstGebruikersAdminMedewerkerBewerken = frm1Instance.LijstGebruikers;
                medewerkersBewerkenScherm.LijstAfdelingenAdminMedewerkerBewerken = frm1Instance.LijstAfdelingen;
                medewerkersBewerkenScherm.LijstGebruikersPlusAdminMedewerkerBewerken = frm1Instance.LijstGebruikersPlus;
                medewerkersBewerkenScherm.IngelogdeGebruikerAdminMedewerkerBewerken = frm1Instance.IngelogdeGebruiker;
                medewerkersBewerkenScherm.FormClosed += (s, args) => this.Show();
                medewerkersBewerkenScherm.FormClosed += MedewerkersBewerkenScherm_FormClosed;
                medewerkersBewerkenScherm.MdiParent = this.MdiParent;
                medewerkersBewerkenScherm.Show();
                medewerkersBewerkenScherm.WindowState = FormWindowState.Minimized;
                medewerkersBewerkenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                medewerkersBewerkenScherm.Activate();
            }

        }
        private void btnGegevensVerwijderen_Click(object sender, EventArgs e)
        {
            if (gegevensVerwijderenScherm == null)
            {
                gegevensVerwijderenScherm = new FrmAdminGegevensVerwijderen(frm1Instance);
                gegevensVerwijderenScherm.LijstGebruikersrollenAdminGegevensVerwijderen = frm1Instance.LijstGebruikersrollen;
                gegevensVerwijderenScherm.LijstGebruikersAdminGegevensVerwijderen = frm1Instance.LijstGebruikers;
                gegevensVerwijderenScherm.LijstAfdelingenAdminGegevensVerwijderen = frm1Instance.LijstAfdelingen;
                gegevensVerwijderenScherm.LijstGebruikersPlusAdminGegevensVerwijderen = frm1Instance.LijstGebruikersPlus;
                gegevensVerwijderenScherm.IngelogdeGebruikerAdminGegevensVerwijderen = frm1Instance.IngelogdeGebruiker;
                gegevensVerwijderenScherm.FormClosed += (s, args) => this.Show();
                gegevensVerwijderenScherm.FormClosed += GegevensVerwijderenScherm_FormClosed;
                gegevensVerwijderenScherm.MdiParent = this.MdiParent;
                gegevensVerwijderenScherm.Show();
                gegevensVerwijderenScherm.WindowState = FormWindowState.Minimized;
                gegevensVerwijderenScherm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                gegevensVerwijderenScherm.Activate();
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void AfdelingAanmakenScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            afdelingAanmakenScherm = null;
        }
        private void MedewerkersAanmakenScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            medewerkersAanmakenScherm = null;
        }
        private void MedewerkersBewerkenScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            medewerkersBewerkenScherm = null;
        }
        private void GegevensVerwijderenScherm_FormClosed(object sender, FormClosedEventArgs e)
        {
            gegevensVerwijderenScherm = null;
        }
    }
}
