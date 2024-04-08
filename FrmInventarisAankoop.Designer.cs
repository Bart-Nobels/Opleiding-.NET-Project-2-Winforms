namespace Project_2__Bart_
{
    partial class FrmInventarisAankoop
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
            btnTerugInventarisAankoop = new Button();
            btnBewerken = new Button();
            groupBox2 = new GroupBox();
            txtAantalInstock = new TextBox();
            txtPlaatsInWarenhuis = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtAankoopprijs = new TextBox();
            lstAankoopartikels = new ListBox();
            btnVerwijderen = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTerugInventarisAankoop
            // 
            btnTerugInventarisAankoop.Location = new Point(24, 326);
            btnTerugInventarisAankoop.Margin = new Padding(3, 2, 3, 2);
            btnTerugInventarisAankoop.Name = "btnTerugInventarisAankoop";
            btnTerugInventarisAankoop.Size = new Size(122, 41);
            btnTerugInventarisAankoop.TabIndex = 0;
            btnTerugInventarisAankoop.Text = "Terug";
            btnTerugInventarisAankoop.UseVisualStyleBackColor = true;
            btnTerugInventarisAankoop.Click += btnTerugInventarisAankoop_Click;
            // 
            // btnBewerken
            // 
            btnBewerken.Location = new Point(771, 324);
            btnBewerken.Margin = new Padding(3, 2, 3, 2);
            btnBewerken.Name = "btnBewerken";
            btnBewerken.Size = new Size(113, 43);
            btnBewerken.TabIndex = 31;
            btnBewerken.Text = "Bewerken";
            btnBewerken.UseVisualStyleBackColor = true;
            btnBewerken.Click += btnBewerken_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAantalInstock);
            groupBox2.Controls.Add(txtPlaatsInWarenhuis);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtAankoopprijs);
            groupBox2.Location = new Point(432, 29);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(477, 95);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gegevens Artikel:";
            // 
            // txtAantalInstock
            // 
            txtAantalInstock.Location = new Point(130, 18);
            txtAantalInstock.Margin = new Padding(3, 2, 3, 2);
            txtAantalInstock.Name = "txtAantalInstock";
            txtAantalInstock.Size = new Size(308, 23);
            txtAantalInstock.TabIndex = 35;
            // 
            // txtPlaatsInWarenhuis
            // 
            txtPlaatsInWarenhuis.Location = new Point(130, 68);
            txtPlaatsInWarenhuis.Margin = new Padding(3, 2, 3, 2);
            txtPlaatsInWarenhuis.Name = "txtPlaatsInWarenhuis";
            txtPlaatsInWarenhuis.Size = new Size(308, 23);
            txtPlaatsInWarenhuis.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 68);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 31;
            label5.Text = "Plaats In Warenhuis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 43);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 30;
            label4.Text = "Aankoopprijs:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 29;
            label3.Text = "Aantal In Stock:";
            // 
            // txtAankoopprijs
            // 
            txtAankoopprijs.Location = new Point(130, 41);
            txtAankoopprijs.Margin = new Padding(3, 2, 3, 2);
            txtAankoopprijs.Name = "txtAankoopprijs";
            txtAankoopprijs.Size = new Size(308, 23);
            txtAankoopprijs.TabIndex = 34;
            // 
            // lstAankoopartikels
            // 
            lstAankoopartikels.FormattingEnabled = true;
            lstAankoopartikels.ItemHeight = 15;
            lstAankoopartikels.Location = new Point(24, 29);
            lstAankoopartikels.Margin = new Padding(3, 2, 3, 2);
            lstAankoopartikels.Name = "lstAankoopartikels";
            lstAankoopartikels.Size = new Size(374, 274);
            lstAankoopartikels.TabIndex = 28;
            lstAankoopartikels.SelectedIndexChanged += lstAankoopartikels_SelectedIndexChanged;
            lstAankoopartikels.Format += lstAankoopartikels_Format;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.Location = new Point(432, 325);
            btnVerwijderen.Margin = new Padding(3, 2, 3, 2);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(113, 43);
            btnVerwijderen.TabIndex = 32;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = true;
            btnVerwijderen.Click += btnVerwijderen_Click;
            // 
            // FrmInventarisAankoop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 389);
            Controls.Add(btnVerwijderen);
            Controls.Add(btnBewerken);
            Controls.Add(groupBox2);
            Controls.Add(lstAankoopartikels);
            Controls.Add(btnTerugInventarisAankoop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmInventarisAankoop";
            Text = "Inventaris";
            Load += FrmInventarisAankoop_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTerugInventarisAankoop;
        private Button btnBewerken;
        private GroupBox groupBox2;
        private ListBox lstAfdelingen;
        private NumericUpDown nudTellerPaswoord;
        private Label label6;
        private TextBox txtLoonGebruiker;
        private Label label5;
        private TextBox txtRekeningnummerGebruiker;
        private Label label4;
        private TextBox txtTelefoonnummerGebruiker;
        private Label label3;
        private TextBox txtAdresGebruiker;
        private TextBox txtNaamArtikel;
        private Label label12;
        private TextBox txtAankoopprijs;
        private Label label11;
        private TextBox txtGebruikersnaamGebruiker;
        private Label label10;
        private TextBox txtPaswoordGebruiker;
        private Label label9;
        private Label label8;
        private Label label7;
        private ListBox lstAankoopartikels;
        private TextBox txtPlaatsInWarenhuis;
        private TextBox txtAantalInstock;
        private Button btnVerwijderen;
    }
}