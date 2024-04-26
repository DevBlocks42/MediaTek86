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
        public List<Absence> getPersonnelAbsences(int idPersonnel)
        {
            return personnelAccess.getPersonnelAbsences(idPersonnel);
        }
        public void ajouterAbsence(DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            personnelAccess.ajouterAbsencePersonnel(this.personnel, dateDebut, dateFin, motif);
        }
        public void updateAbsencePersonnel(DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            if(absence != null)
            {
                personnelAccess.updateAbsencePersonnel(personnel, dateDebut, dateFin, motif);
            }
        }
    }
}