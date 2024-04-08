namespace Project_2__Bart_
{
    partial class FrmVerkoop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerkoop));
            btnKassa = new Button();
            BtnOverzichtVerkoop = new Button();
            btnKlantenbeheer = new Button();
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
            btnTerug = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnKassa
            // 
            btnKassa.FlatAppearance.BorderSize = 0;
            btnKassa.FlatStyle = FlatStyle.Flat;
            btnKassa.Image = (Image)resources.GetObject("btnKassa.Image");
            btnKassa.ImageAlign = ContentAlignment.MiddleLeft;
            btnKassa.Location = new Point(0, 2);
            btnKassa.Margin = new Padding(3, 2, 3, 2);
            btnKassa.Name = "btnKassa";
            btnKassa.Size = new Size(192, 53);
            btnKassa.TabIndex = 6;
            btnKassa.Text = "Kassa";
            btnKassa.UseVisualStyleBackColor = true;
            btnKassa.Click += btnKassa_Click;
            // 
            // BtnOverzichtVerkoop
            // 
            BtnOverzichtVerkoop.FlatAppearance.BorderSize = 0;
            BtnOverzichtVerkoop.FlatStyle = FlatStyle.Flat;
            BtnOverzichtVerkoop.Image = (Image)resources.GetObject("BtnOverzichtVerkoop.Image");
            BtnOverzichtVerkoop.ImageAlign = ContentAlignment.MiddleLeft;
            BtnOverzichtVerkoop.Location = new Point(0, -2);
            BtnOverzichtVerkoop.Margin = new Padding(3, 2, 3, 2);
            BtnOverzichtVerkoop.Name = "BtnOverzichtVerkoop";
            BtnOverzichtVerkoop.Size = new Size(192, 53);
            BtnOverzichtVerkoop.TabIndex = 5;
            BtnOverzichtVerkoop.Text = "Overzicht";
            BtnOverzichtVerkoop.UseVisualStyleBackColor = true;
            BtnOverzichtVerkoop.Click += BtnOverzichtVerkoop_Click;
            // 
            // btnKlantenbeheer
            // 
            btnKlantenbeheer.FlatAppearance.BorderSize = 0;
            btnKlantenbeheer.FlatStyle = FlatStyle.Flat;
            btnKlantenbeheer.Image = (Image)resources.GetObject("btnKlantenbeheer.Image");
            btnKlantenbeheer.ImageAlign = ContentAlignment.MiddleLeft;
            btnKlantenbeheer.Location = new Point(0, 2);
            btnKlantenbeheer.Margin = new Padding(3, 2, 3, 2);
            btnKlantenbeheer.Name = "btnKlantenbeheer";
            btnKlantenbeheer.Size = new Size(205, 53);
            btnKlantenbeheer.TabIndex = 9;
            btnKlantenbeheer.Text = "Klantenbeheer";
            btnKlantenbeheer.UseVisualStyleBackColor = true;
            btnKlantenbeheer.Click += btnKlantenbeheer_Click;
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
            flowLayoutPanel1.Size = new Size(200, 572);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // panel7
            // 
            panel7.Controls.Add(BtnOverzichtVerkoop);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(192, 53);
            panel7.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKassa);
            panel1.Location = new Point(3, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 53);
            panel1.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnKlantenbeheer);
            panel3.Location = new Point(3, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 53);
            panel3.TabIndex = 33;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
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
            panel2.BackColor = Color.Goldenrod;
            panel2.Location = new Point(3, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 57);
            panel2.TabIndex = 33;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Goldenrod;
            panel8.Location = new Point(3, 361);
            panel8.Name = "panel8";
            panel8.Size = new Size(192, 57);
            panel8.TabIndex = 34;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel9.BackColor = Color.Goldenrod;
            panel9.Location = new Point(3, 424);
            panel9.Name = "panel9";
            panel9.Size = new Size(192, 57);
            panel9.TabIndex = 34;
            // 
            // btnTerug
            // 
            btnTerug.BackColor = Color.Goldenrod;
            btnTerug.FlatAppearance.BorderSize = 0;
            btnTerug.FlatStyle = FlatStyle.Flat;
            btnTerug.Image = (Image)resources.GetObject("btnTerug.Image");
            btnTerug.ImageAlign = ContentAlignment.MiddleLeft;
            btnTerug.Location = new Point(3, 486);
            btnTerug.Margin = new Padding(3, 2, 3, 2);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(192, 43);
            btnTerug.TabIndex = 33;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = false;
            btnTerug.Click += btnTerug_Click;
            // 
            // FrmVerkoop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 572);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmVerkoop";
            Text = "Verkoop";
            Load += FrmVerkoop_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnKassa;
        private Button BtnOverzichtVerkoop;
        private Button btnKlantenbeheer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel7;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel2;
        private Panel panel8;
        private Panel panel9;
        private Button btnTerug;
    }
}