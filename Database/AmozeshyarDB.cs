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
    }
}