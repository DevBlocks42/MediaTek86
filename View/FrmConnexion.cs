namespace MediaTek86
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LblConnexion; // �vite l'auto-focus sur la 1�re TextBox ce qui engendrait l'impossibilit� de voir le placeholder du champs.
        }
    }
}