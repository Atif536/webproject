using Microsoft.EntityFrameworkCore;

namespace Sunfiit_2._0v.Models
{
    public class db : DbContext
    {
        public db(DbContextOptions<db> options) : base(options)
        {

        }
        public DbSet<login> login2 { get; set; }
    }

}
