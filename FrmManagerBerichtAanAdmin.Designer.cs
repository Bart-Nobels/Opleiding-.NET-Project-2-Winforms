namespace Project_2__Bart_
{
    partial class FrmManagerBerichtAanAdmin
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
            btnVerzenden = new Button();
            label1 = new Label();
            txtBestandsnaam = new TextBox();
            txtBericht = new TextBox();
            btnTerug = new Button();
            SuspendLayout();
            // 
            // btnVerzenden
            // 
            btnVerzenden.Location = new Point(560, 282);
            btnVerzenden.Margin = new Padding(3, 2, 3, 2);
            btnVerzenden.Name = "btnVerzenden";
            btnVerzenden.Size = new Size(122, 43);
            btnVerzenden.TabIndex = 21;
            btnVerzenden.Text = "Verzenden";
            btnVerzenden.UseVisualStyleBackColor = true;
            btnVerzenden.Click += btnVerzenden_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 296);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 20;
            label1.Text = "Bestandsnaam:";
            // 
            // txtBestandsnaam
            // 
            txtBestandsnaam.Location = new Point(324, 293);
            txtBestandsnaam.Margin = new Padding(3, 2, 3, 2);
            txtBestandsnaam.Name = "txtBestandsnaam";
            txtBestandsnaam.Size = new Size(194, 23);
            txtBestandsnaam.TabIndex = 19;
            // 
            // txtBericht
            // 
            txtBericht.Location = new Point(217, 46);
            txtBericht.Margin = new Padding(3, 2, 3, 2);
            txtBericht.Multiline = true;
            txtBericht.Name = "txtBericht";
            txtBericht.ScrollBars = ScrollBars.Vertical;
            txtBericht.Size = new Size(428, 218);
            txtBericht.TabIndex = 18;
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(24, 282);
            btnTerug.Margin = new Padding(3, 2, 3, 2);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(113, 43);
            btnTerug.TabIndex = 17;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // FrmManagerBerichtAanAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 348);
            Controls.Add(btnVerzenden);
            Controls.Add(label1);
            Controls.Add(txtBestandsnaam);
            Controls.Add(txtBericht);
            Controls.Add(btnTerug);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmManagerBerichtAanAdmin";
            Text = "Bericht Aan Admin";
            Load += FrmManagerBerichtAanAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerzenden;
        private Label label1;
        private TextBox txtBestandsnaam;
        private TextBox txtBericht;
        private Button btnTerug;
    }
}