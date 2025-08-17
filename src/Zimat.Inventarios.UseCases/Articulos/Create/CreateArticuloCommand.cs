using System;

using Ardalis.Result;


namespace Zimat.Inventarios.UseCases.Articulos.Create;

  public record CreateArticuloCommand(string Clave, string Descripcion, decimal PrecioPublico, Guid UnidadId,
        string? UserName = null) : Ardalis.SharedKernel.ICommand<Result<Guid>>;
