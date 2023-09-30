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

            // Configuración de la conexión desde appsettings.json
            IConfiguration configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                  .Build();

            var serviceProvider = ConfigureServices(configuration);
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }

        /// <summary>
        /// Configura los servicios y la inyección de dependencias para la aplicación.
        /// </summary>
        /// <param name="configuration">La configuración de la aplicación proporcionada por IConfiguration.</param>
        /// <returns>Un proveedor de servicios que gestiona la resolución de dependencias.</returns>
        public static ServiceProvider ConfigureServices(IConfiguration configuration)

        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton(configuration);
            serviceCollection.AddTransient<MainForm>();
            return serviceCollection.BuildServiceProvider();
        }
    }
}