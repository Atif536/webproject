using Microsoft.EntityFrameworkCore;

namespace Sunfiit_2._0v.Models
{
    public class dbset:DbContext
    {
        public dbset(DbContextOptions<dbset> options):base(options)
        { 

        }
        public DbSet<item> items { get; set; }

    }
}
