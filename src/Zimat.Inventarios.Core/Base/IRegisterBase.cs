

public interface IRegisterBase
{
   public string? Usuario { get; set; }
  public int Estado { get; set; }
        
  public DateTime CreatedAt { get; set; }
        
  public DateTime UpdatedAt { get; set; }
}