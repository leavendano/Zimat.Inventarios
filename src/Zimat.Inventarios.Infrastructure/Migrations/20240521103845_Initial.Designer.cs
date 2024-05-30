﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Zimat.Inventarios.Infrastructure.Data;

#nullable disable

namespace Zimat.Inventarios.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240521103845_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Zimat.Inventarios.Core.ContributorAggregate.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("boolean")
                        .HasColumnName("activo");

                    b.Property<string>("Categoria")
                        .HasColumnType("text")
                        .HasColumnName("categoria");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("clave");

                    b.Property<string>("Codigo")
                        .HasColumnType("text")
                        .HasColumnName("codigo");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Divisa")
                        .HasColumnType("text")
                        .HasColumnName("divisa");

                    b.Property<int>("Estatus")
                        .HasColumnType("integer")
                        .HasColumnName("estatus");

                    b.Property<decimal>("Existencia")
                        .HasColumnType("numeric")
                        .HasColumnName("existencia");

                    b.Property<decimal>("Factor1")
                        .HasColumnType("numeric")
                        .HasColumnName("factor1");

                    b.Property<decimal>("Factor2")
                        .HasColumnType("numeric")
                        .HasColumnName("factor2");

                    b.Property<decimal>("Factor3")
                        .HasColumnType("numeric")
                        .HasColumnName("factor3");

                    b.Property<decimal>("Factor4")
                        .HasColumnType("numeric")
                        .HasColumnName("factor4");

                    b.Property<decimal>("Factor5")
                        .HasColumnType("numeric")
                        .HasColumnName("factor5");

                    b.Property<string>("Familia")
                        .HasColumnType("text")
                        .HasColumnName("familia");

                    b.Property<decimal>("Impuesto1")
                        .HasColumnType("numeric")
                        .HasColumnName("impuesto1");

                    b.Property<decimal>("Impuesto2")
                        .HasColumnType("numeric")
                        .HasColumnName("impuesto2");

                    b.Property<string>("Linea")
                        .HasColumnType("text")
                        .HasColumnName("linea");

                    b.Property<string>("Marca")
                        .HasColumnType("text")
                        .HasColumnName("marca");

                    b.Property<decimal>("Maximo")
                        .HasColumnType("numeric")
                        .HasColumnName("maximo");

                    b.Property<decimal>("Minimo")
                        .HasColumnType("numeric")
                        .HasColumnName("minimo");

                    b.Property<string>("Modelo")
                        .HasColumnType("text")
                        .HasColumnName("modelo");

                    b.Property<string>("Numdep")
                        .HasColumnType("text")
                        .HasColumnName("numdep");

                    b.Property<string>("Numprov")
                        .HasColumnType("text")
                        .HasColumnName("numprov");

                    b.Property<string>("Numprov1")
                        .HasColumnType("text")
                        .HasColumnName("numprov1");

                    b.Property<string>("Numprov2")
                        .HasColumnType("text")
                        .HasColumnName("numprov2");

                    b.Property<string>("Numprov3")
                        .HasColumnType("text")
                        .HasColumnName("numprov3");

                    b.Property<decimal>("Precio1")
                        .HasColumnType("numeric")
                        .HasColumnName("precio1");

                    b.Property<decimal>("Precio2")
                        .HasColumnType("numeric")
                        .HasColumnName("precio2");

                    b.Property<decimal>("Precio3")
                        .HasColumnType("numeric")
                        .HasColumnName("precio3");

                    b.Property<decimal>("Precio4")
                        .HasColumnType("numeric")
                        .HasColumnName("precio4");

                    b.Property<decimal>("Precio5")
                        .HasColumnType("numeric")
                        .HasColumnName("precio5");

                    b.Property<decimal>("Reorden")
                        .HasColumnType("numeric")
                        .HasColumnName("reorden");

                    b.Property<bool>("Series")
                        .HasColumnType("boolean")
                        .HasColumnName("series");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("text")
                        .HasColumnName("ubicacion");

                    b.Property<DateTime>("Ultcomp")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ultcomp");

                    b.Property<DateTime>("Ultcomp1")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ultcomp1");

                    b.Property<DateTime>("Ultcomp2")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ultcomp2");

                    b.Property<DateTime>("Ultcomp3")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ultcomp3");

                    b.Property<decimal>("UltimoCosto")
                        .HasColumnType("numeric")
                        .HasColumnName("ultimo_costo");

                    b.Property<DateTime>("Ultvent")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ultvent");

                    b.Property<string>("Unidad")
                        .HasColumnType("text")
                        .HasColumnName("unidad");

                    b.Property<string>("Unidefa")
                        .HasColumnType("text")
                        .HasColumnName("unidefa");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Usuario")
                        .HasColumnType("text")
                        .HasColumnName("usuario");

                    b.Property<string>("Valdep")
                        .HasColumnType("text")
                        .HasColumnName("valdep");

                    b.HasKey("Id")
                        .HasName("pk_articulos");

                    b.ToTable("articulos", (string)null);
                });

            modelBuilder.Entity("Zimat.Inventarios.Core.ContributorAggregate.Contributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("Estatus")
                        .HasColumnType("integer")
                        .HasColumnName("estatus");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Usuario")
                        .HasColumnType("text")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("pk_contributors");

                    b.ToTable("contributors", (string)null);
                });

            modelBuilder.Entity("Zimat.Inventarios.Core.ContributorAggregate.Contributor", b =>
                {
                    b.OwnsOne("Zimat.Inventarios.Core.ContributorAggregate.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("ContributorId")
                                .HasColumnType("integer")
                                .HasColumnName("id");

                            b1.Property<string>("CountryCode")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("phone_number_country_code");

                            b1.Property<string>("Extension")
                                .HasColumnType("text")
                                .HasColumnName("phone_number_extension");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("phone_number_number");

                            b1.HasKey("ContributorId");

                            b1.ToTable("contributors");

                            b1.WithOwner()
                                .HasForeignKey("ContributorId")
                                .HasConstraintName("fk_contributors_contributors_id");
                        });

                    b.Navigation("PhoneNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
