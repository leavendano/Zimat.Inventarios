using Zimat.Inventarios.Core.ClienteAggregate;

namespace Zimat.Inventarios.UseCases.Clientes;

public class ClienteCrearDTO
{
    public string Clave { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string? Calle { get; set; }
    public string? NumeroExterior { get; set; }
    public string? Colonia { get; set; }
    public string? Ciudad { get; set; }
    public string? Estado { get; set; }
    public string Pais { get; set; } = "México";
    public string CodigoPostal { get; set; } = "";
    public string? Telefono { get; set; }
    public string? Email { get; set; }
    public string? ContactoVentas { get; set; }
    public string? ContactoPago { get; set; }
    public string Rfc { get; set; } = "";
    public string? RegimenFiscal { get; set; }
    public string? UsoCfdi { get; set; }
    public string? Observaciones { get; set; }
    public int DiasCredito { get; set; } = 0;
    public decimal LimiteCredito { get; set; } = 0;

    public Cliente ToCliente()
    {
        var item = new Cliente(Clave, Nombre, Rfc, CodigoPostal);
        item.Calle = Calle;
        item.NumeroExterior = NumeroExterior;
        item.Colonia = Colonia;
        item.Ciudad = Ciudad;
        item.Estado = Estado;
        item.Pais = Pais;
        item.Telefono = Telefono;
        item.Email = Email;
        item.ContactoVentas = ContactoVentas;
        item.ContactoPago = ContactoPago;
        item.RegimenFiscal = RegimenFiscal;
        item.UsoCfdi = UsoCfdi;
        item.Observaciones = Observaciones;
        item.DiasCredito = DiasCredito;
        item.LimiteCredito = LimiteCredito;
        return item;
    }
}
