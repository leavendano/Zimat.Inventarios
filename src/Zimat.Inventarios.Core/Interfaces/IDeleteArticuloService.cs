using Ardalis.Result;

namespace Zimat.Inventarios.Core.Interfaces;
public interface IDeleteArticuloService
{
  public Task<Result> DeleteArticulo(int articuloId);
}
