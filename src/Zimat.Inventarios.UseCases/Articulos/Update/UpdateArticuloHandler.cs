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
    var precioAnterior = existingArticulo.PrecioPublico;
    existingArticulo.UpdateDescripcion(request.Descripcion!);
    existingArticulo.UpdatePrecio(request.PrecioPublico);
    if(precioAnterior != request.PrecioPublico)
    {
      await emailSender.SendEmailAsync("leavendano@gmail.com",
                                    "cfdi@infinitummail.com",
                                    "Producto modificado por el usuario Administrador",
                                    $"Se cambio al precio de el Articulo {request.Descripcion}, pasa de {precioAnterior} a  {request.PrecioPublico}.");
    }
   
    await _repository.UpdateAsync(existingArticulo, cancellationToken);

    return Result.Success(new ArticuloDTO(existingArticulo.Id,
      existingArticulo.Clave, existingArticulo.Descripcion,existingArticulo.PrecioPublico,existingArticulo.UltimoCosto,
      existingArticulo.Impuesto1,""));
  }
}
