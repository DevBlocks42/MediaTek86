namespace MediaTek86.View
{
    partial class FrmAjoutModifPersonnel
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
            TbxNomPersonnel = new TextBox();
            LblNomPersonnel = new Label();
            LblPrenom = new Label();
            TbxPrenomPersonnel = new TextBox();
            LblTelPersonnel = new Label();
            TbxTelPersonnel = new TextBox();
            LblMailPersonnel = new Label();
            TbxMailPersonnel = new TextBox();
            CbxServicePersonnel = new ComboBox();
            LblServicePersonnel = new Label();
            BtnEnregistrerPersonnel = new Button();
            BtnRetour = new Button();
            LblTitreAjoutModif = new Label();
            SuspendLayout();
            // 
            // TbxNomPersonnel
            // 
            TbxNomPersonnel.Location = new Point(412, 187);
            TbxNomPersonnel.Name = "TbxNomPersonnel";
            TbxNomPersonnel.Size = new Size(200, 23);
            TbxNomPersonnel.TabIndex = 0;
            // 
            // LblNomPersonnel
            // 
            LblNomPersonnel.AutoSize = true;
            LblNomPersonnel.Font = new Font("Segoe UI", 12F);
            LblNomPersonnel.Location = new Point(412, 163);
            LblNomPersonnel.Name = "LblNomPersonnel";
            LblNomPersonnel.Size = new Size(45, 21);
            LblNomPersonnel.TabIndex = 1;
            LblNomPersonnel.Text = "Nom";
            // 
            // LblPrenom
            // 
            LblPrenom.AutoSize = true;
            LblPrenom.Font = new Font("Segoe UI", 12F);
            LblPrenom.Location = new Point(412, 213);
            LblPrenom.Name = "LblPrenom";
            LblPrenom.Size = new Size(65, 21);
            LblPrenom.TabIndex = 3;
            LblPrenom.Text = "Prénom";
            // 
            // TbxPrenomPersonnel
            // 
            TbxPrenomPersonnel.Location = new Point(412, 237);
            TbxPrenomPersonnel.Name = "TbxPrenomPersonnel";
            TbxPrenomPersonnel.Size = new Size(200, 23);
            TbxPrenomPersonnel.TabIndex = 2;
            // 
            // LblTelPersonnel
            // 
            LblTelPersonnel.AutoSize = true;
            LblTelPersonnel.Font = new Font("Segoe UI", 12F);
            LblTelPersonnel.Location = new Point(412, 263);
            LblTelPersonnel.Name = "LblTelPersonnel";
            LblTelPersonnel.Size = new Size(28, 21);
            LblTelPersonnel.TabIndex = 5;
            LblTelPersonnel.Text = "Tel";
            // 
            // TbxTelPersonnel
            // 
            TbxTelPersonnel.Location = new Point(412, 287);
            TbxTelPersonnel.Name = "TbxTelPersonnel";
            TbxTelPersonnel.Size = new Size(200, 23);
            TbxTelPersonnel.TabIndex = 4;
            // 
            // LblMailPersonnel
            // 
            LblMailPersonnel.AutoSize = true;
            LblMailPersonnel.Font = new Font("Segoe UI", 12F);
            LblMailPersonnel.Location = new Point(412, 313);
            LblMailPersonnel.Name = "LblMailPersonnel";
            LblMailPersonnel.Size = new Size(40, 21);
            LblMailPersonnel.TabIndex = 7;
            LblMailPersonnel.Text = "Mail";
            // 
            // TbxMailPersonnel
            // 
            TbxMailPersonnel.Location = new Point(412, 337);
            TbxMailPersonnel.Name = "TbxMailPersonnel";
            TbxMailPersonnel.Size = new Size(200, 23);
            TbxMailPersonnel.TabIndex = 6;
            // 
            // CbxServicePersonnel
            // 
            CbxServicePersonnel.FormattingEnabled = true;
            CbxServicePersonnel.Location = new Point(412, 387);
            CbxServicePersonnel.Name = "CbxServicePersonnel";
            CbxServicePersonnel.Size = new Size(200, 23);
            CbxServicePersonnel.TabIndex = 8;
            // 
            // LblServicePersonnel
            // 
            LblServicePersonnel.AutoSize = true;
            LblServicePersonnel.Font = new Font("Segoe UI", 12F);
            LblServicePersonnel.Location = new Point(412, 363);
            LblServicePersonnel.Name = "LblServicePersonnel";
            LblServicePersonnel.Size = new Size(60, 21);
            LblServicePersonnel.TabIndex = 9;
            LblServicePersonnel.Text = "Service";
            // 
            // BtnEnregistrerPersonnel
            // 
            BtnEnregistrerPersonnel.Location = new Point(475, 446);
            BtnEnregistrerPersonnel.Name = "BtnEnregistrerPersonnel";
            BtnEnregistrerPersonnel.Size = new Size(75, 23);
            BtnEnregistrerPersonnel.TabIndex = 10;
            BtnEnregistrerPersonnel.Text = "Enregistrer";
            BtnEnregistrerPersonnel.UseVisualStyleBackColor = true;
            BtnEnregistrerPersonnel.Click += BtnEnregistrerPersonnel_Click;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(475, 505);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(75, 23);
            BtnRetour.TabIndex = 11;
            BtnRetour.Text = "Annuler";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // LblTitreAjoutModif
            // 
            LblTitreAjoutModif.AutoSize = true;
            LblTitreAjoutModif.Font = new Font("Segoe UI", 16F);
            LblTitreAjoutModif.Location = new Point(47, 44);
            LblTitreAjoutModif.Name = "LblTitreAjoutModif";
            LblTitreAjoutModif.Size = new Size(221, 30);
            LblTitreAjoutModif.TabIndex = 12;
            LblTitreAjoutModif.Text = "TITRE_AJOUT_MODIF";
            // 
            // FrmAjoutModifPersonnel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(LblTitreAjoutModif);
            Controls.Add(BtnRetour);
            Controls.Add(BtnEnregistrerPersonnel);
            Controls.Add(LblServicePersonnel);
            Controls.Add(CbxServicePersonnel);
            Controls.Add(LblMailPersonnel);
            Controls.Add(TbxMailPersonnel);
            Controls.Add(LblTelPersonnel);
            Controls.Add(TbxTelPersonnel);
            Controls.Add(LblPrenom);
            Controls.Add(TbxPrenomPersonnel);
            Controls.Add(LblNomPersonnel);
            Controls.Add(TbxNomPersonnel);
            MaximizeBox = false;
            Name = "FrmAjoutModifPersonnel";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administration - ajout/modification du personnel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbxNomPersonnel;
        private Label LblNomPersonnel;
        private Label LblPrenom;
        private TextBox TbxPrenomPersonnel;
        private Label LblTelPersonnel;
        private TextBox TbxTelPersonnel;
        private Label LblMailPersonnel;
        private TextBox TbxMailPersonnel;
        private ComboBox CbxServicePersonnel;
        private Label LblServicePersonnel;
        private Button BtnEnregistrerPersonnel;
        private Button BtnRetour;
        private Label LblTitreAjoutModif;
    }
}