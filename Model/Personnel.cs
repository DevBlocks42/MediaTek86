namespace MediaTek86.Model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations d'un personnel
    /// </summary>
    public class Personnel
    {
        private int idPersonnel;
        private String nom;
        private String prenom;
        private String tel;
        private String mail;
        private Service service;
        private List<Absence> absences;
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        /// <param name="absences"></param>
        public Personnel(int idPersonnel, String nom, String prenom, String tel, String mail, Service service, List<Absence> absences) 
        { 
            this.idPersonnel = idPersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.service = service;
            this.absences = absences;   
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
        /// Getter sur prenom
        /// </summary>
        /// <returns>String prenom</returns>
        public String getPrenom()
        {
            return prenom;
        }
        /// <summary>
        /// Getter sur tel
        /// </summary>
        /// <returns>String tel</returns>
        public String getTel()
        {
            return tel;
        }
        /// <summary>
        /// Getter sur mail
        /// </summary>
        /// <returns>String mail</returns>
        public String getMail()
        {
            return mail;
        }
        /// <summary>
        /// Getter sur service
        /// </summary>
        /// <returns>Service service</returns>
        public Service getService()
        {
            return service;
        }
        /// <summary>
        /// Getter sur idPersonnel
        /// </summary>
        /// <returns>int idPersonnel</returns>
        public int getIdPersonnel()
        { 
            return idPersonnel; 
        }
        /// <summary>
        /// Getter sur absences
        /// </summary>
        /// <returns>List</returns>
        public List<Absence> getAbsences()
        {
            return absences;
        }
        /// <summary>
        /// Setter sur absences
        /// </summary>
        /// <param name="absences"></param>
        public void setAbsences(List<Absence> absences)
        {
            this.absences = absences;
        }
        /// <summary>
        /// Redéfinition de l'affichage par défaut de l'objet Personnel
        /// </summary>
        /// <returns>string représentant l'objet Personnel</returns>
        public override string ToString()
        {
            return nom + " " + prenom + "; Service : " + service.getNom();
        }
    }
}