
using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Articulos.Update;
public record UpdateArticuloCommand(
    Guid ArticuloId, 
    string Descripcion,
    string Clave,
    string? Observaciones,
    string? CodigoBarras,
    Guid UnidadId, 
    string? Marca,
    string? Modelo,
    Guid? LineaId, 
    Guid? FamiliaId,
    Guid? CategoriaId,
    Guid? DepartamentoId,
    string? Ubicacion,
    bool Series,
    decimal Impuesto1,
    decimal Impuesto2,
    string? ClaveSat,
    decimal StockMinimo, 
    decimal StockMaximo,  
    decimal DescuentoMaximo,
    string? RutaImagen,
    int StockStatus = 0
    ) : ICommand<Result<ArticuloDTO>>;
