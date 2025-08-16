using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class ArticuloUnidad : EntityBase<Guid>, IRegisterBase
{
    public Guid ArticuloId { get; set; }
    public Guid UnidadId { get; set; }
    public decimal FactorConversion { get; set; }
    public string? User { get; set; }
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public ArticuloUnidad(Guid articuloId, Guid unidadId, decimal factorConversion)
    {
        ArticuloId = Guard.Against.Null(articuloId, nameof(articuloId));
        UnidadId = Guard.Against.Null(unidadId, nameof(unidadId));
        FactorConversion = Guard.Against.NegativeOrZero(factorConversion, nameof(factorConversion));
        Id = UuidV7.NewGuid();
        User = null;
        Status = RegisterStatus.Activo; // Activo por defecto
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
}