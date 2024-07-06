using System;

using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Articulos.Create;

  public record CreateArticuloCommand(string Clave, string Descripcion, decimal PrecioPublico) : Ardalis.SharedKernel.ICommand<Result<int>>;
