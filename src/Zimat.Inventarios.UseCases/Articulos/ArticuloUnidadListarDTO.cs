namespace Zimat.Inventarios.UseCases.Articulos;

public class ArticuloUnidadListarDTO
{
  public Guid Id { get; set; }
  public Guid ArticuloId { get; set; }
  public Guid UnidadId { get; set; }
  
  public string? UnidadNombre { get; set; } = null;  // Nombre de la unidad
  public decimal FactorConversion { get; set; }
  public string? User { get; set; }
  public int Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
