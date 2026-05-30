namespace Zimat.Inventarios.UseCases.Kardex;

public class KardexListarDTO
{
    public Guid Id { get; set; }
    public Guid ArticuloId { get; set; }
    public int AlmacenId { get; set; }
    public int TipoMovimiento { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Cantidad { get; set; }
    public decimal CostoUnitario { get; set; }
    public decimal CostoTotal { get; set; }
    public Guid? ReferenciaId { get; set; }
    public string? User { get; set; }
}
