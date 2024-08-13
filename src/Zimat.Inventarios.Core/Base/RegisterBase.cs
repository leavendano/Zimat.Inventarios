
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.Base;
public abstract class RegisterBase<TId> : EntityBase<TId> where TId : struct, IEquatable<TId>
{
  
  public string? Usuario { get; set; } = null;
  public int Estatus { get; set; } = 1;
        
  public DateTime CreatedAt { get; set; }
        
  public DateTime UpdatedAt { get; set; }
}


public abstract class RegisterBase: RegisterBase<int> 
{

}