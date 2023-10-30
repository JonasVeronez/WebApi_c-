

using forkLift.Model;
using Microsoft.EntityFrameworkCore;

namespace forkLift.Data
{
    public class ForkLiftContext : DbContext
    {
        public ForkLiftContext(DbContextOptions<ForkLiftContext> options) : base(options)
        {
        }
        public DbSet<ForkLift> ForkLifts{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var forklift =  modelBuilder.Entity<ForkLift>();
            forklift.ToTable("ForkLift");
            forklift.HasKey(x => x.id);
            forklift.Property(x => x.id).HasColumnName("Id").ValueGeneratedOnAdd();
            forklift.Property(x => x.forklift).HasColumnName("Nome").IsRequired();
        }

    }
}