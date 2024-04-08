namespace Project_2__Bart_
{
    partial class FrmKlantenBeheer
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
            lstKlanten = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNaam = new TextBox();
            txtAdres = new TextBox();
            txtTelefoonnummer = new TextBox();
            txtEmail = new TextBox();
            txtTotaalSaldo = new TextBox();
            btnVerwijderen = new Button();
            btnBewerken = new Button();
            btnTerug = new Button();
            SuspendLayout();
            // 
            // lstKlanten
            // 
            lstKlanten.FormattingEnabled = true;
            lstKlanten.ItemHeight = 15;
            lstKlanten.Location = new Point(35, 35);
            lstKlanten.Name = "lstKlanten";
            lstKlanten.Size = new Size(353, 274);
            lstKlanten.TabIndex = 0;
            lstKlanten.SelectedIndexChanged += lstKlanten_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Klanten:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 35);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Naam:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 67);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Adres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 97);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefoonnummer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 131);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 5;
            label5.Text = "E-mailadres:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 166);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 6;
            label6.Text = "Totaal Saldo:";
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(554, 32);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(320, 23);
            txtNaam.TabIndex = 7;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(554, 64);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(320, 23);
            txtAdres.TabIndex = 8;
            // 
            // txtTelefoonnummer
            // 
            txtTelefoonnummer.Location = new Point(554, 97);
            txtTelefoonnummer.Name = "txtTelefoonnummer";
            txtTelefoonnummer.Size = new Size(320, 23);
            txtTelefoonnummer.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(554, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtTotaalSaldo
            // 
            txtTotaalSaldo.Location = new Point(554, 166);
            txtTotaalSaldo.Name = "txtTotaalSaldo";
            txtTotaalSaldo.ReadOnly = true;
            txtTotaalSaldo.Size = new Size(320, 23);
            txtTotaalSaldo.TabIndex = 11;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.Location = new Point(436, 262);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(108, 47);
            btnVerwijderen.TabIndex = 12;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = true;
            btnVerwijderen.Click += btnVerwijderen_Click;
            // 
            // btnBewerken
            // 
            btnBewerken.Location = new Point(766, 262);
            btnBewerken.Name = "btnBewerken";
            btnBewerken.Size = new Size(108, 47);
            btnBewerken.TabIndex = 13;
            btnBewerken.Text = "Bewerken";
            btnBewerken.UseVisualStyleBackColor = true;
            btnBewerken.Click += btnBewerken_Click;
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(35, 372);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(108, 47);
            btnTerug.TabIndex = 14;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // FrmKlantenBeheer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(btnTerug);
            Controls.Add(btnBewerken);
            Controls.Add(btnVerwijderen);
            Controls.Add(txtTotaalSaldo);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefoonnummer);
            Controls.Add(txtAdres);
            Controls.Add(txtNaam);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstKlanten);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKlantenBeheer";
            Text = "FrmKlantenBeheer";
            Load += FrmKlantenBeheer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKlanten;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNaam;
        private TextBox txtAdres;
        private TextBox txtTelefoonnummer;
        private TextBox txtEmail;
        private TextBox txtTotaalSaldo;
        private Button btnVerwijderen;
        private Button btnBewerken;
        private Button btnTerug;
    }
}