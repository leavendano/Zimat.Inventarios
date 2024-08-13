
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.UnidadAggregate;

public class Unidad(string descripcion,string claveSat, string usuario = "ADMINISTRADOR") : EntityBase, IAggregateRoot,IRegisterBase
{
    public string Descripcion { get; set; } = Guard.Against.NullOrEmpty(descripcion,nameof(descripcion));
    public string ClaveSat { get; set; } = Guard.Against.NullOrEmpty(claveSat,nameof(claveSat));
    public string? Usuario { get; set; } = Guard.Against.NullOrEmpty(usuario,nameof(usuario));
    public int Estatus { get; set; } = 1;
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
