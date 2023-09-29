using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Configuración de la conexión desde appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("AzureStorage");

            // Parsear la cadena de conexión y obtener el cliente del blob
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Nombre del contenedor
            string containerName = "new-container";

            // Obtener una referencia al contenedor (los nombres de contenedores deben ser en minúsculas)
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(containerName.ToLower());

            // Crear el contenedor si no existe
            if (blobContainer.CreateIfNotExists())
            {
                blobContainer.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
                Console.WriteLine($"Container '{containerName}' created and made public.");
            }
            else
            {
                Console.WriteLine($"Container '{containerName}' already exists.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
