using Zimat.Inventarios.Web.Models;
using Zimat.Inventarios.UseCases.Articulos;

namespace Zimat.Inventarios.Web.Services;

public class CartService
{
    private readonly List<CartItem> _items = new();
    
    public event Action? OnCartChanged;
    
    public IReadOnlyList<CartItem> Items => _items.AsReadOnly();
    
    public decimal TotalItems => _items.Sum(item => item.Cantidad);
    
    public decimal Subtotal => _items.Sum(item => item.Subtotal);
    
    public decimal TotalImpuestos => _items.Sum(item => item.ImpuestoTotal);
    
    public decimal Total => _items.Sum(item => item.Total);
    
    public void AddItem(ArticuloPrecioListarDTO articulo, decimal cantidad = 1)
    {
        var existingItem = _items.FirstOrDefault(item => item.ArticuloId == articulo.Id);
        
        if (existingItem != null)
        {
            existingItem.Cantidad += cantidad;
        }
        else
        {
            _items.Add(new CartItem
            {
                ArticuloId = articulo.Id,
                Clave = articulo.Clave,
                Descripcion = articulo.Descripcion,
                PrecioUnitario = articulo.PrecioPublico,
                Cantidad = cantidad,
                Unidad = articulo.Unidad,
                Impuesto1 = articulo.Impuesto1
            });
        }
        
        OnCartChanged?.Invoke();
    }
    
    public void RemoveItem(Guid articuloId)
    {
        var item = _items.FirstOrDefault(item => item.ArticuloId == articuloId);
        if (item != null)
        {
            _items.Remove(item);
            OnCartChanged?.Invoke();
        }
    }
    
    public void UpdateQuantity(Guid articuloId, decimal cantidad)
    {
        var item = _items.FirstOrDefault(item => item.ArticuloId == articuloId);
        if (item != null)
        {
            if (cantidad <= 0)
            {
                RemoveItem(articuloId);
            }
            else
            {
                item.Cantidad = cantidad;
                OnCartChanged?.Invoke();
            }
        }
    }
    
    public void Clear()
    {
        _items.Clear();
        OnCartChanged?.Invoke();
    }
}