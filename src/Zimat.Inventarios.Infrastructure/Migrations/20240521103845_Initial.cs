using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Zimat.Inventarios.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class Initial : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "articulos",
              columns: table => new
              {
                  id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  clave = table.Column<string>(type: "text", nullable: false),
                  descripcion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                  codigo = table.Column<string>(type: "text", nullable: true),
                  unidad = table.Column<string>(type: "text", nullable: true),
                  unidefa = table.Column<string>(type: "text", nullable: true),
                  marca = table.Column<string>(type: "text", nullable: true),
                  modelo = table.Column<string>(type: "text", nullable: true),
                  linea = table.Column<string>(type: "text", nullable: true),
                  familia = table.Column<string>(type: "text", nullable: true),
                  categoria = table.Column<string>(type: "text", nullable: true),
                  numdep = table.Column<string>(type: "text", nullable: true),
                  valdep = table.Column<string>(type: "text", nullable: true),
                  ubicacion = table.Column<string>(type: "text", nullable: true),
                  series = table.Column<bool>(type: "boolean", nullable: false),
                  impuesto1 = table.Column<decimal>(type: "numeric", nullable: false),
                  impuesto2 = table.Column<decimal>(type: "numeric", nullable: false),
                  numprov = table.Column<string>(type: "text", nullable: true),
                  numprov1 = table.Column<string>(type: "text", nullable: true),
                  numprov2 = table.Column<string>(type: "text", nullable: true),
                  numprov3 = table.Column<string>(type: "text", nullable: true),
                  ultcomp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  ultcomp1 = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  ultcomp2 = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  ultcomp3 = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  ultvent = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  existencia = table.Column<decimal>(type: "numeric", nullable: false),
                  minimo = table.Column<decimal>(type: "numeric", nullable: false),
                  maximo = table.Column<decimal>(type: "numeric", nullable: false),
                  reorden = table.Column<decimal>(type: "numeric", nullable: false),
                  divisa = table.Column<string>(type: "text", nullable: true),
                  precio1 = table.Column<decimal>(type: "numeric", nullable: false),
                  precio2 = table.Column<decimal>(type: "numeric", nullable: false),
                  precio3 = table.Column<decimal>(type: "numeric", nullable: false),
                  precio4 = table.Column<decimal>(type: "numeric", nullable: false),
                  precio5 = table.Column<decimal>(type: "numeric", nullable: false),
                  factor1 = table.Column<decimal>(type: "numeric", nullable: false),
                  factor2 = table.Column<decimal>(type: "numeric", nullable: false),
                  factor3 = table.Column<decimal>(type: "numeric", nullable: false),
                  factor4 = table.Column<decimal>(type: "numeric", nullable: false),
                  factor5 = table.Column<decimal>(type: "numeric", nullable: false),
                  ultimo_costo = table.Column<decimal>(type: "numeric", nullable: false),
                  activo = table.Column<bool>(type: "boolean", nullable: false),
                  usuario = table.Column<string>(type: "text", nullable: true),
                  estatus = table.Column<int>(type: "integer", nullable: false),
                  created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_articulos", x => x.id);
              });

          migrationBuilder.CreateTable(
              name: "contributors",
              columns: table => new
              {
                  id = table.Column<int>(type: "integer", nullable: false)
                      .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                  name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                  status = table.Column<int>(type: "integer", nullable: false),
                  phone_number_country_code = table.Column<string>(type: "text", nullable: true),
                  phone_number_number = table.Column<string>(type: "text", nullable: true),
                  phone_number_extension = table.Column<string>(type: "text", nullable: true),
                  usuario = table.Column<string>(type: "text", nullable: true),
                  estatus = table.Column<int>(type: "integer", nullable: false),
                  created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                  updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("pk_contributors", x => x.id);
              });
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "articulos");

          migrationBuilder.DropTable(
              name: "contributors");
      }
  }
