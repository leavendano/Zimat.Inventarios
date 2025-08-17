
using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Unidades.Update;
public record UpdateUnidadCommand(Guid UnidadId, string Descripcion,string ClaveSat) : ICommand<Result<UnidadDTO>>;
