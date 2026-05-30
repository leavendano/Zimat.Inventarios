using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.Precios.Create;

public record CreatePrecioCommand(
  Guid ArticuloId,
  Guid ArticuloUnidadId,
  int NumeroLista,
  decimal ImportePrecio,
  decimal FactorCosto,
  string? UserName = null) : ICommand<Result<Guid>>;
