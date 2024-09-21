namespace Zimat.Inventarios.Web.Comprobante;

public class UploadComprobanteResponse(Guid comprobanteId)
{
  public Guid ComprobanteId { get; set; } = comprobanteId;
}
