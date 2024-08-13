using System;

using Ardalis.Result;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Articulos.Create;

  public record CreateArticuloCommand(string Clave, string Descripcion, decimal PrecioPublico, int UnidadId,
        string? UserName = null) : Ardalis.SharedKernel.ICommand<Result<Guid>>;
