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
        /// <summary>
        /// Getter sur libelle
        /// </summary>
        /// <returns>String</returns>
        public String getLibelle()
        { 
            return libelle; 
        }
        /// <summary>
        /// Getter sur idMotif
        /// </summary>
        /// <returns>int idMotif</returns>
        public int getIdMotif()
        { 
            return idMotif; 
        } 
        /// <summary>
        /// Redéfinition de l'affichage de l'objet Motif
        /// </summary>
        /// <returns>string représentant l'instance de l'objet Motif</returns>
        public override string ToString()
        {
            return libelle;
        }
    }
}