using Microsoft.EntityFrameworkCore;
using YourSovereignLedger.Core;

namespace YourSovereignLedger.Data.Context;

public class AppDBContext : DbContext
{
    public AppDBContext() { }

    public DbSet<CatalogItem> CatalogItems { get; set; }
    public DbSet<CommissionSlot> CommissionSlots { get; set; }
    public DbSet<CustomerContactInfo> ContactInfos { get; set; }
    public DbSet<CustomerProfile> CustomerProfiles { get; set; }
    public DbSet<OrderLineItem> LineItems { get; set; }
    public DbSet<SaleOrder> SaleOrders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
