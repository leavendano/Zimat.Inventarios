
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.UnidadAggregate;

public class Unidad(string descripcion, string claveSat, string usuario = "ADMINISTRADOR") : EntityBase<Guid>, IRegisterBase
{
    public Unidad(string descripcion, string claveSat, string usuario = "ADMINISTRADOR", Guid? id = null) : this(descripcion, claveSat, usuario)
    {
        Id = id ?? UuidV7.NewGuid();
    }
    
    public string Descripcion { get; set; } = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
    public string ClaveSat { get; set; } = Guard.Against.NullOrEmpty(claveSat,nameof(claveSat));
    public string? Usuario { get; set; } = Guard.Against.NullOrEmpty(usuario,nameof(usuario));
    public int Estado { get; set; } = 1; // Activo por defecto
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
