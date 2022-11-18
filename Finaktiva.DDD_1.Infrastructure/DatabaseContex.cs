using Finaktiva.DDD_1.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Finaktiva.DDD_1.Infrastructure
{
    public class DatabaseContex:DbContext
    {
        public DatabaseContex(DbContextOptions<DatabaseContex> options) : base (options)
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(o =>
            {
                o.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Person>().OwnsOne(o => o.Name, conf =>
            {
                conf.Property(x => x.Value).HasColumnName("Name");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}