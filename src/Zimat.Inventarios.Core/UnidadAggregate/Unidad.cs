
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.UnidadAggregate;

public class Unidad : EntityBase<Guid>, IRegisterBase, IAggregateRoot
{
    public Unidad(string descripcion, string claveSat, string user = "Administrador") : base()
    {

        Descripcion  = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
        ClaveSat = Guard.Against.NullOrEmpty(claveSat,nameof(claveSat));
        Id =  UuidV7.NewGuid();
        User  = Guard.Against.NullOrEmpty(user,nameof(user));
        Status = RegisterStatus.Activo; // Activo por defecto
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    
    public string Descripcion { get; set; }
    public string ClaveSat { get; set; } 
    public string? User { get; set; } 
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public void UpdateDescripcion(string newName)
	{
		Descripcion = Guard.Against.NullOrEmpty(newName, nameof(newName));
		
	}
    public void UpdateClaveSat(string newClave)
	{
		ClaveSat = Guard.Against.NullOrEmpty(newClave, nameof(newClave));
		
	}

}
