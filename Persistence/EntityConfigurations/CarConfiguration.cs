using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using Core.Domain;

namespace Persistence.EntityConfigurations
{
    //Fluent API Configuration
    public class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            Property(c => c.CarMake)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.CarModel)
                .IsRequired()
                .HasMaxLength(150);


            HasMany(c => c.Shops)
                .WithMany(t => t.Cars)
                .Map(m =>
                {
                    m.ToTable("CarShopTable");
                    m.MapLeftKey("CarId");
                    m.MapRightKey("ShopId");
                });
        }
    }
}