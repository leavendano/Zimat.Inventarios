using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.Create;

public record CreateKardexCommand(
    Guid ArticuloId,
    int AlmacenId,
    int TipoMovimiento,
    DateTime Fecha,
    decimal Cantidad,
    decimal CostoUnitario,
    Guid? ReferenciaId = null,
    string? UserName = null) : ICommand<Result<Guid>>;
