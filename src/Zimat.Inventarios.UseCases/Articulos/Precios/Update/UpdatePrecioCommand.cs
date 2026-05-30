using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.Precios.Update;

public record UpdatePrecioCommand(
  Guid ArticuloId,
  Guid ArticuloUnidadId,
  Guid PrecioId,
  decimal ImportePrecio,
  decimal FactorCosto) : ICommand<Result>;
