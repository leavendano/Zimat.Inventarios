using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zimat.Inventarios.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class SaldoAnticipo : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AlterColumn<Guid>(
              name: "documento_relacionado_id",
              table: "documentos",
              type: "uuid",
              nullable: true,
              oldClrType: typeof(Guid),
              oldType: "uuid");

          migrationBuilder.AddColumn<bool>(
              name: "pagado",
              table: "documentos",
              type: "boolean",
              nullable: false,
              defaultValue: false);

          migrationBuilder.AddColumn<decimal>(
              name: "saldo_anticipo",
              table: "documentos",
              type: "numeric",
              nullable: false,
              defaultValue: 0m);
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropColumn(
              name: "pagado",
              table: "documentos");

          migrationBuilder.DropColumn(
              name: "saldo_anticipo",
              table: "documentos");

          migrationBuilder.AlterColumn<Guid>(
              name: "documento_relacionado_id",
              table: "documentos",
              type: "uuid",
              nullable: false,
              defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
              oldClrType: typeof(Guid),
              oldType: "uuid",
              oldNullable: true);
      }
  }
