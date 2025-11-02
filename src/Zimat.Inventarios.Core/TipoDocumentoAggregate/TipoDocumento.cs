using Ardalis.GuardClauses;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.TipoDocumentoAggregate;

public class TipoDocumento : EntityBase<int>, IAggregateRoot
{
    public string Nombre { get; set; }
    public bool EsEntrada { get; set; }
    public bool EsSalida { get; set; }
    public bool AfectaInventario { get; set; }
    public bool AfectaCuentasPorPagar { get; set; }
    public bool AfectaCuentasPorCobrar { get; set; }
    public bool RequiereProveedor { get; set; }
    public bool RequiereCliente { get; set; }
    public string Prefijo { get; set; }
    public int UltimoFolio { get; set; }

    public TipoDocumento(string nombre, bool esEntrada, bool esSalida, bool afectaInventario,
        bool afectaCuentasPorPagar, bool afectaCuentasPorCobrar, 
        bool requiereProveedor, bool requiereCliente,int ultimoFolio, string prefijo = "")
    {
        Nombre = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
        EsEntrada = esEntrada;
        EsSalida = esSalida;
        AfectaInventario = afectaInventario;
        AfectaCuentasPorPagar = afectaCuentasPorPagar;
        AfectaCuentasPorCobrar = afectaCuentasPorCobrar;
        RequiereProveedor = requiereProveedor;
        RequiereCliente = requiereCliente;
        UltimoFolio = Guard.Against.Negative(ultimoFolio, nameof(ultimoFolio));
        Prefijo = Guard.Against.Null(prefijo, nameof(prefijo));
    }

    public void UpdateNombre(string nombre)
    {
        Nombre = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
    }

    public void UpdatePrefijo(string prefijo)
    {
        Prefijo = prefijo;
    }

    public void UpdateUltimoFolio(int ultimoFolio)
    {
        UltimoFolio = Guard.Against.Negative(ultimoFolio, nameof(ultimoFolio));
    }

    public void UpdateEsEntrada(bool esEntrada)
    {
        EsEntrada = esEntrada;
        EsSalida = !esEntrada;
    }

    public void UpdateEsSalida(bool esSalida)
    {
        EsSalida = esSalida;
        EsEntrada = !esSalida;
    }

    public string GetNextFolio()
    {
        UltimoFolio += 1;
        return $"{Prefijo}{UltimoFolio:D5}";
    }

    public void Update(string nombre, bool esEntrada, bool esSalida, bool afectaInventario,
        bool afectaCuentasPorPagar, bool afectaCuentasPorCobrar,
        bool requiereProveedor, bool requiereCliente, string prefijo)
    {
        Nombre = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
        EsEntrada = esEntrada;
        EsSalida = esSalida;
        AfectaInventario = afectaInventario;
        AfectaCuentasPorPagar = afectaCuentasPorPagar;
        AfectaCuentasPorCobrar = afectaCuentasPorCobrar;
        RequiereProveedor = requiereProveedor;
        RequiereCliente = requiereCliente;
        Prefijo = Guard.Against.Null(prefijo, nameof(prefijo));
    }
}