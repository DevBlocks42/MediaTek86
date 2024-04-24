using MediaTek86.DAL;
using MediaTek86.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void ajouterPersonnel(String nom, String prenom, String tel, String mail, int idService)
        {
            personnelAccess.ajouterPersonnel(nom, prenom, tel, mail, idService);
        }
        public List<String> getNomServices()
        {
            return personnelAccess.getNomServices();
        }
    }
}
