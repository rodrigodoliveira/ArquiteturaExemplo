using Br.Financas.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Br.Financas.Infra.Repositories.Map {
    public class ProductMap : EntityTypeConfiguration<Product> {

        public ProductMap()
        {
            ToTable("Product");
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.Price).IsRequired().HasPrecision(10, 2);
        }
    }
}
