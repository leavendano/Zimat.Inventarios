namespace Zimat.Inventarios.Core.Base;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }
    void Delete();
    void Undelete();
}