namespace MediaTek86
{
    partial class FrmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            TbxLogin = new TextBox();
            TbxPwd = new TextBox();
            LblConnexion = new Label();
            BtnConnect = new Button();
            SuspendLayout();
            // 
            // TbxLogin
            // 
            resources.ApplyResources(TbxLogin, "TbxLogin");
            TbxLogin.Name = "TbxLogin";
            // 
            // TbxPwd
            // 
            resources.ApplyResources(TbxPwd, "TbxPwd");
            TbxPwd.Name = "TbxPwd";
            // 
            // LblConnexion
            // 
            resources.ApplyResources(LblConnexion, "LblConnexion");
            LblConnexion.Name = "LblConnexion";
            // 
            // BtnConnect
            // 
            resources.ApplyResources(BtnConnect, "BtnConnect");
            BtnConnect.Name = "BtnConnect";
            BtnConnect.UseVisualStyleBackColor = true;
            // 
            // FrmConnexion
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnConnect);
            Controls.Add(LblConnexion);
            Controls.Add(TbxPwd);
            Controls.Add(TbxLogin);
            MaximizeBox = false;
            Name = "FrmConnexion";
            ShowIcon = false;
            Load += FrmConnexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbxLogin;
        private TextBox TbxPwd;
        private Label LblConnexion;
        private Button BtnConnect;
    }
}
