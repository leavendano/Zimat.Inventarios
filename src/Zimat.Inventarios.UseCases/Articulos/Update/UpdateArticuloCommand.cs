
using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Articulos.Update;
public record UpdateArticuloCommand(Guid ArticuloId, string Descripcion,decimal PrecioPublico) : ICommand<Result<ArticuloDTO>>;
