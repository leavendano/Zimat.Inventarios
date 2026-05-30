using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Ventas.Create;
public record CreateVentaCommand(string Folio, DateTime Fecha, int TipoDocumentoId, Guid? ClienteId,
        decimal Importe, IEnumerable<VentaConceptoDTO>? conceptos) : Ardalis.SharedKernel.ICommand<Result<Guid>>;
