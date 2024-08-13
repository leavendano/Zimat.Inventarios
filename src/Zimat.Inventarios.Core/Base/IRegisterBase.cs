

public interface IRegisterBase
{
   public string? Usuario { get; set; }
  public int Estatus { get; set; }
        
  public DateTime CreatedAt { get; set; }
        
  public DateTime UpdatedAt { get; set; }
}