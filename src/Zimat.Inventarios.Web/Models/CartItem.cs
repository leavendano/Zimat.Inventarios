namespace Zimat.Inventarios.Web.Models;

public class CartItem
{
    public Guid ArticuloId { get; set; }
    public string Clave { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal PrecioUnitario { get; set; }
    public int Cantidad { get; set; }
    public string Unidad { get; set; } = string.Empty;
    public decimal Impuesto1 { get; set; }
    
    public decimal Subtotal => PrecioUnitario * Cantidad;
    public decimal ImpuestoTotal => Subtotal * (Impuesto1 / 100);
    public decimal Total => Subtotal + ImpuestoTotal;
}