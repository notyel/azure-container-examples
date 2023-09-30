using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AzureContainerRegistryFileUpload
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configuraci�n de la conexi�n desde appsettings.json
            IConfiguration configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                  .Build();

            var serviceProvider = ConfigureServices(configuration);
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }

        /// <summary>
        /// Configura los servicios y la inyecci�n de dependencias para la aplicaci�n.
        /// </summary>
        /// <param name="configuration">La configuraci�n de la aplicaci�n proporcionada por IConfiguration.</param>
        /// <returns>Un proveedor de servicios que gestiona la resoluci�n de dependencias.</returns>
        public static ServiceProvider ConfigureServices(IConfiguration configuration)

        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton(configuration);
            serviceCollection.AddTransient<MainForm>();
            return serviceCollection.BuildServiceProvider();
        }
    }
}