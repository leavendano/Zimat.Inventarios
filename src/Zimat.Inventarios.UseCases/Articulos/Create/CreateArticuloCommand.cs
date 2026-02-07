using System;

using Ardalis.Result;


namespace Zimat.Inventarios.UseCases.Articulos.Create;

  public record CreateArticuloCommand(string Clave, string Descripcion, decimal PrecioPublico, 
        Guid? CategoriaId = null, Guid? LineaId=null, Guid? FamiliaId = null, Guid? DepartamentoId = null,string? RutaImagen = null,
        string? UserName = null) : Ardalis.SharedKernel.ICommand<Result<Guid>>;
