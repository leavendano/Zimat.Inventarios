
using Ardalis.GuardClauses;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Unidad(string descripcion,string claveSat) : RegisterBase
{
    public string Descripcion { get; set; } = Guard.Against.NullOrEmpty(descripcion,nameof(descripcion));
    public string ClaveSat { get; set; } = Guard.Against.NullOrEmpty(claveSat,nameof(claveSat));
}
