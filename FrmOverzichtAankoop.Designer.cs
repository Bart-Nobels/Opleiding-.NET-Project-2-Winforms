namespace Project_2__Bart_
{
    partial class FrmOverzichtAankoop
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
            btnTerugOverzichtAankoop = new Button();
            groupBox1 = new GroupBox();
            rdoLeveranciers = new RadioButton();
            rdoAankoopFacturen = new RadioButton();
            rdoArtikelsInStock = new RadioButton();
            btnWeergevenOverzichtAankoop = new Button();
            txtWeergave = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTerugOverzichtAankoop
            // 
            btnTerugOverzichtAankoop.Location = new Point(24, 377);
            btnTerugOverzichtAankoop.Margin = new Padding(3, 2, 3, 2);
            btnTerugOverzichtAankoop.Name = "btnTerugOverzichtAankoop";
            btnTerugOverzichtAankoop.Size = new Size(108, 38);
            btnTerugOverzichtAankoop.TabIndex = 0;
            btnTerugOverzichtAankoop.Text = "Terug";
            btnTerugOverzichtAankoop.UseVisualStyleBackColor = true;
            btnTerugOverzichtAankoop.Click += btnTerugOverzichtAankoop_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoLeveranciers);
            groupBox1.Controls.Add(rdoAankoopFacturen);
            groupBox1.Controls.Add(rdoArtikelsInStock);
            groupBox1.Location = new Point(236, 23);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(228, 105);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Overzicht:";
            // 
            // rdoLeveranciers
            // 
            rdoLeveranciers.AutoSize = true;
            rdoLeveranciers.Location = new Point(14, 71);
            rdoLeveranciers.Margin = new Padding(3, 2, 3, 2);
            rdoLeveranciers.Name = "rdoLeveranciers";
            rdoLeveranciers.Size = new Size(90, 19);
            rdoLeveranciers.TabIndex = 2;
            rdoLeveranciers.TabStop = true;
            rdoLeveranciers.Text = "Leveranciers";
            rdoLeveranciers.UseVisualStyleBackColor = true;
            // 
            // rdoAankoopFacturen
            // 
            rdoAankoopFacturen.AutoSize = true;
            rdoAankoopFacturen.Location = new Point(14, 50);
            rdoAankoopFacturen.Margin = new Padding(3, 2, 3, 2);
            rdoAankoopFacturen.Name = "rdoAankoopFacturen";
            rdoAankoopFacturen.Size = new Size(117, 19);
            rdoAankoopFacturen.TabIndex = 1;
            rdoAankoopFacturen.TabStop = true;
            rdoAankoopFacturen.Text = "Aankoopfacturen";
            rdoAankoopFacturen.UseVisualStyleBackColor = true;
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
            // btnWeergevenOverzichtAankoop
            // 
            btnWeergevenOverzichtAankoop.Location = new Point(589, 50);
            btnWeergevenOverzichtAankoop.Margin = new Padding(3, 2, 3, 2);
            btnWeergevenOverzichtAankoop.Name = "btnWeergevenOverzichtAankoop";
            btnWeergevenOverzichtAankoop.Size = new Size(146, 49);
            btnWeergevenOverzichtAankoop.TabIndex = 2;
            btnWeergevenOverzichtAankoop.Text = "Weergeven";
            btnWeergevenOverzichtAankoop.UseVisualStyleBackColor = true;
            btnWeergevenOverzichtAankoop.Click += btnWeergevenOverzichtAankoop_Click;
            // 
            // txtWeergave
            // 
            txtWeergave.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtWeergave.Location = new Point(236, 152);
            txtWeergave.Margin = new Padding(3, 2, 3, 2);
            txtWeergave.Multiline = true;
            txtWeergave.Name = "txtWeergave";
            txtWeergave.ReadOnly = true;
            txtWeergave.ScrollBars = ScrollBars.Both;
            txtWeergave.Size = new Size(499, 239);
            txtWeergave.TabIndex = 3;
            txtWeergave.WordWrap = false;
            txtWeergave.TextChanged += txtWeergave_TextChanged;
            // 
            // FrmOverzichtAankoop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 429);
            Controls.Add(txtWeergave);
            Controls.Add(btnWeergevenOverzichtAankoop);
            Controls.Add(groupBox1);
            Controls.Add(btnTerugOverzichtAankoop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmOverzichtAankoop";
            Text = "Overzicht";
            Load += FrmOverzichtAankoop_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTerugOverzichtAankoop;
        private GroupBox groupBox1;
        private RadioButton rdoLeveranciers;
        private RadioButton rdoAankoopFacturen;
        private RadioButton rdoArtikelsInStock;
        private Button btnWeergevenOverzichtAankoop;
        private TextBox txtWeergave;
    }
}