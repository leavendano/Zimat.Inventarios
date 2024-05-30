using System;

using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Articulos.Create;

  public record CreateArticuloCommand(string Clave, string Descripcion, string Codigo) : Ardalis.SharedKernel.ICommand<Result<int>>;
