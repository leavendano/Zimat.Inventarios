using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zimat.Inventarios.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class CambiosCliente : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropIndex(
              name: "ix_precios_articulo_unidad_id",
              table: "precios");

          migrationBuilder.DropIndex(
              name: "ix_articulo_unidades_articulo_id",
              table: "articulo_unidades");

          migrationBuilder.RenameColumn(
              name: "contacto",
              table: "clientes",
              newName: "pais");

          migrationBuilder.AddColumn<string>(
              name: "contacto_pago",
              table: "clientes",
              type: "text",
              nullable: true);

          migrationBuilder.AddColumn<string>(
              name: "contacto_ventas",
              table: "clientes",
              type: "text",
              nullable: true);

          migrationBuilder.AddColumn<decimal>(
              name: "limite_credito",
              table: "clientes",
              type: "numeric",
              nullable: false,
              defaultValue: 0m);

          migrationBuilder.AddColumn<decimal>(
              name: "saldo",
              table: "clientes",
              type: "numeric",
              nullable: false,
              defaultValue: 0m);

          migrationBuilder.AddColumn<string>(
              name: "unidad",
              table: "articulo_unidades",
              type: "text",
              nullable: true);

          migrationBuilder.CreateIndex(
              name: "ix_precios_articulo_unidad_id_numero_lista",
              table: "precios",
              columns: new[] { "articulo_unidad_id", "numero_lista" },
              unique: true);

          migrationBuilder.CreateIndex(
              name: "ix_articulo_unidades_articulo_id_unidad_id",
              table: "articulo_unidades",
              columns: new[] { "articulo_id", "unidad_id" },
              unique: true);
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropIndex(
              name: "ix_precios_articulo_unidad_id_numero_lista",
              table: "precios");

          migrationBuilder.DropIndex(
              name: "ix_articulo_unidades_articulo_id_unidad_id",
              table: "articulo_unidades");

          migrationBuilder.DropColumn(
              name: "contacto_pago",
              table: "clientes");

          migrationBuilder.DropColumn(
              name: "contacto_ventas",
              table: "clientes");

          migrationBuilder.DropColumn(
              name: "limite_credito",
              table: "clientes");

          migrationBuilder.DropColumn(
              name: "saldo",
              table: "clientes");

          migrationBuilder.DropColumn(
              name: "unidad",
              table: "articulo_unidades");

          migrationBuilder.RenameColumn(
              name: "pais",
              table: "clientes",
              newName: "contacto");

          migrationBuilder.CreateIndex(
              name: "ix_precios_articulo_unidad_id",
              table: "precios",
              column: "articulo_unidad_id");

          migrationBuilder.CreateIndex(
              name: "ix_articulo_unidades_articulo_id",
              table: "articulo_unidades",
              column: "articulo_id");
      }
  }
