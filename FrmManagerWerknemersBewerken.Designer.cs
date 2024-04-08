namespace Project_2__Bart_
{
    partial class FrmManagerWerknemersBewerken
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
            lstWerknemers = new ListBox();
            groupBox1 = new GroupBox();
            cbJSONEncrypteren = new CheckBox();
            cbJSONLezen = new CheckBox();
            cbJSONAanmaken = new CheckBox();
            cbJSONBewerken = new CheckBox();
            cbTXTEncrypteren = new CheckBox();
            cbTXTLezen = new CheckBox();
            cbTXTAanmaken = new CheckBox();
            cbTXTBewerken = new CheckBox();
            cbXMLEncrypteren = new CheckBox();
            cbXMLLezen = new CheckBox();
            cbXMLAanmaken = new CheckBox();
            cbXMLBewerken = new CheckBox();
            groupBox2 = new GroupBox();
            txtGebruikersrol = new TextBox();
            label2 = new Label();
            txtLoonGebruiker = new TextBox();
            txtRekeningnummerGebruiker = new TextBox();
            txtTelefoonnummerGebruiker = new TextBox();
            txtAdresGebruiker = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtVoornaamGebruiker = new TextBox();
            txtNaamGebruiker = new TextBox();
            btnBewerken = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(11, 693);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(129, 57);
            btnTerug.TabIndex = 18;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // lstWerknemers
            // 
            lstWerknemers.FormattingEnabled = true;
            lstWerknemers.ItemHeight = 20;
            lstWerknemers.Location = new Point(209, 57);
            lstWerknemers.Name = "lstWerknemers";
            lstWerknemers.Size = new Size(427, 364);
            lstWerknemers.TabIndex = 19;
            lstWerknemers.SelectedIndexChanged += lstWerknemers_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbJSONEncrypteren);
            groupBox1.Controls.Add(cbJSONLezen);
            groupBox1.Controls.Add(cbJSONAanmaken);
            groupBox1.Controls.Add(cbJSONBewerken);
            groupBox1.Controls.Add(cbTXTEncrypteren);
            groupBox1.Controls.Add(cbTXTLezen);
            groupBox1.Controls.Add(cbTXTAanmaken);
            groupBox1.Controls.Add(cbTXTBewerken);
            groupBox1.Controls.Add(cbXMLEncrypteren);
            groupBox1.Controls.Add(cbXMLLezen);
            groupBox1.Controls.Add(cbXMLAanmaken);
            groupBox1.Controls.Add(cbXMLBewerken);
            groupBox1.Location = new Point(209, 491);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 247);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gebruikersrechten:";
            // 
            // cbJSONEncrypteren
            // 
            cbJSONEncrypteren.AutoSize = true;
            cbJSONEncrypteren.Location = new Point(241, 191);
            cbJSONEncrypteren.Name = "cbJSONEncrypteren";
            cbJSONEncrypteren.Size = new Size(177, 24);
            cbJSONEncrypteren.TabIndex = 17;
            cbJSONEncrypteren.Text = "Kan JSON Encrypteren";
            cbJSONEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbJSONLezen
            // 
            cbJSONLezen.AutoSize = true;
            cbJSONLezen.Location = new Point(241, 161);
            cbJSONLezen.Name = "cbJSONLezen";
            cbJSONLezen.Size = new Size(137, 24);
            cbJSONLezen.TabIndex = 16;
            cbJSONLezen.Text = "Kan JSON Lezen";
            cbJSONLezen.UseVisualStyleBackColor = true;
            // 
            // cbJSONAanmaken
            // 
            cbJSONAanmaken.AutoSize = true;
            cbJSONAanmaken.Location = new Point(241, 131);
            cbJSONAanmaken.Name = "cbJSONAanmaken";
            cbJSONAanmaken.Size = new Size(169, 24);
            cbJSONAanmaken.TabIndex = 15;
            cbJSONAanmaken.Text = "Kan JSON Aanmaken";
            cbJSONAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbJSONBewerken
            // 
            cbJSONBewerken.AutoSize = true;
            cbJSONBewerken.Location = new Point(241, 101);
            cbJSONBewerken.Name = "cbJSONBewerken";
            cbJSONBewerken.Size = new Size(163, 24);
            cbJSONBewerken.TabIndex = 14;
            cbJSONBewerken.Text = "Kan JSON Bewerken";
            cbJSONBewerken.UseVisualStyleBackColor = true;
            // 
            // cbTXTEncrypteren
            // 
            cbTXTEncrypteren.AutoSize = true;
            cbTXTEncrypteren.Location = new Point(241, 71);
            cbTXTEncrypteren.Name = "cbTXTEncrypteren";
            cbTXTEncrypteren.Size = new Size(167, 24);
            cbTXTEncrypteren.TabIndex = 13;
            cbTXTEncrypteren.Text = "Kan TXT Encrypteren";
            cbTXTEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbTXTLezen
            // 
            cbTXTLezen.AutoSize = true;
            cbTXTLezen.Location = new Point(241, 41);
            cbTXTLezen.Name = "cbTXTLezen";
            cbTXTLezen.Size = new Size(127, 24);
            cbTXTLezen.TabIndex = 12;
            cbTXTLezen.Text = "Kan TXT Lezen";
            cbTXTLezen.UseVisualStyleBackColor = true;
            // 
            // cbTXTAanmaken
            // 
            cbTXTAanmaken.AutoSize = true;
            cbTXTAanmaken.Location = new Point(17, 191);
            cbTXTAanmaken.Name = "cbTXTAanmaken";
            cbTXTAanmaken.Size = new Size(159, 24);
            cbTXTAanmaken.TabIndex = 11;
            cbTXTAanmaken.Text = "Kan TXT Aanmaken";
            cbTXTAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbTXTBewerken
            // 
            cbTXTBewerken.AutoSize = true;
            cbTXTBewerken.Location = new Point(17, 161);
            cbTXTBewerken.Name = "cbTXTBewerken";
            cbTXTBewerken.Size = new Size(153, 24);
            cbTXTBewerken.TabIndex = 10;
            cbTXTBewerken.Text = "Kan TXT Bewerken";
            cbTXTBewerken.UseVisualStyleBackColor = true;
            // 
            // cbXMLEncrypteren
            // 
            cbXMLEncrypteren.AutoSize = true;
            cbXMLEncrypteren.Location = new Point(17, 131);
            cbXMLEncrypteren.Name = "cbXMLEncrypteren";
            cbXMLEncrypteren.Size = new Size(171, 24);
            cbXMLEncrypteren.TabIndex = 9;
            cbXMLEncrypteren.Text = "Kan XML Encrypteren";
            cbXMLEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cbXMLLezen
            // 
            cbXMLLezen.AutoSize = true;
            cbXMLLezen.Location = new Point(17, 101);
            cbXMLLezen.Name = "cbXMLLezen";
            cbXMLLezen.Size = new Size(131, 24);
            cbXMLLezen.TabIndex = 8;
            cbXMLLezen.Text = "Kan XML Lezen";
            cbXMLLezen.UseVisualStyleBackColor = true;
            // 
            // cbXMLAanmaken
            // 
            cbXMLAanmaken.AutoSize = true;
            cbXMLAanmaken.Location = new Point(17, 71);
            cbXMLAanmaken.Name = "cbXMLAanmaken";
            cbXMLAanmaken.Size = new Size(163, 24);
            cbXMLAanmaken.TabIndex = 7;
            cbXMLAanmaken.Text = "Kan XML Aanmaken";
            cbXMLAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbXMLBewerken
            // 
            cbXMLBewerken.AutoSize = true;
            cbXMLBewerken.Location = new Point(17, 41);
            cbXMLBewerken.Name = "cbXMLBewerken";
            cbXMLBewerken.Size = new Size(157, 24);
            cbXMLBewerken.TabIndex = 6;
            cbXMLBewerken.Text = "Kan XML Bewerken";
            cbXMLBewerken.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGebruikersrol);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtLoonGebruiker);
            groupBox2.Controls.Add(txtRekeningnummerGebruiker);
            groupBox2.Controls.Add(txtTelefoonnummerGebruiker);
            groupBox2.Controls.Add(txtAdresGebruiker);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtVoornaamGebruiker);
            groupBox2.Controls.Add(txtNaamGebruiker);
            groupBox2.Location = new Point(675, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 364);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Werknemersgegevens:";
            // 
            // txtGebruikersrol
            // 
            txtGebruikersrol.Location = new Point(159, 53);
            txtGebruikersrol.Name = "txtGebruikersrol";
            txtGebruikersrol.ReadOnly = true;
            txtGebruikersrol.Size = new Size(341, 27);
            txtGebruikersrol.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 56;
            label2.Text = "Gebruikersrol:";
            // 
            // txtLoonGebruiker
            // 
            txtLoonGebruiker.Location = new Point(159, 252);
            txtLoonGebruiker.Name = "txtLoonGebruiker";
            txtLoonGebruiker.Size = new Size(341, 27);
            txtLoonGebruiker.TabIndex = 55;
            // 
            // txtRekeningnummerGebruiker
            // 
            txtRekeningnummerGebruiker.Location = new Point(159, 219);
            txtRekeningnummerGebruiker.Name = "txtRekeningnummerGebruiker";
            txtRekeningnummerGebruiker.Size = new Size(341, 27);
            txtRekeningnummerGebruiker.TabIndex = 54;
            // 
            // txtTelefoonnummerGebruiker
            // 
            txtTelefoonnummerGebruiker.Location = new Point(159, 187);
            txtTelefoonnummerGebruiker.Name = "txtTelefoonnummerGebruiker";
            txtTelefoonnummerGebruiker.Size = new Size(341, 27);
            txtTelefoonnummerGebruiker.TabIndex = 53;
            // 
            // txtAdresGebruiker
            // 
            txtAdresGebruiker.Location = new Point(159, 153);
            txtAdresGebruiker.Name = "txtAdresGebruiker";
            txtAdresGebruiker.Size = new Size(341, 27);
            txtAdresGebruiker.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 255);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 51;
            label10.Text = "Loon:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 221);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 50;
            label9.Text = "Rekeningnummer:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 189);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 49;
            label8.Text = "Telefoonnummer:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 156);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 48;
            label7.Text = "Adres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 123);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 36;
            label4.Text = "Voornaam:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 91);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 35;
            label3.Text = "Naam:";
            // 
            // txtVoornaamGebruiker
            // 
            txtVoornaamGebruiker.Location = new Point(159, 120);
            txtVoornaamGebruiker.Name = "txtVoornaamGebruiker";
            txtVoornaamGebruiker.Size = new Size(341, 27);
            txtVoornaamGebruiker.TabIndex = 38;
            // 
            // txtNaamGebruiker
            // 
            txtNaamGebruiker.Location = new Point(159, 87);
            txtNaamGebruiker.Name = "txtNaamGebruiker";
            txtNaamGebruiker.Size = new Size(341, 27);
            txtNaamGebruiker.TabIndex = 37;
            // 
            // btnBewerken
            // 
            btnBewerken.Location = new Point(1061, 680);
            btnBewerken.Name = "btnBewerken";
            btnBewerken.Size = new Size(129, 57);
            btnBewerken.TabIndex = 22;
            btnBewerken.Text = "Bewerken";
            btnBewerken.UseVisualStyleBackColor = true;
            btnBewerken.Click += btnBewerken_Click;
            // 
            // FrmManagerWerknemersBewerken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 763);
            Controls.Add(btnBewerken);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstWerknemers);
            Controls.Add(btnTerug);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmManagerWerknemersBewerken";
            Text = "Werknemers Bewerken";
            Load += FrmManagerWerknemersBewerken_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTerug;
        private ListBox lstWerknemers;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnBewerken;
        private CheckBox cbJSONEncrypteren;
        private CheckBox cbJSONLezen;
        private CheckBox cbJSONAanmaken;
        private CheckBox cbJSONBewerken;
        private CheckBox cbTXTEncrypteren;
        private CheckBox cbTXTLezen;
        private CheckBox cbTXTAanmaken;
        private CheckBox cbTXTBewerken;
        private CheckBox cbXMLEncrypteren;
        private CheckBox cbXMLLezen;
        private CheckBox cbXMLAanmaken;
        private CheckBox cbXMLBewerken;
        private Label label4;
        private Label label3;
        private TextBox txtVoornaamGebruiker;
        private TextBox txtNaamGebruiker;
        private TextBox txtLoonGebruiker;
        private TextBox txtRekeningnummerGebruiker;
        private TextBox txtTelefoonnummerGebruiker;
        private TextBox txtAdresGebruiker;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtGebruikersrol;
        private Label label2;
    }
}