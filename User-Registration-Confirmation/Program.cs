using User_Registration_Confirmation.Classes;

namespace User_Registration_Confirmation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            FirestoreHelper.SetEnvironmentVariable();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}