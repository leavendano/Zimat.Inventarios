using Ardalis.Specification;

namespace Zimat.Inventarios.Core.ProveedorAggregate.Specifications;

public class ProveedorByIdSpec : Specification<Proveedor>
{
  public ProveedorByIdSpec(Guid proveedorId)
  {
    Query
        .Where(proveedor => proveedor.Id == proveedorId);
  }
}
