namespace MediaTek86.DAL
{
    /// <summary>
    /// Classe d'accès aux données du responsable 
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// Valorisation de access
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance(); 
        }
        /// <summary>
        /// Vérifie les identifiants du responsable
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <returns>True si les identifiants sont corrects, false si incorrects.</returns>
        public Boolean controleAuthentification(String login, String pass)
        {
            if(access.bddManager != null)
            {
                String req = "SELECT * FROM responsable WHERE login=@login AND pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"@login", login},
                    {"@pwd", pass}
                };
                try
                {
                    List<Object[]> records = access.bddManager.ReqSelect(req, parameters);
                    return records.Count > 0;
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(3306);
                }
            }
            return false;
        }
    }
}