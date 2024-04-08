namespace Project_2__Bart_
{
    partial class FrmLeveringenAankoop
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
            btnTerugLeveringenAankoop = new Button();
            btnZoekenLeveringenAankoop = new Button();
            txtBestandsNaamLeveringenAankoop = new TextBox();
            txtOutput = new TextBox();
            btnVerwerkenLeveringenAankoop = new Button();
            groupBox1 = new GroupBox();
            rdoXMLLeveringenAankoop = new RadioButton();
            rdoJSONLeveringenAankoop = new RadioButton();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtTotaalsaldoLevering = new TextBox();
            txtNaamLeverancier = new TextBox();
            btnFormulierLeegmaken = new Button();
            label3 = new Label();
            cmbPlaatsInWarenhuis = new ComboBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnTerugLeveringenAankoop
            // 
            btnTerugLeveringenAankoop.Location = new Point(10, 475);
            btnTerugLeveringenAankoop.Margin = new Padding(3, 2, 3, 2);
            btnTerugLeveringenAankoop.Name = "btnTerugLeveringenAankoop";
            btnTerugLeveringenAankoop.Size = new Size(132, 38);
            btnTerugLeveringenAankoop.TabIndex = 0;
            btnTerugLeveringenAankoop.Text = "Terug";
            btnTerugLeveringenAankoop.UseVisualStyleBackColor = true;
            btnTerugLeveringenAankoop.Click += btnTerugLeveringenAankoop_Click;
            // 
            // btnZoekenLeveringenAankoop
            // 
            btnZoekenLeveringenAankoop.Location = new Point(5, 22);
            btnZoekenLeveringenAankoop.Margin = new Padding(3, 2, 3, 2);
            btnZoekenLeveringenAankoop.Name = "btnZoekenLeveringenAankoop";
            btnZoekenLeveringenAankoop.Size = new Size(107, 38);
            btnZoekenLeveringenAankoop.TabIndex = 1;
            btnZoekenLeveringenAankoop.Text = "Bestand Zoeken";
            btnZoekenLeveringenAankoop.UseVisualStyleBackColor = true;
            btnZoekenLeveringenAankoop.Click += btnZoekenLeveringenAankoop_Click;
            // 
            // txtBestandsNaamLeveringenAankoop
            // 
            txtBestandsNaamLeveringenAankoop.Location = new Point(194, 32);
            txtBestandsNaamLeveringenAankoop.Margin = new Padding(3, 2, 3, 2);
            txtBestandsNaamLeveringenAankoop.Name = "txtBestandsNaamLeveringenAankoop";
            txtBestandsNaamLeveringenAankoop.ReadOnly = true;
            txtBestandsNaamLeveringenAankoop.Size = new Size(260, 23);
            txtBestandsNaamLeveringenAankoop.TabIndex = 2;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(18, 76);
            txtOutput.Margin = new Padding(3, 2, 3, 2);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(436, 194);
            txtOutput.TabIndex = 3;
            // 
            // btnVerwerkenLeveringenAankoop
            // 
            btnVerwerkenLeveringenAankoop.Location = new Point(322, 22);
            btnVerwerkenLeveringenAankoop.Margin = new Padding(3, 2, 3, 2);
            btnVerwerkenLeveringenAankoop.Name = "btnVerwerkenLeveringenAankoop";
            btnVerwerkenLeveringenAankoop.Size = new Size(132, 38);
            btnVerwerkenLeveringenAankoop.TabIndex = 4;
            btnVerwerkenLeveringenAankoop.Text = "Levering Verwerken";
            btnVerwerkenLeveringenAankoop.UseVisualStyleBackColor = true;
            btnVerwerkenLeveringenAankoop.Click += btnVerwerkenLeveringenAankoop_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoXMLLeveringenAankoop);
            groupBox1.Controls.Add(rdoJSONLeveringenAankoop);
            groupBox1.Controls.Add(btnZoekenLeveringenAankoop);
            groupBox1.Controls.Add(txtBestandsNaamLeveringenAankoop);
            groupBox1.Location = new Point(190, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(473, 78);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bestand Zoeken:";
            // 
            // rdoXMLLeveringenAankoop
            // 
            rdoXMLLeveringenAankoop.AutoSize = true;
            rdoXMLLeveringenAankoop.Location = new Point(132, 42);
            rdoXMLLeveringenAankoop.Margin = new Padding(3, 2, 3, 2);
            rdoXMLLeveringenAankoop.Name = "rdoXMLLeveringenAankoop";
            rdoXMLLeveringenAankoop.Size = new Size(49, 19);
            rdoXMLLeveringenAankoop.TabIndex = 1;
            rdoXMLLeveringenAankoop.TabStop = true;
            rdoXMLLeveringenAankoop.Text = "XML";
            rdoXMLLeveringenAankoop.UseVisualStyleBackColor = true;
            // 
            // rdoJSONLeveringenAankoop
            // 
            rdoJSONLeveringenAankoop.AutoSize = true;
            rdoJSONLeveringenAankoop.Location = new Point(132, 20);
            rdoJSONLeveringenAankoop.Margin = new Padding(3, 2, 3, 2);
            rdoJSONLeveringenAankoop.Name = "rdoJSONLeveringenAankoop";
            rdoJSONLeveringenAankoop.Size = new Size(53, 19);
            rdoJSONLeveringenAankoop.TabIndex = 0;
            rdoJSONLeveringenAankoop.TabStop = true;
            rdoJSONLeveringenAankoop.Text = "JSON";
            rdoJSONLeveringenAankoop.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtTotaalsaldoLevering);
            groupBox2.Controls.Add(txtNaamLeverancier);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(190, 92);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(473, 332);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inhoud Levering:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 289);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 6;
            label2.Text = "Totaalsaldo levering (in euro):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 45);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 5;
            label1.Text = "Naam leverancier:";
            // 
            // txtTotaalsaldoLevering
            // 
            txtTotaalsaldoLevering.Location = new Point(194, 286);
            txtTotaalsaldoLevering.Margin = new Padding(3, 2, 3, 2);
            txtTotaalsaldoLevering.Name = "txtTotaalsaldoLevering";
            txtTotaalsaldoLevering.ReadOnly = true;
            txtTotaalsaldoLevering.Size = new Size(260, 23);
            txtTotaalsaldoLevering.TabIndex = 3;
            // 
            // txtNaamLeverancier
            // 
            txtNaamLeverancier.Location = new Point(194, 40);
            txtNaamLeverancier.Margin = new Padding(3, 2, 3, 2);
            txtNaamLeverancier.Name = "txtNaamLeverancier";
            txtNaamLeverancier.ReadOnly = true;
            txtNaamLeverancier.Size = new Size(260, 23);
            txtNaamLeverancier.TabIndex = 4;
            // 
            // btnFormulierLeegmaken
            // 
            btnFormulierLeegmaken.Location = new Point(698, 32);
            btnFormulierLeegmaken.Margin = new Padding(3, 2, 3, 2);
            btnFormulierLeegmaken.Name = "btnFormulierLeegmaken";
            btnFormulierLeegmaken.Size = new Size(107, 38);
            btnFormulierLeegmaken.TabIndex = 3;
            btnFormulierLeegmaken.Text = "Formulier Leegmaken";
            btnFormulierLeegmaken.UseVisualStyleBackColor = true;
            btnFormulierLeegmaken.Click += btnFormulierLeegmaken_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 33);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 7;
            label3.Text = "Plaats in warenhuis:";
            // 
            // cmbPlaatsInWarenhuis
            // 
            cmbPlaatsInWarenhuis.FormattingEnabled = true;
            cmbPlaatsInWarenhuis.Location = new Point(140, 31);
            cmbPlaatsInWarenhuis.Margin = new Padding(3, 2, 3, 2);
            cmbPlaatsInWarenhuis.Name = "cmbPlaatsInWarenhuis";
            cmbPlaatsInWarenhuis.Size = new Size(133, 23);
            cmbPlaatsInWarenhuis.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbPlaatsInWarenhuis);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnVerwerkenLeveringenAankoop);
            groupBox3.Location = new Point(190, 441);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(473, 71);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Levering Verwerken:";
            // 
            // FrmLeveringenAankoop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 531);
            Controls.Add(groupBox3);
            Controls.Add(btnFormulierLeegmaken);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnTerugLeveringenAankoop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLeveringenAankoop";
            Text = "Leveringen";
            Load += FrmLeveringenAankoop_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTerugLeveringenAankoop;
        private Button btnZoekenLeveringenAankoop;
        private TextBox txtBestandsNaamLeveringenAankoop;
        private TextBox txtOutput;
        private Button btnVerwerkenLeveringenAankoop;
        private GroupBox groupBox1;
        private RadioButton rdoXMLLeveringenAankoop;
        private RadioButton rdoJSONLeveringenAankoop;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox txtTotaalsaldoLevering;
        private TextBox txtNaamLeverancier;
        private Button btnFormulierLeegmaken;
        private Label label3;
        private ComboBox cmbPlaatsInWarenhuis;
        private GroupBox groupBox3;
    }
}