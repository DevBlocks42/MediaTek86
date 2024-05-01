using MediaTek86.DAL;
using MediaTek86.Model;

namespace MediaTek86.Controller
{
    /// <summary>
    /// Contrôleur de FrmAjoutModifAbsence
    /// </summary>
    public class FrmAjoutModifAbsenceController
    {
        private readonly PersonnelAccess personnelAccess;
        private Personnel personnel;
        private Absence absence;
        /// <summary>
        /// Constructeur : iinstance unique de PersonnelAccess
        /// </summary>
        public FrmAjoutModifAbsenceController(Personnel personnel, Absence absence)
        {
            this.personnelAccess = new PersonnelAccess();   
            this.personnel = personnel; 
            this.absence = absence;
        }
        /// <summary>
        /// Retourne la liste des motifs
        /// </summary>
        /// <returns></returns>
        public List<Motif> getAllMotifs()
        {
            return personnelAccess.getAllMotifs();
        }
        /// <summary>
        /// Retourne la liste des absences d'un personnel
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <returns>List d'Absence</returns>
        public List<Absence> getPersonnelAbsences(int idPersonnel)
        {
            return personnelAccess.getPersonnelAbsences(idPersonnel);
        }
        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public void ajouterAbsence(DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            personnelAccess.ajouterAbsencePersonnel(this.personnel, dateDebut, dateFin, motif);
        }
        /// <summary>
        /// Met à jour les informations concernant une absence d'un personnel
        /// </summary>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public void updateAbsencePersonnel(DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            if(absence != null)
            {
                personnelAccess.updateAbsencePersonnel(personnel, dateDebut, dateFin, motif);
            }
        }
    }
}