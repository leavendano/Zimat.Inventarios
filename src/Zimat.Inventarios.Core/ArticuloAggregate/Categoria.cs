using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Categoria(string descripcion) : EntityBase, IRegisterBase
{
    public string Descripcion { get; set; } = Guard.Against.NullOrEmpty(descripcion,nameof(descripcion));
    public decimal Margen { get; set; } = 0;
    public string? Usuario { get; set; }
    public int Estatus { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}
