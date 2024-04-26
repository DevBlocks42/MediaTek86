namespace MediaTek86.Model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations des absences
    /// </summary>
    public class Absence
    {
        private int idPersonnel;
        private DateTime dateDebut;
        private DateTime dateFin;
        private Motif motif;
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, Motif motif) 
        { 
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin; 
            this.motif = motif;
        }
        /// <summary>
        /// Getter sur dateDebut
        /// </summary>
        /// <returns>DateTime date</returns>
        public DateTime getDateDebut()
        { 
            return dateDebut; 
        }
        /// <summary>
        /// Getter sur dateFin
        /// </summary>
        /// <returns>DateTime dateFin</returns>
        public DateTime getDateFin()
        {  
            return dateFin; 
        }
        /// <summary>
        /// Getter sur motif
        /// </summary>
        /// <returns>Motif motif</returns>
        public Motif getMotif()
        { 
            return motif; 
        }   
        /// <summary>
        /// Redéfinit l'affichage par défaut de l'objet Absence
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Absence du " + dateDebut.ToString("dd/MM/yyyy") + " au " + dateFin.ToString("dd/MM/yyyy") + " motif : " + motif.getLibelle();
        }
    }
}