using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.Core.CompraAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
internal class CompraConceptoConfiguration : IEntityTypeConfiguration<CompraConcepto>
{
  public void Configure(EntityTypeBuilder<CompraConcepto> builder)
  {

    //builder.HasOne<Compra>()
    //    .WithMany()
    //    .HasPrincipalKey(x => x.Id);

    builder.Property(x => x.CompraId).HasColumnType("uuid");

    builder.Property(x => x.Id).HasColumnType("uuid");

  }
}
