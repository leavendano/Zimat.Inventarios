using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;

namespace Zimat.Inventarios.UseCases.Articulos;

public class ArticuloPrecioListarDTO
{
    public Guid Id { get; set; }
    public string Clave { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal Impuesto1 { get; set; }
    public decimal Impuesto2 { get; set; }
    public string? RutaImagen { get; set; } 
    public decimal StockActual { get; set; }
    public Guid? UnidadId { get; set; }
    public string Unidad { get; set; } = string.Empty;
    public decimal PrecioPublico { get; set; }
    public decimal Cantidad { get; set; }
    public List<ArticuloUnidadDTO> Unidades { get; set; } = new List<ArticuloUnidadDTO>();
}


public class ArticuloUnidadDTO
{
    public Guid? Id { get; set; }
    public Guid? ArticuloId { get; set; }
    public Guid? UnidadId { get; set; }
    public string? NombreUnidad { get; set; }
    public List<Precio> Precios { get; set; } = new List<Precio>();
}

public class Precio
{
    public Guid? Id { get; set; }
    public int? NoLista { get; set; }
    public Guid ArticuloUnidadId { get; set; }
    public decimal? ImportePrecio { get; set; }
}

