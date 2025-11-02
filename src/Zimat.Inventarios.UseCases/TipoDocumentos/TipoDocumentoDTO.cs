namespace Zimat.Inventarios.UseCases.TipoDocumentos;

public record TipoDocumentoDTO(
    int Id,
    string Nombre,
    bool EsEntrada,
    bool EsSalida,
    bool AfectaInventario,
    bool AfectaCuentasPorPagar,
    bool AfectaCuentasPorCobrar,
    bool RequiereProveedor,
    bool RequiereCliente,
    string Prefijo,
    int UltimoFolio
);
