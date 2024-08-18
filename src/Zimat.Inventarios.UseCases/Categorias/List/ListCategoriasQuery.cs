using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Categorias.List;
public record ListCategoriasQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<CategoriaDTO>>>;

