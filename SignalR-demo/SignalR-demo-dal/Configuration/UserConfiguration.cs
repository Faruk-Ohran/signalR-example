using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR_demo_dal.Domain;
using System.Collections.Generic;

namespace SignalR_demo_dal.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.FirstName)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .IsRequired();

            builder
                .HasMany(p => p.Devices)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            builder
                .HasData(new List<User> {
                    new User { Id = 1, FirstName = "Faruk", LastName = "Ohran"}
                });
        }
    }
}