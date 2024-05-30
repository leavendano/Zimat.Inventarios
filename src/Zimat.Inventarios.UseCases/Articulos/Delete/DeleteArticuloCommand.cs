using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.Delete;

public record DeleteArticuloCommand(int ArticuloId) : ICommand<Result>;
