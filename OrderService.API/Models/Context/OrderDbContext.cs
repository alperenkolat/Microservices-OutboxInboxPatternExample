namespace OrderService.API.Models.Context;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<OrderOutbox> OrderOutboxes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}