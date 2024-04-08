namespace Project_2__Bart_
{
    partial class FrmAdminMedewerkersAanmaken
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
            btnTerug = new Button();
            groupBox2 = new GroupBox();
            lstAfdelingen = new ListBox();
            nudTellerPaswoord = new NumericUpDown();
            txtLoonGebruiker = new TextBox();
            txtRekeningnummerGebruiker = new TextBox();
            txtTelefoonnummerGebruiker = new TextBox();
            txtAdresGebruiker = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnGebruikerAanmaken = new Button();
            cmbGebruikersrol = new ComboBox();
            txtPaswoordGebruiker = new TextBox();
            txtGebruikersnaamGebruiker = new TextBox();
            txtVoornaamGebruiker = new TextBox();
            txtNaamGebruiker = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            cbJSONEncrypteren = new CheckBox();
            cbJSONLezen = new CheckBox();
            cbJSONAanmaken = new CheckBox();
            cbJSONBewerken = new CheckBox();
            cbTXTEncrypteren = new CheckBox();
            cbTXTLezen = new CheckBox();
            cbTXTAanmaken = new CheckBox();
            btnUncheckAll = new Button();
            cbTXTBewerken = new CheckBox();
            btnCheckAll = new Button();
            cbXMLEncrypteren = new CheckBox();
            btnAanmaken = new Button();
            cbXMLLezen = new CheckBox();
            txtNaam = new TextBox();
            cbXMLAanmaken = new CheckBox();
            label1 = new Label();
            cbXMLBewerken = new CheckBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTellerPaswoord).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(32, 656);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(129, 57);
            btnTerug.TabIndex = 42;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstAfdelingen);
            groupBox2.Controls.Add(nudTellerPaswoord);
            groupBox2.Controls.Add(txtLoonGebruiker);
            groupBox2.Controls.Add(txtRekeningnummerGebruiker);
            groupBox2.Controls.Add(txtTelefoonnummerGebruiker);
            groupBox2.Controls.Add(txtAdresGebruiker);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnGebruikerAanmaken);
            groupBox2.Controls.Add(cmbGebruikersrol);
            groupBox2.Controls.Add(txtPaswoordGebruiker);
            groupBox2.Controls.Add(txtGebruikersnaamGebruiker);
            groupBox2.Controls.Add(txtVoornaamGebruiker);
            groupBox2.Controls.Add(txtNaamGebruiker);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(566, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 680);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gebruiker aanmaken:";
            // 
            // lstAfdelingen
            // 
            lstAfdelingen.FormattingEnabled = true;
            lstAfdelingen.ItemHeight = 20;
            lstAfdelingen.Location = new Point(171, 399);
            lstAfdelingen.Name = "lstAfdelingen";
            lstAfdelingen.SelectionMode = SelectionMode.MultiExtended;
            lstAfdelingen.Size = new Size(283, 184);
            lstAfdelingen.TabIndex = 15;
            // 
            // nudTellerPaswoord
            // 
            nudTellerPaswoord.Location = new Point(171, 340);
            nudTellerPaswoord.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudTellerPaswoord.Name = "nudTellerPaswoord";
            nudTellerPaswoord.Size = new Size(283, 27);
            nudTellerPaswoord.TabIndex = 14;
            // 
            // txtLoonGebruiker
            // 
            txtLoonGebruiker.Location = new Point(171, 307);
            txtLoonGebruiker.Name = "txtLoonGebruiker";
            txtLoonGebruiker.Size = new Size(283, 27);
            txtLoonGebruiker.TabIndex = 13;
            // 
            // txtRekeningnummerGebruiker
            // 
            txtRekeningnummerGebruiker.Location = new Point(171, 275);
            txtRekeningnummerGebruiker.Name = "txtRekeningnummerGebruiker";
            txtRekeningnummerGebruiker.Size = new Size(283, 27);
            txtRekeningnummerGebruiker.TabIndex = 12;
            // 
            // txtTelefoonnummerGebruiker
            // 
            txtTelefoonnummerGebruiker.Location = new Point(171, 241);
            txtTelefoonnummerGebruiker.Name = "txtTelefoonnummerGebruiker";
            txtTelefoonnummerGebruiker.Size = new Size(283, 27);
            txtTelefoonnummerGebruiker.TabIndex = 11;
            // 
            // txtAdresGebruiker
            // 
            txtAdresGebruiker.Location = new Point(171, 208);
            txtAdresGebruiker.Name = "txtAdresGebruiker";
            txtAdresGebruiker.Size = new Size(283, 27);
            txtAdresGebruiker.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 389);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 41;
            label12.Text = "Afdeling:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 341);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 40;
            label11.Text = "Teller paswoord:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 309);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 39;
            label10.Text = "Loon:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 277);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 38;
            label9.Text = "Rekeningnummer:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 244);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 37;
            label8.Text = "Telefoonnummer:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 211);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 36;
            label7.Text = "Adres:";
            // 
            // btnGebruikerAanmaken
            // 
            btnGebruikerAanmaken.Location = new Point(339, 631);
            btnGebruikerAanmaken.Name = "btnGebruikerAanmaken";
            btnGebruikerAanmaken.Size = new Size(115, 40);
            btnGebruikerAanmaken.TabIndex = 16;
            btnGebruikerAanmaken.Text = "Aanmaken";
            btnGebruikerAanmaken.UseVisualStyleBackColor = true;
            btnGebruikerAanmaken.Click += btnGebruikerAanmaken_Click;
            // 
            // cmbGebruikersrol
            // 
            cmbGebruikersrol.FormattingEnabled = true;
            cmbGebruikersrol.Location = new Point(171, 43);
            cmbGebruikersrol.Name = "cmbGebruikersrol";
            cmbGebruikersrol.Size = new Size(283, 28);
            cmbGebruikersrol.TabIndex = 5;
            // 
            // txtPaswoordGebruiker
            // 
            txtPaswoordGebruiker.Location = new Point(171, 175);
            txtPaswoordGebruiker.Name = "txtPaswoordGebruiker";
            txtPaswoordGebruiker.Size = new Size(283, 27);
            txtPaswoordGebruiker.TabIndex = 9;
            // 
            // txtGebruikersnaamGebruiker
            // 
            txtGebruikersnaamGebruiker.Location = new Point(171, 141);
            txtGebruikersnaamGebruiker.Name = "txtGebruikersnaamGebruiker";
            txtGebruikersnaamGebruiker.Size = new Size(283, 27);
            txtGebruikersnaamGebruiker.TabIndex = 8;
            // 
            // txtVoornaamGebruiker
            // 
            txtVoornaamGebruiker.Location = new Point(171, 109);
            txtVoornaamGebruiker.Name = "txtVoornaamGebruiker";
            txtVoornaamGebruiker.Size = new Size(283, 27);
            txtVoornaamGebruiker.TabIndex = 7;
            // 
            // txtNaamGebruiker
            // 
            txtNaamGebruiker.Location = new Point(171, 76);
            txtNaamGebruiker.Name = "txtNaamGebruiker";
            txtNaamGebruiker.Size = new Size(283, 27);
            txtNaamGebruiker.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 45);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 31;
            label2.Text = "Gebruikersrol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 79);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 32;
            label3.Text = "Naam:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 112);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 33;
            label4.Text = "Voornaam:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 145);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 34;
            label5.Text = "Gebruikersnaam:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 179);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 35;
            label6.Text = "Paswoord:";
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
            groupBox1.Controls.Add(btnUncheckAll);
            groupBox1.Controls.Add(cbTXTBewerken);
            groupBox1.Controls.Add(btnCheckAll);
            groupBox1.Controls.Add(cbXMLEncrypteren);
            groupBox1.Controls.Add(btnAanmaken);
            groupBox1.Controls.Add(cbXMLLezen);
            groupBox1.Controls.Add(txtNaam);
            groupBox1.Controls.Add(cbXMLAanmaken);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbXMLBewerken);
            groupBox1.Location = new Point(218, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 589);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gebruikersrol aanmaken:";
            // 
            // cbJSONEncrypteren
            // 
            cbJSONEncrypteren.AutoSize = true;
            cbJSONEncrypteren.Location = new Point(22, 540);
            cbJSONEncrypteren.Name = "cbJSONEncrypteren";
            cbJSONEncrypteren.Size = new Size(177, 24);
            cbJSONEncrypteren.TabIndex = 28;
            cbJSONEncrypteren.Text = "Kan JSON Encrypteren";
            cbJSONEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbJSONLezen
            // 
            cbJSONLezen.AutoSize = true;
            cbJSONLezen.Location = new Point(22, 509);
            cbJSONLezen.Name = "cbJSONLezen";
            cbJSONLezen.Size = new Size(137, 24);
            cbJSONLezen.TabIndex = 27;
            cbJSONLezen.Text = "Kan JSON Lezen";
            cbJSONLezen.UseVisualStyleBackColor = true;
            // 
            // cbJSONAanmaken
            // 
            cbJSONAanmaken.AutoSize = true;
            cbJSONAanmaken.Location = new Point(22, 480);
            cbJSONAanmaken.Name = "cbJSONAanmaken";
            cbJSONAanmaken.Size = new Size(169, 24);
            cbJSONAanmaken.TabIndex = 26;
            cbJSONAanmaken.Text = "Kan JSON Aanmaken";
            cbJSONAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbJSONBewerken
            // 
            cbJSONBewerken.AutoSize = true;
            cbJSONBewerken.Location = new Point(22, 451);
            cbJSONBewerken.Name = "cbJSONBewerken";
            cbJSONBewerken.Size = new Size(163, 24);
            cbJSONBewerken.TabIndex = 25;
            cbJSONBewerken.Text = "Kan JSON Bewerken";
            cbJSONBewerken.UseVisualStyleBackColor = true;
            // 
            // cbTXTEncrypteren
            // 
            cbTXTEncrypteren.AutoSize = true;
            cbTXTEncrypteren.Location = new Point(22, 420);
            cbTXTEncrypteren.Name = "cbTXTEncrypteren";
            cbTXTEncrypteren.Size = new Size(167, 24);
            cbTXTEncrypteren.TabIndex = 24;
            cbTXTEncrypteren.Text = "Kan TXT Encrypteren";
            cbTXTEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbTXTLezen
            // 
            cbTXTLezen.AutoSize = true;
            cbTXTLezen.Location = new Point(22, 389);
            cbTXTLezen.Name = "cbTXTLezen";
            cbTXTLezen.Size = new Size(127, 24);
            cbTXTLezen.TabIndex = 23;
            cbTXTLezen.Text = "Kan TXT Lezen";
            cbTXTLezen.UseVisualStyleBackColor = true;
            // 
            // cbTXTAanmaken
            // 
            cbTXTAanmaken.AutoSize = true;
            cbTXTAanmaken.Location = new Point(22, 360);
            cbTXTAanmaken.Name = "cbTXTAanmaken";
            cbTXTAanmaken.Size = new Size(159, 24);
            cbTXTAanmaken.TabIndex = 22;
            cbTXTAanmaken.Text = "Kan TXT Aanmaken";
            cbTXTAanmaken.UseVisualStyleBackColor = true;
            // 
            // btnUncheckAll
            // 
            btnUncheckAll.Location = new Point(232, 147);
            btnUncheckAll.Name = "btnUncheckAll";
            btnUncheckAll.Size = new Size(94, 29);
            btnUncheckAll.TabIndex = 4;
            btnUncheckAll.Text = "Uncheck All";
            btnUncheckAll.UseVisualStyleBackColor = true;
            btnUncheckAll.Click += btnUncheckAll_Click;
            // 
            // cbTXTBewerken
            // 
            cbTXTBewerken.AutoSize = true;
            cbTXTBewerken.Location = new Point(22, 331);
            cbTXTBewerken.Name = "cbTXTBewerken";
            cbTXTBewerken.Size = new Size(153, 24);
            cbTXTBewerken.TabIndex = 21;
            cbTXTBewerken.Text = "Kan TXT Bewerken";
            cbTXTBewerken.UseVisualStyleBackColor = true;
            // 
            // btnCheckAll
            // 
            btnCheckAll.Location = new Point(232, 111);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(94, 29);
            btnCheckAll.TabIndex = 3;
            btnCheckAll.Text = "Check All";
            btnCheckAll.UseVisualStyleBackColor = true;
            btnCheckAll.Click += btnCheckAll_Click;
            // 
            // cbXMLEncrypteren
            // 
            cbXMLEncrypteren.AutoSize = true;
            cbXMLEncrypteren.Location = new Point(22, 300);
            cbXMLEncrypteren.Name = "cbXMLEncrypteren";
            cbXMLEncrypteren.Size = new Size(171, 24);
            cbXMLEncrypteren.TabIndex = 20;
            cbXMLEncrypteren.Text = "Kan XML Encrypteren";
            cbXMLEncrypteren.UseVisualStyleBackColor = true;
            // 
            // btnAanmaken
            // 
            btnAanmaken.Location = new Point(232, 73);
            btnAanmaken.Name = "btnAanmaken";
            btnAanmaken.Size = new Size(94, 29);
            btnAanmaken.TabIndex = 2;
            btnAanmaken.Text = "Aanmaken";
            btnAanmaken.UseVisualStyleBackColor = true;
            btnAanmaken.Click += btnAanmaken_Click;
            // 
            // cbXMLLezen
            // 
            cbXMLLezen.AutoSize = true;
            cbXMLLezen.Location = new Point(22, 269);
            cbXMLLezen.Name = "cbXMLLezen";
            cbXMLLezen.Size = new Size(131, 24);
            cbXMLLezen.TabIndex = 19;
            cbXMLLezen.Text = "Kan XML Lezen";
            cbXMLLezen.UseVisualStyleBackColor = true;
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(24, 73);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(187, 27);
            txtNaam.TabIndex = 1;
            // 
            // cbXMLAanmaken
            // 
            cbXMLAanmaken.AutoSize = true;
            cbXMLAanmaken.Location = new Point(22, 240);
            cbXMLAanmaken.Name = "cbXMLAanmaken";
            cbXMLAanmaken.Size = new Size(163, 24);
            cbXMLAanmaken.TabIndex = 18;
            cbXMLAanmaken.Text = "Kan XML Aanmaken";
            cbXMLAanmaken.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Naam gebruikersrol:";
            // 
            // cbXMLBewerken
            // 
            cbXMLBewerken.AutoSize = true;
            cbXMLBewerken.Location = new Point(22, 211);
            cbXMLBewerken.Name = "cbXMLBewerken";
            cbXMLBewerken.Size = new Size(157, 24);
            cbXMLBewerken.TabIndex = 17;
            cbXMLBewerken.Text = "Kan XML Bewerken";
            cbXMLBewerken.UseVisualStyleBackColor = true;
            // 
            // FrmAdminMedewerkersAanmaken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 733);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnTerug);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdminMedewerkersAanmaken";
            Text = "Medewerkers Aanmaken - Admin";
            Load += FrmAdminMedewerkersAanmaken_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTellerPaswoord).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTerug;
        private GroupBox groupBox2;
        private TextBox txtLoonGebruiker;
        private TextBox txtRekeningnummerGebruiker;
        private TextBox txtTelefoonnummerGebruiker;
        private TextBox txtAdresGebruiker;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnGebruikerAanmaken;
        private ComboBox cmbGebruikersrol;
        private TextBox txtPaswoordGebruiker;
        private TextBox txtGebruikersnaamGebruiker;
        private TextBox txtVoornaamGebruiker;
        private TextBox txtNaamGebruiker;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private CheckBox cbJSONEncrypteren;
        private CheckBox cbJSONLezen;
        private CheckBox cbJSONAanmaken;
        private CheckBox cbJSONBewerken;
        private CheckBox cbTXTEncrypteren;
        private CheckBox cbTXTLezen;
        private CheckBox cbTXTAanmaken;
        private Button btnUncheckAll;
        private CheckBox cbTXTBewerken;
        private Button btnCheckAll;
        private CheckBox cbXMLEncrypteren;
        private Button btnAanmaken;
        private CheckBox cbXMLLezen;
        private TextBox txtNaam;
        private CheckBox cbXMLAanmaken;
        private Label label1;
        private CheckBox cbXMLBewerken;
        private ListBox lstAfdelingen;
        private NumericUpDown nudTellerPaswoord;
    }
}