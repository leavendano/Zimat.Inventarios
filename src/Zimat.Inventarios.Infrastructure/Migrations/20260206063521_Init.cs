using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Zimat.Inventarios.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articulos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    clave = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    observaciones = table.Column<string>(type: "text", nullable: true),
                    codigo_barras = table.Column<string>(type: "text", nullable: true),
                    marca = table.Column<string>(type: "text", nullable: true),
                    modelo = table.Column<string>(type: "text", nullable: true),
                    linea_id = table.Column<Guid>(type: "uuid", nullable: true),
                    familia_id = table.Column<Guid>(type: "uuid", nullable: true),
                    categoria_id = table.Column<Guid>(type: "uuid", nullable: true),
                    departamento_id = table.Column<Guid>(type: "uuid", nullable: true),
                    ubicacion = table.Column<string>(type: "text", nullable: true),
                    series = table.Column<bool>(type: "boolean", nullable: false),
                    impuesto1 = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto2 = table.Column<decimal>(type: "numeric", nullable: false),
                    clave_sat = table.Column<string>(type: "text", nullable: true),
                    ultima_compra = table.Column<Guid>(type: "uuid", nullable: true),
                    ultima_venta = table.Column<Guid>(type: "uuid", nullable: true),
                    stock_actual = table.Column<decimal>(type: "numeric", nullable: false),
                    stock_minimo = table.Column<decimal>(type: "numeric", nullable: false),
                    stock_maximo = table.Column<decimal>(type: "numeric", nullable: false),
                    stock_status = table.Column<int>(type: "integer", nullable: false),
                    precio_publico = table.Column<decimal>(type: "numeric", nullable: false),
                    descuento_maximo = table.Column<decimal>(type: "numeric", nullable: false),
                    costo_unitario = table.Column<decimal>(type: "numeric", nullable: true),
                    costo_promedio = table.Column<decimal>(type: "numeric", nullable: true),
                    ruta_imagen = table.Column<string>(type: "text", nullable: true),
                    peso_neto = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_articulos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    margen = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    clave = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    calle = table.Column<string>(type: "text", nullable: true),
                    numero_exterior = table.Column<string>(type: "text", nullable: true),
                    colonia = table.Column<string>(type: "text", nullable: true),
                    ciudad = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: true),
                    pais = table.Column<string>(type: "text", nullable: true),
                    codigo_postal = table.Column<string>(type: "text", nullable: false),
                    telefono = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    contacto_ventas = table.Column<string>(type: "text", nullable: true),
                    contacto_pago = table.Column<string>(type: "text", nullable: true),
                    rfc = table.Column<string>(type: "text", nullable: false),
                    regimen_fiscal = table.Column<string>(type: "text", nullable: true),
                    uso_cfdi = table.Column<string>(type: "text", nullable: true),
                    observaciones = table.Column<string>(type: "text", nullable: true),
                    dias_credito = table.Column<int>(type: "integer", nullable: false),
                    limite_credito = table.Column<decimal>(type: "numeric", nullable: false),
                    saldo = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_departamentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "familias",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    margen = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_familias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lineas",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    margen = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_lineas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    clave = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    calle = table.Column<string>(type: "text", nullable: true),
                    numero_exterior = table.Column<string>(type: "text", nullable: true),
                    colonia = table.Column<string>(type: "text", nullable: true),
                    ciudad = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: true),
                    codigo_postal = table.Column<string>(type: "text", nullable: false),
                    telefono = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    clasificacion = table.Column<string>(type: "text", nullable: true),
                    contacto = table.Column<string>(type: "text", nullable: true),
                    rfc = table.Column<string>(type: "text", nullable: false),
                    dias_credito = table.Column<int>(type: "integer", nullable: false),
                    cuenta_contable = table.Column<string>(type: "text", nullable: true),
                    tipo_proveedor = table.Column<int>(type: "integer", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_proveedores", x => x.id);
                });

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

            migrationBuilder.CreateTable(
                name: "unidades",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    clave_sat = table.Column<string>(type: "text", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_unidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    clave = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    nivel = table.Column<string>(type: "text", nullable: false),
                    es_vendedor = table.Column<bool>(type: "boolean", nullable: false),
                    comision = table.Column<decimal>(type: "numeric", nullable: false),
                    lista_precio = table.Column<int>(type: "integer", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    folio = table.Column<string>(type: "text", nullable: false),
                    tipo_documento_id = table.Column<int>(type: "integer", nullable: false),
                    almacen_id = table.Column<int>(type: "integer", nullable: true),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    cliente_id = table.Column<Guid>(type: "uuid", nullable: true),
                    forma_pago_id = table.Column<int>(type: "integer", nullable: true),
                    divisa = table.Column<string>(type: "text", nullable: false),
                    tipo_cambio = table.Column<decimal>(type: "numeric", nullable: false),
                    p_descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    fecha_pago = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    referencia = table.Column<string>(type: "text", nullable: true),
                    importe = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto1 = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto2 = table.Column<decimal>(type: "numeric", nullable: false),
                    pagado = table.Column<bool>(type: "boolean", nullable: false),
                    saldo_anticipo = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ventas", x => x.id);
                    table.ForeignKey(
                        name: "fk_ventas_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "compras",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    folio = table.Column<string>(type: "text", nullable: false),
                    tipo_documento_id = table.Column<int>(type: "integer", nullable: false),
                    almacen_id = table.Column<int>(type: "integer", nullable: true),
                    fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    proveedor_id = table.Column<Guid>(type: "uuid", nullable: true),
                    forma_pago_id = table.Column<int>(type: "integer", nullable: true),
                    divisa = table.Column<string>(type: "text", nullable: false),
                    tipo_cambio = table.Column<decimal>(type: "numeric", nullable: false),
                    p_descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    fecha_pago = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    referencia = table.Column<string>(type: "text", nullable: true),
                    importe = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto1 = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto2 = table.Column<decimal>(type: "numeric", nullable: false),
                    documento_relacionado_id = table.Column<Guid>(type: "uuid", nullable: true),
                    pagado = table.Column<bool>(type: "boolean", nullable: false),
                    saldo_anticipo = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_compras", x => x.id);
                    table.ForeignKey(
                        name: "fk_compras_proveedores_proveedor_id",
                        column: x => x.proveedor_id,
                        principalTable: "proveedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "articulo_unidad",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    articulo_id = table.Column<Guid>(type: "uuid", nullable: false),
                    unidad_id = table.Column<Guid>(type: "uuid", nullable: false),
                    factor_conversion = table.Column<decimal>(type: "numeric(18,4)", precision: 18, scale: 4, nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_articulo_unidad", x => x.id);
                    table.ForeignKey(
                        name: "fk_articulo_unidad_articulos_articulo_id",
                        column: x => x.articulo_id,
                        principalTable: "articulos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_articulo_unidad_unidades_unidad_id",
                        column: x => x.unidad_id,
                        principalTable: "unidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "venta_concepto",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    venta_id = table.Column<Guid>(type: "uuid", nullable: false),
                    articulo_id = table.Column<Guid>(type: "uuid", nullable: false),
                    precio = table.Column<decimal>(type: "numeric", nullable: false),
                    costo = table.Column<decimal>(type: "numeric", nullable: false),
                    costo_promedio = table.Column<decimal>(type: "numeric", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric", nullable: false),
                    pendiente = table.Column<decimal>(type: "numeric", nullable: false),
                    devueltos = table.Column<decimal>(type: "numeric", nullable: false),
                    descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto1 = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto2 = table.Column<decimal>(type: "numeric", nullable: false),
                    numero_serie = table.Column<string>(type: "text", nullable: true),
                    importe = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_venta_concepto", x => x.id);
                    table.ForeignKey(
                        name: "fk_venta_concepto_ventas_venta_id",
                        column: x => x.venta_id,
                        principalTable: "ventas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "compra_concepto",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    compra_id = table.Column<Guid>(type: "uuid", nullable: false),
                    articulo_id = table.Column<Guid>(type: "uuid", nullable: false),
                    precio = table.Column<decimal>(type: "numeric", nullable: false),
                    costo = table.Column<decimal>(type: "numeric", nullable: false),
                    costo_promedio = table.Column<decimal>(type: "numeric", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric", nullable: false),
                    pendiente = table.Column<decimal>(type: "numeric", nullable: false),
                    devueltos = table.Column<decimal>(type: "numeric", nullable: false),
                    descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto1 = table.Column<decimal>(type: "numeric", nullable: false),
                    impuesto2 = table.Column<decimal>(type: "numeric", nullable: false),
                    numero_serie = table.Column<string>(type: "text", nullable: true),
                    importe = table.Column<decimal>(type: "numeric", nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_compra_concepto", x => x.id);
                    table.ForeignKey(
                        name: "fk_compra_concepto_compras_compra_id",
                        column: x => x.compra_id,
                        principalTable: "compras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "precio",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    numero_lista = table.Column<int>(type: "integer", nullable: false),
                    articulo_unidad_id = table.Column<Guid>(type: "uuid", nullable: false),
                    importe_precio = table.Column<decimal>(type: "numeric(18,4)", precision: 18, scale: 4, nullable: false),
                    factor_costo = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    user = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_precio", x => x.id);
                    table.ForeignKey(
                        name: "fk_precio_articulo_unidad_articulo_unidad_id",
                        column: x => x.articulo_unidad_id,
                        principalTable: "articulo_unidad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_articulo_unidad_articulo_id_unidad_id",
                table: "articulo_unidad",
                columns: new[] { "articulo_id", "unidad_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_articulo_unidad_unidad_id",
                table: "articulo_unidad",
                column: "unidad_id");

            migrationBuilder.CreateIndex(
                name: "ix_compra_concepto_compra_id",
                table: "compra_concepto",
                column: "compra_id");

            migrationBuilder.CreateIndex(
                name: "ix_compras_proveedor_id",
                table: "compras",
                column: "proveedor_id");

            migrationBuilder.CreateIndex(
                name: "ix_precio_articulo_unidad_id_numero_lista",
                table: "precio",
                columns: new[] { "articulo_unidad_id", "numero_lista" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_venta_concepto_venta_id",
                table: "venta_concepto",
                column: "venta_id");

            migrationBuilder.CreateIndex(
                name: "ix_ventas_cliente_id",
                table: "ventas",
                column: "cliente_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "compra_concepto");

            migrationBuilder.DropTable(
                name: "departamentos");

            migrationBuilder.DropTable(
                name: "familias");

            migrationBuilder.DropTable(
                name: "lineas");

            migrationBuilder.DropTable(
                name: "precio");

            migrationBuilder.DropTable(
                name: "tipo_documentos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "venta_concepto");

            migrationBuilder.DropTable(
                name: "compras");

            migrationBuilder.DropTable(
                name: "articulo_unidad");

            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "articulos");

            migrationBuilder.DropTable(
                name: "unidades");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
