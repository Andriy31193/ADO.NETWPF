using Caffe.Models;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Data
{
    public class BaseDbContext : DbContext
    {
        public DbSet<User> Waiters { get; set; }
        public DbSet<UserAcessLevel> UserAcessLevels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            _ = optionsBuilder.UseSqlite(@"Filename=D:\f\caffe.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _ = modelBuilder.Entity<User>().HasData(new User[] { User.DefaultAdmin });
            _ = modelBuilder.Entity<UserAcessLevel>().HasData(new UserAcessLevel[] { UserAcessLevel.DefaultAdminAcessLevel });
        }
    }
}
