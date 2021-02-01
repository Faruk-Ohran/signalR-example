using Microsoft.EntityFrameworkCore;
using SignalR_demo_dal.Configuration;
using SignalR_demo_dal.Domain;

namespace SignalR_demo_dal.Context
{
    public class SignalRDbContext : DbContext
    {
        public SignalRDbContext(DbContextOptions<SignalRDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}