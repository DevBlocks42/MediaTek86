namespace MediaTek86.Model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations des services
    /// </summary>
    public class Service
    {
        private int idService;
        private String nom;
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        public Service(int idService, String nom) 
        {
            this.idService = idService;
            this.nom = nom;
        }
        /// <summary>
        /// Getter sur nom
        /// </summary>
        /// <returns>String nom</returns>
        public String getNom()
        { 
            return nom; 
        }
        /// <summary>
        /// Getter sur idService
        /// </summary>
        /// <returns>int idService</returns>
        public int getIdService()
        { 
            return idService; 
        }   
    }
}