using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public String getNom()
        { 
            return nom; 
        }
        public int getIdService()
        { 
            return idService; 
        }   

    }
}
