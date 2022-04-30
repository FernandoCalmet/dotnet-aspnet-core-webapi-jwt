# 🦄 C# ASP.NET CORE 5 API JWT

[![Github][github-shield]][github-url]
[![Kofi][kofi-shield]][kofi-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Khanakat][khanakat-shield]][khanakat-url]

## TABLA DE CONTENIDO

* [Acerca del proyecto](#acerca-del-proyecto)
* [Instalación](#instalación)
* [Dependencias](#dependencias)
* [Licencia](#licencia)

## 🔥 ACERCA DEL PROYECTO

Este proyecto es una muestra de una aplicación API con seguridad de JWT. Se utilizo ``ASP.NET Core 5 Web API`` con C# + JWT (Json Web Token).

## ⚙️ INSTALACIÓN

Clonar el repositorio.

```bash
gh repo clone FernandoCalmet/dotnet-5-aspnet-core-api-jwt
```

Crear la migración de base de datos

```bash
update-database
```

Ejecutar aplicación.

```bash
dotnet run
```

## 📥 DEPENDENCIAS

- [Microsoft.AspNetCore.Authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/) : Middleware ASP.NET Core que permite que una aplicación reciba un token de portador de OpenID Connect.
- [Microsoft.AspNetCore.Identity.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.AspNetCore.Identity.EntityFrameworkCore/) : Proveedor de identidad ASP.NET Core que usa Entity Framework Core.
- [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/) : Entity Framework Core es un mapeador de bases de datos de objetos moderno para .NET. Admite consultas LINQ, seguimiento de cambios, actualizaciones y migraciones de esquemas. EF Core funciona con SQL Server, Azure SQL Database, SQLite, Azure Cosmos DB, MySQL, PostgreSQL y otras bases de datos a través de una API de complemento de proveedor.
- [Microsoft.EntityFrameworkCore.Design](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/) : Componentes compartidos en tiempo de diseño para las herramientas de Entity Framework Core.
- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/) : Proveedor de base de datos de Microsoft SQL Server para Entity Framework Core.
- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/) : Entity Framework Core Tools para la consola del administrador de paquetes NuGet en Visual Studio.
- [Microsoft.VisualStudio.Web.CodeGeneration.Design](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/) : Herramienta de generación de código para ASP.NET Core. Contiene el comando dotnet-aspnet-codegenerator que se usa para generar controladores y vistas.
- [System.IdentityModel.Tokens.Jwt](https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt/) : Incluye tipos que brindan soporte para crear, serializar y validar JSON Web Tokens.
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/) : Herramientas Swagger para documentar API creadas en ASP.NET Core.

## 📄 LICENCIA

Este proyecto está bajo la Licencia (Licencia MIT) - mire el archivo [LICENSE](LICENSE) para más detalles.

## ⭐️ DAME UNA ESTRELLA

Si esta Implementación le resultó útil o la utilizó en sus Proyectos, déle una estrella. ¡Gracias! O, si te sientes realmente generoso, [¡Apoye el proyecto con una pequeña contribución!](https://ko-fi.com/fernandocalmet).

<!--- reference style links --->
[github-shield]: https://img.shields.io/badge/-@fernandocalmet-%23181717?style=flat-square&logo=github
[github-url]: https://github.com/fernandocalmet
[kofi-shield]: https://img.shields.io/badge/-@fernandocalmet-%231DA1F2?style=flat-square&logo=kofi&logoColor=ff5f5f
[kofi-url]: https://ko-fi.com/fernandocalmet
[linkedin-shield]: https://img.shields.io/badge/-fernandocalmet-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/fernandocalmet
[linkedin-url]: https://www.linkedin.com/in/fernandocalmet
[khanakat-shield]: https://img.shields.io/badge/khanakat.com-brightgreen?style=flat-square
[khanakat-url]: https://khanakat.com
