namespace Br.Financas.Infra.Repositories.Migrations
{
    using Context;
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinancasDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FinancasDbContext context)
        {

            var productExemplo = new Product()
            {
                Name = "Produto Exemplo",
                Price = 1
            };
            context.Products.AddOrUpdate(productExemplo);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
