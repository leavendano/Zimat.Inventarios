namespace Zimat.Inventarios.UseCases.Clientes;

public record ClienteDTO(
    Guid Id,
    string Clave,
    string Nombre,
    string Rfc,
    string CodigoPostal
);