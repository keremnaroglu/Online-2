using Online2.WinUI.EfContextInjection;

namespace Online2.WinUI
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
            ApplicationConfiguration.Initialize();

            var form = EFContextForm.ConfigureServices<Login>();
            Application.Run(form);
        }
    }
}