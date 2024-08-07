﻿using Zimat.Inventarios.Core.ContributorAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zimat.Inventarios.Core.ProveedorAggregate;
using Zimat.Inventarios.Core.ArticuloAggregate;

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

    if (!dbContext.Articulos.Any())
    {

      dbContext.Articulos.Add(new Articulo("10-001", "CEMENTO GRIS TOLTECA BTO 50 / KGS", 211));
      dbContext.Articulos.Add(new Articulo("10-004", "CEMENTO BLANCO TOLTECA BTO/25 KGS", 201));
      dbContext.Articulos.Add(new Articulo("10-005", "MORTERO TOLTECA BTO/50 KG.", 195));
      dbContext.Articulos.Add(new Articulo("10-101", "CAL HIDRATADA BTO 25 / KGS", 82));

      GuardaCambios = true;
    }
    if (GuardaCambios)
      dbContext.SaveChanges();
  }



}
