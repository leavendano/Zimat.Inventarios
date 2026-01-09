using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;


namespace Zimat.Inventarios.UseCases.Articulos.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetArticuloHandler(IReadRepository<Articulo> _repository)
  : IQueryHandler<GetArticuloQuery, Result<ArticuloEditarDTO>>
{
  public async Task<Result<ArticuloEditarDTO>> Handle(GetArticuloQuery request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdSpec(request.ArticuloId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();
    
    return new ArticuloEditarDTO() 
    {
          Id = entity.Id,
          Clave = entity.Clave,
          Descripcion = entity.Descripcion,
          Observaciones = entity.Observaciones,
          CodigoBarras = entity.CodigoBarras,
          UnidadId = entity.UnidadId,
          Marca = entity.Marca,
          Modelo = entity.Modelo,
          LineaId = entity.LineaId,
          FamiliaId = entity.FamiliaId,
          CategoriaId = entity.CategoriaId,
          DepartamentoId = entity.DepartamentoId,
          Ubicacion = entity.Ubicacion,
          Series = entity.Series,
          Impuesto1 = entity.Impuesto1,
          Impuesto2 = entity.Impuesto2,
          ClaveSat = entity.ClaveSat,
          UltimaCompra = entity.UltimaCompra,
          UltimaVenta = entity.UltimaVenta,
          StockActual = entity.StockActual,
          StockMinimo = entity.StockMinimo,
          StockMaximo = entity.StockMaximo,
          StockStatus = entity.StockStatus,
          DescuentoMaximo = entity.DescuentoMaximo,
          CostoUnitario = entity.CostoUnitario,
          CostoPromedio = entity.CostoPromedio,
          RutaImagen = entity.RutaImagen
    };
  }
}
