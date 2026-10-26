#  Sistema de Gestión Escolar

Un sistema web desarrollado para administrar y gestionar los procesos académicos, en una institución educativa.

---

  Integrantes y Entidades Desarrolladas

| Integrante | Entidad / Módulo Asignado | Descripción |
| :--- | :--- | :--- |
| **Julio Emerson Coro Pineida** | `Estudiante` | MODULO DE AULAS Y MAESTROS  |
| **Darla Sabrina Llano Guamani** | `Estudiante` | MODULO DE CALIFICACIONES Y ALUMNOS|


  Pasos para Ejecutar el Proyecto

Sigue estos pasos para configurar el entorno local, aplicar las migraciones de la base de datos y ejecutar la aplicación.

1. Requisitos Previos

* [.NET SDK](https://dotnet.microsoft.com/) (Versión 6.0, 7.0 u 8.0 según corresponda)
* [SQL Server 2025]
* Entity Framework Core CLI instalado.
* SSMS 22

---

2. Configurar la Cadena de Conexión (Connection String)

Abre el archivo `JSON.cs` ubicado en la raíz del proyecto principal y configura la cadena de conexión apuntando a tu servidor local de SQL Server:

```json
{
  "ConnectionStrings": {
    "SGEContext": "Server=localhost;Database=SGEADB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
  }
}
