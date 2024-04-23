using MediaTek86.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public FrmConnexionController() 
        {
            responsableAcces = new ResponsableAccess(); 
        }
        public Boolean controleAuthentification(String login, String pass)
        {
            return responsableAcces.controleAuthentification(login, pass);
        }
    }
}
