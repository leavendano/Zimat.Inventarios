using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.DepartamentoAggregate;

public class Departamento(string nombre, string usuario = "ADMINISTRADOR") : EntityBase, IAggregateRoot, IRegisterBase
{
  public string Nombre { get; set; } = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
  public string? Usuario { get; set; } = Guard.Against.NullOrEmpty(usuario, nameof(usuario));
  public int Estatus { get; set; } = 1;
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }

}
