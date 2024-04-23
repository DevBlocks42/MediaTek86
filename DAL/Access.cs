using Microsoft.VisualBasic.Logging;
using MediaTek86.BddManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MediaTek86.DAL
{
    /// <summary>
    /// Singleton : classe d'accès à BddManager
    /// </summary>
    public class Access
    {
        /// <summary>
        /// Instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Nom de connexion à la bdd
        /// </summary>
        private static readonly string connectionName = "MediaTek86.Properties.Settings.connectionString";
        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager.BddManager bddManager { get; }

        private Access() 
        {
            String connectionString = GetConnectionStringByName(connectionName);
            bddManager = BddManager.BddManager.GetInstance(connectionString);
        }
        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns>Instance unique de la classe d'accès à la base de données</returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
        /// <summary>
        /// Récupération de la chaîne de connexion
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Chaîne de connexion à la base de données</returns>
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
    }
}
