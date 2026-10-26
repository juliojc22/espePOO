#  Sistema de Gestión Escolar

Un sistema web desarrollado para administrar y gestionar los procesos académicos, en una institución educativa.

---

  Integrantes y Entidades Desarrolladas

| Integrante | Entidad / Módulo Asignado | Descripción | Participación |
| :--- | :--- | :--- | :--- |
| **Julio Emerson Coro Pineida** | `Estudiante` | MODULO DE AULAS Y MAESTROS  | 100% |
| **Darla Sabrina Llano Guamani** | `Estudiante` | MODULO DE CALIFICACIONES Y ALUMNOS| 100% |


  Pasos para Ejecutar el Proyecto

Sigue estos pasos para configurar el entorno local, aplicar las migraciones de la base de datos y ejecutar la aplicación.

1. Requisitos Previos

* [.NET SDK](https://dotnet.microsoft.com/) (Versión 10.0.402)
* [SQL Server 2025]
* Entity Framework Core CLI instalado.
* SSMS 22
* Visual Studio 2026

---

2. Configurar la Cadena de Conexión (Connection String)

Abre el archivo `JSON.cs` ubicado en la raíz del proyecto principal y configura la cadena de conexión apuntando a tu servidor local de SQL Server:

```json
{
  "ConnectionStrings": {
    "SGEContext": "Server=localhost;Database=SGEADB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
  }
}

...

3. Pasos:
  Install-Package System.Security.Cryptography.Pkcs
  Add-Migration InitialCreate
  Update-Database
