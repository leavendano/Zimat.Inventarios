using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.Precios.Delete;

public record DeletePrecioCommand(
  Guid ArticuloId,
  Guid ArticuloUnidadId,
  Guid PrecioId) : ICommand<Result>;
