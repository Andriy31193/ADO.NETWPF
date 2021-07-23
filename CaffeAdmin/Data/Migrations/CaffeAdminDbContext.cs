using Cafe.Data;
using Microsoft.EntityFrameworkCore;

namespace CaffeAdmin
{
    public class CaffeAdminDbContext : BaseDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            _ = optionsBuilder.UseSqlite(@"Filename=D:\f\caffe.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
