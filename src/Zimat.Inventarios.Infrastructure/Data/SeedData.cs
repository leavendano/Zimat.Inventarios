using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zimat.Inventarios.Core.ProveedorAggregate;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.UnidadAggregate;
using Zimat.Inventarios.Core.LineaAggregate;
using Zimat.Inventarios.Core.FamiliaAggregate;
using Zimat.Inventarios.Core.CategoriaAggregate;
using Zimat.Inventarios.Core.DepartamentoAggregate;
using Zimat.Inventarios.Core.ClienteAggregate;
using Zimat.Inventarios.Core.UsuarioAggregate;
namespace Zimat.Inventarios.Infrastructure.Data;

public static class SeedData
{
  
  static bool GuardaCambios = false;
  public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var dbContext = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>(), null))
    {
      PopulateTestData(dbContext);

    }
  }
  public static void PopulateTestData(AppDbContext dbContext)
  {
    Unidad unidadBTO = new Unidad("BTO", "H87");
    if (!dbContext.Unidades.Any())
    {

      dbContext.Unidades.Add(unidadBTO);
      dbContext.Unidades.Add(new Unidad("Servicio", "E48", "Administrador"));
      dbContext.Unidades.Add(new Unidad("Actividad", "ACT", "Administrador"));
      dbContext.Unidades.Add(new Unidad("KGS", "KGM", "Administrador"));
      dbContext.Unidades.Add(new Unidad("PZA", "H87", "Administrador"));
      GuardaCambios = true;
    }


    if (!dbContext.Proveedores.Any())
    {

      dbContext.Proveedores.Add(new Proveedor("001", "CEMEX S.A.B. SA DE CV", "CME820101LJ4", "01180"));
      dbContext.Proveedores.Add(new Proveedor("002", "MEXALIT INDUSTRIAL, SA DE CV", "MIN920101UR1", "01180"));
      dbContext.Proveedores.Add(new Proveedor("004", "DEACERO, SAPI DE CV", "DEA7103086X2", "67128"));

      GuardaCambios = true;
    }


    if (!dbContext.Clientes.Any())
    {

      dbContext.Clientes.Add(new Cliente("0", "PUBLICO EN GENERAL", "XAXX010101000", "71980"));
      dbContext.Clientes.Add(new Cliente("408", "RODOLFO LUJAN RUIZ", "LURR720417KNA", "70934"));
      dbContext.Clientes.Add(new Cliente("15928", "EDILBERTO MENDOZA", "XAXX010101000", "71980"));
      dbContext.Clientes.Add(new Cliente("18482", "SILVANO CORTES CRUZ", "XAXX010101000", "71980"));

      GuardaCambios = true;
    }

    if (!dbContext.Clientes.Any())
    {

      dbContext.Usuarios.Add(new Usuario("HDH", "Hilda Díaz Hernández", "zimat.mostrador1@gmail.com", "2",true));
      dbContext.Usuarios.Add(new Usuario("JJC", "Jose Luis Jimenez Carbajal", "zimat.mostrador1@gmail.com", "12",true));
      dbContext.Usuarios.Add(new Usuario("HZG", "Homero Ziga Gopar", "gerencia.general@zimat-concretos.com", "1",false));
      dbContext.Usuarios.Add(new Usuario("AOV", "Adriana Olivera Vásquez", "zimatfacturacion@gmail.com", "2",true));

      GuardaCambios = true;
    }

    if (!dbContext.Lineas.Any())
    {

      dbContext.Lineas.Add(new Linea("POLVOS Y PRODUCTOS DE CONCRETO",0,"Administrador"));
      dbContext.Lineas.Add(new Linea("ACEROS",0,"Administrador"));
      dbContext.Lineas.Add(new Linea("LAMINA, TEJAS Y  ACCESORIOS",0,"Administrador"));
      dbContext.Lineas.Add(new Linea("SANITARIOS",0,"Administrador"));


      GuardaCambios = true;
    }

    if (!dbContext.Familias.Any())
    {

      dbContext.Familias.Add(new Familia("CEMEX",0,"Administrador"));
      dbContext.Familias.Add(new Familia("MEXALIT",0,"Administrador"));
      dbContext.Familias.Add(new Familia("DEACERO",0,"Administrador"));
      dbContext.Familias.Add(new Familia("CERAMAT",0,"Administrador"));


      GuardaCambios = true;
    }


    if (!dbContext.Categorias.Any())
    {

      dbContext.Categorias.Add(new Categoria("POLVOS",0,"Administrador"));
      dbContext.Categorias.Add(new Categoria("ACEROS",0,"Administrador"));
      dbContext.Categorias.Add(new Categoria("RECUBRIMIENTOS",0,"Administrador"));
      dbContext.Categorias.Add(new Categoria("TECHADOS",0,"Administrador"));


      GuardaCambios = true;
    }
    if (!dbContext.Departamentos.Any())
    {

      dbContext.Departamentos.Add(new Departamento("PINTURAS , SELLADOR Y DESOXIDA","Administrador"));
      dbContext.Departamentos.Add(new Departamento("PRODUCTOS AIRE Y EQUIPOS","Administrador"));
      dbContext.Departamentos.Add(new Departamento("PRODUCTOS ALAFLEX","Administrador"));
      dbContext.Departamentos.Add(new Departamento("PRODUCTOS ALLAPSA","Administrador"));


      GuardaCambios = true;
    }


    if (!dbContext.Articulos.Any())
    {
      
      var IdUnidad = dbContext.Unidades.FirstOrDefault(u => u.Descripcion == "BTO")?.Id ?? unidadBTO.Id;
      var art1 = new Articulo("10-001", "CEMENTO GRIS TOLTECA BTO 50 / KGS", 211, IdUnidad,"Administrador");
      dbContext.Articulos.Add(art1);
      var art2 = new Articulo("10-004", "CEMENTO BLANCO TOLTECA BTO/25 KGS", 201,IdUnidad,"Administrador");
      dbContext.Articulos.Add(art2);
      dbContext.Articulos.Add(new Articulo("10-005", "MORTERO TOLTECA BTO/50 KG.", 195,IdUnidad,"Administrador"));
      dbContext.Articulos.Add(new Articulo("10-101", "CAL HIDRATADA BTO 25 / KGS", 82,IdUnidad,"Administrador"));

      GuardaCambios = true;
    }
    if (GuardaCambios)
      dbContext.SaveChanges();
  }



}
