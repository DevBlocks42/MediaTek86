using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public String getNom()
        { 
            return nom; 
        } 
        public String getPrenom()
        {
            return prenom;
        }
        public String getTel()
        {
            return tel;
        }
        public String getMail()
        {
            return mail;
        }
        public Service getService()
        {
            return service;
        }
        public int getIdPersonnel()
        { 
            return idPersonnel; 
        }
        public List<Absence> getAbsences()
        {
            return absences;
        }
        public void setAbsences(List<Absence> absences)
        {
            this.absences = absences;
        }
        public override string ToString()
        {
            return nom + " " + prenom + "; Service : " + service.getNom();
        }
    }
}
