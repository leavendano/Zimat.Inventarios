using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zimat.Inventarios.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImpuestoDocumento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "impuesto1",
                table: "documentos",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "impuesto2",
                table: "documentos",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "impuesto1",
                table: "documentos");

            migrationBuilder.DropColumn(
                name: "impuesto2",
                table: "documentos");
        }
    }
}
