using MediaTek86.Model;
using Microsoft.VisualBasic.Logging;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

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
        /// <summary>
        /// Récupère la liste des personnels
        /// </summary>
        /// <returns>List<Personnel></returns>
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
        public List<Absence> getPersonnelAbsences(int idPersonnel)
        {
            List<Absence> absences = new List<Absence>();
            String req = "SELECT * FROM absence WHERE idpersonnel=@idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@idpersonnel", idPersonnel}
            };
            try
            {
                List<Object[]> rows = access.bddManager.ReqSelect(req, parameters);
                foreach (Object[] row in rows)
                {
                    MySqlDateTime dateDebut = (MySqlDateTime)row[1];
                    MySqlDateTime dateFin = (MySqlDateTime)row[2];
                    int idMotif = (int)row[3];
                    Motif motif = new Motif(idMotif, getMotifLibelle(idMotif));
                    Absence absence = new Absence(idPersonnel, dateDebut, dateFin, motif);
                    absences.Add(absence);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(3306);
            }
            return absences;
        }
        public String getMotifLibelle(int idMotif)
        {
            String req = "SELECT libelle FROM motif WHERE idmotif=@idmotif";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@idmotif", idMotif}
            };
            try
            {
                List<Object[]> rows = access.bddManager.ReqSelect(req, parameters);
                return rows[0].GetValue(0).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(3306);
            }
            return null;
        }
        public void ajouterPersonnel(String nom, String prenom, String tel, String mail, int idService)
        {
            String req = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES(@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@nom", nom},
                {"@prenom", prenom},
                {"@tel", tel},
                {"@mail", mail},
                {"@idservice", idService}
            };
            try
            {
                access.bddManager.ReqUpdate(req, parameters);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(3306);
            }
        }
        public void updatePersonnel(int idPersonnel, String nom, String prenom, String tel, String mail, int idService)
        {
            String req = "UPDATE personnel SET nom=@nom, prenom=@prenom, tel=@tel, mail=@mail, idservice=@idservice WHERE idpersonnel=@idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@nom", nom},
                {"@prenom", prenom},
                {"@tel", tel},
                {"@mail", mail},
                {"@idservice", idService},
                {"@idpersonnel", idPersonnel}
            };
            try
            {
                access.bddManager.ReqUpdate(req, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(3306);
            }
        }
        public List<String> getNomServices()
        {
            List<String> noms = new List<String>();
            String req = "SELECT nom FROM service;";
            try
            {
                List<Object[]> rows = access.bddManager.ReqSelect(req);
                foreach (Object[] row in rows)
                {
                    noms.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(3306);
            }
            return noms;
        }
    }
}
