namespace Project_2__Bart_
{
    partial class FrmAdminEncryptie
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
            btnSleutelAanmaken = new Button();
            Sleutel = new GroupBox();
            txtNaamSleutelLeverancier = new TextBox();
            label1 = new Label();
            btnSleutelLeverancierZoeken = new Button();
            btnSleutelLeverancierToepassen = new Button();
            groupBox2 = new GroupBox();
            txtNaamBestaandeSleutel = new TextBox();
            label2 = new Label();
            btnSleutelZoeken = new Button();
            btnSleutelVerwijderen = new Button();
            btnTerug = new Button();
            groupBox1.SuspendLayout();
            Sleutel.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSleutelAanmaken);
            groupBox1.Location = new Point(253, 32);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(486, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eigen sleutels:";
            // 
            // btnSleutelAanmaken
            // 
            btnSleutelAanmaken.Location = new Point(174, 40);
            btnSleutelAanmaken.Margin = new Padding(3, 2, 3, 2);
            btnSleutelAanmaken.Name = "btnSleutelAanmaken";
            btnSleutelAanmaken.Size = new Size(108, 43);
            btnSleutelAanmaken.TabIndex = 0;
            btnSleutelAanmaken.Text = "Sleutel Aanmaken";
            btnSleutelAanmaken.UseVisualStyleBackColor = true;
            btnSleutelAanmaken.Click += btnSleutelAanmaken_Click;
            // 
            // Sleutel
            // 
            Sleutel.Controls.Add(txtNaamSleutelLeverancier);
            Sleutel.Controls.Add(label1);
            Sleutel.Controls.Add(btnSleutelLeverancierZoeken);
            Sleutel.Controls.Add(btnSleutelLeverancierToepassen);
            Sleutel.Location = new Point(253, 164);
            Sleutel.Margin = new Padding(3, 2, 3, 2);
            Sleutel.Name = "Sleutel";
            Sleutel.Padding = new Padding(3, 2, 3, 2);
            Sleutel.Size = new Size(486, 117);
            Sleutel.TabIndex = 1;
            Sleutel.TabStop = false;
            Sleutel.Text = "Sleutels leverancier:";
            // 
            // txtNaamSleutelLeverancier
            // 
            txtNaamSleutelLeverancier.Location = new Point(136, 80);
            txtNaamSleutelLeverancier.Margin = new Padding(3, 2, 3, 2);
            txtNaamSleutelLeverancier.Name = "txtNaamSleutelLeverancier";
            txtNaamSleutelLeverancier.ReadOnly = true;
            txtNaamSleutelLeverancier.Size = new Size(204, 23);
            txtNaamSleutelLeverancier.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 82);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Naam sleutel:";
            // 
            // btnSleutelLeverancierZoeken
            // 
            btnSleutelLeverancierZoeken.Location = new Point(15, 27);
            btnSleutelLeverancierZoeken.Margin = new Padding(3, 2, 3, 2);
            btnSleutelLeverancierZoeken.Name = "btnSleutelLeverancierZoeken";
            btnSleutelLeverancierZoeken.Size = new Size(113, 42);
            btnSleutelLeverancierZoeken.TabIndex = 1;
            btnSleutelLeverancierZoeken.Text = "Sleutel Zoeken";
            btnSleutelLeverancierZoeken.UseVisualStyleBackColor = true;
            btnSleutelLeverancierZoeken.Click += btnSleutelLeverancierZoeken_Click;
            // 
            // btnSleutelLeverancierToepassen
            // 
            btnSleutelLeverancierToepassen.Location = new Point(360, 59);
            btnSleutelLeverancierToepassen.Margin = new Padding(3, 2, 3, 2);
            btnSleutelLeverancierToepassen.Name = "btnSleutelLeverancierToepassen";
            btnSleutelLeverancierToepassen.Size = new Size(111, 44);
            btnSleutelLeverancierToepassen.TabIndex = 2;
            btnSleutelLeverancierToepassen.Text = "Sleutel Toepassen";
            btnSleutelLeverancierToepassen.UseVisualStyleBackColor = true;
            btnSleutelLeverancierToepassen.Click += btnSleutelLeverancierToepassen_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNaamBestaandeSleutel);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSleutelZoeken);
            groupBox2.Controls.Add(btnSleutelVerwijderen);
            groupBox2.Location = new Point(253, 296);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(486, 117);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sleutels beheren:";
            // 
            // txtNaamBestaandeSleutel
            // 
            txtNaamBestaandeSleutel.Location = new Point(136, 80);
            txtNaamBestaandeSleutel.Margin = new Padding(3, 2, 3, 2);
            txtNaamBestaandeSleutel.Name = "txtNaamBestaandeSleutel";
            txtNaamBestaandeSleutel.ReadOnly = true;
            txtNaamBestaandeSleutel.Size = new Size(204, 23);
            txtNaamBestaandeSleutel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 82);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Naam sleutel:";
            // 
            // btnSleutelZoeken
            // 
            btnSleutelZoeken.Location = new Point(15, 27);
            btnSleutelZoeken.Margin = new Padding(3, 2, 3, 2);
            btnSleutelZoeken.Name = "btnSleutelZoeken";
            btnSleutelZoeken.Size = new Size(113, 42);
            btnSleutelZoeken.TabIndex = 1;
            btnSleutelZoeken.Text = "Sleutel Zoeken";
            btnSleutelZoeken.UseVisualStyleBackColor = true;
            btnSleutelZoeken.Click += btnSleutelZoeken_Click;
            // 
            // btnSleutelVerwijderen
            // 
            btnSleutelVerwijderen.Location = new Point(360, 59);
            btnSleutelVerwijderen.Margin = new Padding(3, 2, 3, 2);
            btnSleutelVerwijderen.Name = "btnSleutelVerwijderen";
            btnSleutelVerwijderen.Size = new Size(111, 44);
            btnSleutelVerwijderen.TabIndex = 2;
            btnSleutelVerwijderen.Text = "Sleutel Verwijderen";
            btnSleutelVerwijderen.UseVisualStyleBackColor = true;
            btnSleutelVerwijderen.Click += btnSleutelVerwijderen_Click;
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(18, 362);
            btnTerug.Margin = new Padding(3, 2, 3, 2);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(133, 52);
            btnTerug.TabIndex = 6;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // FrmAdminEncryptie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 440);
            Controls.Add(btnTerug);
            Controls.Add(groupBox2);
            Controls.Add(Sleutel);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAdminEncryptie";
            Text = "Encryptiebenodigdheden";
            Load += FrmAdminEncryptie_Load;
            groupBox1.ResumeLayout(false);
            Sleutel.ResumeLayout(false);
            Sleutel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSleutelAanmaken;
        private GroupBox Sleutel;
        private TextBox txtNaamSleutelLeverancier;
        private Label label1;
        private Button btnSleutelLeverancierZoeken;
        private Button btnSleutelLeverancierToepassen;
        private GroupBox groupBox2;
        private TextBox txtNaamBestaandeSleutel;
        private Label label2;
        private Button btnSleutelZoeken;
        private Button btnSleutelVerwijderen;
        private Button btnTerug;
    }
}