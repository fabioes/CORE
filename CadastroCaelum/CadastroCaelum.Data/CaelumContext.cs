using Microsoft.EntityFrameworkCore;

namespace CadastroCaelum.Data
{
    public class CaelumContext : DbContext
    {
        public CaelumContext(DbContextOptions<CaelumContext> options)
            : base(options)
        { }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
      
            modelBuilder.Entity<Aluno>().HasMany(b => b.Curso).WithOne();
        }

    }
}
