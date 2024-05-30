
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.Base;
public abstract class RegisterBase : EntityBase
{
  public string? Usuario { get; set; } = null;
  public int Estatus { get; set; } = 1;
        
  public DateTime CreatedAt { get; set; }
        
  public DateTime UpdatedAt { get; set; }
}