namespace Zimat.Inventarios.UseCases.Articulos;

public class ArticuloUnidadPrecioDTO
{
    public Guid Id { get; set; }
    public string Clave { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal Impuesto1 { get; set; }
    public decimal Impuesto2 { get; set; }
    public string? RutaImagen { get; set; }
    public decimal StockActual { get; set; }
    public Guid? ArticuloUnidadId { get; set; }
    public Guid? UnidadId { get; set; }
    public string? NombreUnidad { get; set; }
    public int? Noprecio { get; set; }
    public decimal? ImportePrecio { get; set; }
}

