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
    public partial class FrmManagerBerichtAanAdmin : Form
    {
        private DialogResult antwoordMessageBox;

        public FrmManagerBerichtAanAdmin()
        {
            InitializeComponent();
        }

        private void FrmManagerBerichtAanAdmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void btnVerzenden_Click(object sender, EventArgs e)
        {
            string directory = Environment.CurrentDirectory + @"\BerichtenAdmin";
            string pad = Environment.CurrentDirectory + @"\BerichtenAdmin\" + txtBestandsnaam.Text + ".txt";
            try
            {
                if (!string.IsNullOrEmpty(txtBericht.Text))
                {
                    if (!string.IsNullOrEmpty(txtBestandsnaam.Text))
                    {
                        antwoordMessageBox = MessageBox.Show("Bent u zeker dat u dit bericht wil verzenden?", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (antwoordMessageBox == DialogResult.Yes)
                        {
                            if (!Directory.Exists(directory))               //maakt nieuwe map aan als deze nog niet bestaat
                            {
                                Directory.CreateDirectory(directory);
                            }
                            if (!System.IO.File.Exists(pad))                //schrijft het bericht (txt bestand) weg in de juiste map
                            {
                                using StreamWriter mijnWriter = new StreamWriter(pad);
                                mijnWriter.WriteLine(txtBericht.Text + Environment.NewLine);
                                MessageBox.Show("Het bericht '" + txtBestandsnaam.Text + "' werd verzonden.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TXTLeegmaken();
                            }
                            else
                            {
                                MessageBox.Show("Er bestaat reeds een bericht met deze naam. Gelieve een andere naam te kiezen aub.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtBestandsnaam.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Het bericht werd NIET verzonden.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gelieve de bestandsnaam in te vullen.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("U kan geen leeg bericht verzenden.", "Mededeling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het verzenden van het bericht", ex.GetType().ToString());
            }
        }
        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void TXTLeegmaken()
        {
            txtBericht.Text = string.Empty;
            txtBestandsnaam.Text = string.Empty;
        }
    }
}
