using Microsoft.EntityFrameworkCore;

namespace Amozeshyar.Database
{
    public class AmozeshyarDB : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FinancialTransaction> FinancialTransactions { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<PreRegisteration> PreRegisterations { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Register> Registers { get; set; }
        public AmozeshyarDB(DbContextOptions<AmozeshyarDB>options)
            :base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Intern>()
            .HasIndex(m=>m.Mobile)
            .IsUnique(true);
            modelBuilder.Entity<Professor>()
            .HasIndex(m=>m.Mobile)
            .IsUnique(true);
        }
    }
}