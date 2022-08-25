using Microsoft.EntityFrameworkCore;

namespace Rest_API_With_ASP_NET.Model.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext()
        {
        
        }
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
    }
}
