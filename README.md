# Azure Container Examples

Este repositorio contiene ejemplos y muestras de código en .NET 6 para trabajar con contenedores en Microsoft Azure. Los ejemplos proporcionados están diseñados para ayudarte a comprender y utilizar funcionalidades comunes relacionadas con la gestión de contenedores en Azure.

## Ejemplos Disponibles

Actualmente, este repositorio incluye los siguientes ejemplos:

1. **create-azure-container-registry**: Ejemplo que demuestra cómo crear un registro de contenedores en Azure.

**Nota:** Este repositorio está en constante desarrollo y se agregará más ejemplos en el futuro. Estoy comprometido a proporcionar ejemplos útiles y actualizados para ayudarte en tu trabajo con contenedores en Azure. ¡Mantente atento a futuras actualizaciones!

## Requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/) con soporte para .NET 6.
- Una cuenta de Microsoft Azure para probar los ejemplos.

## Cómo Empezar

1. Clona este repositorio a tu entorno de desarrollo local.

2. Abre el proyecto de ejemplo que deseas ejecutar en tu IDE.

3. Sigue las instrucciones específicas del ejemplo en su README.md correspondiente para ejecutar y probar el código.

## Configuración de la Cadena de Conexión

Para ejecutar los ejemplos en este repositorio, debes configurar la cadena de conexión a tu servicio de Azure Blob Storage en el archivo `appsettings.json`. Sigue estos pasos:

1. Abre el archivo `appsettings.json` en el proyecto de ejemplo que deseas ejecutar.

2. Encuentra la sección `"ConnectionStrings"` en el archivo.

3. Dentro de `"ConnectionStrings"`, agrega o actualiza la entrada `"AzureStorage"` con tu propia cadena de conexión de Blob Storage de Azure:

```json
{
  "ConnectionStrings": {
    "AzureStorage": "Tu Cadena de conexión de Azure Storage"
  }
}
```

4. Reemplaza `"Tu Cadena de conexión de blobstorage"` con la cadena de conexión real proporcionada por tu cuenta de Azure.

5. Guarda el archivo `appsettings.json` con los cambios realizados.

Ahora, el proyecto utilizará esta cadena de conexión para interactuar con Azure Blob Storage según lo necesite el ejemplo.

## Contribución

¡Contribuciones son bienvenidas! Si deseas mejorar estos ejemplos o agregar nuevos, por favor sigue estas pautas:

1. Crea una bifurcación (fork) de este repositorio.

2. Realiza tus cambios en tu bifurcación.

3. Envía una solicitud de extracción (pull request) con una descripción detallada de tus cambios.

## Licencia

Este proyecto se encuentra bajo la licencia [MIT](LICENSE).

