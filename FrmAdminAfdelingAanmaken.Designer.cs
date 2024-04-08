namespace Project_2__Bart_
{
    partial class FrmAdminAfdelingAanmaken
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
            label1 = new Label();
            txtNaamAfdeling = new TextBox();
            txtOmschrijving = new TextBox();
            label2 = new Label();
            btnToevoegen = new Button();
            SuspendLayout();
            // 
            // btnTerug
            // 
            btnTerug.Location = new Point(10, 286);
            btnTerug.Margin = new Padding(3, 2, 3, 2);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(113, 43);
            btnTerug.TabIndex = 32;
            btnTerug.Text = "Terug";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 43);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 33;
            label1.Text = "Naam afdeling:";
            // 
            // txtNaamAfdeling
            // 
            txtNaamAfdeling.Location = new Point(301, 40);
            txtNaamAfdeling.Margin = new Padding(3, 2, 3, 2);
            txtNaamAfdeling.Name = "txtNaamAfdeling";
            txtNaamAfdeling.Size = new Size(221, 23);
            txtNaamAfdeling.TabIndex = 34;
            // 
            // txtOmschrijving
            // 
            txtOmschrijving.Location = new Point(183, 136);
            txtOmschrijving.Margin = new Padding(3, 2, 3, 2);
            txtOmschrijving.Multiline = true;
            txtOmschrijving.Name = "txtOmschrijving";
            txtOmschrijving.Size = new Size(439, 134);
            txtOmschrijving.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 108);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 36;
            label2.Text = "Omschrijving:";
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(551, 286);
            btnToevoegen.Margin = new Padding(3, 2, 3, 2);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(113, 43);
            btnToevoegen.TabIndex = 37;
            btnToevoegen.Text = "Toevoegen";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // FrmAdminAfdelingAanmaken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnToevoegen);
            Controls.Add(label2);
            Controls.Add(txtOmschrijving);
            Controls.Add(txtNaamAfdeling);
            Controls.Add(label1);
            Controls.Add(btnTerug);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAdminAfdelingAanmaken";
            Text = "Afdeling Aanmaken - Admin";
            Load += FrmAdminAfdelingAanmaken_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTerug;
        private Label label1;
        private TextBox txtNaamAfdeling;
        private TextBox txtOmschrijving;
        private Label label2;
        private Button btnToevoegen;
    }
}