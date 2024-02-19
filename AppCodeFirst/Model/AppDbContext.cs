using Microsoft.EntityFrameworkCore;

namespace AppCodeFirst.Model
{
    public  class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=cs140211-codefirst;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=AppDBFirst");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }

    }
}
