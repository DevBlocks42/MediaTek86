namespace MediaTek86
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entr�e de l'application
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MediaTek86.View.FrmConnexion());
        }
    }
}