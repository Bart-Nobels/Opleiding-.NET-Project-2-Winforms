using System.IO;

namespace Project_2__Bart_
{
    public partial class FrmVerslagen : Form
    {
        private Form1 frm1Instance;
        private string huidigeDirectory;
        private string nieuweDirectory;
        private string selectedFilePath;
        private string naamBestand;
        private string pad;
        private string naamMap;
        private string inhoud;
        private string filePathHuidigDocument;
        private DialogResult antwoordMessageBox;

        public FrmVerslagen(Form1 frm1)
        {
            InitializeComponent();
            frm1Instance = frm1;
        }

        public GebruikerPlus IngelogdeGebruikerVerslagen
        {
            get { return frm1Instance.IngelogdeGebruiker; }
            set { frm1Instance.IngelogdeGebruiker = value; }
        }

        private void FrmVerslagen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            huidigeDirectory = Environment.CurrentDirectory + @"\Verslagen";
            try
            {
                if (!Directory.Exists(huidigeDirectory))
                {
                    Directory.CreateDirectory(huidigeDirectory);
                }
                if (IngelogdeGebruikerVerslagen.GebruikersRol.Naam.ToUpper() != "ADMIN" && IngelogdeGebruikerVerslagen.GebruikersRol.Naam.ToUpper() != "ADMINISTRATOR")
                {
                    if (IngelogdeGebruikerVerslagen.LijstAfdelingen != null && IngelogdeGebruikerVerslagen.LijstAfdelingen.Any())
                    {
                        foreach (Afdeling a in IngelogdeGebruikerVerslagen.LijstAfdelingen)
                        {
                            cmbAfdelingen.Items.Add(a.Naam);
                        }
                    }
                }
                else
                {
                    if (frm1Instance.LijstAfdelingen != null && frm1Instance.LijstAfdelingen.Any())
                    {
                        foreach (Afdeling a in frm1Instance.LijstAfdelingen)
                        {
                            cmbAfdelingen.Items.Add(a.Naam);
                        }
                    }
                }
                CheckKanTXTAanmaken();
                CheckKanTXTLezen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het inladen van afdelingen in de combobox.", ex.GetType().ToString());
            }
        }
        private void btnVerslagZoeken_Click_1(object sender, EventArgs e)
        {
            if (Directory.Exists(huidigeDirectory))
            {
                try
                {
                    FormulierLeegmaken();

                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = huidigeDirectory;
                        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        openFileDialog.FilterIndex = 1;
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            selectedFilePath = openFileDialog.FileName;
                            filePathHuidigDocument = selectedFilePath;  //Bart: is nodig om te weten in welk document we aan het werken zijn!
                            txtBestandsnaam.Text = Path.GetFileName(selectedFilePath);

                            inhoud = File.ReadAllText(selectedFilePath);
                            txtVerslag.Text = inhoud;

                            if (IngelogdeGebruikerVerslagen.GebruikersRol.Naam.ToUpper() == "MANAGER")
                            {
                                if (CheckAfdeling(selectedFilePath) == false && IngelogdeGebruikerVerslagen.GebruikersRol.KanBewerkenTxt == false)
                                {
                                    txtVerslag.Enabled = false;
                                    btnOpslaan.Enabled = false;
                                }
                                txtBestandsnaam.Enabled = false;
                                cmbAfdelingen.Enabled = false;
                            }
                            else if (IngelogdeGebruikerVerslagen.GebruikersRol.Naam.ToUpper() == "WERKNEMER" && CheckAfdeling(selectedFilePath) == true)
                            {
                                if (CheckGuid(selectedFilePath) == false && IngelogdeGebruikerVerslagen.GebruikersRol.KanBewerkenTxt == false)
                                {
                                    txtVerslag.Enabled = false;
                                    btnOpslaan.Enabled = false;
                                }
                                txtBestandsnaam.Enabled = false;
                                cmbAfdelingen.Enabled = false;
                            }
                            else if (IngelogdeGebruikerVerslagen.GebruikersRol.Naam.ToUpper() == "ADMIN" || IngelogdeGebruikerVerslagen.GebruikersRol.Naam.ToUpper() == "ADMINISTRATOR")
                            {
                                txtBestandsnaam.Enabled = false;
                                cmbAfdelingen.Enabled = false;
                            }
                            else
                            {
                                FormulierLeegmaken();
                                CheckKanTXTAanmaken();
                                CheckKanTXTLezen();
                                MessageBox.Show("U heeft niet de juiste rechten om dit bestand te openen.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er is een fout opgetreden bij het zoeken naar een document.", ex.GetType().ToString());
                }
            }
            else
            {
                MessageBox.Show("De map met documenten kon niet gevonden worden.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVerslag.Text))
            {
                if (!string.IsNullOrEmpty(txtBestandsnaam.Text))
                {
                    try
                    {
                        if (txtBestandsnaam.Enabled == true)
                        {
                            if (cmbAfdelingen.SelectedIndex != -1)
                            {
                                antwoordMessageBox = MessageBox.Show("Bent u zeker dat u het document wil opslaan?", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (antwoordMessageBox == DialogResult.Yes)
                                {
                                    naamMap = cmbAfdelingen.SelectedItem.ToString();
                                    nieuweDirectory = Environment.CurrentDirectory + @"\Verslagen\" + naamMap;
                                    naamBestand = txtBestandsnaam.Text + "_" + cmbAfdelingen.SelectedItem.ToString() + "_" + IngelogdeGebruikerVerslagen.Guid + ".txt";
                                    pad = Path.Combine(nieuweDirectory, naamBestand);
                                    filePathHuidigDocument = pad;  //Bart: is nodig om te weten in welk document we aan het werken zijn!

                                    if (!Directory.Exists(nieuweDirectory))
                                    {
                                        Directory.CreateDirectory(nieuweDirectory);
                                    }
                                    if (File.Exists(pad))
                                    {
                                        MessageBox.Show("Er bestaat al een bestand met deze naam. Gelieve een andere naam te kiezen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        txtBestandsnaam.Text = string.Empty;
                                    }
                                    else
                                    {
                                        File.WriteAllText(pad, txtVerslag.Text);

                                        txtBestandsnaam.Enabled = false;
                                        cmbAfdelingen.Enabled = false;

                                        MessageBox.Show("Het document werd opgeslagen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Het document werd NIET opgeslagen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Gelieve eerst een afdeling te selecteren. Uw document zal in de map van die afdeling opgeslagen worden.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            antwoordMessageBox = MessageBox.Show("Bent u zeker dat u het document wil opslaan?" + Environment.NewLine + "Het bestaande document wordt overschreven!", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (antwoordMessageBox == DialogResult.Yes)
                            {
                                File.WriteAllText(filePathHuidigDocument, txtVerslag.Text); //Bart: schrijft de gegevens weg van het huidige document waar we in werken als dit geen nieuw document is.

                                txtBestandsnaam.Enabled = false;
                                cmbAfdelingen.Enabled = false;

                                MessageBox.Show("Het document werd opgeslagen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Het document werd NIET opgeslagen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Er is een fout opgetreden bij het opslaan.", ex.GetType().ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Gelieve eerst een bestandsnaam in te vullen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("U kan geen leeg document opslaan.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnFormulierLeegmaken_Click(object sender, EventArgs e)
        {
            try
            {
                antwoordMessageBox = MessageBox.Show("Bent u zeker dat u het formulier wil leegmaken?" + Environment.NewLine + "De niet opgeslagen gegevens gaan verloren!", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (antwoordMessageBox == DialogResult.Yes)
                {
                    FormulierLeegmaken();
                    CheckKanTXTAanmaken();
                    CheckKanTXTLezen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het leegmaken van het formulier.", ex.GetType().ToString());
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool CheckGuid(string filePath)
        {
            string naamFileZonderExtentie = Path.GetFileNameWithoutExtension(filePath);
            bool guidGelijk = false;

            if (naamFileZonderExtentie.Contains(IngelogdeGebruikerVerslagen.Guid.ToString()))
            {
                guidGelijk = true;
            }
            return guidGelijk;
        }
        private bool CheckAfdeling(string filePath)
        {
            string naamFileZonderExtentie = Path.GetFileNameWithoutExtension(filePath);
            bool afdelingGelijk = false;

            foreach (Afdeling a in IngelogdeGebruikerVerslagen.LijstAfdelingen)
            {
                if (naamFileZonderExtentie.Contains(a.Naam))
                {
                    afdelingGelijk = true;
                    break;
                }
            }
            return afdelingGelijk;
        }
        private void FormulierLeegmaken()
        {
            txtVerslag.Text = string.Empty;
            txtBestandsnaam.Text = string.Empty;

            txtVerslag.Enabled = true;
            txtBestandsnaam.Enabled = true;
            btnOpslaan.Enabled = true;
            btnVerslagZoeken.Enabled = true;
            cmbAfdelingen.Enabled = true;
        }
        private void CheckKanTXTLezen()
        {
            if (IngelogdeGebruikerVerslagen.GebruikersRol.KanLezenTxt == false)
            {
                btnVerslagZoeken.Enabled = false;
            }
        }
        private void CheckKanTXTAanmaken()
        {
            if (IngelogdeGebruikerVerslagen.GebruikersRol.KanAanmakenTxt == false)
            {
                txtVerslag.Enabled = false;
                btnOpslaan.Enabled = false;
                txtBestandsnaam.Enabled = false;
                cmbAfdelingen.Enabled = false;
            }
        }
    }
}

