using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Documentos.Delete;
public record DeleteDocumentoCommand(int DocumentoId) : ICommand<Result>;
