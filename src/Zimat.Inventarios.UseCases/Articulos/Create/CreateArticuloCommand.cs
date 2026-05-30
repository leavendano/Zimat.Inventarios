using System;

using Ardalis.Result;


namespace Zimat.Inventarios.UseCases.Articulos.Create;

  public record CreateArticuloCommand(string Clave, string Descripcion, decimal PrecioPublico,
        Guid? CategoriaId = null, Guid? LineaId=null, Guid? FamiliaId = null, Guid? DepartamentoId = null,string? RutaImagen = null,
        string? UserName = null, decimal Impuesto1 = 0, decimal Impuesto2 = 0, string? ClaveSat = null) : Ardalis.SharedKernel.ICommand<Result<Guid>>;
