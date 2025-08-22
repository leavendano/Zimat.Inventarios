using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Articulo : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{


  public Articulo(string clave, string descripcion, decimal precioPublico, Guid unidadId, string? user) : base()
  {
    Clave = Guard.Against.NullOrEmpty(clave, nameof(clave));
    Descripcion = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
    PrecioPublico = Guard.Against.NegativeOrZero(precioPublico, nameof(precioPublico));
    Id = UuidV7.NewGuid();
    UnidadId = Guard.Against.NullOrEmpty(unidadId, nameof(unidadId));
    User = user;
    Status = RegisterStatus.Activo; // Activo por defecto
    StockActual = 0;
    StockMinimo = 0;
    StockMaximo = 0;
    CreatedAt = DateTime.UtcNow;
    UpdatedAt = DateTime.UtcNow;
	}
  public string Clave {get; private set;}
  public string Descripcion { get; private set;} 
  public string? Observaciones { get; set;}
  public string? CodigoBarras { get; set; }
  public Guid UnidadId  { get; set;} 
  public string? Marca  { get; set;}
  public string? Modelo  { get; set;}
  public Guid? LineaId  { get; set;} 
  public Guid? FamiliaId  { get; set;}
  public Guid? CategoriaId  { get; set;}
  public Guid? DepartamentoId  { get; set;}
  public string? Ubicacion  { get; set;}
  public bool Series  { get; set;}
  public decimal Impuesto1 { get; set;}
  public decimal Impuesto2  { get; set;}
  public string? ClaveSat { get; set;}
  public Guid? UltimaCompra { get; set; }
  public Guid? UltimaVenta  { get; set;}
  public decimal StockActual { get; set;}
  public decimal StockMinimo  { get; set;} 
  public decimal StockMaximo { get; set; } 
  public int StockStatus { get; set; } = 0; // 0: Normal, 1: Bajo, 2: Alto
  
  public decimal PrecioPublico { get; set; } 
  public decimal DescuentoMaximo { get; set;}
  public decimal? CostoUnitario { get; set;}
  public decimal? CostoPromedio { get; set;}
  public string? RutaImagen { get; set; }
  
  public decimal PesoNeto { get; set; }
  public string? User { get; set; }	
  public int Status { get; set;}
  public DateTime CreatedAt { get; set;}
  public DateTime UpdatedAt { get; set;}


	public void UpdateDescripcion(string newName)
	{
		Descripcion = Guard.Against.NullOrEmpty(newName, nameof(newName));
		
	}

	public void UpdatePrecio(decimal nuevoPrecio)
	{
		PrecioPublico = Guard.Against.NegativeOrZero(nuevoPrecio,nameof(nuevoPrecio));
	}

}
