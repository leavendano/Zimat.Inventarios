
namespace Zimat.Inventarios.Core.Extensions;
public static class EmptyIfNull{

    public static IEnumerable<T> OrEmptyIfNull<T>(this IEnumerable<T>? source)
    {
        return source ?? Enumerable.Empty<T>();
    }


}

