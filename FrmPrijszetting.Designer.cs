namespace Project_2__Bart_
{
    partial class FrmPrijszetting
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
            lstVerkoopArtikels = new ListBox();
            btnBewerken = new Button();
            txtMinimumvoorraadniveau = new TextBox();
            txtPrijs = new TextBox();
            label3 = new Label();
            lblVerkoopprijs = new Label();
            btnTerug = new Button();
            SuspendLayout();
            // 
            // lstVerkoopArtikels
            // 
            lstVerkoopArtikels.FormattingEnabled = true;
            lstVerkoopArtikels.ItemHeight = 15;
            lstVerkoopArtikels.Location = new Point(12, 12);
            lstVerkoopArtikels.Name = "lstVerkoopArtikels";
            lstVerkoopArtikels.Size = new Size(317, 304);
            lstVerkoopArtikels.TabIndex = 0;
            lstVerkoopArtikels.SelectedIndexChanged += lstVerkoopArtikels_SelectedIndexChanged;
            // 
            // btnBewerken
            // 
            btnBewerken.Location = new Point(649, 114);
            btnBewerken.Name = "btnBewerken";
            btnBewerken.Size = new Size(108, 47);
            btnBewerken.TabIndex = 25;
            btnBewerken.Text = "Bewerken";
            btnBewerken.UseVisualStyleBackColor = true;
            btnBewerken.Click += btnBewerken_Click;
            // 
            // txtMinimumvoorraadniveau
            // 
            txtMinimumvoorraadniveau.Location = new Point(589, 66);
            txtMinimumvoorraadniveau.Name = "txtMinimumvoorraadniveau";
            txtMinimumvoorraadniveau.Size = new Size(100, 23);
            txtMinimumvoorraadniveau.TabIndex = 20;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(589, 34);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(100, 23);
            txtPrijs.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 66);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 15;
            label3.Text = "Minimumvoorraadniveau:";
            // 
            // lblVerkoopprijs
            // 
            lblVerkoopprijs.AutoSize = true;
            lblVerkoopprijs.Location = new Point(426, 34);
            lblVerkoopprijs.Name = "lblVerkoopprijs";
            lblVerkoopprijs.Size = new Size(75, 15);
            lblVerkoopprijs.TabIndex = 14;
            lblVerkoopprijs.Text = "Verkoopprijs:";
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(12, 377);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(108, 47);
            btnTerug.TabIndex = 26;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // FrmPrijszetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTerug);
            Controls.Add(btnBewerken);
            Controls.Add(txtMinimumvoorraadniveau);
            Controls.Add(txtPrijs);
            Controls.Add(label3);
            Controls.Add(lblVerkoopprijs);
            Controls.Add(lstVerkoopArtikels);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrijszetting";
            Text = "FrmPrijszetting";
            Load += FrmPrijszetting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVerkoopArtikels;
        private Button btnBewerken;
        private TextBox txtMinimumvoorraadniveau;
        private TextBox txtPrijs;
        private Label label3;
        private Label lblVerkoopprijs;
        private Button btnTerug;
    }
}