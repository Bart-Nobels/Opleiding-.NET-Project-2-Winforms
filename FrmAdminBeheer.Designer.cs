namespace Project_2__Bart_
{
    partial class FrmAdminBeheer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminBeheer));
            btnMedewerkersAanmaken = new Button();
            btnMedewerkersBewerken = new Button();
            btnTerug = new Button();
            btnAfdelingAanmaken = new Button();
            btnGegevensVerwijderen = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel7 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnMedewerkersAanmaken
            // 
            btnMedewerkersAanmaken.FlatAppearance.BorderSize = 0;
            btnMedewerkersAanmaken.FlatStyle = FlatStyle.Flat;
            btnMedewerkersAanmaken.Image = (Image)resources.GetObject("btnMedewerkersAanmaken.Image");
            btnMedewerkersAanmaken.ImageAlign = ContentAlignment.MiddleLeft;
            btnMedewerkersAanmaken.Location = new Point(0, 2);
            btnMedewerkersAanmaken.Margin = new Padding(3, 2, 3, 2);
            btnMedewerkersAanmaken.Name = "btnMedewerkersAanmaken";
            btnMedewerkersAanmaken.Size = new Size(225, 48);
            btnMedewerkersAanmaken.TabIndex = 30;
            btnMedewerkersAanmaken.Text = "Medewerkers aanmaken";
            btnMedewerkersAanmaken.UseVisualStyleBackColor = true;
            btnMedewerkersAanmaken.Click += btnMedewerkersAanmaken_Click;
            // 
            // btnMedewerkersBewerken
            // 
            btnMedewerkersBewerken.FlatAppearance.BorderSize = 0;
            btnMedewerkersBewerken.FlatStyle = FlatStyle.Flat;
            btnMedewerkersBewerken.Image = (Image)resources.GetObject("btnMedewerkersBewerken.Image");
            btnMedewerkersBewerken.ImageAlign = ContentAlignment.MiddleLeft;
            btnMedewerkersBewerken.Location = new Point(3, 3);
            btnMedewerkersBewerken.Margin = new Padding(3, 2, 3, 2);
            btnMedewerkersBewerken.Name = "btnMedewerkersBewerken";
            btnMedewerkersBewerken.Size = new Size(211, 48);
            btnMedewerkersBewerken.TabIndex = 29;
            btnMedewerkersBewerken.Text = "Medewerkers bewerken";
            btnMedewerkersBewerken.UseVisualStyleBackColor = true;
            btnMedewerkersBewerken.Click += btnMedewerkersBewerken_Click;
            // 
            // btnTerug
            // 
            btnTerug.FlatAppearance.BorderSize = 0;
            btnTerug.FlatStyle = FlatStyle.Flat;
            btnTerug.Image = (Image)resources.GetObject("btnTerug.Image");
            btnTerug.ImageAlign = ContentAlignment.MiddleLeft;
            btnTerug.Location = new Point(3, 486);
            btnTerug.Margin = new Padding(3, 2, 3, 2);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(192, 43);
            btnTerug.TabIndex = 31;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // btnAfdelingAanmaken
            // 
            btnAfdelingAanmaken.FlatAppearance.BorderSize = 0;
            btnAfdelingAanmaken.FlatStyle = FlatStyle.Flat;
            btnAfdelingAanmaken.Image = (Image)resources.GetObject("btnAfdelingAanmaken.Image");
            btnAfdelingAanmaken.ImageAlign = ContentAlignment.MiddleLeft;
            btnAfdelingAanmaken.Location = new Point(3, 2);
            btnAfdelingAanmaken.Margin = new Padding(3, 2, 3, 2);
            btnAfdelingAanmaken.Name = "btnAfdelingAanmaken";
            btnAfdelingAanmaken.Size = new Size(199, 48);
            btnAfdelingAanmaken.TabIndex = 32;
            btnAfdelingAanmaken.Text = "Afdeling aanmaken";
            btnAfdelingAanmaken.UseVisualStyleBackColor = true;
            btnAfdelingAanmaken.Click += btnAfdelingAanmaken_Click;
            // 
            // btnGegevensVerwijderen
            // 
            btnGegevensVerwijderen.FlatAppearance.BorderSize = 0;
            btnGegevensVerwijderen.FlatStyle = FlatStyle.Flat;
            btnGegevensVerwijderen.Image = (Image)resources.GetObject("btnGegevensVerwijderen.Image");
            btnGegevensVerwijderen.ImageAlign = ContentAlignment.MiddleLeft;
            btnGegevensVerwijderen.Location = new Point(3, 2);
            btnGegevensVerwijderen.Margin = new Padding(3, 2, 3, 2);
            btnGegevensVerwijderen.Name = "btnGegevensVerwijderen";
            btnGegevensVerwijderen.Size = new Size(198, 48);
            btnGegevensVerwijderen.TabIndex = 33;
            btnGegevensVerwijderen.Text = "Gegevens Verwijderen";
            btnGegevensVerwijderen.UseVisualStyleBackColor = true;
            btnGegevensVerwijderen.Click += btnGegevensVerwijderen_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Goldenrod;
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(btnTerug);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 552);
            flowLayoutPanel1.TabIndex = 34;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnAfdelingAanmaken);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(192, 53);
            panel7.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMedewerkersAanmaken);
            panel1.Location = new Point(3, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 53);
            panel1.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnMedewerkersBewerken);
            panel3.Location = new Point(3, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 53);
            panel3.TabIndex = 33;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btnGegevensVerwijderen);
            panel4.Location = new Point(3, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 53);
            panel4.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 57);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 53);
            panel5.TabIndex = 33;
            // 
            // panel6
            // 
            panel6.Location = new Point(3, 239);
            panel6.Name = "panel6";
            panel6.Size = new Size(192, 53);
            panel6.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(3, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 57);
            panel2.TabIndex = 33;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Location = new Point(3, 361);
            panel8.Name = "panel8";
            panel8.Size = new Size(192, 57);
            panel8.TabIndex = 34;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel9.BackColor = Color.Transparent;
            panel9.Location = new Point(3, 424);
            panel9.Name = "panel9";
            panel9.Size = new Size(192, 57);
            panel9.TabIndex = 34;
            // 
            // FrmAdminBeheer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 552);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAdminBeheer";
            Text = "Gegevensbeheer - Admin";
            Load += FrmAdminBeheer_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMedewerkersAanmaken;
        private Button btnMedewerkersBewerken;
        private Button btnTerug;
        private Button btnAfdelingAanmaken;
        private Button btnGegevensVerwijderen;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel7;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel2;
        private Panel panel8;
        private Panel panel9;
        private Panel panel5;
    }
}