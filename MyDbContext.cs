using Microsoft.EntityFrameworkCore;

namespace testdocker
{
    public class MyDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MyDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = "server=testdocker_db_1;port=3306;database=test;user=root;password=1;";
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<User> Users { get; set; }
    }
}
