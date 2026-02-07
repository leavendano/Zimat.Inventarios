using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.ArticuloUnidades.Delete;

public record DeleteArticuloUnidadCommand(
  Guid ArticuloId,
  Guid ArticuloUnidadId) : ICommand<Result>;
