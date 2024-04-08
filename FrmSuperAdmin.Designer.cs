namespace Project_2__Bart_
{
    partial class FrmSuperAdmin
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
            groupBox2 = new GroupBox();
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
            btnAfsluiten = new Button();
            btnAdminBewerken = new Button();
            btnEncryptieBenodigdheden = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Location = new Point(43, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 576);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gebruikersrol aanmaken:";
            // 
            // cbJSONEncrypteren
            // 
            cbJSONEncrypteren.AutoSize = true;
            cbJSONEncrypteren.Location = new Point(22, 540);
            cbJSONEncrypteren.Name = "cbJSONEncrypteren";
            cbJSONEncrypteren.Size = new Size(177, 24);
            cbJSONEncrypteren.TabIndex = 23;
            cbJSONEncrypteren.Text = "Kan JSON Encrypteren";
            cbJSONEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbJSONLezen
            // 
            cbJSONLezen.AutoSize = true;
            cbJSONLezen.Location = new Point(22, 509);
            cbJSONLezen.Name = "cbJSONLezen";
            cbJSONLezen.Size = new Size(137, 24);
            cbJSONLezen.TabIndex = 22;
            cbJSONLezen.Text = "Kan JSON Lezen";
            cbJSONLezen.UseVisualStyleBackColor = true;
            // 
            // cbJSONAanmaken
            // 
            cbJSONAanmaken.AutoSize = true;
            cbJSONAanmaken.Location = new Point(22, 480);
            cbJSONAanmaken.Name = "cbJSONAanmaken";
            cbJSONAanmaken.Size = new Size(169, 24);
            cbJSONAanmaken.TabIndex = 21;
            cbJSONAanmaken.Text = "Kan JSON Aanmaken";
            cbJSONAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbJSONBewerken
            // 
            cbJSONBewerken.AutoSize = true;
            cbJSONBewerken.Location = new Point(22, 451);
            cbJSONBewerken.Name = "cbJSONBewerken";
            cbJSONBewerken.Size = new Size(163, 24);
            cbJSONBewerken.TabIndex = 20;
            cbJSONBewerken.Text = "Kan JSON Bewerken";
            cbJSONBewerken.UseVisualStyleBackColor = true;
            // 
            // cbTXTEncrypteren
            // 
            cbTXTEncrypteren.AutoSize = true;
            cbTXTEncrypteren.Location = new Point(22, 420);
            cbTXTEncrypteren.Name = "cbTXTEncrypteren";
            cbTXTEncrypteren.Size = new Size(167, 24);
            cbTXTEncrypteren.TabIndex = 19;
            cbTXTEncrypteren.Text = "Kan TXT Encrypteren";
            cbTXTEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbTXTLezen
            // 
            cbTXTLezen.AutoSize = true;
            cbTXTLezen.Location = new Point(22, 389);
            cbTXTLezen.Name = "cbTXTLezen";
            cbTXTLezen.Size = new Size(127, 24);
            cbTXTLezen.TabIndex = 18;
            cbTXTLezen.Text = "Kan TXT Lezen";
            cbTXTLezen.UseVisualStyleBackColor = true;
            // 
            // cbTXTAanmaken
            // 
            cbTXTAanmaken.AutoSize = true;
            cbTXTAanmaken.Location = new Point(22, 360);
            cbTXTAanmaken.Name = "cbTXTAanmaken";
            cbTXTAanmaken.Size = new Size(159, 24);
            cbTXTAanmaken.TabIndex = 17;
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
            cbTXTBewerken.TabIndex = 16;
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
            cbXMLEncrypteren.TabIndex = 15;
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
            cbXMLLezen.TabIndex = 14;
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
            cbXMLAanmaken.TabIndex = 13;
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
            cbXMLBewerken.TabIndex = 12;
            cbXMLBewerken.Text = "Kan XML Bewerken";
            cbXMLBewerken.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            groupBox2.Location = new Point(494, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 324);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gebruiker aanmaken:";
            // 
            // btnGebruikerAanmaken
            // 
            btnGebruikerAanmaken.Location = new Point(274, 253);
            btnGebruikerAanmaken.Name = "btnGebruikerAanmaken";
            btnGebruikerAanmaken.Size = new Size(115, 40);
            btnGebruikerAanmaken.TabIndex = 5;
            btnGebruikerAanmaken.Text = "Aanmaken";
            btnGebruikerAanmaken.UseVisualStyleBackColor = true;
            btnGebruikerAanmaken.Click += btnGebruikerAanmaken_Click;
            // 
            // cmbGebruikersrol
            // 
            cmbGebruikersrol.FormattingEnabled = true;
            cmbGebruikersrol.Location = new Point(171, 43);
            cmbGebruikersrol.Name = "cmbGebruikersrol";
            cmbGebruikersrol.Size = new Size(218, 28);
            cmbGebruikersrol.TabIndex = 10;
            // 
            // txtPaswoordGebruiker
            // 
            txtPaswoordGebruiker.Location = new Point(171, 175);
            txtPaswoordGebruiker.Name = "txtPaswoordGebruiker";
            txtPaswoordGebruiker.Size = new Size(218, 27);
            txtPaswoordGebruiker.TabIndex = 14;
            // 
            // txtGebruikersnaamGebruiker
            // 
            txtGebruikersnaamGebruiker.Location = new Point(171, 141);
            txtGebruikersnaamGebruiker.Name = "txtGebruikersnaamGebruiker";
            txtGebruikersnaamGebruiker.Size = new Size(218, 27);
            txtGebruikersnaamGebruiker.TabIndex = 13;
            // 
            // txtVoornaamGebruiker
            // 
            txtVoornaamGebruiker.Location = new Point(171, 109);
            txtVoornaamGebruiker.Name = "txtVoornaamGebruiker";
            txtVoornaamGebruiker.Size = new Size(218, 27);
            txtVoornaamGebruiker.TabIndex = 12;
            // 
            // txtNaamGebruiker
            // 
            txtNaamGebruiker.Location = new Point(171, 76);
            txtNaamGebruiker.Name = "txtNaamGebruiker";
            txtNaamGebruiker.Size = new Size(218, 27);
            txtNaamGebruiker.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 45);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Gebruikersrol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 79);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Naam:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 112);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Voornaam:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 145);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 4;
            label5.Text = "Gebruikersnaam:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 179);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "Paswoord:";
            // 
            // btnAfsluiten
            // 
            btnAfsluiten.Location = new Point(768, 648);
            btnAfsluiten.Name = "btnAfsluiten";
            btnAfsluiten.Size = new Size(137, 51);
            btnAfsluiten.TabIndex = 11;
            btnAfsluiten.Text = "Afsluiten";
            btnAfsluiten.UseVisualStyleBackColor = true;
            btnAfsluiten.Click += btnAfsluiten_Click;
            // 
            // btnAdminBewerken
            // 
            btnAdminBewerken.Location = new Point(43, 79);
            btnAdminBewerken.Name = "btnAdminBewerken";
            btnAdminBewerken.Size = new Size(137, 51);
            btnAdminBewerken.TabIndex = 12;
            btnAdminBewerken.Text = "Admin Bewerken";
            btnAdminBewerken.UseVisualStyleBackColor = true;
            btnAdminBewerken.Click += btnAdminBewerken_Click;
            // 
            // btnEncryptieBenodigdheden
            // 
            btnEncryptieBenodigdheden.Location = new Point(242, 79);
            btnEncryptieBenodigdheden.Name = "btnEncryptieBenodigdheden";
            btnEncryptieBenodigdheden.Size = new Size(137, 51);
            btnEncryptieBenodigdheden.TabIndex = 13;
            btnEncryptieBenodigdheden.Text = "Encryptie Benodigdheden";
            btnEncryptieBenodigdheden.UseVisualStyleBackColor = true;
            btnEncryptieBenodigdheden.Click += btnEncryptieBenodigdheden_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAdminBewerken);
            groupBox3.Controls.Add(btnEncryptieBenodigdheden);
            groupBox3.Location = new Point(494, 379);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 179);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Extra opties:";
            // 
            // FrmSuperAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 745);
            Controls.Add(groupBox3);
            Controls.Add(btnAfsluiten);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSuperAdmin";
            Text = "SuperAdmin";
            Load += FrmSuperAdmin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtNaam;
        private Label label1;
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
        private Button btnUncheckAll;
        private Button btnCheckAll;
        private Button btnAanmaken;
        private Button btnGebruikerAanmaken;
        private Button btnAfsluiten;
        private CheckBox cbTXTAanmaken;
        private CheckBox cbTXTBewerken;
        private CheckBox cbXMLEncrypteren;
        private CheckBox cbXMLLezen;
        private CheckBox cbXMLAanmaken;
        private CheckBox cbXMLBewerken;
        private CheckBox cbJSONEncrypteren;
        private CheckBox cbJSONLezen;
        private CheckBox cbJSONAanmaken;
        private CheckBox cbJSONBewerken;
        private CheckBox cbTXTEncrypteren;
        private CheckBox cbTXTLezen;
        private Button btnAdminBewerken;
        private Button btnEncryptieBenodigdheden;
        private GroupBox groupBox3;
    }
}