using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.MarcaAggregate;

public class Marca : EntityBase<Guid>, IRegisterBase, IAggregateRoot
{
    public Marca(string descripcion, string user = "Administrador") : base()
    {
        Descripcion = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
        Id = UuidV7.NewGuid();
        User = Guard.Against.NullOrEmpty(user, nameof(user));
        Status = RegisterStatus.Activo;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public string Descripcion { get; set; }
    public string? User { get; set; }
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public void UpdateDescripcion(string newName)
    {
        Descripcion = Guard.Against.NullOrEmpty(newName, nameof(newName));
    }
}
