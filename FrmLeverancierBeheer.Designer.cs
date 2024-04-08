namespace Project_2__Bart_
{
    partial class FrmLeverancierBeheer
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
            btnBewerken = new Button();
            btnVerwijderen = new Button();
            txtTotaalSaldo = new TextBox();
            txtEmail = new TextBox();
            txtTelefoonnummer = new TextBox();
            txtAdres = new TextBox();
            txtNaam = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lstLeveranciers = new ListBox();
            SuspendLayout();
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(34, 383);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(108, 47);
            btnTerug.TabIndex = 29;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // btnBewerken
            // 
            btnBewerken.Location = new Point(732, 273);
            btnBewerken.Name = "btnBewerken";
            btnBewerken.Size = new Size(108, 47);
            btnBewerken.TabIndex = 28;
            btnBewerken.Text = "Bewerken";
            btnBewerken.UseVisualStyleBackColor = true;
            btnBewerken.Click += btnBewerken_Click;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.Location = new Point(435, 273);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(108, 47);
            btnVerwijderen.TabIndex = 27;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = true;
            btnVerwijderen.Click += btnVerwijderen_Click;
            // 
            // txtTotaalSaldo
            // 
            txtTotaalSaldo.Location = new Point(553, 177);
            txtTotaalSaldo.Name = "txtTotaalSaldo";
            txtTotaalSaldo.ReadOnly = true;
            txtTotaalSaldo.Size = new Size(287, 23);
            txtTotaalSaldo.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(553, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 23);
            txtEmail.TabIndex = 25;
            // 
            // txtTelefoonnummer
            // 
            txtTelefoonnummer.Location = new Point(553, 108);
            txtTelefoonnummer.Name = "txtTelefoonnummer";
            txtTelefoonnummer.Size = new Size(287, 23);
            txtTelefoonnummer.TabIndex = 24;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(553, 75);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(287, 23);
            txtAdres.TabIndex = 23;
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(553, 43);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(287, 23);
            txtNaam.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 177);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 21;
            label6.Text = "Totaal Saldo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 142);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 20;
            label5.Text = "E-mailadres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 108);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 19;
            label4.Text = "Telefoonnummer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 78);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 18;
            label3.Text = "Adres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 46);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 17;
            label2.Text = "Naam:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 16;
            label1.Text = "Leveranciers:";
            // 
            // lstLeveranciers
            // 
            lstLeveranciers.FormattingEnabled = true;
            lstLeveranciers.ItemHeight = 15;
            lstLeveranciers.Location = new Point(34, 46);
            lstLeveranciers.Name = "lstLeveranciers";
            lstLeveranciers.Size = new Size(353, 274);
            lstLeveranciers.TabIndex = 15;
            lstLeveranciers.SelectedIndexChanged += lstKlanten_SelectedIndexChanged;
            // 
            // FrmLeverancierBeheer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 450);
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
            Controls.Add(lstLeveranciers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLeverancierBeheer";
            Text = "FrmLeverancierBeheer";
            Load += FrmLeverancierBeheer_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTerug;
        private Button btnBewerken;
        private Button btnVerwijderen;
        private TextBox txtTotaalSaldo;
        private TextBox txtEmail;
        private TextBox txtTelefoonnummer;
        private TextBox txtAdres;
        private TextBox txtNaam;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lstLeveranciers;
    }
}