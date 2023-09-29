<p align="center">
  <img src="assets/logo-microsoft-azure.png" alt="Logo de Microsoft Azure" width="50%">
</p>

# Azure Container Examples

Este repositorio contiene ejemplos y muestras de código en .NET 6 para trabajar con contenedores en Microsoft Azure. Los ejemplos proporcionados están diseñados para ayudarte a comprender y utilizar funcionalidades comunes relacionadas con la gestión de contenedores en Azure.

## Ejemplos Disponibles

Actualmente, este repositorio incluye los siguientes ejemplos:

1. **create-azure-container-registry**: Ejemplo que demuestra cómo crear un registro de contenedores en Azure.
2. **upload-file-to-azure-container-registry**: Ejemplo que ilustra cómo cargar un archivo en un registro de contenedores de Azure.

**Nota:** Este repositorio está en constante desarrollo y se agregará más ejemplos en el futuro. Estoy comprometido a proporcionar ejemplos útiles y actualizados para ayudarte en tu trabajo con contenedores en Azure. ¡Mantente atento a futuras actualizaciones!

## Requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/) con soporte para .NET 6.
- Una cuenta de Microsoft Azure para probar los ejemplos.
- Microsoft Azure Storage Explorer: Se utiliza para validar los resultados de los ejemplos y gestionar el almacenamiento en la nube de Azure.

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

4. Reemplaza `"Tu Cadena de conexión de Azure Storage"` con la cadena de conexión real proporcionada por tu cuenta de Azure.

5. Guarda el archivo `appsettings.json` con los cambios realizados.

Ahora, el proyecto utilizará esta cadena de conexión para interactuar con Azure Blob Storage según lo necesite el ejemplo.

## Introducción a Azure Storage:
- Azure Storage es la **solución de almacenamiento en la nube** de Microsoft que ofrece **almacenamiento altamente disponible, escalable, duradero y seguro** para una amplia variedad de objetos de datos en la nube.
- Los objetos de datos de Azure Storage son accesibles desde cualquier lugar del mundo a través de **HTTP o HTTPS** mediante una **API REST**.
- Ofrece bibliotecas cliente para desarrolladores en varios lenguajes, incluyendo **.NET, Java, Python, JavaScript, C++, y Go**.
- Se pueden usar herramientas como **Azure PowerShell, la CLI de Azure, Azure Portal** y el **Explorador de Azure Storage** para interactuar con Azure Storage.

**Ventajas de Azure Storage:**
- Ofrece **durabilidad y alta disponibilidad** mediante **redundancia de datos** y la opción de **replicación** entre centros de datos o regiones geográficas.
- Proporciona **seguridad** mediante el **cifrado de datos**.
- Es **escalable** para satisfacer las necesidades de rendimiento y almacenamiento de aplicaciones modernas.
- Azure gestiona automáticamente el **mantenimiento y las actualizaciones del hardware**.
- Permite el **acceso global a los datos** a través de **HTTP o HTTPS** y proporciona bibliotecas cliente en varios lenguajes.

**Servicios de datos de Azure Storage:**

<p align="center">
  <img src="assets/azure-storage-types.webp" alt="Servicios de datos de Azure Storage" width="50%">
</p>

- **Azure Blob Storage:** Almacén de objetos escalable para datos de texto y binarios, con compatibilidad para análisis de macrodatos a través de **Data Lake Storage Gen2**.
- **Azure Files:** Recursos compartidos de archivos administrados para implementaciones locales y en la nube.
- **Azure Elastic SAN (versión preliminar):** Solución totalmente integrada para implementar y administrar una SAN en Azure.
- **Azure Queue Storage:** Almacén de mensajería para la comunicación confiable entre componentes de la aplicación.
- **Azure Table Storage:** Almacén NoSQL para el almacenamiento sin esquema de datos estructurados.
- **Managed Disks:** Volúmenes de almacenamiento de nivel de bloque para máquinas virtuales de Azure.
- **Azure NetApp Files (almacenamiento de archivos de empresa):** Proporciona migración y ejecución de aplicaciones basadas en archivos sin cambios en el código.

En resumen, **Azure Storage** es una **solución versátil** que proporciona **durabilidad, alta disponibilidad, escalabilidad y seguridad** para diversos tipos de datos en la nube. Cada servicio de datos dentro de **Azure Storage** ofrece características específicas para diferentes escenarios de almacenamiento.

## Contribución

¡Contribuciones son bienvenidas! Si deseas mejorar estos ejemplos o agregar nuevos, por favor sigue estas pautas:

1. Crea una bifurcación (fork) de este repositorio.

2. Realiza tus cambios en tu bifurcación.

3. Envía una solicitud de extracción (pull request) con una descripción detallada de tus cambios.

## Licencia

Este proyecto se encuentra bajo la licencia [MIT](LICENSE).

