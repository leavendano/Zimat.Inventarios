using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.VentaAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
internal class VentaConceptoConfiguration : IEntityTypeConfiguration<VentaConcepto>
{
  public void Configure(EntityTypeBuilder<VentaConcepto> builder)
  {
    

    builder.Property(x => x.VentaId).HasColumnType("uuid");

    builder.Property(x => x.Id).HasColumnType("uuid");
        
  }
}
