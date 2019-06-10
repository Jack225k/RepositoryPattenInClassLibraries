
using System.Data.Entity;
using Core.Domain;
using Core.Domain.LinkingTables;
using Persistence.EntityConfigurations;

namespace Persistence
{
    public class CarShopContext : DbContext
    {
        public CarShopContext() : base("name=CarShopContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Core.Domain.Attribute> Attributes { get; set; }
        public virtual DbSet<CarAttributesLink> CarAttributeLinks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarConfiguration());
            modelBuilder.Configurations.Add(new CarAttributesLinkConfiguration());
        }
    }
}