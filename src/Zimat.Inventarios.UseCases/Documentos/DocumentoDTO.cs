using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zimat.Inventarios.UseCases.Documentos;
public record DocumentoDTO(int Id, string Folio, DateTime Fecha, int TipoDocumentoId, int? ClienteId, int? ProveedorId, decimal Importe);
