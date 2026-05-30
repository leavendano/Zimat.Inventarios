using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Familias.Delete;

public record DeleteFamiliaCommand(Guid FamiliaId) : ICommand<Result>;
