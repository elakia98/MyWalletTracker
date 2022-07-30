using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyWalletTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<WalletHolder>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<WalletDetails> WalletDetails { get; set; }

    }
}