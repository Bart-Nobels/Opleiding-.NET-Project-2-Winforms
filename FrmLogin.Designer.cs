namespace Project_2__Bart_
{
    partial class FrmLogin
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
            txtGebruikersnaam = new TextBox();
            txtPaswoord = new TextBox();
            btnAnnuleer = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Gebruikersnaam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 91);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Paswoord:";
            // 
            // txtGebruikersnaam
            // 
            txtGebruikersnaam.Location = new Point(192, 41);
            txtGebruikersnaam.Margin = new Padding(3, 2, 3, 2);
            txtGebruikersnaam.Name = "txtGebruikersnaam";
            txtGebruikersnaam.Size = new Size(217, 23);
            txtGebruikersnaam.TabIndex = 2;
            // 
            // txtPaswoord
            // 
            txtPaswoord.Location = new Point(192, 88);
            txtPaswoord.Margin = new Padding(3, 2, 3, 2);
            txtPaswoord.Name = "txtPaswoord";
            txtPaswoord.PasswordChar = '*';
            txtPaswoord.Size = new Size(217, 23);
            txtPaswoord.TabIndex = 3;
            // 
            // btnAnnuleer
            // 
            btnAnnuleer.Location = new Point(59, 153);
            btnAnnuleer.Margin = new Padding(3, 2, 3, 2);
            btnAnnuleer.Name = "btnAnnuleer";
            btnAnnuleer.Size = new Size(135, 44);
            btnAnnuleer.TabIndex = 4;
            btnAnnuleer.Text = "Annuleer";
            btnAnnuleer.UseVisualStyleBackColor = true;
            btnAnnuleer.Click += btnAnnuleer_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(274, 153);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(135, 44);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 230);
            Controls.Add(btnOK);
            Controls.Add(btnAnnuleer);
            Controls.Add(txtPaswoord);
            Controls.Add(txtGebruikersnaam);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGebruikersnaam;
        private TextBox txtPaswoord;
        private Button btnAnnuleer;
        private Button btnOK;
    }
}