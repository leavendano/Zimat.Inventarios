using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Precio : EntityBase<Guid>, IRegisterBase
{
    public int UnidadId { get; set; }
    public decimal Importe { get; set; }
    public decimal Descuento { get; set; }
    public string? Usuario { get; set; }
    public int Estado { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Precio(int unidadId, decimal importe, decimal descuento)
    {
        UnidadId = unidadId;
        Importe = importe;
        Descuento = descuento;
        Id = new UuidV7().Value;
        Estado = 1; // Activo por defecto
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
}