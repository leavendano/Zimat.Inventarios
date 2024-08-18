using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Documentos.Create;
public record CreateDocumentoCommand(string Folio, DateTime Fecha, int TipoDocumentoId, int? ClienteId, int? ProveedorId, decimal Importe) : Ardalis.SharedKernel.ICommand<Result<Guid>>;
