using MediaTek86.DAL;
using MediaTek86.Model;

namespace MediaTek86.Controller
{
    /// <summary>
    /// Contrôleur de FrmAbsencePersonnel
    /// </summary>
    public class FrmAbsencePersonnelController
    {
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// Constructeur du controller pour FrmAbsencePersonnel
        /// </summary>
        public FrmAbsencePersonnelController()
        {
            personnelAccess = new PersonnelAccess();
        }
        /// <summary>
        /// Supprime une absence d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="absence"></param>
        public void supprimerAbsence(Personnel personnel, Absence absence)
        {
            personnelAccess.supprimerAbsence(personnel, absence);
        }
        /// <summary>
        /// Récupère la liste des absences d'un personnel
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <returns>List d'Absence</returns>
        public List<Absence> getPersonnelAbsences(int idPersonnel)
        {
            return personnelAccess.getPersonnelAbsences(idPersonnel);
        }
    }
}