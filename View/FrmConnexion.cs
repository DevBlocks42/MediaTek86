using MediaTek86.Controller;

namespace MediaTek86.View
{
    /// <summary>
    /// Vue du formulaire de connexion
    /// </summary>
    public partial class FrmConnexion : Form
    {
        private FrmConnexionController controller;
        /// <summary>
        /// Valorisation de la propri�t� priv�e
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
            controller = new FrmConnexionController();
        }
        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LblConnexion; // �vite l'auto-focus sur la 1�re TextBox ce qui engendrait l'impossibilit� de voir le placeholder du champs.
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connexion");
            if (TbxLogin.Text.Length > 0 && TbxPwd.Text.Length > 0)
            {
                if (controller.controleAuthentification(TbxLogin.Text, TbxPwd.Text))
                {
                    FrmAdministration frmAdministration = new FrmAdministration();
                    frmAdministration.Show();
                    MessageBox.Show("Connexion r�ussie.");
                }
                else
                {
                    MessageBox.Show("Erreur, nom d'utilisateur ou mot de passe incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Erreur, vous devez saisir tous les champs avant de pouvoir vous connecter.");
            }
        }
    }
}