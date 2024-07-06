using Ardalis.GuardClauses;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Departamento(string nombre) : RegisterBase
{
    public string Nombre { get; set; } = Guard.Against.NullOrEmpty(nombre,nameof(nombre));
   
}
