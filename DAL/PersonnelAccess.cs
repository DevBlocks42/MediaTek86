using MediaTek86.Model;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.DAL
{
    /// <summary>
    /// Classe d'accès aux données des personnels
    /// </summary>
    public class PersonnelAccess
    {
        /// <summary>
        /// Instance de Access
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// Constructeur, valorisation de la propriété access
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }
        public List<Personnel> getLesPersonnels() 
        { 
            List<Personnel> lesPersonnels = new List<Personnel>();
            if(access.bddManager != null)
            {
                String req = "SELECT * FROM personnel;";
                try
                {
                    List<Object[]> lignes = access.bddManager.ReqSelect(req);
                    foreach (Object[] l in lignes) 
                    {
                        int idPersonnel = (int)l[0];
                        String prenom = (String)l[1];
                        String nom = (String)l[2];
                        String tel = (String)l[3];
                        String mail = (String)l[4];
                        String _req = "SELECT nom FROM service WHERE idservice=@idservice";
                        Dictionary<string, object> parameters = new Dictionary<string, object>()
                        {
                            {"@idservice", l[5]}
                        };
                        try
                        {
                            List<Object[]> rows = access.bddManager.ReqSelect(_req, parameters);
                            Service service = new Service((int)l[5], rows[0].GetValue(0).ToString());
                            List<Absence> absences = null;
                            Personnel personnel = new Personnel(idPersonnel, prenom, nom, tel, mail, service, absences);
                            lesPersonnels.Add(personnel);
                        }
                        catch (Exception ex) 
                        {
                            Console.WriteLine(ex.Message);
                            Environment.Exit(3306);
                        }
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);  
                    Environment.Exit(3306);
                }
            }
            return lesPersonnels;
        }
    }
}
