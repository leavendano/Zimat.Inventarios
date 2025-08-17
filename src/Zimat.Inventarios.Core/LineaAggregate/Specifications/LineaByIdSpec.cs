using Ardalis.Specification;


namespace Zimat.Inventarios.Core.LineaAggregate.Specifications;
public class LineaByIdSpec : Specification<Linea>
{
  public LineaByIdSpec(Guid lineaId)
  {
    Query
        .Where(linea => linea.Id == lineaId);
  }
}