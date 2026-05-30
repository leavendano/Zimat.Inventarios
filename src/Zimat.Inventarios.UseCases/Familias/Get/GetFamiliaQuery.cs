using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Familias.Get;
public record GetFamiliaQuery(Guid FamiliaId) : IQuery<Result<FamiliaDTO>>;
