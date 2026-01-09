using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.Interfaces;
using Zimat.Inventarios.UseCases.Contributors;

namespace Zimat.Inventarios.UseCases.Articulos.Update;
public class UpdateArticuloHandler(IRepository<Articulo> _repository, IEmailSender emailSender) : ICommandHandler<UpdateArticuloCommand, Result<ArticuloDTO>>
{

  public async Task<Result<ArticuloDTO>> Handle(UpdateArticuloCommand request, CancellationToken cancellationToken)
  {
    var existingArticulo = await _repository.GetByIdAsync(request.ArticuloId, cancellationToken);
    if (existingArticulo == null)
    {
      return Result.NotFound();
    }
    
    existingArticulo.UpdateDescripcion(request.Descripcion!);
    //existingArticulo.UpdatePrecio(request.PrecioPublico);
    existingArticulo.RutaImagen = request.RutaImagen;
    existingArticulo.LineaId = request.LineaId;
    existingArticulo.FamiliaId = request.FamiliaId;
    existingArticulo.CategoriaId = request.CategoriaId;
    existingArticulo.DepartamentoId = request.DepartamentoId;
    existingArticulo.Impuesto1 = request.Impuesto1;
    existingArticulo.Impuesto2 = request.Impuesto2;
    existingArticulo.Observaciones = request.Observaciones;
    existingArticulo.CodigoBarras = request.CodigoBarras;
    existingArticulo.UnidadId = request.UnidadId;
    existingArticulo.Marca = request.Marca;
    existingArticulo.Modelo = request.Modelo;
    existingArticulo.Ubicacion = request.Ubicacion;
    existingArticulo.Series = request.Series;
    existingArticulo.StockMinimo = request.StockMinimo;
    existingArticulo.StockMaximo = request.StockMaximo;
    existingArticulo.StockStatus = request.StockStatus;
    existingArticulo.DescuentoMaximo = request.DescuentoMaximo;

    
      await emailSender.SendEmailAsync("leavendano@gmail.com",
                                    "cfdi@infinitummail.com",
                                    "Producto modificado por el usuario Administrador",
                                    $"Se actualizaron los datos el Articulo {request.Descripcion}");
    
   
    await _repository.UpdateAsync(existingArticulo, cancellationToken);

    return Result.Success(new ArticuloDTO(existingArticulo.Id,
      existingArticulo.Clave, existingArticulo.Descripcion,existingArticulo.PrecioPublico,existingArticulo.CostoUnitario,
      existingArticulo.Impuesto1,existingArticulo.UnidadId,existingArticulo.RutaImagen));
  }
}
