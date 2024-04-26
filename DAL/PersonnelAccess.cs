using MediaTek86.Model;

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
        /// <returns>List de Personnel</returns>
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
                            List<Absence> absences = getPersonnelAbsences(idPersonnel);
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
        /// <summary>
        /// Récupère la liste des absences d'un personnel dans la base de données
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <returns>List d'Absences absences</returns>
        public List<Absence> getPersonnelAbsences(int idPersonnel)
        {
            List<Absence> absences = new List<Absence>();
            String req = "SELECT * FROM absence WHERE idpersonnel=@idpersonnel ORDER BY datedebut";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@idpersonnel", idPersonnel}
            };
            try
            {
                List<Object[]> rows = access.bddManager.ReqSelect(req, parameters);
                foreach (Object[] row in rows)
                {
                    DateTime dateDebut = DateTime.Parse(row[1].ToString());
                    DateTime dateFin = DateTime.Parse(row[2].ToString());
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
        /// <summary>
        /// Récupère le libelle d'un motif
        /// </summary>
        /// <param name="idMotif"></param>
        /// <returns>String libelleMotif</returns>
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
        /// <summary>
        /// Ajoute un nouveau personnel dans la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idService"></param>
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
        /// <summary>
        /// Met à jour les informations concernant un personnel dans la base de données
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idService"></param>
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
        /// <summary>
        /// Supprime un personnel de la base de données
        /// </summary>
        /// <param name="idPersonnel"></param>
        public void supprimerPersonnel(int idPersonnel)
        {
            String req = "DELETE FROM personnel WHERE idpersonnel=@idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
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
        /// <summary>
        /// Supprime une absence d'un personnel dans la base de données
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="absence"></param>
        public void supprimerAbsence(Personnel personnel, Absence absence)
        {
            int idPersonnel = personnel.getIdPersonnel();
            DateTime dateDebut = absence.getDateDebut();
            String req = "DELETE FROM absence WHERE idpersonnel=@idpersonnel AND datedebut=@datedebut";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@idpersonnel", idPersonnel},
                {"@datedebut", dateDebut}
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
        /// <summary>
        /// Récupère la liste des noms de services 
        /// </summary>
        /// <returns>List de String nomServices</returns>
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
        /// <summary>
        /// Récupère la liste  des motifs dans la base de données
        /// </summary>
        /// <returns>List de Motif</returns>
        public List<Motif> getAllMotifs()
        {
            List<Motif> motifs = new List<Motif>();
            String req = "SELECT * FROM motif;";
            try
            {
                List<Object[]> rows = access.bddManager.ReqSelect(req);
                foreach (Object[] row in rows)
                {
                    motifs.Add(new Motif((int)row[0], (string)row[1]));
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(3306);
            }
            return motifs;
        }
        /// <summary>
        /// Ajoute une absence pour un personnel dans la base de données
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public void ajouterAbsencePersonnel(Personnel personnel, DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            String req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES(@idpersonnel, @datedebut, @datefin, @idmotif);";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@idpersonnel", personnel.getIdPersonnel()},
                {"@datedebut", dateDebut},
                {"@datefin", dateFin},
                {"@idmotif", motif.getIdMotif()}
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
        /// <summary>
        /// Met à jour une absence d'un personnel dans la base de données
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public void updateAbsencePersonnel(Personnel personnel, DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            String req = "UPDATE absence SET datedebut=@datedebut, datefin=@datefin, idmotif=@idmotif WHERE idpersonnel=@idpersonnel AND datedebut=@datedebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@idpersonnel", personnel.getIdPersonnel()},
                {"@datedebut", dateDebut},
                {"@datefin", dateFin},
                {"@idmotif", motif.getIdMotif()}
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
    }
}