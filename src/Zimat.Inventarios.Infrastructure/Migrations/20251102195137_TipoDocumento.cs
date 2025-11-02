using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Zimat.Inventarios.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TipoDocumento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tipo_documentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    es_entrada = table.Column<bool>(type: "boolean", nullable: false),
                    es_salida = table.Column<bool>(type: "boolean", nullable: false),
                    afecta_inventario = table.Column<bool>(type: "boolean", nullable: false),
                    afecta_cuentas_por_pagar = table.Column<bool>(type: "boolean", nullable: false),
                    afecta_cuentas_por_cobrar = table.Column<bool>(type: "boolean", nullable: false),
                    requiere_proveedor = table.Column<bool>(type: "boolean", nullable: false),
                    requiere_cliente = table.Column<bool>(type: "boolean", nullable: false),
                    prefijo = table.Column<string>(type: "text", nullable: false),
                    ultimo_folio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tipo_documentos", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tipo_documentos");
        }
    }
}
