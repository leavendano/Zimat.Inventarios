namespace Zimat.Inventarios.UseCases.Proveedores.List;
public interface IListProveedoresQueryService
{
  Task<IEnumerable<ProveedorDTO>> ListAsync();
}
