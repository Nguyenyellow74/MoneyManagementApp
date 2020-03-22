using Microsoft.EntityFrameworkCore;

namespace MoneyManagementWebApp.Models
{
    public class MoneyManagementContext : DbContext
    {
        public DbSet<User> Users { get; set;}
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Receiving> Receivings { get; set; }
        public DbSet<Spending> Spendings { get; set; }

        public MoneyManagementContext (DbContextOptions<MoneyManagementContext> options) : base(options) {
            
        }
    }
}