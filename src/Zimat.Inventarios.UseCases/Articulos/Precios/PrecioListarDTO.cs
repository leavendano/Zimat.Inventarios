namespace Zimat.Inventarios.UseCases.Articulos.Precios;

public class PrecioListarDTO
{
  public Guid Id { get; set; }
  public Guid ArticuloUnidadId { get; set; }
  public int NumeroLista { get; set; }
  public decimal ImportePrecio { get; set; }
  public decimal FactorCosto { get; set; }
  public string? User { get; set; }
  public int Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
