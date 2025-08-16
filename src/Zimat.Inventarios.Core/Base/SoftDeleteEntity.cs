
namespace Zimat.Inventarios.Core.Base;

public abstract class SoftDeleteEntity : ISoftDelete
{
    public bool IsDeleted { get; set; } = false;

    public virtual void Delete()
    {
        IsDeleted = true;
    }

    public virtual void Undelete()
    {
        IsDeleted = false;
    }
}