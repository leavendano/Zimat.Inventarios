using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zimat.Inventarios.Core.ProveedorAggregate;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.UnidadAggregate;
using Zimat.Inventarios.Core.LineaAggregate;
using Zimat.Inventarios.Core.FamiliaAggregate;
using Zimat.Inventarios.Core.CategoriaAggregate;
using Zimat.Inventarios.Core.DepartamentoAggregate;
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
    if (!dbContext.Unidades.Any())
    {

      dbContext.Unidades.Add(new Unidad("BTO", "H87"));
      dbContext.Unidades.Add(new Unidad("Servicio", "E48"));
      dbContext.Unidades.Add(new Unidad("Actividad", "ACT"));
      dbContext.Unidades.Add(new Unidad("KGS", "KGM"));
      dbContext.Unidades.Add(new Unidad("PZA", "H87"));
      GuardaCambios = true;
    }


    if (!dbContext.Proveedores.Any())
    {

      dbContext.Proveedores.Add(new Proveedor("001", "CEMEX S.A.B. SA DE CV", "CME820101LJ4", "01180"));
      dbContext.Proveedores.Add(new Proveedor("002", "MEXALIT INDUSTRIAL, SA DE CV", "MIN920101UR1", "01180"));
      dbContext.Proveedores.Add(new Proveedor("004", "DEACERO, SAPI DE CV", "DEA7103086X2", "67128"));

      GuardaCambios = true;
    }

    if (!dbContext.Lineas.Any())
    {

      dbContext.Lineas.Add(new Linea("POLVOS Y PRODUCTOS DE CONCRETO"));
      dbContext.Lineas.Add(new Linea("ACEROS"));
      dbContext.Lineas.Add(new Linea("LAMINA, TEJAS Y  ACCESORIOS"));
      dbContext.Lineas.Add(new Linea("SANITARIOS"));


      GuardaCambios = true;
    }

    if (!dbContext.Familias.Any())
    {

      dbContext.Familias.Add(new Familia("CEMEX"));
      dbContext.Familias.Add(new Familia("MEXALIT"));
      dbContext.Familias.Add(new Familia("DEACERO"));
      dbContext.Familias.Add(new Familia("CERAMAT"));


      GuardaCambios = true;
    }


    if (!dbContext.Categorias.Any())
    {

      dbContext.Categorias.Add(new Categoria("POLVOS"));
      dbContext.Categorias.Add(new Categoria("ACEROS"));
      dbContext.Categorias.Add(new Categoria("RECUBRIMIENTOS"));
      dbContext.Categorias.Add(new Categoria("TECHADOS"));


      GuardaCambios = true;
    }
    if (!dbContext.Departamentos.Any())
    {

      dbContext.Departamentos.Add(new Departamento("PINTURAS , SELLADOR Y DESOXIDA"));
      dbContext.Departamentos.Add(new Departamento("PRODUCTOS AIRE Y EQUIPOS"));
      dbContext.Departamentos.Add(new Departamento("PRODUCTOS ALAFLEX"));
      dbContext.Departamentos.Add(new Departamento("PRODUCTOS ALLAPSA"));


      GuardaCambios = true;
    }


    if (!dbContext.Articulos.Any())
    {
      
      
      var art1 = new Articulo("10-001", "CEMENTO GRIS TOLTECA BTO 50 / KGS", 211,1,"Administrador");
      dbContext.Articulos.Add(art1);
      var art2 = new Articulo("10-004", "CEMENTO BLANCO TOLTECA BTO/25 KGS", 201,1,"Administrador");
      dbContext.Articulos.Add(art2);
      dbContext.Articulos.Add(new Articulo("10-005", "MORTERO TOLTECA BTO/50 KG.", 195,1,"Administrador"));
      dbContext.Articulos.Add(new Articulo("10-101", "CAL HIDRATADA BTO 25 / KGS", 82,1,"Administrador"));

      GuardaCambios = true;
    }
    if (GuardaCambios)
      dbContext.SaveChanges();
  }



}
