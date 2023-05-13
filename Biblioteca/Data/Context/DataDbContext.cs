using Data.Mappings;
using UserClass.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DataDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
