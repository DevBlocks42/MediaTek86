using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations des motifs d'absence
    /// </summary>
    public class Motif
    {
        private int idMotif;
        private String libelle;
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idMotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idMotif, String libelle) 
        { 
            this.idMotif = idMotif;
            this.libelle = libelle;
        }
    }
}
