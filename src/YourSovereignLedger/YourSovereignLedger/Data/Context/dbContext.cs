using Microsoft.EntityFrameworkCore;

namespace YourSovereignLedger.Data.Context
{
    public class dbContext : DbContext
    {
        public dbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
