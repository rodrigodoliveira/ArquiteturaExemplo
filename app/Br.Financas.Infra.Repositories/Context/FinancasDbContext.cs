using Br.Financas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br.Financas.Infra.Repositories.Context {
    public class FinancasDbContext : DbContext{

        public DbSet<Product> Products { get; set; }

        public FinancasDbContext(): base("FinancasConnectioString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new Map.ProductMap());
        }
    }
}
