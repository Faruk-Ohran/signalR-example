using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalR_demo_dal.Domain;
using System.Collections.Generic;

namespace SignalR_demo_dal.Configuration
{
    public class DeviceConfiguration : BaseEntityConfiguration<Device>
    {
        public override void Configure(EntityTypeBuilder<Device> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.Name)
                .IsRequired();

            builder
                .Property(p => p.Manufacturer)
                .IsRequired();

            builder
                .HasOne(p => p.User)
                .WithMany(p => p.Devices)
                .HasForeignKey(p => p.Id);

            builder
                .HasData(new List<Device>
                {
                    new Device { Id = 1, Name = "Device1", Manufacturer = "Manufacturer1", UserId = 1},
                    new Device { Id = 2, Name = "Device2", Manufacturer = "Manufacturer2", UserId = 1},
                    new Device { Id = 3, Name = "Device3", Manufacturer = "Manufacturer3", UserId = 1},
                });
        }
    }
}