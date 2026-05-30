using Ardalis.Specification;

namespace Zimat.Inventarios.Core.MarcaAggregate.Specifications;

public class MarcaByIdSpec : Specification<Marca>
{
    public MarcaByIdSpec(Guid marcaId)
    {
        Query.Where(marca => marca.Id == marcaId);
    }
}
