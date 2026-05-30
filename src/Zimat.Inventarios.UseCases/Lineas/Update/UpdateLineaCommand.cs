using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Lineas.Update;
public record UpdateLineaCommand(Guid LineaId, string Descripcion,decimal Margen) : ICommand<Result<LineaDTO>>;