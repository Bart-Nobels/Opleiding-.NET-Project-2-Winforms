namespace Project_2__Bart_.Kassa
{
    partial class FrmVerkoopKassa
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerkoopKassa));
            label1 = new Label();
            txtKlantNaam = new TextBox();
            btnKlantZoeken = new Button();
            lbArtikels = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtFactuur = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTotaalBedrag = new TextBox();
            nudHoeveelheid = new NumericUpDown();
            btnToevoegen = new Button();
            btnRembours = new Button();
            lblTijd = new Label();
            timTijd = new System.Windows.Forms.Timer(components);
            timAfmelden = new System.Windows.Forms.Timer(components);
            timScreensaver = new System.Windows.Forms.Timer(components);
            btnCash = new Button();
            btnBancontact = new Button();
            btnMaaltijdcheques = new Button();
            btnKredietkaart = new Button();
            label6 = new Label();
            txtOntvangen = new TextBox();
            label7 = new Label();
            txtWisselgeld = new TextBox();
            btnTerug = new Button();
            btnDoorgaan = new Button();
            btnAfrekenen = new Button();
            lblKlantNaam = new Label();
            lblTotaalSaldoKlant = new Label();
            lblNaamGebruiker = new Label();
            ((System.ComponentModel.ISupportInitialize)nudHoeveelheid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1318, 56);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 0;
            label1.Text = "Klantnaam:";
            // 
            // txtKlantNaam
            // 
            txtKlantNaam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtKlantNaam.Location = new Point(1487, 66);
            txtKlantNaam.Margin = new Padding(3, 4, 3, 4);
            txtKlantNaam.Name = "txtKlantNaam";
            txtKlantNaam.Size = new Size(250, 27);
            txtKlantNaam.TabIndex = 1;
            // 
            // btnKlantZoeken
            // 
            btnKlantZoeken.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKlantZoeken.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKlantZoeken.Location = new Point(1757, 37);
            btnKlantZoeken.Margin = new Padding(3, 4, 3, 4);
            btnKlantZoeken.Name = "btnKlantZoeken";
            btnKlantZoeken.Size = new Size(181, 74);
            btnKlantZoeken.TabIndex = 2;
            btnKlantZoeken.Text = "Zoeken";
            btnKlantZoeken.UseVisualStyleBackColor = true;
            btnKlantZoeken.Click += btnKlantZoeken_Click;
            // 
            // lbArtikels
            // 
            lbArtikels.FormattingEnabled = true;
            lbArtikels.ItemHeight = 20;
            lbArtikels.Location = new Point(156, 138);
            lbArtikels.Margin = new Padding(3, 4, 3, 4);
            lbArtikels.Name = "lbArtikels";
            lbArtikels.ScrollAlwaysVisible = true;
            lbArtikels.Size = new Size(199, 324);
            lbArtikels.TabIndex = 3;
            lbArtikels.SelectedIndexChanged += lbArtikels_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 138);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 4;
            label2.Text = "Artikels:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(389, 138);
            label3.Name = "label3";
            label3.Size = new Size(186, 37);
            label3.TabIndex = 5;
            label3.Text = "Hoeveelheid:";
            // 
            // txtFactuur
            // 
            txtFactuur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFactuur.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFactuur.Location = new Point(1318, 138);
            txtFactuur.Margin = new Padding(3, 4, 3, 4);
            txtFactuur.Multiline = true;
            txtFactuur.Name = "txtFactuur";
            txtFactuur.ScrollBars = ScrollBars.Vertical;
            txtFactuur.Size = new Size(621, 396);
            txtFactuur.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1180, 138);
            label4.Name = "label4";
            label4.Size = new Size(120, 37);
            label4.TabIndex = 7;
            label4.Text = "Factuur:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1087, 560);
            label5.Name = "label5";
            label5.Size = new Size(229, 41);
            label5.TabIndex = 8;
            label5.Text = "Totaal Bedrag :";
            // 
            // txtTotaalBedrag
            // 
            txtTotaalBedrag.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotaalBedrag.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotaalBedrag.Location = new Point(1310, 564);
            txtTotaalBedrag.Margin = new Padding(3, 4, 3, 4);
            txtTotaalBedrag.Name = "txtTotaalBedrag";
            txtTotaalBedrag.ReadOnly = true;
            txtTotaalBedrag.Size = new Size(258, 42);
            txtTotaalBedrag.TabIndex = 9;
            // 
            // nudHoeveelheid
            // 
            nudHoeveelheid.Location = new Point(595, 148);
            nudHoeveelheid.Margin = new Padding(3, 4, 3, 4);
            nudHoeveelheid.Name = "nudHoeveelheid";
            nudHoeveelheid.Size = new Size(195, 27);
            nudHoeveelheid.TabIndex = 10;
            // 
            // btnToevoegen
            // 
            btnToevoegen.Enabled = false;
            btnToevoegen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnToevoegen.Location = new Point(389, 204);
            btnToevoegen.Margin = new Padding(3, 4, 3, 4);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(153, 74);
            btnToevoegen.TabIndex = 11;
            btnToevoegen.Text = "Toevoegen";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // btnRembours
            // 
            btnRembours.Enabled = false;
            btnRembours.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRembours.Location = new Point(637, 204);
            btnRembours.Margin = new Padding(3, 4, 3, 4);
            btnRembours.Name = "btnRembours";
            btnRembours.Size = new Size(153, 74);
            btnRembours.TabIndex = 12;
            btnRembours.Text = "Rembours";
            btnRembours.UseVisualStyleBackColor = true;
            btnRembours.Click += btnRembours_Click;
            // 
            // lblTijd
            // 
            lblTijd.AutoSize = true;
            lblTijd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTijd.Location = new Point(246, 27);
            lblTijd.Name = "lblTijd";
            lblTijd.Size = new Size(58, 32);
            lblTijd.TabIndex = 13;
            lblTijd.Text = "Tijd:";
            // 
            // timTijd
            // 
            timTijd.Enabled = true;
            timTijd.Tick += timTIjd_Tick;
            // 
            // timAfmelden
            // 
            timAfmelden.Interval = 1000;
            timAfmelden.Tick += timAfmelden_Tick;
            // 
            // btnCash
            // 
            btnCash.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCash.BackgroundImage = (Image)resources.GetObject("btnCash.BackgroundImage");
            btnCash.BackgroundImageLayout = ImageLayout.Zoom;
            btnCash.Enabled = false;
            btnCash.Location = new Point(1310, 634);
            btnCash.Margin = new Padding(3, 4, 3, 4);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(211, 140);
            btnCash.TabIndex = 14;
            btnCash.UseVisualStyleBackColor = true;
            btnCash.Click += btnCash_Click;
            // 
            // btnBancontact
            // 
            btnBancontact.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBancontact.BackgroundImage = (Image)resources.GetObject("btnBancontact.BackgroundImage");
            btnBancontact.BackgroundImageLayout = ImageLayout.Zoom;
            btnBancontact.Enabled = false;
            btnBancontact.Location = new Point(1310, 774);
            btnBancontact.Margin = new Padding(3, 4, 3, 4);
            btnBancontact.Name = "btnBancontact";
            btnBancontact.Size = new Size(211, 140);
            btnBancontact.TabIndex = 15;
            btnBancontact.UseVisualStyleBackColor = true;
            // 
            // btnMaaltijdcheques
            // 
            btnMaaltijdcheques.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMaaltijdcheques.BackgroundImage = (Image)resources.GetObject("btnMaaltijdcheques.BackgroundImage");
            btnMaaltijdcheques.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaaltijdcheques.Enabled = false;
            btnMaaltijdcheques.Location = new Point(1666, 634);
            btnMaaltijdcheques.Margin = new Padding(3, 4, 3, 4);
            btnMaaltijdcheques.Name = "btnMaaltijdcheques";
            btnMaaltijdcheques.Size = new Size(211, 140);
            btnMaaltijdcheques.TabIndex = 16;
            btnMaaltijdcheques.UseVisualStyleBackColor = true;
            btnMaaltijdcheques.Click += btnMaaltijdcheques_Click;
            // 
            // btnKredietkaart
            // 
            btnKredietkaart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKredietkaart.BackgroundImage = (Image)resources.GetObject("btnKredietkaart.BackgroundImage");
            btnKredietkaart.BackgroundImageLayout = ImageLayout.Zoom;
            btnKredietkaart.Enabled = false;
            btnKredietkaart.Location = new Point(1666, 774);
            btnKredietkaart.Margin = new Padding(3, 4, 3, 4);
            btnKredietkaart.Name = "btnKredietkaart";
            btnKredietkaart.Size = new Size(211, 140);
            btnKredietkaart.TabIndex = 17;
            btnKredietkaart.UseVisualStyleBackColor = true;
            btnKredietkaart.Click += btnKredietkaart_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1583, 565);
            label6.Name = "label6";
            label6.Size = new Size(182, 41);
            label6.TabIndex = 18;
            label6.Text = "Ontvangen:";
            // 
            // txtOntvangen
            // 
            txtOntvangen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtOntvangen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtOntvangen.Location = new Point(1762, 565);
            txtOntvangen.Margin = new Padding(3, 4, 3, 4);
            txtOntvangen.Name = "txtOntvangen";
            txtOntvangen.Size = new Size(207, 42);
            txtOntvangen.TabIndex = 19;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1274, 958);
            label7.Name = "label7";
            label7.Size = new Size(179, 41);
            label7.TabIndex = 20;
            label7.Text = "Wisselgeld:";
            // 
            // txtWisselgeld
            // 
            txtWisselgeld.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtWisselgeld.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtWisselgeld.Location = new Point(1471, 958);
            txtWisselgeld.Margin = new Padding(3, 4, 3, 4);
            txtWisselgeld.Name = "txtWisselgeld";
            txtWisselgeld.ReadOnly = true;
            txtWisselgeld.Size = new Size(132, 42);
            txtWisselgeld.TabIndex = 21;
            // 
            // btnTerug
            // 
            btnTerug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTerug.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTerug.Location = new Point(26, 946);
            btnTerug.Margin = new Padding(3, 4, 3, 4);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(153, 74);
            btnTerug.TabIndex = 22;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // btnDoorgaan
            // 
            btnDoorgaan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDoorgaan.Enabled = false;
            btnDoorgaan.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoorgaan.Location = new Point(1666, 926);
            btnDoorgaan.Margin = new Padding(3, 4, 3, 4);
            btnDoorgaan.Name = "btnDoorgaan";
            btnDoorgaan.Size = new Size(211, 114);
            btnDoorgaan.TabIndex = 24;
            btnDoorgaan.Text = "Printen en Doorgaan";
            btnDoorgaan.UseVisualStyleBackColor = true;
            btnDoorgaan.Click += btnDoorgaan_Click;
            // 
            // btnAfrekenen
            // 
            btnAfrekenen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAfrekenen.Enabled = false;
            btnAfrekenen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAfrekenen.Location = new Point(1147, 451);
            btnAfrekenen.Margin = new Padding(3, 4, 3, 4);
            btnAfrekenen.Name = "btnAfrekenen";
            btnAfrekenen.Size = new Size(157, 82);
            btnAfrekenen.TabIndex = 25;
            btnAfrekenen.Text = "Afrekenen";
            btnAfrekenen.UseVisualStyleBackColor = true;
            btnAfrekenen.Click += btnAfrekenen_Click;
            // 
            // lblKlantNaam
            // 
            lblKlantNaam.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblKlantNaam.AutoSize = true;
            lblKlantNaam.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKlantNaam.Location = new Point(26, 818);
            lblKlantNaam.Name = "lblKlantNaam";
            lblKlantNaam.Size = new Size(163, 37);
            lblKlantNaam.TabIndex = 26;
            lblKlantNaam.Text = "Klantnaam:";
            // 
            // lblTotaalSaldoKlant
            // 
            lblTotaalSaldoKlant.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotaalSaldoKlant.AutoSize = true;
            lblTotaalSaldoKlant.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotaalSaldoKlant.Location = new Point(26, 870);
            lblTotaalSaldoKlant.Name = "lblTotaalSaldoKlant";
            lblTotaalSaldoKlant.Size = new Size(183, 37);
            lblTotaalSaldoKlant.TabIndex = 27;
            lblTotaalSaldoKlant.Text = "Totaal Saldo:";
            // 
            // lblNaamGebruiker
            // 
            lblNaamGebruiker.AutoSize = true;
            lblNaamGebruiker.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNaamGebruiker.Location = new Point(26, 24);
            lblNaamGebruiker.Name = "lblNaamGebruiker";
            lblNaamGebruiker.Size = new Size(227, 37);
            lblNaamGebruiker.TabIndex = 23;
            lblNaamGebruiker.Text = "Naam Gebruiker";
            // 
            // FrmVerkoopKassa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2051, 1060);
            Controls.Add(lblTotaalSaldoKlant);
            Controls.Add(lblKlantNaam);
            Controls.Add(btnAfrekenen);
            Controls.Add(btnDoorgaan);
            Controls.Add(lblNaamGebruiker);
            Controls.Add(btnTerug);
            Controls.Add(txtWisselgeld);
            Controls.Add(label7);
            Controls.Add(txtOntvangen);
            Controls.Add(label6);
            Controls.Add(btnKredietkaart);
            Controls.Add(btnMaaltijdcheques);
            Controls.Add(btnBancontact);
            Controls.Add(btnCash);
            Controls.Add(lblTijd);
            Controls.Add(btnRembours);
            Controls.Add(btnToevoegen);
            Controls.Add(nudHoeveelheid);
            Controls.Add(txtTotaalBedrag);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFactuur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbArtikels);
            Controls.Add(btnKlantZoeken);
            Controls.Add(txtKlantNaam);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVerkoopKassa";
            Text = "Kassa";
            Load += Kassa_Load;
            ((System.ComponentModel.ISupportInitialize)nudHoeveelheid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKlantNaam;
        private Button btnKlantZoeken;
        private ListBox lbArtikels;
        private Label label2;
        private Label label3;
        private TextBox txtFactuur;
        private Label label4;
        private Label label5;
        private TextBox txtTotaalBedrag;
        private NumericUpDown nudHoeveelheid;
        private Button btnToevoegen;
        private Button btnRembours;
        private Label lblTijd;
        private System.Windows.Forms.Timer timTijd;
        private System.Windows.Forms.Timer timAfmelden;
        private System.Windows.Forms.Timer timScreensaver;
        private Button btnCash;
        private Button btnBancontact;
        private Button btnMaaltijdcheques;
        private Button btnKredietkaart;
        private Label label6;
        private TextBox txtOntvangen;
        private Label label7;
        private TextBox txtWisselgeld;
        private Button btnTerug;
        private Button btnDoorgaan;
        private Button btnAfrekenen;
        private Label lblKlantNaam;
        private Label lblTotaalSaldoKlant;
        private Label lblNaamGebruiker;
    }
}