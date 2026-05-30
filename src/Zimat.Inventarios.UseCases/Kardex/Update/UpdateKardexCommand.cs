using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.Update;

public record UpdateKardexCommand(
    Guid KardexId,
    decimal Cantidad,
    decimal CostoUnitario) : ICommand<Result<KardexDTO>>;
