using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zimat.Inventarios.UseCases.Compras;
public record CompraListarDTO(Guid Id, string Folio, DateTime Fecha, int TipoDocumentoId, string TipoDocumentoNombre,
        Guid ProveedorId,string ProveedorNombre, decimal Importe, Guid? DocumentoRelacionadoId);
