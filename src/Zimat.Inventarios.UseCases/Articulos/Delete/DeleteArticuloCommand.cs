using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Articulos.Delete;

public record DeleteArticuloCommand(Guid ArticuloId) : ICommand<Result>;
