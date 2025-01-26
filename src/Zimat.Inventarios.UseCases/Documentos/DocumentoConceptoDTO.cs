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
  public Guid ArticuloId { get; set; }
  public string Clave { get; set; } = ""; 
  public string Descripcion { get; set; } = "";
  public decimal Precio { get; set; } = 0m;
  public decimal Cantidad { get; set; } =0m;
  public string Unidad { get; set; } = "";
  public decimal Impuesto1 { get; set; } = 16;
  public decimal Impuesto2 { get; set; } = 16;
  public decimal UltimoCosto { get; set; }
  public decimal Descuento { get; set; } = 0;
  public decimal DescuentoImporte { get; set; } = 0m;
  public decimal Importe { get; set; } = 0;
}
