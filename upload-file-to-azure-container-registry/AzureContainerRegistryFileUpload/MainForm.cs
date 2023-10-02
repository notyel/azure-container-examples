using Microsoft.Extensions.Configuration;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace AzureContainerRegistryFileUpload
{
    public partial class MainForm : Form
    {
        private readonly IConfiguration _configuration;
        public MainForm(IConfiguration configuration)
        {
            _configuration = configuration;
            InitializeComponent();
        }

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
    }
}