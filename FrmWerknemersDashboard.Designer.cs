﻿namespace Project_2__Bart_
{
    partial class FrmWerknemersDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWerknemersDashboard));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel7 = new Panel();
            BtnPersoonlijkeInfo = new Button();
            panel1 = new Panel();
            btnVerslagen = new Button();
            panel3 = new Panel();
            btnVerkoop = new Button();
            panel4 = new Panel();
            btnAankoop = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            btnAfmelden = new Button();
            Header = new Panel();
            Controlbox = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            Header.SuspendLayout();
            Controlbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkGoldenrod;
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(btnAfmelden);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 62);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 893);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // panel7
            // 
            panel7.Controls.Add(BtnPersoonlijkeInfo);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(192, 53);
            panel7.TabIndex = 33;
            // 
            // BtnPersoonlijkeInfo
            // 
            BtnPersoonlijkeInfo.FlatAppearance.BorderSize = 0;
            BtnPersoonlijkeInfo.FlatStyle = FlatStyle.Flat;
            BtnPersoonlijkeInfo.Image = (Image)resources.GetObject("BtnPersoonlijkeInfo.Image");
            BtnPersoonlijkeInfo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPersoonlijkeInfo.Location = new Point(-3, 0);
            BtnPersoonlijkeInfo.Margin = new Padding(3, 2, 3, 2);
            BtnPersoonlijkeInfo.Name = "BtnPersoonlijkeInfo";
            BtnPersoonlijkeInfo.Size = new Size(200, 53);
            BtnPersoonlijkeInfo.TabIndex = 14;
            BtnPersoonlijkeInfo.Text = "Persoonlijke info";
            BtnPersoonlijkeInfo.UseVisualStyleBackColor = true;
            BtnPersoonlijkeInfo.Click += BtnPersoonlijkeInfo_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVerslagen);
            panel1.Location = new Point(3, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 53);
            panel1.TabIndex = 32;
            // 
            // btnVerslagen
            // 
            btnVerslagen.FlatAppearance.BorderSize = 0;
            btnVerslagen.FlatStyle = FlatStyle.Flat;
            btnVerslagen.Image = (Image)resources.GetObject("btnVerslagen.Image");
            btnVerslagen.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerslagen.Location = new Point(0, 2);
            btnVerslagen.Margin = new Padding(3, 2, 3, 2);
            btnVerslagen.Name = "btnVerslagen";
            btnVerslagen.Size = new Size(197, 53);
            btnVerslagen.TabIndex = 18;
            btnVerslagen.Text = "Verslagen";
            btnVerslagen.UseVisualStyleBackColor = true;
            btnVerslagen.Click += btnVerslagen_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVerkoop);
            panel3.Location = new Point(3, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 53);
            panel3.TabIndex = 33;
            // 
            // btnVerkoop
            // 
            btnVerkoop.FlatAppearance.BorderSize = 0;
            btnVerkoop.FlatStyle = FlatStyle.Flat;
            btnVerkoop.Image = (Image)resources.GetObject("btnVerkoop.Image");
            btnVerkoop.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerkoop.Location = new Point(-3, 2);
            btnVerkoop.Margin = new Padding(3, 2, 3, 2);
            btnVerkoop.Name = "btnVerkoop";
            btnVerkoop.Size = new Size(197, 53);
            btnVerkoop.TabIndex = 15;
            btnVerkoop.Text = "Verkoop";
            btnVerkoop.UseVisualStyleBackColor = true;
            btnVerkoop.Click += btnVerkoop_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAankoop);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(3, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 53);
            panel4.TabIndex = 33;
            // 
            // btnAankoop
            // 
            btnAankoop.FlatAppearance.BorderSize = 0;
            btnAankoop.FlatStyle = FlatStyle.Flat;
            btnAankoop.Image = (Image)resources.GetObject("btnAankoop.Image");
            btnAankoop.ImageAlign = ContentAlignment.MiddleLeft;
            btnAankoop.Location = new Point(-3, 0);
            btnAankoop.Margin = new Padding(3, 2, 3, 2);
            btnAankoop.Name = "btnAankoop";
            btnAankoop.Size = new Size(192, 53);
            btnAankoop.TabIndex = 17;
            btnAankoop.Text = "Aankoop";
            btnAankoop.UseVisualStyleBackColor = true;
            btnAankoop.Click += btnAankoop_Click;
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
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.Location = new Point(3, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 57);
            panel2.TabIndex = 33;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkGoldenrod;
            panel8.Location = new Point(3, 361);
            panel8.Name = "panel8";
            panel8.Size = new Size(192, 57);
            panel8.TabIndex = 34;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel9.BackColor = Color.DarkGoldenrod;
            panel9.Location = new Point(3, 424);
            panel9.Name = "panel9";
            panel9.Size = new Size(192, 57);
            panel9.TabIndex = 34;
            // 
            // btnAfmelden
            // 
            btnAfmelden.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAfmelden.FlatAppearance.BorderSize = 0;
            btnAfmelden.FlatStyle = FlatStyle.Flat;
            btnAfmelden.Image = (Image)resources.GetObject("btnAfmelden.Image");
            btnAfmelden.ImageAlign = ContentAlignment.MiddleLeft;
            btnAfmelden.Location = new Point(3, 486);
            btnAfmelden.Margin = new Padding(3, 2, 3, 2);
            btnAfmelden.Name = "btnAfmelden";
            btnAfmelden.Size = new Size(183, 53);
            btnAfmelden.TabIndex = 23;
            btnAfmelden.Text = "Afmelden";
            btnAfmelden.UseVisualStyleBackColor = true;
            btnAfmelden.Click += btnAfmelden_Click;
            // 
            // Header
            // 
            Header.BackColor = Color.PaleGoldenrod;
            Header.Controls.Add(Controlbox);
            Header.Controls.Add(label1);
            Header.Controls.Add(pictureBox1);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(1555, 62);
            Header.TabIndex = 34;
            Header.MouseDown += FormMain_MouseDown;
            Header.MouseMove += FormMain_MouseMove;
            Header.MouseUp += FormMain_MouseUp;
            // 
            // Controlbox
            // 
            Controlbox.Controls.Add(btnClose);
            Controlbox.Controls.Add(btnMaximize);
            Controlbox.Controls.Add(btnMinimize);
            Controlbox.Dock = DockStyle.Right;
            Controlbox.Location = new Point(1355, 0);
            Controlbox.Name = "Controlbox";
            Controlbox.Size = new Size(200, 62);
            Controlbox.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(154, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 36);
            btnClose.TabIndex = 31;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(114, 9);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 36);
            btnMaximize.TabIndex = 31;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click_1;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(74, 9);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 36);
            btnMinimize.TabIndex = 0;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 1;
            label1.Text = "Bools and Booze";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmWerknemersDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 955);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmWerknemersDashboard";
            Text = "Dashboard Werknemer";
            Load += FrmWerknemersDashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            Header.ResumeLayout(false);
            Header.PerformLayout();
            Controlbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel7;
        private Button BtnPersoonlijkeInfo;
        private Panel panel1;
        private Button btnVerslagen;
        private Panel panel3;
        private Button btnVerkoop;
        private Panel panel4;
        private Button btnAankoop;
        private Panel panel5;
        private Panel panel6;
        private Panel panel2;
        private Panel panel8;
        private Panel panel9;
        private Button btnAfmelden;
        private Panel Header;
        private Panel Controlbox;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Label label1;
        private PictureBox pictureBox1;
    }
}