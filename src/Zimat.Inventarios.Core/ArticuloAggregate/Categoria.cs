using Ardalis.GuardClauses;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Categoria(string descripcion) : RegisterBase
{
    public string Descripcion { get; set; } = Guard.Against.NullOrEmpty(descripcion,nameof(descripcion));
    public decimal Margen { get; set; } = 0;
}
