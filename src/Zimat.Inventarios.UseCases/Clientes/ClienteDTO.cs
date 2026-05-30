namespace Zimat.Inventarios.UseCases.Clientes;

public record ClienteDTO(
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
    string? Pais = null,
    string? Telefono = null,
    string? Email = null,
    string? ContactoVentas = null,
    string? ContactoPago = null,
    string? RegimenFiscal = null,
    string? UsoCfdi = null,
    string? Observaciones = null,
    int DiasCredito = 0,
    decimal LimiteCredito = 0
);
