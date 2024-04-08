using System.Xml;

namespace Project_2__Bart_
{
    public partial class FrmAdminAfdelingAanmaken : Form
    {
        private Form1 frm1Instance;

        public FrmAdminAfdelingAanmaken(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }
        public List<Afdeling> LijstAfdelingenAdminAfdelingAanmaken
        {
            get { return frm1Instance.LijstAfdelingen; }
            set { frm1Instance.LijstAfdelingen = value; }
        }

        private void FrmAdminAfdelingAanmaken_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNaamAfdeling.Text))
                {
                    Afdeling eenAfdeling = new Afdeling(txtNaamAfdeling.Text, txtOmschrijving.Text);
                    LijstAfdelingenAdminAfdelingAanmaken.Add(eenAfdeling);
                    MessageBox.Show("Afdeling: " + "'" + txtNaamAfdeling.Text + "'" + " werd succesvol toegevoegd.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AfdelingenSchrijven();
                    TXTLeegmaken();
                }
                else
                {
                    MessageBox.Show("Gelieve eerst de naam van de afdeling in te vullen aub.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets foutgelopen bij het aanmaken van de afdeling.", ex.GetType().ToString());
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void TXTLeegmaken()
        {
            txtNaamAfdeling.Text = string.Empty;
            txtOmschrijving.Text = string.Empty;
        }
        private void AfdelingenSchrijven()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlElement mainRoot = xmlDoc.CreateElement("Afdelingen");
            xmlDoc.AppendChild(mainRoot);

            foreach (Afdeling dezeAfdeling in LijstAfdelingenAdminAfdelingAanmaken)
            {
                XmlElement root = xmlDoc.CreateElement("Afdeling");
                mainRoot.AppendChild(root);

                XmlElement afdelingsNaam = xmlDoc.CreateElement("Naam");
                afdelingsNaam.InnerText = dezeAfdeling.Naam;
                root.AppendChild(afdelingsNaam);

                XmlElement afdelingsID = xmlDoc.CreateElement("ID");
                afdelingsID.InnerText = dezeAfdeling.Guid.ToString();
                root.AppendChild(afdelingsID);

                XmlElement afdelingOmschrijving = xmlDoc.CreateElement("Omschrijving");
                afdelingOmschrijving.InnerText = dezeAfdeling.Omschrijving;
                root.AppendChild(afdelingOmschrijving);
            }
            xmlDoc.Save("Afdelingen.xml");
        }
    }
}
