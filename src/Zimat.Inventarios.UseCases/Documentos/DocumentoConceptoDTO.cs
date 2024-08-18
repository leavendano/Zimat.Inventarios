using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.DocumentoAggregate;

namespace Zimat.Inventarios.UseCases.Documentos;
public class DocumentoConceptoDTO
{
  public Guid DocumentoId { get; set; } 
  public int ArticuloId { get; set; }
  public string? Clave { get; set; }
  public string? Descripcion { get; set; }
  public decimal Precio { get; set; }
  public decimal Cantidad { get; set; }
  public decimal Descuento { get; set; } = 0;
  public decimal Impuesto1 { get; set; } = 16;
  
  public decimal Importe { get; set; } = 0;
}
