using EES.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EES.Database
{
    public class EESContext : DbContext
    {
        public DbSet<DtEmployee> DtEmployee { get; set; }

        public DbSet<MstBelong> MstBelong { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(new DbConnection().GetConnectionString());
    }
}
