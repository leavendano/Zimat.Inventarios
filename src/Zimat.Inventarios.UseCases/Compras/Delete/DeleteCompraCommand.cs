using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Compras.Delete;
public record DeleteCompraCommand(Guid CompraId) : ICommand<Result>;
