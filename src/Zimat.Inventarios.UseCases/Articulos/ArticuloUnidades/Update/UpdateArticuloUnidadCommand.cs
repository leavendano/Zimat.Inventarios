using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.ArticuloUnidades.Update;

public record UpdateArticuloUnidadCommand(
  Guid ArticuloId,
  Guid ArticuloUnidadId,
  decimal FactorConversion) : ICommand<Result>;
