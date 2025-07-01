using Microsoft.EntityFrameworkCore;
using Sales_pwss.Web.Data.Entities;

namespace Sales_pwss.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}
