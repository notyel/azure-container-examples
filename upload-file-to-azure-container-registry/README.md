



# Ejemplo: Subir Archivos a Azure Blob Storage con .NET Core

Este ejemplo muestra cómo cargar un archivo en un contenedor de Azure Blob Storage utilizando .NET Core. Azure Blob Storage es un servicio de almacenamiento en la nube altamente escalable y duradero ofrecido por Microsoft Azure.

## Requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/) con soporte para .NET 6.
- Una cuenta de Microsoft Azure con un servicio de almacenamiento de blobs configurado.

## Configuración

Antes de ejecutar este ejemplo, asegúrate de configurar la cadena de conexión a tu servicio de almacenamiento de blobs de Azure en el archivo `appsettings.json`. La cadena de conexión se debe definir en la sección `"AzureStorage"` del archivo como se muestra a continuación:

```json
{
  "ConnectionStrings": {
    "AzureStorage": "Tu Cadena de conexión de Azure Storage"
  }
}
```

Reemplaza `"Tu Cadena de conexión de Azure Storage"` con la cadena de conexión real proporcionada por tu cuenta de Azure.

El proyecto **AzureContainerRegistryFileUpload** tiene las siguientes referencias de paquete:

**[net6.0-windows7.0]:**
   | Paquete de nivel superior                                | Solicitado | Resuelto |
   | --------------------------------------------------------- | ---------- | --------- |
   | Microsoft.Azure.Storage.Blob                           | 11.2.3     | 11.2.3    |
   | Microsoft.Extensions.Configuration                     | 7.0.0      | 7.0.0     |
   | Microsoft.Extensions.Configuration.FileExtensions      | 7.0.0      | 7.0.0     |
   | Microsoft.Extensions.Configuration.Json                | 7.0.0      | 7.0.0     |
   | Microsoft.Extensions.DependencyInjection               | 7.0.0      | 7.0.0     |

Puedes listar estas referencias de paquete utilizando el siguiente comando:

```shell
dotnet list AzureContainerRegistryFileUpload.sln package
```

## Ejecución del Ejemplo

1. Clona este repositorio a tu entorno de desarrollo local.

2. Abre el proyecto `upload-file-to-azure-container-registry` en tu IDE.

3. Sigue las instrucciones en el archivo `MainForm.cs` para ejecutar el ejemplo. El código se encargará de mostrar un cuadro de diálogo para seleccionar un archivo y luego lo cargará en tu cuenta de Azure Blob Storage.

4. Una vez ejecutado, el resultado se mostrará en una ventana emergente, indicando si el archivo se cargó correctamente o si ocurrió algún error.

## Código de Ejemplo

```csharp
private void btnFileUpload_Click(object sender, EventArgs e)
{
    OpenFileDialog openFileDialog = new OpenFileDialog();

    // Configura las propiedades del cuadro de diálogo de selección de archivo
    openFileDialog.Title = "Seleccionar archivo para cargar en Blob Storage";
    openFileDialog.Filter = "Todos los archivos (*.*)|*.*";

    // Muestra el cuadro de diálogo de selección de archivo
    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
        // Obtiene la ruta del archivo seleccionado
        string filePath = openFileDialog.FileName;
        string fileName = Path.GetFileName(filePath);
        string containerName = "new-container";
        string connectionString = _configuration.GetConnectionString("AzureStorage");

        CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
        CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
        CloudBlobContainer blobContainer = blobClient.GetContainerReference(containerName.ToLower());
        CloudBlockBlob cloudBlockBlob = blobContainer.GetBlockBlobReference(fileName.ToLower());

        try
        {
            cloudBlockBlob.UploadFromFile(filePath);

            MessageBox.Show($"El archivo '{fileName}' se ha cargado correctamente en tu Blob Storage de Azure.", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar el archivo '{fileName}' en Blob Storage de Azure: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
```

## Información Adicional

Azure Blob Storage es un servicio versátil que proporciona durabilidad, alta disponibilidad, escalabilidad y seguridad para diversos tipos de datos en la nube. Puedes acceder a los objetos de Blob Storage desde cualquier parte del mundo mediante protocolos como HTTP o HTTPS.

Si deseas explorar más sobre Azure Blob Storage, puedes consultar la [documentación oficial de Azure Storage](https://docs.microsoft.com/en-us/azure/storage/).

¡Disfruta explorando este ejemplo y experimentando con Azure Blob Storage!

**Nota:** Este README.md es un ejemplo y debe adaptarse según tus necesidades y el contenido específico de tu proyecto.
