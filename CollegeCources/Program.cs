using CollegeCources.Views;
using Microsoft.Extensions.Configuration;
namespace CollegeCources
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                      .AddUserSecrets<Program>()
                      .Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CourseCreationForm());
        }
    }
}