using Ardalis.Specification;


namespace Zimat.Inventarios.Core.TipoDocumentoAggregate.Specifications;
public class TipoDocumentoByIdSpec : Specification<TipoDocumento>
{
  public TipoDocumentoByIdSpec(int tipoDocumentoId)
  {
    Query
        .Where(tipoDocumento => tipoDocumento.Id == tipoDocumentoId);
  }
}
