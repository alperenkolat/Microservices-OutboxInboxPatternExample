using StockService.API.Consumers.Entities;

namespace StockService.API.Consumers.Contexts;
public class StockDbContext : DbContext
{
    public StockDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<OrderInbox> OrderInboxes { get; set; }
}