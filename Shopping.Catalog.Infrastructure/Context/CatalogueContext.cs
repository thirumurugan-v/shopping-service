using Microsoft.EntityFrameworkCore;
using Shopping.Catalogue.Domain.Models;
using Shopping.Catalogue.Infrastructure.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Catalogue.Infrastructure.Context
{
    public class CatalogueContext : DbContext
    {
        public DbSet<ProductList> ProductList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductListEntityTypeConfiguration());
        }

        public CatalogueContext(DbContextOptions<CatalogueContext> options) : base(options)
        {

        }
    }
}
