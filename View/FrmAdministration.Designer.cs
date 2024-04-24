namespace MediaTek86.View
{
    partial class FrmAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministration));
            LbxPersonnel = new ListBox();
            LblGestionPersonnel = new Label();
            BtnAddPersonnel = new Button();
            BtnEditPersonnel = new Button();
            BtnAbsencePersonnel = new Button();
            BtnDeletePersonnel = new Button();
            SuspendLayout();
            // 
            // LbxPersonnel
            // 
            resources.ApplyResources(LbxPersonnel, "LbxPersonnel");
            LbxPersonnel.FormattingEnabled = true;
            LbxPersonnel.Name = "LbxPersonnel";
            // 
            // LblGestionPersonnel
            // 
            resources.ApplyResources(LblGestionPersonnel, "LblGestionPersonnel");
            LblGestionPersonnel.Name = "LblGestionPersonnel";
            // 
            // BtnAddPersonnel
            // 
            resources.ApplyResources(BtnAddPersonnel, "BtnAddPersonnel");
            BtnAddPersonnel.Name = "BtnAddPersonnel";
            BtnAddPersonnel.UseVisualStyleBackColor = true;
            BtnAddPersonnel.Click += BtnAddPersonnel_Click;
            // 
            // BtnEditPersonnel
            // 
            resources.ApplyResources(BtnEditPersonnel, "BtnEditPersonnel");
            BtnEditPersonnel.Name = "BtnEditPersonnel";
            BtnEditPersonnel.UseVisualStyleBackColor = true;
            BtnEditPersonnel.Click += BtnEditPersonnel_Click;
            // 
            // BtnAbsencePersonnel
            // 
            resources.ApplyResources(BtnAbsencePersonnel, "BtnAbsencePersonnel");
            BtnAbsencePersonnel.Name = "BtnAbsencePersonnel";
            BtnAbsencePersonnel.UseVisualStyleBackColor = true;
            BtnAbsencePersonnel.Click += BtnAbsencePersonnel_Click;
            // 
            // BtnDeletePersonnel
            // 
            resources.ApplyResources(BtnDeletePersonnel, "BtnDeletePersonnel");
            BtnDeletePersonnel.Name = "BtnDeletePersonnel";
            BtnDeletePersonnel.UseVisualStyleBackColor = true;
            BtnDeletePersonnel.Click += BtnDeletePersonnel_Click;
            // 
            // FrmAdministration
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnAbsencePersonnel);
            Controls.Add(BtnDeletePersonnel);
            Controls.Add(BtnEditPersonnel);
            Controls.Add(BtnAddPersonnel);
            Controls.Add(LblGestionPersonnel);
            Controls.Add(LbxPersonnel);
            MaximizeBox = false;
            Name = "FrmAdministration";
            ShowIcon = false;
            Load += FrmAdministration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbxPersonnel;
        private Label LblGestionPersonnel;
        private Button BtnAddPersonnel;
        private Button BtnEditPersonnel;
        private Button BtnAbsencePersonnel;
        private Button BtnDeletePersonnel;
    }
}