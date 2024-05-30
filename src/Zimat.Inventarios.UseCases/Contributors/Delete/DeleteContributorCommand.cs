using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
