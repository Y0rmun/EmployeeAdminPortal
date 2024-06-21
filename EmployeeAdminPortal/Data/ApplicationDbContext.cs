using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            //                                          вот это имя указывай в файле .json
            //                                                            ||
            //                                                            \/
            options.UseNpgsql(Configuration.GetConnectionString("DeafultConnection"));
        }

        public DbSet<Employee> Employee { get; set; }

    }
}
