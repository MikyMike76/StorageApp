using Microsoft.EntityFrameworkCore;
using StorageApp.Entities;

namespace StorageApp.Data
{
    public  class StorageAppDbContext : DbContext
    {
        public DbSet<Medicine> Medicines => Set<Medicine>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
