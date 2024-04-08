namespace Project_2__Bart_.Kassa
{
    partial class NieuweKlant
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNaam = new TextBox();
            txtAdres = new TextBox();
            txtTelefoon = new TextBox();
            txtEmail = new TextBox();
            btnAanmaken = new Button();
            btnAnnuleren = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 0;
            label1.Text = "Naam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 1;
            label2.Text = "Adres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 2;
            label3.Text = "Telefoon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 170);
            label4.Name = "label4";
            label4.Size = new Size(80, 30);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(125, 38);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(431, 23);
            txtNaam.TabIndex = 4;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(125, 87);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(431, 23);
            txtAdres.TabIndex = 5;
            // 
            // txtTelefoon
            // 
            txtTelefoon.Location = new Point(125, 133);
            txtTelefoon.Name = "txtTelefoon";
            txtTelefoon.Size = new Size(431, 23);
            txtTelefoon.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(431, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnAanmaken
            // 
            btnAanmaken.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAanmaken.Location = new Point(12, 231);
            btnAanmaken.Name = "btnAanmaken";
            btnAanmaken.Size = new Size(152, 58);
            btnAanmaken.TabIndex = 8;
            btnAanmaken.Text = "Aanmaken";
            btnAanmaken.UseVisualStyleBackColor = true;
            btnAanmaken.Click += btnAanmaken_Click;
            // 
            // btnAnnuleren
            // 
            btnAnnuleren.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnnuleren.Location = new Point(404, 231);
            btnAnnuleren.Name = "btnAnnuleren";
            btnAnnuleren.Size = new Size(152, 58);
            btnAnnuleren.TabIndex = 9;
            btnAnnuleren.Text = "Annuleren";
            btnAnnuleren.UseVisualStyleBackColor = true;
            btnAnnuleren.Click += btnAnnuleren_Click;
            // 
            // NieuweKlant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 319);
            Controls.Add(btnAnnuleren);
            Controls.Add(btnAanmaken);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefoon);
            Controls.Add(txtAdres);
            Controls.Add(txtNaam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NieuweKlant";
            Text = "NieuweKlant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNaam;
        private TextBox txtAdres;
        private TextBox txtTelefoon;
        private TextBox txtEmail;
        private Button btnAanmaken;
        private Button btnAnnuleren;
    }
}