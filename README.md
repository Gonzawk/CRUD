# Proyecto de API Web y Aplicación Web Conectada a una Base de Datos

Este proyecto incluye una solución en blanco con:

- **API Web**: Implementada en C# usando Entity Framework para conectar a una base de datos MySQL. Incluye endpoints CRUD y documentación generada con Swagger.
- **Aplicación Web**: Desarrollada en HTML, CSS y JavaScript para interactuar con la API, permitiendo listar, dar de alta, modificar y eliminar datos.

## Tecnologías Utilizadas

- **Backend**: C#, Entity Framework, MySQL
- **Frontend**: HTML, CSS, JavaScript

## Instrucciones para Ejecutar el Proyecto

1. Clona el repositorio:
   ```sh
   git clone https://github.com/Gonzawk/CRUD.git

2.Restaurar y Configurar la Base de Datos:

Descarga el archivo de respaldo de la base de datos desde este enlace (https://drive.google.com/file/d/18pLgla4_9WznjXvt380aOSLhZqC0f1wq/view?usp=drive_link) y guárdalo en tu máquina.

Restaura la base de datos usando MySQL.

Configura la cadena de conexión a la base de datos en el archivo de configuración de la API (appsettings.json):

   "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=[nombre_de_base_de_datos];User Id=[usuario];Password=[contraseña];"
    }

Reemplaza [nombre_de_base_de_datos], [usuario] y [contraseña] con tus valores.

3.Restaura las dependencias y ejecuta la API:

                                                  dotnet restore
                                                  dotnet run

4.Abre la aplicación web en el navegador y comienza a interactuar con la API.

Contribuciones
Las contribuciones son bienvenidas. Por favor, abre un issue o un pull request para sugerir mejoras o correcciones.

Licencia
Este proyecto está licenciado bajo los términos de la Licencia MIT.