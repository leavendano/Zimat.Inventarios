using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.CategoriaAggregate;

public class Categoria(string descripcion, decimal margen = 0, string usuario = "ADMINISTRADOR") : EntityBase,IAggregateRoot, IRegisterBase
{
  public string Descripcion { get; set; } = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
  public decimal Margen { get; set; } = Guard.Against.Negative(margen, nameof(margen));
  public string? Usuario { get; set; } = Guard.Against.NullOrEmpty(usuario, nameof(usuario));
  public int Estatus { get; set; } = 1;
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }

}
