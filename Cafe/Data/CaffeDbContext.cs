using Microsoft.EntityFrameworkCore;
using Cafe.Data;
namespace Cafe
{
    public class CaffeDbContext : BaseDbContext
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
