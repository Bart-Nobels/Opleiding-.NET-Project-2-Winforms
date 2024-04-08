namespace Project_2__Bart_
{
    partial class FrmAdminToDoLijst
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
            lstOverzichtBerichten = new ListBox();
            txtInhoudBericht = new TextBox();
            btnBerichtVerwijderen = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(10, 406);
            btnTerug.Margin = new Padding(3, 2, 3, 2);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(113, 43);
            btnTerug.TabIndex = 19;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // lstOverzichtBerichten
            // 
            lstOverzichtBerichten.FormattingEnabled = true;
            lstOverzichtBerichten.ItemHeight = 15;
            lstOverzichtBerichten.Location = new Point(38, 20);
            lstOverzichtBerichten.Margin = new Padding(3, 2, 3, 2);
            lstOverzichtBerichten.Name = "lstOverzichtBerichten";
            lstOverzichtBerichten.Size = new Size(384, 184);
            lstOverzichtBerichten.TabIndex = 20;
            lstOverzichtBerichten.SelectedIndexChanged += lstOverzichtBerichten_SelectedIndexChanged;
            // 
            // txtInhoudBericht
            // 
            txtInhoudBericht.Location = new Point(38, 27);
            txtInhoudBericht.Margin = new Padding(3, 2, 3, 2);
            txtInhoudBericht.Multiline = true;
            txtInhoudBericht.Name = "txtInhoudBericht";
            txtInhoudBericht.ReadOnly = true;
            txtInhoudBericht.Size = new Size(384, 157);
            txtInhoudBericht.TabIndex = 21;
            // 
            // btnBerichtVerwijderen
            // 
            btnBerichtVerwijderen.Location = new Point(657, 194);
            btnBerichtVerwijderen.Margin = new Padding(3, 2, 3, 2);
            btnBerichtVerwijderen.Name = "btnBerichtVerwijderen";
            btnBerichtVerwijderen.Size = new Size(113, 43);
            btnBerichtVerwijderen.TabIndex = 22;
            btnBerichtVerwijderen.Text = "Bericht verwijderen";
            btnBerichtVerwijderen.UseVisualStyleBackColor = true;
            btnBerichtVerwijderen.Click += btnBerichtVerwijderen_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstOverzichtBerichten);
            groupBox1.Location = new Point(159, 27);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(452, 210);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Berichten:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtInhoudBericht);
            groupBox2.Location = new Point(159, 254);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(452, 194);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inhoud:";
            // 
            // FrmAdminToDoLijst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 458);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnBerichtVerwijderen);
            Controls.Add(btnTerug);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAdminToDoLijst";
            Text = "FrmAdminToDoLijst";
            Load += FrmAdminToDoLijst_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTerug;
        private ListBox lstOverzichtBerichten;
        private TextBox txtInhoudBericht;
        private Button btnBerichtVerwijderen;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}