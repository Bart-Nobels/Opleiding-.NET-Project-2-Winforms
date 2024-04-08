namespace Project_2__Bart_
{
    partial class FrmAdminMedewerkersBewerken
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBewerken = new Button();
            groupBox2 = new GroupBox();
            lstAfdelingen = new ListBox();
            label2 = new Label();
            nudTellerPaswoord = new NumericUpDown();
            label6 = new Label();
            txtLoonGebruiker = new TextBox();
            label5 = new Label();
            txtRekeningnummerGebruiker = new TextBox();
            label4 = new Label();
            txtTelefoonnummerGebruiker = new TextBox();
            label3 = new Label();
            txtAdresGebruiker = new TextBox();
            txtNaamGebruiker = new TextBox();
            label12 = new Label();
            txtVoornaamGebruiker = new TextBox();
            label11 = new Label();
            txtGebruikersnaamGebruiker = new TextBox();
            label10 = new Label();
            txtPaswoordGebruiker = new TextBox();
            label9 = new Label();
            cmbGebruikersrol = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            cbJSONEncrypteren = new CheckBox();
            cbJSONLezen = new CheckBox();
            cbJSONAanmaken = new CheckBox();
            cbJSONBewerken = new CheckBox();
            cbTXTEncrypteren = new CheckBox();
            cbTXTLezen = new CheckBox();
            cbTXTAanmaken = new CheckBox();
            cbTXTBewerken = new CheckBox();
            cbXMLEncrypteren = new CheckBox();
            cbXMLLezen = new CheckBox();
            cbXMLAanmaken = new CheckBox();
            cbXMLBewerken = new CheckBox();
            lstMedewerkers = new ListBox();
            btnTerug = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTellerPaswoord).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBewerken
            // 
            btnBewerken.Location = new Point(1069, 635);
            btnBewerken.Name = "btnBewerken";
            btnBewerken.Size = new Size(129, 57);
            btnBewerken.TabIndex = 27;
            btnBewerken.Text = "Bewerken";
            btnBewerken.UseVisualStyleBackColor = true;
            btnBewerken.Click += btnBewerken_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstAfdelingen);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(nudTellerPaswoord);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtLoonGebruiker);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtRekeningnummerGebruiker);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTelefoonnummerGebruiker);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtAdresGebruiker);
            groupBox2.Controls.Add(txtNaamGebruiker);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtVoornaamGebruiker);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtGebruikersnaamGebruiker);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtPaswoordGebruiker);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbGebruikersrol);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(683, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 589);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medewerkersgegevens:";
            // 
            // lstAfdelingen
            // 
            lstAfdelingen.FormattingEnabled = true;
            lstAfdelingen.ItemHeight = 20;
            lstAfdelingen.Location = new Point(165, 392);
            lstAfdelingen.Name = "lstAfdelingen";
            lstAfdelingen.SelectionMode = SelectionMode.MultiExtended;
            lstAfdelingen.Size = new Size(351, 184);
            lstAfdelingen.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 39);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 28;
            label2.Text = "Gebruikersrol:";
            // 
            // nudTellerPaswoord
            // 
            nudTellerPaswoord.Location = new Point(165, 333);
            nudTellerPaswoord.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudTellerPaswoord.Name = "nudTellerPaswoord";
            nudTellerPaswoord.Size = new Size(351, 27);
            nudTellerPaswoord.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 171);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 32;
            label6.Text = "Paswoord:";
            // 
            // txtLoonGebruiker
            // 
            txtLoonGebruiker.Location = new Point(165, 300);
            txtLoonGebruiker.Name = "txtLoonGebruiker";
            txtLoonGebruiker.Size = new Size(351, 27);
            txtLoonGebruiker.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 139);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 31;
            label5.Text = "Gebruikersnaam:";
            // 
            // txtRekeningnummerGebruiker
            // 
            txtRekeningnummerGebruiker.Location = new Point(165, 267);
            txtRekeningnummerGebruiker.Name = "txtRekeningnummerGebruiker";
            txtRekeningnummerGebruiker.Size = new Size(351, 27);
            txtRekeningnummerGebruiker.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 105);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 30;
            label4.Text = "Voornaam:";
            // 
            // txtTelefoonnummerGebruiker
            // 
            txtTelefoonnummerGebruiker.Location = new Point(165, 235);
            txtTelefoonnummerGebruiker.Name = "txtTelefoonnummerGebruiker";
            txtTelefoonnummerGebruiker.Size = new Size(351, 27);
            txtTelefoonnummerGebruiker.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 72);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 29;
            label3.Text = "Naam:";
            // 
            // txtAdresGebruiker
            // 
            txtAdresGebruiker.Location = new Point(165, 201);
            txtAdresGebruiker.Name = "txtAdresGebruiker";
            txtAdresGebruiker.Size = new Size(351, 27);
            txtAdresGebruiker.TabIndex = 37;
            // 
            // txtNaamGebruiker
            // 
            txtNaamGebruiker.Location = new Point(165, 69);
            txtNaamGebruiker.Name = "txtNaamGebruiker";
            txtNaamGebruiker.Size = new Size(351, 27);
            txtNaamGebruiker.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 383);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 43;
            label12.Text = "Afdeling:";
            // 
            // txtVoornaamGebruiker
            // 
            txtVoornaamGebruiker.Location = new Point(165, 101);
            txtVoornaamGebruiker.Name = "txtVoornaamGebruiker";
            txtVoornaamGebruiker.Size = new Size(351, 27);
            txtVoornaamGebruiker.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 335);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 42;
            label11.Text = "Teller paswoord:";
            // 
            // txtGebruikersnaamGebruiker
            // 
            txtGebruikersnaamGebruiker.Location = new Point(165, 135);
            txtGebruikersnaamGebruiker.Name = "txtGebruikersnaamGebruiker";
            txtGebruikersnaamGebruiker.Size = new Size(351, 27);
            txtGebruikersnaamGebruiker.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 303);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 41;
            label10.Text = "Loon:";
            // 
            // txtPaswoordGebruiker
            // 
            txtPaswoordGebruiker.Location = new Point(165, 168);
            txtPaswoordGebruiker.Name = "txtPaswoordGebruiker";
            txtPaswoordGebruiker.Size = new Size(351, 27);
            txtPaswoordGebruiker.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 269);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 40;
            label9.Text = "Rekeningnummer:";
            // 
            // cmbGebruikersrol
            // 
            cmbGebruikersrol.FormattingEnabled = true;
            cmbGebruikersrol.Location = new Point(165, 36);
            cmbGebruikersrol.Name = "cmbGebruikersrol";
            cmbGebruikersrol.Size = new Size(351, 28);
            cmbGebruikersrol.TabIndex = 32;
            cmbGebruikersrol.SelectedIndexChanged += cmbGebruikersrol_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 237);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 39;
            label8.Text = "Telefoonnummer:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 204);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 38;
            label7.Text = "Adres:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbJSONEncrypteren);
            groupBox1.Controls.Add(cbJSONLezen);
            groupBox1.Controls.Add(cbJSONAanmaken);
            groupBox1.Controls.Add(cbJSONBewerken);
            groupBox1.Controls.Add(cbTXTEncrypteren);
            groupBox1.Controls.Add(cbTXTLezen);
            groupBox1.Controls.Add(cbTXTAanmaken);
            groupBox1.Controls.Add(cbTXTBewerken);
            groupBox1.Controls.Add(cbXMLEncrypteren);
            groupBox1.Controls.Add(cbXMLLezen);
            groupBox1.Controls.Add(cbXMLAanmaken);
            groupBox1.Controls.Add(cbXMLBewerken);
            groupBox1.Location = new Point(217, 445);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 247);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gebruikersrechten:";
            // 
            // cbJSONEncrypteren
            // 
            cbJSONEncrypteren.AutoSize = true;
            cbJSONEncrypteren.Location = new Point(241, 191);
            cbJSONEncrypteren.Name = "cbJSONEncrypteren";
            cbJSONEncrypteren.Size = new Size(177, 24);
            cbJSONEncrypteren.TabIndex = 17;
            cbJSONEncrypteren.Text = "Kan JSON Encrypteren";
            cbJSONEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbJSONLezen
            // 
            cbJSONLezen.AutoSize = true;
            cbJSONLezen.Location = new Point(241, 161);
            cbJSONLezen.Name = "cbJSONLezen";
            cbJSONLezen.Size = new Size(137, 24);
            cbJSONLezen.TabIndex = 16;
            cbJSONLezen.Text = "Kan JSON Lezen";
            cbJSONLezen.UseVisualStyleBackColor = true;
            // 
            // cbJSONAanmaken
            // 
            cbJSONAanmaken.AutoSize = true;
            cbJSONAanmaken.Location = new Point(241, 131);
            cbJSONAanmaken.Name = "cbJSONAanmaken";
            cbJSONAanmaken.Size = new Size(169, 24);
            cbJSONAanmaken.TabIndex = 15;
            cbJSONAanmaken.Text = "Kan JSON Aanmaken";
            cbJSONAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbJSONBewerken
            // 
            cbJSONBewerken.AutoSize = true;
            cbJSONBewerken.Location = new Point(241, 101);
            cbJSONBewerken.Name = "cbJSONBewerken";
            cbJSONBewerken.Size = new Size(163, 24);
            cbJSONBewerken.TabIndex = 14;
            cbJSONBewerken.Text = "Kan JSON Bewerken";
            cbJSONBewerken.UseVisualStyleBackColor = true;
            // 
            // cbTXTEncrypteren
            // 
            cbTXTEncrypteren.AutoSize = true;
            cbTXTEncrypteren.Location = new Point(241, 71);
            cbTXTEncrypteren.Name = "cbTXTEncrypteren";
            cbTXTEncrypteren.Size = new Size(167, 24);
            cbTXTEncrypteren.TabIndex = 13;
            cbTXTEncrypteren.Text = "Kan TXT Encrypteren";
            cbTXTEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbTXTLezen
            // 
            cbTXTLezen.AutoSize = true;
            cbTXTLezen.Location = new Point(241, 41);
            cbTXTLezen.Name = "cbTXTLezen";
            cbTXTLezen.Size = new Size(127, 24);
            cbTXTLezen.TabIndex = 12;
            cbTXTLezen.Text = "Kan TXT Lezen";
            cbTXTLezen.UseVisualStyleBackColor = true;
            // 
            // cbTXTAanmaken
            // 
            cbTXTAanmaken.AutoSize = true;
            cbTXTAanmaken.Location = new Point(17, 191);
            cbTXTAanmaken.Name = "cbTXTAanmaken";
            cbTXTAanmaken.Size = new Size(159, 24);
            cbTXTAanmaken.TabIndex = 11;
            cbTXTAanmaken.Text = "Kan TXT Aanmaken";
            cbTXTAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbTXTBewerken
            // 
            cbTXTBewerken.AutoSize = true;
            cbTXTBewerken.Location = new Point(17, 161);
            cbTXTBewerken.Name = "cbTXTBewerken";
            cbTXTBewerken.Size = new Size(153, 24);
            cbTXTBewerken.TabIndex = 10;
            cbTXTBewerken.Text = "Kan TXT Bewerken";
            cbTXTBewerken.UseVisualStyleBackColor = true;
            // 
            // cbXMLEncrypteren
            // 
            cbXMLEncrypteren.AutoSize = true;
            cbXMLEncrypteren.Location = new Point(17, 131);
            cbXMLEncrypteren.Name = "cbXMLEncrypteren";
            cbXMLEncrypteren.Size = new Size(171, 24);
            cbXMLEncrypteren.TabIndex = 9;
            cbXMLEncrypteren.Text = "Kan XML Encrypteren";
            cbXMLEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbXMLLezen
            // 
            cbXMLLezen.AutoSize = true;
            cbXMLLezen.Location = new Point(17, 101);
            cbXMLLezen.Name = "cbXMLLezen";
            cbXMLLezen.Size = new Size(131, 24);
            cbXMLLezen.TabIndex = 8;
            cbXMLLezen.Text = "Kan XML Lezen";
            cbXMLLezen.UseVisualStyleBackColor = true;
            // 
            // cbXMLAanmaken
            // 
            cbXMLAanmaken.AutoSize = true;
            cbXMLAanmaken.Location = new Point(17, 71);
            cbXMLAanmaken.Name = "cbXMLAanmaken";
            cbXMLAanmaken.Size = new Size(163, 24);
            cbXMLAanmaken.TabIndex = 7;
            cbXMLAanmaken.Text = "Kan XML Aanmaken";
            cbXMLAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbXMLBewerken
            // 
            cbXMLBewerken.AutoSize = true;
            cbXMLBewerken.Location = new Point(17, 41);
            cbXMLBewerken.Name = "cbXMLBewerken";
            cbXMLBewerken.Size = new Size(157, 24);
            cbXMLBewerken.TabIndex = 6;
            cbXMLBewerken.Text = "Kan XML Bewerken";
            cbXMLBewerken.UseVisualStyleBackColor = true;
            // 
            // lstMedewerkers
            // 
            lstMedewerkers.FormattingEnabled = true;
            lstMedewerkers.ItemHeight = 20;
            lstMedewerkers.Location = new Point(217, 12);
            lstMedewerkers.Name = "lstMedewerkers";
            lstMedewerkers.Size = new Size(427, 364);
            lstMedewerkers.TabIndex = 24;
            lstMedewerkers.SelectedIndexChanged += lstMedewerkers_SelectedIndexChanged;
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(11, 655);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(129, 57);
            btnTerug.TabIndex = 23;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // FrmAdminMedewerkersBewerken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 724);
            Controls.Add(btnBewerken);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstMedewerkers);
            Controls.Add(btnTerug);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdminMedewerkersBewerken";
            Text = "Medewerkers Bewerken - Admin";
            Load += FrmAdminMedewerkersBewerken_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTellerPaswoord).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBewerken;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private CheckBox cbJSONEncrypteren;
        private CheckBox cbJSONLezen;
        private CheckBox cbJSONAanmaken;
        private CheckBox cbJSONBewerken;
        private CheckBox cbTXTEncrypteren;
        private CheckBox cbTXTLezen;
        private CheckBox cbTXTAanmaken;
        private CheckBox cbTXTBewerken;
        private CheckBox cbXMLEncrypteren;
        private CheckBox cbXMLLezen;
        private CheckBox cbXMLAanmaken;
        private CheckBox cbXMLBewerken;
        private ListBox lstMedewerkers;
        private Button btnTerug;
        private ListBox lstAfdelingen;
        private Label label2;
        private NumericUpDown nudTellerPaswoord;
        private Label label6;
        private TextBox txtLoonGebruiker;
        private Label label5;
        private TextBox txtRekeningnummerGebruiker;
        private Label label4;
        private TextBox txtTelefoonnummerGebruiker;
        private Label label3;
        private TextBox txtAdresGebruiker;
        private TextBox txtNaamGebruiker;
        private Label label12;
        private TextBox txtVoornaamGebruiker;
        private Label label11;
        private TextBox txtGebruikersnaamGebruiker;
        private Label label10;
        private TextBox txtPaswoordGebruiker;
        private Label label9;
        private ComboBox cmbGebruikersrol;
        private Label label8;
        private Label label7;
    }
}