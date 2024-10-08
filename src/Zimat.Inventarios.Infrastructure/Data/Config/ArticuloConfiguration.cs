﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Infrastructure.Data.Config;
public class ArticuloConfiguration : IEntityTypeConfiguration<Articulo>
{
  public void Configure(EntityTypeBuilder<Articulo> builder)
  {
    builder.Property(p => p.Descripcion)
        .HasMaxLength(DataSchemaConstants.DEFAULT_DESCRIPTION_LENGTH)
        .IsRequired();
    
  builder.Property(x => x.Id).HasColumnType("uuid");      
    //builder.OwnsOne(builder => builder.Clave);

    //builder.Property(x => x.Status)
    //  .HasConversion(
    //      x => x.Value,
    //      x => ContributorStatus.FromValue(x));
  }
}

