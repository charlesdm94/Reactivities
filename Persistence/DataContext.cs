using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        // If DbSet<IEntity> properties have a public setter, they're automatically initialized when the instance of the derived context is created
        // base refers to the DbContext parent constructor
        public DataContext(DbContextOptions options) : base(options){

        }

        // Activities will be the name of the table/obj in the database
        public DbSet<Activity> Activities {get; set;}
    }
}