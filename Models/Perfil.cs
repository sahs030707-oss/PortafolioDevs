namespace PortafolioDevs.Models;

public record Dato(string Etiqueta, string Valor);

public record GrupoHabilidades(string Nombre, string[] Items);

public record Proyecto(
    string Titulo,
    string Descripcion,
    string[] Tecnologias,
    string? UrlRepo = null,
    string? UrlDemo = null);

public record Perfil(
    string Nombre,
    string Rol,
    string Resumen,
    string SobreMi,
    string Correo,
    string GitHub,
    string LinkedIn,
    string UrlSitio,
    IReadOnlyList<Dato> Datos,
    IReadOnlyList<GrupoHabilidades> Habilidades,
    IReadOnlyList<Proyecto> Proyectos);
