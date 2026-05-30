
namespace Zimat.Inventarios.UseCases.Proveedores;

public record ProveedorDTO(
    Guid Id,
    string Clave,
    string Nombre,
    string Rfc,
    string CodigoPostal,
    string? Calle = null,
    string? NumeroExterior = null,
    string? Colonia = null,
    string? Ciudad = null,
    string? Estado = null,
    string? Telefono = null,
    string? Email = null,
    string? Clasificacion = null,
    string? Contacto = null,
    string? CuentaContable = null,
    int DiasCredito = 0,
    int TipoProveedor = 1
);
