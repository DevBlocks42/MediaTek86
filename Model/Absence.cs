using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations des absences
    /// </summary>
    public class Absence
    {
        private int idAbsence;
        private DateOnly dateDebut;
        private DateOnly dateFin;
        private Motif motif;
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idAbsence"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public Absence(int idAbsence, DateOnly dateDebut, DateOnly dateFin, Motif motif) 
        { 
            this.idAbsence = idAbsence;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin; 
            this.motif = motif;
        }
    }
}
