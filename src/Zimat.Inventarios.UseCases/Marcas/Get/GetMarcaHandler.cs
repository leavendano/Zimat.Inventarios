using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.MarcaAggregate;
using Zimat.Inventarios.Core.MarcaAggregate.Specifications;

namespace Zimat.Inventarios.UseCases.Marcas.Get;

public class GetMarcaHandler(IReadRepository<Marca> _repository)
    : IQueryHandler<GetMarcaQuery, Result<MarcaDTO>>
{
    public async Task<Result<MarcaDTO>> Handle(GetMarcaQuery request, CancellationToken cancellationToken)
    {
        var spec = new MarcaByIdSpec(request.MarcaId);
        var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
        if (entity == null) return Result.NotFound();

        return new MarcaDTO(entity.Id, entity.Descripcion);
    }
}
