namespace Zimat.Inventarios.UseCases.Usuarios;
public record UsuarioDTO(
    Guid Id,
    string Clave,
    string Nombre,
    string Email,
    string Nivel,
    bool EsVendedor,
    decimal Comision,
    int ListaPrecio
);