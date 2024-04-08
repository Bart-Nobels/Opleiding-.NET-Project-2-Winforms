namespace Project_2__Bart_
{
    public partial class FrmAdminToDoLijst : Form
    {
        string directory = Environment.CurrentDirectory + @"\BerichtenAdmin";
        string geselecteerdeBestand;
        string bestandPad;
        string geselecteerdeItem;
        string[] bestanden;
        string[] gesplitst;
        List<BestandInfo> listBestandenMetDatum = new List<BestandInfo>();

        public FrmAdminToDoLijst()
        {
            InitializeComponent();
        }

        private void FrmAdminToDoLijst_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            bestanden = Directory.GetFiles(directory);
            try
            {
                foreach (string bestand in bestanden)
                {
                    DateTime opmaakDatum = File.GetCreationTime(bestand);
                    listBestandenMetDatum.Add(new BestandInfo { Naam = Path.GetFileName(bestand), OpmaakDatum = opmaakDatum });
                }

                listBestandenMetDatum.Sort((a, b) => b.OpmaakDatum.CompareTo(a.OpmaakDatum)); //Bart: sorteren bestanden op datum

                foreach (BestandInfo bi in listBestandenMetDatum)
                {
                    lstOverzichtBerichten.Items.Add($"{bi.Naam} - {bi.OpmaakDatum}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het laden van de lijst met documenten.", ex.GetType().ToString());
            }
            
        }
        private void lstOverzichtBerichten_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstOverzichtBerichten.SelectedIndex != -1)
                {
                    if (lstOverzichtBerichten.SelectedIndex != -1)
                    {
                        geselecteerdeItem = lstOverzichtBerichten.SelectedItem.ToString();
                        gesplitst = geselecteerdeItem.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                        if (gesplitst.Length == 2)
                        {
                            geselecteerdeBestand = gesplitst[0];
                            string inhoud = File.ReadAllText(Path.Combine(directory, geselecteerdeBestand));
                            txtInhoudBericht.Text = inhoud;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het laden van een documenten.", ex.GetType().ToString());
            }
        }
        private void btnBerichtVerwijderen_Click(object sender, EventArgs e)
        {
            if (lstOverzichtBerichten.SelectedIndex != -1)
            {
                geselecteerdeItem = lstOverzichtBerichten.SelectedItem.ToString();
                gesplitst = geselecteerdeItem.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (gesplitst.Length == 2)
                {
                    geselecteerdeBestand = gesplitst[0];
                    bestandPad = Path.Combine(directory, geselecteerdeBestand);
                }
                try
                {
                    DialogResult antwoordMessageBox = MessageBox.Show("Bent u zeker dat u dit document wil verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (antwoordMessageBox == DialogResult.Yes)
                    {
                        File.Delete(bestandPad);
                        lstOverzichtBerichten.Items.RemoveAt(lstOverzichtBerichten.SelectedIndex);
                        txtInhoudBericht.Text = string.Empty;

                        MessageBox.Show("Document is succesvol verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Het document is NIET verwijderd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het verwijderen van het document.", ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("Gelieve eerst een document te selecteren aub.", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
