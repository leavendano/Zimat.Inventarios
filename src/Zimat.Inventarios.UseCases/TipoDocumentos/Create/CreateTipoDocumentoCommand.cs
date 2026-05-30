using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Create;

public record CreateTipoDocumentoCommand(
    string Nombre,
    bool EsEntrada,
    bool EsSalida,
    bool AfectaInventario,
    bool AfectaCuentasPorPagar,
    bool AfectaCuentasPorCobrar,
    bool RequiereProveedor,
    bool RequiereCliente,
    int UltimoFolio,
    string Prefijo = ""
) : Ardalis.SharedKernel.ICommand<Result<int>>;
