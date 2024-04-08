namespace Project_2__Bart_
{
    partial class FrmVerslagen
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
            txtVerslag = new TextBox();
            txtBestandsnaam = new TextBox();
            label1 = new Label();
            btnOpslaan = new Button();
            btnVerslagZoeken = new Button();
            cmbAfdelingen = new ComboBox();
            label2 = new Label();
            btnFormulierLeegmaken = new Button();
            SuspendLayout();
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(11, 448);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(129, 57);
            btnTerug.TabIndex = 12;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // txtVerslag
            // 
            txtVerslag.Location = new Point(233, 133);
            txtVerslag.Multiline = true;
            txtVerslag.Name = "txtVerslag";
            txtVerslag.ScrollBars = ScrollBars.Vertical;
            txtVerslag.Size = new Size(518, 289);
            txtVerslag.TabIndex = 13;
            // 
            // txtBestandsnaam
            // 
            txtBestandsnaam.Location = new Point(355, 463);
            txtBestandsnaam.Name = "txtBestandsnaam";
            txtBestandsnaam.Size = new Size(221, 27);
            txtBestandsnaam.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 467);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 15;
            label1.Text = "Bestandsnaam:";
            // 
            // btnOpslaan
            // 
            btnOpslaan.Location = new Point(612, 479);
            btnOpslaan.Name = "btnOpslaan";
            btnOpslaan.Size = new Size(139, 57);
            btnOpslaan.TabIndex = 16;
            btnOpslaan.Text = "Opslaan";
            btnOpslaan.UseVisualStyleBackColor = true;
            btnOpslaan.Click += btnOpslaan_Click;
            // 
            // btnVerslagZoeken
            // 
            btnVerslagZoeken.Location = new Point(233, 43);
            btnVerslagZoeken.Name = "btnVerslagZoeken";
            btnVerslagZoeken.Size = new Size(139, 57);
            btnVerslagZoeken.TabIndex = 18;
            btnVerslagZoeken.Text = "Verslag Zoeken";
            btnVerslagZoeken.UseVisualStyleBackColor = true;
            btnVerslagZoeken.Click += btnVerslagZoeken_Click_1;
            // 
            // cmbAfdelingen
            // 
            cmbAfdelingen.FormattingEnabled = true;
            cmbAfdelingen.Location = new Point(355, 524);
            cmbAfdelingen.Name = "cmbAfdelingen";
            cmbAfdelingen.Size = new Size(221, 28);
            cmbAfdelingen.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 527);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 20;
            label2.Text = "Afdeling:";
            // 
            // btnFormulierLeegmaken
            // 
            btnFormulierLeegmaken.Location = new Point(612, 43);
            btnFormulierLeegmaken.Name = "btnFormulierLeegmaken";
            btnFormulierLeegmaken.Size = new Size(139, 57);
            btnFormulierLeegmaken.TabIndex = 21;
            btnFormulierLeegmaken.Text = "Formulier Leegmaken";
            btnFormulierLeegmaken.UseVisualStyleBackColor = true;
            btnFormulierLeegmaken.Click += btnFormulierLeegmaken_Click;
            // 
            // FrmVerslagen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 586);
            Controls.Add(btnFormulierLeegmaken);
            Controls.Add(label2);
            Controls.Add(cmbAfdelingen);
            Controls.Add(btnVerslagZoeken);
            Controls.Add(btnOpslaan);
            Controls.Add(label1);
            Controls.Add(txtBestandsnaam);
            Controls.Add(txtVerslag);
            Controls.Add(btnTerug);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVerslagen";
            Text = "Verslagen";
            Load += FrmVerslagen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTerug;
        private TextBox txtVerslag;
        private TextBox txtBestandsnaam;
        private Label label1;
        private Button btnOpslaan;
        private Button btnVerslagZoeken;
        private ComboBox cmbAfdelingen;
        private Label label2;
        private Button btnFormulierLeegmaken;
    }
}