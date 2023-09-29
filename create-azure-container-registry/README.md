# Ejemplo: Crear un Registro de Contenedores en Azure

Este ejemplo muestra cómo crear un registro de contenedores en Microsoft Azure utilizando .NET 6 y Azure Storage. Un registro de contenedores es esencial para administrar y distribuir imágenes de contenedores en Azure.

![Validación en Azure Storage Explorer](screenshots/Screenshot_1.png)

Para validar el resultado final en Microsoft Azure Storage Explorer, sigue estos pasos:

1. Abre Microsoft Azure Storage Explorer y accede a tu cuenta de Azure.

2. Navega hasta el contenedor que creaste utilizando este ejemplo ("new-container" en este caso).

3. Verifica que el contenedor se haya creado correctamente y que esté listo para su uso.

¡Listo! Ahora puedes utilizar el contenedor en tus aplicaciones o cargar objetos en él según sea necesario.

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

## Ejecución del Ejemplo

1. Clona este repositorio a tu entorno de desarrollo local.

2. Abre el proyecto `create-azure-container-registry` en tu IDE.

3. Sigue las instrucciones en el archivo `Program.cs` para ejecutar el ejemplo. El código se encargará de crear un nuevo contenedor en tu cuenta de Azure Blob Storage.

4. Una vez ejecutado, el resultado se mostrará en la consola, indicando si el contenedor se creó correctamente o si ya existe.

