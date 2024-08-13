using Ardalis.Result;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.Interfaces;
public interface IDeleteArticuloService
{
  public Task<Result> DeleteArticulo(Guid articuloId);
}
