using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class DatabaseContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public DatabaseContext() { }

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite(_configuration.GetConnectionString("sqlite"));
            optionsBuilder.UseSqlite("Data source=product_catalog.db");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Camera> Cameras { get; set; }
    }
}