using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using Core.Domain.LinkingTables;

namespace Persistence.EntityConfigurations
{
    public class CarAttributesLinkConfiguration : EntityTypeConfiguration<CarAttributesLink>
    {
        public CarAttributesLinkConfiguration()
        {
            HasRequired(c => c.Attributes)
                .WithMany(a => a.CarAttributesLinks)
                .HasForeignKey(c => c.AttributesId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Car)
                .WithMany(c => c.CarAttributesLinks)
                .HasForeignKey(c => c.CarId)
                .WillCascadeOnDelete(false);
        }
    }
}