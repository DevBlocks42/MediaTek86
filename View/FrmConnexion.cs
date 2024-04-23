using MediaTek86.Controller;

namespace MediaTek86
{
    public partial class FrmConnexion : Form
    {
        private FrmConnexionController controller;
        public FrmConnexion()
        {
            InitializeComponent();
            controller = new FrmConnexionController();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LblConnexion; // évite l'auto-focus sur la 1ère TextBox ce qui engendrait l'impossibilité de voir le placeholder du champs.
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connexion");
            if (TbxLogin.Text.Length > 0 && TbxPwd.Text.Length > 0)
            {
                if (controller.controleAuthentification(TbxLogin.Text, TbxPwd.Text))
                {
                    MessageBox.Show("Connexion réussie.");
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