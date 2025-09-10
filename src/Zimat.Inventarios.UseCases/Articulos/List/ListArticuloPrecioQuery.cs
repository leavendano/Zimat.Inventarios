using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.UseCases.Articulos;

namespace Zimat.Inventarios.UseCases.Articulos.List;

public record ListArticuloPrecioQuery(string? filtro,int? Skip, int? Take) : IQuery<Result<IEnumerable<ArticuloPrecioListarDTO>>>;
