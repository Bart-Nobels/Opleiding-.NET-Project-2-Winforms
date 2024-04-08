namespace Project_2__Bart_
{
    partial class FrmBestellingenAankoop
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
            btnTerugBestellingenAankoop = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbArtikel = new ComboBox();
            label3 = new Label();
            nudAantal = new NumericUpDown();
            btnToevoegenBestellingenAankoop = new Button();
            btnBestellingPlaatsenBestellingenAankoop = new Button();
            txtOverzichtBestellingBestellingenAankoop = new TextBox();
            groupBox1 = new GroupBox();
            rdoXMLBestellingenAankoop = new RadioButton();
            txtBestelbestandZoeken = new TextBox();
            rdoJSONBestellingenAankoop = new RadioButton();
            btnBestelbestandZoeken = new Button();
            cbEncryptieBestellingenAankoop = new CheckBox();
            txtBedrijfsnaam = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtNaamBestandBestelling = new TextBox();
            rdoXMLBestellingPlaatsen = new RadioButton();
            rdoJSONBestellingPlaatsen = new RadioButton();
            groupBox3 = new GroupBox();
            txtTotaalsaldoBestelling = new TextBox();
            label5 = new Label();
            btnFormulierLeegmaken = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAantal).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnTerugBestellingenAankoop
            // 
            btnTerugBestellingenAankoop.Location = new Point(10, 553);
            btnTerugBestellingenAankoop.Margin = new Padding(3, 2, 3, 2);
            btnTerugBestellingenAankoop.Name = "btnTerugBestellingenAankoop";
            btnTerugBestellingenAankoop.Size = new Size(127, 45);
            btnTerugBestellingenAankoop.TabIndex = 0;
            btnTerugBestellingenAankoop.Text = "Terug";
            btnTerugBestellingenAankoop.UseVisualStyleBackColor = true;
            btnTerugBestellingenAankoop.Click += btnTerugBestellingenAankoop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 39);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Bedrijfsnaam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 82);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Naam artikel:";
            // 
            // cmbArtikel
            // 
            cmbArtikel.FormattingEnabled = true;
            cmbArtikel.Location = new Point(128, 80);
            cmbArtikel.Margin = new Padding(3, 2, 3, 2);
            cmbArtikel.Name = "cmbArtikel";
            cmbArtikel.Size = new Size(275, 23);
            cmbArtikel.TabIndex = 3;
            cmbArtikel.SelectedIndexChanged += cmbArtikel_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 127);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Aantal flessen:";
            // 
            // nudAantal
            // 
            nudAantal.Location = new Point(128, 127);
            nudAantal.Margin = new Padding(3, 2, 3, 2);
            nudAantal.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAantal.Name = "nudAantal";
            nudAantal.Size = new Size(275, 23);
            nudAantal.TabIndex = 7;
            nudAantal.ValueChanged += nudAantal_ValueChanged;
            // 
            // btnToevoegenBestellingenAankoop
            // 
            btnToevoegenBestellingenAankoop.Location = new Point(15, 160);
            btnToevoegenBestellingenAankoop.Margin = new Padding(3, 2, 3, 2);
            btnToevoegenBestellingenAankoop.Name = "btnToevoegenBestellingenAankoop";
            btnToevoegenBestellingenAankoop.Size = new Size(101, 30);
            btnToevoegenBestellingenAankoop.TabIndex = 8;
            btnToevoegenBestellingenAankoop.Text = "Toevoegen";
            btnToevoegenBestellingenAankoop.UseVisualStyleBackColor = true;
            btnToevoegenBestellingenAankoop.Click += btnToevoegenBestellingenAankoop_Click;
            // 
            // btnBestellingPlaatsenBestellingenAankoop
            // 
            btnBestellingPlaatsenBestellingenAankoop.Location = new Point(468, 29);
            btnBestellingPlaatsenBestellingenAankoop.Margin = new Padding(3, 2, 3, 2);
            btnBestellingPlaatsenBestellingenAankoop.Name = "btnBestellingPlaatsenBestellingenAankoop";
            btnBestellingPlaatsenBestellingenAankoop.Size = new Size(101, 40);
            btnBestellingPlaatsenBestellingenAankoop.TabIndex = 9;
            btnBestellingPlaatsenBestellingenAankoop.Text = "Bestelling Plaatsen";
            btnBestellingPlaatsenBestellingenAankoop.UseVisualStyleBackColor = true;
            btnBestellingPlaatsenBestellingenAankoop.Click += btnBestellingPlaatsenBestellingenAankoop_Click;
            // 
            // txtOverzichtBestellingBestellingenAankoop
            // 
            txtOverzichtBestellingBestellingenAankoop.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOverzichtBestellingBestellingenAankoop.Location = new Point(15, 201);
            txtOverzichtBestellingBestellingenAankoop.Margin = new Padding(3, 2, 3, 2);
            txtOverzichtBestellingBestellingenAankoop.Multiline = true;
            txtOverzichtBestellingBestellingenAankoop.Name = "txtOverzichtBestellingBestellingenAankoop";
            txtOverzichtBestellingBestellingenAankoop.ReadOnly = true;
            txtOverzichtBestellingBestellingenAankoop.ScrollBars = ScrollBars.Vertical;
            txtOverzichtBestellingBestellingenAankoop.Size = new Size(388, 137);
            txtOverzichtBestellingBestellingenAankoop.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoXMLBestellingenAankoop);
            groupBox1.Controls.Add(txtBestelbestandZoeken);
            groupBox1.Controls.Add(rdoJSONBestellingenAankoop);
            groupBox1.Controls.Add(btnBestelbestandZoeken);
            groupBox1.Location = new Point(193, 19);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(458, 81);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bestand Zoeken:";
            // 
            // rdoXMLBestellingenAankoop
            // 
            rdoXMLBestellingenAankoop.AutoSize = true;
            rdoXMLBestellingenAankoop.Location = new Point(128, 50);
            rdoXMLBestellingenAankoop.Margin = new Padding(3, 2, 3, 2);
            rdoXMLBestellingenAankoop.Name = "rdoXMLBestellingenAankoop";
            rdoXMLBestellingenAankoop.Size = new Size(49, 19);
            rdoXMLBestellingenAankoop.TabIndex = 1;
            rdoXMLBestellingenAankoop.TabStop = true;
            rdoXMLBestellingenAankoop.Text = "XML";
            rdoXMLBestellingenAankoop.UseVisualStyleBackColor = true;
            // 
            // txtBestelbestandZoeken
            // 
            txtBestelbestandZoeken.Location = new Point(213, 34);
            txtBestelbestandZoeken.Margin = new Padding(3, 2, 3, 2);
            txtBestelbestandZoeken.Name = "txtBestelbestandZoeken";
            txtBestelbestandZoeken.ReadOnly = true;
            txtBestelbestandZoeken.Size = new Size(231, 23);
            txtBestelbestandZoeken.TabIndex = 14;
            // 
            // rdoJSONBestellingenAankoop
            // 
            rdoJSONBestellingenAankoop.AutoSize = true;
            rdoJSONBestellingenAankoop.Location = new Point(128, 27);
            rdoJSONBestellingenAankoop.Margin = new Padding(3, 2, 3, 2);
            rdoJSONBestellingenAankoop.Name = "rdoJSONBestellingenAankoop";
            rdoJSONBestellingenAankoop.Size = new Size(53, 19);
            rdoJSONBestellingenAankoop.TabIndex = 0;
            rdoJSONBestellingenAankoop.TabStop = true;
            rdoJSONBestellingenAankoop.Text = "JSON";
            rdoJSONBestellingenAankoop.UseVisualStyleBackColor = true;
            // 
            // btnBestelbestandZoeken
            // 
            btnBestelbestandZoeken.Location = new Point(15, 30);
            btnBestelbestandZoeken.Margin = new Padding(3, 2, 3, 2);
            btnBestelbestandZoeken.Name = "btnBestelbestandZoeken";
            btnBestelbestandZoeken.Size = new Size(101, 38);
            btnBestelbestandZoeken.TabIndex = 13;
            btnBestelbestandZoeken.Text = "Bestelbestand Zoeken";
            btnBestelbestandZoeken.UseVisualStyleBackColor = true;
            btnBestelbestandZoeken.Click += btnBestelbestandZoeken_Click;
            // 
            // cbEncryptieBestellingenAankoop
            // 
            cbEncryptieBestellingenAankoop.AutoSize = true;
            cbEncryptieBestellingenAankoop.Location = new Point(264, 41);
            cbEncryptieBestellingenAankoop.Margin = new Padding(3, 2, 3, 2);
            cbEncryptieBestellingenAankoop.Name = "cbEncryptieBestellingenAankoop";
            cbEncryptieBestellingenAankoop.Size = new Size(75, 19);
            cbEncryptieBestellingenAankoop.TabIndex = 12;
            cbEncryptieBestellingenAankoop.Text = "Encryptie";
            cbEncryptieBestellingenAankoop.UseVisualStyleBackColor = true;
            // 
            // txtBedrijfsnaam
            // 
            txtBedrijfsnaam.Location = new Point(128, 37);
            txtBedrijfsnaam.Margin = new Padding(3, 2, 3, 2);
            txtBedrijfsnaam.Name = "txtBedrijfsnaam";
            txtBedrijfsnaam.ReadOnly = true;
            txtBedrijfsnaam.Size = new Size(275, 23);
            txtBedrijfsnaam.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNaamBestandBestelling);
            groupBox2.Controls.Add(rdoXMLBestellingPlaatsen);
            groupBox2.Controls.Add(rdoJSONBestellingPlaatsen);
            groupBox2.Controls.Add(cbEncryptieBestellingenAankoop);
            groupBox2.Controls.Add(btnBestellingPlaatsenBestellingenAankoop);
            groupBox2.Location = new Point(193, 509);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(590, 88);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bestelling Plaatsen:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 32);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 14;
            label4.Text = "Bestandsnaam:";
            // 
            // txtNaamBestandBestelling
            // 
            txtNaamBestandBestelling.Location = new Point(15, 50);
            txtNaamBestandBestelling.Margin = new Padding(3, 2, 3, 2);
            txtNaamBestandBestelling.Name = "txtNaamBestandBestelling";
            txtNaamBestandBestelling.Size = new Size(198, 23);
            txtNaamBestandBestelling.TabIndex = 13;
            // 
            // rdoXMLBestellingPlaatsen
            // 
            rdoXMLBestellingPlaatsen.AutoSize = true;
            rdoXMLBestellingPlaatsen.Location = new Point(386, 52);
            rdoXMLBestellingPlaatsen.Margin = new Padding(3, 2, 3, 2);
            rdoXMLBestellingPlaatsen.Name = "rdoXMLBestellingPlaatsen";
            rdoXMLBestellingPlaatsen.Size = new Size(49, 19);
            rdoXMLBestellingPlaatsen.TabIndex = 1;
            rdoXMLBestellingPlaatsen.TabStop = true;
            rdoXMLBestellingPlaatsen.Text = "XML";
            rdoXMLBestellingPlaatsen.UseVisualStyleBackColor = true;
            // 
            // rdoJSONBestellingPlaatsen
            // 
            rdoJSONBestellingPlaatsen.AutoSize = true;
            rdoJSONBestellingPlaatsen.Location = new Point(386, 29);
            rdoJSONBestellingPlaatsen.Margin = new Padding(3, 2, 3, 2);
            rdoJSONBestellingPlaatsen.Name = "rdoJSONBestellingPlaatsen";
            rdoJSONBestellingPlaatsen.Size = new Size(53, 19);
            rdoJSONBestellingPlaatsen.TabIndex = 0;
            rdoJSONBestellingPlaatsen.TabStop = true;
            rdoJSONBestellingPlaatsen.Text = "JSON";
            rdoJSONBestellingPlaatsen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTotaalsaldoBestelling);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cmbArtikel);
            groupBox3.Controls.Add(txtBedrijfsnaam);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtOverzichtBestellingBestellingenAankoop);
            groupBox3.Controls.Add(nudAantal);
            groupBox3.Controls.Add(btnToevoegenBestellingenAankoop);
            groupBox3.Location = new Point(193, 113);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(590, 380);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Artikels Toevoegen:";
            // 
            // txtTotaalsaldoBestelling
            // 
            txtTotaalsaldoBestelling.Location = new Point(176, 351);
            txtTotaalsaldoBestelling.Margin = new Padding(3, 2, 3, 2);
            txtTotaalsaldoBestelling.Name = "txtTotaalsaldoBestelling";
            txtTotaalsaldoBestelling.ReadOnly = true;
            txtTotaalsaldoBestelling.Size = new Size(227, 23);
            txtTotaalsaldoBestelling.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 353);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 16;
            label5.Text = "Totaalsaldo bestelling:";
            // 
            // btnFormulierLeegmaken
            // 
            btnFormulierLeegmaken.Location = new Point(673, 44);
            btnFormulierLeegmaken.Margin = new Padding(3, 2, 3, 2);
            btnFormulierLeegmaken.Name = "btnFormulierLeegmaken";
            btnFormulierLeegmaken.Size = new Size(101, 38);
            btnFormulierLeegmaken.TabIndex = 15;
            btnFormulierLeegmaken.Text = "Formulier Leegmaken";
            btnFormulierLeegmaken.UseVisualStyleBackColor = true;
            btnFormulierLeegmaken.Click += btnFormulierLeegmaken_Click;
            // 
            // FrmBestellingenAankoop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 616);
            Controls.Add(btnFormulierLeegmaken);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnTerugBestellingenAankoop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBestellingenAankoop";
            Text = "Bestellingen";
            Load += FrmBestellingenAankoop_Load;
            ((System.ComponentModel.ISupportInitialize)nudAantal).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTerugBestellingenAankoop;
        private Label label1;
        private Label label2;
        private ComboBox cmbArtikel;
        private Label label3;
        private NumericUpDown nudAantal;
        private Button btnToevoegenBestellingenAankoop;
        private Button btnBestellingPlaatsenBestellingenAankoop;
        private TextBox txtOverzichtBestellingBestellingenAankoop;
        private GroupBox groupBox1;
        private RadioButton rdoXMLBestellingenAankoop;
        private RadioButton rdoJSONBestellingenAankoop;
        private CheckBox cbEncryptieBestellingenAankoop;
        private Button btnBestelbestandZoeken;
        private TextBox txtBestelbestandZoeken;
        private TextBox txtBedrijfsnaam;
        private GroupBox groupBox2;
        private RadioButton rdoXMLBestellingPlaatsen;
        private RadioButton rdoJSONBestellingPlaatsen;
        private GroupBox groupBox3;
        private TextBox txtNaamBestandBestelling;
        private Label label4;
        private Button btnFormulierLeegmaken;
        private TextBox txtTotaalsaldoBestelling;
        private Label label5;
    }
}