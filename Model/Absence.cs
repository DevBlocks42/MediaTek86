using MySql.Data.Types;
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
        public DateTime getDateDebut()
        { 
            return dateDebut; 
        }   
        public override string ToString()
        {
            return "Absence du " + dateDebut.ToString() + " au " + dateFin.ToString() + " motif : " + motif.getLibelle();
        }
    }
}
