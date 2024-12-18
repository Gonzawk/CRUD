# Proyecto de API Web y Aplicaci�n Web Conectada a una Base de Datos

Este proyecto incluye una soluci�n en blanco con:

- **API Web**: Implementada en C# usando Entity Framework para conectar a una base de datos MySQL. Incluye endpoints CRUD y documentaci�n generada con Swagger.
- **Aplicaci�n Web**: Desarrollada en HTML, CSS y JavaScript para interactuar con la API, permitiendo listar, dar de alta, modificar y eliminar datos.

## Tecnolog�as Utilizadas

- **Backend**: C#, Entity Framework, MySQL
- **Frontend**: HTML, CSS, JavaScript

## Instrucciones para Ejecutar el Proyecto

1. Clona el repositorio:
   ```sh
   git clone https://github.com/Gonzawk/CRUD.git

2.Restaurar y Configurar la Base de Datos:

Descarga el archivo de respaldo de la base de datos desde este enlace (https://drive.google.com/file/d/18pLgla4_9WznjXvt380aOSLhZqC0f1wq/view?usp=drive_link) y gu�rdalo en tu m�quina.

Restaura la base de datos usando MySQL.

Configura la cadena de conexi�n a la base de datos en el archivo de configuraci�n de la API (appsettings.json):

   "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=[nombre_de_base_de_datos];User Id=[usuario];Password=[contrase�a];"
    }

Reemplaza [nombre_de_base_de_datos], [usuario] y [contrase�a] con tus valores.

3.Restaura las dependencias y ejecuta la API:

                                                  dotnet restore
                                                  dotnet run

4.Abre la aplicaci�n web en el navegador y comienza a interactuar con la API.

Contribuciones
Las contribuciones son bienvenidas. Por favor, abre un issue o un pull request para sugerir mejoras o correcciones.

Licencia
Este proyecto est� licenciado bajo los t�rminos de la Licencia MIT.