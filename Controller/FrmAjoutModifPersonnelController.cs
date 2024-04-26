using MediaTek86.DAL;
using MediaTek86.Model;

namespace MediaTek86.Controller
{
    /// <summary>
    /// Contrôleur de FrmAjoutModifPersonnel
    /// </summary>
    public class FrmAjoutModifPersonnelController
    {
        private readonly PersonnelAccess personnelAccess;
        private Personnel personnel;
        /// <summary>
        /// Constructeur : valorisation de personnelAccess
        /// </summary>
        public FrmAjoutModifPersonnelController(Personnel personnel)
        {
            personnelAccess = new PersonnelAccess();  
            this.personnel = personnel; 
        }
        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idService"></param>
        public void ajouterPersonnel(String nom, String prenom, String tel, String mail, int idService)
        {
            personnelAccess.ajouterPersonnel(nom, prenom, tel, mail, idService);
        }
        /// <summary>
        /// Met à jour les informations d'un personnel
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idService"></param>
        public void updatePersonnel(int idPersonnel, String nom, String prenom, String tel, String mail, int idService)
        {
            personnelAccess.updatePersonnel(idPersonnel, nom, prenom, tel, mail, idService);
        }
        /// <summary>
        /// Récupère la liste des nom de services
        /// </summary>
        /// <returns>List de String</returns>
        public List<String> getNomServices()
        {
            return personnelAccess.getNomServices();
        }
    }
}