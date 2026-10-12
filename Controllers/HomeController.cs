using Microsoft.AspNetCore.Mvc;
using PortafolioDevs.Models;

namespace PortafolioDevs.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        
        var perfil = new Perfil(
            Nombre: "Steven Hernandez Sevilla",
            Rol: "Ingeniero en sistemas",
            Resumen: "Construyo aplicaciones web con .NET y las publico en Azure con despliegue automático.",
            SobreMi: "Soy estudiante y estoy aprendiendo a crear aplicaciones completas: desde la base de datos hasta la página que ve el usuario. " +
                     "Este portafolio es parte de ese proceso.",
            Correo: "sahs030707@gmail.com",
            GitHub: "https://github.com/sahs030707-oss",
            LinkedIn: "https://www.linkedin.com/in/noTengo",
            UrlSitio: "portafolio-tu-app.azurewebsites.net",
            Datos: new[]
            {
                new Dato("Estudio", "Ingenieria en sistemas de informacion"),
                new Dato("Ahora aprendo", "Flutter/Dart , MongDB ,Aplicacion en la Nube"),
                new Dato("Ubicación", "Masaya, Nicaragua"),
            },
            Habilidades: new[]
            {
                new GrupoHabilidades("Backend", new[] { "C#", "ASP.NET", "Entity Framework", "APIs REST" }),
                new GrupoHabilidades("Frontend", new[] { "HTML", "CSS", "Dart", "JavaScript" }),
                new GrupoHabilidades("Datos", new[] { "SQL Server", "MongoDB" , "FireBase" }),
                new GrupoHabilidades("Nube y herramientas", new[] { "Azure App Service", "Azure DevOps", "Git y GitHub" }),
            },
            Proyectos: new[]
            {
                new Proyecto(
                    "Este portafolio",
                    "Sitio personal en ASP.NET Core MVC con diseño responsive. Cada push a la rama main lo compila y lo publica en Azure App Service mediante un pipeline.",
                    new[] { "ASP.NET Core MVC", "Bootstrap", "Azure Pipelines" },
                    UrlRepo: "https://github.com/sahs030707-oss/PortafolioDevs.git",
                    UrlDemo: "https://portafolio-tu-app.azurewebsites.net"),
                new Proyecto(
                    "API REST PurisimoCafe",
                    "API desarrollada para gestionar y procesar solicitudes de manera eficiente, facilitando la comunicación entre aplicaciones y el manejo de datos.",
                    new[] { "C#", "SQL Server" },
                    UrlRepo: "https://github.com/sahs030707-oss/API_REST_PurisimoCafe.git"),
                new Proyecto(
                    "App Movil PurisimoCafe",
                    "Aplicación móvil de Purísimo Café, diseñada para ofrecer una experiencia intuitiva y facilitar el acceso a las funcionalidades del sistema de cafetería desde dispositivos móviles.",
                    new[] { "Flutter", "Dart" },
                    UrlRepo: "https://github.com/sahs030707-oss/PurisimoCafe-AppMovil.git"),
            });

        return View(perfil);
    }
}
