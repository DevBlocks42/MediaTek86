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
    /// Contrôleur de FrmAbsencePersonnel
    /// </summary>
    public class FrmAbsencePersonnelController
    {
        private readonly PersonnelAccess personnelAccess;
        public FrmAbsencePersonnelController()
        {
            personnelAccess = new PersonnelAccess();
        }
        public void supprimerAbsence(Personnel personnel, Absence absence)
        {
            personnelAccess.supprimerAbsence(personnel, absence);
        }
        public List<Absence> getPersonnelAbsences(int idPersonnel)
        {
            return personnelAccess.getPersonnelAbsences(idPersonnel);
        }
    }
}
