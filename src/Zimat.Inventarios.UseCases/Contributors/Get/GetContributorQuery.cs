using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
