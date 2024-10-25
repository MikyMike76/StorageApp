using Microsoft.EntityFrameworkCore;
using StorageApp.Entities;

namespace StorageApp.Data
{
    public  class StorageAppDbContext : DbContext
    {
        public DbSet<Medicine> Medicines => Set<Medicine>();
        public DbSet<Offers> Offers => Set<Offers>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
