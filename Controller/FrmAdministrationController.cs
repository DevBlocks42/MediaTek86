using MediaTek86.DAL;
using MediaTek86.Model;

namespace MediaTek86.Controller
{
    /// <summary>
    /// Contrôleur de FrmAdministration
    /// </summary>
    public class FrmAdministrationController
    {
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// Controller de FrmAdministration : valorisation de la proprété privée personnelAccess
        /// </summary>
        public FrmAdministrationController()
        {
            personnelAccess = new PersonnelAccess();    
        }
        /// <summary>
        /// Récupère la liste des personnels actuellement présents dans la base de données.
        /// </summary>
        /// <returns>List de Personnel></returns>
        public List<Personnel> getLesPersonnels()
        {
            return personnelAccess.getLesPersonnels();  
        }
        /// <summary>
        /// Supprime un personnel
        /// </summary>
        /// <param name="idPersonnel"></param>
        public void supprimerPersonnel(int idPersonnel)
        {
            personnelAccess.supprimerPersonnel(idPersonnel);
        }
    }
}