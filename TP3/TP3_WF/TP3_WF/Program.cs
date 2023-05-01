using TP3_WF.Entidades;

namespace TP3_WF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        // [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            GestorExperimento exp = new GestorExperimento();
            exp.realizarExperimento(10, 1, 5);
        }
    }
}