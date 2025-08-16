

public interface IRegisterBase
{
   public string? User { get; set; }
  public int Status { get; set; }
        
  public DateTime CreatedAt { get; set; }
        
  public DateTime UpdatedAt { get; set; }
}