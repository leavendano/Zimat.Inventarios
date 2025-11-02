using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Familias.Update;
public record UpdateFamiliaCommand(Guid FamiliaId, string Descripcion, decimal Margen) : ICommand<Result<FamiliaDTO>>;
