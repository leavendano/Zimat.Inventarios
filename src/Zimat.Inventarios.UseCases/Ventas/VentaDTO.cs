using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zimat.Inventarios.UseCases.Ventas;
public record VentaDTO(Guid Id, string Folio, DateTime Fecha, int TipoDocumentoId,
        Guid? ClienteId, decimal Importe, bool Pagado);
