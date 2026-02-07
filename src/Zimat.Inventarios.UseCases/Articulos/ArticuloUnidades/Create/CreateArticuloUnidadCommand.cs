using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.ArticuloUnidades.Create;

public record CreateArticuloUnidadCommand(
  Guid ArticuloId,
  Guid UnidadId,
  decimal FactorConversion,
  string? UserName = null) : ICommand<Result<Guid>>;
