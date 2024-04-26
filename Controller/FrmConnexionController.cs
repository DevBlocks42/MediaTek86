using MediaTek86.DAL;

namespace MediaTek86.Controller
{
    /// <summary>
    /// Contrôleur de FrmConnexion
    /// </summary>
    public class FrmConnexionController
    {
        /// <summary>
        /// Objet d'accès aux données du responsable
        /// </summary>
        private readonly ResponsableAccess responsableAcces;
        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmConnexionController() 
        {
            responsableAcces = new ResponsableAccess(); 
        }
        /// <summary>
        /// Contrôle la validité des identifiants saisits par l'utilisateur
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <returns>true si les identifiants sont corrects, false sinon</returns>
        public Boolean controleAuthentification(String login, String pass)
        {
            return responsableAcces.controleAuthentification(login, pass);
        }
    }
}