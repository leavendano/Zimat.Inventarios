
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.Update;
public record UpdateArticuloCommand(int ArticuloId, string Descripcion,decimal PrecioPublico) : ICommand<Result<ArticuloDTO>>;
