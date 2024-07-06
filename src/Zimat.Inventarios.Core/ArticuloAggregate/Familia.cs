using Ardalis.GuardClauses;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Familia(string descripcion) : RegisterBase
{
    public string Descripcion { get; set; } = Guard.Against.NullOrEmpty(descripcion,nameof(descripcion));
    public decimal Margen { get; set; } = 0;
}
