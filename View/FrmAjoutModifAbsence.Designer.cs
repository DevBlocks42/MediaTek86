namespace MediaTek86.View
{
    partial class FrmAjoutModifAbsence
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
            LblPersonnelAbsence = new Label();
            CbxDateDebut = new ComboBox();
            LblDateDebut = new Label();
            LblDateFin = new Label();
            CbxDateFin = new ComboBox();
            LblMotif = new Label();
            CbxMotif = new ComboBox();
            BtnRetour = new Button();
            BtnEnregistrerPersonnel = new Button();
            SuspendLayout();
            // 
            // LblPersonnelAbsence
            // 
            LblPersonnelAbsence.Font = new Font("Segoe UI", 16F);
            LblPersonnelAbsence.Location = new Point(0, 100);
            LblPersonnelAbsence.Name = "LblPersonnelAbsence";
            LblPersonnelAbsence.Size = new Size(1008, 30);
            LblPersonnelAbsence.TabIndex = 0;
            LblPersonnelAbsence.Text = "Personnel : Johnatthan Dosettestein";
            LblPersonnelAbsence.TextAlign = ContentAlignment.TopCenter;
            // 
            // CbxDateDebut
            // 
            CbxDateDebut.FormattingEnabled = true;
            CbxDateDebut.Location = new Point(412, 236);
            CbxDateDebut.Name = "CbxDateDebut";
            CbxDateDebut.Size = new Size(200, 23);
            CbxDateDebut.TabIndex = 1;
            // 
            // LblDateDebut
            // 
            LblDateDebut.AutoSize = true;
            LblDateDebut.Location = new Point(412, 218);
            LblDateDebut.Name = "LblDateDebut";
            LblDateDebut.Size = new Size(81, 15);
            LblDateDebut.TabIndex = 2;
            LblDateDebut.Text = "Date de début";
            // 
            // LblDateFin
            // 
            LblDateFin.AutoSize = true;
            LblDateFin.Location = new Point(412, 262);
            LblDateFin.Name = "LblDateFin";
            LblDateFin.Size = new Size(64, 15);
            LblDateFin.TabIndex = 4;
            LblDateFin.Text = "Date de fin";
            // 
            // CbxDateFin
            // 
            CbxDateFin.FormattingEnabled = true;
            CbxDateFin.Location = new Point(412, 280);
            CbxDateFin.Name = "CbxDateFin";
            CbxDateFin.Size = new Size(200, 23);
            CbxDateFin.TabIndex = 3;
            // 
            // LblMotif
            // 
            LblMotif.AutoSize = true;
            LblMotif.Location = new Point(412, 306);
            LblMotif.Name = "LblMotif";
            LblMotif.Size = new Size(36, 15);
            LblMotif.TabIndex = 6;
            LblMotif.Text = "Motif";
            // 
            // CbxMotif
            // 
            CbxMotif.FormattingEnabled = true;
            CbxMotif.Location = new Point(412, 324);
            CbxMotif.Name = "CbxMotif";
            CbxMotif.Size = new Size(200, 23);
            CbxMotif.TabIndex = 5;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(467, 440);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(75, 23);
            BtnRetour.TabIndex = 13;
            BtnRetour.Text = "Annuler";
            BtnRetour.UseVisualStyleBackColor = true;
            // 
            // BtnEnregistrerPersonnel
            // 
            BtnEnregistrerPersonnel.Location = new Point(467, 381);
            BtnEnregistrerPersonnel.Name = "BtnEnregistrerPersonnel";
            BtnEnregistrerPersonnel.Size = new Size(75, 23);
            BtnEnregistrerPersonnel.TabIndex = 12;
            BtnEnregistrerPersonnel.Text = "Enregistrer";
            BtnEnregistrerPersonnel.UseVisualStyleBackColor = true;
            // 
            // FrmAjoutModifAbsence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(BtnRetour);
            Controls.Add(BtnEnregistrerPersonnel);
            Controls.Add(LblMotif);
            Controls.Add(CbxMotif);
            Controls.Add(LblDateFin);
            Controls.Add(CbxDateFin);
            Controls.Add(LblDateDebut);
            Controls.Add(CbxDateDebut);
            Controls.Add(LblPersonnelAbsence);
            MaximizeBox = false;
            Name = "FrmAjoutModifAbsence";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administration - ajouter/modifier une absence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPersonnelAbsence;
        private ComboBox CbxDateDebut;
        private Label LblDateDebut;
        private Label LblDateFin;
        private ComboBox CbxDateFin;
        private Label LblMotif;
        private ComboBox CbxMotif;
        private Button BtnRetour;
        private Button BtnEnregistrerPersonnel;
    }
}