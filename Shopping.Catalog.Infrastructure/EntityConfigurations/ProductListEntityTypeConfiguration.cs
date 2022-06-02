using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopping.Catalogue.Domain.Models;

namespace Shopping.Catalogue.Infrastructure.EntityConfigurations
{
    internal class ProductListEntityTypeConfiguration : IEntityTypeConfiguration<ProductList>
    {
        public void Configure(EntityTypeBuilder<ProductList> configuration)
        {
            configuration.HasKey(x => x.Id);

            configuration.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            configuration.Property(x => x.Price)
                .IsRequired()
                .HasPrecision(15, 2);

            configuration.Property(x => x.ThumbnailImagePath)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
