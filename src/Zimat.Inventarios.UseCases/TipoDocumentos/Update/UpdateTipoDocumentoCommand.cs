using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Update;

public record UpdateTipoDocumentoCommand(
    int TipoDocumentoId,
    string Nombre,
    bool EsEntrada,
    bool EsSalida,
    bool AfectaInventario,
    bool AfectaCuentasPorPagar,
    bool AfectaCuentasPorCobrar,
    bool RequiereProveedor,
    bool RequiereCliente,
    string Prefijo
) : ICommand<Result<TipoDocumentoDTO>>;
