namespace Zimat.Inventarios.UseCases.Kardex;

public record KardexDTO(
    Guid Id,
    Guid ArticuloId,
    int AlmacenId,
    int TipoMovimiento,
    DateTime Fecha,
    decimal Cantidad,
    decimal CostoUnitario,
    decimal CostoTotal,
    Guid? ReferenciaId,
    string? User);
