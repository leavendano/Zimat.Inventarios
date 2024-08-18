using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.Core.DocumentoAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
internal class DocumentoConceptoConfiguration : IEntityTypeConfiguration<DocumentoConcepto>
{
  public void Configure(EntityTypeBuilder<DocumentoConcepto> builder)
  {
    
    //builder.HasOne<Documento>()
    //    .WithMany()
    //    .HasPrincipalKey(x => x.Id);

    builder.Property(x => x.DocumentoId).HasColumnType("uuid");

    builder.Property(x => x.Id).HasColumnType("uuid");
        
  }
}
