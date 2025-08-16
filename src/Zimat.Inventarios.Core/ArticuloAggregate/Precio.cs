using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Precio(Guid articuloUnidadId, int numeroLista, decimal importePrecio, decimal factorCosto,string user = "ADMINISTRADOR") :
     EntityBase<Guid>, IRegisterBase
{
    public Precio(Guid articuloUnidadId, int numeroLista, decimal importePrecio, decimal factorCosto, string user = "ADMINISTRADOR", Guid? id = null) :
             this(articuloUnidadId, numeroLista, importePrecio, factorCosto, user)
    {
        Id = id ?? UuidV7.NewGuid();
        Status = RegisterStatus.Activo; // Assuming 1 means active
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    
    public int NumeroLista { get; init; } = Guard.Against.NegativeOrZero(numeroLista, nameof(numeroLista));
    public Guid ArticuloUnidadId { get; init; } = Guard.Against.Null(articuloUnidadId, nameof(articuloUnidadId));
    public decimal ImportePrecio { get; set; } = Guard.Against.NegativeOrZero(importePrecio, nameof(importePrecio));
    public decimal FactorCosto { get; set; } = Guard.Against.NegativeOrZero(factorCosto, nameof(factorCosto));
    public string? User { get; set; } = Guard.Against.NullOrEmpty(user, nameof(user));
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    
}