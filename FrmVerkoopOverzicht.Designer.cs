namespace Project_2__Bart_
{
    partial class FrmVerkoopOverzicht
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
            txtWeergave = new TextBox();
            btnWeergeven = new Button();
            groupBox1 = new GroupBox();
            rdoKlanten = new RadioButton();
            rdoVerkoopFacturen = new RadioButton();
            rdoArtikelsInStock = new RadioButton();
            btnTerug = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtWeergave
            // 
            txtWeergave.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWeergave.Location = new Point(256, 162);
            txtWeergave.Margin = new Padding(3, 2, 3, 2);
            txtWeergave.Multiline = true;
            txtWeergave.Name = "txtWeergave";
            txtWeergave.ReadOnly = true;
            txtWeergave.ScrollBars = ScrollBars.Both;
            txtWeergave.Size = new Size(494, 239);
            txtWeergave.TabIndex = 7;
            txtWeergave.WordWrap = false;
            // 
            // btnWeergeven
            // 
            btnWeergeven.Location = new Point(608, 61);
            btnWeergeven.Margin = new Padding(3, 2, 3, 2);
            btnWeergeven.Name = "btnWeergeven";
            btnWeergeven.Size = new Size(142, 49);
            btnWeergeven.TabIndex = 6;
            btnWeergeven.Text = "Weergeven";
            btnWeergeven.UseVisualStyleBackColor = true;
            btnWeergeven.Click += btnWeergeven_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoKlanten);
            groupBox1.Controls.Add(rdoVerkoopFacturen);
            groupBox1.Controls.Add(rdoArtikelsInStock);
            groupBox1.Location = new Point(256, 34);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(228, 105);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Overzicht:";
            // 
            // rdoKlanten
            // 
            rdoKlanten.AutoSize = true;
            rdoKlanten.Location = new Point(14, 71);
            rdoKlanten.Margin = new Padding(3, 2, 3, 2);
            rdoKlanten.Name = "rdoKlanten";
            rdoKlanten.Size = new Size(65, 19);
            rdoKlanten.TabIndex = 2;
            rdoKlanten.TabStop = true;
            rdoKlanten.Text = "Klanten";
            rdoKlanten.UseVisualStyleBackColor = true;
            // 
            // rdoVerkoopFacturen
            // 
            rdoVerkoopFacturen.AutoSize = true;
            rdoVerkoopFacturen.Location = new Point(14, 50);
            rdoVerkoopFacturen.Margin = new Padding(3, 2, 3, 2);
            rdoVerkoopFacturen.Name = "rdoVerkoopFacturen";
            rdoVerkoopFacturen.Size = new Size(112, 19);
            rdoVerkoopFacturen.TabIndex = 1;
            rdoVerkoopFacturen.TabStop = true;
            rdoVerkoopFacturen.Text = "Verkoopfacturen";
            rdoVerkoopFacturen.UseVisualStyleBackColor = true;
            // 
            // rdoArtikelsInStock
            // 
            rdoArtikelsInStock.AutoSize = true;
            rdoArtikelsInStock.Location = new Point(14, 27);
            rdoArtikelsInStock.Margin = new Padding(3, 2, 3, 2);
            rdoArtikelsInStock.Name = "rdoArtikelsInStock";
            rdoArtikelsInStock.Size = new Size(108, 19);
            rdoArtikelsInStock.TabIndex = 0;
            rdoArtikelsInStock.TabStop = true;
            rdoArtikelsInStock.Text = "Artikels in stock";
            rdoArtikelsInStock.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(44, 388);
            btnTerug.Margin = new Padding(3, 2, 3, 2);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(108, 38);
            btnTerug.TabIndex = 4;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // FrmVerkoopOverzicht
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 460);
            Controls.Add(txtWeergave);
            Controls.Add(btnWeergeven);
            Controls.Add(groupBox1);
            Controls.Add(btnTerug);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmVerkoopOverzicht";
            Text = "Overzicht";
            Load += FrmVerkoopOverzicht_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWeergave;
        private Button btnWeergeven;
        private GroupBox groupBox1;
        private RadioButton rdoKlanten;
        private RadioButton rdoVerkoopFacturen;
        private RadioButton rdoArtikelsInStock;
        private Button btnTerug;
    }
}