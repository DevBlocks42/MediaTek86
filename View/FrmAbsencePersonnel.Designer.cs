namespace MediaTek86.View
{
    partial class FrmAbsencePersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbsencePersonnel));
            LbxAbsencesPersonnel = new ListBox();
            LblAbsencePersonnel = new Label();
            BtnDeleteAbsence = new Button();
            BtnEditAbsence = new Button();
            BtnAddAbsence = new Button();
            SuspendLayout();
            // 
            // LbxAbsencesPersonnel
            // 
            resources.ApplyResources(LbxAbsencesPersonnel, "LbxAbsencesPersonnel");
            LbxAbsencesPersonnel.FormattingEnabled = true;
            LbxAbsencesPersonnel.Name = "LbxAbsencesPersonnel";
            // 
            // LblAbsencePersonnel
            // 
            resources.ApplyResources(LblAbsencePersonnel, "LblAbsencePersonnel");
            LblAbsencePersonnel.Name = "LblAbsencePersonnel";
            // 
            // BtnDeleteAbsence
            // 
            resources.ApplyResources(BtnDeleteAbsence, "BtnDeleteAbsence");
            BtnDeleteAbsence.Name = "BtnDeleteAbsence";
            BtnDeleteAbsence.UseVisualStyleBackColor = true;
            // 
            // BtnEditAbsence
            // 
            resources.ApplyResources(BtnEditAbsence, "BtnEditAbsence");
            BtnEditAbsence.Name = "BtnEditAbsence";
            BtnEditAbsence.UseVisualStyleBackColor = true;
            // 
            // BtnAddAbsence
            // 
            resources.ApplyResources(BtnAddAbsence, "BtnAddAbsence");
            BtnAddAbsence.Name = "BtnAddAbsence";
            BtnAddAbsence.UseVisualStyleBackColor = true;
            BtnAddAbsence.Click += BtnAddAbsence_Click;
            // 
            // FrmAbsencePersonnel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnDeleteAbsence);
            Controls.Add(BtnEditAbsence);
            Controls.Add(BtnAddAbsence);
            Controls.Add(LblAbsencePersonnel);
            Controls.Add(LbxAbsencesPersonnel);
            MaximizeBox = false;
            Name = "FrmAbsencePersonnel";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbxAbsencesPersonnel;
        private Label LblAbsencePersonnel;
        private Button BtnDeleteAbsence;
        private Button BtnEditAbsence;
        private Button BtnAddAbsence;
    }
}