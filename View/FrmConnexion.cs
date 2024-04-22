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
            this.ActiveControl = LblConnexion; // évite l'auto-focus sur la 1ère TextBox ce qui engendrait l'impossibilité de voir le placeholder du champs.
        }
    }
}