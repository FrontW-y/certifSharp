namespace certifSharp
{
    partial class certifSharp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(certifSharp));
            dateSelector = new DateTimePicker();
            generer = new Button();
            groupBox1 = new GroupBox();
            dateNaissanceBox = new DateTimePicker();
            nomEleve = new TextBox();
            prenomEleve = new TextBox();
            label5 = new Label();
            genre = new ComboBox();
            naissanceLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            typeLabel = new Label();
            typeMenu = new ComboBox();
            villeLabel = new Label();
            villeTextBox = new TextBox();
            ziptextBox = new TextBox();
            zipLabel = new Label();
            nomMedecinBox = new TextBox();
            nomMed = new Label();
            optionnel = new Label();
            motifsZone = new RichTextBox();
            motifsLabels = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateSelector
            // 
            dateSelector.CustomFormat = "dd/MM/yyyy ";
            dateSelector.Format = DateTimePickerFormat.Custom;
            dateSelector.Location = new Point(556, 30);
            dateSelector.Margin = new Padding(4, 5, 4, 5);
            dateSelector.Name = "dateSelector";
            dateSelector.Size = new Size(190, 31);
            dateSelector.TabIndex = 0;
            dateSelector.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // generer
            // 
            generer.Location = new Point(556, 482);
            generer.Margin = new Padding(4, 5, 4, 5);
            generer.Name = "generer";
            generer.Size = new Size(191, 85);
            generer.TabIndex = 1;
            generer.Text = "Générer ";
            generer.UseVisualStyleBackColor = true;
            generer.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateNaissanceBox);
            groupBox1.Controls.Add(nomEleve);
            groupBox1.Controls.Add(prenomEleve);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(genre);
            groupBox1.Controls.Add(naissanceLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(384, 278);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information élève";
            // 
            // dateNaissanceBox
            // 
            dateNaissanceBox.CustomFormat = "dd/MM/yyyy ";
            dateNaissanceBox.Format = DateTimePickerFormat.Custom;
            dateNaissanceBox.Location = new Point(203, 147);
            dateNaissanceBox.Margin = new Padding(4, 5, 4, 5);
            dateNaissanceBox.Name = "dateNaissanceBox";
            dateNaissanceBox.Size = new Size(171, 31);
            dateNaissanceBox.TabIndex = 9;
            dateNaissanceBox.ValueChanged += dateNaissanceBox_ValueChanged;
            // 
            // nomEleve
            // 
            nomEleve.Location = new Point(203, 47);
            nomEleve.Margin = new Padding(4, 5, 4, 5);
            nomEleve.Name = "nomEleve";
            nomEleve.Size = new Size(171, 31);
            nomEleve.TabIndex = 8;
            // 
            // prenomEleve
            // 
            prenomEleve.Location = new Point(203, 98);
            prenomEleve.Margin = new Padding(4, 5, 4, 5);
            prenomEleve.Name = "prenomEleve";
            prenomEleve.Size = new Size(171, 31);
            prenomEleve.TabIndex = 7;
            prenomEleve.TextChanged += prenomEleve_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 198);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 5;
            label5.Text = "Genre";
            // 
            // genre
            // 
            genre.FormattingEnabled = true;
            genre.Items.AddRange(new object[] { "Homme", "Femme" });
            genre.Location = new Point(203, 193);
            genre.Margin = new Padding(4, 5, 4, 5);
            genre.Name = "genre";
            genre.Size = new Size(171, 33);
            genre.TabIndex = 4;
            genre.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // naissanceLabel
            // 
            naissanceLabel.AutoSize = true;
            naissanceLabel.Location = new Point(9, 150);
            naissanceLabel.Margin = new Padding(4, 0, 4, 0);
            naissanceLabel.Name = "naissanceLabel";
            naissanceLabel.Size = new Size(154, 25);
            naissanceLabel.TabIndex = 2;
            naissanceLabel.Text = "Date de naissance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 1;
            label3.Text = "Prénom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 0;
            label2.Text = "NOM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 3;
            label1.Text = "Date absence";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(26, 328);
            typeLabel.Margin = new Padding(4, 0, 4, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(49, 25);
            typeLabel.TabIndex = 10;
            typeLabel.Text = "Type";
            typeLabel.Click += label6_Click;
            // 
            // typeMenu
            // 
            typeMenu.FormattingEnabled = true;
            typeMenu.Items.AddRange(new object[] { "Medadom", "Normal" });
            typeMenu.Location = new Point(220, 323);
            typeMenu.Margin = new Padding(4, 5, 4, 5);
            typeMenu.Name = "typeMenu";
            typeMenu.Size = new Size(171, 33);
            typeMenu.TabIndex = 11;
            typeMenu.Text = "Sélectionnez";
            typeMenu.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new Point(29, 383);
            villeLabel.Margin = new Padding(4, 0, 4, 0);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new Size(44, 25);
            villeLabel.TabIndex = 10;
            villeLabel.Text = "Ville";
            villeLabel.Click += label7_Click;
            // 
            // villeTextBox
            // 
            villeTextBox.Location = new Point(220, 378);
            villeTextBox.Margin = new Padding(4, 5, 4, 5);
            villeTextBox.Name = "villeTextBox";
            villeTextBox.Size = new Size(171, 31);
            villeTextBox.TabIndex = 10;
            villeTextBox.TextChanged += textBox1_TextChanged;
            // 
            // ziptextBox
            // 
            ziptextBox.Location = new Point(220, 427);
            ziptextBox.Margin = new Padding(4, 5, 4, 5);
            ziptextBox.Name = "ziptextBox";
            ziptextBox.Size = new Size(171, 31);
            ziptextBox.TabIndex = 12;
            ziptextBox.TextChanged += textBox4_TextChanged;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new Point(29, 432);
            zipLabel.Margin = new Padding(4, 0, 4, 0);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new Size(106, 25);
            zipLabel.TabIndex = 13;
            zipLabel.Text = "Code Postal";
            zipLabel.Click += label8_Click;
            // 
            // nomMedecinBox
            // 
            nomMedecinBox.Location = new Point(220, 482);
            nomMedecinBox.Margin = new Padding(4, 5, 4, 5);
            nomMedecinBox.Name = "nomMedecinBox";
            nomMedecinBox.Size = new Size(171, 31);
            nomMedecinBox.TabIndex = 14;
            nomMedecinBox.TextChanged += textBox1_TextChanged_1;
            // 
            // nomMed
            // 
            nomMed.AutoSize = true;
            nomMed.Location = new Point(29, 487);
            nomMed.Margin = new Padding(4, 0, 4, 0);
            nomMed.Name = "nomMed";
            nomMed.Size = new Size(124, 25);
            nomMed.TabIndex = 15;
            nomMed.Text = "Nom Medecin";
            nomMed.Click += label6_Click_1;
            // 
            // optionnel
            // 
            optionnel.AutoSize = true;
            optionnel.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            optionnel.Location = new Point(156, 502);
            optionnel.Margin = new Padding(4, 0, 4, 0);
            optionnel.Name = "optionnel";
            optionnel.Size = new Size(53, 15);
            optionnel.TabIndex = 16;
            optionnel.Text = "Optionel";
            optionnel.Click += label7_Click_1;
            // 
            // motifsZone
            // 
            motifsZone.Location = new Point(556, 118);
            motifsZone.Margin = new Padding(4, 5, 4, 5);
            motifsZone.Name = "motifsZone";
            motifsZone.Size = new Size(190, 177);
            motifsZone.TabIndex = 17;
            motifsZone.Text = "Motifs :";
            // 
            // motifsLabels
            // 
            motifsLabels.AutoSize = true;
            motifsLabels.Location = new Point(437, 118);
            motifsLabels.Margin = new Padding(4, 0, 4, 0);
            motifsLabels.Name = "motifsLabels";
            motifsLabels.Size = new Size(63, 25);
            motifsLabels.TabIndex = 18;
            motifsLabels.Text = "Motifs";
            // 
            // certifSharp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 587);
            Controls.Add(motifsLabels);
            Controls.Add(motifsZone);
            Controls.Add(optionnel);
            Controls.Add(nomMed);
            Controls.Add(nomMedecinBox);
            Controls.Add(zipLabel);
            Controls.Add(ziptextBox);
            Controls.Add(villeTextBox);
            Controls.Add(villeLabel);
            Controls.Add(typeLabel);
            Controls.Add(typeMenu);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(generer);
            Controls.Add(dateSelector);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "certifSharp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CertifGen";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateSelector;
        private Button generer;
        private GroupBox groupBox1;
        private Label label1;
        private Label naissanceLabel;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox genre;
        private TextBox nomEleve;
        private TextBox prenomEleve;
        private Label typeLabel;
        private ComboBox typeMenu;
        private DateTimePicker dateNaissanceBox;
        private Label villeLabel;
        private TextBox villeTextBox;
        private TextBox ziptextBox;
        private Label zipLabel;
        private TextBox nomMedecinBox;
        private Label nomMed;
        private Label optionnel;
        private RichTextBox motifsZone;
        private Label motifsLabels;
    }
}