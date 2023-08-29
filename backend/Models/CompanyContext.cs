
using Microsoft.EntityFrameworkCore;

namespace DesafioFULLApi.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt)
        {

        }

        public DbSet<Company> Companys { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
               .HasKey(d => new { d.CompanyId, d.Id });

            modelBuilder.Entity<Supplier>()
                .HasOne(debt => debt.Company)
                .WithMany(title => title.Suppliers)
                .HasForeignKey(debt => debt.CompanyId)
                .HasConstraintName("ForeignKey_Suppliers_Company");

            modelBuilder.Entity<Company>().HasMany(td => td.Suppliers);
        }
    }
}
