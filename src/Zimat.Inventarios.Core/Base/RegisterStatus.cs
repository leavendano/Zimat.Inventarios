using Ardalis.SmartEnum;

namespace Zimat.Inventarios.Core.Base;

public class RegisterStatus : SmartEnum<RegisterStatus>
{
  public static readonly RegisterStatus Inactivo = new(nameof(Inactivo), 0);
  public static readonly RegisterStatus Activo = new(nameof(Activo), 1);
  
  protected RegisterStatus(string name, int value) : base(name, value) { }
}

